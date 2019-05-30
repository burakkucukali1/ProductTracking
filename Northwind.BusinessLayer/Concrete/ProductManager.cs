using FluentValidation;
using Northwind.BusinessLayer.Abstract;
using Northwind.BusinessLayer.Concrete.ValidationRules.FluentValidation;
using Northwind.BusinessLayer.Utilities;
using Northwind.DataAccessLayer.Abstract;
using Northwind.DataAccessLayer.Concrete;
using Northwind.DataAccessLayer.Concrete.EntityFramework;
using Northwind.Entities1.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.BusinessLayer.Concrete
{
	public class ProductManager:IProductService
	{
		private IProductDAL _productDAL;

		public ProductManager(IProductDAL productDAL)
		{
			_productDAL = productDAL;
		}

		public void Add(Product product)
		{
			ValidationTool.Validate(new ProductValidator(), product);
			_productDAL.Add(product);
		}

		public void Delete(Product product)
		{
			_productDAL.Delete(product);
		}

		public List<Product> GetAll()
		{

			return _productDAL.GetAll();
		}

		public List<Product> GetProductsByCategory(int categoryID)
		{
			return _productDAL.GetAll(p => p.CategoryID==categoryID);
		}

		public List<Product> GetProductsByProductName(string productName)
		{
			return _productDAL.GetAll(p => p.ProductName.ToLower().Contains(productName.ToLower()));
			
		}

		public void Update(Product product)
		{
			ValidationTool.Validate(new ProductValidator(), product);

			_productDAL.Update(product);
		}
	}
}
