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
    public partial class ShipperListForm : Form
    {
        public ShipperListForm()
        {
            InitializeComponent();
        }

        private void ctxbtnDelete_Click(object sender, EventArgs e)
        {
            var selectedRow = gridShipper.SelectedRows[0];
            var cellId = selectedRow.Cells["colId"];
            var shipperId = (int)cellId.Value;
            var dialogResult = MessageBox.Show($"{shipperId}ID li ürün silinecek ! Devam etmek istermisiniz?", "Dikkat !", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                var shipperMapper = new ShipperDataMapper();
                shipperMapper.Delete(shipperId);
                RefreshGrid();
            }
        }

        private void ShipperListForm_Load(object sender, EventArgs e)
        {
            gridShipper.AutoGenerateColumns = false;
            RefreshGrid();
        }

        public void RefreshGrid()
        {
            gridShipper.DataSource = new ShipperDataMapper().GetAll();
        }

        private void gridShipper_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            gridShipper.Rows[e.RowIndex].Selected = true;
        }

        private void gridShipper_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var clickedIndex = e.RowIndex;
            var cell = gridShipper.Rows[clickedIndex].Cells["colId"];
            var shipperId = (int)cell.Value;

            var shipperEditForm = new ShipperEditForm(shipperId);
            shipperEditForm.MdiParent = MdiParent;
            shipperEditForm.Show();
        }
    }
    
}
