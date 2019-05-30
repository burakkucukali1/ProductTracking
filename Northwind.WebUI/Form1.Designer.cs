namespace Northwind.WebUI
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dgwProduct = new System.Windows.Forms.DataGridView();
			this.gbxCategory = new System.Windows.Forms.GroupBox();
			this.cbxCategory = new System.Windows.Forms.ComboBox();
			this.lblCategory = new System.Windows.Forms.Label();
			this.gbxProduct = new System.Windows.Forms.GroupBox();
			this.lblProduct = new System.Windows.Forms.Label();
			this.txtProduct = new System.Windows.Forms.TextBox();
			this.gbxProductAdd = new System.Windows.Forms.GroupBox();
			this.lblProductName = new System.Windows.Forms.Label();
			this.lblCategoryID = new System.Windows.Forms.Label();
			this.lblUnitPrice = new System.Windows.Forms.Label();
			this.lblStockAmount = new System.Windows.Forms.Label();
			this.lblQuantityPerUnit = new System.Windows.Forms.Label();
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.txtStock = new System.Windows.Forms.TextBox();
			this.cbxCategoryID = new System.Windows.Forms.ComboBox();
			this.txtQuantityPerUnit = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.gbxUpdate = new System.Windows.Forms.GroupBox();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.cbxUpdateCategory = new System.Windows.Forms.ComboBox();
			this.txtUpdatePrice = new System.Windows.Forms.TextBox();
			this.txtUpdatePerUnit = new System.Windows.Forms.TextBox();
			this.txtUpdateStock = new System.Windows.Forms.TextBox();
			this.txtUpdateProductName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnRemove = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
			this.gbxCategory.SuspendLayout();
			this.gbxProduct.SuspendLayout();
			this.gbxProductAdd.SuspendLayout();
			this.gbxUpdate.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgwProduct
			// 
			this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwProduct.Location = new System.Drawing.Point(33, 203);
			this.dgwProduct.Name = "dgwProduct";
			this.dgwProduct.RowTemplate.Height = 24;
			this.dgwProduct.Size = new System.Drawing.Size(1013, 202);
			this.dgwProduct.TabIndex = 0;
			this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
			// 
			// gbxCategory
			// 
			this.gbxCategory.Controls.Add(this.cbxCategory);
			this.gbxCategory.Controls.Add(this.lblCategory);
			this.gbxCategory.Location = new System.Drawing.Point(12, 12);
			this.gbxCategory.Name = "gbxCategory";
			this.gbxCategory.Size = new System.Drawing.Size(1051, 64);
			this.gbxCategory.TabIndex = 1;
			this.gbxCategory.TabStop = false;
			this.gbxCategory.Text = "Kategoriye göre ara";
			// 
			// cbxCategory
			// 
			this.cbxCategory.FormattingEnabled = true;
			this.cbxCategory.Location = new System.Drawing.Point(106, 28);
			this.cbxCategory.Name = "cbxCategory";
			this.cbxCategory.Size = new System.Drawing.Size(231, 24);
			this.cbxCategory.TabIndex = 1;
			this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
			// 
			// lblCategory
			// 
			this.lblCategory.AutoSize = true;
			this.lblCategory.Location = new System.Drawing.Point(6, 31);
			this.lblCategory.Name = "lblCategory";
			this.lblCategory.Size = new System.Drawing.Size(61, 17);
			this.lblCategory.TabIndex = 0;
			this.lblCategory.Text = "Kategori";
			// 
			// gbxProduct
			// 
			this.gbxProduct.Controls.Add(this.lblProduct);
			this.gbxProduct.Controls.Add(this.txtProduct);
			this.gbxProduct.Location = new System.Drawing.Point(12, 97);
			this.gbxProduct.Name = "gbxProduct";
			this.gbxProduct.Size = new System.Drawing.Size(1051, 64);
			this.gbxProduct.TabIndex = 2;
			this.gbxProduct.TabStop = false;
			this.gbxProduct.Text = "Ürüne göre ara";
			// 
			// lblProduct
			// 
			this.lblProduct.AutoSize = true;
			this.lblProduct.Location = new System.Drawing.Point(18, 34);
			this.lblProduct.Name = "lblProduct";
			this.lblProduct.Size = new System.Drawing.Size(63, 17);
			this.lblProduct.TabIndex = 1;
			this.lblProduct.Text = "Ürün Adı";
			// 
			// txtProduct
			// 
			this.txtProduct.Location = new System.Drawing.Point(106, 34);
			this.txtProduct.Name = "txtProduct";
			this.txtProduct.Size = new System.Drawing.Size(230, 22);
			this.txtProduct.TabIndex = 0;
			this.txtProduct.TextChanged += new System.EventHandler(this.txtProduct_TextChanged);
			// 
			// gbxProductAdd
			// 
			this.gbxProductAdd.Controls.Add(this.btnAdd);
			this.gbxProductAdd.Controls.Add(this.cbxCategoryID);
			this.gbxProductAdd.Controls.Add(this.txtPrice);
			this.gbxProductAdd.Controls.Add(this.txtQuantityPerUnit);
			this.gbxProductAdd.Controls.Add(this.txtStock);
			this.gbxProductAdd.Controls.Add(this.txtProductName);
			this.gbxProductAdd.Controls.Add(this.lblUnitPrice);
			this.gbxProductAdd.Controls.Add(this.lblQuantityPerUnit);
			this.gbxProductAdd.Controls.Add(this.lblCategoryID);
			this.gbxProductAdd.Controls.Add(this.lblStockAmount);
			this.gbxProductAdd.Controls.Add(this.lblProductName);
			this.gbxProductAdd.Location = new System.Drawing.Point(33, 453);
			this.gbxProductAdd.Name = "gbxProductAdd";
			this.gbxProductAdd.Size = new System.Drawing.Size(1012, 151);
			this.gbxProductAdd.TabIndex = 3;
			this.gbxProductAdd.TabStop = false;
			this.gbxProductAdd.Text = "Yeni Ürün Ekle";
			// 
			// lblProductName
			// 
			this.lblProductName.AutoSize = true;
			this.lblProductName.Location = new System.Drawing.Point(6, 18);
			this.lblProductName.Name = "lblProductName";
			this.lblProductName.Size = new System.Drawing.Size(63, 17);
			this.lblProductName.TabIndex = 0;
			this.lblProductName.Text = "Ürün Adı";
			// 
			// lblCategoryID
			// 
			this.lblCategoryID.AutoSize = true;
			this.lblCategoryID.Location = new System.Drawing.Point(6, 63);
			this.lblCategoryID.Name = "lblCategoryID";
			this.lblCategoryID.Size = new System.Drawing.Size(61, 17);
			this.lblCategoryID.TabIndex = 0;
			this.lblCategoryID.Text = "Kategori";
			// 
			// lblUnitPrice
			// 
			this.lblUnitPrice.AutoSize = true;
			this.lblUnitPrice.Location = new System.Drawing.Point(6, 111);
			this.lblUnitPrice.Name = "lblUnitPrice";
			this.lblUnitPrice.Size = new System.Drawing.Size(38, 17);
			this.lblUnitPrice.TabIndex = 0;
			this.lblUnitPrice.Text = "Fiyat";
			// 
			// lblStockAmount
			// 
			this.lblStockAmount.AutoSize = true;
			this.lblStockAmount.Location = new System.Drawing.Point(453, 18);
			this.lblStockAmount.Name = "lblStockAmount";
			this.lblStockAmount.Size = new System.Drawing.Size(76, 17);
			this.lblStockAmount.TabIndex = 0;
			this.lblStockAmount.Text = "Stok Adedi";
			// 
			// lblQuantityPerUnit
			// 
			this.lblQuantityPerUnit.AutoSize = true;
			this.lblQuantityPerUnit.Location = new System.Drawing.Point(450, 63);
			this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
			this.lblQuantityPerUnit.Size = new System.Drawing.Size(79, 17);
			this.lblQuantityPerUnit.TabIndex = 0;
			this.lblQuantityPerUnit.Text = "Birim Adedi";
			// 
			// txtProductName
			// 
			this.txtProductName.Location = new System.Drawing.Point(118, 18);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new System.Drawing.Size(233, 22);
			this.txtProductName.TabIndex = 1;
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(118, 111);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(233, 22);
			this.txtPrice.TabIndex = 1;
			// 
			// txtStock
			// 
			this.txtStock.Location = new System.Drawing.Point(578, 15);
			this.txtStock.Name = "txtStock";
			this.txtStock.Size = new System.Drawing.Size(214, 22);
			this.txtStock.TabIndex = 1;
			// 
			// cbxCategoryID
			// 
			this.cbxCategoryID.FormattingEnabled = true;
			this.cbxCategoryID.Location = new System.Drawing.Point(118, 63);
			this.cbxCategoryID.Name = "cbxCategoryID";
			this.cbxCategoryID.Size = new System.Drawing.Size(234, 24);
			this.cbxCategoryID.TabIndex = 2;
			// 
			// txtQuantityPerUnit
			// 
			this.txtQuantityPerUnit.Location = new System.Drawing.Point(578, 65);
			this.txtQuantityPerUnit.Name = "txtQuantityPerUnit";
			this.txtQuantityPerUnit.Size = new System.Drawing.Size(214, 22);
			this.txtQuantityPerUnit.TabIndex = 1;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(578, 111);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(214, 34);
			this.btnAdd.TabIndex = 3;
			this.btnAdd.Text = "EKLE";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// gbxUpdate
			// 
			this.gbxUpdate.Controls.Add(this.btnUpdate);
			this.gbxUpdate.Controls.Add(this.cbxUpdateCategory);
			this.gbxUpdate.Controls.Add(this.txtUpdatePrice);
			this.gbxUpdate.Controls.Add(this.txtUpdatePerUnit);
			this.gbxUpdate.Controls.Add(this.txtUpdateStock);
			this.gbxUpdate.Controls.Add(this.txtUpdateProductName);
			this.gbxUpdate.Controls.Add(this.label1);
			this.gbxUpdate.Controls.Add(this.label2);
			this.gbxUpdate.Controls.Add(this.label3);
			this.gbxUpdate.Controls.Add(this.label4);
			this.gbxUpdate.Controls.Add(this.label5);
			this.gbxUpdate.Location = new System.Drawing.Point(32, 617);
			this.gbxUpdate.Name = "gbxUpdate";
			this.gbxUpdate.Size = new System.Drawing.Size(1012, 151);
			this.gbxUpdate.TabIndex = 4;
			this.gbxUpdate.TabStop = false;
			this.gbxUpdate.Text = "Ürün Güncelle";
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(578, 111);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(214, 34);
			this.btnUpdate.TabIndex = 3;
			this.btnUpdate.Text = "GÜNCELLE";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// cbxUpdateCategory
			// 
			this.cbxUpdateCategory.FormattingEnabled = true;
			this.cbxUpdateCategory.Location = new System.Drawing.Point(118, 63);
			this.cbxUpdateCategory.Name = "cbxUpdateCategory";
			this.cbxUpdateCategory.Size = new System.Drawing.Size(234, 24);
			this.cbxUpdateCategory.TabIndex = 2;
			// 
			// txtUpdatePrice
			// 
			this.txtUpdatePrice.Location = new System.Drawing.Point(118, 111);
			this.txtUpdatePrice.Name = "txtUpdatePrice";
			this.txtUpdatePrice.Size = new System.Drawing.Size(233, 22);
			this.txtUpdatePrice.TabIndex = 1;
			// 
			// txtUpdatePerUnit
			// 
			this.txtUpdatePerUnit.Location = new System.Drawing.Point(578, 65);
			this.txtUpdatePerUnit.Name = "txtUpdatePerUnit";
			this.txtUpdatePerUnit.Size = new System.Drawing.Size(214, 22);
			this.txtUpdatePerUnit.TabIndex = 1;
			// 
			// txtUpdateStock
			// 
			this.txtUpdateStock.Location = new System.Drawing.Point(578, 13);
			this.txtUpdateStock.Name = "txtUpdateStock";
			this.txtUpdateStock.Size = new System.Drawing.Size(214, 22);
			this.txtUpdateStock.TabIndex = 1;
			// 
			// txtUpdateProductName
			// 
			this.txtUpdateProductName.Location = new System.Drawing.Point(118, 18);
			this.txtUpdateProductName.Name = "txtUpdateProductName";
			this.txtUpdateProductName.Size = new System.Drawing.Size(233, 22);
			this.txtUpdateProductName.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 111);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Fiyat";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(450, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Birim Adedi";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 63);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "Kategori";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(453, 18);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 17);
			this.label4.TabIndex = 0;
			this.label4.Text = "Stok Adedi";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 18);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(63, 17);
			this.label5.TabIndex = 0;
			this.label5.Text = "Ürün Adı";
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point(607, 411);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(217, 38);
			this.btnRemove.TabIndex = 5;
			this.btnRemove.Text = "SİL";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1078, 788);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.gbxUpdate);
			this.Controls.Add(this.gbxProductAdd);
			this.Controls.Add(this.gbxProduct);
			this.Controls.Add(this.gbxCategory);
			this.Controls.Add(this.dgwProduct);
			this.Name = "Form1";
			this.Text = "Ürünler";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
			this.gbxCategory.ResumeLayout(false);
			this.gbxCategory.PerformLayout();
			this.gbxProduct.ResumeLayout(false);
			this.gbxProduct.PerformLayout();
			this.gbxProductAdd.ResumeLayout(false);
			this.gbxProductAdd.PerformLayout();
			this.gbxUpdate.ResumeLayout(false);
			this.gbxUpdate.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgwProduct;
		private System.Windows.Forms.GroupBox gbxCategory;
		private System.Windows.Forms.ComboBox cbxCategory;
		private System.Windows.Forms.Label lblCategory;
		private System.Windows.Forms.GroupBox gbxProduct;
		private System.Windows.Forms.Label lblProduct;
		private System.Windows.Forms.TextBox txtProduct;
		private System.Windows.Forms.GroupBox gbxProductAdd;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.ComboBox cbxCategoryID;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.TextBox txtQuantityPerUnit;
		private System.Windows.Forms.TextBox txtStock;
		private System.Windows.Forms.TextBox txtProductName;
		private System.Windows.Forms.Label lblUnitPrice;
		private System.Windows.Forms.Label lblQuantityPerUnit;
		private System.Windows.Forms.Label lblCategoryID;
		private System.Windows.Forms.Label lblStockAmount;
		private System.Windows.Forms.Label lblProductName;
		private System.Windows.Forms.GroupBox gbxUpdate;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.ComboBox cbxUpdateCategory;
		private System.Windows.Forms.TextBox txtUpdatePrice;
		private System.Windows.Forms.TextBox txtUpdatePerUnit;
		private System.Windows.Forms.TextBox txtUpdateStock;
		private System.Windows.Forms.TextBox txtUpdateProductName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnRemove;
	}
}

