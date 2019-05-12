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
    public partial class OrderDetailsListForm : Form
    {
        private int _orderId;

        public OrderDetailsListForm()
        {
            InitializeComponent();
        }

        public OrderDetailsListForm(int orderId) : this()
        {
            _orderId = orderId;
        }

        private void OrderDetailsListForm_Load(object sender, EventArgs e)
        {
            FillOrderDetailsGrid();
        }

        private void FillOrderDetailsGrid()
        {
            gridOrderDetails.DataSource = new OrderDetailDataMapper().Get(_orderId);
        }
    }
}
