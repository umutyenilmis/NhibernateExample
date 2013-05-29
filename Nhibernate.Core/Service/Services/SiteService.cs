using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nhibernate.Core.Service.DefaultServices;
using Nhibernate.Core.Service.Interfaces;
using Nhibernate.Core.Service.Dto;
using Nhibernate.Core.Infrastructure.UoW;
using Nhibernate.Core.Domain;
using NHibernate;
using NHibernate.Transform;


namespace Nhibernate.Core.Service.Services
{
    public	class SiteService : ServiceBase, ISiteService
	{
		public void DummyData()
		{
			var user = new SSUser
			{
				Name = "Ali",
				BirthDate = DateTime.Now,
				ViewCount = 500
			};

			UnitOfWork.CurrentSession.SaveOrUpdate(user);

			var product = new Product
			{
				Name = "Ürün",
				Owner = user
			};

			UnitOfWork.CurrentSession.SaveOrUpdate(product);

			using (var tran = UnitOfWork.CurrentSession.BeginTransaction())
			{
				tran.Commit();
			}
		}

		public UserDto GetUser(string name)
		{
			var user = UnitOfWork.CurrentSession.QueryOver<SSUser>()
				.Where(x => x.Name == name)
				.SingleOrDefault<SSUser>();

			SetResultAsSuccess(0, "Başarılı");
			
			return new UserDto
			{
				Name = user.Name,
				ProductList = GetProductList(user)
			};


		}

		private IList<ProductDto> GetProductList(SSUser user)
		{
			ProductDto productDto = null;
			SSUser userJoin = null;

			return UnitOfWork.CurrentSession.QueryOver<Product>()
				.JoinAlias(x => x.Owner, () => userJoin)
				.Where(x => x.Owner == user)
				.SelectList(u => u.Select(x => x.Name).WithAlias(() => productDto.Name))
				.TransformUsing(Transformers.AliasToBean<ProductDto>())
				.List<ProductDto>();

			
			//var productList = UnitOfWork.CurrentSession.QueryOver<Product>()
			//	.JoinAlias(x => x.Owner, () => userJoin)
			//	.Where(() => userJoin == user)
			//	.List<Product>();
			//
			//var productListDto = new List<ProductDto>();
			//foreach (var product in productList)
			//{
			//	productListDto.Add(new ProductDto
			//	{
			//		Name = product.Name
			//	});
			//}
			//
			//
			//return productListDto;
		}
	}
}
