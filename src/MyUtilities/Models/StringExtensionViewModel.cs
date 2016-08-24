using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyUtilities.Models
{
    public class StringExtensionViewModel
    {
        public List<StringExtensionModel> StringExtensionModels { get; set; }
        public StringExtensionViewModel()
        {
            StringExtensionModels = new List<StringExtensionModel>();
        }
   }
}
