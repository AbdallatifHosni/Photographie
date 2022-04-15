using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Photography.Models
{
    public class Work
    {
        [Key]
        public int WorkId { get; set; }
        [Required]
        public string? Description { get; set; }
        [ForeignKey("ClientId")]
        public int ClientId { get; set; }
        public virtual ICollection<Client>? clients { get; set; }

    }
}
