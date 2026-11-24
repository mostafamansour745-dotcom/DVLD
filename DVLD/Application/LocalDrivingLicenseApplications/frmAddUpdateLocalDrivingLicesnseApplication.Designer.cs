namespace DVLD.Application.LocalDrivingLicenseApplications
{
    partial class frmAddUpdateLocalDrivingLicesnseApplication
    {
        private System.ComponentModel.IContainer components = null;

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
            lblTitle = new Label();
            tcApplicationInfo = new TabControl();
            tpPersonalInfo = new TabPage();
            ctrlPersonCardWithFilter1 = new DVLD.Controls.ctrlPersonCardWithFilter();
            btnApplicationInfoNext = new Button();
            tpApplicationInfo = new TabPage();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lblCreatedByUser = new Label();
            lblFees = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            cbLicenseClass = new ComboBox();
            pictureBox6 = new PictureBox();
            label15 = new Label();
            lblApplicationDate = new Label();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            lblLocalDrivingLicebseApplicationID = new Label();
            label4 = new Label();
            btnClose = new Button();
            btnSave = new Button();
            tcApplicationInfo.SuspendLayout();
            tpPersonalInfo.SuspendLayout();
            tpApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Gold;
            lblTitle.Location = new Point(12, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(885, 39);
            lblTitle.TabIndex = 122;
            lblTitle.Text = "Local Driving License Application";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tcApplicationInfo
            // 
            tcApplicationInfo.Controls.Add(tpPersonalInfo);
            tcApplicationInfo.Controls.Add(tpApplicationInfo);
            tcApplicationInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            tcApplicationInfo.Location = new Point(12, 70);
            tcApplicationInfo.Name = "tcApplicationInfo";
            tcApplicationInfo.SelectedIndex = 0;
            tcApplicationInfo.Size = new Size(885, 590);
            tcApplicationInfo.TabIndex = 121;
            // 
            // tpPersonalInfo
            // 
            tpPersonalInfo.BackColor = Color.FromArgb(38, 38, 46);
            tpPersonalInfo.Controls.Add(ctrlPersonCardWithFilter1);
            tpPersonalInfo.Controls.Add(btnApplicationInfoNext);
            tpPersonalInfo.Location = new Point(4, 32);
            tpPersonalInfo.Name = "tpPersonalInfo";
            tpPersonalInfo.Padding = new Padding(3);
            tpPersonalInfo.Size = new Size(877, 554);
            tpPersonalInfo.TabIndex = 0;
            tpPersonalInfo.Text = "Personal Info";
            // 
            // ctrlPersonCardWithFilter1
            // 
            ctrlPersonCardWithFilter1.Location = new Point(10, 10);
            ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            ctrlPersonCardWithFilter1.Size = new Size(855, 480);
            ctrlPersonCardWithFilter1.TabIndex = 0;
            // 
            // btnApplicationInfoNext
            // 
            btnApplicationInfoNext.BackColor = Color.FromArgb(30, 30, 36);
            btnApplicationInfoNext.FlatAppearance.BorderColor = Color.Gold;
            btnApplicationInfoNext.FlatStyle = FlatStyle.Flat;
            btnApplicationInfoNext.ForeColor = Color.Gold;
            btnApplicationInfoNext.Image = Properties.Resources.Next_32;
            btnApplicationInfoNext.ImageAlign = ContentAlignment.MiddleRight;
            btnApplicationInfoNext.Location = new Point(735, 500);
            btnApplicationInfoNext.Margin = new Padding(4, 5, 4, 5);
            btnApplicationInfoNext.Name = "btnApplicationInfoNext";
            btnApplicationInfoNext.Size = new Size(130, 42);
            btnApplicationInfoNext.TabIndex = 119;
            btnApplicationInfoNext.Text = "Next";
            btnApplicationInfoNext.UseVisualStyleBackColor = false;
            btnApplicationInfoNext.Click += btnApplicationInfoNext_Click;
            // 
            // tpApplicationInfo
            // 
            tpApplicationInfo.BackColor = Color.FromArgb(38, 38, 46);
            tpApplicationInfo.Controls.Add(pictureBox2);
            tpApplicationInfo.Controls.Add(pictureBox1);
            tpApplicationInfo.Controls.Add(label1);
            tpApplicationInfo.Controls.Add(lblCreatedByUser);
            tpApplicationInfo.Controls.Add(lblFees);
            tpApplicationInfo.Controls.Add(label2);
            tpApplicationInfo.Controls.Add(pictureBox3);
            tpApplicationInfo.Controls.Add(cbLicenseClass);
            tpApplicationInfo.Controls.Add(pictureBox6);
            tpApplicationInfo.Controls.Add(label15);
            tpApplicationInfo.Controls.Add(lblApplicationDate);
            tpApplicationInfo.Controls.Add(pictureBox4);
            tpApplicationInfo.Controls.Add(label5);
            tpApplicationInfo.Controls.Add(lblLocalDrivingLicebseApplicationID);
            tpApplicationInfo.Controls.Add(label4);
            tpApplicationInfo.Location = new Point(4, 32);
            tpApplicationInfo.Name = "tpApplicationInfo";
            tpApplicationInfo.Padding = new Padding(3);
            tpApplicationInfo.Size = new Size(877, 554);
            tpApplicationInfo.TabIndex = 1;
            tpApplicationInfo.Text = "Application Info.";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Number_32;
            pictureBox2.Location = new Point(257, 58);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 144;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(257, 210);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 143;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(58, 210);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(127, 25);
            label1.TabIndex = 142;
            label1.Text = "Created By:";
            // 
            // lblCreatedByUser
            // 
            lblCreatedByUser.AutoSize = true;
            lblCreatedByUser.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreatedByUser.ForeColor = Color.Gold;
            lblCreatedByUser.Location = new Point(295, 211);
            lblCreatedByUser.Margin = new Padding(4, 0, 4, 0);
            lblCreatedByUser.Name = "lblCreatedByUser";
            lblCreatedByUser.Size = new Size(74, 25);
            lblCreatedByUser.TabIndex = 141;
            lblCreatedByUser.Text = "[????]";
            // 
            // lblFees
            // 
            lblFees.AutoSize = true;
            lblFees.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFees.ForeColor = Color.Gold;
            lblFees.Location = new Point(295, 174);
            lblFees.Margin = new Padding(4, 0, 4, 0);
            lblFees.Name = "lblFees";
            lblFees.Size = new Size(62, 25);
            lblFees.TabIndex = 140;
            lblFees.Text = "[$$$]";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(58, 172);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(180, 25);
            label2.TabIndex = 138;
            label2.Text = "Application Fees:";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.money_32;
            pictureBox3.Location = new Point(257, 178);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 139;
            pictureBox3.TabStop = false;
            // 
            // cbLicenseClass
            // 
            cbLicenseClass.BackColor = Color.FromArgb(40, 40, 48);
            cbLicenseClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLicenseClass.FlatStyle = FlatStyle.Flat;
            cbLicenseClass.ForeColor = Color.White;
            cbLicenseClass.FormattingEnabled = true;
            cbLicenseClass.Location = new Point(295, 140);
            cbLicenseClass.Name = "cbLicenseClass";
            cbLicenseClass.Size = new Size(270, 31);
            cbLicenseClass.TabIndex = 134;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Renew_Driving_License_32;
            pictureBox6.Location = new Point(257, 139);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(31, 26);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 136;
            pictureBox6.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.White;
            label15.Location = new Point(58, 134);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(155, 25);
            label15.TabIndex = 135;
            label15.Text = "License Class:";
            // 
            // lblApplicationDate
            // 
            lblApplicationDate.AutoSize = true;
            lblApplicationDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApplicationDate.ForeColor = Color.Gold;
            lblApplicationDate.Location = new Point(295, 96);
            lblApplicationDate.Margin = new Padding(4, 0, 4, 0);
            lblApplicationDate.Name = "lblApplicationDate";
            lblApplicationDate.Size = new Size(136, 25);
            lblApplicationDate.TabIndex = 133;
            lblApplicationDate.Text = "[??/??/????]";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Calendar_32;
            pictureBox4.Location = new Point(257, 96);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(31, 26);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 132;
            pictureBox4.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(58, 96);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(177, 25);
            label5.TabIndex = 131;
            label5.Text = "Application Date:";
            // 
            // lblLocalDrivingLicebseApplicationID
            // 
            lblLocalDrivingLicebseApplicationID.AutoSize = true;
            lblLocalDrivingLicebseApplicationID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocalDrivingLicebseApplicationID.ForeColor = Color.Gold;
            lblLocalDrivingLicebseApplicationID.Location = new Point(295, 58);
            lblLocalDrivingLicebseApplicationID.Margin = new Padding(4, 0, 4, 0);
            lblLocalDrivingLicebseApplicationID.Name = "lblLocalDrivingLicebseApplicationID";
            lblLocalDrivingLicebseApplicationID.Size = new Size(62, 25);
            lblLocalDrivingLicebseApplicationID.TabIndex = 129;
            lblLocalDrivingLicebseApplicationID.Text = "[???]";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(58, 58);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(192, 25);
            label4.TabIndex = 128;
            label4.Text = "D.L.Application ID:";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(30, 30, 36);
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(184, 134, 11);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(630, 670);
            btnClose.Margin = new Padding(4, 5, 4, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(130, 42);
            btnClose.TabIndex = 120;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(30, 30, 36);
            btnSave.Enabled = false;
            btnSave.FlatAppearance.BorderColor = Color.Gold;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.Gold;
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(767, 670);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 42);
            btnSave.TabIndex = 119;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // frmAddUpdateLocalDrivingLicesnseApplication
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 38, 46);
            ClientSize = new Size(910, 725);
            Controls.Add(lblTitle);
            Controls.Add(tcApplicationInfo);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmAddUpdateLocalDrivingLicesnseApplication";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmAddUpdateApplication";
            Activated += frmAddUpdateLocalDrivingLicesnseApplication_Activated;
            Load += frmAddUpdateLocalDrivingLicesnseApplication_Load;
            tcApplicationInfo.ResumeLayout(false);
            tpPersonalInfo.ResumeLayout(false);
            tpApplicationInfo.ResumeLayout(false);
            tpApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tcApplicationInfo;
        private System.Windows.Forms.TabPage tpPersonalInfo;
        private System.Windows.Forms.Button btnApplicationInfoNext;
        private System.Windows.Forms.TabPage tpApplicationInfo;
        private System.Windows.Forms.Label lblLocalDrivingLicebseApplicationID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbLicenseClass;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCreatedByUser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DVLD.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
    }
}