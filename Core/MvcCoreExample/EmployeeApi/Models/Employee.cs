using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EmployeeApi.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public double salary { get; set; }
    }

    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> option) : base(option)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
