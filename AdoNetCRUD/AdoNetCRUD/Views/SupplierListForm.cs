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
    public partial class SupplierListForm : Form
    {
        public SupplierListForm()
        {
            InitializeComponent();
        }
        public void RefreshGrid()
        {
            gridSupplier.DataSource = new SupplierDataMapper().GetAll();
        }

        private void SupplierListForm_Load(object sender, EventArgs e)
        {
            gridSupplier.AutoGenerateColumns = false;
            RefreshGrid();
        }

        private void ctxBtnDelete_Click(object sender, EventArgs e)
        {
            int supplierId = (int)gridSupplier.SelectedRows[0].Cells["colSupplierId"].Value;
            var confirmResult = MessageBox.Show($"Are you sure to delete this item(ID= {supplierId})?", "Confirm Delete!!", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                new SupplierDataMapper().Delete(supplierId);
                RefreshGrid();
            }
        }

        private void gridSupplier_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                gridSupplier.Rows[e.RowIndex].Selected = true;
            }
        }

        private void ctxBtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void gridSupplier_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var clickedIndex = e.RowIndex;
            var cell = gridSupplier.Rows[clickedIndex].Cells["colSupplierId"];
            var supplierId = (int)cell.Value;

            var supplierEditForm = new SupplierEditForm(supplierId);
            supplierEditForm.MdiParent = this.MdiParent;
            supplierEditForm.Show();
        }
    }
}
