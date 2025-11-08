using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace NIOPDCXmlGenerator.Forms
{
    partial class PatientVisitFrm
    {
        private System.ComponentModel.IContainer components = null;
        // top controls
        private RadPanel panelTop;
        private RadLabel lblPersonnel;
        private RadLabel lblFirstName;
        private RadLabel lblLastName;
        private RadLabel lblNational;
        private RadLabel lblMobile;
        private RadLabel lblVisitDate;
        private RadLabel lblBookletExpiry;
        private RadLabel lblPageNo;
        private RadButton btnAddService;
        private RadGridView radGridViewServices;
        private RadButton btnEditQuantity;
        private RadButton btnRemoveService;

        // totals panel
        private RadPanel panelTotals;
        private RadLabel lblTotalQty;
        private RadTextBox txtTotalQuantity;
        private RadLabel lblTotalPatientShare;
        private RadTextBox txtTotalPatientShare;
        private RadLabel lblTotalCompanyShare;
        private RadTextBox txtTotalCompanyShare;
        private RadLabel lblTotalAmount;
        private RadTextBox txtTotalAmount;

        private RadButton btnSaveAll;
        private RadButton btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.panelTop = new Telerik.WinControls.UI.RadPanel();
            this.txtPageNo = new Telerik.WinControls.UI.RadSpinEditor();
            this.txtLastName = new Telerik.WinControls.UI.RadTextBox();
            this.txtMobile = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.txtNationalCode = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.txtFirstName = new Telerik.WinControls.UI.RadTextBox();
            this.ddlStatus = new Telerik.WinControls.UI.RadDropDownList();
            this.txtPersonnelCode = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.lblPersonnel = new Telerik.WinControls.UI.RadLabel();
            this.lblFirstName = new Telerik.WinControls.UI.RadLabel();
            this.lblLastName = new Telerik.WinControls.UI.RadLabel();
            this.lblNational = new Telerik.WinControls.UI.RadLabel();
            this.lblMobile = new Telerik.WinControls.UI.RadLabel();
            this.lblVisitDate = new Telerik.WinControls.UI.RadLabel();
            this.lblBookletExpiry = new Telerik.WinControls.UI.RadLabel();
            this.lblPageNo = new Telerik.WinControls.UI.RadLabel();
            this.btnAddService = new Telerik.WinControls.UI.RadButton();
            this.radGridViewServices = new Telerik.WinControls.UI.RadGridView();
            this.btnEditQuantity = new Telerik.WinControls.UI.RadButton();
            this.btnRemoveService = new Telerik.WinControls.UI.RadButton();
            this.panelTotals = new Telerik.WinControls.UI.RadPanel();
            this.btnClose = new Telerik.WinControls.UI.RadButton();
            this.btnSaveAll = new Telerik.WinControls.UI.RadButton();
            this.lblTotalQty = new Telerik.WinControls.UI.RadLabel();
            this.txtTotalQuantity = new Telerik.WinControls.UI.RadTextBox();
            this.lblTotalPatientShare = new Telerik.WinControls.UI.RadLabel();
            this.txtTotalPatientShare = new Telerik.WinControls.UI.RadTextBox();
            this.lblTotalCompanyShare = new Telerik.WinControls.UI.RadLabel();
            this.txtTotalCompanyShare = new Telerik.WinControls.UI.RadTextBox();
            this.lblTotalAmount = new Telerik.WinControls.UI.RadLabel();
            this.txtTotalAmount = new Telerik.WinControls.UI.RadTextBox();
            this.txtVisitDate = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.txtBookletExpiry = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radSpinEditor1 = new Telerik.WinControls.UI.RadSpinEditor();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.panelTop)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPageNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNationalCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonnelCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPersonnel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNational)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMobile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblVisitDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBookletExpiry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPageNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewServices.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelTotals)).BeginInit();
            this.panelTotals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotalQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotalPatientShare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPatientShare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotalCompanyShare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalCompanyShare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotalAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVisitDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBookletExpiry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.radSpinEditor1);
            this.panelTop.Controls.Add(this.radLabel2);
            this.panelTop.Controls.Add(this.radLabel1);
            this.panelTop.Controls.Add(this.txtBookletExpiry);
            this.panelTop.Controls.Add(this.txtVisitDate);
            this.panelTop.Controls.Add(this.txtPageNo);
            this.panelTop.Controls.Add(this.txtLastName);
            this.panelTop.Controls.Add(this.txtMobile);
            this.panelTop.Controls.Add(this.txtNationalCode);
            this.panelTop.Controls.Add(this.txtFirstName);
            this.panelTop.Controls.Add(this.ddlStatus);
            this.panelTop.Controls.Add(this.txtPersonnelCode);
            this.panelTop.Controls.Add(this.lblPersonnel);
            this.panelTop.Controls.Add(this.lblFirstName);
            this.panelTop.Controls.Add(this.lblLastName);
            this.panelTop.Controls.Add(this.lblNational);
            this.panelTop.Controls.Add(this.lblMobile);
            this.panelTop.Controls.Add(this.lblVisitDate);
            this.panelTop.Controls.Add(this.lblBookletExpiry);
            this.panelTop.Controls.Add(this.lblPageNo);
            this.panelTop.Controls.Add(this.btnAddService);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Font = new System.Drawing.Font("B Koodak", 14F);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1227, 190);
            this.panelTop.TabIndex = 1;
            this.panelTop.ThemeName = "ControlDefault";
            // 
            // txtPageNo
            // 
            this.txtPageNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPageNo.Font = new System.Drawing.Font("B Koodak", 14F);
            this.txtPageNo.Location = new System.Drawing.Point(582, 99);
            this.txtPageNo.Name = "txtPageNo";
            this.txtPageNo.ShowUpDownButtons = false;
            this.txtPageNo.Size = new System.Drawing.Size(133, 38);
            this.txtPageNo.TabIndex = 7;
            this.txtPageNo.ThemeName = "ControlDefault";
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.Font = new System.Drawing.Font("B Koodak", 14F);
            this.txtLastName.Location = new System.Drawing.Point(335, 13);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLastName.Size = new System.Drawing.Size(141, 38);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.ThemeName = "ControlDefault";
            // 
            // txtMobile
            // 
            this.txtMobile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMobile.Font = new System.Drawing.Font("B Koodak", 14F);
            this.txtMobile.Location = new System.Drawing.Point(582, 56);
            this.txtMobile.Mask = "###########";
            this.txtMobile.MaskType = Telerik.WinControls.UI.MaskType.Standard;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(133, 38);
            this.txtMobile.TabIndex = 4;
            this.txtMobile.TabStop = false;
            this.txtMobile.Text = "___________";
            this.txtMobile.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.txtMobile.ThemeName = "ControlDefault";
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNationalCode.Font = new System.Drawing.Font("B Koodak", 14F);
            this.txtNationalCode.Location = new System.Drawing.Point(821, 54);
            this.txtNationalCode.Mask = "9999999999";
            this.txtNationalCode.MaskType = Telerik.WinControls.UI.MaskType.Standard;
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.NullText = "کد ملی";
            this.txtNationalCode.Size = new System.Drawing.Size(137, 38);
            this.txtNationalCode.TabIndex = 3;
            this.txtNationalCode.TabStop = false;
            this.txtNationalCode.Text = "__________";
            this.txtNationalCode.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.txtNationalCode.ThemeName = "ControlDefault";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.Font = new System.Drawing.Font("B Koodak", 14F);
            this.txtFirstName.Location = new System.Drawing.Point(582, 11);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFirstName.Size = new System.Drawing.Size(133, 38);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.ThemeName = "ControlDefault";
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
            this.ddlStatus.Location = new System.Drawing.Point(335, 57);
            this.ddlStatus.Name = "ddlStatus";
            this.ddlStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ddlStatus.Size = new System.Drawing.Size(141, 38);
            this.ddlStatus.TabIndex = 5;
            this.ddlStatus.Text = "کارمند";
            this.ddlStatus.ThemeName = "ControlDefault";
            // 
            // txtPersonnelCode
            // 
            this.txtPersonnelCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPersonnelCode.Font = new System.Drawing.Font("B Koodak", 14F);
            this.txtPersonnelCode.Location = new System.Drawing.Point(821, 10);
            this.txtPersonnelCode.Mask = "999999-99";
            this.txtPersonnelCode.MaskType = Telerik.WinControls.UI.MaskType.Standard;
            this.txtPersonnelCode.Name = "txtPersonnelCode";
            this.txtPersonnelCode.NullText = "تاریخ";
            this.txtPersonnelCode.Size = new System.Drawing.Size(137, 38);
            this.txtPersonnelCode.TabIndex = 0;
            this.txtPersonnelCode.TabStop = false;
            this.txtPersonnelCode.Text = "______-__";
            this.txtPersonnelCode.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.txtPersonnelCode.ThemeName = "ControlDefault";
            this.txtPersonnelCode.TextChanged += new System.EventHandler(this.txtPersonnelCode_TextChanged);
            // 
            // lblPersonnel
            // 
            this.lblPersonnel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPersonnel.Font = new System.Drawing.Font("B Koodak", 14F);
            this.lblPersonnel.Location = new System.Drawing.Point(964, 12);
            this.lblPersonnel.Name = "lblPersonnel";
            this.lblPersonnel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPersonnel.Size = new System.Drawing.Size(83, 37);
            this.lblPersonnel.TabIndex = 0;
            this.lblPersonnel.Text = "کد پرسنلی:";
            this.lblPersonnel.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lblPersonnel.ThemeName = "ControlDefault";
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFirstName.Font = new System.Drawing.Font("B Koodak", 14F);
            this.lblFirstName.Location = new System.Drawing.Point(721, 13);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFirstName.Size = new System.Drawing.Size(30, 37);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "نام:";
            this.lblFirstName.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lblFirstName.ThemeName = "ControlDefault";
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastName.Font = new System.Drawing.Font("B Koodak", 14F);
            this.lblLastName.Location = new System.Drawing.Point(482, 13);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLastName.Size = new System.Drawing.Size(94, 37);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "نام خانوادگی:";
            this.lblLastName.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lblLastName.ThemeName = "ControlDefault";
            // 
            // lblNational
            // 
            this.lblNational.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNational.Font = new System.Drawing.Font("B Koodak", 14F);
            this.lblNational.Location = new System.Drawing.Point(964, 54);
            this.lblNational.Name = "lblNational";
            this.lblNational.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNational.Size = new System.Drawing.Size(58, 37);
            this.lblNational.TabIndex = 7;
            this.lblNational.Text = "کد ملی:";
            this.lblNational.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lblNational.ThemeName = "ControlDefault";
            // 
            // lblMobile
            // 
            this.lblMobile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMobile.Font = new System.Drawing.Font("B Koodak", 14F);
            this.lblMobile.Location = new System.Drawing.Point(721, 54);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMobile.Size = new System.Drawing.Size(54, 37);
            this.lblMobile.TabIndex = 9;
            this.lblMobile.Text = "موبایل:";
            this.lblMobile.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lblMobile.ThemeName = "ControlDefault";
            // 
            // lblVisitDate
            // 
            this.lblVisitDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVisitDate.Font = new System.Drawing.Font("B Koodak", 14F);
            this.lblVisitDate.Location = new System.Drawing.Point(964, 100);
            this.lblVisitDate.Name = "lblVisitDate";
            this.lblVisitDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblVisitDate.Size = new System.Drawing.Size(95, 37);
            this.lblVisitDate.TabIndex = 12;
            this.lblVisitDate.Text = "تاریخ ویزیت:";
            this.lblVisitDate.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lblVisitDate.ThemeName = "ControlDefault";
            // 
            // lblBookletExpiry
            // 
            this.lblBookletExpiry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBookletExpiry.Font = new System.Drawing.Font("B Koodak", 14F);
            this.lblBookletExpiry.Location = new System.Drawing.Point(482, 99);
            this.lblBookletExpiry.Name = "lblBookletExpiry";
            this.lblBookletExpiry.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBookletExpiry.Size = new System.Drawing.Size(99, 37);
            this.lblBookletExpiry.TabIndex = 14;
            this.lblBookletExpiry.Text = "اعتبار دفترچه:";
            this.lblBookletExpiry.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lblBookletExpiry.ThemeName = "ControlDefault";
            // 
            // lblPageNo
            // 
            this.lblPageNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPageNo.Font = new System.Drawing.Font("B Koodak", 14F);
            this.lblPageNo.Location = new System.Drawing.Point(721, 101);
            this.lblPageNo.Name = "lblPageNo";
            this.lblPageNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPageNo.Size = new System.Drawing.Size(94, 37);
            this.lblPageNo.TabIndex = 16;
            this.lblPageNo.Text = "شماره صفحه:";
            this.lblPageNo.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lblPageNo.ThemeName = "ControlDefault";
            // 
            // btnAddService
            // 
            this.btnAddService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddService.Font = new System.Drawing.Font("B Koodak", 14F);
            this.btnAddService.Location = new System.Drawing.Point(1104, 153);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddService.Size = new System.Drawing.Size(111, 31);
            this.btnAddService.TabIndex = 9;
            this.btnAddService.Text = "بازیابی اطلاعات";
            this.btnAddService.ThemeName = "ControlDefault";
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // radGridViewServices
            // 
            this.radGridViewServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridViewServices.Font = new System.Drawing.Font("B Koodak", 14F);
            this.radGridViewServices.Location = new System.Drawing.Point(0, 190);
            // 
            // 
            // 
            this.radGridViewServices.MasterTemplate.AllowAddNewRow = false;
            this.radGridViewServices.MasterTemplate.AllowDeleteRow = false;
            this.radGridViewServices.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridViewServices.Name = "radGridViewServices";
            this.radGridViewServices.ShowGroupPanel = false;
            this.radGridViewServices.Size = new System.Drawing.Size(1227, 384);
            this.radGridViewServices.TabIndex = 0;
            this.radGridViewServices.ThemeName = "ControlDefault";
            // 
            // btnEditQuantity
            // 
            this.btnEditQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditQuantity.Font = new System.Drawing.Font("B Koodak", 14F);
            this.btnEditQuantity.Location = new System.Drawing.Point(56, 24);
            this.btnEditQuantity.Name = "btnEditQuantity";
            this.btnEditQuantity.Size = new System.Drawing.Size(111, 31);
            this.btnEditQuantity.TabIndex = 3;
            this.btnEditQuantity.Text = "ویرایش تعداد";
            this.btnEditQuantity.ThemeName = "ControlDefault";
            this.btnEditQuantity.Click += new System.EventHandler(this.btnEditQuantity_Click);
            // 
            // btnRemoveService
            // 
            this.btnRemoveService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveService.Font = new System.Drawing.Font("B Koodak", 14F);
            this.btnRemoveService.Location = new System.Drawing.Point(166, 24);
            this.btnRemoveService.Name = "btnRemoveService";
            this.btnRemoveService.Size = new System.Drawing.Size(111, 31);
            this.btnRemoveService.TabIndex = 4;
            this.btnRemoveService.Text = "حذف خدمت";
            this.btnRemoveService.ThemeName = "ControlDefault";
            this.btnRemoveService.Click += new System.EventHandler(this.btnRemoveService_Click);
            // 
            // panelTotals
            // 
            this.panelTotals.Controls.Add(this.btnEditQuantity);
            this.panelTotals.Controls.Add(this.btnClose);
            this.panelTotals.Controls.Add(this.btnSaveAll);
            this.panelTotals.Controls.Add(this.btnRemoveService);
            this.panelTotals.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTotals.Font = new System.Drawing.Font("B Koodak", 14F);
            this.panelTotals.Location = new System.Drawing.Point(0, 574);
            this.panelTotals.Name = "panelTotals";
            this.panelTotals.Size = new System.Drawing.Size(1227, 60);
            this.panelTotals.TabIndex = 2;
            this.panelTotals.ThemeName = "ControlDefault";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("B Koodak", 14F);
            this.btnClose.Location = new System.Drawing.Point(463, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 31);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "خروج";
            this.btnClose.ThemeName = "ControlDefault";
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAll.Font = new System.Drawing.Font("B Koodak", 14F);
            this.btnSaveAll.Location = new System.Drawing.Point(866, 24);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(111, 31);
            this.btnSaveAll.TabIndex = 5;
            this.btnSaveAll.Text = "ذخیره ویزیت";
            this.btnSaveAll.ThemeName = "ControlDefault";
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // lblTotalQty
            // 
            this.lblTotalQty.Font = new System.Drawing.Font("B Koodak", 14F);
            this.lblTotalQty.Location = new System.Drawing.Point(10, 8);
            this.lblTotalQty.Name = "lblTotalQty";
            this.lblTotalQty.Size = new System.Drawing.Size(72, 37);
            this.lblTotalQty.TabIndex = 0;
            this.lblTotalQty.Text = "تعداد کل:";
            // 
            // txtTotalQuantity
            // 
            this.txtTotalQuantity.Font = new System.Drawing.Font("B Koodak", 14F);
            this.txtTotalQuantity.Location = new System.Drawing.Point(80, 6);
            this.txtTotalQuantity.Name = "txtTotalQuantity";
            this.txtTotalQuantity.ReadOnly = true;
            this.txtTotalQuantity.Size = new System.Drawing.Size(81, 42);
            this.txtTotalQuantity.TabIndex = 0;
            // 
            // lblTotalPatientShare
            // 
            this.lblTotalPatientShare.Font = new System.Drawing.Font("B Koodak", 14F);
            this.lblTotalPatientShare.Location = new System.Drawing.Point(180, 8);
            this.lblTotalPatientShare.Name = "lblTotalPatientShare";
            this.lblTotalPatientShare.Size = new System.Drawing.Size(109, 37);
            this.lblTotalPatientShare.TabIndex = 0;
            this.lblTotalPatientShare.Text = "جمع سهم بیمار:";
            // 
            // txtTotalPatientShare
            // 
            this.txtTotalPatientShare.Font = new System.Drawing.Font("B Koodak", 14F);
            this.txtTotalPatientShare.Location = new System.Drawing.Point(280, 6);
            this.txtTotalPatientShare.Name = "txtTotalPatientShare";
            this.txtTotalPatientShare.ReadOnly = true;
            this.txtTotalPatientShare.Size = new System.Drawing.Size(121, 42);
            this.txtTotalPatientShare.TabIndex = 0;
            // 
            // lblTotalCompanyShare
            // 
            this.lblTotalCompanyShare.Font = new System.Drawing.Font("B Koodak", 14F);
            this.lblTotalCompanyShare.Location = new System.Drawing.Point(420, 8);
            this.lblTotalCompanyShare.Name = "lblTotalCompanyShare";
            this.lblTotalCompanyShare.Size = new System.Drawing.Size(123, 37);
            this.lblTotalCompanyShare.TabIndex = 0;
            this.lblTotalCompanyShare.Text = "جمع سهم شرکت:";
            // 
            // txtTotalCompanyShare
            // 
            this.txtTotalCompanyShare.Font = new System.Drawing.Font("B Koodak", 14F);
            this.txtTotalCompanyShare.Location = new System.Drawing.Point(520, 6);
            this.txtTotalCompanyShare.Name = "txtTotalCompanyShare";
            this.txtTotalCompanyShare.ReadOnly = true;
            this.txtTotalCompanyShare.Size = new System.Drawing.Size(121, 42);
            this.txtTotalCompanyShare.TabIndex = 0;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Font = new System.Drawing.Font("B Koodak", 14F);
            this.lblTotalAmount.Location = new System.Drawing.Point(660, 8);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(79, 37);
            this.lblTotalAmount.TabIndex = 0;
            this.lblTotalAmount.Text = "جمع نهایی:";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("B Koodak", 14F);
            this.txtTotalAmount.Location = new System.Drawing.Point(740, 6);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(121, 42);
            this.txtTotalAmount.TabIndex = 0;
            // 
            // txtVisitDate
            // 
            this.txtVisitDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVisitDate.Font = new System.Drawing.Font("B Koodak", 14F);
            this.txtVisitDate.Location = new System.Drawing.Point(821, 100);
            this.txtVisitDate.Mask = "9999/99/99";
            this.txtVisitDate.MaskType = Telerik.WinControls.UI.MaskType.Standard;
            this.txtVisitDate.Name = "txtVisitDate";
            this.txtVisitDate.NullText = "تاریخ";
            this.txtVisitDate.Size = new System.Drawing.Size(137, 38);
            this.txtVisitDate.TabIndex = 6;
            this.txtVisitDate.TabStop = false;
            this.txtVisitDate.Text = "____/__/__";
            this.txtVisitDate.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.txtVisitDate.ThemeName = "ControlDefault";
            // 
            // txtBookletExpiry
            // 
            this.txtBookletExpiry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBookletExpiry.Font = new System.Drawing.Font("B Koodak", 14F);
            this.txtBookletExpiry.Location = new System.Drawing.Point(335, 100);
            this.txtBookletExpiry.Mask = "####/##/##";
            this.txtBookletExpiry.MaskType = Telerik.WinControls.UI.MaskType.Standard;
            this.txtBookletExpiry.Name = "txtBookletExpiry";
            this.txtBookletExpiry.NullText = "تاریخ";
            this.txtBookletExpiry.Size = new System.Drawing.Size(141, 38);
            this.txtBookletExpiry.TabIndex = 8;
            this.txtBookletExpiry.TabStop = false;
            this.txtBookletExpiry.Text = "____/__/__";
            this.txtBookletExpiry.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.txtBookletExpiry.ThemeName = "ControlDefault";
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel1.Font = new System.Drawing.Font("B Koodak", 14F);
            this.radLabel1.Location = new System.Drawing.Point(482, 58);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel1.Size = new System.Drawing.Size(62, 37);
            this.radLabel1.TabIndex = 17;
            this.radLabel1.Text = "وضعیت:";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel1.ThemeName = "ControlDefault";
            // 
            // radSpinEditor1
            // 
            this.radSpinEditor1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radSpinEditor1.Font = new System.Drawing.Font("B Koodak", 14F);
            this.radSpinEditor1.Location = new System.Drawing.Point(1053, 12);
            this.radSpinEditor1.Name = "radSpinEditor1";
            this.radSpinEditor1.ShowUpDownButtons = false;
            this.radSpinEditor1.Size = new System.Drawing.Size(62, 38);
            this.radSpinEditor1.TabIndex = 18;
            this.radSpinEditor1.ThemeName = "ControlDefault";
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel2.Font = new System.Drawing.Font("B Koodak", 14F);
            this.radLabel2.Location = new System.Drawing.Point(1121, 14);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel2.Size = new System.Drawing.Size(99, 37);
            this.radLabel2.TabIndex = 19;
            this.radLabel2.Text = "شماره ویزیت:";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel2.ThemeName = "ControlDefault";
            // 
            // PatientVisitFrm
            // 
            this.ClientSize = new System.Drawing.Size(1227, 634);
            this.Controls.Add(this.radGridViewServices);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelTotals);
            this.Name = "PatientVisitFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ثبت / ویرایش ویزیت";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.PatientVisitFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelTop)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPageNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNationalCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonnelCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPersonnel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNational)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMobile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblVisitDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBookletExpiry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPageNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewServices.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelTotals)).EndInit();
            this.panelTotals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotalQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotalPatientShare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPatientShare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotalCompanyShare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalCompanyShare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotalAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVisitDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBookletExpiry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        private RadMaskedEditBox txtPersonnelCode;
        private RadTextBox txtLastName;
        private RadMaskedEditBox txtMobile;
        private RadMaskedEditBox txtNationalCode;
        private RadTextBox txtFirstName;
        private RadDropDownList ddlStatus;
        private RadSpinEditor txtPageNo;
        private RadMaskedEditBox txtBookletExpiry;
        private RadMaskedEditBox txtVisitDate;
        private RadSpinEditor radSpinEditor1;
        private RadLabel radLabel2;
        private RadLabel radLabel1;
    }
}
