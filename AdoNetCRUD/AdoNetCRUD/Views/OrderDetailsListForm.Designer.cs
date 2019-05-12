namespace AdoNetCRUD
{
    partial class OrderDetailsListForm
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
            this.gridOrderDetails = new System.Windows.Forms.DataGridView();
            this.colOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // gridOrderDetails
            // 
            this.gridOrderDetails.AllowUserToAddRows = false;
            this.gridOrderDetails.AllowUserToDeleteRows = false;
            this.gridOrderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrderID,
            this.colProductId,
            this.colUnitPrice,
            this.colQuantity,
            this.colDiscount});
            this.gridOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridOrderDetails.Location = new System.Drawing.Point(0, 0);
            this.gridOrderDetails.MultiSelect = false;
            this.gridOrderDetails.Name = "gridOrderDetails";
            this.gridOrderDetails.ReadOnly = true;
            this.gridOrderDetails.Size = new System.Drawing.Size(800, 450);
            this.gridOrderDetails.TabIndex = 0;
            // 
            // colOrderID
            // 
            this.colOrderID.DataPropertyName = "OrderId";
            this.colOrderID.HeaderText = "Order Id";
            this.colOrderID.Name = "colOrderID";
            this.colOrderID.ReadOnly = true;
            // 
            // colProductId
            // 
            this.colProductId.DataPropertyName = "ProductId";
            this.colProductId.HeaderText = "Product Id";
            this.colProductId.Name = "colProductId";
            this.colProductId.ReadOnly = true;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.DataPropertyName = "UnitPrice";
            this.colUnitPrice.HeaderText = "Unit Price";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.ReadOnly = true;
            // 
            // colQuantity
            // 
            this.colQuantity.DataPropertyName = "Quantity";
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            // 
            // colDiscount
            // 
            this.colDiscount.DataPropertyName = "Discount";
            this.colDiscount.HeaderText = "Discount";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.ReadOnly = true;
            // 
            // OrderDetailsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridOrderDetails);
            this.Name = "OrderDetailsListForm";
            this.Text = "OrderDetailsListForm";
            this.Load += new System.EventHandler(this.OrderDetailsListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridOrderDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscount;
    }
}