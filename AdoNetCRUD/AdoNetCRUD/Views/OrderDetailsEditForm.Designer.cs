namespace AdoNetCRUD
{
    partial class OrderDetailsEditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddBasket = new System.Windows.Forms.Button();
            this.numDiscount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbProductId = new System.Windows.Forms.ComboBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.colDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitsPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridOrderDetails = new System.Windows.Forms.DataGridView();
            this.btnEnd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Adedi : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "İndirim Tutarı";
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(228, 202);
            this.numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(190, 20);
            this.numQuantity.TabIndex = 4;
            this.numQuantity.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnAddBasket
            // 
            this.btnAddBasket.Location = new System.Drawing.Point(147, 395);
            this.btnAddBasket.Name = "btnAddBasket";
            this.btnAddBasket.Size = new System.Drawing.Size(88, 30);
            this.btnAddBasket.TabIndex = 6;
            this.btnAddBasket.Text = "Sepete Ekle";
            this.btnAddBasket.UseVisualStyleBackColor = true;
            this.btnAddBasket.Click += new System.EventHandler(this.btnAddBasket_Click);
            // 
            // numDiscount
            // 
            this.numDiscount.Location = new System.Drawing.Point(228, 271);
            this.numDiscount.Name = "numDiscount";
            this.numDiscount.Size = new System.Drawing.Size(190, 20);
            this.numDiscount.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Birim Fiyat";
            // 
            // cmbProductId
            // 
            this.cmbProductId.FormattingEnabled = true;
            this.cmbProductId.Location = new System.Drawing.Point(228, 92);
            this.cmbProductId.Name = "cmbProductId";
            this.cmbProductId.Size = new System.Drawing.Size(190, 21);
            this.cmbProductId.TabIndex = 10;
            this.cmbProductId.SelectedIndexChanged += new System.EventHandler(this.cmbProductId_SelectedIndexChanged);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Enabled = false;
            this.txtUnitPrice.Location = new System.Drawing.Point(228, 144);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(190, 20);
            this.txtUnitPrice.TabIndex = 11;
            // 
            // colDiscount
            // 
            this.colDiscount.DataPropertyName = "Discount";
            this.colDiscount.HeaderText = "İndirim Tutarı";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.ReadOnly = true;
            // 
            // colUnitsPrice
            // 
            this.colUnitsPrice.DataPropertyName = "UnitPrice";
            this.colUnitsPrice.HeaderText = "Birim Fiyatı";
            this.colUnitsPrice.Name = "colUnitsPrice";
            this.colUnitsPrice.ReadOnly = true;
            // 
            // colQuantity
            // 
            this.colQuantity.DataPropertyName = "Quantity";
            this.colQuantity.HeaderText = "Ürün Adedi";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "ProductId";
            this.colId.HeaderText = "Ürün Adı";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // gridOrderDetails
            // 
            this.gridOrderDetails.AllowUserToAddRows = false;
            this.gridOrderDetails.AllowUserToDeleteRows = false;
            this.gridOrderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colQuantity,
            this.colUnitsPrice,
            this.colDiscount});
            this.gridOrderDetails.Location = new System.Drawing.Point(459, 92);
            this.gridOrderDetails.Name = "gridOrderDetails";
            this.gridOrderDetails.ReadOnly = true;
            this.gridOrderDetails.Size = new System.Drawing.Size(482, 219);
            this.gridOrderDetails.TabIndex = 13;
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(343, 395);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 27);
            this.btnEnd.TabIndex = 14;
            this.btnEnd.Text = "Bitir";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // OrderDetailsEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 450);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.gridOrderDetails);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.cmbProductId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numDiscount);
            this.Controls.Add(this.btnAddBasket);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OrderDetailsEditForm";
            this.Text = "OrderDetailsEditForm";
            this.Load += new System.EventHandler(this.OrderDetailsEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Button btnAddBasket;
        private System.Windows.Forms.NumericUpDown numDiscount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbProductId;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitsPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridView gridOrderDetails;
        private System.Windows.Forms.Button btnEnd;
    }
}