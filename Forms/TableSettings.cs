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
using Business.DependencyResolvers.Ninject;

namespace Forms
{
    public partial class TableSettings : DevExpress.XtraEditors.XtraForm
    {
        public TableSettings()
        {
            InitializeComponent();
            _tableService = InstanceFactory.GetInstance<ITableService>();
        }
        ITableService _tableService;
        public User user;

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                _tableService.Add(new Table
                {
                    TableName = tbxName.Text,
                });
                LoadTables();
                DevExpress.XtraEditors.XtraMessageBox.Show("Masa Eklendi !");
            }
            catch (Exception exception)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(exception.Message);
            }
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
            DevExpress.XtraEditors.XtraMessageBox.Show("Masa Silindi !");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                _tableService.Update(new Table
                {
                    TableID = Convert.ToInt32(dqwMasalar.CurrentRow.Cells[0].Value),
                    TableName = tbxUpdateName.Text,
                });
                LoadTables();
                DevExpress.XtraEditors.XtraMessageBox.Show("Masa Güncellendi !");

            }
            catch (Exception exception)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(exception.Message);
            }
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
