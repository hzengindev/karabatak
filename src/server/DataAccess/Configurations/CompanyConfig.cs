using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class CompanyConfig : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.Property(z => z.Name).HasColumnType("nvarchar(200)");
            builder.Property(z => z.APIKey).HasColumnType("nvarchar(1000)");
            builder.Property(z => z.UnitPrice).HasPrecision(18, 2);
        }
    }
}
