using System;
using System.Windows.Forms;
using DVLD.GlobalClasses;
using DVLD_Business;

namespace DVLD.Tests
{
    public partial class frmTakeTest : Form
    {
        private int _AppointmentID;
        private clsTestType.enTestType _TestType;

        private int _TestID = -1;
        private clsTest _Test;

        public frmTakeTest(int AppointmentID, clsTestType.enTestType TestType)
        {
            InitializeComponent();
            _AppointmentID = AppointmentID;
            _TestType = TestType;
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            // 1. Disable Save button by default until data is fully validated
            btnSave.Enabled = false;

            ctrlSecheduledTest1.TestTypeID = _TestType;
            ctrlSecheduledTest1.LoadInfo(_AppointmentID);

            // 2. Check if the appointment info loaded successfully
            if (ctrlSecheduledTest1.TestAppointmentID == -1)
            {
                MessageBox.Show("Error: Could not load appointment information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _TestID = ctrlSecheduledTest1.TestID;

            // 3. If test has already been taken
            if (_TestID != -1)
            {
                _Test = clsTest.Find(_TestID);

                if (_Test == null)
                {
                    MessageBox.Show("Error: Could not find Test data in database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (_Test.TestResult)
                    rbPass.Checked = true;
                else
                    rbFail.Checked = true;

                txtNotes.Text = _Test.Notes;

                lblUserMessage.Visible = true;
                rbFail.Enabled = false;
                rbPass.Enabled = false;
                txtNotes.Enabled = false;
                btnSave.Enabled = false;
            }
            else // 4. New test (not taken yet)
            {
                _Test = new clsTest(); // Initialize object safely
                btnSave.Enabled = true; // Enable save only when data is valid
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_Test == null)
            {
                MessageBox.Show("Error: Test object is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to save? After that you cannot change the Pass/Fail results.",
                        "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            _Test.TestAppointmentID = _AppointmentID;
            _Test.TestResult = rbPass.Checked;
            _Test.Notes = txtNotes.Text.Trim();
            _Test.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (_Test.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = false;
                rbPass.Enabled = false;
                rbFail.Enabled = false;
                txtNotes.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}