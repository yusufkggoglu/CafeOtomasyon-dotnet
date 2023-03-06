using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers.Ninject;
using DataAccess.Abstract;
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
    

    public partial class TableList : DevExpress.XtraEditors.XtraForm
    {
        public TableList()
        {
            InitializeComponent();
            _tableService = InstanceFactory.GetInstance<ITableService>();
        }
        ITableService _tableService;
        public User user;
        private void GetTables()
        {
            var model = _tableService.GetAll();
            for (int i = 0; i < model.Count; i++)
            {
                DevExpress.XtraEditors.SimpleButton btn = new DevExpress.XtraEditors.SimpleButton(); 
                btn.Text = model[i].TableName.ToString();
                btn.Name = model[i].TableName.ToString();
                btn.AccessibleDescription= model[i].TableID.ToString();
                btn.Font = new Font("Microsoft Sans Serif", 15);
                btn.Height = 200;
                btn.Width = 200;
                flpTable.Controls.Add(btn);
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
        
        public void OpenScreenForm(object sender, System.EventArgs e)
        {
            DevExpress.XtraEditors.SimpleButton btn = sender as DevExpress.XtraEditors.SimpleButton;
            OrderScreen frm = new OrderScreen()
            {
                masa_Ad = btn.Name.ToString(),
                id = Convert.ToInt32(btn.AccessibleDescription),
                user = user
            };
            frm.MdiParent = ActiveForm;
            this.Close();
            frm.Show();
        }

        private void TableList_Load(object sender, EventArgs e)
        {
            GetTables();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            TableList frm = new TableList()
            {
                user = user
            };
             frm.MdiParent = ActiveForm;
             frm.Show();
             this.Close();
        }
    }
}
