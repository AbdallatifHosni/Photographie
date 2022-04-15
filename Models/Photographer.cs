using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Photography.Models
{
    public class Photographer
    {
        public Photographer()
        {
            client =new HashSet<Client>();
        }
        [Key]
        public int PhotographerId { get; set; }
        public string? Name { get; set; }
        public string? ImageUser { get; set; }
        [Required]
        [Column(TypeName = "Varchar(MAX)")]
        public string? bio { get; set; }
        [Required]
        [Column(TypeName = "Varchar(30)")]
        public string Address { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.EmailAddress)]
        [Column("Email-Adress", TypeName = "Varchar(35)")]
        public string Email { get; set; } = string.Empty;
        [ForeignKey("ClientId")]
        public int ClientId { get; set; }
        public  ICollection< Client>? client { get; set; }
    }
}
