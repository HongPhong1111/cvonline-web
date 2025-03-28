namespace CVOnline.Web.Models.Domain
{
    public class CVTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PreviewImageUrl { get; set; }
        public string? HtmlTemplate { get; set; }
        public string? CssTemplate { get; set; }
        public string Category { get; set; }
        public int UsageCount { get; set; }
        public ICollection<CV> CVs { get; set; }
    }
}