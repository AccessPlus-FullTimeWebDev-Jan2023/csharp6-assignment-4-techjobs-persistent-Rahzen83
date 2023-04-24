using System.ComponentModel.DataAnnotations;

namespace TechJobs6Persistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string? Name { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string? Location { get; set; }
    }
}
