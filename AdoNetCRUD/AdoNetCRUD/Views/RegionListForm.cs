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
    public partial class RegionListForm : Form
    {
        public RegionListForm()
        {
            InitializeComponent();
        }

        private void RegionListForm_Load(object sender, EventArgs e)
        {
            gridRegion.AutoGenerateColumns = false;
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            gridRegion.DataSource = new RegionDataMapper().GetAll();
        }

        private void gridRegion_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var clickedIndex = e.RowIndex;
            var cell = gridRegion.Rows[clickedIndex].Cells["colRegionId"];
            var regionId = (int)cell.Value;

            var regionEditForm = new RegionEditForm(regionId);
            regionEditForm.MdiParent = this.MdiParent;
            regionEditForm.Show();
        }

        private void gridRegion_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                gridRegion.Rows[e.RowIndex].Selected = true;
            }
        }

        private void ctxBtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void ctxBtnDelete_Click(object sender, EventArgs e)
        {
            int regionId = (int)gridRegion.SelectedRows[0].Cells["colRegionId"].Value;
            var confirmResult = MessageBox.Show($"Are you sure to delete this item(ID= {regionId})?", "Confirm Delete!!", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                new RegionDataMapper().Delete(regionId);
                RefreshGrid();
            }
        }
    }
}
