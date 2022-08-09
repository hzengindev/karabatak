using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class QueryCounterConfig : IEntityTypeConfiguration<QueryCounter>
    {
        public void Configure(EntityTypeBuilder<QueryCounter> builder)
        {
            builder.Property(z => z.UnitPrice).HasPrecision(18, 2);

            builder.HasOne(z => z.Company)
                .WithMany(z => z.QueryCounters)
                .HasForeignKey(z => z.CompanyId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(z => z.Branch)
                .WithMany(z => z.QueryCounters)
                .HasForeignKey(z => z.BranchId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
