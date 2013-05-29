using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nhibernate.Core.Domain
{
	public class SSUser : EntityBase 
	{
		public virtual string Name { get; set; }
		public virtual DateTime BirthDate { get; set; }
		public virtual int ViewCount { get; set; }
			
	}
}
