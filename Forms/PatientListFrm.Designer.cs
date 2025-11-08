using System.ComponentModel;
using Telerik.WinControls.UI;

namespace NIOPDCXmlGenerator.Forms
{
    partial class PatientListFrm
    {
        private IContainer components = null;
        private RadGridView gvPatientList;
        private RadButton btnAdd;
        private RadButton btnEdit;
        private RadButton btnDelete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.gvPatientList = new Telerik.WinControls.UI.RadGridView();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.btnEdit = new Telerik.WinControls.UI.RadButton();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatientList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatientList.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gvPatientList
            // 
            this.gvPatientList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvPatientList.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.gvPatientList.Location = new System.Drawing.Point(12, 12);
            // 
            // 
            // 
            this.gvPatientList.MasterTemplate.AllowAddNewRow = false;
            this.gvPatientList.MasterTemplate.AllowDeleteRow = false;
            this.gvPatientList.MasterTemplate.AllowEditRow = false;
            this.gvPatientList.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.FieldName = "PersonnelCode";
            gridViewTextBoxColumn1.HeaderText = "کد پرسنلی";
            gridViewTextBoxColumn1.Name = "PersonnelCode";
            gridViewTextBoxColumn1.Width = 130;
            gridViewTextBoxColumn2.FieldName = "FirstName";
            gridViewTextBoxColumn2.HeaderText = "نام";
            gridViewTextBoxColumn2.Name = "FirstName";
            gridViewTextBoxColumn2.Width = 130;
            gridViewTextBoxColumn3.FieldName = "LastName";
            gridViewTextBoxColumn3.HeaderText = "نام خانوادگی";
            gridViewTextBoxColumn3.Name = "LastName";
            gridViewTextBoxColumn3.Width = 130;
            gridViewTextBoxColumn4.FieldName = "Gender";
            gridViewTextBoxColumn4.HeaderText = "جنسیت";
            gridViewTextBoxColumn4.Name = "Gender";
            gridViewTextBoxColumn5.FieldName = "NationalCode";
            gridViewTextBoxColumn5.HeaderText = "کدملی";
            gridViewTextBoxColumn5.Name = "NationalCode";
            gridViewTextBoxColumn5.Width = 130;
            gridViewTextBoxColumn6.FieldName = "Mobile";
            gridViewTextBoxColumn6.HeaderText = "موبایل";
            gridViewTextBoxColumn6.Name = "Mobile";
            gridViewTextBoxColumn6.Width = 130;
            gridViewTextBoxColumn7.FieldName = "IsRetired";
            gridViewTextBoxColumn7.HeaderText = "وضعیت";
            gridViewTextBoxColumn7.Name = "IsRetired";
            gridViewTextBoxColumn7.Width = 130;
            gridViewTextBoxColumn8.FieldName = "PatientId";
            gridViewTextBoxColumn8.HeaderText = "PatientId";
            gridViewTextBoxColumn8.IsVisible = false;
            gridViewTextBoxColumn8.Name = "PatientId";
            gridViewTextBoxColumn8.ReadOnly = true;
            gridViewTextBoxColumn8.VisibleInColumnChooser = false;
            this.gvPatientList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8});
            this.gvPatientList.MasterTemplate.EnableFiltering = true;
            this.gvPatientList.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gvPatientList.Name = "gvPatientList";
            this.gvPatientList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gvPatientList.Size = new System.Drawing.Size(907, 417);
            this.gvPatientList.TabIndex = 0;
            this.gvPatientList.ThemeName = "ControlDefault";
            this.gvPatientList.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.gvPatientList_CellFormatting);
            this.gvPatientList.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.gvPatientList_CellDoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnAdd.Location = new System.Drawing.Point(819, 441);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "افزودن";
            this.btnAdd.ThemeName = "ControlDefault";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnEdit.Location = new System.Drawing.Point(713, 441);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 30);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.ThemeName = "ControlDefault";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnDelete.Location = new System.Drawing.Point(607, 441);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "حذف";
            this.btnDelete.ThemeName = "ControlDefault";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // PatientListFrm
            // 
            this.ClientSize = new System.Drawing.Size(931, 483);
            this.Controls.Add(this.gvPatientList);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Name = "PatientListFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "لیست بیماران";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this.gvPatientList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatientList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
