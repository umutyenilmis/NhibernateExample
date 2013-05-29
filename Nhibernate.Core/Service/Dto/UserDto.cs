using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nhibernate.Core.Domain;

namespace Nhibernate.Core.Service.Dto
{
	public	class UserDto
	{
		public UserDto()
		{
			ProductList = new List<ProductDto>();
		}
		public string Name { get; set; }
		public IList<ProductDto> ProductList { get; set; }
	}
	public class ProductDto
	{
		public string Name { get; set; }
	}
}
