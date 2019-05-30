using Ninject.Modules;
using Northwind.BusinessLayer.Abstract;
using Northwind.BusinessLayer.Concrete;
using Northwind.DataAccessLayer.Abstract;
using Northwind.DataAccessLayer.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.BusinessLayer.DependencyResolvers.Ninject
{
	public class BusinessModule:NinjectModule
	{
		public override void Load()
		{
			Bind<IProductService>().To<ProductManager>().InSingletonScope();
			Bind<IProductDAL>().To<EFProductDAL>().InSingletonScope();


			Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
			Bind<ICategoryDAL>().To<EFCategoryDAL>().InSingletonScope();

		}
	}
}
