using PSP_Infrago.Entities;
using System.Data.Entity;
namespace PSP_Infrago.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<MaterialAssignment> MaterialAssignments { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Provider> providers { get; set; }
        public DbSet<Tool> Tools { get; set; }
        public DbSet<ToolAssignment> ToolAssignments { get; set; }
        public DbSet<Maintenance> Maintenances { get; set; }
        public DbSet<MaintenanceDetails> MaintenanceDetails { get; set; }
        public DbSet<Machinery> Machineries { get; set; }
        public DbSet<MachineryAssignment> MachineryAssignments { get; set; }
        public DbSet<ProjectDetails> ProjectDetails { get; set; }
        public DbSet<Service> Services { get; set; }

        public DataContext() : base("name=con")
        {
        }
    }
}
