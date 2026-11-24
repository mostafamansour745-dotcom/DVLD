
using DVLD_Business;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DVLD.Licenses.Local_Licenses.Controls
{
    public partial class ctrlDriverLicenseInfoWithFilter : UserControl
    {
        // Event triggered when a license is selected
        public event Action<int> OnLicenseSelected;

        // Protected method to raise the OnLicenseSelected event
        protected virtual void LicenseSelected(int licenseID)
        {
            OnLicenseSelected?.Invoke(licenseID);
        }

        private bool _filterEnabled = true;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool FilterEnabled
        {
            get => _filterEnabled;
            set
            {
                _filterEnabled = value;
                gbFilters.Enabled = _filterEnabled;
            }
        }

        private int _licenseID = -1;

        public int LicenseID => ctrlDriverLicenseInfo1.LicenseID;

        public clsLicense SelectedLicenseInfo => ctrlDriverLicenseInfo1.SelectedLicenseInfo;

        public ctrlDriverLicenseInfoWithFilter()
        {
            InitializeComponent();
        }

        public void LoadLicenseInfo(int licenseID)
        {
            txtLicenseID.Text = licenseID.ToString();
            ctrlDriverLicenseInfo1.LoadInfo(licenseID);
            _licenseID = ctrlDriverLicenseInfo1.LicenseID;

            if (OnLicenseSelected != null && FilterEnabled && _licenseID != -1)
            {
                OnLicenseSelected(_licenseID);
            }
        }

        private void txtLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numbers and control keys (such as Backspace)
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            // Pressing Enter triggers the Find button
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnFind.PerformClick();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show(
                    "Some fields are not valid! Hover over the red icon(s) to view the error.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                txtLicenseID.Focus();
                return;
            }

            _licenseID = int.Parse(txtLicenseID.Text.Trim());
            LoadLicenseInfo(_licenseID);
        }

        public void txtLicenseIDFocus()
        {
            txtLicenseID.Focus();
        }

        private void txtLicenseID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLicenseID.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtLicenseID, "This field is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLicenseID, null);
            }
        }
    }
}