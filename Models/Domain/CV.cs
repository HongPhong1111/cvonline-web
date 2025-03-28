using Microsoft.AspNetCore.Identity;

namespace CVOnline.Web.Models.Domain
{
    public class CV
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public int TemplateId { get; set; }
        public CVTemplate Template { get; set; }
    }
}