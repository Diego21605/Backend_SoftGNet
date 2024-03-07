using Backend_SoftGNet.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend_SoftGNet.Data
{
    public class dataContext: DbContext
    {
        protected readonly IConfiguration Configuration;
        public dataContext(DbContextOptions<dataContext> options, IConfiguration configuration) : base(options) { Configuration = configuration; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Drivers> Drivers { get; set; }
        public DbSet<Vehicles> Vehicles { get; set; }
        public DbSet<Routes> Route { get; set; }
        public DbSet<Schedules> Schedules { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Users> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Routes
            modelBuilder.Entity<Routes>().HasOne(x => x.Drivers).WithMany().HasForeignKey(y => y.Driver_Id).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Routes>().HasOne(x => x.Vehicles).WithMany().HasForeignKey(y => y.Vehicle_Id).OnDelete(DeleteBehavior.Restrict);

            //Schedules
            modelBuilder.Entity<Schedules>().HasOne(x => x.Route).WithMany().HasForeignKey(y => y.Route_Id).OnDelete(DeleteBehavior.Restrict);

            //Users
            modelBuilder.Entity<Users>().HasOne(x => x.Role).WithMany().HasForeignKey(y => y.Role_Id).OnDelete(DeleteBehavior.Restrict);
        }

    }
}
