using Dapper;
using NIOPDCXmlGenerator.Data;
using NIOPDCXmlGenerator.Models;
using NIOPDCXmlGenerator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;
using YourNamespace.Forms;

namespace NIOPDCXmlGenerator.Forms
{
    public partial class PatientVisitFrm : RadForm
    {
        private readonly DoctorService _doctorService = new DoctorService();
        private readonly ServiceService _serviceService = new ServiceService();
        private readonly FranchiseService _franchiseService = new FranchiseService();
        private readonly VisitService _visitService = new VisitService();
        private readonly PatientService _patientService = new PatientService();

        // pending display rows
        private List<VisitDetail> _pendingDisplay = new List<VisitDetail>();
        // pending DTOs for DB insert
        private List<VisitService.AddDetailRequest> _pendingDetails = new List<VisitService.AddDetailRequest>();

        private Patient _currentPatient;
        private int? _editingVisitId;

        public PatientVisitFrm(int? editingVisitId = null)
        {
            InitializeComponent();
            _editingVisitId = editingVisitId;
        }

        private void PatientVisitFrm_Load(object sender, EventArgs e)
        {
            txtVisitDate.Text = PersianDateHelper.ToShamsi(DateTime.Now);
            ddDoctor.DataSource = _doctorService.GetAll(false);
            ddDoctor.DisplayMember = "FullNameWithSpecialty";
            ddDoctor.ValueMember = "NPCode";
            ddDoctor.Enabled = true;

            if (_editingVisitId.HasValue)
            {
                LoadVisitForEdit(_editingVisitId.Value);
            }
            else
            {
                txtVisitNo.Value = _visitService.GetNextVisitNo();
            }
        }

        private void LoadVisitForEdit(int visitId)
        {
            // دریافت سرفصل و جزئیات از سرویس
            var tuple = _visitService.GetVisitWithDetails(visitId);
            var visit = tuple.visit;
            var details = tuple.details?.ToList() ?? new List<VisitDetail>();

            if (visit == null)
            {
                RadMessageBox.Show(this, "ویزیت مورد نظر پیدا نشد.", "خطا", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;
            }

            // بارگذاری بیمار
            var patient = _patientService.GetById(visit.PatientId);
            if (patient != null)
            {
                _currentPatient = patient;
                FillPatientInfoToControls(patient);
            }
            else
            {
                // اگر بیمار پیدا نشد، فقط PatientId را نگهدار
                _currentPatient = null;
                txtFirstName.Text = string.Empty;
                txtLastName.Text = string.Empty;
                txtNationalCode.Text = string.Empty;
                txtMobile.Text = string.Empty;
                ddlStatus.SelectedValue = 0;
            }

            // پر کردن فیلدهای ویزیت
            txtVisitDate.Text = PersianDateHelper.ToShamsi(visit.VisitDate);
            txtBookletExpiry.Text = visit.BookletExpiryDate.HasValue ? PersianDateHelper.ToShamsi(visit.BookletExpiryDate.Value) : string.Empty;
            txtPageNo.Text = visit.PrescriptionPageNo ?? string.Empty;

            // مقداردهی لیست نمایش و لیست درج
            _pendingDisplay.Clear();
            _pendingDetails.Clear();

            foreach (var d in details)
            {
                // ساخت شیء VisitDetail برای نمایش (توجه: VisitDetail مدل پروژه شماست)
                var display = new VisitDetail
                {
                    VisitDetailId = d.VisitDetailId,
                    VisitId = d.VisitId,
                    ServiceId = d.ServiceId,
                    TariffId = d.TariffId,
                    Quantity = d.Quantity,
                    UnitAmount = d.UnitAmount,
                    PatientShare = d.PatientShare,
                    CompanyShare = d.CompanyShare,
                    TotalAmount = d.TotalAmount,
                    CreatedAt = d.CreatedAt
                };
                _pendingDisplay.Add(display);

                // ساخت DTO برای درج/بروزرسانی (تعداد و تاریخ ویزیت)
                _pendingDetails.Add(new VisitService.AddDetailRequest
                {
                    ServiceId = d.ServiceId,
                    Quantity = d.Quantity,
                    VisitDate = visit.VisitDate.Date
                });
            }

            // تنظیم مقدار editing id داخلی (در صورتی که لازم است)
            _editingVisitId = visitId;

            // ریفرش گرید و مقادیر جمعی
            RefreshServiceGrid();
        }



        private void btnFindPatient_Click(object sender, EventArgs e)
        {
            var pers = txtPersonnelCode.Text.Trim();
            if (string.IsNullOrWhiteSpace(pers)) { ShowError("کد پرسنلی وارد نشده."); return; }

            var existing = _patientService.GetBypersonnelCode(pers);
            if (existing != null)
            {
                _currentPatient = existing;
                FillPatientInfoToControls(existing);
            }
            else
            {
                // اگر وجود نداشت، فرم به کاربر اجازه می‌دهد ابتدا اطلاعات پایه را وارد کند.
                var res = RadMessageBox.Show(this, "کد پرسنلی یافت نشد. می‌خواهید بیمار جدید بسازید؟", "اطلاع", MessageBoxButtons.YesNo, RadMessageIcon.Question);
                if (res == DialogResult.Yes)
                {
                    // مقدارهای حداقلی را از فیلدهای نام/خانوادگی گرفته و در جدول Patients درج کن
                    var p = new Patient
                    {
                        PersonnelCode = pers,
                        FirstName = txtFirstName.Text.Trim(),
                        LastName = txtLastName.Text.Trim(),
                        NationalCode = string.IsNullOrWhiteSpace(txtNationalCode.Text) ? null : txtNationalCode.Text.Trim(),
                        Mobile = string.IsNullOrWhiteSpace(txtMobile.Text) ? null : txtMobile.Text.Trim(),
                        IsRetired = Convert.ToBoolean(ddlStatus.SelectedValue),
                    };
                    if (!ValidationHelper.ValidatePersonnelCode(p.PersonnelCode))
                    {
                        ShowError("کد پرسنلی صحیح نیست. الگو: 123456-00");
                        return;
                    }

                    var newId = _patientService.Insert(p);
                    p.PatientId = newId;
                    _currentPatient = p;
                    RadMessageBox.Show(this, "بیمار جدید ثبت شد.", "موفقیت", MessageBoxButtons.OK, RadMessageIcon.Info);
                    FillPatientInfoToControls(p);
                }
            }
        }

        private void FillPatientInfoToControls(Patient p)
        {
            txtFirstName.Text = p.FirstName;
            txtLastName.Text = p.LastName;
            txtNationalCode.Text = p.NationalCode;
            txtMobile.Text = p.Mobile;
            ddlStatus.SelectedValue = p.IsRetired ? 1 : 0;
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            //if (cmbServices.SelectedItem == null) { ShowError("خدمت را انتخاب کنید."); return; }
            //if (!int.TryParse(txtQuantity.Text.Trim(), out var qty) || qty <= 0) { ShowError("تعداد باید عدد صحیح و بزرگتر از صفر باشد."); return; }
            //if (_currentPatient == null) { ShowError("ابتدا بیمار را بارگذاری کنید."); return; }

            //DateTime visitDate;
            //try { visitDate = PersianDateHelper.ParseShamsiToGregorian(txtVisitDate.Text.Trim()); }
            //catch { ShowError("فرمت تاریخ ویزیت صحیح نیست."); return; }

            //int serviceId = (int)cmbServices.SelectedValue;
            //var unitAmount = _serviceService.GetTariffForDate(serviceId, visitDate);
            //if (!unitAmount.HasValue) { ShowError("برای این خدمت در این تاریخ تعرفه تعریف نشده."); return; }

            //var percent = _franchiseService.GetPercentageForDate(_currentPatient.IsRetired, visitDate);
            //if (!percent.HasValue) { ShowError("درصد فرانشیز برای این تاریخ و نوع بیمار تعریف نشده."); return; }

            //long total = unitAmount.Value * (long)qty;
            //long patientShare = (long)Math.Round(total * (percent.Value / 100m));
            //long companyShare = total - patientShare;

            //// اگر سطر همان سرویس قبلا اضافه شده بود، آن را جمع کن (یا تصمیم بگیر رکورد جدا ایجاد شود)
            //var existing = _pendingDisplay.FirstOrDefault(d => d.ServiceId == serviceId && d.UnitAmount == unitAmount.Value);
            //if (existing != null)
            //{
            //    existing.Quantity += qty;
            //    existing.TotalAmount += total;
            //    existing.PatientShare += patientShare;
            //    existing.CompanyShare += companyShare;

            //    var idx = _pendingDetails.FindIndex(x => x.ServiceId == serviceId && x.VisitDate.Date == visitDate.Date);
            //    if (idx >= 0) _pendingDetails[idx].Quantity += qty;
            //}
            //else
            //{
            //    var vd = new VisitDetail
            //    {
            //        ServiceId = serviceId,
            //        TariffId = null,
            //        Quantity = qty,
            //        UnitAmount = unitAmount.Value,
            //        TotalAmount = total,
            //        PatientShare = patientShare,
            //        CompanyShare = companyShare
            //    };
            //    _pendingDisplay.Add(vd);
            //    _pendingDetails.Add(new VisitService.AddDetailRequest { ServiceId = serviceId, Quantity = qty, VisitDate = visitDate });
            //}

            //RefreshServiceGrid();
        }

        private void RefreshServiceGrid()
        {
            var rows = _pendingDisplay.Select(d => new
            {
                d.ServiceId,
                ServiceTitle = _serviceService.GetServiceById(d.ServiceId)?.Title ?? d.ServiceId.ToString(),
                d.Quantity,
                UnitAmount = d.UnitAmount,
                d.TotalAmount,
                d.PatientShare,
                d.CompanyShare
            }).ToList();

            gridVisitDetails.DataSource = rows;
            if (gridVisitDetails.Columns["ServiceId"] != null) gridVisitDetails.Columns["ServiceId"].IsVisible = false;

            UpdateTotalsOnForm();
        }

        private void UpdateTotalsOnForm()
        {
            txtTotalQuantity.Text = _pendingDisplay.Sum(d => d.Quantity).ToString();
            txtTotalPatientShare.Text = _pendingDisplay.Sum(d => d.PatientShare).ToString();
            txtTotalCompanyShare.Text = _pendingDisplay.Sum(d => d.CompanyShare).ToString();
            txtTotalAmount.Text = _pendingDisplay.Sum(d => d.TotalAmount).ToString();
        }

        // handler برای ویرایش تعداد در grid: در این نمونه چون از AutoGenerateColumns استفاده شده،
        // ما کنترل ویرایشی سطرها را با باز کردن یک فرم کوچک یا با راهکار inline مدیریت می‌کنیم.
        // راه ساده: انتخاب سطر و استفاده از یک Inputbox برای تغییر تعداد.
        //--------------------------------------------------------------------------------------------------------------------------------------------
        private void btnEditQuantity_Click(object sender, EventArgs e)
        {
            //if (radGridViewServices.CurrentRow == null) return;
            //int serviceId = (int)radGridViewServices.CurrentRow.Cells["ServiceId"].Value;
            //var item = _pendingDisplay.FirstOrDefault(d => d.ServiceId == serviceId);
            //if (item == null) return;

            //using var frm = new EditQuantityFrm(item.Quantity);
            //if (frm.ShowDialog(this) == DialogResult.OK)
            //{
            //    int newQty = frm.NewQuantity;
            //    // recalc row
            //    DateTime visitDate;
            //    try { visitDate = PersianDateHelper.ParseShamsiToGregorian(txtVisitDate.Text.Trim()); }
            //    catch { ShowError("فرمت تاریخ ویزیت صحیح نیست."); return; }

            //    var unitAmount = item.UnitAmount;
            //    var percent = _franchiseService.GetPercentageForDate(_currentPatient.IsRetired, visitDate);
            //    if (!percent.HasValue) { ShowError("درصد فرانشیز برای این تاریخ و نوع بیمار تعریف نشده."); return; }

            //    long newTotal = unitAmount * (long)newQty;
            //    long newPatientShare = (long)Math.Round(newTotal * (percent.Value / 100m));
            //    long newCompanyShare = newTotal - newPatientShare;

            //    item.Quantity = newQty;
            //    item.TotalAmount = newTotal;
            //    item.PatientShare = newPatientShare;
            //    item.CompanyShare = newCompanyShare;

            //    // update pendingDetails matching ServiceId (first match)
            //    var pd = _pendingDetails.FirstOrDefault(d => d.ServiceId == serviceId);
            //    if (pd != null) pd.Quantity = newQty;

            //    RefreshServiceGrid();
            //}
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------
        private void btnRemoveService_Click(object sender, EventArgs e)
        {
            if (gridVisitDetails.CurrentRow == null) return;
            int serviceId = (int)gridVisitDetails.CurrentRow.Cells["ServiceId"].Value;
            var idx = _pendingDisplay.FindIndex(d => d.ServiceId == serviceId);
            if (idx >= 0) { _pendingDisplay.RemoveAt(idx); _pendingDetails.RemoveAt(idx); RefreshServiceGrid(); }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------
        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            if (_pendingDetails.Count == 0) { ShowError("هیچ خدمتی اضافه نشده."); return; }

            DateTime visitDate;
            try { visitDate = PersianDateHelper.ParseShamsiToGregorian(txtVisitDate.Text.Trim()); }
            catch { ShowError("فرمت تاریخ ویزیت صحیح نیست."); return; }

            DateTime? bookletExpiry = null;
            if (!string.IsNullOrWhiteSpace(txtBookletExpiry.Text)) bookletExpiry = PersianDateHelper.ParseShamsiToGregorian(txtBookletExpiry.Text.Trim());

            // اگر بیمار هنوز انتخاب نشده بود (مثلاً از طریق جستجو نیامده)، سعی کن با personnel code واکشی یا درج کنی
            if (_currentPatient == null)
            {
                var pers = txtPersonnelCode.Text.Trim();
                if (string.IsNullOrWhiteSpace(pers)) { ShowError("ابتدا بیمار را انتخاب یا کد پرسنلی را وارد کنید."); return; }

                var existing = _patientService.GetBypersonnelCode(pers);
                if (existing != null) { _currentPatient = existing; }
                else
                {
                    var p = new Patient
                    {
                        PersonnelCode = pers,
                        FirstName = txtFirstName.Text.Trim(),
                        LastName = txtLastName.Text.Trim(),
                        NationalCode = string.IsNullOrWhiteSpace(txtNationalCode.Text) ? null : txtNationalCode.Text.Trim(),
                        Mobile = string.IsNullOrWhiteSpace(txtMobile.Text) ? null : txtMobile.Text.Trim(),
                        IsRetired = Convert.ToBoolean(ddlStatus.SelectedValue)
                    };
                    var newId = _patientService.Insert(p);
                    p.PatientId = newId;
                    _currentPatient = p;
                }
            }

            try
            {
                var visitId = _visitService.InsertVisitWithDetails(
                    Convert.ToInt32(txtVisitNo.Value),
                  _currentPatient.PatientId,
                  visitDate,
                  bookletExpiry,
                  txtPageNo.Text.Trim(),
                  _pendingDetails,
                  _currentPatient.IsRetired
                );

                RadMessageBox.Show(this, "ویزیت با موفقیت ثبت شد. شماره ویزیت: " + visitId, "موفقیت", MessageBoxButtons.OK, RadMessageIcon.Info);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(this, "خطا در ذخیره‌سازی ویزیت: " + ex.Message, "خطا", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------
        private void FillVisitForEdit(int visitId)
        {
            var (visit, details) = _visitService.GetVisitWithDetails(visitId);
            if (visit == null) return;
            var patient = _patientService.GetById(visit.PatientId);
            if (patient != null) { _currentPatient = patient; FillPatientInfoToControls(patient); }

            txtVisitDate.Text = PersianDateHelper.ToShamsi(visit.VisitDate);
            txtBookletExpiry.Text = visit.BookletExpiryDate.HasValue ? PersianDateHelper.ToShamsi(visit.BookletExpiryDate.Value) : string.Empty;
            txtPageNo.Text = visit.PrescriptionPageNo;

            _pendingDisplay = details.Select(d => d).ToList();
            _pendingDetails = details.Select(d => new VisitService.AddDetailRequest
            {
                ServiceId = d.ServiceId,
                Quantity = d.Quantity,
                VisitDate = visit.VisitDate
            }).ToList();


            RefreshServiceGrid();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------
        private void ShowError(string msg) => RadMessageBox.Show(this, msg, "خطا", MessageBoxButtons.OK, RadMessageIcon.Error);

        //--------------------------------------------------------------------------------------------------------------------------------------------
        private void txtPersonnelCode_TextChanged(object sender, EventArgs e)
        {
            var input = txtPersonnelCode.Value?.ToString()?.Replace("_", "").Trim();

            // بررسی فقط زمانی که طول ورودی به 8 رسید (مثلاً 12345600)
            if (input != null && input.Length == 8)
            {
                using var cn = DbHelper.GetConnection();
                var existing = cn.QueryFirstOrDefault<Patient>(
                    "SELECT * FROM Patients WHERE PersonnelCode = @code", new { code = input });
                if (existing != null)
                {
                    LoadPatientToForm(existing);
                }
                else
                {
                    InsertPatientFrm _insertPatientFrm = new InsertPatientFrm(null, false, txtPersonnelCode.Value?.ToString());
                    if (_insertPatientFrm.ShowDialog() == DialogResult.OK)
                    {
                        //txtPersonnelCode.Value = _insertPatientFrm._returnPersonnelCode;
                        existing = cn.QueryFirstOrDefault<Patient>(
                           "SELECT * FROM Patients WHERE PersonnelCode = @code", new { code = input });
                        LoadPatientToForm(existing);
                    }
                }

            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------
        private void LoadPatientToForm(Patient p)
        {
            //txtPersonnelCode.Text = p.PersonnelCode;
            txtFirstName.Text = p.FirstName;
            txtLastName.Text = p.LastName;
            txtNationalCode.Text = p.NationalCode;
            txtMobile.Text = p.Mobile;
            ddlStatus.SelectedIndex = p.IsRetired ? 1 : 0;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------
        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        //--------------------------------------------------------------------------------------------------------------------------------------------
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gridVisitDetails.CurrentRow == null || gridVisitDetails.CurrentRow.DataBoundItem == null)
            {
                RadMessageBox.Show("لطفاً یک خدمت را انتخاب کنید.", "هشدار", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                return;
            }

            var detail = (VisitDetail)gridVisitDetails.CurrentRow.DataBoundItem;

            var frm = new PatientVisitDetailsFrm(currentVisitId, currentPatient, currentVisitDate, detail.VisitDetailId);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadVisitDetails(); // بارگذاری مجدد پس از ویرایش
            }

        }

        //--------------------------------------------------------------------------------------------------------------------------------------------
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridVisitDetails.CurrentRow == null || gridVisitDetails.CurrentRow.DataBoundItem == null)
            {
                RadMessageBox.Show("لطفاً یک خدمت را انتخاب کنید.", "هشدار", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                return;
            }

            var detail = (VisitDetail)gridVisitDetails.CurrentRow.DataBoundItem;

            var confirm = RadMessageBox.Show("آیا از حذف این خدمت مطمئن هستید؟", "تأیید حذف", MessageBoxButtons.YesNo, RadMessageIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                var service = new VisitDetailService();
                service.Delete(detail.VisitDetailId);
                LoadVisitDetails(); // بارگذاری مجدد پس از حذف
            }

        }

        //--------------------------------------------------------------------------------------------------------------------------------------------
        private void btnInsert_Click(object sender, EventArgs e)
        {
            var frm = new PatientVisitDetailsFrm(currentVisitId, currentPatient, currentVisitDate);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadVisitDetails(); // بارگذاری مجدد خدمات پس از درج
            }

        }
        //--------------------------------------------------------------------------------------------------------------------------------------------

    }
}
