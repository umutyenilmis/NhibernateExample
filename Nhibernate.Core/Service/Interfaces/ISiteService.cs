using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nhibernate.Core.Service.DefaultServices.Interfaces;
using Nhibernate.Core.Service.Dto;


namespace Nhibernate.Core.Service.Interfaces
{
	public interface ISiteService : IService
	{
		UserDto GetUser(string name);
		void DummyData();
	}
}
