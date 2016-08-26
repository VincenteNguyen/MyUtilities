using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyUtilities.Models
{
    public class HtmlToTreeModel : BaseResultModel
    {
        public string RootElement { get; set; }
        public string FirstParentElement { get; set; }
        public string SecondSelectorElement { get; set; }
        public string ThirdSelectorElement { get; set; }
        public string ElementProperties { get; set; }
    }
}
