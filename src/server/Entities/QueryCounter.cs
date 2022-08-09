namespace Entities
{
    public class QueryCounter : BaseEntity, IEntity
    {
        public Guid Id { get; set; }
        public Guid BranchId { get; set; }
        public Guid CompanyId { get; set; }
        public DateTime QueryDate { get; set; }
        public decimal UnitPrice { get; set; }


        public Branch Branch { get; set; }
        public Company Company { get; set; }
    }
}
