using Telerik.WinControls.UI;

namespace NIOPDCXmlGenerator.Forms
{
    partial class FranchiseRateEditFrm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtTo = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.txtFrom = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.lblFrom = new Telerik.WinControls.UI.RadLabel();
            this.lblTo = new Telerik.WinControls.UI.RadLabel();
            this.lblRetiredPercent = new Telerik.WinControls.UI.RadLabel();
            this.txtRetiredPercent = new Telerik.WinControls.UI.RadTextBox();
            this.lblEmployeePercent = new Telerik.WinControls.UI.RadLabel();
            this.txtEmployeePercent = new Telerik.WinControls.UI.RadTextBox();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRetiredPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRetiredPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEmployeePercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeePercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTo
            // 
            this.txtTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTo.Font = new System.Drawing.Font("B Koodak", 14F);
            this.txtTo.Location = new System.Drawing.Point(12, 53);
            this.txtTo.Mask = "0000/00/00";
            this.txtTo.MaskType = Telerik.WinControls.UI.MaskType.Standard;
            this.txtTo.Name = "txtTo";
            this.txtTo.NullText = "تاریخ";
            this.txtTo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTo.Size = new System.Drawing.Size(147, 38);
            this.txtTo.TabIndex = 21;
            this.txtTo.TabStop = false;
            this.txtTo.Text = "____/__/__";
            this.txtTo.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.txtTo.ThemeName = "ControlDefault";
            // 
            // txtFrom
            // 
            this.txtFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFrom.Font = new System.Drawing.Font("B Koodak", 14F);
            this.txtFrom.Location = new System.Drawing.Point(12, 12);
            this.txtFrom.Mask = "0000/00/00";
            this.txtFrom.MaskType = Telerik.WinControls.UI.MaskType.Standard;
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.NullText = "تاریخ";
            this.txtFrom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFrom.Size = new System.Drawing.Size(147, 38);
            this.txtFrom.TabIndex = 20;
            this.txtFrom.TabStop = false;
            this.txtFrom.Text = "____/__/__";
            this.txtFrom.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.txtFrom.ThemeName = "ControlDefault";
            // 
            // lblFrom
            // 
            this.lblFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFrom.Font = new System.Drawing.Font("B Koodak", 14F);
            this.lblFrom.Location = new System.Drawing.Point(163, 18);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFrom.Size = new System.Drawing.Size(67, 37);
            this.lblFrom.TabIndex = 12;
            this.lblFrom.Text = "از تاریخ :";
            this.lblFrom.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lblFrom.ThemeName = "ControlDefault";
            // 
            // lblTo
            // 
            this.lblTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTo.Font = new System.Drawing.Font("B Koodak", 14F);
            this.lblTo.Location = new System.Drawing.Point(163, 58);
            this.lblTo.Name = "lblTo";
            this.lblTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTo.Size = new System.Drawing.Size(66, 37);
            this.lblTo.TabIndex = 13;
            this.lblTo.Text = "تا تاریخ :";
            this.lblTo.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lblTo.ThemeName = "ControlDefault";
            // 
            // lblRetiredPercent
            // 
            this.lblRetiredPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRetiredPercent.Font = new System.Drawing.Font("B Koodak", 14F);
            this.lblRetiredPercent.Location = new System.Drawing.Point(163, 98);
            this.lblRetiredPercent.Name = "lblRetiredPercent";
            this.lblRetiredPercent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRetiredPercent.Size = new System.Drawing.Size(114, 37);
            this.lblRetiredPercent.TabIndex = 14;
            this.lblRetiredPercent.Text = "درصد بازنشسته:";
            this.lblRetiredPercent.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lblRetiredPercent.ThemeName = "ControlDefault";
            // 
            // txtRetiredPercent
            // 
            this.txtRetiredPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRetiredPercent.Font = new System.Drawing.Font("B Koodak", 14F);
            this.txtRetiredPercent.Location = new System.Drawing.Point(13, 94);
            this.txtRetiredPercent.Name = "txtRetiredPercent";
            this.txtRetiredPercent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtRetiredPercent.Size = new System.Drawing.Size(147, 38);
            this.txtRetiredPercent.TabIndex = 15;
            this.txtRetiredPercent.ThemeName = "ControlDefault";
            // 
            // lblEmployeePercent
            // 
            this.lblEmployeePercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmployeePercent.Font = new System.Drawing.Font("B Koodak", 14F);
            this.lblEmployeePercent.Location = new System.Drawing.Point(163, 138);
            this.lblEmployeePercent.Name = "lblEmployeePercent";
            this.lblEmployeePercent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEmployeePercent.Size = new System.Drawing.Size(97, 37);
            this.lblEmployeePercent.TabIndex = 16;
            this.lblEmployeePercent.Text = "درصد کارمند:";
            this.lblEmployeePercent.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lblEmployeePercent.ThemeName = "ControlDefault";
            // 
            // txtEmployeePercent
            // 
            this.txtEmployeePercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmployeePercent.Font = new System.Drawing.Font("B Koodak", 14F);
            this.txtEmployeePercent.Location = new System.Drawing.Point(13, 135);
            this.txtEmployeePercent.Name = "txtEmployeePercent";
            this.txtEmployeePercent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEmployeePercent.Size = new System.Drawing.Size(147, 38);
            this.txtEmployeePercent.TabIndex = 17;
            this.txtEmployeePercent.ThemeName = "ControlDefault";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("B Koodak", 14F);
            this.btnSave.Location = new System.Drawing.Point(150, 179);
            this.btnSave.Name = "btnSave";
            this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSave.Size = new System.Drawing.Size(110, 45);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "ذخیره";
            this.btnSave.ThemeName = "ControlDefault";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("B Koodak", 14F);
            this.btnCancel.Location = new System.Drawing.Point(13, 179);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCancel.Size = new System.Drawing.Size(110, 45);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.ThemeName = "ControlDefault";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FranchiseRateEditFrm
            // 
            this.ClientSize = new System.Drawing.Size(289, 237);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblRetiredPercent);
            this.Controls.Add(this.txtRetiredPercent);
            this.Controls.Add(this.lblEmployeePercent);
            this.Controls.Add(this.txtEmployeePercent);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("B Koodak", 14F);
            this.Name = "FranchiseRateEditFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تعریف / ویرایش بازه فرانشیز";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.FranchiseRateEditFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRetiredPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRetiredPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEmployeePercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeePercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private RadMaskedEditBox txtTo;
        private RadMaskedEditBox txtFrom;
        private RadLabel lblFrom;
        private RadLabel lblTo;
        private RadLabel lblRetiredPercent;
        private RadTextBox txtRetiredPercent;
        private RadLabel lblEmployeePercent;
        private RadTextBox txtEmployeePercent;
        private RadButton btnSave;
        private RadButton btnCancel;
    }
}
