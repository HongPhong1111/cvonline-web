using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

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

        public string HtmlTemplate { get; set; }
        public string CssTemplate { get; set; }
        public int TemplateId { get; set; }
        public string JobTitle { get; set; }
        public string BirthDate { get; set; }
        public string Gender { get; set; }
        public string TemplateName { get; set; }
        public string PreviewImageUrl { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Website { get; set; }
        public IFormFile Photo { get; set; }
        public string PhotoUrl { get; set; }
    }
}