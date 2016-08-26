using System.ComponentModel.DataAnnotations;

namespace MyUtilities.Models
{
    public class StringExtensionModel : BaseResultModel
    {
        [Display(Name = "From string")]
        [Required]
        public string FromA { get; set; }

        [Display(Name = "To string")]
        [Required]
        public string ToB { get; set; }

        [Display(Name = "Text to check")]
        [Required]
        public string TextToCheck { get; set; }
    }
}
