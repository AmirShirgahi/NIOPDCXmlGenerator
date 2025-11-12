namespace YourNamespace.Forms
{
    partial class PatientVisitDetailsFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Controls
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel lblPatientName;
        private Telerik.WinControls.UI.RadLabel lblVisitDate;
        private Telerik.WinControls.UI.RadLabel lblVisitType;
        private Telerik.WinControls.UI.RadLabel lblVisitNo;
        private Telerik.WinControls.UI.RadLabel lblFranchisePercentage;

        private Telerik.WinControls.UI.RadDropDownList rdlServices;
        private Telerik.WinControls.UI.RadSpinEditor rseQuantity;
        private Telerik.WinControls.UI.RadSpinEditor rseFranchiseAmount;
        private Telerik.WinControls.UI.RadSpinEditor rsePatientShare;
        private Telerik.WinControls.UI.RadSpinEditor rseCompanyShare;
        private Telerik.WinControls.UI.RadSpinEditor rseTotal;

        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadButton btnCancel;
        #endregion

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.lblVisitNo = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.lblPatientName = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.lblVisitDate = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.lblVisitType = new Telerik.WinControls.UI.RadLabel();
            this.lblFranchisePercentage = new Telerik.WinControls.UI.RadLabel();

            this.rdlServices = new Telerik.WinControls.UI.RadDropDownList();
            this.rseQuantity = new Telerik.WinControls.UI.RadSpinEditor();
            this.rseFranchiseAmount = new Telerik.WinControls.UI.RadSpinEditor();
            this.rsePatientShare = new Telerik.WinControls.UI.RadSpinEditor();
            this.rseCompanyShare = new Telerik.WinControls.UI.RadSpinEditor();
            this.rseTotal = new Telerik.WinControls.UI.RadSpinEditor();

            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();

            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblVisitNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPatientName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblVisitDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblVisitType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFranchisePercentage)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.rdlServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rseQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rseFranchiseAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsePatientShare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rseCompanyShare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rseTotal)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();

            this.SuspendLayout();

            // 
            // radLabel1 - Visit No label
            // 
            this.radLabel1.Location = new System.Drawing.Point(20, 18);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(70, 18);
            this.radLabel1.Text = "شماره ویزیت:";
            // 
            // lblVisitNo
            // 
            this.lblVisitNo.Location = new System.Drawing.Point(110, 18);
            this.lblVisitNo.Name = "lblVisitNo";
            this.lblVisitNo.Size = new System.Drawing.Size(50, 18);
            this.lblVisitNo.Text = "";
            // 
            // radLabel2 - Patient Name
            // 
            this.radLabel2.Location = new System.Drawing.Point(20, 46);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(75, 18);
            this.radLabel2.Text = "نام بیمار:";
            // 
            // lblPatientName
            // 
            this.lblPatientName.Location = new System.Drawing.Point(110, 46);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(200, 18);
            this.lblPatientName.Text = "";
            // 
            // radLabel3 - Visit Date
            // 
            this.radLabel3.Location = new System.Drawing.Point(350, 18);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(70, 18);
            this.radLabel3.Text = "تاریخ ویزیت:";
            // 
            // lblVisitDate
            // 
            this.lblVisitDate.Location = new System.Drawing.Point(440, 18);
            this.lblVisitDate.Name = "lblVisitDate";
            this.lblVisitDate.Size = new System.Drawing.Size(90, 18);
            this.lblVisitDate.Text = "";
            // 
            // radLabel4 - Visit Type
            // 
            this.radLabel4.Location = new System.Drawing.Point(350, 46);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(70, 18);
            this.radLabel4.Text = "نوع ویزیت:";
            // 
            // lblVisitType
            // 
            this.lblVisitType.Location = new System.Drawing.Point(440, 46);
            this.lblVisitType.Name = "lblVisitType";
            this.lblVisitType.Size = new System.Drawing.Size(100, 18);
            this.lblVisitType.Text = "";
            // 
            // lblFranchisePercentage
            // 
            this.lblFranchisePercentage.Location = new System.Drawing.Point(580, 32);
            this.lblFranchisePercentage.Name = "lblFranchisePercentage";
            this.lblFranchisePercentage.Size = new System.Drawing.Size(100, 18);
            this.lblFranchisePercentage.Text = "0 %";

            // 
            // rdlServices
            // 
            this.rdlServices.Location = new System.Drawing.Point(20, 90);
            this.rdlServices.Name = "rdlServices";
            this.rdlServices.Size = new System.Drawing.Size(400, 24);
            this.rdlServices.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.rdlServices.NullText = "انتخاب سرویس...";
            // 
            // rseQuantity
            // 
            this.rseQuantity.Location = new System.Drawing.Point(440, 90);
            this.rseQuantity.Name = "rseQuantity";
            this.rseQuantity.Size = new System.Drawing.Size(80, 24);
            this.rseQuantity.Minimum = 1;
            this.rseQuantity.DecimalPlaces = 0;
            this.rseQuantity.Value = 1;
            // 
            // rseFranchiseAmount
            // 
            this.rseFranchiseAmount.Location = new System.Drawing.Point(540, 90);
            this.rseFranchiseAmount.Name = "rseFranchiseAmount";
            this.rseFranchiseAmount.Size = new System.Drawing.Size(120, 24);
            this.rseFranchiseAmount.DecimalPlaces = 2;
            this.rseFranchiseAmount.Maximum = 100000000;
            this.rseFranchiseAmount.Minimum = 0;
            // 
            // rsePatientShare
            // 
            this.rsePatientShare.Location = new System.Drawing.Point(20, 140);
            this.rsePatientShare.Name = "rsePatientShare";
            this.rsePatientShare.Size = new System.Drawing.Size(150, 24);
            this.rsePatientShare.DecimalPlaces = 2;
            this.rsePatientShare.ReadOnly = false; // قابل ویرایش اختیاری؛ اگر می‌خواهید قفل شود true قرار دهید
            // 
            // rseCompanyShare
            // 
            this.rseCompanyShare.Location = new System.Drawing.Point(200, 140);
            this.rseCompanyShare.Name = "rseCompanyShare";
            this.rseCompanyShare.Size = new System.Drawing.Size(150, 24);
            this.rseCompanyShare.DecimalPlaces = 2;
            this.rseCompanyShare.ReadOnly = false;
            // 
            // rseTotal
            // 
            this.rseTotal.Location = new System.Drawing.Point(380, 140);
            this.rseTotal.Name = "rseTotal";
            this.rseTotal.Size = new System.Drawing.Size(150, 24);
            this.rseTotal.DecimalPlaces = 2;
            this.rseTotal.ReadOnly = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(540, 200);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.Text = "ذخیره";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(420, 200);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.Text = "انصراف";

            // 
            // PatientVisitDetailsFrm (Form)
            // 
            this.ClientSize = new System.Drawing.Size(670, 250);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.lblVisitNo);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.lblVisitDate);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.lblVisitType);
            this.Controls.Add(this.lblFranchisePercentage);

            this.Controls.Add(this.rdlServices);
            this.Controls.Add(this.rseQuantity);
            this.Controls.Add(this.rseFranchiseAmount);
            this.Controls.Add(this.rsePatientShare);
            this.Controls.Add(this.rseCompanyShare);
            this.Controls.Add(this.rseTotal);

            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AcceptButton = this.btnSave;
            this.CancelButton = this.btnCancel;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "جزئیات ویزیت - ثبت/ویرایش";

            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblVisitNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPatientName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblVisitDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblVisitType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFranchisePercentage)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.rdlServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rseQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rseFranchiseAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsePatientShare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rseCompanyShare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rseTotal)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
