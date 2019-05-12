using AdoNetCRUD.DataMappers;
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
    public partial class CategoryListForm : Form
    {
        public CategoryListForm()
        {
            InitializeComponent();
        }

        private void CategoryListForm_Load(object sender, EventArgs e)
        {
            gridCategory.AutoGenerateColumns = false;
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            gridCategory.DataSource = new CategoryDataMapper().GetAll();
        }

        private void gridCategory_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                gridCategory.Rows[e.RowIndex].Selected = true;
            }
        }

        private void ctxBtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void ctxBtnDelete_Click(object sender, EventArgs e)
        {
            int categoryId = (int)gridCategory.SelectedRows[0].Cells["colCategoryId"].Value;
            var confirmResult = MessageBox.Show($"Are you sure to delete this item(ID= {categoryId})?", "Confirm Delete!!", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                new CategoryDataMapper().Delete(categoryId);
            }
        }

        private void gridCategory_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var clickedIndex = e.RowIndex;
            var cell = gridCategory.Rows[clickedIndex].Cells["colCategoryId"];
            var categoryId = (int)cell.Value;

            var categoryEditForm = new CategoryEditForm(categoryId);
            categoryEditForm.MdiParent = this.MdiParent;
            categoryEditForm.Show();
        }
    }
}
