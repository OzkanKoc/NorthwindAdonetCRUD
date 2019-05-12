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
    public partial class ShipperEditForm : Form
    {
        private int _shipperId;
        public ShipperEditForm()
        {
            InitializeComponent();
        }
        public ShipperEditForm(int shipperId) : this()
        {
            _shipperId = shipperId;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var shipperMapper = new ShipperDataMapper();
            var shipper = CreateShipperByForm();
            if (shipper.ShipperID == 0)
            {
                shipperMapper.Insert(shipper);
            }
            else
            {
                shipperMapper.Update(shipper);
            }
            RefreshListForm();
            Close();
        }

        private void RefreshListForm()
        {
            foreach (var childForm in MdiParent.MdiChildren)
            {
                if (childForm is ShipperListForm)
                {
                    ((ShipperListForm)childForm).RefreshGrid();
                }
            }
        }

        private Shipper CreateShipperByForm()
        {
            return new Shipper()
            {
                CompanyName = (txtCompanyName.Text),
                Phone = txtPhone.Text.Trim()
            };
        }
        private void ShipperEditForm_Load(object sender, EventArgs e)
        {
            var shipperMapper = new ShipperDataMapper();
            var shipper = shipperMapper.Get(_shipperId);
            FillFormByShipper(shipper);
        }
        private void FillFormByShipper(Shipper shipper)
        {
            if (shipper != null)
            {
                txtCompanyName.Text = shipper.CompanyName;
                txtPhone.Text = shipper.Phone;
            }
        }
    }
}
