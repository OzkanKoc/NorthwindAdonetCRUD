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

namespace AdoNetCRUD.Views
{
    public partial class OrderListForm : Form
    {
        public OrderListForm()
        {
            InitializeComponent();
        }

        private void OrderListForm_Load(object sender, EventArgs e)
        {
            gridOrder.AutoGenerateColumns = false;
            RefreshGrid();
        }

        public void RefreshGrid()
        {
            gridOrder.DataSource = new OrderDataMapper().GetAll();
        }

        private void ctxbtnDelete_Click(object sender, EventArgs e)
        {
            if (gridOrder.SelectedRows.Count > 0)
            {
                var selectedRow = gridOrder.SelectedRows[0];
                var cellId = selectedRow.Cells["colId"];
                var orderId = (int)cellId.Value;
                var dialogResult = MessageBox.Show($"{orderId}ID li ürün silinecek ! Devam etmek istermisiniz?", "Dikkat !", MessageBoxButtons.OKCancel);

                if (dialogResult == DialogResult.OK)
                {
                    new OrderDetailDataMapper().Delete(orderId);
                    new OrderDataMapper().Delete(orderId);
                    RefreshGrid();
                };
            }
        }

        private void gridOrder_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var orderId = (int)gridOrder.Rows[e.RowIndex].Cells["colId"].Value;

            var orderEditForm = new OrderEditForm(orderId);
            orderEditForm.MdiParent = MdiParent;
            orderEditForm.Show();
        }

        private void gridOrder_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            gridOrder.Rows[e.RowIndex].Selected = true;
        }

        private void ctxbtnOrderDetails_Click(object sender, EventArgs e)
        {
            if (gridOrder.SelectedRows.Count > 0)
            {
                int orderId = (int)gridOrder.SelectedRows[0].Cells["colId"].Value;
                ShowOrderDetailsListForm(orderId);
            }
        }

        private void ShowOrderDetailsListForm(int orderId)
        {
            var orderDetailsForm = new OrderDetailsListForm(orderId);
            orderDetailsForm.ShowDialog();
        }
    }
}
