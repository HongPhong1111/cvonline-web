using System.ComponentModel.DataAnnotations;

namespace CVOnline.Web.Models.ViewModels
{
    public class ManageViewModel
    {
        [Required(ErrorMessage = "Vui lòng nhập FullName")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập email")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public string Email { get; set; }

        public string Address { get; set; }

        public string? AvatarUrl { get; set; }
    }
}