using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AppDevTest.Models
{
    public class MvcCalculatorModel
    {
        [Display(Name = "Value1")]
        public string Value1 { get; set; }
        
        [Display(Name = "Value2")]
        public string Value2 { get; set; }

        [Required]
        [Display(Name = "Operator")]
        public string Operation { get; set; }

        public string Type { get; set; }
    }
}