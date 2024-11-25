using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_Infrago.Data
{
    public class DataContext : DbContext
    {
        public DbSet<frmClient> Clients { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<MaterialAssignment> MaterialAssignments { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Provider> Providers { get; set; }

        public DataContext() : base("name=con")
        {
        }
    }
}
