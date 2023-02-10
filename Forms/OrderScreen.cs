using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Forms
{
    public partial class OrderScreen : DevExpress.XtraEditors.XtraForm
    {
        public OrderScreen()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
            _orderService = new OrderManager(new EfOrderDal());
            _tableService = new TableManager(new EfTableDal());
        }

        public int id;
        public string masa_Ad;
        public int user_id;

        IProductService _productService;
        IOrderService _orderService;
        ITableService _tableService;

        private void OrderScreen_Load(object sender, EventArgs e)
        {
            GetProducts();
            GetOrderByTableId();
            GetPrice();
        }

        public void GetProducts()
        {
            var model = _productService.GetAll();
            for (int i = 0; i < model.Count; i++)
            {
                DevExpress.XtraEditors.SimpleButton btn = new DevExpress.XtraEditors.SimpleButton();
                btn.Text = model[i].Name;
                btn.Font = new Font("Microsoft Sans Serif", 15);
                btn.Name = model[i].ProductID.ToString();
                btn.Height = 125;
                btn.Width = 125;
                btn.AccessibleDescription = model[i].Price.ToString();
                btn.Appearance.BackColor = Color.Orange;
                flp.Controls.Add(btn);
                btn.Click += newOrder;
            }
        }

        public void newOrder(object sender, System.EventArgs e)
        {
            try
            {
                DevExpress.XtraEditors.SimpleButton btn = sender as DevExpress.XtraEditors.SimpleButton;
                _orderService.Add(new Order()
                {
                    ProductName = btn.Text,
                    Price = Convert.ToDecimal(btn.AccessibleDescription),
                    TableID = id,
                    Amount = 1,
                    UserID = 1,
                    OrderTime = DateTime.Now,
                    Note = "",
                });
                GetOrderByTableId();
                ChangeStatus1();
                GetPrice();
                MessageBox.Show("Ürün eklendi !");
            }
            catch (Exception exception) 
            {
                MessageBox.Show(exception.Message);
            }
           
        }
        public void ChangeStatus1()
        {
            try
            {
                _tableService.Update(new Table
                {
                    TableID = id,
                    Status = 1,
                    TableName = masa_Ad,
                });
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        public void ChangeStatus0()
        {
            try
            {
                _tableService.Update(new Table
                {
                    TableID = id,
                    Status = 0,
                    TableName = masa_Ad,
                });
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
            
        private void GetOrderByTableId()
        {
            dqwOrders.DataSource = _orderService.GetAll(id);
        }
        private void GetPrice()
        {
            var list = _orderService.GetAll(id);
            decimal price = 0;
            foreach (var temp in list)
            {
                price += temp.Price;
            }
            tbxPrice.Text = price.ToString();
            if (list.Count == 0)
            {
                ChangeStatus0();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _orderService.Delete(new Order
            {
                OrderID = Convert.ToInt32(dqwOrders.CurrentRow.Cells[0].Value)
            });
            GetOrderByTableId();
            GetPrice();
            MessageBox.Show("Ürün Silindi!");
        }

        private void BtnTableList_Click(object sender, EventArgs e)
        {
            TableList frm = new TableList();
            frm.MdiParent = ActiveForm;
            this.Close();
            frm.Show();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            GetOrderByTableId();
        }

        private void dqwOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rtbxNotes.Text = dqwOrders.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _orderService.Update(new Order
                {
                    OrderID = Convert.ToInt32(dqwOrders.CurrentRow.Cells[0].Value),
                    Amount = Convert.ToInt32(dqwOrders.CurrentRow.Cells[4].Value),
                    Note = rtbxNotes.Text,
                    OrderTime = Convert.ToDateTime(dqwOrders.CurrentRow.Cells[5].Value),
                    Price = Convert.ToDecimal(dqwOrders.CurrentRow.Cells[3].Value),
                    ProductName = dqwOrders.CurrentRow.Cells[2].Value.ToString(),
                    UserID = user_id,
                    TableID = id,
                });
                GetOrderByTableId();
                MessageBox.Show("Not Eklendi !");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
