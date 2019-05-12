namespace AdoNetCRUD
{
    partial class TerritoryListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridTerritory = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTerritoryDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxbtndelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridTerritory)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridTerritory
            // 
            this.gridTerritory.AllowUserToAddRows = false;
            this.gridTerritory.AllowUserToDeleteRows = false;
            this.gridTerritory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTerritory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTerritory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colTerritoryDescription,
            this.colRegionId});
            this.gridTerritory.ContextMenuStrip = this.contextMenuStrip1;
            this.gridTerritory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTerritory.Location = new System.Drawing.Point(0, 0);
            this.gridTerritory.MultiSelect = false;
            this.gridTerritory.Name = "gridTerritory";
            this.gridTerritory.ReadOnly = true;
            this.gridTerritory.Size = new System.Drawing.Size(800, 450);
            this.gridTerritory.TabIndex = 0;
            this.gridTerritory.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.gridTerritory_CellContextMenuStripNeeded);
            this.gridTerritory.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridTerritory_CellMouseDoubleClick);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colTerritoryDescription
            // 
            this.colTerritoryDescription.DataPropertyName = "TerritoryDescription";
            this.colTerritoryDescription.HeaderText = "Bölge Açıklaması";
            this.colTerritoryDescription.Name = "colTerritoryDescription";
            this.colTerritoryDescription.ReadOnly = true;
            // 
            // colRegionId
            // 
            this.colRegionId.DataPropertyName = "RegionID";
            this.colRegionId.HeaderText = "Bölge Id";
            this.colRegionId.Name = "colRegionId";
            this.colRegionId.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxbtndelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(87, 26);
            // 
            // ctxbtndelete
            // 
            this.ctxbtndelete.Name = "ctxbtndelete";
            this.ctxbtndelete.Size = new System.Drawing.Size(86, 22);
            this.ctxbtndelete.Text = "Sil";
            this.ctxbtndelete.Click += new System.EventHandler(this.ctxbtndelete_Click);
            // 
            // TerritoryListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridTerritory);
            this.Name = "TerritoryListForm";
            this.Text = "TerritoryListForm";
            this.Load += new System.EventHandler(this.TerritoryListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTerritory)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridTerritory;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctxbtndelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTerritoryDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegionId;
    }
}