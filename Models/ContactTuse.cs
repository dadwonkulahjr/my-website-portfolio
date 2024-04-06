using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mypersonalwebsite.Models
{
    public class ContactTuse
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name field is required.")]
        [Column(TypeName = "nvarchar(50)")]
        [MaxLength(25)]
        public required string Name { get; set; }

        [EmailAddress(ErrorMessage = "Please enter a valid email address."), Required(ErrorMessage = "Email field is required."), DataType(DataType.EmailAddress)]
        public required string Email { get; set; }

        [Required(ErrorMessage = "Please enter a message."), DataType(DataType.MultilineText)]
        [MaxLength(255)]
        [Column(TypeName = "nvarchar(255)")]
        public required string Message { get; set; }
    }
}
