using System;
using System.Windows.Forms;
using NIOPDCXmlGenerator.Data;
using NIOPDCXmlGenerator.Models;
using NIOPDCXmlGenerator.Services;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace NIOPDCXmlGenerator.Forms
{
    public partial class FranchiseRateEditFrm : RadForm
    {
        private readonly FranchiseService _franchiseService = new FranchiseService();
        private readonly int? _editingId;

        public FranchiseRateEditFrm(int? editingId = null)
        {
            InitializeComponent();
            _editingId = editingId;
        }

        private void FranchiseRateEditFrm_Load(object sender, EventArgs e)
        {
            if (_editingId.HasValue)
            {
                var r = _franchiseService.GetById(_editingId.Value);
                if (r != null)
                {
                    txtFrom.Text = PersianDateHelper.ToShamsi(r.FromDate);
                    txtTo.Text = PersianDateHelper.ToShamsi(r.ToDate);
                    txtRetiredPercent.Text = r.RetiredPercentage.ToString();
                    txtEmployeePercent.Text = r.EmployeePercentage.ToString();
                }
            }
            else
            {
                txtRetiredPercent.Text = "0";
                txtEmployeePercent.Text = "0";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(PersianDateHelper.ParseShamsiToGregorian(DateTime.Now.ToString("yyyy/mm/dd")).ToString());
            try
            {
                var from = PersianDateHelper.ParseShamsiToGregorian(txtFrom.Text.Trim());
                var to = PersianDateHelper.ParseShamsiToGregorian(txtTo.Text.Trim());
                if (from > to) { RadMessageBox.Show(this, "تاریخ شروع باید قبل یا برابر تاریخ پایان باشد.", "خطا", MessageBoxButtons.OK, RadMessageIcon.Error); return; }

                if (!decimal.TryParse(txtRetiredPercent.Text.Trim(), out var rperc) || rperc < 0 || rperc > 100)
                { RadMessageBox.Show(this, "درصد بازنشسته باید عددی بین 0 تا 100 باشد.", "خطا", MessageBoxButtons.OK, RadMessageIcon.Error); return; }

                if (!decimal.TryParse(txtEmployeePercent.Text.Trim(), out var eperc) || eperc < 0 || eperc > 100)
                { RadMessageBox.Show(this, "درصد کارمند باید عددی بین 0 تا 100 باشد.", "خطا", MessageBoxButtons.OK, RadMessageIcon.Error); return; }

                // چک همپوشانی بازه (بدون تفکیک نوع)
                if (_franchiseService.HasOverlap(from, to, _editingId))
                {
                    RadMessageBox.Show(this, "این بازه زمانی با یک رکورد دیگر همپوشانی دارد.", "خطا", MessageBoxButtons.OK, RadMessageIcon.Error);
                    return;
                }

                var rate = new FranchiseRate
                {
                    RetiredPercentage = rperc,
                    EmployeePercentage = eperc,
                    FromDate = from,
                    ToDate = to,
                    CreatedAt = DateTime.Now,
                };

                if (_editingId.HasValue) { rate.RateId = _editingId.Value; _franchiseService.Update(rate); }
                else _franchiseService.Insert(rate);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (FormatException) { RadMessageBox.Show(this, "فرمت تاریخ صحیح نیست. الگو: yyyy/MM/dd", "خطا", MessageBoxButtons.OK, RadMessageIcon.Error); }
            catch (Exception ex) { RadMessageBox.Show(this, "خطا: " + ex.Message, "خطا", MessageBoxButtons.OK, RadMessageIcon.Error); }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
