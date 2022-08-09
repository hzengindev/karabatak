using DataAccess.Configurations;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Branch> Branches { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<QueryCounter> QueryCounters { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<User>(new UserConfig());
            modelBuilder.ApplyConfiguration<Company>(new CompanyConfig());
            modelBuilder.ApplyConfiguration<Branch>(new BranchConfig());
            modelBuilder.ApplyConfiguration<Reservation>(new ReservationConfig());
            modelBuilder.ApplyConfiguration<QueryCounter>(new QueryCounterConfig());

            InitialDataSeed.Seed(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        
    }
}
