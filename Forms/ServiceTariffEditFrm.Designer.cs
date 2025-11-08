using Telerik.WinControls.UI;

namespace NIOPDCXmlGenerator.Forms
{
    partial class ServiceTariffEditFrm
    {
        private System.ComponentModel.IContainer components = null;
        private RadPanel panelMain;
        private RadLabel radLabel1;
        private RadLabel radLabel3;
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
            this.txtAmount = new Telerik.WinControls.UI.RadSpinEditor();
            this.ddlService = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.txtAmount);
            this.panelMain.Controls.Add(this.ddlService);
            this.panelMain.Controls.Add(this.radLabel1);
            this.panelMain.Controls.Add(this.radLabel3);
            this.panelMain.Controls.Add(this.btnSave);
            this.panelMain.Controls.Add(this.btnCancel);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(12);
            this.panelMain.Size = new System.Drawing.Size(440, 200);
            this.panelMain.TabIndex = 0;
            this.panelMain.ThemeName = "ControlDefault";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(160, 72);
            this.txtAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 9;
            this.txtAmount.ThemeName = "ControlDefault";
            // 
            // ddlService
            // 
            this.ddlService.DropDownAnimationEnabled = true;
            this.ddlService.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlService.Location = new System.Drawing.Point(160, 20);
            this.ddlService.Name = "ddlService";
            this.ddlService.Size = new System.Drawing.Size(125, 20);
            this.ddlService.TabIndex = 8;
            this.ddlService.Text = "radDropDownList1";
            this.ddlService.ThemeName = "ControlDefault";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(20, 20);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(114, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "از تاریخ (yyyy/MM/dd):";
            this.radLabel1.ThemeName = "ControlDefault";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(20, 100);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(71, 18);
            this.radLabel3.TabIndex = 2;
            this.radLabel3.Text = "مبلغ واحد (ریال):";
            this.radLabel3.ThemeName = "ControlDefault";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(40, 150);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 24);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "ذخیره";
            this.btnSave.ThemeName = "ControlDefault";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(140, 150);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 24);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.ThemeName = "ControlDefault";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ServiceTariffEditFrm
            // 
            this.ClientSize = new System.Drawing.Size(440, 200);
            this.Controls.Add(this.panelMain);
            this.Name = "ServiceTariffEditFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تعریف / ویرایش تعرفه خدمت";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.ServiceTariffEditFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        private RadDropDownList ddlService;
        private RadSpinEditor txtAmount;
    }
}
