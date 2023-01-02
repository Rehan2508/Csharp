using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class Patient
    {
        public int id { get; set; }
        public string name { get; set; }
        public string ailment { get; set; }
    }

    public class HospitalContext : DbContext
    {
        public DbSet<Patient> patient { get; set; }
    }
}