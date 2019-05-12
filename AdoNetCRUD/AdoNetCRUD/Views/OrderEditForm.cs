using AdoNetCRUD.DataMappers;
using AdoNetCRUD.Entities;
using AdoNetCRUD.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetCRUD.Views
{
    public partial class OrderEditForm : Form
    {
        private int _orderId;
        private List<OrderDetail> _orderDetailsList = new List<OrderDetail>();

        public OrderEditForm()
        {
            InitializeComponent();
        }

        public OrderEditForm(int orderId) : this()
        {
            _orderId = orderId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InsertToOrderDB();
            InsertToOrderDetailsDB();
            Dispose();
        }

        private void InsertToOrderDetailsDB()
        {
            var orderDetailsMapper = new OrderDetailDataMapper();
            int index = GetLastIdFromOrder();

            foreach (var item in _orderDetailsList)
            {
                item.OrderId = index;
                orderDetailsMapper.Insert(item);
            }
        }

        private int GetLastIdFromOrder()
        {
            int index = 0;
            var ordarMapper = new OrderDataMapper();
            var commandText = "select top 1 * FROM Orders ORDER BY OrderID DESC";

            var dbCommand = default(SqlCommand);

            try
            {
                dbCommand = DbHelper.CreateCommand(commandText);
                index = (int)dbCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("OrderId alınamadı..");
            }
            finally
            {
                dbCommand?.Connection?.Dispose();
                dbCommand?.Dispose();
            }

            return index;
        }

        private void InsertToOrderDB()
        {
            var orderMapper = new OrderDataMapper();
            var order = CreateOrderByForm();
            if (order.Id == 0)
            {
                orderMapper.Insert(order);
            }
            else
            {
                orderMapper.Update(order);
            }
            RefreshListForm();
        }

        private void RefreshListForm()
        {
            foreach (var item in MdiParent.MdiChildren)
            {
                if (item is OrderListForm)
                {
                    ((OrderListForm)item).RefreshGrid();
                }
            }
        }

        private Order CreateOrderByForm()
        {
            return new Order()
            {
                Id = _orderId,
                CustomerId = cmbCustomer.SelectedValue as string,
                EmployeeId = cmbEmployeeId.SelectedValue as int?,
                OrderDate = dtpOrderDate.Value,
                RequiredDate = dtpRequiredDate.Value,
                ShippedDate = dtpShipDate.Value,
                ShipVia = cmbShipVia.SelectedValue as int?,
                Freight = numFeright.Value,
                ShipName = txtShipName.Text.Trim(),
                ShipAddress = txtShipName.Text.Trim(),
                ShipCity = txtShipCity.Text.Trim(),
                ShipRegion = txtRegion.Text.Trim(),
                ShipPostalCode = txtPostalCode.Text.Trim(),
                ShipCountry = txtCountry.Text.Trim()
            };
        }

        private void OrderEditForm_Load(object sender, EventArgs e)
        {
            var orderMapper = new OrderDataMapper();
            var order = orderMapper.Get(_orderId);
            FillCustomerComboBox();
            FillShipperComboBox();
            FillEmployeeComboBox();
        }

        private void FillCustomerComboBox()
        {
            var customerMapper = new CustomerDataMapper();
            cmbCustomer.DataSource = customerMapper.GetAll();
            cmbCustomer.DisplayMember = "CompanyName";
            cmbCustomer.ValueMember = "Id";
        }

        private void FillShipperComboBox()
        {
            var shipperMapper = new ShipperDataMapper();
            cmbShipVia.DataSource = shipperMapper.GetAll();
            cmbShipVia.DisplayMember = "CompanyName";
            cmbShipVia.ValueMember = "ShipperID";
        }

        private void FillEmployeeComboBox()
        {
            var employeeMapper = new EmployeeDataMapper();
            cmbEmployeeId.DataSource = employeeMapper.GettAll();
            cmbEmployeeId.DisplayMember = "FullName";
            cmbEmployeeId.ValueMember = "Id";
        }

        private void FillFormByOrder(Order order)
        {
            if (order != null)
            {
                cmbCustomer.SelectedValue = order.CustomerId;
                cmbEmployeeId.SelectedValue = order.EmployeeId.HasValue
                    ? order.EmployeeId.Value
                    : 0;
                dtpOrderDate.Value = (DateTime)order.OrderDate;
                dtpRequiredDate.Value = (DateTime)order.RequiredDate;
                dtpShipDate.Value = (DateTime)order.ShippedDate;
                numFeright.Value = order.Freight.HasValue ? order.Freight.Value : 0;
                txtShipName.Text = order.ShipName;
                txtShipAddress.Text = order.ShipAddress;
                txtShipCity.Text = order.ShipCity;
                txtRegion.Text = order.ShipRegion;
                txtPostalCode.Text = order.ShipPostalCode;
                txtCountry.Text = order.ShipCountry;
                cmbShipVia.SelectedValue = order.ShipVia.HasValue
                                             ? order.ShipVia.Value
                                            : 0;
            };
        }

        private void btnOrderInsert_Click(object sender, EventArgs e)
        {
            OrderDetailsEditForm odEditForm = new OrderDetailsEditForm(_orderDetailsList, gridOrder);
            odEditForm.Owner = this;
            odEditForm.Show();
        }
    }
}