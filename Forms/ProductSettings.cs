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
    public partial class ProductSettings : DevExpress.XtraEditors.XtraForm
    {
        public ProductSettings()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());

        }
        IProductService _productService;
        ICategoryService _categoryService;
        public int user_id;

        private void ProductSettings_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadProducts()
        {
            dqwUrunler.DataSource = _productService.GetAll();
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "Name";
            cbxCategory.ValueMember = "CategoryID";

            cbxUpdateCategory.DataSource = _categoryService.GetAll();
            cbxUpdateCategory.DisplayMember = "Name";
            cbxUpdateCategory.ValueMember = "CategoryID";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            _productService.Add(new Product
            {
                CategoryID = Convert.ToInt32(cbxCategory.SelectedValue),
                Name = tbxName.Text,
                Price = Convert.ToDecimal(tbxPrice.Text)
            });
            LoadProducts();
            MessageBox.Show("Ürün Eklendi!");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            _productService.Update(new Product
            {
                ProductID = Convert.ToInt32(dqwUrunler.CurrentRow.Cells[0].Value),
                Name = tbxUpdateName.Text,
                CategoryID = Convert.ToInt32(cbxUpdateCategory.SelectedValue),
                Price = Convert.ToDecimal(tbxUpdatePrice.Text)
            });
            LoadProducts();
            MessageBox.Show("Ürün Güncellendi!");
        }

        private void dqwUrunler_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            cbxUpdateCategory.SelectedValue = dqwUrunler.CurrentRow.Cells[1].Value;
            tbxUpdateName.Text = dqwUrunler.CurrentRow.Cells[2].Value.ToString();
            tbxUpdatePrice.Text = dqwUrunler.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _productService.Delete(new Product
            {
                ProductID = Convert.ToInt32(dqwUrunler.CurrentRow.Cells[0].Value)
            });
            LoadProducts();
            MessageBox.Show("Ürün Silindi!");
        }
    }
}
