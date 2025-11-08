using System.ComponentModel;
using Telerik.WinControls.UI;

namespace NIOPDCXmlGenerator.Forms
{
    partial class ChangePassword
    {
        partial class ChangePasswordFrm
        {
            private IContainer components = null;
            private RadLabel lblCurrent;
            private RadLabel lblNew;
            private RadLabel lblConfirm;
            private RadTextBox txtCurrent;
            private RadTextBox txtNew;
            private RadTextBox txtConfirm;
            private RadButton btnSave;
            private RadButton btnCancel;

            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null)) components.Dispose();
                base.Dispose(disposing);
            }

            private void InitializeComponent()
            {
                this.lblCurrent = new RadLabel();
                this.lblNew = new RadLabel();
                this.lblConfirm = new RadLabel();
                this.txtCurrent = new RadTextBox();
                this.txtNew = new RadTextBox();
                this.txtConfirm = new RadTextBox();
                this.btnSave = new RadButton();
                this.btnCancel = new RadButton();

                ((ISupportInitialize)(this.lblCurrent)).BeginInit();
                ((ISupportInitialize)(this.lblNew)).BeginInit();
                ((ISupportInitialize)(this.lblConfirm)).BeginInit();
                ((ISupportInitialize)(this.txtCurrent)).BeginInit();
                ((ISupportInitialize)(this.txtNew)).BeginInit();
                ((ISupportInitialize)(this.txtConfirm)).BeginInit();
                ((ISupportInitialize)(this.btnSave)).BeginInit();
                ((ISupportInitialize)(this.btnCancel)).BeginInit();

                this.SuspendLayout();

                this.lblCurrent.Location = new System.Drawing.Point(20, 20);
                this.lblCurrent.Size = new System.Drawing.Size(100, 18);
                this.lblCurrent.Text = "رمز فعلی";

                this.txtCurrent.Location = new System.Drawing.Point(130, 18);
                this.txtCurrent.Size = new System.Drawing.Size(200, 24);
                this.txtCurrent.PasswordChar = '*';

                this.lblNew.Location = new System.Drawing.Point(20, 60);
                this.lblNew.Size = new System.Drawing.Size(100, 18);
                this.lblNew.Text = "رمز جدید";

                this.txtNew.Location = new System.Drawing.Point(130, 58);
                this.txtNew.Size = new System.Drawing.Size(200, 24);
                this.txtNew.PasswordChar = '*';

                this.lblConfirm.Location = new System.Drawing.Point(20, 100);
                this.lblConfirm.Size = new System.Drawing.Size(100, 18);
                this.lblConfirm.Text = "تکرار رمز جدید";

                this.txtConfirm.Location = new System.Drawing.Point(130, 98);
                this.txtConfirm.Size = new System.Drawing.Size(200, 24);
                this.txtConfirm.PasswordChar = '*';

                this.btnSave.Location = new System.Drawing.Point(130, 140);
                this.btnSave.Size = new System.Drawing.Size(90, 30);
                this.btnSave.Text = "ذخیره";
                this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

                this.btnCancel.Location = new System.Drawing.Point(240, 140);
                this.btnCancel.Size = new System.Drawing.Size(90, 30);
                this.btnCancel.Text = "انصراف";
                this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

                this.ClientSize = new System.Drawing.Size(360, 190);
                this.Controls.Add(this.lblCurrent);
                this.Controls.Add(this.txtCurrent);
                this.Controls.Add(this.lblNew);
                this.Controls.Add(this.txtNew);
                this.Controls.Add(this.lblConfirm);
                this.Controls.Add(this.txtConfirm);
                this.Controls.Add(this.btnSave);
                this.Controls.Add(this.btnCancel);
                this.Text = "تغییر رمز عبور";
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

                ((ISupportInitialize)(this.lblCurrent)).EndInit();
                ((ISupportInitialize)(this.lblNew)).EndInit();
                ((ISupportInitialize)(this.lblConfirm)).EndInit();
                ((ISupportInitialize)(this.txtCurrent)).EndInit();
                ((ISupportInitialize)(this.txtNew)).EndInit();
                ((ISupportInitialize)(this.txtConfirm)).EndInit();
                ((ISupportInitialize)(this.btnSave)).EndInit();
                ((ISupportInitialize)(this.btnCancel)).EndInit();
                this.ResumeLayout(false);
                this.PerformLayout();
            }
        }
    }
}
