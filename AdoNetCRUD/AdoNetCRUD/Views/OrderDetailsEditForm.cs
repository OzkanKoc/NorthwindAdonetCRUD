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
    public partial class OrderDetailsEditForm : Form
    {
        private int _orderId;
        private List<OrderDetail> _orderDetailsList;
        private DataGridView _gridViewOrder;

        public OrderDetailsEditForm()
        {
            InitializeComponent();
        }

        public OrderDetailsEditForm(List<OrderDetail> orderDetailsList, DataGridView gridViewOrder)
            : this()
        {
            _orderDetailsList = orderDetailsList;
            _gridViewOrder = gridViewOrder;
        }

        public OrderDetailsEditForm(int orderId) : this()
        {
            _orderId = orderId;
        }

        private void OrderDetailsEditForm_Load(object sender, EventArgs e)
        {
            FillProductComboBox();
        }

        private void FillProductComboBox()
        {
            var productMapper = new ProductDataMapper();
            cmbProductId.DataSource = productMapper.GettAll();
            cmbProductId.DisplayMember = "ProductName";
            cmbProductId.ValueMember = "Id";
        }

        private OrderDetail CreateOrderDetailByForm()
        {
            return new OrderDetail()
            {
                ProductId = cmbProductId.SelectedIndex + 1,
                UnitPrice = decimal.Parse(txtUnitPrice.Text.Trim()),
                Quantity = (short)numQuantity.Value,
                Discount = ((float)numDiscount.Value) / 100
            };
        }

        private void btnAddBasket_Click(object sender, EventArgs e)
        {
            var orderDetail = CreateOrderDetailByForm();

            if (!isContain(orderDetail))
            {
                _orderDetailsList.Add(orderDetail);
            }

            gridOrderDetails.DataSource = null;
            gridOrderDetails.DataSource = _orderDetailsList;
        }

        private bool isContain(OrderDetail orderDetail)
        {
            foreach (var item in _orderDetailsList)
            {
                if (item.ProductId == orderDetail.ProductId)
                {
                    item.Quantity += orderDetail.Quantity;
                    return true;
                }
            }

            return false;
        }

        private void cmbProductId_SelectedIndexChanged(object sender, EventArgs e)
        {
            var product = new ProductDataMapper().Get(cmbProductId.SelectedIndex + 1);
            txtUnitPrice.Text = product.UnitPrice.ToString();
            numDiscount.Value = numDiscount.Minimum;
            numQuantity.Value = numQuantity.Minimum;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            _gridViewOrder.DataSource = null;
            _gridViewOrder.DataSource = _orderDetailsList;
            Dispose();
        }
    }
}
