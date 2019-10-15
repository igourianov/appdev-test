using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppDevTest.Models
{
    public class MvcCalculatorModel
    {

        [Display(Name = "Value1")]
        public string Value1
        { get; set; }

        [Display(Name = "Value2")]
        public string Value2
        { get; set; }

        [Required]
        public string Operation
        { get; set; }

        public double Result
        { get; set; }

        public string Error
        { get; set; }

        public string Type
        { get; set; }
    }
}