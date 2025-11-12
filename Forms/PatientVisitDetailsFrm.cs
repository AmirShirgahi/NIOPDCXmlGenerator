using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace YourNamespace.Forms
{
    public partial class PatientVisitDetailsFrm : RadForm
    {
        private readonly string _connectionString;
        private readonly int _visitId;
        private readonly int? _visitDetailId;
        private readonly bool _isEditMode;

        private decimal _franchisePercentage = 0m;
        private int _franchiseRateId = 0;
        private int _patientId = 0;

        // cache for tariff amounts (serviceTariffId -> tariffAmount)
        private readonly System.Collections.Generic.Dictionary<int, decimal> _tariffCache = new System.Collections.Generic.Dictionary<int, decimal>();

        public PatientVisitDetailsFrm(string connectionString, int visitId, int? visitDetailId = null)
        {
            InitializeComponent();
            _connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
            _visitId = visitId;
            _visitDetailId = visitDetailId;
            _isEditMode = visitDetailId.HasValue;
        }

        private void PatientVisitDetailsFrm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadVisitHeader();

                if (!FindFranchiseRateForVisitDate())
                {
                    RadMessageBox.Show(this, "برای این تاریخ ویزیت دوره ای در جدول FranchiseRates تعریف نشده است. لطفا ابتدا دوره را تعریف کنید.", "دوره تعریف نشده", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                    return;
                }

                LoadServiceTariffs();

                if (_isEditMode) LoadVisitDetail();

                WireEvents();

                // اگر در حالت درج هستیم، آماده به کار
                if (!_isEditMode)
                {
                    rseQuantity.Value = 1;
                }
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(this, "خطا در بارگذاری فرم: " + ex.Message, "خطا", MessageBoxButtons.OK, RadMessageIcon.Error);
                this.Close();
            }
        }

        #region Load Header and FranchiseRate

        private void LoadVisitHeader()
        {
            const string sql = @"
SELECT v.PatientId, ISNULL(p.FirstName,'') + ' ' + ISNULL(p.LastName,'') AS FullName, v.VisitDate, v.VisitType
FROM Visits v
LEFT JOIN Patients p ON v.PatientId = p.Id
WHERE v.Id = @visitId;
";
            using (var cn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.AddWithValue("@visitId", _visitId);
                cn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    if (r.Read())
                    {
                        _patientId = r["PatientId"] != DBNull.Value ? Convert.ToInt32(r["PatientId"]) : 0;
                        lblPatientName.Text = r["FullName"]?.ToString() ?? "";
                        var dt = r["VisitDate"] != DBNull.Value ? Convert.ToDateTime(r["VisitDate"]) : (DateTime?)null;
                        lblVisitDate.Text = dt?.ToString("yyyy/MM/dd") ?? "";
                        lblVisitType.Text = r["VisitType"]?.ToString() ?? "";
                    }
                    else
                    {
                        throw new InvalidOperationException("سطر ویزیت یافت نشد.");
                    }
                }
            }
        }

        private bool FindFranchiseRateForVisitDate()
        {
            if (string.IsNullOrEmpty(lblVisitDate.Text)) return false;
            if (!DateTime.TryParse(lblVisitDate.Text, out DateTime visitDate)) return false;

            const string sql = @"
SELECT TOP 1 Id, EmployeePercentage, RetiredPercentage
FROM FranchiseRates
WHERE @visitDate BETWEEN FromDate AND ToDate
ORDER BY FromDate DESC;
";
            using (var cn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.AddWithValue("@visitDate", visitDate);
                cn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    if (r.Read())
                    {
                        _franchiseRateId = Convert.ToInt32(r["Id"]);
                        var empPct = r["EmployeePercentage"] != DBNull.Value ? Convert.ToDecimal(r["EmployeePercentage"]) : 0m;
                        var retPct = r["RetiredPercentage"] != DBNull.Value ? Convert.ToDecimal(r["RetiredPercentage"]) : 0m;

                        // فرض: VisitType متن "Retired" برای بازنشسته و "Employee" برای کارمند است
                        var vt = lblVisitType.Text?.Trim().ToLowerInvariant();
                        if (vt == "retired" || vt == "بازنشسته" || vt == "بازنشست") _franchisePercentage = retPct;
                        else _franchisePercentage = empPct;

                        lblFranchisePercentage.Text = _franchisePercentage.ToString("0.##") + " %";
                        return true;
                    }
                }
            }
            return false;
        }

        #endregion

        #region Load ServiceTariffs and VisitDetail

        private void LoadServiceTariffs()
        {
            // این کوئری سرویس‌هایی که برای این franchise rate وجود دارند و تاکنون برای این Visit ثبت نشده‌اند را می‌گیرد
            const string sql = @"
SELECT st.Id AS ServiceTariffId, s.ServiceName, st.TariffAmount
FROM ServiceTariffs st
JOIN Services s ON st.ServiceId = s.Id
WHERE st.FranchiseRateId = @franchiseRateId
AND st.Id NOT IN (SELECT ServiceTariffId FROM VisitDetails WHERE VisitId = @visitId)
ORDER BY s.ServiceName;
";

            using (var cn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.AddWithValue("@franchiseRateId", _franchiseRateId);
                cmd.Parameters.AddWithValue("@visitId", _visitId);
                var dt = new DataTable();
                using (var da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }

                // اگر در حالت ویرایش باشد و سرویس این VisitDetail در لیست بالا نیست، بعدا آن را اضافه خواهیم کرد
                rdlServices.DataSource = dt;
                rdlServices.DisplayMember = "ServiceName";
                rdlServices.ValueMember = "ServiceTariffId";

                // cache tariff amounts
                _tariffCache.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    var id = Convert.ToInt32(row["ServiceTariffId"]);
                    var amt = row["TariffAmount"] != DBNull.Value ? Convert.ToDecimal(row["TariffAmount"]) : 0m;
                    _tariffCache[id] = amt;
                }
            }
        }

        private void LoadVisitDetail()
        {
            const string sql = @"
SELECT vd.Id, vd.ServiceTariffId, ISNULL(st.TariffAmount,0) AS TariffAmount, vd.Quantity, vd.FranchiseAmount
FROM VisitDetails vd
LEFT JOIN ServiceTariffs st ON vd.ServiceTariffId = st.Id
WHERE vd.Id = @vdId;
";
            using (var cn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.AddWithValue("@vdId", _visitDetailId.Value);
                cn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    if (r.Read())
                    {
                        int serviceTariffId = r["ServiceTariffId"] != DBNull.Value ? Convert.ToInt32(r["ServiceTariffId"]) : 0;
                        decimal tariffAmount = r["TariffAmount"] != DBNull.Value ? Convert.ToDecimal(r["TariffAmount"]) : 0m;
                        int qty = r["Quantity"] != DBNull.Value ? Convert.ToInt32(r["Quantity"]) : 1;
                        decimal franchiseAmountPerUnit = r["FranchiseAmount"] != DBNull.Value ? Convert.ToDecimal(r["FranchiseAmount"]) : tariffAmount;

                        // اگر سرویس قبلاً در لیست نباشد، آن را اضافه کن
                        var exists = rdlServices.Items.Any(i => (int)i.Value == serviceTariffId);
                        if (!exists)
                        {
                            string text = $"(سرویس قدیمی) {serviceTariffId}";
                            var item = new RadListDataItem(text, serviceTariffId);
                            rdlServices.Items.Add(item);
                            _tariffCache[serviceTariffId] = tariffAmount;
                        }

                        rdlServices.SelectedValue = serviceTariffId;
                        rseQuantity.Value = qty;
                        rseFranchiseAmount.Value = franchiseAmountPerUnit;

                        // محاسبه اولیه
                        CalculateShares();
                    }
                }
            }
        }

        #endregion

        #region Events and Calculation

        private void WireEvents()
        {
            rdlServices.SelectedIndexChanged += RdlServices_SelectedIndexChanged;
            rseQuantity.ValueChanged += RseQuantity_ValueChanged;
            rseFranchiseAmount.ValueChanged += RseFranchiseAmount_ValueChanged;
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += BtnCancel_Click;
        }

        private void RdlServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdlServices.SelectedValue == null) return;
            int id = (int)rdlServices.SelectedValue;
            if (_tariffCache.ContainsKey(id))
            {
                // اگر کاربر هنوز مبلغ فرانشیز را تغییر نداده، مقدار پیش‌فرض را ست کن
                if (rseFranchiseAmount.Value == 0m)
                {
                    rseFranchiseAmount.Value = _tariffCache[id];
                }
            }
            else
            {
                // تلاش برای گرفتن تعرفه از دیتابیس در صورت نبودن در کش
                var amt = GetTariffAmount(id);
                _tariffCache[id] = amt;
                if (rseFranchiseAmount.Value == 0m) rseFranchiseAmount.Value = amt;
            }
            CalculateShares();
        }

        private void RseQuantity_ValueChanged(object sender, EventArgs e)
        {
            CalculateShares();
        }

        private void RseFranchiseAmount_ValueChanged(object sender, EventArgs e)
        {
            CalculateShares();
        }

        private void CalculateShares()
        {
            if (rdlServices.SelectedValue == null) return;
            int serviceTariffId = (int)rdlServices.SelectedValue;
            decimal tariffAmount = _tariffCache.ContainsKey(serviceTariffId) ? _tariffCache[serviceTariffId] : GetTariffAmount(serviceTariffId);
            int qty = Convert.ToInt32(rseQuantity.Value);
            decimal pct = _franchisePercentage; // درصد مثل 20 => 20
            decimal franchiseAmountPerUnit = rseFranchiseAmount.Value > 0 ? rseFranchiseAmount.Value : tariffAmount;

            decimal patientShare = franchiseAmountPerUnit * qty * (pct / 100m);
            decimal companyShare = franchiseAmountPerUnit * qty * ((100m - pct) / 100m);
            decimal total = patientShare + companyShare;

            rsePatientShare.Value = Math.Round(patientShare, 2);
            rseCompanyShare.Value = Math.Round(companyShare, 2);
            rseTotal.Value = Math.Round(total, 2);
        }

        private decimal GetTariffAmount(int serviceTariffId)
        {
            const string sql = "SELECT ISNULL(TariffAmount,0) FROM ServiceTariffs WHERE Id = @id";
            using (var cn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.AddWithValue("@id", serviceTariffId);
                cn.Open();
                var obj = cmd.ExecuteScalar();
                return obj != null ? Convert.ToDecimal(obj) : 0m;
            }
        }

        #endregion

        #region Save (Insert / Update)

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputs()) return;

                int serviceTariffId = (int)rdlServices.SelectedValue;
                int qty = Convert.ToInt32(rseQuantity.Value);
                decimal franchiseAmountPerUnit = rseFranchiseAmount.Value;
                decimal patientShare = rsePatientShare.Value;
                decimal companyShare = rseCompanyShare.Value;
                decimal total = rseTotal.Value;

                using (var cn = new SqlConnection(_connectionString))
                {
                    cn.Open();
                    using (var tran = cn.BeginTransaction())
                    {
                        if (_isEditMode)
                        {
                            const string sqlUpdate = @"
UPDATE VisitDetails
SET ServiceTariffId = @serviceTariffId,
    Quantity = @qty,
    FranchiseAmount = @franchiseAmount,
    PatientShare = @patientShare,
    CompanyShare = @companyShare,
    TotalAmount = @total,
    ModifiedAt = GETDATE()
WHERE Id = @vdId;
";
                            using (var cmd = new SqlCommand(sqlUpdate, cn, tran))
                            {
                                cmd.Parameters.AddWithValue("@serviceTariffId", serviceTariffId);
                                cmd.Parameters.AddWithValue("@qty", qty);
                                cmd.Parameters.AddWithValue("@franchiseAmount", franchiseAmountPerUnit);
                                cmd.Parameters.AddWithValue("@patientShare", patientShare);
                                cmd.Parameters.AddWithValue("@companyShare", companyShare);
                                cmd.Parameters.AddWithValue("@total", total);
                                cmd.Parameters.AddWithValue("@vdId", _visitDetailId.Value);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            const string sqlInsert = @"
INSERT INTO VisitDetails
(VisitId, PatientId, ServiceTariffId, Quantity, FranchiseAmount, PatientShare, CompanyShare, TotalAmount, CreatedAt, CreatedBy)
VALUES
(@visitId, @patientId, @serviceTariffId, @qty, @franchiseAmount, @patientShare, @companyShare, @total, GETDATE(), @createdBy);
";
                            using (var cmd = new SqlCommand(sqlInsert, cn, tran))
                            {
                                cmd.Parameters.AddWithValue("@visitId", _visitId);
                                cmd.Parameters.AddWithValue("@patientId", _patientId);
                                cmd.Parameters.AddWithValue("@serviceTariffId", serviceTariffId);
                                cmd.Parameters.AddWithValue("@qty", qty);
                                cmd.Parameters.AddWithValue("@franchiseAmount", franchiseAmountPerUnit);
                                cmd.Parameters.AddWithValue("@patientShare", patientShare);
                                cmd.Parameters.AddWithValue("@companyShare", companyShare);
                                cmd.Parameters.AddWithValue("@total", total);
                                cmd.Parameters.AddWithValue("@createdBy", GetCurrentUserId());
                                cmd.ExecuteNonQuery();
                            }
                        }

                        tran.Commit();
                    }
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(this, "خطا در ذخیره‌سازی: " + ex.Message, "خطا", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }

        private int GetCurrentUserId()
        {
            // مقداردهی مناسب بر اساس سیستم شما; فعلاً مقدار ثابت
            return 1;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool ValidateInputs()
        {
            if (rdlServices.SelectedValue == null)
            {
                RadMessageBox.Show(this, "لطفا یک سرویس انتخاب کنید.", "خطا", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                return false;
            }
            if (rseQuantity.Value <= 0)
            {
                RadMessageBox.Show(this, "تعداد باید بزرگتر از صفر باشد.", "خطا", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                return false;
            }
            return true;
        }

        #endregion
    }
}
