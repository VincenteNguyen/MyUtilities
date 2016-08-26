using System.ComponentModel.DataAnnotations;

namespace MyUtilities.Models
{
    public class EnumGeneratorViewModel : BaseResultModel
    {
        [Required]
        [Display(Name = "Enum name")]
        public new string Name { get; set; }
        public string[] dynamicName { get; set; }
        public string[] dynamicValue { get; set; }
    }
}
