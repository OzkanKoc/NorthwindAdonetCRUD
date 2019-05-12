using AdoNetCRUD.DataMappers;
using AdoNetCRUD.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetCRUD
{
    public partial class CategoryEditForm : Form
    {
        private int _categoryId;
        public CategoryEditForm()
        {
            InitializeComponent();
        }
        public CategoryEditForm(int categoryId) : this()
        {
            _categoryId = categoryId;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var category = CreateCategoryByForm();
            var categoryDataMapper = new CategoryDataMapper();
            if (_categoryId == 0)
            {
                categoryDataMapper.Insert(category);
            }
            else
            {
                category.Id = _categoryId;
                categoryDataMapper.Update(category);
            }
            Dispose();
        }
        private Category CreateCategoryByForm()
        {
            return new Category
            {
                Description = rtxtDescription.Text,
                Name = txtCategoryName.Text
            };
        }
        private void CategoryEditForm_Load(object sender, EventArgs e)
        {
            if (_categoryId != 0)
            {
                var categoryMapper = new CategoryDataMapper();
                var category = categoryMapper.Get(_categoryId);
                FillFormByCategory(category);
            }
        }
        private void FillFormByCategory(Category category)
        {
            if (category != null)
            {
                txtCategoryName.Text = category.Name;
                rtxtDescription.Text = category.Description;
            }
        }
    }
}
