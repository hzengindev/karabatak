namespace Entities
{
    public class Reservation : BaseEntity, IEntity
    {
        public Guid Id { get; set; }
        public Guid BranchId { get; set; }
        public Guid CompanyId { get; set; }
        public DateTime PickUpDate { get; set; }
        public DateTime DropOffDate { get; set; }
        public string CustomerIdentity { get; set; }
        public string PNR { get; set; }
        public string Reference { get; set; }
        public bool PaymentStatus { get; set; }


        public Branch Branch { get; set; }
        public Company Company { get; set; }
    }
}
