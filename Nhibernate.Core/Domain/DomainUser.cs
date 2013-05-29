namespace Nhibernate.Core.Domain
{
    public class DomainUser : EntityBase
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FacebookId { get; set; }
    }
}