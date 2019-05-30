using Northwind.Entities1.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.BusinessLayer.Abstract
{
	public interface IProductService
	{
		List<Product> GetAll();
		List<Product> GetProductsByCategory(int categoryID);
		List<Product> GetProductsByProductName(string productName);
		void Add(Product product);
		void Update(Product product);
		void Delete(Product product);
	}
}
