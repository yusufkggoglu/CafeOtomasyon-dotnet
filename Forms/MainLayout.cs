using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers.Ninject;
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
    public partial class MainLayout : DevExpress.XtraEditors.XtraForm
    {
        public MainLayout()
        {
            InitializeComponent();
            _userService = InstanceFactory.GetInstance<IUserService>();
            _roleService = InstanceFactory.GetInstance<IRoleService>();
        }
        IUserService _userService;
        IRoleService _roleService;
        public User user;
        ProductSettings frm1;
        CategorySettings frm2;
        UserSettings frm3;
        TableSettings frm4;
        TableList frm5;
        PaymentScreen frm6;
        PaymentHistoryScreen frm7;
        KitchenScreen frm8;
        OutGoingsScreen frm9;
        
    private void barBtnUrun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frm1==null || frm1.IsDisposed)
            frm1 = new ProductSettings()
            {
                user = user
            };
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void barBtnKategori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm2 == null || frm2.IsDisposed)
            frm2 = new CategorySettings()
            {
                user = user
            };
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void barBtnKullanıcı_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm3 == null || frm3.IsDisposed)
                frm3 = new UserSettings()
                {
                    user = user
                };
            frm3.MdiParent = this;
            frm3.Show();
        }

        private void barBtnMasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm4 == null || frm4.IsDisposed)
                frm4 = new TableSettings()
                {
                    user = user
                };
            frm4.MdiParent = this;
            frm4.Show();
        }

        private void barBtnSiparis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm5 == null || frm5.IsDisposed)
                frm5 = new TableList()
                {
                    user = user
                };
            frm5.MdiParent = this;
            frm5.Show();
        }

        private void barBtnKasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm6 == null || frm6.IsDisposed)
                frm6 = new PaymentScreen()
                {
                    user = user
                };
            frm6.MdiParent = this;
            frm6.Show();
        }

        private void MainLayout_Load(object sender, EventArgs e)
        {
            Role r = _roleService.Get(Convert.ToInt32(user.RoleID));
            if (Convert.ToInt32(r.AdminStatus) == 0)
            {
                barBtnKasa.Enabled = true;
                barBtnGider.Enabled = true;
                barBtnKategori.Enabled = true;
                barBtnKullanıcı.Enabled = true;
                barBtnMasa.Enabled = true;
                barBtnUrun.Enabled = true;
                barBtnRapor.Enabled = true;
            }
        }

        private void barBtnBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoginScreen frm1 = new LoginScreen();
            frm1.Show();
            this.Hide();
        }

        private void barBtnRapor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm7 == null || frm7.IsDisposed)
                frm7 = new PaymentHistoryScreen()
                {
                    user = user
                };
            frm7.MdiParent = this;
            frm7.Show();
        }

        private void barBtnMutfak_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm8 == null || frm8.IsDisposed)
                frm8 = new KitchenScreen()
                {
                    
                };
            frm8.MdiParent = this;
            frm8.Show();
        }

        private void barBtnGider_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm9 == null || frm9.IsDisposed)
                frm9 = new OutGoingsScreen()
                {
                };
            frm9.MdiParent = this;
            frm9.Show();
        }
    }
}
