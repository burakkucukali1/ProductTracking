using Northwind.DataAccessLayer.Abstract;
using Northwind.Entities1.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccessLayer.Concrete.EntityFramework
{
	public class EFCategoryDAL:EFEntityRepositoryBase<Category, NorthwindContext> , ICategoryDAL
	{
	}
}
