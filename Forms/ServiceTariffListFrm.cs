using NIOPDCXmlGenerator.Data;
using NIOPDCXmlGenerator.Models;
using NIOPDCXmlGenerator.Services;
using System;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace NIOPDCXmlGenerator.Forms
{
    public partial class ServiceTariffListFrm : RadForm
    {
        private readonly ServiceService _serviceService = new ServiceService();
        private readonly int _rateId;
        private readonly ServiceTariffService _serviceTariffService= new   ServiceTariffService();

        public ServiceTariffListFrm(int rateId)
        {
            InitializeComponent();
            _rateId = rateId;
        }


        private void ServiceTariffListFrm_Load(object sender, EventArgs e) => RefreshGrid();

        private void RefreshGrid()
        {
            var list = _serviceTariffService.GetByRateId(_rateId);
            radGridView1.DataSource = list;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new ServiceTariffEditFrm(_rateId);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                RefreshGrid();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (radGridView1.CurrentRow == null) return;

            var selected = radGridView1.CurrentRow.DataBoundItem as ServiceTariff;
            var frm = new ServiceTariffEditFrm(selected);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                RefreshGrid();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (radGridView1.CurrentRow == null) return;
            int id = (int)radGridView1.CurrentRow.Cells["TariffId"].Value;
            var res = RadMessageBox.Show(this, "آیا مطمئن هستید حذف شود؟", "حذف", MessageBoxButtons.YesNo, RadMessageIcon.Question);
            if (res == DialogResult.Yes)
            {
                _serviceService.DeleteTariff(id);
                RefreshGrid();
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();
    }
}
