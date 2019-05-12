using AdoNetCRUD.DataMappers;
using AdoNetCRUD.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetCRUD
{
    public partial class ProductEditForm : Form
    {
        private int _productId;

        public ProductEditForm()
        {
            InitializeComponent();
        }

        public ProductEditForm(int productId) : this()
        {
            _productId = productId;
        }

        private void FillFormByProduct(Product product)
        {
            if (product != null)
            {
                txtProductName.Text = product.ProductName;
                txtQuantityPerUnit.Text = product.QuantityPerUnit;
                numReorderLevel.Value = product.ReorderLevel.HasValue ? product.ReorderLevel.Value : 0;
                numUnitPrice.Value = product.UnitPrice.HasValue ? product.UnitPrice.Value : 0;
                numUnitsInStock.Value = product.UnitsInStock.HasValue ? product.UnitsInStock.Value : 0;
                numUnitsOnOrder.Value = product.UnitsOnOrder.HasValue ? product.UnitsOnOrder.Value : 0;
                cmbSupplier.SelectedValue = product.SupplierId;
                cmbCategory.SelectedValue = product.CategoryId.HasValue ? product.CategoryId : (object)DBNull.Value;
                chkDiscontinued.Checked = product.Discontinued;
            }
        }

        private void ProductEditForm_Load(object sender, EventArgs e)
        {
            FillCategoryComboBox();
            FillSupplierComboBox();

            ProductDataMapper productData = new ProductDataMapper();
            var product = productData.Get(_productId);
            FillFormByProduct(product);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var products = new ProductDataMapper();
            var product = CreateProductByForm();
            if (_productId == 0)
            {
                products.Insert(product);
            }
            else
            {
                product.Id = _productId;
                products.Update(product);
            }
            foreach (var item in MdiParent.MdiChildren)
            {
                if (item is ProductListForm)
                {
                    ((ProductListForm)item).RefreshGrid();
                    break;
                }
            }
            Dispose();
        }

        private Product CreateProductByForm()
        {
            return new Product()
            {
                ProductName = txtProductName.Text.Trim(),
                SupplierId = cmbSupplier.SelectedValue as int?,
                CategoryId = cmbCategory.SelectedValue as int?,
                QuantityPerUnit = txtQuantityPerUnit.Text.Trim(),
                UnitPrice = numUnitPrice.Value,
                UnitsInStock = (short)numUnitsInStock.Value,
                UnitsOnOrder = (short)numUnitsOnOrder.Value,
                ReorderLevel = (short)numReorderLevel.Value,
                Discontinued = chkDiscontinued.Checked
            };
        }

        private void FillCategoryComboBox()
        {
            var categoryMapper = new CategoryDataMapper();
            cmbCategory.DataSource = categoryMapper.GetAll();
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
        }

        private void FillSupplierComboBox()
        {
            var supplierMapper = new SupplierDataMapper();
            cmbSupplier.DataSource = supplierMapper.GetAll();
            cmbSupplier.DisplayMember = "CompanyName";
            cmbSupplier.ValueMember = "Id";
        }
    }
}
