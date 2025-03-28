using System.ComponentModel.DataAnnotations;

namespace CVOnline.Web.Models.ViewModels
{
    public class EditCVViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tiêu đề CV")]
        [Display(Name = "Tiêu đề CV")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập nội dung CV")]
        [Display(Name = "Nội dung CV")]
        public string Content { get; set; }

        public int TemplateId { get; set; }
        public string TemplateName { get; set; }
    }
}