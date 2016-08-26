using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyUtilities.Models
{
    public class HttpBuilderModel : BaseResultModel
    {
        [Display(Name = "Page variable")]
        public string PageVariable { get; set; }

        [Display(Name = "From")]
        public string From { get; set; }

        [Display(Name = "Parameter")]
        public string Parameter { get; set; }

        [Display(Name = "Name of collection")]
        public string NameOfCollection { get; set; }
    }
}
