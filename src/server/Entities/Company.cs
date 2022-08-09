namespace Entities
{
    public class Company : BaseEntity, IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string APIKey { get; set; }
        public decimal UnitPrice { get; set; }


        public List<Branch> Branches { get; set; }
        public List<QueryCounter> QueryCounters { get; set; }
        public List<Reservation> Reservations { get; set; }
    }
}
