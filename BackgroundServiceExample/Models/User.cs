using System.ComponentModel.DataAnnotations;

namespace BackgroundServiceExample.Models
{
    public class User
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
