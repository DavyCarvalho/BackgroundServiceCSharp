using System.ComponentModel.DataAnnotations;

namespace BackgroundServiceExample.Models {
    public class BackgroundProccess {
        [Key]
        [Required]
        public Guid Id { get; set; }
        
        [Required]
        public string NameSearchParameter { get; set; }
    }
}
