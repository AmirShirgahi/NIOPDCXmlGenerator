using NIOPDCXmlGenerator.Forms;
using NIOPDCXmlGenerator.Models;
using NIOPDCXmlGenerator.Services;
using System;
using System.Linq;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace NIOPDCXmlGenerator
{
    public partial class DoctorListFrm : RadForm
    {
        public DoctorListFrm()
        {
            InitializeComponent();
            this.Font = new System.Drawing.Font("B Nazanin", 11);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;

            SetupGrid();
            LoadData();
        }

        private void SetupGrid()
        {
            radGridView1.AutoGenerateColumns = false;
            radGridView1.AllowAddNewRow = false;
            radGridView1.AllowDeleteRow = false;
            radGridView1.AllowEditRow = false;
            radGridView1.ReadOnly = true;
            radGridView1.SelectionMode = GridViewSelectionMode.FullRowSelect;
            radGridView1.Font = this.Font;
            radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;

            radGridView1.Columns.Clear();
            radGridView1.Columns.Add(new GridViewTextBoxColumn("NPCode") { HeaderText = "کد نظام پزشکی", Width = 100 });
            radGridView1.Columns.Add(new GridViewTextBoxColumn("FullName") { HeaderText = "نام کامل", Width = 150 });
            radGridView1.Columns.Add(new GridViewTextBoxColumn("NationalCode") { HeaderText = "کد ملی", Width = 100 });
            radGridView1.Columns.Add(new GridViewTextBoxColumn("Mobile") { HeaderText = "شماره موبایل", Width = 120 });
            radGridView1.Columns.Add(new GridViewTextBoxColumn("GenderText") { HeaderText = "جنسیت", Width = 80 });
            radGridView1.Columns.Add(new GridViewTextBoxColumn("Specialty") { HeaderText = "تخصص", Width = 80 });
            radGridView1.Columns.Add(new GridViewCheckBoxColumn("IsActive") { HeaderText = "فعال؟", Width = 60 });
        }

        private void LoadData()
        {
            var list = new DoctorService().GetAll().ToList();
            radGridView1.DataSource = list;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new DoctorInsertFrm()
            {
                RightToLeft = System.Windows.Forms.RightToLeft.No,
                RightToLeftLayout = false
            }; 
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (radGridView1.CurrentRow == null) return;

            var doctor = radGridView1.CurrentRow.DataBoundItem as Doctor;
            var frm = new DoctorInsertFrm(doctor)
            {
                RightToLeft = System.Windows.Forms.RightToLeft.No,
                RightToLeftLayout = false
            };
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (radGridView1.CurrentRow == null) return;

            var doctor = radGridView1.CurrentRow.DataBoundItem as Doctor;
            var result = RadMessageBox.Show($"آیا از حذف پزشک {doctor.FullName} مطمئن هستید؟",
                                            "تأیید حذف",
                                            System.Windows.Forms.MessageBoxButtons.YesNo,
                                            RadMessageIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                new DoctorService().Delete(doctor.NPCode);
                LoadData();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}