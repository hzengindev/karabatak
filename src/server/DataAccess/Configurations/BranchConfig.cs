using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class BranchConfig : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder.Property(z => z.Name).HasColumnType("nvarchar(200)");

            builder.HasOne(z => z.Company)
                .WithMany(z => z.Branches)
                .HasForeignKey(z => z.CompanyId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
