using System;

namespace CVOnline.Web.Models.Domain
{
    public class CVShare
    {
        public int Id { get; set; }
        public string ShareToken { get; set; }
        public int CVId { get; set; }
        public CV CV { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public bool IsPasswordProtected { get; set; }
        public string? Password { get; set; }
    }
}