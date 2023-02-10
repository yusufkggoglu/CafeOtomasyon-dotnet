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
    public partial class OutGoingsScreen : DevExpress.XtraEditors.XtraForm
    {
        public OutGoingsScreen()
        {
            InitializeComponent();
            _outGoingService = new OutGoingManager(new EfOutGoingDal());
        }
        IOutGoingService _outGoingService;

        private void OutGoingsScreen_Load(object sender, EventArgs e)
        {
            LoadOutGoings();
            GetSumOfOutGoings();
        }

        public void LoadOutGoings()
        {
            dqwGiderler.DataSource = _outGoingService.GetAll();
        }

        private void dqwGiderler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdateName.Text = dqwGiderler.CurrentRow.Cells[1].Value.ToString();
            tbxUpdateAmount.Text =dqwGiderler.CurrentRow.Cells[2].Value.ToString();
            tbxUpdatePrice.Text = dqwGiderler.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                _outGoingService.Add(new OutGoing
                {
                    Name = tbxName.Text,
                    Price = Convert.ToDecimal(tbxPrice.Text),
                    Amount = Convert.ToInt32(tbxAmount.Text),
                });
                LoadOutGoings();
                GetSumOfOutGoings();
                MessageBox.Show("Gider Eklendi!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _outGoingService.Delete(new OutGoing
            {
                ID = Convert.ToInt32(dqwGiderler.CurrentRow.Cells[0].Value)
            });
            LoadOutGoings();
            GetSumOfOutGoings();
            MessageBox.Show("Gider Silindi!");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                _outGoingService.Update(new OutGoing
                {
                    ID = Convert.ToInt32(dqwGiderler.CurrentRow.Cells[0].Value),
                    Name = tbxUpdateName.Text,
                    Price = Convert.ToDecimal(tbxUpdatePrice.Text),
                    Amount = Convert.ToInt32(tbxUpdateAmount.Text),
                });
                LoadOutGoings();
                GetSumOfOutGoings();
                MessageBox.Show("Gider Güncellendi!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void GetSumOfOutGoings()
        {
            decimal sum = 0;
            var list = _outGoingService.GetAll();
            foreach(var temp in list)
            {
                sum += Convert.ToDecimal(temp.Amount) * Convert.ToDecimal(temp.Price);
            }
            tbxToplam.Text = sum.ToString();
        }
    }
}
