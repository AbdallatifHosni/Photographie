using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Photography.Models
{

    public class Client
    {
        public Client()
        {
            photographer=new HashSet<Photographer>();
        }

        [Key]
        public int ClientId { get; set; }
        [Column(TypeName = "Varchar(25)")]
        public string Name { get; set; }
        [Required]
        public string ImageUser { get; set; }
        [Required]
        [Column("Address",TypeName ="Varchar(30)")]
        public string Address { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [Column("Email-Adress" , TypeName = "Varchar(35)")]
        public string Email { get; set; }
        public ICollection<Photographer>? photographer  { get; set; }
    }
}
