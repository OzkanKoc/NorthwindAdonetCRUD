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
    public partial class EmployeeListForm : Form
    {
        public EmployeeListForm()
        {
            InitializeComponent();
        }

        private void EmployeeListForm_Load(object sender, EventArgs e)
        {
            gridEmployee.AutoGenerateColumns = false;
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            gridEmployee.DataSource = new EmployeeDataMapper().GettAll();
        }

        private void ctxBtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void ctxBtnDelete_Click(object sender, EventArgs e)
        {
            if (gridEmployee.SelectedRows.Count > 0)
            {
                int employeeId = (int)gridEmployee.SelectedRows[0].Cells["colEmployeeId"].Value;
                var confirmResult = MessageBox.Show($"Are you sure to delete this item(ID= {employeeId})?", "Confirm Delete!!", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    new SupplierDataMapper().Delete(employeeId);
                    RefreshGrid();
                }
            }
        }

        private void gridEmployee_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                gridEmployee.Rows[e.RowIndex].Selected = true;
            }
        }

        private void gridEmployee_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var clickedIndex = e.RowIndex;
            var cell = gridEmployee.Rows[clickedIndex].Cells["colEmployeeId"];
            var employeeId = (int)cell.Value;

            var employeeEditForm = new EmployeeEditForm(employeeId);
            employeeEditForm.MdiParent = this.MdiParent;
            employeeEditForm.Show();
        }
    }
}
