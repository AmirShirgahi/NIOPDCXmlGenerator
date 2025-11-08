using System;
using System.Windows.Forms;
using NIOPDCXmlGenerator.Models;
using NIOPDCXmlGenerator.Services;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace NIOPDCXmlGenerator.Forms
{
    public partial class ServiceEditFrm : RadForm
    {
        private readonly ServiceService _serviceService = new ServiceService();
        private readonly int? _editingId;

        public ServiceEditFrm(int? editingId = null)
        {
            InitializeComponent();
            _editingId = editingId;
        }

        private void ServiceEditFrm_Load(object sender, EventArgs e)
        {
            if (_editingId.HasValue)
            {
                var s = _serviceService.GetServiceById(_editingId.Value);
                if (s != null)
                {
                    txtTitle.Text = s.Title;
                    chkActive.ToggleState = s.IsActive ? Telerik.WinControls.Enumerations.ToggleState.On : Telerik.WinControls.Enumerations.ToggleState.Off;
                }
            }
            else chkActive.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var title = txtTitle.Text.Trim();
            if (string.IsNullOrWhiteSpace(title)) { RadMessageBox.Show(this, "نام خدمت وارد نشده.", "خطا", MessageBoxButtons.OK, RadMessageIcon.Error); return; }

            var s = new ServiceItem { Title = title, IsActive = chkActive.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On };
            if (_editingId.HasValue) { s.ServiceId = _editingId.Value; _serviceService.UpdateService(s); }
            else _serviceService.InsertService(s);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
