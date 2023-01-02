using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CateringApp.Models
{
    public class Product
    {
        [DisplayName("Id")]
        public int id { get; set; }
        [DisplayName("Name")]
        public string name { get; set; }
        [DisplayName("Category Id")]
        public int categoryId { get; set; }
        [DisplayName("Description")]
        public string description { get; set; }
        [DisplayName("Photo Path")]
        public string photoPath { get; set; }
        [DisplayName("Price")]
        public double price { get; set; }
    }
}