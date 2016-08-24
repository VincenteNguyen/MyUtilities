﻿using System.ComponentModel.DataAnnotations;

namespace MyUtilities.Models
{
    public class StringExtensionModel
    {
        public string Name { get; set; }

        [Display(Name = "Source code")]
        public string SourceCode { get; set; }

        [Required]
        [Display(Name = "Source value")]
        public string SourceValue { get; set; }

        [Display(Name = "From string")]
        [Required]
        public string FromA { get; set; }

        [Display(Name = "To string")]
        [Required]
        public string ToB { get; set; }

        [Display(Name = "Text to check")]
        [Required]
        public string TextToCheck { get; set; }

        public string Result { get; set; }
    }
}