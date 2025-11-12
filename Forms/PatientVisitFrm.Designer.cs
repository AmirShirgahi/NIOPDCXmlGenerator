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
        private RadGridView gridVisitDetails;
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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientVisitFrm));
            this.panelTop = new Telerik.WinControls.UI.RadPanel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.txtVisitNo = new Telerik.WinControls.UI.RadSpinEditor();
            this.ddDoctor = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtBookletExpiry = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.txtVisitDate = new Telerik.WinControls.UI.RadMaskedEditBox();
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
            this.gridVisitDetails = new Telerik.WinControls.UI.RadGridView();
            this.btnEditQuantity = new Telerik.WinControls.UI.RadButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
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
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.btnSearch = new Telerik.WinControls.UI.RadButton();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.btnEdit = new Telerik.WinControls.UI.RadButton();
            this.btnInsert = new Telerik.WinControls.UI.RadButton();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.panelTop)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVisitNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBookletExpiry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVisitDate)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridVisitDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVisitDetails.MasterTemplate)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInsert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.radLabel3);
            this.panelTop.Controls.Add(this.txtVisitNo);
            this.panelTop.Controls.Add(this.ddDoctor);
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
            this.panelTop.Size = new System.Drawing.Size(1084, 148);
            this.panelTop.TabIndex = 1;
            this.panelTop.ThemeName = "ControlDefault";
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_Paint);
            // 
            // radLabel3
            // 
            this.radLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel3.Font = new System.Drawing.Font("B Koodak", 14F);
            this.radLabel3.Location = new System.Drawing.Point(523, 98);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel3.Size = new System.Drawing.Size(57, 37);
            this.radLabel3.TabIndex = 21;
            this.radLabel3.Text = "پزشک:";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel3.ThemeName = "ControlDefault";
            // 
            // txtVisitNo
            // 
            this.txtVisitNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVisitNo.Font = new System.Drawing.Font("B Koodak", 14F);
            this.txtVisitNo.Location = new System.Drawing.Point(830, 11);
            this.txtVisitNo.Name = "txtVisitNo";
            this.txtVisitNo.ShowUpDownButtons = false;
            this.txtVisitNo.Size = new System.Drawing.Size(137, 38);
            this.txtVisitNo.TabIndex = 18;
            this.txtVisitNo.ThemeName = "ControlDefault";
            // 
            // ddDoctor
            // 
            this.ddDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ddDoctor.DropDownAnimationEnabled = true;
            this.ddDoctor.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddDoctor.Font = new System.Drawing.Font("B Koodak", 14F);
            this.ddDoctor.Location = new System.Drawing.Point(133, 100);
            this.ddDoctor.Name = "ddDoctor";
            this.ddDoctor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ddDoctor.Size = new System.Drawing.Size(384, 38);
            this.ddDoctor.TabIndex = 20;
            this.ddDoctor.ThemeName = "ControlDefault";
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.ddDoctor.GetChildAt(0))).RightToLeft = true;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.ddDoctor.GetChildAt(0))).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.ddDoctor.GetChildAt(0))).Font = new System.Drawing.Font("B Koodak", 14F);
            ((Telerik.WinControls.UI.RadDropDownListArrowButtonElement)(this.ddDoctor.GetChildAt(0).GetChildAt(2).GetChildAt(1))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel2.Font = new System.Drawing.Font("B Koodak", 14F);
            this.radLabel2.Location = new System.Drawing.Point(973, 12);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel2.Size = new System.Drawing.Size(99, 37);
            this.radLabel2.TabIndex = 19;
            this.radLabel2.Text = "شماره ویزیت:";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel2.ThemeName = "ControlDefault";
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel1.Font = new System.Drawing.Font("B Koodak", 14F);
            this.radLabel1.Location = new System.Drawing.Point(523, 55);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel1.Size = new System.Drawing.Size(62, 37);
            this.radLabel1.TabIndex = 17;
            this.radLabel1.Text = "وضعیت:";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel1.ThemeName = "ControlDefault";
            // 
            // txtBookletExpiry
            // 
            this.txtBookletExpiry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBookletExpiry.Font = new System.Drawing.Font("B Koodak", 14F);
            this.txtBookletExpiry.Location = new System.Drawing.Point(133, 56);
            this.txtBookletExpiry.Mask = "####/##/##";
            this.txtBookletExpiry.MaskType = Telerik.WinControls.UI.MaskType.Standard;
            this.txtBookletExpiry.Name = "txtBookletExpiry";
            this.txtBookletExpiry.NullText = "تاریخ";
            this.txtBookletExpiry.Size = new System.Drawing.Size(137, 38);
            this.txtBookletExpiry.TabIndex = 8;
            this.txtBookletExpiry.TabStop = false;
            this.txtBookletExpiry.Text = "____/__/__";
            this.txtBookletExpiry.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.txtBookletExpiry.ThemeName = "ControlDefault";
            // 
            // txtVisitDate
            // 
            this.txtVisitDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVisitDate.Font = new System.Drawing.Font("B Koodak", 14F);
            this.txtVisitDate.Location = new System.Drawing.Point(830, 98);
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
            // txtPageNo
            // 
            this.txtPageNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPageNo.Font = new System.Drawing.Font("B Koodak", 14F);
            this.txtPageNo.Location = new System.Drawing.Point(591, 99);
            this.txtPageNo.Name = "txtPageNo";
            this.txtPageNo.ShowUpDownButtons = false;
            this.txtPageNo.Size = new System.Drawing.Size(137, 38);
            this.txtPageNo.TabIndex = 7;
            this.txtPageNo.ThemeName = "ControlDefault";
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.Font = new System.Drawing.Font("B Koodak", 14F);
            this.txtLastName.Location = new System.Drawing.Point(133, 12);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLastName.Size = new System.Drawing.Size(137, 38);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.ThemeName = "ControlDefault";
            // 
            // txtMobile
            // 
            this.txtMobile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMobile.Font = new System.Drawing.Font("B Koodak", 14F);
            this.txtMobile.Location = new System.Drawing.Point(591, 55);
            this.txtMobile.Mask = "###########";
            this.txtMobile.MaskType = Telerik.WinControls.UI.MaskType.Standard;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(137, 38);
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
            this.txtNationalCode.Location = new System.Drawing.Point(830, 55);
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
            this.txtFirstName.Location = new System.Drawing.Point(380, 12);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFirstName.Size = new System.Drawing.Size(137, 38);
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
            this.ddlStatus.Location = new System.Drawing.Point(380, 55);
            this.ddlStatus.Name = "ddlStatus";
            this.ddlStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ddlStatus.Size = new System.Drawing.Size(137, 38);
            this.ddlStatus.TabIndex = 5;
            this.ddlStatus.Text = "کارمند";
            this.ddlStatus.ThemeName = "ControlDefault";
            // 
            // txtPersonnelCode
            // 
            this.txtPersonnelCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPersonnelCode.Font = new System.Drawing.Font("B Koodak", 14F);
            this.txtPersonnelCode.Location = new System.Drawing.Point(591, 12);
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
            this.lblPersonnel.Location = new System.Drawing.Point(734, 13);
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
            this.lblFirstName.Location = new System.Drawing.Point(519, 13);
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
            this.lblLastName.Location = new System.Drawing.Point(280, 13);
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
            this.lblNational.Location = new System.Drawing.Point(973, 55);
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
            this.lblMobile.Location = new System.Drawing.Point(734, 55);
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
            this.lblVisitDate.Location = new System.Drawing.Point(973, 98);
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
            this.lblBookletExpiry.Location = new System.Drawing.Point(280, 56);
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
            this.lblPageNo.Location = new System.Drawing.Point(730, 99);
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
            this.btnAddService.Location = new System.Drawing.Point(3, 12);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddService.Size = new System.Drawing.Size(124, 130);
            this.btnAddService.TabIndex = 9;
            this.btnAddService.Text = "تایید\r\n و \r\nثبت خدمات";
            this.btnAddService.ThemeName = "ControlDefault";
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // gridVisitDetails
            // 
            this.gridVisitDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridVisitDetails.Font = new System.Drawing.Font("B Koodak", 14F);
            this.gridVisitDetails.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.gridVisitDetails.MasterTemplate.AllowAddNewRow = false;
            this.gridVisitDetails.MasterTemplate.AllowDeleteRow = false;
            this.gridVisitDetails.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gridVisitDetails.Name = "gridVisitDetails";
            this.gridVisitDetails.ShowGroupPanel = false;
            this.gridVisitDetails.Size = new System.Drawing.Size(1009, 406);
            this.gridVisitDetails.TabIndex = 0;
            this.gridVisitDetails.ThemeName = "ControlDefault";
            // 
            // btnEditQuantity
            // 
            this.btnEditQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditQuantity.Font = new System.Drawing.Font("B Koodak", 14F);
            this.btnEditQuantity.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditQuantity.ImageIndex = 9;
            this.btnEditQuantity.ImageList = this.imageList1;
            this.btnEditQuantity.Location = new System.Drawing.Point(766, 6);
            this.btnEditQuantity.Name = "btnEditQuantity";
            this.btnEditQuantity.Size = new System.Drawing.Size(72, 61);
            this.btnEditQuantity.TabIndex = 3;
            this.btnEditQuantity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditQuantity.ThemeName = "ControlDefault";
            this.btnEditQuantity.Click += new System.EventHandler(this.btnEditQuantity_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Black;
            this.imageList1.Images.SetKeyName(0, "add.png");
            this.imageList1.Images.SetKeyName(1, "delete.png");
            this.imageList1.Images.SetKeyName(2, "delete-button-png-28566.png");
            this.imageList1.Images.SetKeyName(3, "Doctors.png");
            this.imageList1.Images.SetKeyName(4, "door-icon-10418.png");
            this.imageList1.Images.SetKeyName(5, "edit.png");
            this.imageList1.Images.SetKeyName(6, "exit-icon-4619.png");
            this.imageList1.Images.SetKeyName(7, "ok-icon-3111.png");
            this.imageList1.Images.SetKeyName(8, "ok-icon-3116.png");
            this.imageList1.Images.SetKeyName(9, "save-icon-5400(1).png");
            this.imageList1.Images.SetKeyName(10, "search.png");
            this.imageList1.Images.SetKeyName(11, "yes-png-39568.png");
            // 
            // btnRemoveService
            // 
            this.btnRemoveService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveService.Font = new System.Drawing.Font("B Koodak", 14F);
            this.btnRemoveService.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRemoveService.ImageIndex = 9;
            this.btnRemoveService.ImageList = this.imageList1;
            this.btnRemoveService.Location = new System.Drawing.Point(883, 6);
            this.btnRemoveService.Name = "btnRemoveService";
            this.btnRemoveService.Size = new System.Drawing.Size(72, 61);
            this.btnRemoveService.TabIndex = 4;
            this.btnRemoveService.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            this.panelTotals.Location = new System.Drawing.Point(0, 554);
            this.panelTotals.Name = "panelTotals";
            this.panelTotals.Size = new System.Drawing.Size(1084, 78);
            this.panelTotals.TabIndex = 2;
            this.panelTotals.ThemeName = "ControlDefault";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("B Koodak", 14F);
            this.btnClose.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.ImageIndex = 6;
            this.btnClose.ImageList = this.imageList1;
            this.btnClose.Location = new System.Drawing.Point(12, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(67, 61);
            this.btnClose.TabIndex = 6;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClose.ThemeName = "ControlDefault";
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAll.Font = new System.Drawing.Font("B Koodak", 14F);
            this.btnSaveAll.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveAll.ImageIndex = 9;
            this.btnSaveAll.ImageList = this.imageList1;
            this.btnSaveAll.Location = new System.Drawing.Point(1000, 6);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(72, 61);
            this.btnSaveAll.TabIndex = 5;
            this.btnSaveAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.btnSearch);
            this.radPanel1.Controls.Add(this.btnDelete);
            this.radPanel1.Controls.Add(this.btnEdit);
            this.radPanel1.Controls.Add(this.btnInsert);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.radPanel1.Location = new System.Drawing.Point(1009, 148);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(75, 406);
            this.radPanel1.TabIndex = 0;
            this.radPanel1.ThemeName = "ControlDefault";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("B Koodak", 14F);
            this.btnSearch.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.ImageIndex = 0;
            this.btnSearch.ImageKey = "search.png";
            this.btnSearch.ImageList = this.imageList1;
            this.btnSearch.Location = new System.Drawing.Point(6, 213);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(63, 63);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSearch.ThemeName = "ControlDefault";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Font = new System.Drawing.Font("B Koodak", 14F);
            this.btnDelete.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.ImageIndex = 1;
            this.btnDelete.ImageKey = "add.png";
            this.btnDelete.ImageList = this.imageList1;
            this.btnDelete.Location = new System.Drawing.Point(6, 144);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(63, 63);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.ThemeName = "ControlDefault";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Font = new System.Drawing.Font("B Koodak", 14F);
            this.btnEdit.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.ImageIndex = 3;
            this.btnEdit.ImageKey = "add.png";
            this.btnEdit.ImageList = this.imageList1;
            this.btnEdit.Location = new System.Drawing.Point(6, 75);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(63, 63);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEdit.ThemeName = "ControlDefault";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsert.Font = new System.Drawing.Font("B Koodak", 14F);
            this.btnInsert.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInsert.ImageIndex = 0;
            this.btnInsert.ImageKey = "add.png";
            this.btnInsert.ImageList = this.imageList1;
            this.btnInsert.Location = new System.Drawing.Point(6, 6);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(63, 63);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.btnInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInsert.ThemeName = "ControlDefault";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.gridVisitDetails);
            this.radPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel2.Location = new System.Drawing.Point(0, 148);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(1009, 406);
            this.radPanel2.TabIndex = 3;
            this.radPanel2.ThemeName = "ControlDefault";
            // 
            // PatientVisitFrm
            // 
            this.ClientSize = new System.Drawing.Size(1084, 632);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.radPanel1);
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
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVisitNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBookletExpiry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVisitDate)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridVisitDetails.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVisitDetails)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInsert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
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
        private RadSpinEditor txtVisitNo;
        private RadLabel radLabel2;
        private RadLabel radLabel1;
        private RadLabel radLabel3;
        private RadDropDownList ddDoctor;
        private RadPanel radPanel1;
        private RadPanel radPanel2;
        private RadButton btnInsert;
        public ImageList imageList1;
        private RadButton btnSearch;
        private RadButton btnDelete;
        private RadButton btnEdit;
    }
}
