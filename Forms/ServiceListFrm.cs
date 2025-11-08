using System;
using System.Linq;
using System.Windows.Forms;
using NIOPDCXmlGenerator.Services;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace NIOPDCXmlGenerator.Forms
{
    public partial class ServiceListFrm : RadForm
    {
        private readonly ServiceService _serviceService = new ServiceService();

        public ServiceListFrm()
        {
            InitializeComponent();
        }

        private void ServiceListFrm_Load(object sender, EventArgs e) => RefreshGrid();

        private void RefreshGrid()
        {
            var data = _serviceService.GetAllServices().Select(s => new {
                s.ServiceId,
                s.Title,
                IsActive = s.IsActive ? "فعال" : "غیرفعال",
                CreatedAt = s.CreatedAt.ToString("yyyy-MM-dd")
            }).ToList();

            radGridView1.DataSource = data;
            if (radGridView1.Columns["ServiceId"] != null) radGridView1.Columns["ServiceId"].IsVisible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var frm = new ServiceEditFrm();
            if (frm.ShowDialog(this) == DialogResult.OK) RefreshGrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (radGridView1.CurrentRow == null) return;
            int id = (int)radGridView1.CurrentRow.Cells["ServiceId"].Value;
            using var frm = new ServiceEditFrm(id);
            if (frm.ShowDialog(this) == DialogResult.OK) RefreshGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (radGridView1.CurrentRow == null) return;
            int id = (int)radGridView1.CurrentRow.Cells["ServiceId"].Value;
            var res = RadMessageBox.Show(this, "آیا مطمئن هستید حذف شود؟", "حذف", MessageBoxButtons.YesNo, RadMessageIcon.Question);
            if (res == DialogResult.Yes)
            {
                _serviceService.DeleteService(id);
                RefreshGrid();
            }
        }

        private void btnTariffs_Click(object sender, EventArgs e)
        {
            if (radGridView1.CurrentRow == null) return;
            int id = (int)radGridView1.CurrentRow.Cells["ServiceId"].Value;
            using var frm = new ServiceTariffListFrm(id);
            frm.ShowDialog(this);
        }

        private void btnRefresh_Click(object sender, EventArgs e) => RefreshGrid();

        private void btnClose_Click(object sender, EventArgs e) => Close();
    }
}
