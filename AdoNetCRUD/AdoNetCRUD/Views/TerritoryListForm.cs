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
    public partial class TerritoryListForm : Form
    {
        public TerritoryListForm()
        {
            InitializeComponent();
        }

        private void TerritoryListForm_Load(object sender, EventArgs e)
        {
            gridTerritory.AutoGenerateColumns = false;
            RefreshGrid();
        }

        public void RefreshGrid()
        {
            gridTerritory.DataSource = new TerritoryDataMapper().GetAll();
        }

        private void ctxbtndelete_Click(object sender, EventArgs e)
        {
            if (gridTerritory.SelectedRows.Count > 0)
            {
                var territoryId = gridTerritory.SelectedRows[0].Cells["colId"].Value;
                var dialogResult = MessageBox.Show($"{territoryId}ID li ürün silinecek ! Devam etmek istermisiniz?", "Dikkat !", MessageBoxButtons.OKCancel);

                if (dialogResult == DialogResult.OK)
                {
                    var territoryMapper = new TerritoryDataMapper();
                    territoryMapper.Delete(territoryId.ToString());
                    RefreshGrid();
                }
            }
        }

        private void gridTerritory_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var territoryId = (string)gridTerritory.Rows[e.RowIndex].Cells["colId"].Value;

            var territoryEditForm = new TerritoryEditForm(territoryId);
            territoryEditForm.MdiParent = MdiParent;
            territoryEditForm.Show();
        }

        private void gridTerritory_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                gridTerritory.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}


