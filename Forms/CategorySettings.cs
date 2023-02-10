using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class CategorySettings : DevExpress.XtraEditors.XtraForm
    {
        public CategorySettings()
        {
            InitializeComponent();
            _categoryService = new CategoryManager(new EfCategoryDal());

        }
        ICategoryService _categoryService;
        public int user_id;
        private void CategorySettings_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }
        private void LoadCategories()
        {
            dqwKategoriler.DataSource = _categoryService.GetAll();
        }

        private void dqwKategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdateName.Text = dqwKategoriler.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            _categoryService.Add(new Category
            {
                Name = tbxName.Text,
                
            });
            LoadCategories();
            MessageBox.Show("Kategori Eklendi!");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _categoryService.Delete(new Category
            {
                CategoryID = Convert.ToInt32(dqwKategoriler.CurrentRow.Cells[0].Value)
            });
            LoadCategories();
            MessageBox.Show("Kategori Silindi !");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            _categoryService.Update(new Category
            {
                CategoryID = Convert.ToInt32(dqwKategoriler.CurrentRow.Cells[0].Value),
                Name = tbxUpdateName.Text,
            });
            LoadCategories();
            MessageBox.Show("Kategori Güncellendi !");
        }
    }
}
