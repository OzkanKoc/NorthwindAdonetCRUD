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

namespace AdoNetCRUD.Views
{
    public partial class CustomerEditForm : Form
    {
        private string _customerId = string.Empty;
        public CustomerEditForm()
        {
            InitializeComponent();
        }
        public CustomerEditForm(string customerId) : this()
        {
            _customerId = customerId;
        }
        private void CustomerEditForm_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_customerId))
            {
                var customerMapper = new CustomerDataMapper();
                var customer = customerMapper.Get(_customerId);
                FillFormByCustomer(customer);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var customerMapper = new CustomerDataMapper();
            var customer = CreateCustomertByForm();
            if (string.IsNullOrWhiteSpace(_customerId))
            {
                customerMapper.Insert(customer);
            }
            else
            {
                customerMapper.Update(customer);
            }
            RefreshListForm();
            Dispose();
        }
        private void RefreshListForm()
        {
            foreach (var childForm in MdiParent.MdiChildren)
            {
                if (childForm is CustomerListForm)
                {
                    ((CustomerListForm)childForm).RefreshGrid();
                }
            }
        }
        private Customer CreateCustomertByForm()
        {
            return new Customer()
            {
                Id = txtCustomerId.Text.Trim().ToUpper(),
                ContactName = txtContactName.Text.Trim(),
                CompanyName = txtCompanyName.Text.Trim(),
                ContactTitle = txtAddress.Text.Trim(),
                City = txtAddress.Text.Trim(),
                Region = txtRegion.Text.Trim(),
                PostalCode = txtPostalCode.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Country = txtCountry.Text.Trim(),
                Fax = txtFaks.Text.Trim(),

            };
        }
        private void FillFormByCustomer(Customer customer)
        {
            if (customer != null)
            {
                txtCustomerId.Text = customer.Id;
                txtCompanyName.Text = customer.CompanyName;
                txtContactName.Text = customer.ContactName;
                txtContactTitle.Text = customer.ContactTitle;
                txtCity.Text = customer.City;
                txtRegion.Text = customer.Region;
                txtPostalCode.Text = customer.PostalCode;
                txtPhone.Text = customer.Phone;
                txtCountry.Text = customer.Country;
                txtRegion.Text = customer.Region;
                txtFaks.Text = customer.Fax;
                txtAddress.Text = customer.Address;
            }
        }
    }
}
