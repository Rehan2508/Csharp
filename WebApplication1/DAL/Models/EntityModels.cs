using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Category
    {
        [DisplayName("Id")]
        public int id { get; set; }
        [DisplayName(" Category Name")]
        public string name { get; set; }
        [DisplayName("Photo Path")]
        public string photoPath { get; set; }
    }

    public class Inventory
    {
        public int id { get; set; }

        [ForeignKey("product")]
        public int pid { get; set; }
        public Product product { get; set; }

        [ForeignKey("cid")]
        public int categId { get; set; }
        public Category cid { get; set; }

        public float qty { get; set; }
    }

    public class Product
    {
        [DisplayName("Id")]
        public int id { get; set; }
        [DisplayName("Product Name")]
        public string name { get; set; }
        [DisplayName("Category Id")]
        [ForeignKey("categ")]
        public int categID { get; set; }            
        public Category categ { get; set; }

        [DisplayName("Photo Path")]
        public string photoPath { get; set; }
        [DisplayName("Price")]
        public float price { get; set; }
        public bool check { get; set; } = false;
    }

    public class Purchase
    {
        [DisplayName("Id")]
        public int id { get; set; }
        [DisplayName("Product Name")]
        public string name { get; set; }
        [DisplayName("Price")]
        public float price { get; set; }
        [DisplayName("Quantity")]
        public int qty { get; set; }

        [DisplayName("Product Id")]
        [ForeignKey("product")]
        public int prodID { get; set; }
        public Product product { get; set; }
    }

    public class CateringContext : DbContext
    {
        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Purchase> purchases { get; set; }
        public DbSet<Inventory> inventories { get; set; }
    }

}
