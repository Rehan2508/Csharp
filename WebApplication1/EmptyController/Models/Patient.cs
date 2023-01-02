using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmptyController.Models
{
    public class Patient
    {
        [Display(Name = "Id")]
        public int id { get; set; }

        [Display(Name = "Name")]
        public string name { get; set; }

        [Display(Name = "Ailment")]
        public string ailment { get; set; }
        
    }
}