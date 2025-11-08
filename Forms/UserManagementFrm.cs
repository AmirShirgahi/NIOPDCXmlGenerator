using NIOPDCXmlGenerator.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace NIOPDCXmlGenerator.Forms
{
    public partial class UserManagementFrm : RadForm
    {
        private readonly UserService _us = new UserService();
        private readonly AuthService _auth = new AuthService();

        public UserManagementFrm()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            gridUsers.DataSource = _us.GetAll().Select(u => new {
                u.UserId,
                u.Username,
                u.FullName,
                IsAdmin = u.IsAdmin ? "Yes" : "No",
                u.CreatedAt
            }).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text.Trim();
            var pwd = txtPassword.Text;
            var fullname = txtFullName.Text.Trim();
            var isAdmin = chkIsAdmin.Checked;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(pwd))
            {
                Telerik.WinControls.RadMessageBox.Show(this, "نام کاربری و رمز لازم است", "خطا", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Error);
                return;
            }
            try
            {
                _auth.CreateUser(username, pwd, fullname, isAdmin);
                LoadUsers();
                Telerik.WinControls.RadMessageBox.Show(this, "کاربر اضافه شد", "موفقیت", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Info);
            }
            catch (Exception ex)
            {
                Telerik.WinControls.RadMessageBox.Show(this, "خطا در اضافه کردن کاربر: " + ex.Message, "خطا", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridUsers.CurrentRow == null) return;
            var id = (int)gridUsers.CurrentRow.Cells["UserId"].Value;
            var res = Telerik.WinControls.RadMessageBox.Show(this, "آیا مایل به حذف کاربر هستید؟", "تأیید", MessageBoxButtons.YesNo, Telerik.WinControls.RadMessageIcon.Question);
            if (res == DialogResult.Yes)
            {
                _us.Delete(id);
                LoadUsers();
            }
        }
    }
}
