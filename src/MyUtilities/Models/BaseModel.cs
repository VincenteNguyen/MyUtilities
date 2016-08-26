using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyUtilities.Models
{
    public class BaseModel
    {
        public string Name { get; set; }

        [Display(Name = "Source code")]
        public string SourceCode { get; set; }
    }
}
