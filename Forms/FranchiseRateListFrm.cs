using NIOPDCXmlGenerator.Data;
using NIOPDCXmlGenerator.Models;
using NIOPDCXmlGenerator.Services;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Localization;

namespace NIOPDCXmlGenerator.Forms
{


    public partial class FranchiseRateListFrm : RadForm
    {
        private readonly FranchiseService _franchiseService = new FranchiseService();
        private readonly ServiceTariffService _serviceTariffService = new ServiceTariffService();

        public FranchiseRateListFrm()
        {
            InitializeComponent();
        }

        private void FranchiseRateListFrm_Load(object sender, EventArgs e)
        {


            radGridView1.HandleCreated += (s, args) =>
            {
                // در برخی نسخه‌ها مسیر صحیح اینه:
                var panel = radGridView1.GridViewElement?.GroupPanelElement;
                if (panel != null)
                {
                    panel.Text = "برای گروه‌بندی، عنوان یک ستون را به اینجا بکشید";
                }
                else
                {
                    // fallback: با تاخیر خیلی کم
                    BeginInvoke(new Action(() =>
                    {
                        var p2 = radGridView1.GridViewElement?.GroupPanelElement;
                        if (p2 != null)
                            p2.Text = "برای گروه‌بندی، عنوان یک ستون را به اینجا بکشید";
                    }));
                }
            };

            RefreshGrid();
        }

        private void RefreshGrid()
        {
            var data = _franchiseService.GetAll();
            var rows = data.Select(r => new
            {
                r.RateId,
                From = PersianDateHelper.ToShamsi(r.FromDate),
                To = PersianDateHelper.ToShamsi(r.ToDate),
                RetiredPercentage = r.RetiredPercentage,
                EmployeePercentage = r.EmployeePercentage,
                CreatedAt = PersianDateHelper.ToShamsi(r.CreatedAt),
                UpdatedAt = r.UpdatedAt is null ? string.Empty : PersianDateHelper.ToShamsi(r.UpdatedAt ?? new DateTime(622, 3, 22))
            }).ToList();

            radGridView1.DataSource = rows;

            // مخفی کردن شناسه
            if (radGridView1.Columns["RateId"] != null) radGridView1.Columns["RateId"].IsVisible = false;

            // تغییر متن هِدر ستون‌ها به فارسی
            if (radGridView1.Columns["From"] != null) radGridView1.Columns["From"].HeaderText = "از تاریخ";
            if (radGridView1.Columns["To"] != null) radGridView1.Columns["To"].HeaderText = "تا تاریخ";
            if (radGridView1.Columns["RetiredPercentage"] != null) radGridView1.Columns["RetiredPercentage"].HeaderText = "درصد بازنشسته";
            if (radGridView1.Columns["EmployeePercentage"] != null) radGridView1.Columns["EmployeePercentage"].HeaderText = "درصد کارمند";
            if (radGridView1.Columns["CreatedAt"] != null) radGridView1.Columns["CreatedAt"].HeaderText = "تاریخ ثبت";
            if (radGridView1.Columns["UpdatedAt"] != null) radGridView1.Columns["UpdatedAt"].HeaderText = "تاریخ ویرایش";

            // تنظیمات اختیاری: قالب نمایش درصد و عرض ستون‌ها
            if (radGridView1.Columns["RetiredPercentage"] != null)
            {
                radGridView1.Columns["RetiredPercentage"].FormatString = "{0:N2}";
                radGridView1.Columns["RetiredPercentage"].Width = 120;
                radGridView1.Columns["RetiredPercentage"].TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            }
            if (radGridView1.Columns["EmployeePercentage"] != null)
            {
                radGridView1.Columns["EmployeePercentage"].FormatString = "{0:N2}";
                radGridView1.Columns["EmployeePercentage"].Width = 120;
                radGridView1.Columns["EmployeePercentage"].TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var frm = new FranchiseRateEditFrm();
            if (frm.ShowDialog(this) == DialogResult.OK) RefreshGrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (radGridView1.CurrentRow == null) return;
            int id = (int)radGridView1.CurrentRow.Cells["RateId"].Value;
            using var frm = new FranchiseRateEditFrm(id);
            if (frm.ShowDialog(this) == DialogResult.OK) RefreshGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (radGridView1.CurrentRow == null) return;
            int id = (int)radGridView1.CurrentRow.Cells["RateId"].Value;
            if (_serviceTariffService.Exists(id))
            {
                RadMessageBox.Show(this, "برای این دوره تعرفه خدمات تعریف شده است. ابتدا باید آنها را حذف نمایید", "خطا", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;
            }
            var res = RadMessageBox.Show(this, "آیا مطمئن هستید حذف شود؟", "حذف", MessageBoxButtons.YesNo, RadMessageIcon.Question);
            if (res == DialogResult.Yes)
            {
                _franchiseService.Delete(id);
                RefreshGrid();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e) => RefreshGrid();

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void btnTarrifReg_Click(object sender, EventArgs e)
        {



            if (radGridView1.CurrentRow == null)
            {
                RadMessageBox.Show("لطفاً یک دوره فرانشیز را انتخاب کنید.");
                return;
            }
            int rateId = 0;
            var rowValue = radGridView1.CurrentRow.Cells["RateId"].Value;
            if (rowValue != null)
            {
                rateId = Convert.ToInt32(rowValue);
                // سایر فیلدها رو هم می‌تونی همین‌طور بخونی
            }
            // بررسی وجود تعرفه برای این دوره
            var existingTariffs = new ServiceTariffService().GetByRateId(rateId);
            if (existingTariffs == null || !existingTariffs.Any())
            {
                var result = RadMessageBox.Show(
                    "هیچ تعرفه‌ای برای این دوره ثبت نشده است.\nآیا مایل هستید تمامی خدمات برای شما ایجاد شود تا شما مبالغ تعرفه را تنظیم نمایید؟",
                    "ثبت تعرفه‌ها", MessageBoxButtons.YesNo, RadMessageIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var activeServices = new ServiceService().GetActiveServices(); // فقط سرویس‌های فعال
                    foreach (var service in activeServices)
                    {
                        var tariff = new ServiceTariff
                        {
                            FranchiseRateID = rateId,
                            ServiceId = service.ServiceId,
                            Amount = -1
                        };
                        new ServiceTariffService().Insert(tariff);
                    }
                }
            }

            // باز کردن فرم لیست تعرفه‌ها برای این دوره
            var frm = new ServiceTariffListFrm(rateId);
            frm.ShowDialog();
        }
    }
}
