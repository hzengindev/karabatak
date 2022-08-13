namespace DataAccess.Entities
{
    public class BaseEntity : IEntity
    {
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
