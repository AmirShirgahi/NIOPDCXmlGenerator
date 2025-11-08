using Dapper;
using NIOPDCXmlGenerator.Data;
using NIOPDCXmlGenerator.Models;
using NIOPDCXmlGenerator.Services;
using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace NIOPDCXmlGenerator.Forms
{

    public partial class InsertPatientFrm : RadForm
    {
        private readonly PatientService _service = new PatientService();
        private Patient? _editing = null;
        public string _returnPersonnelCode = string.Empty;
        //--------------------------------------------------------------------------------------------------------------------------------------------
        public InsertPatientFrm(Patient? patient, bool enableTxtPersonelcode = true, string Personelcode = "")
        {

            InitializeComponent();
            if (!enableTxtPersonelcode) txtPersonnelCode.Enabled = enableTxtPersonelcode;
            if (Personelcode.Length > 0) txtPersonnelCode.Value = Personelcode;
            _editing = patient;
            if (_editing != null) LoadForEdit();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------
        private void LoadForEdit()
        {
            txtPersonnelCode.Text = _editing.PersonnelCode;
            txtFirstName.Text = _editing.FirstName;
            txtLastName.Text = _editing.LastName;
            ddGender.SelectedIndex = _editing.Gender ;
            txtNationalCode.Text = _editing.NationalCode;
            txtMobile.Text = _editing.Mobile;
            ddlStatus.SelectedIndex = _editing.IsRetired ? 1 : 0;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------
        private void btnSave_Click(object sender, EventArgs e)
        {
            var code = txtPersonnelCode.Value?.ToString()?.Trim();
            if (!ValidationHelper.ValidatePersonnelCode(code))
            {
                RadMessageBox.Show(this, "کد پرسنلی نامعتبر است", "خطا", MessageBoxButtons.OK, RadMessageIcon.Error);
                txtPersonnelCode.Focus();
                //return;
            }
            else if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                RadMessageBox.Show(this, "نام را وارد کنید", "خطا", MessageBoxButtons.OK, RadMessageIcon.Error);
                txtFirstName.Focus();
                //return;
            }

            else if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                RadMessageBox.Show(this, "نام خانوادگی را وارد کنید", "خطا", MessageBoxButtons.OK, RadMessageIcon.Error);
                txtLastName.Focus();
                //return;
            }

            else if (!ValidationHelper.ValidateMobile(txtMobile.Value?.ToString().Replace("_", "")))
            {
                RadMessageBox.Show(this, "شماره موبایل نامعتبر است", "خطا", MessageBoxButtons.OK, RadMessageIcon.Error);
                txtMobile.Focus();
                //return;
            }

            else if (!ValidationHelper.ValidateNationalCode(txtNationalCode.Value?.ToString().Replace("_", "")))
            {
                RadMessageBox.Show(this, "کد ملی نامعتبر است", "خطا", MessageBoxButtons.OK, RadMessageIcon.Error);
                txtNationalCode.Focus();
                //return;
            }
            else
            {

                var p = new Patient
                {
                    PersonnelCode = code!,
                    FirstName = txtFirstName.Text.Trim(),
                    LastName = txtLastName.Text.Trim(),
                    NationalCode = txtNationalCode.Text.Trim(),
                    Mobile = txtMobile.Text.Trim(),
                    IsRetired = ddlStatus.SelectedIndex == 1,
                    Gender= ddGender.SelectedIndex,
                };

                try
                {
                    if (_editing == null)
                    {
                        int r = _service.Insert(p);
                        _returnPersonnelCode = p.PersonnelCode;
                        RadMessageBox.Show(this, "بیمار جدید با موفقیت ثبت شد", "موفقیت", MessageBoxButtons.OK, RadMessageIcon.Info);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        p.PatientId = _editing.PatientId;
                        _service.Update(p);
                        _returnPersonnelCode = p.PersonnelCode;
                        RadMessageBox.Show(this, "اطلاعات بیمار با موفقیت ویرایش شد", "ویرایش", MessageBoxButtons.OK, RadMessageIcon.Info);
                        this.DialogResult = DialogResult.OK;
                    }

                    ClearForm();
                    _editing = null;
                    txtPersonnelCode.Focus();
                }
                catch (Exception ex)
                {
                    RadMessageBox.Show(this, "خطا در ثبت اطلاعات: " + ex.Message, "خطا", MessageBoxButtons.OK, RadMessageIcon.Error);
                }
            }
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------
        private void ClearForm()
        {
            txtPersonnelCode.Value = string.Empty;
            txtFirstName.Clear();
            txtLastName.Clear();
            txtNationalCode.Value = string.Empty;
            txtMobile.Value = string.Empty;
            ddlStatus.SelectedIndex = 0;
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------

        private void MoveFocusOnEnter(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (sender == ddlStatus)
                {
                    btnSave.PerformClick();
                }
                else
                {
                    this.SelectNextControl(this.ActiveControl, true, true, true, true);
                }
            }
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------
        private void InsertPatientFrm_Load(object sender, EventArgs e)
        {
            AttachFocusHandlers(this);

            //txtFirstName.KeyDown += MoveFocusOnEnter;
            //txtLastName.KeyDown += MoveFocusOnEnter;
            //txtPersonnelCode.KeyDown += MoveFocusOnEnter;
            //txtMobile.KeyDown += MoveFocusOnEnter;
            //txtNationalCode.KeyDown += MoveFocusOnEnter;
            //ddlStatus.KeyDown += MoveFocusOnEnter;
            //foreach (Control ctrl in this.Controls)
            //{
            //    if (ctrl is RadTextBox || ctrl is RadMaskedEditBox || ctrl is RadDropDownList)
            //    {
            //        ctrl.KeyDown += MoveFocusOnEnter;
            //    }
            //}

            this.Text = _editing == null ? "ثبت بیمار جدید" : "ویرایش بیمار";
        }

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

                if (_editing != null)
                {
                    _editing = existing;
                    LoadPatientToForm(existing);
                }
                else if ((existing != null) && (_editing == null))
                {
                    var res = RadMessageBox.Show(this,
                        "این کد پرسنلی قبلاً ثبت شده است. آیا مایل به ویرایش آن هستید؟",
                        "رکورد موجود است",
                        MessageBoxButtons.YesNo,
                        RadMessageIcon.Question);
                    
                    if (res == DialogResult.Yes)
                    {
                        _editing = existing;
                        LoadPatientToForm(existing);
                    }
                    else
                    {
                        ClearForm();
                        txtPersonnelCode.Focus();
                    }
                }
                else
                {
                    _editing = null;
                    txtFirstName.Focus();
                }

            }
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------
        private void LoadPatientToForm(Patient p)
        {
            txtPersonnelCode.Text = p.PersonnelCode;
            txtFirstName.Text = p.FirstName;
            txtLastName.Text = p.LastName;
            txtNationalCode.Text = p.NationalCode;
            txtMobile.Text = p.Mobile;
            ddlStatus.SelectedIndex = p.IsRetired ? 1 : 0;
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------
        private void Control_Enter(object sender, EventArgs e)
        {
            if (sender is RadTextBox txt)
            {
                txt.BackColor = Color.LightGoldenrodYellow;
                txt.ForeColor = Color.Blue;
            }
            else if (sender is RadMaskedEditBox masked)
            {
                masked.BackColor = Color.LightGoldenrodYellow;
                masked.ForeColor = Color.Blue;
            }
            else if (sender is RadDropDownList ddl)
            {
                ddl.BackColor = Color.LightGoldenrodYellow;
                ddl.ForeColor = Color.Blue;
            }
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------

        private void Control_Leave(object sender, EventArgs e)
        {
            if (sender is RadTextBox txt)
            {
                txt.ResetBackColor();
                txt.ResetForeColor();
            }
            else if (sender is RadMaskedEditBox masked)
            {
                masked.ResetBackColor();
                masked.ResetForeColor();
            }
            else if (sender is RadDropDownList ddl)
            {
                ddl.ResetBackColor();
                ddl.ResetForeColor();
            }
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------
        private void AttachFocusHandlers(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is RadTextBox || ctrl is RadMaskedEditBox || ctrl is RadDropDownList)
                {
                    ctrl.Enter += Control_Enter;
                    ctrl.Leave += Control_Leave;
                    //ctrl.KeyDown += MoveFocusOnEnter;
                }

                if (ctrl.HasChildren)
                {
                    AttachFocusHandlers(ctrl);
                }
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------
        private void ddlStatus_Enter(object sender, EventArgs e)
        {
            ddlStatus.ShowDropDown();

        }
        //--------------------------------------------------------------------------------------------------------------------------------------------

    }

}
