using Microsoft.EntityFrameworkCore;


namespace CareNet_System.Models
{
    public class HosPitalContext:DbContext
    {
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Department> Departments { get; set; } 
        public DbSet<Patient> Patients { get; set; } 
        public DbSet<Bills> Bills { get; set; }
      

        public HosPitalContext() : base() { }
        public HosPitalContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = AHMED\\SQLEXPRESS; Initial Catalog = Hospital; Integrated Security = True; Encrypt = False");
        }
    }
}
