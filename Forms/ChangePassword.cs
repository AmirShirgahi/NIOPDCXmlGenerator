using NIOPDCXmlGenerator.Models;
using NIOPDCXmlGenerator.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace NIOPDCXmlGenerator.Forms
{
    public partial class ChangePassword : Telerik.WinControls.UI.RadForm
    {
        public partial class ChangePasswordFrm : RadForm
        {
            private readonly AuthService _auth = new AuthService();
            private readonly User _currentUser;

            public ChangePasswordFrm(User user)
            {
                _currentUser = user;
                InitializeComponent();
            }

            private void btnSave_Click(object sender, EventArgs e)
            {
                var current = txtCurrent.Text;
                var newPass = txtNew.Text;
                var confirm = txtConfirm.Text;

                if (string.IsNullOrWhiteSpace(current) || string.IsNullOrWhiteSpace(newPass) || string.IsNullOrWhiteSpace(confirm))
                {
                    RadMessageBox.Show(this, "لطفاً همه فیلدها را پر کنید", "خطا", MessageBoxButtons.OK, RadMessageIcon.Error);
                    return;
                }

                var user =new AuthService().Authenticate(_currentUser.Username, current);
                if (user == null)
                {
                    RadMessageBox.Show(this, "رمز فعلی اشتباه است", "خطا", MessageBoxButtons.OK, RadMessageIcon.Error);
                    return;
                }

                if (newPass.Length < 6)
                {
                    RadMessageBox.Show(this, "رمز جدید باید حداقل ۶ کاراکتر باشد", "خطا", MessageBoxButtons.OK, RadMessageIcon.Error);
                    return;
                }

                if (newPass != confirm)
                {
                    RadMessageBox.Show(this, "رمز جدید و تکرار آن یکسان نیستند", "خطا", MessageBoxButtons.OK, RadMessageIcon.Error);
                    return;
                }

                try
                {
                   new AuthService().ChangePassword(_currentUser.UserId, newPass);
                    RadMessageBox.Show(this, "رمز عبور با موفقیت تغییر یافت", "موفقیت", MessageBoxButtons.OK, RadMessageIcon.Info);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    RadMessageBox.Show(this, "خطا در تغییر رمز: " + ex.Message, "خطا", MessageBoxButtons.OK, RadMessageIcon.Error);
                }
            }

            private void btnCancel_Click(object sender, EventArgs e)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ChangePassword
            // 
            this.ClientSize = new System.Drawing.Size(582, 311);
            this.Name = "ChangePassword";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
