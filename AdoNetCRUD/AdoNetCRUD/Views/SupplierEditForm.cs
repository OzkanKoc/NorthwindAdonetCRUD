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
    public partial class SupplierEditForm : Form
    {
        private int _supplierId;

        public SupplierEditForm()
        {
            InitializeComponent();
        }

        public SupplierEditForm(int supplierId) : this()
        {
            _supplierId = supplierId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var supplier = CreateSupplierByForm();
            var supplierDataMapper = new SupplierDataMapper();
            if (_supplierId == 0)
            {
                supplierDataMapper.Insert(supplier);
            }
            else
            {
                supplier.Id = _supplierId;
                supplierDataMapper.Update(supplier);
            }
            Dispose();
        }

        private Supplier CreateSupplierByForm()
        {
            return new Supplier
            {
                CompanyName = txtCompanyName.Text,
                ContactName = txtContactName.Text,
                ContactTitle = txtContactTitle.Text,
                Region = txtRegion.Text,
                Phone = txtPhoneNumber.Text,
                Fax = txtFaxNumber.Text,
                City = txtCity.Text,
                Country = txtCountry.Text,
                Address = txtAddress.Text,
                PostalCode = txtPostalCode.Text,
                HomePage = txtHomePage.Text
            };
        }

        private void SupplierEditForm_Load(object sender, EventArgs e)
        {
            SupplierDataMapper supplierDataMapper = new SupplierDataMapper();
            var supplier = supplierDataMapper.Get(_supplierId);
            FillFormBySupplier(supplier);
        }

        private void FillFormBySupplier(Supplier supplier)
        {
            if (supplier != null)
            {
                txtAddress.Text = supplier.Address;
                txtPhoneNumber.Text = supplier.Phone;
                txtCity.Text = supplier.City;
                txtCountry.Text = supplier.Country;
                txtCompanyName.Text = supplier.CompanyName;
                txtContactName.Text = supplier.ContactName;
                txtContactTitle.Text = supplier.ContactTitle;
                txtHomePage.Text = supplier.HomePage;
                txtPostalCode.Text = supplier.PostalCode;
                txtFaxNumber.Text = supplier.Fax;
                txtRegion.Text = supplier.Region;
            }
        }
    }
}
