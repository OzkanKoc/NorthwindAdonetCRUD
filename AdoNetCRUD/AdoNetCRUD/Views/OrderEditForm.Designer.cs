namespace AdoNetCRUD.Views
{
    partial class OrderEditForm
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

            {
                this.label1 = new System.Windows.Forms.Label();
                this.label2 = new System.Windows.Forms.Label();
                this.label3 = new System.Windows.Forms.Label();
                this.label4 = new System.Windows.Forms.Label();
                this.label5 = new System.Windows.Forms.Label();
                this.label6 = new System.Windows.Forms.Label();
                this.label7 = new System.Windows.Forms.Label();
                this.label8 = new System.Windows.Forms.Label();
                this.label9 = new System.Windows.Forms.Label();
                this.label10 = new System.Windows.Forms.Label();
                this.label11 = new System.Windows.Forms.Label();
                this.label12 = new System.Windows.Forms.Label();
                this.label13 = new System.Windows.Forms.Label();
                this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
                this.dtpRequiredDate = new System.Windows.Forms.DateTimePicker();
                this.dtpShipDate = new System.Windows.Forms.DateTimePicker();
                this.numFeright = new System.Windows.Forms.NumericUpDown();
                this.txtShipName = new System.Windows.Forms.TextBox();
                this.txtShipAddress = new System.Windows.Forms.TextBox();
                this.txtShipCity = new System.Windows.Forms.TextBox();
                this.txtRegion = new System.Windows.Forms.TextBox();
                this.txtPostalCode = new System.Windows.Forms.TextBox();
                this.txtCountry = new System.Windows.Forms.TextBox();
                this.btnSave = new System.Windows.Forms.Button();
                this.cmbShipVia = new System.Windows.Forms.ComboBox();
                this.cmbEmployeeId = new System.Windows.Forms.ComboBox();
                this.cmbCustomer = new System.Windows.Forms.ComboBox();
                this.gridOrder = new System.Windows.Forms.DataGridView();
                this.btnOrderInsert = new System.Windows.Forms.Button();
                ((System.ComponentModel.ISupportInitialize)(this.numFeright)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.gridOrder)).BeginInit();
                this.SuspendLayout();
                // 
                // label1
                // 
                this.label1.AutoSize = true;
                this.label1.Location = new System.Drawing.Point(32, 29);
                this.label1.Name = "label1";
                this.label1.Size = new System.Drawing.Size(88, 13);
                this.label1.TabIndex = 0;
                this.label1.Text = "Müşteri Numarası";
                // 
                // label2
                // 
                this.label2.AutoSize = true;
                this.label2.Location = new System.Drawing.Point(32, 78);
                this.label2.Name = "label2";
                this.label2.Size = new System.Drawing.Size(88, 13);
                this.label2.TabIndex = 1;
                this.label2.Text = "Çalışan Numarası";
                // 
                // label3
                // 
                this.label3.AutoSize = true;
                this.label3.Location = new System.Drawing.Point(33, 126);
                this.label3.Name = "label3";
                this.label3.Size = new System.Drawing.Size(67, 13);
                this.label3.TabIndex = 2;
                this.label3.Text = "Sipariş Tarihi";
                // 
                // label4
                // 
                this.label4.AutoSize = true;
                this.label4.Location = new System.Drawing.Point(32, 174);
                this.label4.Name = "label4";
                this.label4.Size = new System.Drawing.Size(68, 13);
                this.label4.TabIndex = 3;
                this.label4.Text = "Termin Tarihi";
                // 
                // label5
                // 
                this.label5.AutoSize = true;
                this.label5.Location = new System.Drawing.Point(32, 222);
                this.label5.Name = "label5";
                this.label5.Size = new System.Drawing.Size(61, 13);
                this.label5.TabIndex = 4;
                this.label5.Text = "Sevk Tarihi";
                // 
                // label6
                // 
                this.label6.AutoSize = true;
                this.label6.Location = new System.Drawing.Point(33, 321);
                this.label6.Name = "label6";
                this.label6.Size = new System.Drawing.Size(33, 13);
                this.label6.TabIndex = 5;
                this.label6.Text = "Ücret";
                // 
                // label7
                // 
                this.label7.AutoSize = true;
                this.label7.Location = new System.Drawing.Point(433, 77);
                this.label7.Name = "label7";
                this.label7.Size = new System.Drawing.Size(34, 13);
                this.label7.TabIndex = 6;
                this.label7.Text = "Adres";
                // 
                // label8
                // 
                this.label8.AutoSize = true;
                this.label8.Location = new System.Drawing.Point(433, 125);
                this.label8.Name = "label8";
                this.label8.Size = new System.Drawing.Size(31, 13);
                this.label8.TabIndex = 7;
                this.label8.Text = "Şehir";
                // 
                // label9
                // 
                this.label9.AutoSize = true;
                this.label9.Location = new System.Drawing.Point(433, 173);
                this.label9.Name = "label9";
                this.label9.Size = new System.Drawing.Size(34, 13);
                this.label9.TabIndex = 8;
                this.label9.Text = "Bölge";
                // 
                // label10
                // 
                this.label10.AutoSize = true;
                this.label10.Location = new System.Drawing.Point(433, 221);
                this.label10.Name = "label10";
                this.label10.Size = new System.Drawing.Size(62, 13);
                this.label10.TabIndex = 9;
                this.label10.Text = "Posta Kodu";
                // 
                // label11
                // 
                this.label11.AutoSize = true;
                this.label11.Location = new System.Drawing.Point(433, 269);
                this.label11.Name = "label11";
                this.label11.Size = new System.Drawing.Size(29, 13);
                this.label11.TabIndex = 10;
                this.label11.Text = "Ülke";
                // 
                // label12
                // 
                this.label12.AutoSize = true;
                this.label12.Location = new System.Drawing.Point(32, 270);
                this.label12.Name = "label12";
                this.label12.Size = new System.Drawing.Size(123, 13);
                this.label12.TabIndex = 11;
                this.label12.Text = "Kargo Hareket Numarası";
                // 
                // label13
                // 
                this.label13.AutoSize = true;
                this.label13.Location = new System.Drawing.Point(433, 28);
                this.label13.Name = "label13";
                this.label13.Size = new System.Drawing.Size(56, 13);
                this.label13.TabIndex = 12;
                this.label13.Text = "Kargo İsmi";
                // 
                // dtpOrderDate
                // 
                this.dtpOrderDate.Location = new System.Drawing.Point(192, 126);
                this.dtpOrderDate.Name = "dtpOrderDate";
                this.dtpOrderDate.Size = new System.Drawing.Size(192, 20);
                this.dtpOrderDate.TabIndex = 2;
                // 
                // dtpRequiredDate
                // 
                this.dtpRequiredDate.Location = new System.Drawing.Point(192, 166);
                this.dtpRequiredDate.Name = "dtpRequiredDate";
                this.dtpRequiredDate.Size = new System.Drawing.Size(192, 20);
                this.dtpRequiredDate.TabIndex = 3;
                // 
                // dtpShipDate
                // 
                this.dtpShipDate.Location = new System.Drawing.Point(192, 214);
                this.dtpShipDate.Name = "dtpShipDate";
                this.dtpShipDate.Size = new System.Drawing.Size(192, 20);
                this.dtpShipDate.TabIndex = 4;
                // 
                // numFeright
                // 
                this.numFeright.Location = new System.Drawing.Point(192, 313);
                this.numFeright.Name = "numFeright";
                this.numFeright.Size = new System.Drawing.Size(192, 20);
                this.numFeright.TabIndex = 6;
                // 
                // txtShipName
                // 
                this.txtShipName.Location = new System.Drawing.Point(569, 21);
                this.txtShipName.Name = "txtShipName";
                this.txtShipName.Size = new System.Drawing.Size(146, 20);
                this.txtShipName.TabIndex = 7;
                // 
                // txtShipAddress
                // 
                this.txtShipAddress.Location = new System.Drawing.Point(569, 69);
                this.txtShipAddress.Name = "txtShipAddress";
                this.txtShipAddress.Size = new System.Drawing.Size(146, 20);
                this.txtShipAddress.TabIndex = 8;
                // 
                // txtShipCity
                // 
                this.txtShipCity.Location = new System.Drawing.Point(569, 118);
                this.txtShipCity.Name = "txtShipCity";
                this.txtShipCity.Size = new System.Drawing.Size(146, 20);
                this.txtShipCity.TabIndex = 9;
                // 
                // txtRegion
                // 
                this.txtRegion.Location = new System.Drawing.Point(569, 166);
                this.txtRegion.Name = "txtRegion";
                this.txtRegion.Size = new System.Drawing.Size(146, 20);
                this.txtRegion.TabIndex = 10;
                // 
                // txtPostalCode
                // 
                this.txtPostalCode.Location = new System.Drawing.Point(569, 219);
                this.txtPostalCode.Name = "txtPostalCode";
                this.txtPostalCode.Size = new System.Drawing.Size(146, 20);
                this.txtPostalCode.TabIndex = 11;
                // 
                // txtCountry
                // 
                this.txtCountry.Location = new System.Drawing.Point(569, 267);
                this.txtCountry.Name = "txtCountry";
                this.txtCountry.Size = new System.Drawing.Size(146, 20);
                this.txtCountry.TabIndex = 12;
                // 
                // btnSave
                // 
                this.btnSave.Location = new System.Drawing.Point(62, 584);
                this.btnSave.Name = "btnSave";
                this.btnSave.Size = new System.Drawing.Size(603, 44);
                this.btnSave.TabIndex = 13;
                this.btnSave.Text = "Kaydet";
                this.btnSave.UseVisualStyleBackColor = true;
                this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
                // 
                // cmbShipVia
                // 
                this.cmbShipVia.FormattingEnabled = true;
                this.cmbShipVia.Location = new System.Drawing.Point(192, 266);
                this.cmbShipVia.Name = "cmbShipVia";
                this.cmbShipVia.Size = new System.Drawing.Size(192, 21);
                this.cmbShipVia.TabIndex = 14;
                // 
                // cmbEmployeeId
                // 
                this.cmbEmployeeId.FormattingEnabled = true;
                this.cmbEmployeeId.Location = new System.Drawing.Point(192, 78);
                this.cmbEmployeeId.Name = "cmbEmployeeId";
                this.cmbEmployeeId.Size = new System.Drawing.Size(192, 21);
                this.cmbEmployeeId.TabIndex = 15;
                // 
                // cmbCustomer
                // 
                this.cmbCustomer.FormattingEnabled = true;
                this.cmbCustomer.Location = new System.Drawing.Point(192, 25);
                this.cmbCustomer.Name = "cmbCustomer";
                this.cmbCustomer.Size = new System.Drawing.Size(192, 21);
                this.cmbCustomer.TabIndex = 16;
                // 
                // gridOrder
                // 
                this.gridOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                this.gridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                this.gridOrder.Location = new System.Drawing.Point(12, 348);
                this.gridOrder.Name = "gridOrder";
                this.gridOrder.Size = new System.Drawing.Size(720, 221);
                this.gridOrder.TabIndex = 17;
                // 
                // btnOrderInsert
                // 
                this.btnOrderInsert.Location = new System.Drawing.Point(460, 306);
                this.btnOrderInsert.Name = "btnOrderInsert";
                this.btnOrderInsert.Size = new System.Drawing.Size(174, 31);
                this.btnOrderInsert.TabIndex = 18;
                this.btnOrderInsert.Text = "Ürün Ekle";
                this.btnOrderInsert.UseVisualStyleBackColor = true;
                this.btnOrderInsert.Click += new System.EventHandler(this.btnOrderInsert_Click);
                // 
                // OrderEditForm
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(755, 631);
                this.Controls.Add(this.btnOrderInsert);
                this.Controls.Add(this.gridOrder);
                this.Controls.Add(this.cmbCustomer);
                this.Controls.Add(this.cmbEmployeeId);
                this.Controls.Add(this.cmbShipVia);
                this.Controls.Add(this.btnSave);
                this.Controls.Add(this.txtCountry);
                this.Controls.Add(this.txtPostalCode);
                this.Controls.Add(this.txtRegion);
                this.Controls.Add(this.txtShipCity);
                this.Controls.Add(this.txtShipAddress);
                this.Controls.Add(this.txtShipName);
                this.Controls.Add(this.numFeright);
                this.Controls.Add(this.dtpShipDate);
                this.Controls.Add(this.dtpRequiredDate);
                this.Controls.Add(this.dtpOrderDate);
                this.Controls.Add(this.label12);
                this.Controls.Add(this.label6);
                this.Controls.Add(this.label5);
                this.Controls.Add(this.label4);
                this.Controls.Add(this.label3);
                this.Controls.Add(this.label2);
                this.Controls.Add(this.label1);
                this.Controls.Add(this.label13);
                this.Controls.Add(this.label11);
                this.Controls.Add(this.label10);
                this.Controls.Add(this.label9);
                this.Controls.Add(this.label8);
                this.Controls.Add(this.label7);
                this.Name = "OrderEditForm";
                this.Text = "OrderEditForm";
                this.Load += new System.EventHandler(this.OrderEditForm_Load);
                ((System.ComponentModel.ISupportInitialize)(this.numFeright)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.gridOrder)).EndInit();
                this.ResumeLayout(false);
                this.PerformLayout();
            }
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.DateTimePicker dtpRequiredDate;
        private System.Windows.Forms.DateTimePicker dtpShipDate;
        private System.Windows.Forms.NumericUpDown numFeright;
        private System.Windows.Forms.TextBox txtShipName;
        private System.Windows.Forms.TextBox txtShipAddress;
        private System.Windows.Forms.TextBox txtShipCity;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbShipVia;
        private System.Windows.Forms.ComboBox cmbEmployeeId;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.DataGridView gridOrder;
        private System.Windows.Forms.Button btnOrderInsert;
    }
}