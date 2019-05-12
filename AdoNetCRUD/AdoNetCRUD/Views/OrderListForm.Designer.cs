namespace AdoNetCRUD.Views
{
    partial class OrderListForm
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
            this.gridOrder = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxbtnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxbtnOrderDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShippedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShipVia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFreight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShipName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShipAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShipCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShipRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShipPostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShipCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrder)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridOrder
            // 
            this.gridOrder.AllowUserToAddRows = false;
            this.gridOrder.AllowUserToDeleteRows = false;
            this.gridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colCustomerId,
            this.colEmployeeId,
            this.colOrderDate,
            this.colRequireDate,
            this.colShippedDate,
            this.colShipVia,
            this.colFreight,
            this.colShipName,
            this.colShipAddress,
            this.colShipCity,
            this.colShipRegion,
            this.colShipPostalCode,
            this.colShipCountry});
            this.gridOrder.ContextMenuStrip = this.contextMenuStrip1;
            this.gridOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridOrder.Location = new System.Drawing.Point(0, 0);
            this.gridOrder.MultiSelect = false;
            this.gridOrder.Name = "gridOrder";
            this.gridOrder.ReadOnly = true;
            this.gridOrder.Size = new System.Drawing.Size(800, 450);
            this.gridOrder.TabIndex = 0;
            this.gridOrder.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.gridOrder_CellContextMenuStripNeeded);
            this.gridOrder.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridOrder_RowHeaderMouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxbtnDelete,
            this.ctxbtnOrderDetails});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 48);
            // 
            // ctxbtnDelete
            // 
            this.ctxbtnDelete.Name = "ctxbtnDelete";
            this.ctxbtnDelete.Size = new System.Drawing.Size(144, 22);
            this.ctxbtnDelete.Text = "Sil";
            this.ctxbtnDelete.Click += new System.EventHandler(this.ctxbtnDelete_Click);
            // 
            // ctxbtnOrderDetails
            // 
            this.ctxbtnOrderDetails.Name = "ctxbtnOrderDetails";
            this.ctxbtnOrderDetails.Size = new System.Drawing.Size(144, 22);
            this.ctxbtnOrderDetails.Text = "Sipariş Detayı";
            this.ctxbtnOrderDetails.Click += new System.EventHandler(this.ctxbtnOrderDetails_Click);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Sipariş Numarası";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colCustomerId
            // 
            this.colCustomerId.DataPropertyName = "CustomerId";
            this.colCustomerId.HeaderText = "Müşteri Numarası";
            this.colCustomerId.Name = "colCustomerId";
            this.colCustomerId.ReadOnly = true;
            // 
            // colEmployeeId
            // 
            this.colEmployeeId.DataPropertyName = "EmployeeId";
            this.colEmployeeId.HeaderText = "Çalışan Numarası";
            this.colEmployeeId.Name = "colEmployeeId";
            this.colEmployeeId.ReadOnly = true;
            // 
            // colOrderDate
            // 
            this.colOrderDate.DataPropertyName = "OrderDate";
            this.colOrderDate.HeaderText = "Sipariş Tarihi";
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.ReadOnly = true;
            // 
            // colRequireDate
            // 
            this.colRequireDate.DataPropertyName = "RequiredDate";
            this.colRequireDate.HeaderText = "Termin Tarihi";
            this.colRequireDate.Name = "colRequireDate";
            this.colRequireDate.ReadOnly = true;
            // 
            // colShippedDate
            // 
            this.colShippedDate.DataPropertyName = "ShippedDate";
            this.colShippedDate.HeaderText = "Sevk Tarihi";
            this.colShippedDate.Name = "colShippedDate";
            this.colShippedDate.ReadOnly = true;
            // 
            // colShipVia
            // 
            this.colShipVia.DataPropertyName = "ShipVia";
            this.colShipVia.HeaderText = "Kargo Hareket Numarası";
            this.colShipVia.Name = "colShipVia";
            this.colShipVia.ReadOnly = true;
            // 
            // colFreight
            // 
            this.colFreight.DataPropertyName = "Freight";
            this.colFreight.HeaderText = "Ücret";
            this.colFreight.Name = "colFreight";
            this.colFreight.ReadOnly = true;
            // 
            // colShipName
            // 
            this.colShipName.DataPropertyName = "ShipName";
            this.colShipName.HeaderText = "Kargo Adı";
            this.colShipName.Name = "colShipName";
            this.colShipName.ReadOnly = true;
            // 
            // colShipAddress
            // 
            this.colShipAddress.DataPropertyName = "ShipAddress";
            this.colShipAddress.HeaderText = "Adres";
            this.colShipAddress.Name = "colShipAddress";
            this.colShipAddress.ReadOnly = true;
            // 
            // colShipCity
            // 
            this.colShipCity.DataPropertyName = "ShipCity";
            this.colShipCity.HeaderText = "Şehir";
            this.colShipCity.Name = "colShipCity";
            this.colShipCity.ReadOnly = true;
            // 
            // colShipRegion
            // 
            this.colShipRegion.DataPropertyName = "ShipRegion";
            this.colShipRegion.HeaderText = "Bölge";
            this.colShipRegion.Name = "colShipRegion";
            this.colShipRegion.ReadOnly = true;
            // 
            // colShipPostalCode
            // 
            this.colShipPostalCode.DataPropertyName = "ShipPostalCode";
            this.colShipPostalCode.HeaderText = "Posta Kodu";
            this.colShipPostalCode.Name = "colShipPostalCode";
            this.colShipPostalCode.ReadOnly = true;
            // 
            // colShipCountry
            // 
            this.colShipCountry.DataPropertyName = "ShipCountry";
            this.colShipCountry.HeaderText = "Ülke";
            this.colShipCountry.Name = "colShipCountry";
            this.colShipCountry.ReadOnly = true;
            // 
            // OrderListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridOrder);
            this.Name = "OrderListForm";
            this.Text = "OrderListForm";
            this.Load += new System.EventHandler(this.OrderListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrder)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView gridOrder;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctxbtnDelete;
        private System.Windows.Forms.ToolStripMenuItem ctxbtnOrderDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShippedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShipVia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFreight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShipName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShipAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShipCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShipRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShipPostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShipCountry;
    }
}