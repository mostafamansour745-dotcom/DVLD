using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD.People
{
    partial class frmAddUpdatePerson
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(frmAddUpdatePerson));
            lblTitle = new Label();
            lblPersonIDTag = new Label();
            lblPersonID = new Label();
            pbPersonIDIcon = new PictureBox();
            groupBox1 = new GroupBox();
            lblFirst = new Label();
            lblSecond = new Label();
            lblThird = new Label();
            lblLast = new Label();
            lblName = new Label();
            pbNameIcon = new PictureBox();
            txtFirstName = new TextBox();
            txtSecondName = new TextBox();
            txtThirdName = new TextBox();
            txtLastName = new TextBox();
            lblNationalNo = new Label();
            pbNationalNoIcon = new PictureBox();
            txtNationalNo = new TextBox();
            lblGendor = new Label();
            pbGendorMaleIcon = new PictureBox();
            rbMale = new RadioButton();
            pbGendorFemaleIcon = new PictureBox();
            rbFemale = new RadioButton();
            lblEmail = new Label();
            pbEmailIcon = new PictureBox();
            txtEmail = new TextBox();
            lblAddress = new Label();
            pbAddressIcon = new PictureBox();
            txtAddress = new TextBox();
            lblDateOfBirth = new Label();
            pbDateOfBirthIcon = new PictureBox();
            dtpDateOfBirth = new DateTimePicker();
            lblPhone = new Label();
            pbPhoneIcon = new PictureBox();
            txtPhone = new TextBox();
            lblCountry = new Label();
            pbCountryIcon = new PictureBox();
            cbCountry = new ComboBox();
            pbPersonImage = new PictureBox();
            llSetImage = new LinkLabel();
            llRemoveImage = new LinkLabel();
            btnClose = new Button();
            btnSave = new Button();
            openFileDialog1 = new OpenFileDialog();
            errorProvider1 = new ErrorProvider(components);
            ((ISupportInitialize)pbPersonIDIcon).BeginInit();
            groupBox1.SuspendLayout();
            ((ISupportInitialize)pbNameIcon).BeginInit();
            ((ISupportInitialize)pbNationalNoIcon).BeginInit();
            ((ISupportInitialize)pbGendorMaleIcon).BeginInit();
            ((ISupportInitialize)pbGendorFemaleIcon).BeginInit();
            ((ISupportInitialize)pbEmailIcon).BeginInit();
            ((ISupportInitialize)pbAddressIcon).BeginInit();
            ((ISupportInitialize)pbDateOfBirthIcon).BeginInit();
            ((ISupportInitialize)pbPhoneIcon).BeginInit();
            ((ISupportInitialize)pbCountryIcon).BeginInit();
            ((ISupportInitialize)pbPersonImage).BeginInit();
            ((ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(212, 175, 55);
            lblTitle.Location = new Point(309, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(311, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add New Person";
            // 
            // lblPersonIDTag
            // 
            lblPersonIDTag.AutoSize = true;
            lblPersonIDTag.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPersonIDTag.ForeColor = Color.White;
            lblPersonIDTag.Location = new Point(29, 93);
            lblPersonIDTag.Name = "lblPersonIDTag";
            lblPersonIDTag.Size = new Size(108, 25);
            lblPersonIDTag.TabIndex = 1;
            lblPersonIDTag.Text = "Person ID :";
            // 
            // lblPersonID
            // 
            lblPersonID.AutoSize = true;
            lblPersonID.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPersonID.ForeColor = Color.FromArgb(212, 175, 55);
            lblPersonID.Location = new Point(189, 93);
            lblPersonID.Name = "lblPersonID";
            lblPersonID.Size = new Size(48, 25);
            lblPersonID.TabIndex = 2;
            lblPersonID.Text = "N/A";
            // 
            // pbPersonIDIcon
            // 
            pbPersonIDIcon.Image = Properties.Resources.Number_32;
            pbPersonIDIcon.Location = new Point(143, 91);
            pbPersonIDIcon.Margin = new Padding(3, 4, 3, 4);
            pbPersonIDIcon.Name = "pbPersonIDIcon";
            pbPersonIDIcon.Size = new Size(27, 32);
            pbPersonIDIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbPersonIDIcon.TabIndex = 6;
            pbPersonIDIcon.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(30, 30, 36);
            groupBox1.Controls.Add(lblFirst);
            groupBox1.Controls.Add(lblSecond);
            groupBox1.Controls.Add(lblThird);
            groupBox1.Controls.Add(lblLast);
            groupBox1.Controls.Add(lblName);
            groupBox1.Controls.Add(pbNameIcon);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(txtSecondName);
            groupBox1.Controls.Add(txtThirdName);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(lblNationalNo);
            groupBox1.Controls.Add(pbNationalNoIcon);
            groupBox1.Controls.Add(txtNationalNo);
            groupBox1.Controls.Add(lblGendor);
            groupBox1.Controls.Add(pbGendorMaleIcon);
            groupBox1.Controls.Add(rbMale);
            groupBox1.Controls.Add(pbGendorFemaleIcon);
            groupBox1.Controls.Add(rbFemale);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Controls.Add(pbEmailIcon);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(lblAddress);
            groupBox1.Controls.Add(pbAddressIcon);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(lblDateOfBirth);
            groupBox1.Controls.Add(pbDateOfBirthIcon);
            groupBox1.Controls.Add(dtpDateOfBirth);
            groupBox1.Controls.Add(lblPhone);
            groupBox1.Controls.Add(pbPhoneIcon);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(lblCountry);
            groupBox1.Controls.Add(pbCountryIcon);
            groupBox1.Controls.Add(cbCountry);
            groupBox1.Controls.Add(pbPersonImage);
            groupBox1.Controls.Add(llSetImage);
            groupBox1.Controls.Add(llRemoveImage);
            groupBox1.Font = new Font("Segoe UI", 9F);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(23, 140);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(880, 420);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // lblFirst
            // 
            lblFirst.AutoSize = true;
            lblFirst.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFirst.ForeColor = Color.Gray;
            lblFirst.Location = new Point(217, 27);
            lblFirst.Name = "lblFirst";
            lblFirst.Size = new Size(40, 20);
            lblFirst.TabIndex = 0;
            lblFirst.Text = "First";
            // 
            // lblSecond
            // 
            lblSecond.AutoSize = true;
            lblSecond.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSecond.ForeColor = Color.Gray;
            lblSecond.Location = new Point(383, 27);
            lblSecond.Name = "lblSecond";
            lblSecond.Size = new Size(59, 20);
            lblSecond.TabIndex = 1;
            lblSecond.Text = "Second";
            // 
            // lblThird
            // 
            lblThird.AutoSize = true;
            lblThird.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblThird.ForeColor = Color.Gray;
            lblThird.Location = new Point(549, 27);
            lblThird.Name = "lblThird";
            lblThird.Size = new Size(46, 20);
            lblThird.TabIndex = 2;
            lblThird.Text = "Third";
            // 
            // lblLast
            // 
            lblLast.AutoSize = true;
            lblLast.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLast.ForeColor = Color.Gray;
            lblLast.Location = new Point(720, 27);
            lblLast.Name = "lblLast";
            lblLast.Size = new Size(38, 20);
            lblLast.TabIndex = 3;
            lblLast.Text = "Last";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblName.Location = new Point(17, 60);
            lblName.Name = "lblName";
            lblName.Size = new Size(60, 21);
            lblName.TabIndex = 4;
            lblName.Text = "Name:";
            // 
            // pbNameIcon
            // 
            pbNameIcon.Image = Properties.Resources.Person_32;
            pbNameIcon.Location = new Point(131, 56);
            pbNameIcon.Margin = new Padding(3, 4, 3, 4);
            pbNameIcon.Name = "pbNameIcon";
            pbNameIcon.Size = new Size(27, 32);
            pbNameIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbNameIcon.TabIndex = 5;
            pbNameIcon.TabStop = false;
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.FromArgb(37, 37, 45);
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.ForeColor = Color.White;
            txtFirstName.Location = new Point(171, 56);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(148, 27);
            txtFirstName.TabIndex = 6;
            txtFirstName.Validating += ValidateEmptyTextBox;
            // 
            // txtSecondName
            // 
            txtSecondName.BackColor = Color.FromArgb(37, 37, 45);
            txtSecondName.BorderStyle = BorderStyle.FixedSingle;
            txtSecondName.ForeColor = Color.White;
            txtSecondName.Location = new Point(337, 56);
            txtSecondName.Margin = new Padding(3, 4, 3, 4);
            txtSecondName.Name = "txtSecondName";
            txtSecondName.Size = new Size(148, 27);
            txtSecondName.TabIndex = 7;
            // 
            // txtThirdName
            // 
            txtThirdName.BackColor = Color.FromArgb(37, 37, 45);
            txtThirdName.BorderStyle = BorderStyle.FixedSingle;
            txtThirdName.ForeColor = Color.White;
            txtThirdName.Location = new Point(503, 56);
            txtThirdName.Margin = new Padding(3, 4, 3, 4);
            txtThirdName.Name = "txtThirdName";
            txtThirdName.Size = new Size(148, 27);
            txtThirdName.TabIndex = 8;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(37, 37, 45);
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.ForeColor = Color.White;
            txtLastName.Location = new Point(669, 56);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(148, 27);
            txtLastName.TabIndex = 9;
            // 
            // lblNationalNo
            // 
            lblNationalNo.AutoSize = true;
            lblNationalNo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblNationalNo.Location = new Point(17, 113);
            lblNationalNo.Name = "lblNationalNo";
            lblNationalNo.Size = new Size(108, 21);
            lblNationalNo.TabIndex = 10;
            lblNationalNo.Text = "National No:";
            // 
            // pbNationalNoIcon
            // 
            pbNationalNoIcon.Image = Properties.Resources.Number_32;
            pbNationalNoIcon.Location = new Point(131, 109);
            pbNationalNoIcon.Margin = new Padding(3, 4, 3, 4);
            pbNationalNoIcon.Name = "pbNationalNoIcon";
            pbNationalNoIcon.Size = new Size(27, 32);
            pbNationalNoIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbNationalNoIcon.TabIndex = 11;
            pbNationalNoIcon.TabStop = false;
            // 
            // txtNationalNo
            // 
            txtNationalNo.BackColor = Color.FromArgb(37, 37, 45);
            txtNationalNo.BorderStyle = BorderStyle.FixedSingle;
            txtNationalNo.ForeColor = Color.White;
            txtNationalNo.Location = new Point(171, 111);
            txtNationalNo.Margin = new Padding(3, 4, 3, 4);
            txtNationalNo.Name = "txtNationalNo";
            txtNationalNo.Size = new Size(148, 27);
            txtNationalNo.TabIndex = 12;
            // 
            // lblGendor
            // 
            lblGendor.AutoSize = true;
            lblGendor.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblGendor.Location = new Point(17, 167);
            lblGendor.Name = "lblGendor";
            lblGendor.Size = new Size(71, 21);
            lblGendor.TabIndex = 13;
            lblGendor.Text = "Gendor:";
            // 
            // pbGendorMaleIcon
            // 
            pbGendorMaleIcon.Image = (Image)resources.GetObject("pbGendorMaleIcon.Image");
            pbGendorMaleIcon.Location = new Point(131, 163);
            pbGendorMaleIcon.Margin = new Padding(3, 4, 3, 4);
            pbGendorMaleIcon.Name = "pbGendorMaleIcon";
            pbGendorMaleIcon.Size = new Size(27, 32);
            pbGendorMaleIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbGendorMaleIcon.TabIndex = 14;
            pbGendorMaleIcon.TabStop = false;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Checked = true;
            rbMale.Location = new Point(166, 167);
            rbMale.Margin = new Padding(3, 4, 3, 4);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(63, 24);
            rbMale.TabIndex = 13;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.Click += rbMale_CheckedChanged;
            // 
            // pbGendorFemaleIcon
            // 
            pbGendorFemaleIcon.Image = Properties.Resources.Woman_32;
            pbGendorFemaleIcon.Location = new Point(234, 163);
            pbGendorFemaleIcon.Margin = new Padding(3, 4, 3, 4);
            pbGendorFemaleIcon.Name = "pbGendorFemaleIcon";
            pbGendorFemaleIcon.Size = new Size(27, 32);
            pbGendorFemaleIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbGendorFemaleIcon.TabIndex = 15;
            pbGendorFemaleIcon.TabStop = false;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(269, 167);
            rbFemale.Margin = new Padding(3, 4, 3, 4);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(78, 24);
            rbFemale.TabIndex = 15;
            rbFemale.Text = "Female";
            rbFemale.Click += rbMale_CheckedChanged;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblEmail.Location = new Point(17, 220);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(57, 21);
            lblEmail.TabIndex = 16;
            lblEmail.Text = "Email:";
            // 
            // pbEmailIcon
            // 
            pbEmailIcon.Image = Properties.Resources.Email_321;
            pbEmailIcon.Location = new Point(131, 216);
            pbEmailIcon.Margin = new Padding(3, 4, 3, 4);
            pbEmailIcon.Name = "pbEmailIcon";
            pbEmailIcon.Size = new Size(27, 32);
            pbEmailIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbEmailIcon.TabIndex = 17;
            pbEmailIcon.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(37, 37, 45);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.ForeColor = Color.White;
            txtEmail.Location = new Point(171, 217);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(148, 27);
            txtEmail.TabIndex = 18;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblAddress.Location = new Point(17, 273);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(74, 21);
            lblAddress.TabIndex = 19;
            lblAddress.Text = "Address:";
            // 
            // pbAddressIcon
            // 
            pbAddressIcon.Image = Properties.Resources.Address_321;
            pbAddressIcon.Location = new Point(131, 269);
            pbAddressIcon.Margin = new Padding(3, 4, 3, 4);
            pbAddressIcon.Name = "pbAddressIcon";
            pbAddressIcon.Size = new Size(27, 32);
            pbAddressIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbAddressIcon.TabIndex = 20;
            pbAddressIcon.TabStop = false;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.FromArgb(37, 37, 45);
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.ForeColor = Color.White;
            txtAddress.Location = new Point(171, 271);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(480, 113);
            txtAddress.TabIndex = 21;
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblDateOfBirth.Location = new Point(343, 113);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(113, 21);
            lblDateOfBirth.TabIndex = 22;
            lblDateOfBirth.Text = "Date Of Birth:";
            // 
            // pbDateOfBirthIcon
            // 
            pbDateOfBirthIcon.Image = Properties.Resources.Calendar_321;
            pbDateOfBirthIcon.Location = new Point(457, 109);
            pbDateOfBirthIcon.Margin = new Padding(3, 4, 3, 4);
            pbDateOfBirthIcon.Name = "pbDateOfBirthIcon";
            pbDateOfBirthIcon.Size = new Size(27, 32);
            pbDateOfBirthIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbDateOfBirthIcon.TabIndex = 23;
            pbDateOfBirthIcon.TabStop = false;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.CalendarMonthBackground = SystemColors.InactiveCaptionText;
            dtpDateOfBirth.CustomFormat = "dd/MM/yyyy";
            dtpDateOfBirth.Format = DateTimePickerFormat.Custom;
            dtpDateOfBirth.Location = new Point(503, 111);
            dtpDateOfBirth.Margin = new Padding(3, 4, 3, 4);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(148, 27);
            dtpDateOfBirth.TabIndex = 24;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPhone.Location = new Point(343, 167);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(63, 21);
            lblPhone.TabIndex = 25;
            lblPhone.Text = "Phone:";
            // 
            // pbPhoneIcon
            // 
            pbPhoneIcon.Image = Properties.Resources.Phone_321;
            pbPhoneIcon.Location = new Point(457, 163);
            pbPhoneIcon.Margin = new Padding(3, 4, 3, 4);
            pbPhoneIcon.Name = "pbPhoneIcon";
            pbPhoneIcon.Size = new Size(27, 32);
            pbPhoneIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbPhoneIcon.TabIndex = 26;
            pbPhoneIcon.TabStop = false;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.FromArgb(37, 37, 45);
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.ForeColor = Color.White;
            txtPhone.Location = new Point(503, 164);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(148, 27);
            txtPhone.TabIndex = 27;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCountry.Location = new Point(343, 220);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(76, 21);
            lblCountry.TabIndex = 28;
            lblCountry.Text = "Country:";
            // 
            // pbCountryIcon
            // 
            pbCountryIcon.Image = Properties.Resources.Country_321;
            pbCountryIcon.Location = new Point(457, 216);
            pbCountryIcon.Margin = new Padding(3, 4, 3, 4);
            pbCountryIcon.Name = "pbCountryIcon";
            pbCountryIcon.Size = new Size(27, 32);
            pbCountryIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbCountryIcon.TabIndex = 29;
            pbCountryIcon.TabStop = false;
            // 
            // cbCountry
            // 
            cbCountry.BackColor = Color.FromArgb(37, 37, 45);
            cbCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCountry.ForeColor = Color.White;
            cbCountry.FormattingEnabled = true;
            cbCountry.Location = new Point(503, 217);
            cbCountry.Margin = new Padding(3, 4, 3, 4);
            cbCountry.Name = "cbCountry";
            cbCountry.Size = new Size(148, 28);
            cbCountry.TabIndex = 30;
            // 
            // pbPersonImage
            // 
            pbPersonImage.BorderStyle = BorderStyle.FixedSingle;
            pbPersonImage.Image = Properties.Resources.Female_512;
            pbPersonImage.Location = new Point(680, 109);
            pbPersonImage.Margin = new Padding(3, 4, 3, 4);
            pbPersonImage.Name = "pbPersonImage";
            pbPersonImage.Size = new Size(165, 193);
            pbPersonImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbPersonImage.TabIndex = 31;
            pbPersonImage.TabStop = false;
            // 
            // llSetImage
            // 
            llSetImage.AutoSize = true;
            llSetImage.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            llSetImage.LinkColor = Color.FromArgb(212, 175, 55);
            llSetImage.Location = new Point(726, 317);
            llSetImage.Name = "llSetImage";
            llSetImage.Size = new Size(86, 21);
            llSetImage.TabIndex = 24;
            llSetImage.TabStop = true;
            llSetImage.Text = "Set Image";
            llSetImage.LinkClicked += llSetImage_LinkClicked;
            // 
            // llRemoveImage
            // 
            llRemoveImage.AutoSize = true;
            llRemoveImage.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            llRemoveImage.LinkColor = Color.FromArgb(235, 87, 87);
            llRemoveImage.Location = new Point(731, 349);
            llRemoveImage.Name = "llRemoveImage";
            llRemoveImage.Size = new Size(72, 21);
            llRemoveImage.TabIndex = 25;
            llRemoveImage.TabStop = true;
            llRemoveImage.Text = "Remove";
            llRemoveImage.LinkClicked += llRemoveImage_LinkClicked;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(50, 50, 60);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(411, 580);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 47);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(212, 175, 55);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(543, 580);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 47);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdatePerson
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(25, 25, 30);
            ClientSize = new Size(926, 647);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(groupBox1);
            Controls.Add(pbPersonIDIcon);
            Controls.Add(lblPersonID);
            Controls.Add(lblPersonIDTag);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAddUpdatePerson";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add / Edit Person Info.";
            Load += frmAddUpdatePerson_Load;
            ((ISupportInitialize)pbPersonIDIcon).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((ISupportInitialize)pbNameIcon).EndInit();
            ((ISupportInitialize)pbNationalNoIcon).EndInit();
            ((ISupportInitialize)pbGendorMaleIcon).EndInit();
            ((ISupportInitialize)pbGendorFemaleIcon).EndInit();
            ((ISupportInitialize)pbEmailIcon).EndInit();
            ((ISupportInitialize)pbAddressIcon).EndInit();
            ((ISupportInitialize)pbDateOfBirthIcon).EndInit();
            ((ISupportInitialize)pbPhoneIcon).EndInit();
            ((ISupportInitialize)pbCountryIcon).EndInit();
            ((ISupportInitialize)pbPersonImage).EndInit();
            ((ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblPersonIDTag;
        private Label lblPersonID;
        private PictureBox pbPersonIDIcon;
        private GroupBox groupBox1;
        private Label lblFirst;
        private Label lblSecond;
        private Label lblThird;
        private Label lblLast;
        private Label lblName;
        private PictureBox pbNameIcon;
        private TextBox txtFirstName;
        private TextBox txtSecondName;
        private TextBox txtThirdName;
        private TextBox txtLastName;
        private Label lblNationalNo;
        private PictureBox pbNationalNoIcon;
        private TextBox txtNationalNo;
        private Label lblGendor;
        private PictureBox pbGendorMaleIcon;
        private RadioButton rbMale;
        private PictureBox pbGendorFemaleIcon;
        private RadioButton rbFemale;
        private Label lblEmail;
        private PictureBox pbEmailIcon;
        private TextBox txtEmail;
        private Label lblAddress;
        private PictureBox pbAddressIcon;
        private TextBox txtAddress;
        private Label lblDateOfBirth;
        private PictureBox pbDateOfBirthIcon;
        private DateTimePicker dtpDateOfBirth;
        private Label lblPhone;
        private PictureBox pbPhoneIcon;
        private TextBox txtPhone;
        private Label lblCountry;
        private PictureBox pbCountryIcon;
        private ComboBox cbCountry;
        private PictureBox pbPersonImage;
        private LinkLabel llSetImage;
        private LinkLabel llRemoveImage;
        private Button btnClose;
        private Button btnSave;
        private OpenFileDialog openFileDialog1;
        private ErrorProvider errorProvider1;
    }
}