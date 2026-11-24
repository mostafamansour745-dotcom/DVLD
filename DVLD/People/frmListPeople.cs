using DVLD_Business;
using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLD.People
{
    public partial class frmListPeople : Form
    {
        private DataTable _dtAllPeople;
        private DataTable _dtPeople;

        public frmListPeople()
        {
            InitializeComponent();
        }

        private void _RefreshPeopleList()
        {
            _dtAllPeople = clsPerson.GetAllPeople();

            if (_dtAllPeople != null)
            {
                _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                           "FirstName", "SecondName", "ThirdName", "LastName",
                                                           "GendorCaption", "DateOfBirth", "CountryName",
                                                           "Phone", "Email");

                dgvPeople.DataSource = _dtPeople;
                lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();
            }
        }

        private void frmListPeople_Load(object sender, EventArgs e)
        {
            _RefreshPeopleList();

            cbFilterBy.SelectedIndex = 0;

            dgvPeople.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvPeople.Columns.Count > 0)
            {
                dgvPeople.Columns[0].HeaderText = "Person ID";
                dgvPeople.Columns[0].FillWeight = 55;

                dgvPeople.Columns[1].HeaderText = "National No.";
                dgvPeople.Columns[1].FillWeight = 75;

                dgvPeople.Columns[2].HeaderText = "First Name";
                dgvPeople.Columns[2].FillWeight = 80;

                dgvPeople.Columns[3].HeaderText = "Second Name";
                dgvPeople.Columns[3].FillWeight = 80;

                dgvPeople.Columns[4].HeaderText = "Third Name";
                dgvPeople.Columns[4].FillWeight = 80;

                dgvPeople.Columns[5].HeaderText = "Last Name";
                dgvPeople.Columns[5].FillWeight = 80;

                dgvPeople.Columns[6].HeaderText = "Gendor";
                dgvPeople.Columns[6].FillWeight = 55;

                dgvPeople.Columns[7].HeaderText = "Date Of Birth";
                dgvPeople.Columns[7].FillWeight = 85;

                dgvPeople.Columns[8].HeaderText = "Nationality";
                dgvPeople.Columns[8].FillWeight = 85;

                dgvPeople.Columns[9].HeaderText = "Phone";
                dgvPeople.Columns[9].FillWeight = 85;

                dgvPeople.Columns[10].HeaderText = "Email";
                dgvPeople.Columns[10].FillWeight = 140;
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string filterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "Person ID": filterColumn = "PersonID"; break;
                case "National No.": filterColumn = "NationalNo"; break;
                case "First Name": filterColumn = "FirstName"; break;
                case "Second Name": filterColumn = "SecondName"; break;
                case "Third Name": filterColumn = "ThirdName"; break;
                case "Last Name": filterColumn = "LastName"; break;
                case "Nationality": filterColumn = "CountryName"; break;
                case "Gendor": filterColumn = "GendorCaption"; break;
                case "Phone": filterColumn = "Phone"; break;
                case "Email": filterColumn = "Email"; break;
                default: filterColumn = "None"; break;
            }

            if (string.IsNullOrWhiteSpace(txtFilterValue.Text) || filterColumn == "None")
            {
                _dtPeople.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();
                return;
            }

            if (filterColumn == "PersonID")
            {
                if (int.TryParse(txtFilterValue.Text.Trim(), out int personID))
                    _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, personID);
                else
                    _dtPeople.DefaultView.RowFilter = "";
            }
            else
            {
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, txtFilterValue.Text.Trim().Replace("'", "''"));
            }

            lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");

            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
            else
            {
                txtFilterValue.Text = "";
                _dtPeople.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPeople.CurrentRow == null) return;

            int personID = (int)dgvPeople.CurrentRow.Cells[0].Value;
            Form frm = new frmShowPersonInfo(personID);
            frm.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPeople.CurrentRow == null) return;

            Form frm = new frmAddUpdatePerson((int)dgvPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            _RefreshPeopleList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPeople.CurrentRow == null) return;

            int personID = (int)dgvPeople.CurrentRow.Cells[0].Value;

            if (MessageBox.Show($"Are you sure you want to delete Person [{personID}]?", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsPerson.DeletePerson(personID))
                {
                    MessageBox.Show("Person Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshPeopleList();
                }
                else
                {
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _AddNewPerson();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            _AddNewPerson();
        }

        private void _AddNewPerson()
        {
            Form frm = new frmAddUpdatePerson();
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void dgvPeople_DoubleClick(object sender, EventArgs e)
        {
            if (dgvPeople.CurrentRow == null) return;

            Form frm = new frmShowPersonInfo((int)dgvPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPeople_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvPeople.ClearSelection();
                dgvPeople.Rows[e.RowIndex].Selected = true;

                if (e.ColumnIndex >= 0)
                    dgvPeople.CurrentCell = dgvPeople.Rows[e.RowIndex].Cells[e.ColumnIndex];
                else
                    dgvPeople.CurrentCell = dgvPeople.Rows[e.RowIndex].Cells[0];
            }
        }


    }
}