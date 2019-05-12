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
    public partial class TerritoryEditForm : Form
    {
        private string _territoryId;

        public TerritoryEditForm()
        {
            InitializeComponent();
        }

        public TerritoryEditForm(string territoryId) : this()
        {
            _territoryId = territoryId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var territoryMapper = new TerritoryDataMapper();
            var territory = CreateTerritoryByForm();
            if (!string.IsNullOrEmpty(_territoryId))
            {
                territoryMapper.Insert(territory);
            }
            else
            {
                territoryMapper.Insert(territory);
            }
            RefreshListForm();
            Dispose();
        }

        private void RefreshListForm()
        {
            foreach (var item in MdiParent.MdiChildren)
            {
                if (item is TerritoryListForm)
                {
                    ((TerritoryListForm)item).RefreshGrid();
                }
            }
        }

        private Territory CreateTerritoryByForm()
        {
            return new Territory()
            {
                Id = mtxTerritoryId.Text,
                TerritoryDescription = txtterritoryDescription.Text.Trim(),
                RegionID = (int)numRegionId.Value
            };
        }

        private void FillFormByTerritory(Territory territory)
        {
            if (territory != null)
            {
                mtxTerritoryId.Text = territory.Id;
                txtterritoryDescription.Text = territory.TerritoryDescription;
                numRegionId.Value = territory.RegionID;
            }
        }

        private void TerritoryEditForm_Load(object sender, EventArgs e)
        {
            var territoryMapper = new TerritoryDataMapper();
            var territory = territoryMapper.Get(_territoryId);
            FillFormByTerritory(territory);
        }
    }
}
