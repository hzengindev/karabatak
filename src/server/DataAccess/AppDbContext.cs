using DataAccess.Configurations;
using DataAccess.Entities;
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Console logging activated.
            // optionsBuilder.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);

            // Lazy loading activated.
            optionsBuilder.UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

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

        public override int SaveChanges()
        {
            ChangeTracker.Entries()
                .Where(z => z.Entity is BaseEntity && (z.State == EntityState.Added || z.State == EntityState.Modified))
                .ToList()
                .ForEach(entity =>
                {
                    if(entity.State == EntityState.Added)
                    {
                        ((BaseEntity)entity.Entity).CreatedOn = DateTime.Now;
                        ((BaseEntity)entity.Entity).ModifiedOn = DateTime.Now;

                        // TODO: Set CreatedBy/ModifiedBy Field
                    }

                    if(entity.State == EntityState.Modified)
                    {
                        ((BaseEntity)entity.Entity).ModifiedOn = DateTime.Now;
                        // TODO: Set ModifiedBy Field
                    }
                });

            return base.SaveChanges();
        }
    }
}
