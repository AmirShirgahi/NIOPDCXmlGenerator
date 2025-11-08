using NIOPDCXmlGenerator.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace NIOPDCXmlGenerator.Forms
{
    public partial class PatientListFrm : Telerik.WinControls.UI.RadForm
    {
        private readonly PatientService _service = new PatientService();

        public PatientListFrm()
        {
            InitializeComponent();
            LoadPatients();
        }

        private void LoadPatients()
        {
            var list = _service.GetAll().ToList();
            gvPatientList.BeginInit();
            gvPatientList.DataSource = list;
            gvPatientList.MasterTemplate.AutoGenerateColumns = true;
            gvPatientList.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            // Enable column filtering UI (built-in)
            gvPatientList.EnableFiltering = true;
            foreach (var col in gvPatientList.Columns)
            {
                col.AllowFiltering = true;
                //col.filter = true;
            }

            // Hide internal identity column if desired
            if (gvPatientList.Columns.Any(c => c.Name == "PatientId"))
            {
                gvPatientList.Columns["PatientId"].IsVisible = true;
            }

            gvPatientList.EndInit();
        }

        private int? GetSelectedId()
        {
            if (gvPatientList.CurrentRow == null) return null;
            var val = gvPatientList.CurrentRow.Cells["PatientId"].Value;
            if (val == null) return null;
            return Convert.ToInt32(val);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var frm = new InsertPatientFrm(null);
            if (frm.ShowDialog() == DialogResult.OK) LoadPatients();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId();
            if (!id.HasValue) return;
            var patient = _service.GetById(id.Value);
            if (patient == null) return;
            using var frm = new InsertPatientFrm(patient, false);
            if (frm.ShowDialog() == DialogResult.OK) LoadPatients();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId();
            if (!id.HasValue) return;
            var res = Telerik.WinControls.RadMessageBox.Show(this, "آیا مایل به حذف رکورد هستید؟", "تأیید حذف", MessageBoxButtons.YesNo, Telerik.WinControls.RadMessageIcon.Question);
            if (res == DialogResult.Yes)
            {
                _service.Delete(id.Value);
                LoadPatients();
            }
        }

        private void gvPatientList_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.Column.Name == "IsRetired")
            {
                if (e.Row.Cells["IsRetired"].Value is bool isRetired)
                {
                    e.CellElement.Text = isRetired ? "بازنشسته" : "کارمند";
                }
            }
            if (e.Column.Name == "Gender")
            {
                if (e.Row.Cells["Gender"].Value.ToString() == "1")
                {
                    e.CellElement.Text = "مرد";
                }
                else if (e.Row.Cells["Gender"].Value.ToString() == "0")
                {
                    e.CellElement.Text = "زن";
                }
                 
                else
                {
                    e.CellElement.Text = "مقدار نامعتبر";
                }
            }

        }

        private void gvPatientList_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            var id = GetSelectedId();
            if (!id.HasValue) return;
            var patient = _service.GetById(id.Value);
            if (patient == null) return;
            using var frm = new InsertPatientFrm(patient, false);
            if (frm.ShowDialog() == DialogResult.OK) LoadPatients();
        }
    }
}
