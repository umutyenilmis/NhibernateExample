using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nhibernate.Core.Domain.Mappings
{
	public class SSUserMap : EntityBaseMap<SSUser>
	{
		public SSUserMap()
		{
			Map(x => x.Name).Length(50);
			Map(x => x.BirthDate).Not.Nullable();
			Map(x => x.ViewCount);
		}
	}
}
