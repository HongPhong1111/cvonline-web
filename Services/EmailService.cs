using MailKit.Net.Smtp;
using MimeKit;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using MailKit.Security; // Thêm namespace này để sử dụng SecureSocketOptions

namespace CVOnline.Web.Services
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _configuration;

        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendEmailAsync(string toEmail, string subject, string body)
        {
            // Kiểm tra các giá trị cấu hình và cung cấp giá trị mặc định nếu null
            string smtpHost = _configuration["Smtp:Host"] ?? throw new InvalidOperationException("Smtp:Host is not configured.");
            string portString = _configuration["Smtp:Port"];
            string username = _configuration["Smtp:Email"];
            string password = _configuration["Smtp:Password"];

            // Kiểm tra và parse port
            if (string.IsNullOrEmpty(portString) || !int.TryParse(portString, out int port))
            {
                throw new InvalidOperationException("Smtp:Port is not configured or invalid.");
            }

            // Kiểm tra toEmail
            if (string.IsNullOrEmpty(toEmail))
            {
                throw new ArgumentNullException(nameof(toEmail), "Recipient email cannot be null or empty.");
            }

            // Tạo email message
            var email = new MimeMessage();
            email.From.Add(new MailboxAddress("CVOnline", username));
            email.To.Add(new MailboxAddress("", toEmail));
            email.Subject = subject;

            var bodyBuilder = new BodyBuilder { HtmlBody = body };
            email.Body = bodyBuilder.ToMessageBody();

            // Gửi email bằng MailKit
            using var smtpClient = new SmtpClient();
            try
            {
                // Sử dụng SecureSocketOptions.StartTls cho cổng 587
                await smtpClient.ConnectAsync(smtpHost, port, SecureSocketOptions.StartTls);
                await smtpClient.AuthenticateAsync(username, password);
                await smtpClient.SendAsync(email);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to send email: {ex.Message}", ex);
            }
            finally
            {
                await smtpClient.DisconnectAsync(true);
            }
        }
    }

    public interface IEmailService
    {
        Task SendEmailAsync(string recipientEmail, string subject, string messageBody);
    }
}