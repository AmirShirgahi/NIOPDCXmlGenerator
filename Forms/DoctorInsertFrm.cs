using NIOPDCXmlGenerator.Models;
using NIOPDCXmlGenerator.Services;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using static Telerik.WinControls.UI.ValueMapper;

namespace NIOPDCXmlGenerator
{
    public partial class DoctorInsertFrm : RadForm
    {
        private Doctor _doctor;
        private readonly bool _isEdit;

        public DoctorInsertFrm()
        {
            InitializeComponent();
            this.Font = new System.Drawing.Font("B Nazanin", 11);
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;

            _doctor = new Doctor();
            _isEdit = false;
            SetupGenderDropdown();
        }

        public DoctorInsertFrm(Doctor doctor) : this()
        {
            _doctor = doctor;
            _isEdit = true;
            FillForm();
        }

        private void SetupGenderDropdown()
        {
            comboGender.DropDownStyle = RadDropDownStyle.DropDownList; // فقط انتخاب، بدون ویرایش متن
            comboGender.Items.Clear();
            comboGender.Items.Add("زن");   // index = 0
            comboGender.Items.Add("مرد");  // index = 1
            comboGender.SelectedIndex = 0;
        }

        private void FillForm()
        {
            txtNPCode.Text = _doctor.NPCode;
            txtFirstName.Text = _doctor.FirstName;
            txtLastName.Text = _doctor.LastName;
            txtNationalCode.Text = _doctor.NationalCode;
            txtMobile.Text = _doctor.Mobile;
            comboGender.SelectedIndex = _doctor.Gender;
            chkIsActive.Checked = _doctor.IsActive;

            // ✅ در حالت ویرایش کد نظام پزشکی غیرقابل تغییر باشد
            txtNPCode.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool validationStatus = false;
            var service = new DoctorService();
            var allDoctors = service.GetAll();

            // ✅ بررسی کد نظام پزشکی
            if ((!validationStatus) && (string.IsNullOrWhiteSpace(txtNPCode.Text)))
            {
                validationStatus = true;
                RadMessageBox.Show("کد نظام پزشکی الزامی است.", "خطا", MessageBoxButtons.OK, RadMessageIcon.Error);
                txtNPCode.Focus();
            }
            if ((!validationStatus) && (!_isEdit))
            {
                // در حالت Insert بررسی کن NPCode تکراری نباشد
                if (allDoctors.Any(d => d.NPCode == txtNPCode.Text.Trim()))
                {
                    RadMessageBox.Show("کد نظام پزشکی وارد شده قبلاً ثبت شده است.", "خطا", MessageBoxButtons.OK, RadMessageIcon.Error);
                    validationStatus = true;
                    txtNPCode.Focus();
                }
            }
            if ((!validationStatus) && (_isEdit))
            {
                // در حالت Edit بررسی کن پزشک دیگری با همین NPCode وجود نداشته باشد
                if (allDoctors.Any(d => d.NPCode == txtNPCode.Text.Trim() && d.NPCode != _doctor.NPCode))
                {
                    RadMessageBox.Show("کد نظام پزشکی وارد شده قبلاً برای پزشک دیگری ثبت شده است.", "خطا", MessageBoxButtons.OK, RadMessageIcon.Error);
                    validationStatus = true;
                    txtNPCode.Focus();
                }
            }
            if ((!validationStatus) && (string.IsNullOrWhiteSpace(txtFirstName.Text)))
            {
                RadMessageBox.Show(this, "نام را وارد کنید", "خطا", MessageBoxButtons.OK, RadMessageIcon.Error);
                validationStatus = true;
                txtFirstName.Focus();
                //return;
            }

            if ((!validationStatus) && (string.IsNullOrWhiteSpace(txtLastName.Text)))
            {
                RadMessageBox.Show(this, "نام خانوادگی را وارد کنید", "خطا", MessageBoxButtons.OK, RadMessageIcon.Error);
                validationStatus = true;
                txtLastName.Focus();
                //return;
            }

            if ((!validationStatus) && (!ValidationHelper.ValidateMobile(txtMobile.Value?.ToString().Replace("_", ""))))
            {
                RadMessageBox.Show(this, "شماره موبایل نامعتبر است", "خطا", MessageBoxButtons.OK, RadMessageIcon.Error);
                validationStatus = true;
                txtMobile.Focus();
                //return;
            }

            if ((!validationStatus) && (!ValidationHelper.ValidateNationalCode(txtNationalCode.Value?.ToString().Replace("_", ""))))
            {
                RadMessageBox.Show(this, "کد ملی نامعتبر است", "خطا", MessageBoxButtons.OK, RadMessageIcon.Error);
                validationStatus = true;
                txtNationalCode.Focus();
                //return;
            }
            if ((!validationStatus) && (allDoctors.Any(d => d.NationalCode == txtNationalCode.Text.Trim() && d.NPCode != _doctor.NPCode)))
            {
                RadMessageBox.Show("این کد ملی قبلاً برای پزشک دیگری ثبت شده است.", "خطا", MessageBoxButtons.OK, RadMessageIcon.Error);
                validationStatus = true;
                txtNationalCode.Focus();
            }
            if (!validationStatus)
            {
                // ✅ ثبت اطلاعات در آبجکت
                _doctor.NPCode = txtNPCode.Text.Trim();
                _doctor.FirstName = txtFirstName.Text.Trim();
                _doctor.LastName = txtLastName.Text.Trim();
                _doctor.NationalCode = txtNationalCode.Value?.ToString().Replace("_", "").Trim();
                _doctor.Mobile = txtMobile.Value?.ToString().Replace("_", "").Trim();
                _doctor.Gender = (int)comboGender.SelectedItem.Index; // 0=زن، 1=مرد
                _doctor.Specialty = txtSpecialty.Text.Trim();
                _doctor.IsActive = chkIsActive.Checked;

                // ✅ ذخیره در دیتابیس
                if (_isEdit)
                    service.Update(_doctor);
                else
                    service.Insert(_doctor);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}