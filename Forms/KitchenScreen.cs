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

namespace Forms
{
    public partial class KitchenScreen : DevExpress.XtraEditors.XtraForm
    {
        public KitchenScreen()
        {
            InitializeComponent();
            _orderService = new OrderManager(new EfOrderDal());
        }
        IOrderService _orderService;
        private void LoadOrders()
        {
            dqwKitchen.DataSource = _orderService.GetAllOrders();
        }
        private void dqwKitchen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rtbxNotes.Text = dqwKitchen.CurrentRow.Cells[7].Value.ToString();
        }
        private void KitchenScreen_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }
        private void btnAll_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }
    }
}
