using Telerik.WinControls.UI;

namespace NIOPDCXmlGenerator.Forms
{
    partial class PatientVisitListFrm
    {
        private System.ComponentModel.IContainer components = null;
        private RadPanel panelTop;
        private RadGridView radGridView1;
        private RadTextBox txtPersonnelSearch;
        private RadTextBox txtNameSearch;
        private RadTextBox txtFrom;
        private RadTextBox txtTo;
        private RadButton btnSearch;
        private RadButton btnAdd;
        private RadButton btnEdit;
        private RadButton btnDelete;
        private RadButton btnRefresh;
        private RadButton btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.panelTop = new Telerik.WinControls.UI.RadPanel();
            this.txtPersonnelSearch = new Telerik.WinControls.UI.RadTextBox();
            this.txtNameSearch = new Telerik.WinControls.UI.RadTextBox();
            this.txtFrom = new Telerik.WinControls.UI.RadTextBox();
            this.txtTo = new Telerik.WinControls.UI.RadTextBox();
            this.btnSearch = new Telerik.WinControls.UI.RadButton();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.btnEdit = new Telerik.WinControls.UI.RadButton();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.btnRefresh = new Telerik.WinControls.UI.RadButton();
            this.btnClose = new Telerik.WinControls.UI.RadButton();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelTop)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonnelSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.txtPersonnelSearch);
            this.panelTop.Controls.Add(this.txtNameSearch);
            this.panelTop.Controls.Add(this.txtFrom);
            this.panelTop.Controls.Add(this.txtTo);
            this.panelTop.Controls.Add(this.btnSearch);
            this.panelTop.Controls.Add(this.btnAdd);
            this.panelTop.Controls.Add(this.btnEdit);
            this.panelTop.Controls.Add(this.btnDelete);
            this.panelTop.Controls.Add(this.btnRefresh);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(6);
            this.panelTop.Size = new System.Drawing.Size(968, 72);
            this.panelTop.TabIndex = 1;
            this.panelTop.ThemeName = "ControlDefault";
            // 
            // txtPersonnelSearch
            // 
            this.txtPersonnelSearch.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtPersonnelSearch.Location = new System.Drawing.Point(10, 12);
            this.txtPersonnelSearch.Name = "txtPersonnelSearch";
            this.txtPersonnelSearch.Size = new System.Drawing.Size(140, 19);
            this.txtPersonnelSearch.TabIndex = 0;
            this.txtPersonnelSearch.Text = "کد پرسنلی";
            this.txtPersonnelSearch.ThemeName = "ControlDefault";
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtNameSearch.Location = new System.Drawing.Point(160, 12);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(200, 19);
            this.txtNameSearch.TabIndex = 1;
            this.txtNameSearch.Text = "نام بیمار";
            this.txtNameSearch.ThemeName = "ControlDefault";
            // 
            // txtFrom
            // 
            this.txtFrom.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtFrom.Location = new System.Drawing.Point(370, 12);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(110, 19);
            this.txtFrom.TabIndex = 2;
            this.txtFrom.Text = "از (yyyy/MM/dd)";
            this.txtFrom.ThemeName = "ControlDefault";
            // 
            // txtTo
            // 
            this.txtTo.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtTo.Location = new System.Drawing.Point(490, 12);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(110, 19);
            this.txtTo.TabIndex = 3;
            this.txtTo.Text = "تا (yyyy/MM/dd)";
            this.txtTo.ThemeName = "ControlDefault";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnSearch.Location = new System.Drawing.Point(610, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 24);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.ThemeName = "ControlDefault";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnAdd.Location = new System.Drawing.Point(698, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 24);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "افزودن";
            this.btnAdd.ThemeName = "ControlDefault";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnEdit.Location = new System.Drawing.Point(786, 10);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(72, 24);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.ThemeName = "ControlDefault";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnDelete.Location = new System.Drawing.Point(874, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 24);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "حذف";
            this.btnDelete.ThemeName = "ControlDefault";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnRefresh.Location = new System.Drawing.Point(874, 40);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(72, 24);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "بروزرسانی";
            this.btnRefresh.ThemeName = "ControlDefault";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnClose.Location = new System.Drawing.Point(786, 40);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 24);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "بستن";
            this.btnClose.ThemeName = "ControlDefault";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radGridView1.Location = new System.Drawing.Point(0, 72);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowDeleteRow = false;
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(968, 518);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.ThemeName = "ControlDefault";
            // 
            // PatientVisitListFrm
            // 
            this.ClientSize = new System.Drawing.Size(968, 590);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientVisitListFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "لیست ویزیت‌ها";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.PatientVisitListFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelTop)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonnelSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
