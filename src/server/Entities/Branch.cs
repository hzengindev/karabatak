namespace Entities
{
    public class Branch : BaseEntity, IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid CompanyId { get; set; }
        

        public Company Company { get; set; }
        public List<User> Users { get; set; }
        public List<QueryCounter> QueryCounters { get; set; }
        public List<Reservation> Reservations { get; set; }
    }
}
