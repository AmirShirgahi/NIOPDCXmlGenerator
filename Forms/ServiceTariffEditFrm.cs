using NIOPDCXmlGenerator.Data;
using NIOPDCXmlGenerator.Models;
using NIOPDCXmlGenerator.Services;
using System;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Themes.Design;
using Telerik.WinControls.UI;
using System.Linq;

namespace NIOPDCXmlGenerator.Forms
{
    public partial class ServiceTariffEditFrm : RadForm
    {
        private readonly int _rateId;
        private readonly ServiceTariffService _tariffService = new ServiceTariffService();
        private readonly ServiceService _serviceService = new ServiceService();

        public ServiceTariffEditFrm(int rateId)
        {
            InitializeComponent();
            _rateId = rateId;

            var allServices = _serviceService.GetRemainServicesByrateId(rateId);
            var usedServices = _tariffService.GetByRateId(rateId).Select(t => t.ServiceId).ToList();
            var availableServices = allServices.Where(s => !usedServices.Contains(s.ServiceId)).ToList();

            ddlService.DataSource = availableServices;
            ddlService.DisplayMember = "Title";
            ddlService.ValueMember = "ServiceId";
            ddlService.Enabled = true;
        }
        private readonly ServiceTariff _tariff;

        public ServiceTariffEditFrm(ServiceTariff tariff)
        {
            InitializeComponent();
            _tariff = tariff;

            var selectedService = _serviceService.GetServiceById(tariff.ServiceId);
            ddlService.Text = selectedService?.Title;
            ddlService.SelectedValue = selectedService.ServiceId;
            ddlService.Enabled = false;

            txtAmount.Value = tariff.Amount;
        }

        private void ServiceTariffEditFrm_Load(object sender, EventArgs e)
        {
            if (_tariff != null)
            {
                // حالت ویرایش
                var service = _serviceService.GetServiceById(_tariff.ServiceId);
                if (service != null)
                {
                    ddlService.Items.Clear();
                    ddlService.Items.Add(service.Title);
                    ddlService.SelectedIndex = 0;
                }

                ddlService.Enabled = false;
                txtAmount.Value = _tariff.Amount;
            }
            else
            {
                // حالت درج جدید
                var allServices = _serviceService.GetActiveServices();
                var usedServices = _tariffService.GetByRateId(_rateId).Select(t => t.ServiceId).ToList();
                var availableServices = allServices.Where(s => !usedServices.Contains(s.ServiceId)).ToList();

                ddlService.DataSource = availableServices;
                ddlService.DisplayMember = "Title";
                ddlService.ValueMember = "ServiceId";
                ddlService.Enabled = true;

                txtAmount.Value = 0;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAmount.Value < 0)
            {
                RadMessageBox.Show("مبلغ تعرفه باید عددی بزرگتر یا مساوی صفر باشد.");
                return;
            }

            if (_tariff == null)
            {
                // حالت Insert
                var newTariff = new ServiceTariff
                {
                    FranchiseRateID = _rateId,
                    ServiceId = (int)ddlService.SelectedValue,
                    Amount = (long)txtAmount.Value
                };
                _tariffService.Insert(newTariff);
            }
            else
            {
                // حالت Edit
                _tariff.Amount = (long)txtAmount.Value;
                _tariffService.Update(_tariff);
            }

            DialogResult = DialogResult.OK;

        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
