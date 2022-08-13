using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(z => z.Firstname).HasColumnType("nvarchar(50)");
            builder.Property(z => z.Lastname).HasColumnType("nvarchar(50)");
            builder.Property(z => z.Username).HasColumnType("nvarchar(50)");
            builder.Property(z => z.Email).HasColumnType("nvarchar(50)");

            builder.HasOne(z => z.Branch)
                .WithMany(z => z.Users)
                .HasForeignKey(z => z.BranchId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
