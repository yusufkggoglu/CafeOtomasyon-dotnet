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
    public partial class UserSettings : DevExpress.XtraEditors.XtraForm
    {
        public UserSettings()
        {
            InitializeComponent();
            _userService = InstanceFactory.GetInstance<IUserService>();
            _roleService = InstanceFactory.GetInstance<IRoleService>();
        }
        IUserService _userService;
        IRoleService _roleService;
        public User user;

        private void LoadRoles()
        {
            dqwRoller.DataSource = _roleService.GetAll();
        }
        private void LoadUsers()
        {
            dqwKullanicilar.DataSource = _userService.GetAll();
        }
        private void UserSettings_Load(object sender, EventArgs e)
        {
            LoadRoles();
            LoadUsers();
            LoadComboBoxRoles();
        }
        
        private void LoadComboBoxRoles()
        {
            cbxRole.DataSource = _roleService.GetAll();
            cbxRole.DisplayMember = "RoleName";
            cbxRole.ValueMember = "RoleID";

            cbxUpdateRole.DataSource = _roleService.GetAll();
            cbxUpdateRole.DisplayMember = "RoleName";
            cbxUpdateRole.ValueMember = "RoleID";
        }
        private void btnRolEkle_Click(object sender, EventArgs e)
        {
            try
            {
                _roleService.Add(new Role
                {
                    RoleName = tbxRoleName.Text,
                    AdminStatus = cmbAdminStatus.SelectedIndex.ToString(),
                });
                LoadRoles();
                LoadComboBoxRoles();
                DevExpress.XtraEditors.XtraMessageBox.Show("Rol Eklendi!");

            }
            catch (Exception exception)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(exception.Message);
            }
        }
        private void btnRolSil_Click(object sender, EventArgs e)
        {
            try
            {
                _roleService.Delete(new Role
                {
                    RoleID = Convert.ToInt32(dqwRoller.CurrentRow.Cells[0].Value)
                });
                LoadRoles();
                LoadComboBoxRoles();
                DevExpress.XtraEditors.XtraMessageBox.Show("Rol Silindi!");
            }
            catch (Exception)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Silmek istediğiniz rolün bir kullanıcı içermediğine dikkat edin ve tekrar deneyin.");
            }
        }

        private void dqwRoller_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdateRoleName.Text = dqwRoller.CurrentRow.Cells[1].Value.ToString();
            cmbUpdateAdminStatus.SelectedIndex = Convert.ToInt32(dqwRoller.CurrentRow.Cells[2].Value);
        }

        private void dqwKullanicilar_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            tbxUpdateAd.Text = dqwKullanicilar.CurrentRow.Cells[1].Value.ToString();
            tbxUpdateSoyad.Text = dqwKullanicilar.CurrentRow.Cells[2].Value.ToString();
            cbxUpdateRole.SelectedValue = dqwKullanicilar.CurrentRow.Cells[3].Value;
            tbxUpdateSifre.Text = dqwKullanicilar.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnRolGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                _roleService.Update(new Role
                {
                    RoleID = Convert.ToInt32(dqwRoller.CurrentRow.Cells[0].Value),
                    RoleName = tbxUpdateRoleName.Text,
                    AdminStatus = cmbUpdateAdminStatus.SelectedIndex.ToString(),
                });
                LoadRoles();
                LoadComboBoxRoles();
                DevExpress.XtraEditors.XtraMessageBox.Show("Rol Güncellendi !");

            }
            catch (Exception exception)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(exception.Message);
            }
        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            try
            {
                _userService.Add(new User
                {
                    Ad = tbxAd.Text,
                    Soyad = tbxSoyad.Text,
                    Password = tbxSifre.Text,
                    RoleID = Convert.ToInt32(cbxRole.SelectedValue),
                });
                LoadUsers();
                DevExpress.XtraEditors.XtraMessageBox.Show("Kullanıcı Eklendi !");
            }
            catch (Exception exception)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(exception.Message);
            }
        }

        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            _userService.Delete(new User
            {
                UserID = Convert.ToInt32(dqwKullanicilar.CurrentRow.Cells[0].Value)
            });
            LoadUsers();
            DevExpress.XtraEditors.XtraMessageBox.Show("Kullanıcı Silindi !");
        }

        private void btnKullaniciGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                _userService.Update(new User
                {
                    UserID = Convert.ToInt32(dqwKullanicilar.CurrentRow.Cells[0].Value),
                    Ad = tbxUpdateAd.Text,
                    Soyad = tbxUpdateSoyad.Text,
                    Password = tbxUpdateSifre.Text,
                    RoleID = Convert.ToInt32(cbxUpdateRole.SelectedValue),
                });
                LoadUsers();
                DevExpress.XtraEditors.XtraMessageBox.Show("Kullanıcı Güncellendi !");
            }
            catch (Exception exception)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(exception.Message);
            }
        }
    }
}
