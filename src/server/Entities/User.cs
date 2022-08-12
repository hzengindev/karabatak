namespace Entities
{
    public class User : BaseEntity, IEntity
    {
        public Guid Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public UserStatus Status { get; set; }
        public UserRole Role { get; set; }
        public Guid BranchId { get; set; }


        public virtual Branch Branch { get; set; }
    }

    public enum UserStatus : short
    {
        Deactive = 0,
        Active = 1
    }

    public enum UserRole : short
    {
        Employee = 0,
        Manager = 1
    }
}
