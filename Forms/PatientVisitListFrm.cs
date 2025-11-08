using System;
using System.Linq;
using System.Windows.Forms;
using NIOPDCXmlGenerator.Data;
using NIOPDCXmlGenerator.Services;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace NIOPDCXmlGenerator.Forms
{
    public partial class PatientVisitListFrm : RadForm
    {
        private readonly VisitService _visitService = new VisitService();
        private readonly PatientService _patientService = new PatientService();

        public PatientVisitListFrm()
        {
            InitializeComponent();
        }

        private void PatientVisitListFrm_Load(object sender, EventArgs e)
        {
            txtFrom.Text = PersianDateHelper.ToShamsi(DateTime.Now.AddMonths(-1));
            txtTo.Text = PersianDateHelper.ToShamsi(DateTime.Now);
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            // ساده‌سازی: Get all visits then filter client-side (برای دیتاست‌های بزرگ بهتر هست سرویس با پارامتر جستجو باشد)
            var all = _visitService.GetAllVisits(); // باید در VisitService متد GetAllVisits پیاده شود (پایین نمونه کد آورده شده)
            var q = all.AsQueryable();

            if (!string.IsNullOrWhiteSpace(txtPersonnelSearch.Text))
            {
                var pers = txtPersonnelSearch.Text.Trim();
                q = q.Where(v => v.PersonnelCode != null && v.PersonnelCode.Contains(pers));
            }

            if (!string.IsNullOrWhiteSpace(txtNameSearch.Text))
            {
                var name = txtNameSearch.Text.Trim();
                q = q.Where(v => v.PatientName != null && v.PatientName.Contains(name));
            }

            if (DateTime.TryParseExact(PersianDateHelper.ParseShamsiToGregorian(txtFrom.Text).ToString("yyyy-MM-dd"), "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out var from))
            {
                // already parsed in ParseShamsi; simpler just:
            }
            try
            {
                var fromDt = PersianDateHelper.ParseShamsiToGregorian(txtFrom.Text.Trim());
                var toDt = PersianDateHelper.ParseShamsiToGregorian(txtTo.Text.Trim());
                q = q.Where(v => v.VisitDate.Date >= fromDt.Date && v.VisitDate.Date <= toDt.Date);
            }
            catch { /* ignore date filter if parse fails */ }

            var rows = q.Select(v => new
            {
                v.VisitId,
                PersonnelCode = v.PersonnelCode,
                PatientName = v.PatientName,
                VisitDate = PersianDateHelper.ToShamsi(v.VisitDate),
                v.TotalQuantity,
                TotalPatientShare = v.TotalPatientShare,
                TotalCompanyShare = v.TotalCompanyShare,
                TotalAmount = v.TotalAmount
            }).ToList();

            radGridView1.DataSource = rows;
            if (radGridView1.Columns["VisitId"] != null) radGridView1.Columns["VisitId"].IsVisible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e) => RefreshGrid();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var frm = new PatientVisitFrm();
            if (frm.ShowDialog(this) == DialogResult.OK) RefreshGrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (radGridView1.CurrentRow == null) return;
            int visitId = (int)radGridView1.CurrentRow.Cells["VisitId"].Value;
            using var frm = new PatientVisitFrm(visitId);
            if (frm.ShowDialog(this) == DialogResult.OK) RefreshGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (radGridView1.CurrentRow == null) return;
            int visitId = (int)radGridView1.CurrentRow.Cells["VisitId"].Value;
            var res = RadMessageBox.Show(this, "آیا از حذف ویزیت مطمئنی؟", "حذف", MessageBoxButtons.YesNo, RadMessageIcon.Question);
            if (res == DialogResult.Yes)
            {
                _visitService.DeleteVisit(visitId);
                RefreshGrid();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e) => RefreshGrid();
        private void btnClose_Click(object sender, EventArgs e) => Close();
    }
}
