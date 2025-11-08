using Telerik.WinControls.UI;

namespace NIOPDCXmlGenerator.Forms
{
    partial class ServiceEditFrm
    {
        private System.ComponentModel.IContainer components = null;
        private RadPanel panelMain;
        private RadLabel radLabel1;
        private RadTextBox txtTitle;
        private RadCheckBox chkActive;
        private RadButton btnSave;
        private RadButton btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelMain = new Telerik.WinControls.UI.RadPanel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtTitle = new Telerik.WinControls.UI.RadTextBox();
            this.chkActive = new Telerik.WinControls.UI.RadCheckBox();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.radLabel1);
            this.panelMain.Controls.Add(this.txtTitle);
            this.panelMain.Controls.Add(this.chkActive);
            this.panelMain.Controls.Add(this.btnSave);
            this.panelMain.Controls.Add(this.btnCancel);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(12);
            this.panelMain.Size = new System.Drawing.Size(480, 160);
            this.panelMain.TabIndex = 0;
            this.panelMain.ThemeName = "ControlDefault";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(20, 20);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(57, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "عنوان خدمت:";
            this.radLabel1.ThemeName = "ControlDefault";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(120, 18);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(300, 20);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.ThemeName = "ControlDefault";
            // 
            // chkActive
            // 
            this.chkActive.Location = new System.Drawing.Point(120, 60);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(36, 18);
            this.chkActive.TabIndex = 2;
            this.chkActive.Text = "فعال";
            this.chkActive.ThemeName = "ControlDefault";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(120, 100);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 24);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "ذخیره";
            this.btnSave.ThemeName = "ControlDefault";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(220, 100);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 24);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.ThemeName = "ControlDefault";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ServiceEditFrm
            // 
            this.ClientSize = new System.Drawing.Size(480, 160);
            this.Controls.Add(this.panelMain);
            this.Name = "ServiceEditFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تعریف / ویرایش خدمت";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.ServiceEditFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
