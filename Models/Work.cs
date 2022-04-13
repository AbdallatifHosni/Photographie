using System.ComponentModel.DataAnnotations;

namespace Photography.Models
{
    public class Work
    {
        [Key]
        public int WorkId { get; set; }
        public string? Description { get; set; }
    }
}
