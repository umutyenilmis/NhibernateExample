using FluentNHibernate.Mapping;

namespace Nhibernate.Core.Domain.Mappings
{
	public class EntityBaseMap<T> : ClassMap<T> where T : EntityBase
	{
		public EntityBaseMap()
		{
			Id(x => x.Id).GeneratedBy.GuidComb();		
			Map(x => x.IsDeleted).Not.Nullable();
			Map(x => x.CreatedAt);
		}
	}
}