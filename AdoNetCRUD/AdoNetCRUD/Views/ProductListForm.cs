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
    public partial class ProductListForm : Form
    {
        public ProductListForm()
        {
            InitializeComponent();
        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
            gridProducts.AutoGenerateColumns = false;
            RefreshGrid();
        }

        private void gridProducts_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var clickedIndex = e.RowIndex;
            var cell = gridProducts.Rows[clickedIndex].Cells["colProductId"];
            var productId = (int)cell.Value;

            var productEditForm = new ProductEditForm(productId);
            productEditForm.MdiParent = this.MdiParent;
            productEditForm.Show();
        }

        public void RefreshGrid()
        {
            gridProducts.DataSource = new ProductDataMapper().GettAll();
        }

        private void ctxBtnDelete_Click(object sender, EventArgs e)
        {
            int productId = (int)gridProducts.SelectedRows[0].Cells["colProductId"].Value;
            var confirmResult = MessageBox.Show($"Are you sure to delete this item(ID= {productId})?", "Confirm Delete!!", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                new ProductDataMapper().Delete(productId);
                RefreshGrid();
            }
        }

        private void gridProducts_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                gridProducts.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}
