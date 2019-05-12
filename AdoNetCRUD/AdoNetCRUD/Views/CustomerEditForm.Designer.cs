using System;

namespace AdoNetCRUD.Views
{
    partial class CustomerEditForm
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
                this.txtCountry = new System.Windows.Forms.TextBox();
                this.label11 = new System.Windows.Forms.Label();
                this.txtRegion = new System.Windows.Forms.TextBox();
                this.txtCity = new System.Windows.Forms.TextBox();
                this.txtContactTitle = new System.Windows.Forms.TextBox();
                this.txtCompanyName = new System.Windows.Forms.TextBox();
                this.txtContactName = new System.Windows.Forms.TextBox();
                this.btnSave = new System.Windows.Forms.Button();
                this.txtCustomerId = new System.Windows.Forms.TextBox();
                this.txtFaks = new System.Windows.Forms.TextBox();
                this.txtPhone = new System.Windows.Forms.TextBox();
                this.txtPostalCode = new System.Windows.Forms.TextBox();
                this.txtAddress = new System.Windows.Forms.TextBox();
                this.label10 = new System.Windows.Forms.Label();
                this.label9 = new System.Windows.Forms.Label();
                this.label8 = new System.Windows.Forms.Label();
                this.label7 = new System.Windows.Forms.Label();
                this.label6 = new System.Windows.Forms.Label();
                this.label5 = new System.Windows.Forms.Label();
                this.label4 = new System.Windows.Forms.Label();
                this.label3 = new System.Windows.Forms.Label();
                this.label2 = new System.Windows.Forms.Label();
                this.label1 = new System.Windows.Forms.Label();
                this.SuspendLayout();
                // 
                // txtCountry
                // 
                this.txtCountry.Location = new System.Drawing.Point(126, 378);
                this.txtCountry.Name = "txtCountry";
                this.txtCountry.Size = new System.Drawing.Size(189, 20);
                this.txtCountry.TabIndex = 9;
                // 
                // label11
                // 
                this.label11.AutoSize = true;
                this.label11.Location = new System.Drawing.Point(12, 381);
                this.label11.Name = "label11";
                this.label11.Size = new System.Drawing.Size(29, 13);
                this.label11.TabIndex = 49;
                this.label11.Text = "Ülke";
                // 
                // txtRegion
                // 
                this.txtRegion.Location = new System.Drawing.Point(126, 261);
                this.txtRegion.Name = "txtRegion";
                this.txtRegion.Size = new System.Drawing.Size(189, 20);
                this.txtRegion.TabIndex = 6;
                // 
                // txtCity
                // 
                this.txtCity.Location = new System.Drawing.Point(126, 222);
                this.txtCity.Name = "txtCity";
                this.txtCity.Size = new System.Drawing.Size(189, 20);
                this.txtCity.TabIndex = 5;
                // 
                // txtContactTitle
                // 
                this.txtContactTitle.Location = new System.Drawing.Point(126, 144);
                this.txtContactTitle.Name = "txtContactTitle";
                this.txtContactTitle.Size = new System.Drawing.Size(189, 20);
                this.txtContactTitle.TabIndex = 3;
                // 
                // txtCompanyName
                // 
                this.txtCompanyName.Location = new System.Drawing.Point(126, 105);
                this.txtCompanyName.Name = "txtCompanyName";
                this.txtCompanyName.Size = new System.Drawing.Size(189, 20);
                this.txtCompanyName.TabIndex = 2;
                // 
                // txtContactName
                // 
                this.txtContactName.Location = new System.Drawing.Point(126, 66);
                this.txtContactName.Name = "txtContactName";
                this.txtContactName.Size = new System.Drawing.Size(189, 20);
                this.txtContactName.TabIndex = 1;
                // 
                // btnSave
                // 
                this.btnSave.Location = new System.Drawing.Point(126, 454);
                this.btnSave.Name = "btnSave";
                this.btnSave.Size = new System.Drawing.Size(139, 34);
                this.btnSave.TabIndex = 11;
                this.btnSave.Text = "Kaydet";
                this.btnSave.UseVisualStyleBackColor = true;
                this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
                // 
                // txtCustomerId
                // 
                this.txtCustomerId.Location = new System.Drawing.Point(126, 28);
                this.txtCustomerId.Name = "txtCustomerId";
                this.txtCustomerId.Size = new System.Drawing.Size(189, 20);
                this.txtCustomerId.TabIndex = 0;
                // 
                // txtFaks
                // 
                this.txtFaks.Location = new System.Drawing.Point(126, 417);
                this.txtFaks.Name = "txtFaks";
                this.txtFaks.Size = new System.Drawing.Size(189, 20);
                this.txtFaks.TabIndex = 10;
                // 
                // txtPhone
                // 
                this.txtPhone.Location = new System.Drawing.Point(126, 339);
                this.txtPhone.Name = "txtPhone";
                this.txtPhone.Size = new System.Drawing.Size(189, 20);
                this.txtPhone.TabIndex = 8;
                // 
                // txtPostalCode
                // 
                this.txtPostalCode.Location = new System.Drawing.Point(126, 300);
                this.txtPostalCode.Name = "txtPostalCode";
                this.txtPostalCode.Size = new System.Drawing.Size(189, 20);
                this.txtPostalCode.TabIndex = 7;
                // 
                // txtAddress
                // 
                this.txtAddress.Location = new System.Drawing.Point(126, 183);
                this.txtAddress.Name = "txtAddress";
                this.txtAddress.Size = new System.Drawing.Size(189, 20);
                this.txtAddress.TabIndex = 4;
                // 
                // label10
                // 
                this.label10.AutoSize = true;
                this.label10.Location = new System.Drawing.Point(12, 31);
                this.label10.Name = "label10";
                this.label10.Size = new System.Drawing.Size(16, 13);
                this.label10.TabIndex = 46;
                this.label10.Text = "Id";
                // 
                // label9
                // 
                this.label9.AutoSize = true;
                this.label9.Location = new System.Drawing.Point(12, 420);
                this.label9.Name = "label9";
                this.label9.Size = new System.Drawing.Size(30, 13);
                this.label9.TabIndex = 43;
                this.label9.Text = "Faks";
                // 
                // label8
                // 
                this.label8.AutoSize = true;
                this.label8.Location = new System.Drawing.Point(12, 342);
                this.label8.Name = "label8";
                this.label8.Size = new System.Drawing.Size(43, 13);
                this.label8.TabIndex = 41;
                this.label8.Text = "Telefon";
                // 
                // label7
                // 
                this.label7.AutoSize = true;
                this.label7.Location = new System.Drawing.Point(12, 303);
                this.label7.Name = "label7";
                this.label7.Size = new System.Drawing.Size(62, 13);
                this.label7.TabIndex = 39;
                this.label7.Text = "Posta Kodu";
                // 
                // label6
                // 
                this.label6.AutoSize = true;
                this.label6.Location = new System.Drawing.Point(12, 264);
                this.label6.Name = "label6";
                this.label6.Size = new System.Drawing.Size(34, 13);
                this.label6.TabIndex = 38;
                this.label6.Text = "Bölge";
                // 
                // label5
                // 
                this.label5.AutoSize = true;
                this.label5.Location = new System.Drawing.Point(12, 225);
                this.label5.Name = "label5";
                this.label5.Size = new System.Drawing.Size(31, 13);
                this.label5.TabIndex = 36;
                this.label5.Text = "Şehir";
                // 
                // label4
                // 
                this.label4.AutoSize = true;
                this.label4.Location = new System.Drawing.Point(12, 186);
                this.label4.Name = "label4";
                this.label4.Size = new System.Drawing.Size(34, 13);
                this.label4.TabIndex = 33;
                this.label4.Text = "Adres";
                // 
                // label3
                // 
                this.label3.AutoSize = true;
                this.label3.Location = new System.Drawing.Point(12, 147);
                this.label3.Name = "label3";
                this.label3.Size = new System.Drawing.Size(39, 13);
                this.label3.TabIndex = 31;
                this.label3.Text = "Unvan";
                // 
                // label2
                // 
                this.label2.AutoSize = true;
                this.label2.Location = new System.Drawing.Point(12, 108);
                this.label2.Name = "label2";
                this.label2.Size = new System.Drawing.Size(55, 13);
                this.label2.TabIndex = 30;
                this.label2.Text = "Şirket İsmi";
                // 
                // label1
                // 
                this.label1.AutoSize = true;
                this.label1.Location = new System.Drawing.Point(12, 69);
                this.label1.Name = "label1";
                this.label1.Size = new System.Drawing.Size(25, 13);
                this.label1.TabIndex = 27;
                this.label1.Text = "İsim";
                // 
                // CustomerEditForm
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(757, 538);
                this.Controls.Add(this.txtCountry);
                this.Controls.Add(this.label11);
                this.Controls.Add(this.txtRegion);
                this.Controls.Add(this.txtCity);
                this.Controls.Add(this.txtContactTitle);
                this.Controls.Add(this.txtCompanyName);
                this.Controls.Add(this.txtContactName);
                this.Controls.Add(this.btnSave);
                this.Controls.Add(this.txtCustomerId);
                this.Controls.Add(this.txtFaks);
                this.Controls.Add(this.txtPhone);
                this.Controls.Add(this.txtPostalCode);
                this.Controls.Add(this.txtAddress);
                this.Controls.Add(this.label10);
                this.Controls.Add(this.label9);
                this.Controls.Add(this.label8);
                this.Controls.Add(this.label7);
                this.Controls.Add(this.label6);
                this.Controls.Add(this.label5);
                this.Controls.Add(this.label4);
                this.Controls.Add(this.label3);
                this.Controls.Add(this.label2);
                this.Controls.Add(this.label1);
                this.Name = "CustomerEditForm";
                this.Text = "CustomerEditForm";
                this.Load += new System.EventHandler(this.CustomerEditForm_Load);
                this.ResumeLayout(false);
                this.PerformLayout();

            }
        }

        #endregion

        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtContactTitle;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.TextBox txtFaks;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}