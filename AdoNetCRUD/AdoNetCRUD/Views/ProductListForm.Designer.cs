using System;

namespace AdoNetCRUD
{
    partial class ProductListForm
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
            this.gridProducts = new System.Windows.Forms.DataGridView();
            this.colProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantityPerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitsInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitsOnOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReorderLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscontinued = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxButtonDelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridProducts
            // 
            this.gridProducts.AllowUserToAddRows = false;
            this.gridProducts.AllowUserToDeleteRows = false;
            this.gridProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductId,
            this.colProductName,
            this.colCategoryId,
            this.colSupplierId,
            this.colQuantityPerUnit,
            this.colUnitPrice,
            this.colUnitsInStock,
            this.colUnitsOnOrder,
            this.colReorderLevel,
            this.colDiscontinued});
            this.gridProducts.ContextMenuStrip = this.contextMenuStrip;
            this.gridProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProducts.Location = new System.Drawing.Point(0, 0);
            this.gridProducts.MultiSelect = false;
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.ReadOnly = true;
            this.gridProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProducts.Size = new System.Drawing.Size(934, 424);
            this.gridProducts.TabIndex = 0;
            this.gridProducts.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.gridProducts_CellContextMenuStripNeeded);
            this.gridProducts.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridProducts_RowHeaderMouseDoubleClick);
            // 
            // colProductId
            // 
            this.colProductId.DataPropertyName = "Id";
            this.colProductId.HeaderText = "Product Id";
            this.colProductId.Name = "colProductId";
            this.colProductId.ReadOnly = true;
            // 
            // colProductName
            // 
            this.colProductName.DataPropertyName = "ProductName";
            this.colProductName.HeaderText = "Product Name";
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            // 
            // colCategoryId
            // 
            this.colCategoryId.DataPropertyName = "CategoryId";
            this.colCategoryId.HeaderText = "CategoryId";
            this.colCategoryId.Name = "colCategoryId";
            this.colCategoryId.ReadOnly = true;
            // 
            // colSupplierId
            // 
            this.colSupplierId.DataPropertyName = "SupplierId";
            this.colSupplierId.HeaderText = "Supplier Id";
            this.colSupplierId.Name = "colSupplierId";
            this.colSupplierId.ReadOnly = true;
            // 
            // colQuantityPerUnit
            // 
            this.colQuantityPerUnit.DataPropertyName = "QuantityPerUnit";
            this.colQuantityPerUnit.HeaderText = "Quantity Per Unit";
            this.colQuantityPerUnit.Name = "colQuantityPerUnit";
            this.colQuantityPerUnit.ReadOnly = true;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.DataPropertyName = "UnitPrice";
            this.colUnitPrice.HeaderText = "Unit Price";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.ReadOnly = true;
            // 
            // colUnitsInStock
            // 
            this.colUnitsInStock.DataPropertyName = "UnitsInStock";
            this.colUnitsInStock.HeaderText = "Units In Stock";
            this.colUnitsInStock.Name = "colUnitsInStock";
            this.colUnitsInStock.ReadOnly = true;
            // 
            // colUnitsOnOrder
            // 
            this.colUnitsOnOrder.DataPropertyName = "UnitsOnOrder";
            this.colUnitsOnOrder.HeaderText = "Units On Order";
            this.colUnitsOnOrder.Name = "colUnitsOnOrder";
            this.colUnitsOnOrder.ReadOnly = true;
            // 
            // colReorderLevel
            // 
            this.colReorderLevel.DataPropertyName = "ReorderLevel";
            this.colReorderLevel.HeaderText = "Reorder Level";
            this.colReorderLevel.Name = "colReorderLevel";
            this.colReorderLevel.ReadOnly = true;
            // 
            // colDiscontinued
            // 
            this.colDiscontinued.DataPropertyName = "Discontinued";
            this.colDiscontinued.HeaderText = "Discontinued";
            this.colDiscontinued.Name = "colDiscontinued";
            this.colDiscontinued.ReadOnly = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxButtonDelete});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(108, 26);
            this.contextMenuStrip.Click += new System.EventHandler(this.ctxBtnDelete_Click);
            // 
            // ctxButtonDelete
            // 
            this.ctxButtonDelete.Name = "ctxButtonDelete";
            this.ctxButtonDelete.Size = new System.Drawing.Size(180, 22);
            this.ctxButtonDelete.Text = "Delete";
            // 
            // ProductListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 424);
            this.Controls.Add(this.gridProducts);
            this.Name = "ProductListForm";
            this.Text = "ProductListForm";
            this.Load += new System.EventHandler(this.ProductListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantityPerUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitsInStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitsOnOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReorderLevel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colDiscontinued;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ctxButtonDelete;
    }
}