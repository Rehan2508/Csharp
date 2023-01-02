using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityExample.Models
{
    public class Doctor
    {
        public int id { get; set; }
        public string name { get; set; }
        public string hospitalName { get; set; }
    }

    public class HospitalContext : DbContext
    {
        public DbSet<Doctor> doctor { get; set; }
    }
}