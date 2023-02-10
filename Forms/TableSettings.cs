using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities.Concrete;

namespace Forms
{
    public partial class TableSettings : DevExpress.XtraEditors.XtraForm
    {
        public TableSettings()
        {
            InitializeComponent();
            _tableService = new TableManager(new EfTableDal());
        }
        ITableService _tableService;
        public int user_id;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            _tableService.Add(new Table
            {
                TableName = tbxName.Text,
            });
            LoadTables();
            MessageBox.Show("Masa Eklendi !");
        }

        private void LoadTables()
        {
            dqwMasalar.DataSource = _tableService.GetAll();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _tableService.Delete(new Table
            {
                TableID = Convert.ToInt32(dqwMasalar.CurrentRow.Cells[0].Value)
            });
            LoadTables();
            MessageBox.Show("Masa Silindi !");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            _tableService.Update(new Table
            {   TableID=Convert.ToInt32(dqwMasalar.CurrentRow.Cells[0].Value),
                TableName = tbxUpdateName.Text,
            });
            LoadTables();
            MessageBox.Show("Masa Güncellendi !");
        }

        private void TableSettings_Load(object sender, EventArgs e)
        {
            LoadTables();
        }

        private void dqwMasalar_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdateName.Text = dqwMasalar.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
