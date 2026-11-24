using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD.People.Controls
{
    partial class ctrlPersonCard
    {
        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            llEditPersonInfo = new LinkLabel();
            pbPersonImage = new PictureBox();
            lblCountry = new Label();
            pbCountryIcon = new PictureBox();
            lblCountryTag = new Label();
            lblPhone = new Label();
            pbPhoneIcon = new PictureBox();
            lblPhoneTag = new Label();
            lblDateOfBirth = new Label();
            pbDateOfBirthIcon = new PictureBox();
            lblDateOfBirthTag = new Label();
            lblAddress = new Label();
            pbAddressIcon = new PictureBox();
            lblAddressTag = new Label();
            lblEmail = new Label();
            pbEmailIcon = new PictureBox();
            lblEmailTag = new Label();
            lblGendor = new Label();
            pbGendorIcon = new PictureBox();
            lblGendorTag = new Label();
            lblNationalNo = new Label();
            pbNationalNoIcon = new PictureBox();
            lblNationalNoTag = new Label();
            lblName = new Label();
            pbNameIcon = new PictureBox();
            lblNameTag = new Label();
            lblPersonID = new Label();
            pbPersonIDIcon = new PictureBox();
            lblPersonIDTag = new Label();
            groupBox1.SuspendLayout();
            ((ISupportInitialize)pbPersonImage).BeginInit();
            ((ISupportInitialize)pbCountryIcon).BeginInit();
            ((ISupportInitialize)pbPhoneIcon).BeginInit();
            ((ISupportInitialize)pbDateOfBirthIcon).BeginInit();
            ((ISupportInitialize)pbAddressIcon).BeginInit();
            ((ISupportInitialize)pbEmailIcon).BeginInit();
            ((ISupportInitialize)pbGendorIcon).BeginInit();
            ((ISupportInitialize)pbNationalNoIcon).BeginInit();
            ((ISupportInitialize)pbNameIcon).BeginInit();
            ((ISupportInitialize)pbPersonIDIcon).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(30, 30, 36);
            groupBox1.Controls.Add(llEditPersonInfo);
            groupBox1.Controls.Add(pbPersonImage);
            groupBox1.Controls.Add(lblCountry);
            groupBox1.Controls.Add(pbCountryIcon);
            groupBox1.Controls.Add(lblCountryTag);
            groupBox1.Controls.Add(lblPhone);
            groupBox1.Controls.Add(pbPhoneIcon);
            groupBox1.Controls.Add(lblPhoneTag);
            groupBox1.Controls.Add(lblDateOfBirth);
            groupBox1.Controls.Add(pbDateOfBirthIcon);
            groupBox1.Controls.Add(lblDateOfBirthTag);
            groupBox1.Controls.Add(lblAddress);
            groupBox1.Controls.Add(pbAddressIcon);
            groupBox1.Controls.Add(lblAddressTag);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Controls.Add(pbEmailIcon);
            groupBox1.Controls.Add(lblEmailTag);
            groupBox1.Controls.Add(lblGendor);
            groupBox1.Controls.Add(pbGendorIcon);
            groupBox1.Controls.Add(lblGendorTag);
            groupBox1.Controls.Add(lblNationalNo);
            groupBox1.Controls.Add(pbNationalNoIcon);
            groupBox1.Controls.Add(lblNationalNoTag);
            groupBox1.Controls.Add(lblName);
            groupBox1.Controls.Add(pbNameIcon);
            groupBox1.Controls.Add(lblNameTag);
            groupBox1.Controls.Add(lblPersonID);
            groupBox1.Controls.Add(pbPersonIDIcon);
            groupBox1.Controls.Add(lblPersonIDTag);
            groupBox1.Font = new Font("Segoe UI", 9.5F);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(6, 6);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(730, 300);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Person Information";
            // 
            // llEditPersonInfo
            // 
            llEditPersonInfo.AutoSize = true;
            llEditPersonInfo.Enabled = false;
            llEditPersonInfo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            llEditPersonInfo.LinkColor = Color.FromArgb(212, 175, 55);
            llEditPersonInfo.Location = new Point(578, 33);
            llEditPersonInfo.Name = "llEditPersonInfo";
            llEditPersonInfo.Size = new Size(120, 21);
            llEditPersonInfo.TabIndex = 18;
            llEditPersonInfo.TabStop = true;
            llEditPersonInfo.Text = "Edit Person Info";
            llEditPersonInfo.LinkClicked += llEditPersonInfo_LinkClicked;
            // 
            // pbPersonImage
            // 
            pbPersonImage.BorderStyle = BorderStyle.FixedSingle;
            pbPersonImage.Image = Properties.Resources.Male_5121;
            pbPersonImage.Location = new Point(563, 73);
            pbPersonImage.Margin = new Padding(3, 4, 3, 4);
            pbPersonImage.Name = "pbPersonImage";
            pbPersonImage.Size = new Size(138, 160);
            pbPersonImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbPersonImage.TabIndex = 19;
            pbPersonImage.TabStop = false;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Font = new Font("Segoe UI", 9.5F);
            lblCountry.Location = new Point(445, 190);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(48, 21);
            lblCountry.TabIndex = 17;
            lblCountry.Text = "[????]";
            // 
            // pbCountryIcon
            // 
            pbCountryIcon.Image = Properties.Resources.Country_32;
            pbCountryIcon.Location = new Point(408, 186);
            pbCountryIcon.Margin = new Padding(3, 4, 3, 4);
            pbCountryIcon.Name = "pbCountryIcon";
            pbCountryIcon.Size = new Size(24, 28);
            pbCountryIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbCountryIcon.TabIndex = 20;
            pbCountryIcon.TabStop = false;
            // 
            // lblCountryTag
            // 
            lblCountryTag.AutoSize = true;
            lblCountryTag.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCountryTag.Location = new Point(315, 190);
            lblCountryTag.Name = "lblCountryTag";
            lblCountryTag.Size = new Size(76, 21);
            lblCountryTag.TabIndex = 16;
            lblCountryTag.Text = "Country:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 9.5F);
            lblPhone.Location = new Point(445, 150);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(48, 21);
            lblPhone.TabIndex = 15;
            lblPhone.Text = "[????]";
            // 
            // pbPhoneIcon
            // 
            pbPhoneIcon.Image = Properties.Resources.Phone_322;
            pbPhoneIcon.Location = new Point(408, 146);
            pbPhoneIcon.Margin = new Padding(3, 4, 3, 4);
            pbPhoneIcon.Name = "pbPhoneIcon";
            pbPhoneIcon.Size = new Size(24, 28);
            pbPhoneIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbPhoneIcon.TabIndex = 21;
            pbPhoneIcon.TabStop = false;
            // 
            // lblPhoneTag
            // 
            lblPhoneTag.AutoSize = true;
            lblPhoneTag.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPhoneTag.Location = new Point(315, 150);
            lblPhoneTag.Name = "lblPhoneTag";
            lblPhoneTag.Size = new Size(63, 21);
            lblPhoneTag.TabIndex = 14;
            lblPhoneTag.Text = "Phone:";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Font = new Font("Segoe UI", 9.5F);
            lblDateOfBirth.Location = new Point(445, 110);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(48, 21);
            lblDateOfBirth.TabIndex = 13;
            lblDateOfBirth.Text = "[????]";
            // 
            // pbDateOfBirthIcon
            // 
            pbDateOfBirthIcon.Image = Properties.Resources.Calendar_322;
            pbDateOfBirthIcon.Location = new Point(408, 106);
            pbDateOfBirthIcon.Margin = new Padding(3, 4, 3, 4);
            pbDateOfBirthIcon.Name = "pbDateOfBirthIcon";
            pbDateOfBirthIcon.Size = new Size(24, 28);
            pbDateOfBirthIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbDateOfBirthIcon.TabIndex = 22;
            pbDateOfBirthIcon.TabStop = false;
            // 
            // lblDateOfBirthTag
            // 
            lblDateOfBirthTag.AutoSize = true;
            lblDateOfBirthTag.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblDateOfBirthTag.Location = new Point(315, 110);
            lblDateOfBirthTag.Name = "lblDateOfBirthTag";
            lblDateOfBirthTag.Size = new Size(113, 21);
            lblDateOfBirthTag.TabIndex = 12;
            lblDateOfBirthTag.Text = "Date Of Birth:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 9.5F);
            lblAddress.Location = new Point(138, 233);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(48, 21);
            lblAddress.TabIndex = 11;
            lblAddress.Text = "[????]";
            // 
            // pbAddressIcon
            // 
            pbAddressIcon.Image = Properties.Resources.Address_32;
            pbAddressIcon.Location = new Point(103, 229);
            pbAddressIcon.Margin = new Padding(3, 4, 3, 4);
            pbAddressIcon.Name = "pbAddressIcon";
            pbAddressIcon.Size = new Size(24, 28);
            pbAddressIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbAddressIcon.TabIndex = 23;
            pbAddressIcon.TabStop = false;
            // 
            // lblAddressTag
            // 
            lblAddressTag.AutoSize = true;
            lblAddressTag.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblAddressTag.Location = new Point(15, 233);
            lblAddressTag.Name = "lblAddressTag";
            lblAddressTag.Size = new Size(74, 21);
            lblAddressTag.TabIndex = 10;
            lblAddressTag.Text = "Address:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9.5F);
            lblEmail.Location = new Point(138, 190);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 21);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "[????]";
            // 
            // pbEmailIcon
            // 
            pbEmailIcon.Image = Properties.Resources.Email_32;
            pbEmailIcon.Location = new Point(103, 186);
            pbEmailIcon.Margin = new Padding(3, 4, 3, 4);
            pbEmailIcon.Name = "pbEmailIcon";
            pbEmailIcon.Size = new Size(24, 28);
            pbEmailIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbEmailIcon.TabIndex = 24;
            pbEmailIcon.TabStop = false;
            // 
            // lblEmailTag
            // 
            lblEmailTag.AutoSize = true;
            lblEmailTag.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblEmailTag.Location = new Point(15, 190);
            lblEmailTag.Name = "lblEmailTag";
            lblEmailTag.Size = new Size(57, 21);
            lblEmailTag.TabIndex = 8;
            lblEmailTag.Text = "Email:";
            // 
            // lblGendor
            // 
            lblGendor.AutoSize = true;
            lblGendor.Font = new Font("Segoe UI", 9.5F);
            lblGendor.Location = new Point(138, 150);
            lblGendor.Name = "lblGendor";
            lblGendor.Size = new Size(48, 21);
            lblGendor.TabIndex = 7;
            lblGendor.Text = "[????]";
            // 
            // pbGendorIcon
            // 
            pbGendorIcon.Image = Properties.Resources.Man_321;
            pbGendorIcon.Location = new Point(103, 146);
            pbGendorIcon.Margin = new Padding(3, 4, 3, 4);
            pbGendorIcon.Name = "pbGendorIcon";
            pbGendorIcon.Size = new Size(24, 28);
            pbGendorIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbGendorIcon.TabIndex = 25;
            pbGendorIcon.TabStop = false;
            // 
            // lblGendorTag
            // 
            lblGendorTag.AutoSize = true;
            lblGendorTag.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblGendorTag.Location = new Point(15, 150);
            lblGendorTag.Name = "lblGendorTag";
            lblGendorTag.Size = new Size(71, 21);
            lblGendorTag.TabIndex = 6;
            lblGendorTag.Text = "Gendor:";
            // 
            // lblNationalNo
            // 
            lblNationalNo.AutoSize = true;
            lblNationalNo.Font = new Font("Segoe UI", 9.5F);
            lblNationalNo.Location = new Point(138, 110);
            lblNationalNo.Name = "lblNationalNo";
            lblNationalNo.Size = new Size(48, 21);
            lblNationalNo.TabIndex = 5;
            lblNationalNo.Text = "[????]";
            // 
            // pbNationalNoIcon
            // 
            pbNationalNoIcon.Image = Properties.Resources.Number_32;
            pbNationalNoIcon.Location = new Point(103, 106);
            pbNationalNoIcon.Margin = new Padding(3, 4, 3, 4);
            pbNationalNoIcon.Name = "pbNationalNoIcon";
            pbNationalNoIcon.Size = new Size(24, 28);
            pbNationalNoIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbNationalNoIcon.TabIndex = 26;
            pbNationalNoIcon.TabStop = false;
            // 
            // lblNationalNoTag
            // 
            lblNationalNoTag.AutoSize = true;
            lblNationalNoTag.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblNationalNoTag.Location = new Point(15, 110);
            lblNationalNoTag.Name = "lblNationalNoTag";
            lblNationalNoTag.Size = new Size(108, 21);
            lblNationalNoTag.TabIndex = 4;
            lblNationalNoTag.Text = "National No:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(235, 87, 87);
            lblName.Location = new Point(138, 70);
            lblName.Name = "lblName";
            lblName.Size = new Size(50, 21);
            lblName.TabIndex = 3;
            lblName.Text = "[????]";
            // 
            // pbNameIcon
            // 
            pbNameIcon.Image = Properties.Resources.Person_32;
            pbNameIcon.Location = new Point(103, 66);
            pbNameIcon.Margin = new Padding(3, 4, 3, 4);
            pbNameIcon.Name = "pbNameIcon";
            pbNameIcon.Size = new Size(24, 28);
            pbNameIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbNameIcon.TabIndex = 27;
            pbNameIcon.TabStop = false;
            // 
            // lblNameTag
            // 
            lblNameTag.AutoSize = true;
            lblNameTag.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblNameTag.Location = new Point(15, 70);
            lblNameTag.Name = "lblNameTag";
            lblNameTag.Size = new Size(60, 21);
            lblNameTag.TabIndex = 2;
            lblNameTag.Text = "Name:";
            // 
            // lblPersonID
            // 
            lblPersonID.AutoSize = true;
            lblPersonID.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPersonID.ForeColor = Color.FromArgb(212, 175, 55);
            lblPersonID.Location = new Point(138, 33);
            lblPersonID.Name = "lblPersonID";
            lblPersonID.Size = new Size(50, 21);
            lblPersonID.TabIndex = 1;
            lblPersonID.Text = "[????]";
            // 
            // pbPersonIDIcon
            // 
            pbPersonIDIcon.Image = Properties.Resources.Number_32;
            pbPersonIDIcon.Location = new Point(103, 29);
            pbPersonIDIcon.Margin = new Padding(3, 4, 3, 4);
            pbPersonIDIcon.Name = "pbPersonIDIcon";
            pbPersonIDIcon.Size = new Size(24, 28);
            pbPersonIDIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbPersonIDIcon.TabIndex = 28;
            pbPersonIDIcon.TabStop = false;
            // 
            // lblPersonIDTag
            // 
            lblPersonIDTag.AutoSize = true;
            lblPersonIDTag.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPersonIDTag.Location = new Point(15, 33);
            lblPersonIDTag.Name = "lblPersonIDTag";
            lblPersonIDTag.Size = new Size(87, 21);
            lblPersonIDTag.TabIndex = 0;
            lblPersonIDTag.Text = "Person ID:";
            // 
            // ctrlPersonCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 30);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ctrlPersonCard";
            Size = new Size(742, 312);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((ISupportInitialize)pbPersonImage).EndInit();
            ((ISupportInitialize)pbCountryIcon).EndInit();
            ((ISupportInitialize)pbPhoneIcon).EndInit();
            ((ISupportInitialize)pbDateOfBirthIcon).EndInit();
            ((ISupportInitialize)pbAddressIcon).EndInit();
            ((ISupportInitialize)pbEmailIcon).EndInit();
            ((ISupportInitialize)pbGendorIcon).EndInit();
            ((ISupportInitialize)pbNationalNoIcon).EndInit();
            ((ISupportInitialize)pbNameIcon).EndInit();
            ((ISupportInitialize)pbPersonIDIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblPersonIDTag;
        private PictureBox pbPersonIDIcon;
        private Label lblPersonID;
        private Label lblNameTag;
        private PictureBox pbNameIcon;
        private Label lblName;
        private Label lblNationalNoTag;
        private PictureBox pbNationalNoIcon;
        private Label lblNationalNo;
        private Label lblGendorTag;
        private PictureBox pbGendorIcon;
        private Label lblGendor;
        private Label lblEmailTag;
        private PictureBox pbEmailIcon;
        private Label lblEmail;
        private Label lblAddressTag;
        private PictureBox pbAddressIcon;
        private Label lblAddress;
        private Label lblDateOfBirthTag;
        private PictureBox pbDateOfBirthIcon;
        private Label lblDateOfBirth;
        private Label lblPhoneTag;
        private PictureBox pbPhoneIcon;
        private Label lblPhone;
        private Label lblCountryTag;
        private PictureBox pbCountryIcon;
        private Label lblCountry;
        private LinkLabel llEditPersonInfo;
        private PictureBox pbPersonImage;
    }
}