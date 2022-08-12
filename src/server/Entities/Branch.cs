namespace Entities
{
    public class Branch : BaseEntity, IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid CompanyId { get; set; }
        public BranchStatus Status { get; set; }


        public virtual Company Company { get; set; }
        public virtual List<User> Users { get; set; }
        public virtual List<QueryCounter> QueryCounters { get; set; }
        public virtual List<Reservation> Reservations { get; set; }
    }

    public enum BranchStatus : short
    {
        Deactive = 0,
        Active = 1
    }
}
