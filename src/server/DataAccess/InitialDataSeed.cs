using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public static class InitialDataSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var companyId = Guid.Parse("{EBFCC5DC-91E0-49E8-AA44-D1B6404E3F1A}");
            var branchId = Guid.Parse("{9FF4EF03-39E1-42D7-9B60-D54D183A5BA7}");
            var employeeUserId = Guid.Parse("{7EF223F8-548E-4507-AF62-E24A85380A78}");
            var managerUserId = Guid.Parse("{35C708FD-6853-43A1-B670-152E323A576D}");

            modelBuilder.Entity<Company>().HasData(new Company()
            {
                Id = companyId,
                Name = "Test Company",
                APIKey = "test",
                UnitPrice = 2.5M,
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now,
                Status = CompanyStatus.Active
            });

            modelBuilder.Entity<Branch>().HasData(new Branch()
            {
                Id = branchId,
                Name = "Test Branch",
                CompanyId = companyId,
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now,
                Status = BranchStatus.Active
            });

            modelBuilder.Entity<User>().HasData(new User()
            {
                Id = employeeUserId,
                Firstname = "Test Employee",
                Lastname = "Test Employee",
                Email = "employee@test.com",
                Username = "employee",
                Status = UserStatus.Active,
                Role = UserRole.Employee,
                BranchId = branchId,
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now,
                PasswordSalt = new byte[0],
                PasswordHash = new byte[0]
            },
            new User()
            {
                Id = managerUserId,
                Firstname = "Test Manager",
                Lastname = "Test Manager",
                Email = "manager@test.com",
                Username = "manager",
                Status = UserStatus.Active,
                Role = UserRole.Manager,
                BranchId = branchId,
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now,
                PasswordSalt = new byte[0],
                PasswordHash = new byte[0]
            });

            modelBuilder.Entity<Reservation>().HasData(new Reservation()
            {
                Id = Guid.NewGuid(),
                BranchId = branchId,
                CompanyId = companyId,
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now,
                CustomerIdentity = "test-employee",
                PNR = "test-employee",
                Reference = "test-employee",
                DropOffDate = DateTime.Now,
                PickUpDate = DateTime.Now,
                PaymentStatus = true,
            });
        }
    }
}
