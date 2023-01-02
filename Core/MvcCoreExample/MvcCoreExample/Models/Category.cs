using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcCoreExample.Models
{
    public class Category
    {
        public int id { get; set; }

        public string name { get; set; }

        public string imagePath { get; set; }

        [NotMapped]
        public FormFile photo { get; set; }
    }

    public class CateringContext : DbContext
    {
        public CateringContext(DbContextOptions<CateringContext> option) : base(option)
        {

        }
        public DbSet<Category> categories { get; set; }
    }
}
