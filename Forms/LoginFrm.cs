using NIOPDCXmlGenerator.Models;
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
    public partial class LoginFrm : Telerik.WinControls.UI.RadForm
    {
        private readonly AuthService _auth = new AuthService();
        public User? AuthenticatedUser { get; private set; }

        public LoginFrm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = _auth.Authenticate(txtUsername.Text.Trim(), txtPassword.Text);
            if (user == null)
            {
                Telerik.WinControls.RadMessageBox.Show(this, "نام کاربری یا رمز عبور اشتباه است", "خطا", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Error);
                return;
            }
            AuthenticatedUser = user;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
