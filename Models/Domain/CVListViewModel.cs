using CVOnline.Web.Models.Domain;

namespace CVOnline.Web.Models.ViewModels
{
    public class CVListViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int TemplateId { get; set; }
        public CVTemplate Template { get; set; }
    }
}