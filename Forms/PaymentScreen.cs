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
    public partial class PaymentScreen : DevExpress.XtraEditors.XtraForm
    {
        public PaymentScreen()
        {
            InitializeComponent();
            _tableService = InstanceFactory.GetInstance<ITableService>();
            _orderService = InstanceFactory.GetInstance<IOrderService>();
            _paymentService = InstanceFactory.GetInstance<IPaymentService>();
        }
        ITableService _tableService;
        IOrderService _orderService;
        IPaymentService _paymentService;
        public int user_id;
        private int masa_id;
        
        private void PaymentScreen_Load(object sender, EventArgs e)
        {
            GetTables();
        }
        
        private void GetTables()
        {
            var model = _tableService.GetAll();
            for (int i = 0; i < model.Count; i++)
            {
                DevExpress.XtraEditors.SimpleButton btn = new DevExpress.XtraEditors.SimpleButton();
                btn.Text = model[i].TableName.ToString();
                btn.Name = model[i].TableName.ToString();
                btn.AccessibleDescription = model[i].TableID.ToString();
                btn.Font = new Font("Microsoft Sans Serif", 15);
                btn.Height = 100;
                btn.Width = 100;
                flp.Controls.Add(btn);
                btn.Click += OpenScreenForm;
                if (model[i].Status == 0)
                {
                    btn.Appearance.BackColor = Color.Green;
                }
                else
                {
                    btn.Appearance.BackColor = Color.DarkRed;
                }
            }
        }

        private void GetPrice(int id)
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
                Table table;
                table = _tableService.Get(id);
                ChangeStatus0(table);
            }
        }

        private void GetOrderByTableId(int id)
        {
            dqwOrders.DataSource = _orderService.GetAll(id);
        }

        public void OpenScreenForm(object sender, System.EventArgs e)
        {
            DevExpress.XtraEditors.SimpleButton btn = sender as DevExpress.XtraEditors.SimpleButton;
            GetOrderByTableId(Convert.ToInt32(btn.AccessibleDescription));
            GetPrice(Convert.ToInt32(btn.AccessibleDescription));
            masa_id = Convert.ToInt32(btn.AccessibleDescription);
        }

        public void ChangeStatus1(Table table)
        {
            try
            {
                _tableService.Update(new Table
                {
                    TableID = table.TableID,
                    Status = 1,
                    TableName = table.TableName,
                });
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        public void ChangeStatus0(Table table)
        {
            try
            {
                _tableService.Update(new Table
                {
                    TableID = table.TableID,
                    Status = 0,
                    TableName = table.TableName,
                });
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void OffTable(int id)
        {
            try
            {
                var list = _orderService.GetAll(id);
                foreach (var temp in list)
                {
                    _orderService.Delete(temp);
                }
                MessageBox.Show("Hesap Ödendi!");
                GetTables();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        
        private void btnNakit_Click(object sender, EventArgs e)
        {
            try
            {
                _paymentService.Add(new Payment
                {
                    Price = Convert.ToDecimal(tbxPrice.Text),
                    PaymentTime = DateTime.Now,
                    PaymentMethod = "Nakit",
                });
                OffTable(masa_id);
                Table table = _tableService.Get(masa_id);
                ChangeStatus0(table);
                ReturnTables();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnKart_Click(object sender, EventArgs e)
        {
            try
            {
                _paymentService.Add(new Payment
                {
                    Price = Convert.ToDecimal(tbxPrice.Text),
                    PaymentTime = DateTime.Now,
                    PaymentMethod = "Kredi Kartı",
                });
                OffTable(masa_id);
                Table table = _tableService.Get(masa_id);
                ChangeStatus0(table);
                ReturnTables();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        public void ReturnTables()
        {
            PaymentScreen frm = new PaymentScreen();
            frm.MdiParent=ActiveForm;
            frm.Show();
            this.Close();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            ReturnTables();
        }
    }
}
