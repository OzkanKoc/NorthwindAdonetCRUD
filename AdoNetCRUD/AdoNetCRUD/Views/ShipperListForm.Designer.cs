namespace AdoNetCRUD
{
    partial class ShipperListForm
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
            this.gridShipper = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxbtnDelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridShipper)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridShipper
            // 
            this.gridShipper.AllowUserToAddRows = false;
            this.gridShipper.AllowUserToDeleteRows = false;
            this.gridShipper.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridShipper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridShipper.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colCompanyName,
            this.colPhone});
            this.gridShipper.ContextMenuStrip = this.contextMenuStrip1;
            this.gridShipper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridShipper.Location = new System.Drawing.Point(0, 0);
            this.gridShipper.MultiSelect = false;
            this.gridShipper.Name = "gridShipper";
            this.gridShipper.ReadOnly = true;
            this.gridShipper.Size = new System.Drawing.Size(800, 450);
            this.gridShipper.TabIndex = 0;
            this.gridShipper.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.gridShipper_CellContextMenuStripNeeded);
            this.gridShipper.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridShipper_RowHeaderMouseDoubleClick);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "ShipperId";
            this.colId.HeaderText = "Sipariş Numarası";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colCompanyName
            // 
            this.colCompanyName.DataPropertyName = "CompanyName";
            this.colCompanyName.HeaderText = "İsim";
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.ReadOnly = true;
            // 
            // colPhone
            // 
            this.colPhone.DataPropertyName = "Phone";
            this.colPhone.HeaderText = "Telefon";
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxbtnDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(87, 26);
            // 
            // ctxbtnDelete
            // 
            this.ctxbtnDelete.Name = "ctxbtnDelete";
            this.ctxbtnDelete.Size = new System.Drawing.Size(86, 22);
            this.ctxbtnDelete.Text = "Sil";
            this.ctxbtnDelete.Click += new System.EventHandler(this.ctxbtnDelete_Click);
            // 
            // ShipperListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridShipper);
            this.Name = "ShipperListForm";
            this.Text = "ShipperListForm";
            this.Load += new System.EventHandler(this.ShipperListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridShipper)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridShipper;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctxbtnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
    }
}