using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nhibernate.Core.Domain
{
	public class Product : EntityBase
	{
		public virtual SSUser Owner { get; set; }
		public virtual string Name { get; set; }
	}
}
