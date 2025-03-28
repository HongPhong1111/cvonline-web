using System.ComponentModel.DataAnnotations;

namespace CVOnline.Web.Models.ViewModels
{
    public class ShareCVViewModel
    {
        public int CVId { get; set; }
        
        [Display(Name = "Email người nhận")]
        [Required(ErrorMessage = "Vui lòng nhập email người nhận")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public string RecipientEmail { get; set; }
        
        [Display(Name = "Tiêu đề")]
        [Required(ErrorMessage = "Vui lòng nhập tiêu đề")]
        public string Subject { get; set; }
        
        [Display(Name = "Tin nhắn")]
        public string Message { get; set; }
    }
}