using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CVOnline.Web.Data;
using CVOnline.Web.Models.Domain;
using CVOnline.Web.Models.ViewModels;
using CVOnline.Web.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Encodings.Web;

namespace CVOnline.Web.Controllers
{
    public class ShareController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IEmailService _emailService;
        private readonly IConfiguration _configuration;
        private readonly HtmlEncoder _htmlEncoder;

        public ShareController(
            ApplicationDbContext context,
            IEmailService emailService,
            IConfiguration configuration,
            HtmlEncoder htmlEncoder)
        {
            _context = context;
            _emailService = emailService;
            _configuration = configuration;
            _htmlEncoder = htmlEncoder;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Index(int? id = null)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized("Bạn cần đăng nhập để truy cập trang này.");
            }

            if (id.HasValue)
            {
                var cv = await _context.CVs
                    .Include(c => c.User)
                    .FirstOrDefaultAsync(c => c.Id == id.Value && c.UserId == userId);

                if (cv == null)
                {
                    return NotFound("Không tìm thấy CV hoặc bạn không có quyền truy cập.");
                }

                var model = new ShareCVViewModel
                {
                    CVId = cv.Id,
                    Subject = $"Xem CV của {cv.User?.FullName ?? "Người dùng"}"
                };

                return View("ShareCV", model);
            }

            var cvs = await _context.CVs
                .Include(c => c.User)
                .Where(c => c.UserId == userId)
                .ToListAsync();

            return View("Index", cvs); // Trả về view Index thay vì ShareCV
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> ShareByEmail(ShareCVViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("ShareCV", model);
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized("Bạn cần đăng nhập để truy cập trang này.");
            }

            var cv = await _context.CVs
                .Include(c => c.User)
                .FirstOrDefaultAsync(c => c.Id == model.CVId && c.UserId == userId);

            if (cv == null)
            {
                return NotFound();
            }

            var shareToken = Guid.NewGuid().ToString();
            var cvShare = new CVShare
            {
                ShareToken = shareToken,
                CVId = cv.Id,
                UserId = userId,
                CreatedDate = DateTime.Now,
                ExpiryDate = DateTime.Now.AddDays(30)
            };

            _context.CVShares.Add(cvShare);
            await _context.SaveChangesAsync();

            var appUrl = _configuration["ApplicationUrl"] ?? "http://localhost:5135";
            var shareUrl = $"{appUrl}/Share/ViewSharedCV/{shareToken}";

            var messageBody = $@"
        <h2>{model.Subject}</h2>
        <p>{model.Message ?? "Không có tin nhắn."}</p>
        <p>Bạn đã nhận được một CV được chia sẻ từ {cv.User?.FullName ?? "Người dùng"}.</p>
        <p>Nhấp vào liên kết bên dưới để xem CV:</p>
        <a href='{shareUrl}' style='display: inline-block; background-color: #4CAF50; color: white; padding: 10px 20px; text-decoration: none; border-radius: 4px;'>Xem CV</a>
        <p>Liên kết có hiệu lực đến ngày {cvShare.ExpiryDate?.ToString("dd/MM/yyyy") ?? "Không xác định"}.</p>
    ";

            try
            {
                await _emailService.SendEmailAsync(model.RecipientEmail, model.Subject, messageBody);
                TempData["SuccessMessage"] = "CV đã được chia sẻ thành công qua email.";
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "Có lỗi xảy ra khi gửi email. Vui lòng thử lại sau.";
                Console.WriteLine($"Error sending email: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                }
                return View("ShareCV", model);
            }

            return RedirectToAction("Index", "Share"); // Chuyển hướng về Index trong ShareController
        }

        [HttpGet]
        public async Task<IActionResult> ViewSharedCV(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                Console.WriteLine("Share token is null or empty.");
                return NotFound("Liên kết không hợp lệ.");
            }

            var share = await _context.CVShares
                .Include(s => s.CV)
                .ThenInclude(c => c.Template)
                .Include(s => s.User)
                .FirstOrDefaultAsync(s => s.ShareToken == id);

            if (share == null || share.CV == null)
            {
                Console.WriteLine($"No CVShare found for token: {id}");
                return NotFound("Không tìm thấy CV được chia sẻ.");
            }

            if (share.ExpiryDate.HasValue && share.ExpiryDate.Value < DateTime.Now)
            {
                Console.WriteLine($"Share link expired for token: {id}. Expiry date: {share.ExpiryDate}");
                return View("Expired");
            }

            if (share.CV.Template == null)
            {
                Console.WriteLine($"Template is null for CV ID: {share.CV.Id}");
                return View("Error", new { Message = "Không tìm thấy template cho CV này." });
            }

            // Bỏ phần mã hóa HTML và CSS
            // share.CV.Template.HtmlTemplate = _htmlEncoder.Encode(share.CV.Template.HtmlTemplate ?? string.Empty);
            // share.CV.Template.CssTemplate = _htmlEncoder.Encode(share.CV.Template.CssTemplate ?? string.Empty);

            return View("ViewSharedCV", share.CV);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetShareLink(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized("Bạn cần đăng nhập để truy cập trang này.");
            }

            var cv = await _context.CVs
                .FirstOrDefaultAsync(c => c.Id == id && c.UserId == userId);

            if (cv == null)
            {
                return NotFound();
            }

            var existingShare = await _context.CVShares
                .FirstOrDefaultAsync(s => s.CVId == id && s.UserId == userId);

            if (existingShare == null)
            {
                var shareToken = Guid.NewGuid().ToString();
                existingShare = new CVShare
                {
                    ShareToken = shareToken,
                    CVId = cv.Id,
                    UserId = userId,
                    CreatedDate = DateTime.Now,
                    ExpiryDate = DateTime.Now.AddDays(30)
                };
                _context.CVShares.Add(existingShare);
                await _context.SaveChangesAsync();

                existingShare = await _context.CVShares
                    .FirstOrDefaultAsync(s => s.CVId == id && s.UserId == userId);
            }

            if (existingShare == null)
            {
                return NotFound("Không thể tạo link chia sẻ.");
            }

            var appUrl = _configuration["ApplicationUrl"] ?? "http://localhost:5135";
            var shareUrl = $"{appUrl}/Share/ViewSharedCV/{existingShare.ShareToken}";
            return Json(new { shareUrl });
        }
    }
}