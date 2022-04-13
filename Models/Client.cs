using System.ComponentModel.DataAnnotations;

namespace Photography.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        public string? Name { get; set; }
        public string? ImageUser { get; set; }
        public string Address { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public ICollection<Photographer>? photographer  { get; set; }
    }
}
