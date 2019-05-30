using Northwind.BusinessLayer.Abstract;
using Northwind.DataAccessLayer.Abstract;
using Northwind.Entities1.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.BusinessLayer.Concrete
{


	public class CategoryManager : ICategoryService
	{
		private ICategoryDAL _categoryDAL;

		public CategoryManager(ICategoryDAL categoryDAL)
		{
			_categoryDAL = categoryDAL;

		}
		public List<Category> GetAll()
		{
			return _categoryDAL.GetAll();
		}

	
	}
}
