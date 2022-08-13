namespace DataAccess.Entities
{
    public class Company : BaseEntity, IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string APIKey { get; set; }
        public decimal UnitPrice { get; set; }
        public CompanyStatus Status { get; set; }


        public virtual List<Branch> Branches { get; set; }
        public virtual List<QueryCounter> QueryCounters { get; set; }
        public virtual List<Reservation> Reservations { get; set; }

        
    }

    public enum CompanyStatus : short
    {
        Deactive = 0,
        Active = 1
    }
}
