namespace Nhibernate.Core.Domain
{
    public class Score : EntityBase
    {
        public DomainUser DomainUser { get; set; }
        public int Points { get; set; }
    }
}
