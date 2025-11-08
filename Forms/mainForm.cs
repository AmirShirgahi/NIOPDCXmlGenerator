using NIOPDCXmlGenerator.Forms;
using NIOPDCXmlGenerator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Docking;
using static NIOPDCXmlGenerator.Forms.ChangePassword;

namespace NIOPDCXmlGenerator.Forms
{
    //public class CustomDockTabStrip : DockTabStrip
    //{
    //    public CustomDockTabStrip(RadDock dockManager) : base(dockManager)
    //    {
    //    }

    //    public override DockType DockType
    //    {
    //        get { return DockType.Document; }
    //    }

    //    protected override void OnMouseUp(MouseEventArgs e)
    //    {
    //        if (e.Button == MouseButtons.Right)
    //        {
    //            // جلوگیری از نمایش منوی کلیک راست
    //            return;
    //        }

    //        base.OnMouseUp(e);
    //    }
    //}



    public partial class MainFrm : Telerik.WinControls.UI.RadRibbonForm
    {
        private readonly User? _currentUser;
        public MainFrm(User currentUser)
        {
            InitializeComponent();

            lblUser.Text = currentUser == null ? "کاربر غیرمجاز" : $"{currentUser.FullName ?? "NULL"}{(currentUser.IsAdmin ? " (Admin)" : string.Empty)}";
        }
        private int patientFormCounter = 1;
        private void ShowNewFormInDock(Form frm, string title)
        {
            //var docWindow = new DocumentWindow(title);
            var docWindow = new DocumentWindow(frm.Text);

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            docWindow.Controls.Add(frm);
            frm.Show();

            radDockMain.AddDocument(docWindow);
            radDockMain.ActiveWindow = docWindow;
        }

        private void radButtonElement4_Click(object sender, EventArgs e)
        {
            //ShowFormInDock(new PatientInsertFrm());
            string uniqueTitle = $"PatientInsertFrm #{patientFormCounter++}";
            ShowNewFormInDock(new InsertPatientFrm(null) { FormBorderStyle = FormBorderStyle.None }, uniqueTitle);
        }


        private void radDockMain_ActiveWindowChanged(object sender, DockWindowEventArgs e)
        {

        }

        private void radButtonElement5_Click(object sender, EventArgs e)
        {
            //ShowFormInDock(new PatientListFrm());

            string uniqueTitle = $"PatientListFrm #{patientFormCounter++}";
            ShowNewFormInDock(new PatientListFrm{ FormBorderStyle = FormBorderStyle.None }, uniqueTitle);
        }

        private void ChangePass_Click(object sender, EventArgs e)
        {
            using var dlg = new ChangePasswordFrm(_currentUser); // implement separately if desired
            dlg.ShowDialog();
        }

        private void btnUserManagemen_Click(object sender, EventArgs e)
        {
            string uniqueTitle = $"UserManagementFrm #{patientFormCounter++}";
            ShowNewFormInDock(new UserManagementFrm{ FormBorderStyle = FormBorderStyle.None }, uniqueTitle);
        }

        private void btnPatientVisit_Click(object sender, EventArgs e)
        {
            string uniqueTitle = $"PatientVisitFrm #{patientFormCounter++}";
            ShowNewFormInDock(new PatientVisitFrm{ FormBorderStyle = FormBorderStyle.None }, uniqueTitle);
        }

        private void btnPatientVisitList_Click(object sender, EventArgs e)
        {
            string uniqueTitle = $"PatientVisitListFrm #{patientFormCounter++}";
            ShowNewFormInDock(new PatientVisitListFrm{ FormBorderStyle = FormBorderStyle.None }, uniqueTitle);
        }

        private void radButtonElement7_Click(object sender, EventArgs e)
        {
            string uniqueTitle = $"FranchiseRateListFrm #{patientFormCounter++}";
            ShowNewFormInDock(new FranchiseRateListFrm{ FormBorderStyle = FormBorderStyle.None }, uniqueTitle);

        }

        private void radButtonElement1_Click(object sender, EventArgs e)
        {
            string uniqueTitle = $"ServiceListFrm #{patientFormCounter++}";
            ShowNewFormInDock(new ServiceListFrm{ FormBorderStyle = FormBorderStyle.None }, uniqueTitle);

        }

        private void btnServiceTariffList_Click(object sender, EventArgs e)
        {
            string uniqueTitle = $"ServiceListFrm #{patientFormCounter++}";
            ShowNewFormInDock(new ServiceListFrm{ FormBorderStyle = FormBorderStyle.None }, uniqueTitle);

        }

        private void radButtonElement8_Click(object sender, EventArgs e)
        {
            string uniqueTitle = $"DoctorListFrm #{patientFormCounter++}";
            ShowNewFormInDock(new DoctorListFrm { FormBorderStyle = FormBorderStyle.None }, uniqueTitle);

        }
    }

}



