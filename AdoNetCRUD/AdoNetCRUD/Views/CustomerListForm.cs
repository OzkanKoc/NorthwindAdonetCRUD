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
    public partial class CustomerListForm : Form
    {
        public CustomerListForm()
        {
            InitializeComponent();
        }

        private void CustomerListForm_Load(object sender, EventArgs e)
        {
            gridCustomer.AutoGenerateColumns = false;
            RefreshGrid();
        }

        public void RefreshGrid()
        {
            gridCustomer.DataSource = new CustomerDataMapper().GetAll();
        }

        private void gridCustomer_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var clickedIndex = e.RowIndex;
            var cell = gridCustomer.Rows[clickedIndex].Cells["colCustomerId"];
            var customerId = cell.Value;

            var customerEditForm = new CustomerEditForm(customerId.ToString());
            customerEditForm.MdiParent = MdiParent;
            customerEditForm.Show();
        }
    }
}
