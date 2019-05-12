using AdoNetCRUD.DataMappers;
using AdoNetCRUD.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetCRUD.Views
{
    public partial class RegionEditForm : Form
    {
        private int _regionId;

        public RegionEditForm()
        {
            InitializeComponent();
        }

        public RegionEditForm(int regionId) : this()
        {
            _regionId = regionId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var region = CreateRegionByForm();
            var regionDataMapper = new RegionDataMapper();
            if (_regionId == 0)
            {
                regionDataMapper.Insert(region);
            }
            else
            {
                region.Id = _regionId;
                regionDataMapper.Update(region);
            }
            Dispose();
        }

        private Region CreateRegionByForm()
        {
            return new Region
            {
                RegionDescription = rtxtRegionDescription.Text
            };
        }
    }
}
