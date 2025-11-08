using System.ComponentModel;
using Telerik.WinControls.UI;

namespace NIOPDCXmlGenerator.Forms
{
    partial class UserManagementFrm
    {
        private IContainer components = null;
        private RadGridView gridUsers;
        private RadTextBox txtUsername;
        private RadTextBox txtPassword;
        private RadTextBox txtFullName;
        private RadButton btnAdd;
        private RadButton btnDelete;
        private RadCheckBox chkIsAdmin;
        private RadLabel lblUsername;
        private RadLabel lblPassword;
        private RadLabel lblFullName;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.gridUsers = new Telerik.WinControls.UI.RadGridView();
            this.txtUsername = new Telerik.WinControls.UI.RadTextBox();
            this.txtPassword = new Telerik.WinControls.UI.RadTextBox();
            this.txtFullName = new Telerik.WinControls.UI.RadTextBox();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.chkIsAdmin = new Telerik.WinControls.UI.RadCheckBox();
            this.lblUsername = new Telerik.WinControls.UI.RadLabel();
            this.lblPassword = new Telerik.WinControls.UI.RadLabel();
            this.lblFullName = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFullName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gridUsers
            // 
            this.gridUsers.Location = new System.Drawing.Point(12, 120);
            // 
            // 
            // 
            this.gridUsers.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gridUsers.Name = "gridUsers";
            this.gridUsers.ReadOnly = true;
            this.gridUsers.Size = new System.Drawing.Size(860, 300);
            this.gridUsers.TabIndex = 0;
            this.gridUsers.ThemeName = "ControlDefault";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(110, 12);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 20);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.ThemeName = "ControlDefault";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(110, 46);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(200, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.ThemeName = "ControlDefault";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(110, 82);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(200, 20);
            this.txtFullName.TabIndex = 3;
            this.txtFullName.ThemeName = "ControlDefault";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(480, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "اضافه";
            this.btnAdd.ThemeName = "ControlDefault";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(480, 46);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "حذف";
            this.btnDelete.ThemeName = "ControlDefault";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // chkIsAdmin
            // 
            this.chkIsAdmin.Location = new System.Drawing.Point(340, 46);
            this.chkIsAdmin.Name = "chkIsAdmin";
            this.chkIsAdmin.Size = new System.Drawing.Size(53, 18);
            this.chkIsAdmin.TabIndex = 6;
            this.chkIsAdmin.Text = "Admin";
            this.chkIsAdmin.ThemeName = "ControlDefault";
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(12, 12);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(47, 18);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "نام کاربری";
            this.lblUsername.ThemeName = "ControlDefault";
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(12, 48);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(22, 18);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "رمز";
            this.lblPassword.ThemeName = "ControlDefault";
            // 
            // lblFullName
            // 
            this.lblFullName.Location = new System.Drawing.Point(12, 84);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(36, 18);
            this.lblFullName.TabIndex = 9;
            this.lblFullName.Text = "نام کامل";
            this.lblFullName.ThemeName = "ControlDefault";
            // 
            // UserManagementFrm
            // 
            this.ClientSize = new System.Drawing.Size(884, 441);
            this.Controls.Add(this.gridUsers);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.chkIsAdmin);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblFullName);
            this.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.Name = "UserManagementFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "مدیریت کاربران";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFullName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
