namespace DVLD.Application.LocalDrivingLicenseApplications
{
    partial class ctrlDrivingLicenseApplicationInfo
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            llShowLicenceInfo = new LinkLabel();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            lblPassedTests = new Label();
            label2 = new Label();
            pictureBox7 = new PictureBox();
            lblAppliedFor = new Label();
            label10 = new Label();
            pictureBox2 = new PictureBox();
            lblLocalDrivingLicenseApplicationID = new Label();
            label4 = new Label();
            ctrlApplicationBasicsInfo1 = new DVLD.Application.Controls.ctrlApplicationBasicsInfo();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(30, 30, 36);
            groupBox1.Controls.Add(llShowLicenceInfo);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(lblPassedTests);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(pictureBox7);
            groupBox1.Controls.Add(lblAppliedFor);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(lblLocalDrivingLicenseApplicationID);
            groupBox1.Controls.Add(label4);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(3, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(892, 132);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Driving License Application Info";
            // 
            // llShowLicenceInfo
            // 
            llShowLicenceInfo.AutoSize = true;
            llShowLicenceInfo.DisabledLinkColor = Color.FromArgb(120, 120, 128);
            llShowLicenceInfo.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            llShowLicenceInfo.LinkColor = Color.FromArgb(212, 175, 55);
            llShowLicenceInfo.Location = new Point(168, 78);
            llShowLicenceInfo.Name = "llShowLicenceInfo";
            llShowLicenceInfo.Size = new Size(163, 20);
            llShowLicenceInfo.TabIndex = 191;
            llShowLicenceInfo.TabStop = true;
            llShowLicenceInfo.Text = "Show License Info";
            llShowLicenceInfo.LinkClicked += llShowLicenseInfo_LinkClicked;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.License_View_321;
            pictureBox3.Location = new Point(131, 73);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 190;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.PassedTests_32;
            pictureBox1.Location = new Point(496, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 189;
            pictureBox1.TabStop = false;
            // 
            // lblPassedTests
            // 
            lblPassedTests.AutoSize = true;
            lblPassedTests.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassedTests.ForeColor = Color.Gold;
            lblPassedTests.Location = new Point(535, 73);
            lblPassedTests.Margin = new Padding(4, 0, 4, 0);
            lblPassedTests.Name = "lblPassedTests";
            lblPassedTests.Size = new Size(24, 25);
            lblPassedTests.TabIndex = 188;
            lblPassedTests.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(338, 73);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(151, 25);
            label2.TabIndex = 187;
            label2.Text = "Passed Tests:";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.License_Type_32;
            pictureBox7.Location = new Point(497, 36);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(31, 26);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 186;
            pictureBox7.TabStop = false;
            // 
            // lblAppliedFor
            // 
            lblAppliedFor.AutoSize = true;
            lblAppliedFor.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppliedFor.ForeColor = Color.Gold;
            lblAppliedFor.Location = new Point(535, 36);
            lblAppliedFor.Margin = new Padding(4, 0, 4, 0);
            lblAppliedFor.Name = "lblAppliedFor";
            lblAppliedFor.Size = new Size(62, 25);
            lblAppliedFor.TabIndex = 185;
            lblAppliedFor.Text = "[???]";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(289, 36);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(211, 25);
            label10.TabIndex = 184;
            label10.Text = "Applied For License:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Number_32;
            pictureBox2.Location = new Point(131, 36);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 174;
            pictureBox2.TabStop = false;
            // 
            // lblLocalDrivingLicenseApplicationID
            // 
            lblLocalDrivingLicenseApplicationID.AutoSize = true;
            lblLocalDrivingLicenseApplicationID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocalDrivingLicenseApplicationID.ForeColor = Color.Gold;
            lblLocalDrivingLicenseApplicationID.Location = new Point(169, 36);
            lblLocalDrivingLicenseApplicationID.Margin = new Padding(4, 0, 4, 0);
            lblLocalDrivingLicenseApplicationID.Name = "lblLocalDrivingLicenseApplicationID";
            lblLocalDrivingLicenseApplicationID.Size = new Size(62, 25);
            lblLocalDrivingLicenseApplicationID.TabIndex = 161;
            lblLocalDrivingLicenseApplicationID.Text = "[???]";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(6, 36);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(124, 25);
            label4.TabIndex = 160;
            label4.Text = "D.L.App ID:";
            // 
            // ctrlApplicationBasicsInfo1
            // 
            ctrlApplicationBasicsInfo1.BackColor = Color.FromArgb(30, 30, 36);
            ctrlApplicationBasicsInfo1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlApplicationBasicsInfo1.Location = new Point(5, 151);
            ctrlApplicationBasicsInfo1.Margin = new Padding(4, 5, 4, 5);
            ctrlApplicationBasicsInfo1.Name = "ctrlApplicationBasicsInfo1";
            ctrlApplicationBasicsInfo1.Size = new Size(900, 217);
            ctrlApplicationBasicsInfo1.TabIndex = 0;
            // 
            // ctrlDrivingLicenseApplicationInfo
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 30);
            Controls.Add(groupBox1);
            Controls.Add(ctrlApplicationBasicsInfo1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ctrlDrivingLicenseApplicationInfo";
            Size = new Size(909, 376);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private DVLD.Application.Controls.ctrlApplicationBasicsInfo ctrlApplicationBasicsInfo1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblLocalDrivingLicenseApplicationID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblAppliedFor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPassedTests;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel llShowLicenceInfo;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}