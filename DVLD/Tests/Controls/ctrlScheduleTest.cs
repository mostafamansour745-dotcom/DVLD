using DVLD.Classes;
using DVLD.GlobalClasses;
using DVLD.Properties;
using DVLD_Business;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DVLD.Tests.Controls
{
    public partial class ctrlScheduleTest : UserControl
    {
        public enum enMode { AddNew = 0, Update = 1 }
        private enMode _mode = enMode.AddNew;

        public enum enCreationMode { FirstTimeSchedule = 0, RetakeTestSchedule = 1 }
        private enCreationMode _creationMode = enCreationMode.FirstTimeSchedule;

        private clsTestType.enTestType _testTypeID = clsTestType.enTestType.VisionTest;
        private clsLocalDrivingLicenseApplication _localDrivingLicenseApplication;
        private clsTestAppointment _testAppointment;

        private int _localDrivingLicenseApplicationID = -1;
        private int _testAppointmentID = -1;

        private float _testTypeFees = 0;
        private float _retakeAppFees = 0;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public clsTestType.enTestType TestTypeID
        {
            get { return _testTypeID; }
            set
            {
                _testTypeID = value;
                _UpdateTestTypeUI();
            }
        }

        public ctrlScheduleTest()
        {
            InitializeComponent();
        }

        public void LoadInfo(int localDrivingLicenseApplicationID, int appointmentID = -1)
        {
            try
            {
                _localDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
                _testAppointmentID = appointmentID;
                _mode = (_testAppointmentID == -1) ? enMode.AddNew : enMode.Update;

                _localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(_localDrivingLicenseApplicationID);

                if (_localDrivingLicenseApplication == null)
                {
                    MessageBox.Show($"Error: No Local Driving License Application with ID = {_localDrivingLicenseApplicationID}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSave.Enabled = false;
                    return;
                }

                _creationMode = _localDrivingLicenseApplication.DoesAttendTestType(_testTypeID)
                    ? enCreationMode.RetakeTestSchedule
                    : enCreationMode.FirstTimeSchedule;

                _SetupRetakeTestUI();
                _LoadApplicationHeaderInfo();

                if (_mode == enMode.AddNew)
                {
                    if (!_InitAddNewMode())
                        return;
                }
                else
                {
                    if (!_LoadTestAppointmentData())
                        return;
                }

                _CalculateTotalFees();

                if (!_ValidateConstraints())
                    return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred while loading data: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
            }
        }

        private void _UpdateTestTypeUI()
        {
            switch (_testTypeID)
            {
                case clsTestType.enTestType.VisionTest:
                    gbTestType.Text = "Vision Test";
                    pbTestTypeImage.Image = Resources.Vision_512;
                    break;

                case clsTestType.enTestType.WrittenTest:
                    gbTestType.Text = "Written Test";
                    pbTestTypeImage.Image = Resources.Written_Test_512;
                    break;

                case clsTestType.enTestType.StreetTest:
                    gbTestType.Text = "Street Test";
                    pbTestTypeImage.Image = Resources.driving_test_512;
                    break;
            }
        }

        private void _LoadApplicationHeaderInfo()
        {
            lblLocalDrivingLicenseAppID.Text = _localDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lblFullName.Text = _localDrivingLicenseApplication.PersonFullName;
            lblTrial.Text = _localDrivingLicenseApplication.TotalTrialsPerTest(_testTypeID).ToString();
        }

        private void _SetupRetakeTestUI()
        {
            if (_creationMode == enCreationMode.RetakeTestSchedule)
            {
                clsApplicationType retakeAppType = clsApplicationType.Find((int)clsApplication.enApplicationType.RetakeTest);
                _retakeAppFees = retakeAppType != null ? Convert.ToSingle(retakeAppType.Fees) : 0;

                lblRetakeAppFees.Text = _retakeAppFees.ToString("0.##");
                gbRetakeTestInfo.Enabled = true;
                lblTitle.Text = "Schedule Retake Test";
                lblRetakeTestAppID.Text = "N/A";
            }
            else
            {
                _retakeAppFees = 0;
                gbRetakeTestInfo.Enabled = false;
                lblTitle.Text = "Schedule Test";
                lblRetakeAppFees.Text = "0";
                lblRetakeTestAppID.Text = "N/A";
            }
        }

        private bool _InitAddNewMode()
        {
            clsTestType testType = clsTestType.Find(_testTypeID);
            if (testType == null)
            {
                MessageBox.Show("Error: Test type not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return false;
            }

            _testTypeFees = Convert.ToSingle(testType.Fees);
            lblFees.Text = _testTypeFees.ToString("0.##");
            lblRetakeTestAppID.Text = "N/A";

            _SetSafeMinDate(DateTime.Now);
            _testAppointment = new clsTestAppointment();
            return true;
        }

        private bool _LoadTestAppointmentData()
        {
            _testAppointment = clsTestAppointment.Find(_testAppointmentID);
            if (_testAppointment == null)
            {
                MessageBox.Show($"Error: No Appointment with ID = {_testAppointmentID}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return false;
            }

            _testTypeFees = _testAppointment.PaidFees;
            lblFees.Text = _testTypeFees.ToString("0.##");

            if (DateTime.Compare(DateTime.Now, _testAppointment.AppointmentDate) < 0)
                _SetSafeMinDate(DateTime.Now);
            else
                _SetSafeMinDate(_testAppointment.AppointmentDate);

            dtpTestDate.Value = _testAppointment.AppointmentDate;

            if (_testAppointment.RetakeTestApplicationID == -1)
            {
                _retakeAppFees = 0;
                lblRetakeAppFees.Text = "0";
                lblRetakeTestAppID.Text = "N/A";
            }
            else
            {
                _retakeAppFees = _testAppointment.RetakeTestAppInfo != null ? Convert.ToSingle(_testAppointment.RetakeTestAppInfo.PaidFees) : 0;

                lblRetakeAppFees.Text = _retakeAppFees.ToString("0.##");
                gbRetakeTestInfo.Enabled = true;
                lblTitle.Text = "Schedule Retake Test";
                lblRetakeTestAppID.Text = _testAppointment.RetakeTestApplicationID.ToString();
            }

            return true;
        }

        private void _SetSafeMinDate(DateTime targetMinDate)
        {
            if (dtpTestDate.Value < targetMinDate)
                dtpTestDate.Value = targetMinDate;

            dtpTestDate.MinDate = targetMinDate;
        }

        private void _CalculateTotalFees()
        {
            lblTotalFees.Text = (_testTypeFees + _retakeAppFees).ToString("0.##");
        }

        private bool _ValidateConstraints()
        {
            return _HandleActiveTestAppointmentConstraint()
                && _HandleAppointmentLockedConstraint()
                && _HandlePreviousTestConstraint();
        }

        private bool _HandleActiveTestAppointmentConstraint()
        {
            if (_mode == enMode.AddNew && clsLocalDrivingLicenseApplication.IsThereAnActiveScheduledTest(_localDrivingLicenseApplicationID, _testTypeID))
            {
                lblUserMessage.Text = "Person already has an active appointment for this test";
                lblUserMessage.Visible = true;
                btnSave.Enabled = false;
                dtpTestDate.Enabled = false;
                return false;
            }
            return true;
        }

        private bool _HandleAppointmentLockedConstraint()
        {
            if (_testAppointment != null && _testAppointment.IsLocked)
            {
                lblUserMessage.Text = "Person already sat for the test, appointment Locked.";
                lblUserMessage.Visible = true;
                dtpTestDate.Enabled = false;
                btnSave.Enabled = false;
                return false;
            }

            lblUserMessage.Visible = false;
            return true;
        }

        private bool _HandlePreviousTestConstraint()
        {
            if (_localDrivingLicenseApplication == null) return false;

            switch (_testTypeID)
            {
                case clsTestType.enTestType.VisionTest:
                    lblUserMessage.Visible = false;
                    return true;

                case clsTestType.enTestType.WrittenTest:
                    if (!_localDrivingLicenseApplication.DoesPassTestType(clsTestType.enTestType.VisionTest))
                    {
                        lblUserMessage.Text = "Cannot Schedule, Vision Test should be passed first";
                        lblUserMessage.Visible = true;
                        btnSave.Enabled = false;
                        dtpTestDate.Enabled = false;
                        return false;
                    }
                    lblUserMessage.Visible = false;
                    btnSave.Enabled = true;
                    dtpTestDate.Enabled = true;
                    return true;

                case clsTestType.enTestType.StreetTest:
                    if (!_localDrivingLicenseApplication.DoesPassTestType(clsTestType.enTestType.WrittenTest))
                    {
                        lblUserMessage.Text = "Cannot Schedule, Written Test should be passed first";
                        lblUserMessage.Visible = true;
                        btnSave.Enabled = false;
                        dtpTestDate.Enabled = false;
                        return false;
                    }
                    lblUserMessage.Visible = false;
                    btnSave.Enabled = true;
                    dtpTestDate.Enabled = true;
                    return true;

                default:
                    return true;
            }
        }

        private bool _HandleRetakeApplication()
        {
            if (_mode == enMode.AddNew && _creationMode == enCreationMode.RetakeTestSchedule)
            {
                clsApplicationType retakeAppType = clsApplicationType.Find((int)clsApplication.enApplicationType.RetakeTest);
                if (retakeAppType == null)
                {
                    MessageBox.Show("Failed to load Retake Test Application Type details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                clsApplication application = new clsApplication
                {
                    ApplicantPersonID = _localDrivingLicenseApplication.ApplicantPersonID,
                    ApplicationDate = DateTime.Now,
                    ApplicationTypeID = (int)clsApplication.enApplicationType.RetakeTest,
                    ApplicationStatus = clsApplication.enApplicationStatus.Completed,
                    LastStatusDate = DateTime.Now,
                    PaidFees = retakeAppType.Fees,
                    CreatedByUserID = clsGlobal.CurrentUser != null ? clsGlobal.CurrentUser.UserID : -1
                };

                if (!application.Save())
                {
                    _testAppointment.RetakeTestApplicationID = -1;
                    MessageBox.Show("Failed to create retake test application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                _testAppointment.RetakeTestApplicationID = application.ApplicationID;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (_localDrivingLicenseApplication == null || _testAppointment == null)
                {
                    MessageBox.Show("Invalid state. Cannot save appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!_HandleRetakeApplication())
                    return;

                _testAppointment.TestTypeID = _testTypeID;
                _testAppointment.LocalDrivingLicenseApplicationID = _localDrivingLicenseApplication.LocalDrivingLicenseApplicationID;
                _testAppointment.AppointmentDate = dtpTestDate.Value;
                _testAppointment.PaidFees = _testTypeFees;
                _testAppointment.CreatedByUserID = clsGlobal.CurrentUser != null ? clsGlobal.CurrentUser.UserID : -1;

                if (_testAppointment.Save())
                {
                    _mode = enMode.Update;
                    MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error: Data was not saved successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}