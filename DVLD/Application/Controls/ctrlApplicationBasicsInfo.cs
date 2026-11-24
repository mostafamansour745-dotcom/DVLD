using DVLD.Classes;
using DVLD.GlobalClasses;
using DVLD.People;
using DVLD.Properties;
using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD.Application.Controls
{
    public partial class ctrlApplicationBasicsInfo : UserControl
    {
        private clsApplication _Application;
        private int _ApplicationID = -1;

        public int ApplicationID { get { return _ApplicationID; } }

        public ctrlApplicationBasicsInfo()
        {
            InitializeComponent();
        }

        public void LoadApplicationInfo(int applicationID)
        {
            _Application = clsApplication.FindBaseApplication(applicationID);

            if (_Application == null)
            {
                ResetApplicationInfo();
                MessageBox.Show("No Application with ApplicationID = " + applicationID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillApplicationInfo();
        }

        private void _FillApplicationInfo()
        {
            _ApplicationID = _Application.ApplicationID;
            lblApplicationID.Text = _Application.ApplicationID.ToString();
            lblStatus.Text = _Application.StatusText;
            lblType.Text = _Application.ApplicationTypeInfo?.Title ?? string.Empty;
            lblFees.Text = _Application.PaidFees.ToString("0.##");
            lblApplicant.Text = _Application.ApplicantFullName;
            lblDate.Text = clsFormat.DateToShort(_Application.ApplicationDate);
            lblStatusDate.Text = clsFormat.DateToShort(_Application.LastStatusDate);
            lblCreatedByUser.Text = _Application.CreatedByUserInfo?.UserName ?? string.Empty;
        }

        public void ResetApplicationInfo()
        {
            _ApplicationID = -1;

            lblApplicationID.Text = "[????]";
            lblStatus.Text = "[????]";
            lblType.Text = "[????]";
            lblFees.Text = "[????]";
            lblApplicant.Text = "[????]";
            lblDate.Text = "[????]";
            lblStatusDate.Text = "[????]";
            lblCreatedByUser.Text = "[????]";
        }

        private void llViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_Application == null)
                return;

            frmShowPersonInfo frm = new frmShowPersonInfo(_Application.ApplicantPersonID);
            frm.ShowDialog();

            // Refresh Application Info
            LoadApplicationInfo(_ApplicationID);
        }
    }
}