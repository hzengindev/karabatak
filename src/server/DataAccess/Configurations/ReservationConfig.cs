using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class ReservationConfig : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.HasOne(z => z.Company)
                .WithMany(z => z.Reservations)
                .HasForeignKey(z => z.CompanyId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(z => z.Branch)
                .WithMany(z => z.Reservations)
                .HasForeignKey(z => z.BranchId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
