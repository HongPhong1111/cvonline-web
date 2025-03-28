using System.ComponentModel.DataAnnotations;

namespace CVOnline.Web.Models.ViewModels
{
    public class CreateCVViewModel
    {
        [Required(ErrorMessage = "Vui lòng nhập tiêu đề CV")]
        [Display(Name = "Tiêu đề CV")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập nội dung CV")]
        [Display(Name = "Nội dung CV")]
        [DataType(DataType.Html)]
        public string Content { get; set; }


        public int TemplateId { get; set; }
        public string TemplateName { get; set; }
        public string PreviewImageUrl { get; set; }

        // Thông tin cá nhân để điền sẵn
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}