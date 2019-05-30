using Northwind.BusinessLayer.Abstract;
using Northwind.BusinessLayer.Concrete;
using Northwind.BusinessLayer.DependencyResolvers.Ninject;
using Northwind.DataAccessLayer.Concrete.EntityFramework;
using Northwind.Entities1.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			_productService = InstanceFactory.GetInstance<IProductService>();
			_categoryService = InstanceFactory.GetInstance<ICategoryService>();
		}

		private IProductService _productService;
		private ICategoryService _categoryService;

		private void Form1_Load(object sender, EventArgs e)
		{
			LoadProducts();
			LoadCategories();

		}

		private void LoadCategories()
		{
			cbxCategory.DataSource = _categoryService.GetAll();
			cbxCategory.DisplayMember = "CategoryName";
			cbxCategory.ValueMember = "CategoryID";

			cbxCategoryID.DataSource = _categoryService.GetAll();
			cbxCategoryID.DisplayMember = "CategoryName";
			cbxCategoryID.ValueMember = "CategoryID";

			cbxUpdateCategory.DataSource = _categoryService.GetAll();
			cbxUpdateCategory.DisplayMember = "CategoryName";
			cbxUpdateCategory.ValueMember = "CategoryID";
		}

		private void LoadProducts()
		{
			dgwProduct.DataSource = _productService.GetAll();
		}

		private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));

			}
			catch
			{


			}
		}

		private void txtProduct_TextChanged(object sender, EventArgs e)
		{
			dgwProduct.DataSource = _productService.GetProductsByProductName(txtProduct.Text);

			if (string.IsNullOrEmpty(txtProduct.Text))
			{
				LoadProducts();
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				_productService.Add(new Product
				{
					CategoryID = Convert.ToInt32(cbxCategoryID.SelectedValue),
					ProductName = txtProductName.Text,
					QuantityPerUnit = txtQuantityPerUnit.Text,
					UnitPrice = Convert.ToDecimal(txtPrice.Text),
					UnitsInStock = Convert.ToInt16(txtStock.Text)
				});
				MessageBox.Show("Ürün Eklendi!");
				LoadProducts();
			}

			catch (Exception exception)
			{

				MessageBox.Show(exception.Message);
			}
		}

	private void btnUpdate_Click(object sender, EventArgs e)
	{
		_productService.Update(new Product
		{
			ProductID = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
			ProductName = txtUpdateProductName.Text,
			CategoryID = Convert.ToInt32(cbxUpdateCategory.SelectedValue),
			UnitsInStock = Convert.ToInt16(txtUpdateStock.Text),
			QuantityPerUnit = txtUpdatePerUnit.Text,
			UnitPrice = Convert.ToDecimal(txtUpdatePrice.Text)
		});
		MessageBox.Show("Ürün Güncellendi");
		LoadProducts();
	}

	private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		txtUpdateProductName.Text = dgwProduct.CurrentRow.Cells[1].Value.ToString();
		cbxUpdateCategory.SelectedValue = dgwProduct.CurrentRow.Cells[2].Value;
		txtUpdatePrice.Text = dgwProduct.CurrentRow.Cells[3].Value.ToString();
		txtUpdatePerUnit.Text = dgwProduct.CurrentRow.Cells[4].Value.ToString();
		txtUpdateStock.Text = dgwProduct.CurrentRow.Cells[5].Value.ToString();
	}

	private void btnRemove_Click(object sender, EventArgs e)
	{
		_productService.Delete(new Product
		{
			ProductID = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)

		});
		MessageBox.Show("Ürün Silindi!");
		LoadProducts();
	}

}			
}
