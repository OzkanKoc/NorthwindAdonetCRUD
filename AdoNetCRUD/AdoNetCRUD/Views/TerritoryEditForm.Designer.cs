namespace AdoNetCRUD
{
    partial class TerritoryEditForm
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
            this.numRegionId = new System.Windows.Forms.NumericUpDown();
            this.txtterritoryDescription = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.mtxTerritoryId = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numRegionId)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saha Açıklaması";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bölge Numarası";
            // 
            // numRegionId
            // 
            this.numRegionId.Location = new System.Drawing.Point(195, 137);
            this.numRegionId.Name = "numRegionId";
            this.numRegionId.Size = new System.Drawing.Size(192, 20);
            this.numRegionId.TabIndex = 2;
            // 
            // txtterritoryDescription
            // 
            this.txtterritoryDescription.Location = new System.Drawing.Point(195, 83);
            this.txtterritoryDescription.Name = "txtterritoryDescription";
            this.txtterritoryDescription.Size = new System.Drawing.Size(192, 20);
            this.txtterritoryDescription.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(195, 213);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(192, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // mtxTerritoryId
            // 
            this.mtxTerritoryId.Location = new System.Drawing.Point(195, 42);
            this.mtxTerritoryId.Mask = "00000";
            this.mtxTerritoryId.Name = "mtxTerritoryId";
            this.mtxTerritoryId.Size = new System.Drawing.Size(192, 20);
            this.mtxTerritoryId.TabIndex = 5;
            this.mtxTerritoryId.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Saha Numarası";
            // 
            // TerritoryEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtxTerritoryId);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtterritoryDescription);
            this.Controls.Add(this.numRegionId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TerritoryEditForm";
            this.Text = "TerritoryEditForm";
            this.Load += new System.EventHandler(this.TerritoryEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRegionId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numRegionId;
        private System.Windows.Forms.TextBox txtterritoryDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.MaskedTextBox mtxTerritoryId;
        private System.Windows.Forms.Label label3;
    }
}