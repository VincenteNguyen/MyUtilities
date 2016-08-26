using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyUtilities.Models
{
    public class BaseResultModel
    {
        [Required]
        [Display(Name = "Source value")]
        public string SourceValue { get; set; }

        public string Result { get; set; }
    }
}
