using System.ComponentModel;
using Telerik.WinControls.UI;

namespace NIOPDCXmlGenerator.Forms
{
    partial class InsertPatientFrm : RadForm
    {
        private IContainer components = null;
        private RadLabel lblPersonnelCode;
        private RadLabel lblFirstName;
        private RadLabel lblLastName;
        private RadLabel lblNationalCode;
        private RadLabel lblMobile;
        private RadTextBox txtFirstName;
        private RadDropDownList ddlStatus;
        private RadLabel lblStatus;
        private RadButton btnSave;
        private RadButton btnCancel;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            this.lblPersonnelCode = new Telerik.WinControls.UI.RadLabel();
            this.lblFirstName = new Telerik.WinControls.UI.RadLabel();
            this.lblLastName = new Telerik.WinControls.UI.RadLabel();
            this.lblNationalCode = new Telerik.WinControls.UI.RadLabel();
            this.lblMobile = new Telerik.WinControls.UI.RadLabel();
            this.txtFirstName = new Telerik.WinControls.UI.RadTextBox();
            this.ddlStatus = new Telerik.WinControls.UI.RadDropDownList();
            this.lblStatus = new Telerik.WinControls.UI.RadLabel();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.txtPersonnelCode = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.txtNationalCode = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.txtMobile = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.txtLastName = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.ddGender = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.lblPersonnelCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNationalCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMobile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonnelCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNationalCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPersonnelCode
            // 
            this.lblPersonnelCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPersonnelCode.Font = new System.Drawing.Font("B Koodak", 14F);
            this.lblPersonnelCode.Location = new System.Drawing.Point(235, 12);
            this.lblPersonnelCode.Name = "lblPersonnelCode";
            this.lblPersonnelCode.Size = new System.Drawing.Size(79, 37);
            this.lblPersonnelCode.TabIndex = 0;
            this.lblPersonnelCode.Text = "کد پرسنلی";
            this.lblPersonnelCode.ThemeName = "ControlDefault";
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFirstName.Font = new System.Drawing.Font("B Koodak", 14F);
            this.lblFirstName.Location = new System.Drawing.Point(235, 56);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(26, 37);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "نام";
            this.lblFirstName.ThemeName = "ControlDefault";
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastName.Font = new System.Drawing.Font("B Koodak", 14F);
            this.lblLastName.Location = new System.Drawing.Point(235, 100);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(90, 37);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "نام خانوادگی";
            this.lblLastName.ThemeName = "ControlDefault";
            // 
            // lblNationalCode
            // 
            this.lblNationalCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNationalCode.Font = new System.Drawing.Font("B Koodak", 14F);
            this.lblNationalCode.Location = new System.Drawing.Point(235, 181);
            this.lblNationalCode.Name = "lblNationalCode";
            this.lblNationalCode.Size = new System.Drawing.Size(54, 37);
            this.lblNationalCode.TabIndex = 6;
            this.lblNationalCode.Text = "کد ملی";
            this.lblNationalCode.ThemeName = "ControlDefault";
            // 
            // lblMobile
            // 
            this.lblMobile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMobile.Font = new System.Drawing.Font("B Koodak", 14F);
            this.lblMobile.Location = new System.Drawing.Point(235, 225);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(50, 37);
            this.lblMobile.TabIndex = 8;
            this.lblMobile.Text = "موبایل";
            this.lblMobile.ThemeName = "ControlDefault";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.Font = new System.Drawing.Font("B Koodak", 14F);
            this.txtFirstName.Location = new System.Drawing.Point(9, 56);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFirstName.Size = new System.Drawing.Size(220, 38);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.ThemeName = "ControlDefault";
            this.txtFirstName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveFocusOnEnter);
            // 
            // ddlStatus
            // 
            this.ddlStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlStatus.DropDownAnimationEnabled = true;
            this.ddlStatus.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlStatus.Font = new System.Drawing.Font("B Koodak", 14F);
            radListDataItem1.Selected = true;
            radListDataItem1.Text = "کارمند";
            radListDataItem2.Text = "بازنشسته";
            this.ddlStatus.Items.Add(radListDataItem1);
            this.ddlStatus.Items.Add(radListDataItem2);
            this.ddlStatus.Location = new System.Drawing.Point(9, 272);
            this.ddlStatus.Name = "ddlStatus";
            this.ddlStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ddlStatus.Size = new System.Drawing.Size(220, 38);
            this.ddlStatus.TabIndex = 6;
            this.ddlStatus.Text = "کارمند";
            this.ddlStatus.ThemeName = "ControlDefault";
            this.ddlStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveFocusOnEnter);
            this.ddlStatus.Enter += new System.EventHandler(this.ddlStatus_Enter);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.Font = new System.Drawing.Font("B Koodak", 14F);
            this.lblStatus.Location = new System.Drawing.Point(235, 272);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(58, 37);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "وضعیت";
            this.lblStatus.ThemeName = "ControlDefault";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("B Koodak", 14F);
            this.btnSave.Location = new System.Drawing.Point(9, 316);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 30);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "ذخیره";
            this.btnSave.ThemeName = "ControlDefault";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("B Koodak", 14F);
            this.btnCancel.Location = new System.Drawing.Point(139, 316);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.ThemeName = "ControlDefault";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPersonnelCode
            // 
            this.txtPersonnelCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPersonnelCode.Font = new System.Drawing.Font("B Koodak", 14F);
            this.txtPersonnelCode.Location = new System.Drawing.Point(9, 12);
            this.txtPersonnelCode.Mask = "999999-99";
            this.txtPersonnelCode.MaskType = Telerik.WinControls.UI.MaskType.Standard;
            this.txtPersonnelCode.Name = "txtPersonnelCode";
            this.txtPersonnelCode.NullText = "تاریخ";
            this.txtPersonnelCode.Size = new System.Drawing.Size(220, 38);
            this.txtPersonnelCode.TabIndex = 0;
            this.txtPersonnelCode.TabStop = false;
            this.txtPersonnelCode.Text = "______-__";
            this.txtPersonnelCode.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.txtPersonnelCode.ThemeName = "ControlDefault";
            this.txtPersonnelCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveFocusOnEnter);
            this.txtPersonnelCode.TextChanged += new System.EventHandler(this.txtPersonnelCode_TextChanged);
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNationalCode.Font = new System.Drawing.Font("B Koodak", 14F);
            this.txtNationalCode.Location = new System.Drawing.Point(9, 181);
            this.txtNationalCode.Mask = "9999999999";
            this.txtNationalCode.MaskType = Telerik.WinControls.UI.MaskType.Standard;
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.NullText = "کد ملی";
            this.txtNationalCode.Size = new System.Drawing.Size(220, 38);
            this.txtNationalCode.TabIndex = 4;
            this.txtNationalCode.TabStop = false;
            this.txtNationalCode.Text = "__________";
            this.txtNationalCode.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.txtNationalCode.ThemeName = "ControlDefault";
            this.txtNationalCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveFocusOnEnter);
            // 
            // txtMobile
            // 
            this.txtMobile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMobile.Font = new System.Drawing.Font("B Koodak", 14F);
            this.txtMobile.Location = new System.Drawing.Point(9, 225);
            this.txtMobile.Mask = "###########";
            this.txtMobile.MaskType = Telerik.WinControls.UI.MaskType.Standard;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(220, 38);
            this.txtMobile.TabIndex = 5;
            this.txtMobile.TabStop = false;
            this.txtMobile.Text = "___________";
            this.txtMobile.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.txtMobile.ThemeName = "ControlDefault";
            this.txtMobile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveFocusOnEnter);
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.Font = new System.Drawing.Font("B Koodak", 14F);
            this.txtLastName.Location = new System.Drawing.Point(9, 99);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLastName.Size = new System.Drawing.Size(220, 38);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.ThemeName = "ControlDefault";
            this.txtLastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveFocusOnEnter);
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel1.Font = new System.Drawing.Font("B Koodak", 14F);
            this.radLabel1.Location = new System.Drawing.Point(235, 143);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(58, 37);
            this.radLabel1.TabIndex = 15;
            this.radLabel1.Text = "جنسیت";
            this.radLabel1.ThemeName = "ControlDefault";
            // 
            // ddGender
            // 
            this.ddGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ddGender.DropDownAnimationEnabled = true;
            this.ddGender.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddGender.Font = new System.Drawing.Font("B Koodak", 14F);
            radListDataItem3.Text = "زن";
            radListDataItem4.Selected = true;
            radListDataItem4.Text = "مرد";
            this.ddGender.Items.Add(radListDataItem3);
            this.ddGender.Items.Add(radListDataItem4);
            this.ddGender.Location = new System.Drawing.Point(9, 143);
            this.ddGender.Name = "ddGender";
            this.ddGender.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ddGender.Size = new System.Drawing.Size(220, 38);
            this.ddGender.TabIndex = 3;
            this.ddGender.Text = "مرد";
            this.ddGender.ThemeName = "ControlDefault";
            this.ddGender.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveFocusOnEnter);
            // 
            // InsertPatientFrm
            // 
            this.ClientSize = new System.Drawing.Size(344, 357);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.ddGender);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtNationalCode);
            this.Controls.Add(this.txtPersonnelCode);
            this.Controls.Add(this.lblPersonnelCode);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblNationalCode);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.ddlStatus);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InsertPatientFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.InsertPatientFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lblPersonnelCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNationalCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMobile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonnelCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNationalCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private RadMaskedEditBox txtNationalCode;
        private RadMaskedEditBox txtMobile;
        private RadTextBox txtLastName;
        public RadMaskedEditBox txtPersonnelCode;
        private RadLabel radLabel1;
        private RadDropDownList ddGender;
    }
}
