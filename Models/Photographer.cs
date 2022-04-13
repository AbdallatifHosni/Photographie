using System.ComponentModel.DataAnnotations;

namespace Photography.Models
{
    public class Photographer
    {
        [Key]
        public int ClientId { get; set; }
        public string? Name { get; set; }
        public string? ImageUser { get; set; }
        public string? bio { get; set; }
        public string Address { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public  ICollection< Client>? client { get; set; }
    }
}
