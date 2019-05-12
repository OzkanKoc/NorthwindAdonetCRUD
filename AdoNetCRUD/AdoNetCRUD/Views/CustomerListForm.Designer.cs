namespace AdoNetCRUD.Views
{
    partial class CustomerListForm
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
            this.gridCustomer = new System.Windows.Forms.DataGridView();
            this.colCustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContactTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCustomer
            // 
            this.gridCustomer.AllowUserToAddRows = false;
            this.gridCustomer.AllowUserToDeleteRows = false;
            this.gridCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCustomerId,
            this.colCompanyName,
            this.colContactName,
            this.colContactTitle,
            this.colAddress,
            this.colCity,
            this.colRegion,
            this.colPostalCode,
            this.colCountry,
            this.colPhone,
            this.colFax});
            this.gridCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCustomer.Location = new System.Drawing.Point(0, 0);
            this.gridCustomer.MultiSelect = false;
            this.gridCustomer.Name = "gridCustomer";
            this.gridCustomer.ReadOnly = true;
            this.gridCustomer.Size = new System.Drawing.Size(800, 450);
            this.gridCustomer.TabIndex = 0;
            this.gridCustomer.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridCustomer_RowHeaderMouseDoubleClick);
            // 
            // colCustomerId
            // 
            this.colCustomerId.DataPropertyName = "Id";
            this.colCustomerId.HeaderText = "Id";
            this.colCustomerId.Name = "colCustomerId";
            this.colCustomerId.ReadOnly = true;
            // 
            // colCompanyName
            // 
            this.colCompanyName.DataPropertyName = "CompanyName";
            this.colCompanyName.HeaderText = "Company Name";
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.ReadOnly = true;
            // 
            // colContactName
            // 
            this.colContactName.DataPropertyName = "ContactName";
            this.colContactName.HeaderText = "Contact Name";
            this.colContactName.Name = "colContactName";
            this.colContactName.ReadOnly = true;
            // 
            // colContactTitle
            // 
            this.colContactTitle.DataPropertyName = "ContactTitle";
            this.colContactTitle.HeaderText = "Contact Title";
            this.colContactTitle.Name = "colContactTitle";
            this.colContactTitle.ReadOnly = true;
            // 
            // colAddress
            // 
            this.colAddress.DataPropertyName = "Address";
            this.colAddress.HeaderText = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            // 
            // colCity
            // 
            this.colCity.DataPropertyName = "City";
            this.colCity.HeaderText = "Şehir";
            this.colCity.Name = "colCity";
            this.colCity.ReadOnly = true;
            // 
            // colRegion
            // 
            this.colRegion.DataPropertyName = "Region";
            this.colRegion.HeaderText = "Bölge";
            this.colRegion.Name = "colRegion";
            this.colRegion.ReadOnly = true;
            // 
            // colPostalCode
            // 
            this.colPostalCode.DataPropertyName = "PostalCode";
            this.colPostalCode.HeaderText = "Posta Kodu";
            this.colPostalCode.Name = "colPostalCode";
            this.colPostalCode.ReadOnly = true;
            // 
            // colCountry
            // 
            this.colCountry.DataPropertyName = "Country";
            this.colCountry.HeaderText = "Ülke";
            this.colCountry.Name = "colCountry";
            this.colCountry.ReadOnly = true;
            // 
            // colPhone
            // 
            this.colPhone.DataPropertyName = "Phone";
            this.colPhone.HeaderText = "Telefon No";
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            // 
            // colFax
            // 
            this.colFax.DataPropertyName = "Fax";
            this.colFax.HeaderText = "Fax No";
            this.colFax.Name = "colFax";
            this.colFax.ReadOnly = true;
            // 
            // CustomerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridCustomer);
            this.Name = "CustomerListForm";
            this.Text = "CustomerListForm";
            this.Load += new System.EventHandler(this.CustomerListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContactName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContactTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFax;
    }
}