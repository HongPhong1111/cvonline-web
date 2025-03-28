using CVOnline.Web.Models.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CVOnline.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CV> CVs { get; set; }
        public DbSet<CVTemplate> CVTemplates { get; set; }
        public DbSet<CVShare> CVShares { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            // Cấu hình quan hệ giữa các entity
            builder.Entity<CV>()
                .HasOne(c => c.User)
                .WithMany(u => u.CVs)
                .HasForeignKey(c => c.UserId);

            builder.Entity<CV>()
                .HasOne(c => c.Template)
                .WithMany(t => t.CVs)
                .HasForeignKey(c => c.TemplateId);

            // Cấu hình CVShare để tránh lỗi multiple cascade paths
            builder.Entity<CVShare>()
                .HasOne(cs => cs.CV)
                .WithMany()
                .HasForeignKey(cs => cs.CVId)
                .OnDelete(DeleteBehavior.NoAction); // Tránh vòng lặp khi xóa

            builder.Entity<CVShare>()
                .HasOne(cs => cs.User)
                .WithMany()
                .HasForeignKey(cs => cs.UserId)
                .OnDelete(DeleteBehavior.Cascade); // Chỉ cascade ở 1 bên

            // Seed dữ liệu mẫu CV
            builder.Entity<CVTemplate>().HasData(
                new CVTemplate 
                { 
                    Id = 1, 
                    Name = "Simple", 
                    PreviewImageUrl = "/images/templates/simple.jpg", 
                    HtmlTemplate = "<div>Simple HTML Template</div>",
                    CssTemplate = ".simple { color: black; }", 
                    Category = "Simple", 
                    UsageCount = 0 
                },
                new CVTemplate 
                { 
                    Id = 2, 
                    Name = "Professional", 
                    PreviewImageUrl = "/images/templates/professional.jpg", 
                    HtmlTemplate = "<div>Professional HTML Template</div>",
                    CssTemplate = ".professional { color: blue; }", 
                    Category = "Office Worker", 
                    UsageCount = 0 
                },
                new CVTemplate 
                { 
                    Id = 3, 
                    Name = "Creative", 
                    PreviewImageUrl = "/images/templates/creative.jpg", 
                    HtmlTemplate = "<div>Creative HTML Template</div>",
                    CssTemplate = ".creative { color: green; }", 
                    Category = "Colorful", 
                    UsageCount = 0 
                },
                new CVTemplate 
                { 
                    Id = 4, 
                    Name = "Timeline", 
                    PreviewImageUrl = "/images/templates/timeline.jpg", 
                    HtmlTemplate = "<div>Timeline HTML Template</div>",
                    CssTemplate = ".timeline { color: orange; }", 
                    Category = "Timeline", 
                    UsageCount = 0 
                },
                new CVTemplate 
                { 
                    Id = 5, 
                    Name = "Modern", 
                    PreviewImageUrl = "/images/templates/modern.jpg", 
                    HtmlTemplate = "<div>Modern HTML Template</div>",
                    CssTemplate = ".modern { color: purple; }", 
                    Category = "Experiencer", 
                    UsageCount = 0 
                },
                new CVTemplate 
                { 
                    Id = 6, 
                    Name = "Minimalist", 
                    PreviewImageUrl = "/images/templates/minimalist.jpg", 
                    HtmlTemplate = "<div>Minimalist HTML Template</div>",
                    CssTemplate = ".minimalist { color: gray; }", 
                    Category = "No Photo", 
                    UsageCount = 0 
                },
                new CVTemplate 
                { 
                    Id = 7, 
                    Name = "Classic", 
                    PreviewImageUrl = "/images/templates/classic.jpg", 
                    HtmlTemplate = "<div>Classic HTML Template</div>",
                    CssTemplate = ".classic { color: brown; }", 
                    Category = "Toàn bộ", 
                    UsageCount = 0 
                },
                new CVTemplate 
                { 
                    Id = 8, 
                    Name = "Corporate", 
                    PreviewImageUrl = "/images/templates/corporate.jpg", 
                    HtmlTemplate = "<div>Corporate HTML Template</div>",
                    CssTemplate = ".corporate { color: navy; }", 
                    Category = "Office Worker", 
                    UsageCount = 0 
                },
                new CVTemplate 
                { 
                    Id = 9, 
                    Name = "Academic", 
                    PreviewImageUrl = "/images/templates/academic.jpg", 
                    HtmlTemplate = "<div>Academic HTML Template</div>",
                    CssTemplate = ".academic { color: maroon; }", 
                    Category = "Fresher", 
                    UsageCount = 0 
                },
                new CVTemplate 
                { 
                    Id = 10, 
                    Name = "Technical", 
                    PreviewImageUrl = "/images/templates/technical.jpg", 
                    HtmlTemplate = "<div>Technical HTML Template</div>",
                    CssTemplate = ".technical { color: teal; }", 
                    Category = "Experiencer", 
                    UsageCount = 0 
                }
            );
        }
    }
}