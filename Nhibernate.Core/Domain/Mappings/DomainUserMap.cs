namespace Nhibernate.Core.Domain.Mappings
{
    public class DomainUserMap : EntityBaseMap<DomainUser>
    {
        public DomainUserMap()
        {
            Map(x => x.Name);
            Map(x => x.Surname);
            Map(x => x.FacebookId);
        }
    }
}