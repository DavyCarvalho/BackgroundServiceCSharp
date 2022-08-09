using System.ComponentModel.DataAnnotations;

namespace BackgroundServiceExample.Models {
    public class BackgroundProcess {
        [Key]
        [Required]
        public Guid Id { get; set; }
        
        [Required]
        public string NameSearchParameter { get; set; }
    }
}
