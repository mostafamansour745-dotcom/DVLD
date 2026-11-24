namespace DVLD
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MenuStrip msMain;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            msApplications = new ToolStripMenuItem();
            drivingLicensesServicesToolStripMenuItem = new ToolStripMenuItem();
            newDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            localLicenseToolStripMenuItem = new ToolStripMenuItem();
            internationalLicenseToolStripMenuItem = new ToolStripMenuItem();
            renewDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            replacementForLostOrDamagedLicenseToolStripMenuItem = new ToolStripMenuItem();
            releaseDetainedDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            retakeTestToolStripMenuItem = new ToolStripMenuItem();
            manageApplicationsToolStripMenuItem = new ToolStripMenuItem();
            localDrivingLicenseApplicationToolStripMenuItem = new ToolStripMenuItem();
            internationalDrivingLicenseApplicationsToolStripMenuItem = new ToolStripMenuItem();
            detainLicensesToolStripMenuItem = new ToolStripMenuItem();
            manageDetainLicenseToolStripMenuItem = new ToolStripMenuItem();
            detainLicenseToolStripMenuItem = new ToolStripMenuItem();
            releaseDetainLicenseToolStripMenuItem = new ToolStripMenuItem();
            manageApplicationTypesToolStripMenuItem = new ToolStripMenuItem();
            manageTestTypesToolStripMenuItem = new ToolStripMenuItem();
            msPeople = new ToolStripMenuItem();
            msDrivers = new ToolStripMenuItem();
            driversToolStripMenuItem = new ToolStripMenuItem();
            msUsers = new ToolStripMenuItem();
            msAccountSetting = new ToolStripMenuItem();
            currentUserInfoToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            signOutToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            pictureBox1 = new PictureBox();
            msMain = new MenuStrip();
            msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // msMain
            // 
            msMain.BackColor = Color.Transparent;
            msMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            msMain.ImageScalingSize = new Size(64, 64);
            msMain.Items.AddRange(new ToolStripItem[] { msApplications, msPeople, msDrivers, msUsers, msAccountSetting });
            msMain.Location = new Point(0, 0);
            msMain.Name = "msMain";
            msMain.Size = new Size(982, 72);
            msMain.TabIndex = 0;
            msMain.Text = "msMain";
            // 
            // msApplications
            // 
            msApplications.DropDownItems.AddRange(new ToolStripItem[] { drivingLicensesServicesToolStripMenuItem, manageApplicationsToolStripMenuItem, detainLicensesToolStripMenuItem, manageApplicationTypesToolStripMenuItem, manageTestTypesToolStripMenuItem });
            msApplications.ForeColor = Color.Gold;
            msApplications.Image = Properties.Resources.Applications_64;
            msApplications.Name = "msApplications";
            msApplications.Size = new Size(199, 68);
            msApplications.Text = "Applications";
            msApplications.Click += msApplications_Click;
            // 
            // drivingLicensesServicesToolStripMenuItem
            // 
            drivingLicensesServicesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newDrivingLicenseToolStripMenuItem, renewDrivingLicenseToolStripMenuItem, replacementForLostOrDamagedLicenseToolStripMenuItem, releaseDetainedDrivingLicenseToolStripMenuItem, retakeTestToolStripMenuItem });
            drivingLicensesServicesToolStripMenuItem.Image = (Image)resources.GetObject("drivingLicensesServicesToolStripMenuItem.Image");
            drivingLicensesServicesToolStripMenuItem.Name = "drivingLicensesServicesToolStripMenuItem";
            drivingLicensesServicesToolStripMenuItem.Size = new Size(373, 70);
            drivingLicensesServicesToolStripMenuItem.Text = "Driving Licenses Services";
            // 
            // newDrivingLicenseToolStripMenuItem
            // 
            newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { localLicenseToolStripMenuItem, internationalLicenseToolStripMenuItem });
            newDrivingLicenseToolStripMenuItem.Image = (Image)resources.GetObject("newDrivingLicenseToolStripMenuItem.Image");
            newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
            newDrivingLicenseToolStripMenuItem.Size = new Size(506, 70);
            newDrivingLicenseToolStripMenuItem.Text = "New Driving License";
            // 
            // localLicenseToolStripMenuItem
            // 
            localLicenseToolStripMenuItem.Name = "localLicenseToolStripMenuItem";
            localLicenseToolStripMenuItem.Size = new Size(276, 32);
            localLicenseToolStripMenuItem.Text = "Local License";
            localLicenseToolStripMenuItem.Click += localLicenseToolStripMenuItem_Click;
            // 
            // internationalLicenseToolStripMenuItem
            // 
            internationalLicenseToolStripMenuItem.Name = "internationalLicenseToolStripMenuItem";
            internationalLicenseToolStripMenuItem.Size = new Size(276, 32);
            internationalLicenseToolStripMenuItem.Text = "International License";
            // 
            // renewDrivingLicenseToolStripMenuItem
            // 
            renewDrivingLicenseToolStripMenuItem.Image = Properties.Resources.Renew_Driving_License_32;
            renewDrivingLicenseToolStripMenuItem.Name = "renewDrivingLicenseToolStripMenuItem";
            renewDrivingLicenseToolStripMenuItem.Size = new Size(506, 70);
            renewDrivingLicenseToolStripMenuItem.Text = "Renew Driving License";
            // 
            // replacementForLostOrDamagedLicenseToolStripMenuItem
            // 
            replacementForLostOrDamagedLicenseToolStripMenuItem.Image = Properties.Resources.Damaged_Driving_License_32;
            replacementForLostOrDamagedLicenseToolStripMenuItem.Name = "replacementForLostOrDamagedLicenseToolStripMenuItem";
            replacementForLostOrDamagedLicenseToolStripMenuItem.Size = new Size(506, 70);
            replacementForLostOrDamagedLicenseToolStripMenuItem.Text = "Replacement for Lost or Damaged License";
            // 
            // releaseDetainedDrivingLicenseToolStripMenuItem
            // 
            releaseDetainedDrivingLicenseToolStripMenuItem.Image = Properties.Resources.Renew_Driving_License_321;
            releaseDetainedDrivingLicenseToolStripMenuItem.Name = "releaseDetainedDrivingLicenseToolStripMenuItem";
            releaseDetainedDrivingLicenseToolStripMenuItem.Size = new Size(506, 70);
            releaseDetainedDrivingLicenseToolStripMenuItem.Text = "Release Detained Driving License";
            // 
            // retakeTestToolStripMenuItem
            // 
            retakeTestToolStripMenuItem.Image = Properties.Resources.Retake_Test_32;
            retakeTestToolStripMenuItem.Name = "retakeTestToolStripMenuItem";
            retakeTestToolStripMenuItem.Size = new Size(506, 70);
            retakeTestToolStripMenuItem.Text = "Retake Test";
            retakeTestToolStripMenuItem.Click += retakeTestToolStripMenuItem_Click;
            // 
            // manageApplicationsToolStripMenuItem
            // 
            manageApplicationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { localDrivingLicenseApplicationToolStripMenuItem, internationalDrivingLicenseApplicationsToolStripMenuItem });
            manageApplicationsToolStripMenuItem.Image = (Image)resources.GetObject("manageApplicationsToolStripMenuItem.Image");
            manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            manageApplicationsToolStripMenuItem.Size = new Size(373, 70);
            manageApplicationsToolStripMenuItem.Text = "Manage Applications";
            // 
            // localDrivingLicenseApplicationToolStripMenuItem
            // 
            localDrivingLicenseApplicationToolStripMenuItem.Image = Properties.Resources.LocalDriving_License;
            localDrivingLicenseApplicationToolStripMenuItem.Name = "localDrivingLicenseApplicationToolStripMenuItem";
            localDrivingLicenseApplicationToolStripMenuItem.Size = new Size(503, 70);
            localDrivingLicenseApplicationToolStripMenuItem.Text = "Local Driving License Applications";
            localDrivingLicenseApplicationToolStripMenuItem.Click += localDrivingLicenseApplicationToolStripMenuItem_Click;
            // 
            // internationalDrivingLicenseApplicationsToolStripMenuItem
            // 
            internationalDrivingLicenseApplicationsToolStripMenuItem.Image = Properties.Resources.International_32;
            internationalDrivingLicenseApplicationsToolStripMenuItem.Name = "internationalDrivingLicenseApplicationsToolStripMenuItem";
            internationalDrivingLicenseApplicationsToolStripMenuItem.Size = new Size(503, 70);
            internationalDrivingLicenseApplicationsToolStripMenuItem.Text = "International Driving License Applications";
            // 
            // detainLicensesToolStripMenuItem
            // 
            detainLicensesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageDetainLicenseToolStripMenuItem, detainLicenseToolStripMenuItem, releaseDetainLicenseToolStripMenuItem });
            detainLicensesToolStripMenuItem.Image = Properties.Resources.Detain_64;
            detainLicensesToolStripMenuItem.Name = "detainLicensesToolStripMenuItem";
            detainLicensesToolStripMenuItem.Size = new Size(373, 70);
            detainLicensesToolStripMenuItem.Text = "Detain Licenses";
            // 
            // manageDetainLicenseToolStripMenuItem
            // 
            manageDetainLicenseToolStripMenuItem.Image = (Image)resources.GetObject("manageDetainLicenseToolStripMenuItem.Image");
            manageDetainLicenseToolStripMenuItem.Name = "manageDetainLicenseToolStripMenuItem";
            manageDetainLicenseToolStripMenuItem.Size = new Size(342, 70);
            manageDetainLicenseToolStripMenuItem.Text = "Manage Detain License";
            // 
            // detainLicenseToolStripMenuItem
            // 
            detainLicenseToolStripMenuItem.Image = (Image)resources.GetObject("detainLicenseToolStripMenuItem.Image");
            detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
            detainLicenseToolStripMenuItem.Size = new Size(342, 70);
            detainLicenseToolStripMenuItem.Text = "Detain License";
            // 
            // releaseDetainLicenseToolStripMenuItem
            // 
            releaseDetainLicenseToolStripMenuItem.Image = (Image)resources.GetObject("releaseDetainLicenseToolStripMenuItem.Image");
            releaseDetainLicenseToolStripMenuItem.Name = "releaseDetainLicenseToolStripMenuItem";
            releaseDetainLicenseToolStripMenuItem.Size = new Size(342, 70);
            releaseDetainLicenseToolStripMenuItem.Text = "Release Detain License";
            // 
            // manageApplicationTypesToolStripMenuItem
            // 
            manageApplicationTypesToolStripMenuItem.Image = (Image)resources.GetObject("manageApplicationTypesToolStripMenuItem.Image");
            manageApplicationTypesToolStripMenuItem.Name = "manageApplicationTypesToolStripMenuItem";
            manageApplicationTypesToolStripMenuItem.Size = new Size(373, 70);
            manageApplicationTypesToolStripMenuItem.Text = "Manage Application Types";
            manageApplicationTypesToolStripMenuItem.Click += manageApplicationTypesToolStripMenuItem_Click;
            // 
            // manageTestTypesToolStripMenuItem
            // 
            manageTestTypesToolStripMenuItem.Image = (Image)resources.GetObject("manageTestTypesToolStripMenuItem.Image");
            manageTestTypesToolStripMenuItem.Name = "manageTestTypesToolStripMenuItem";
            manageTestTypesToolStripMenuItem.Size = new Size(373, 70);
            manageTestTypesToolStripMenuItem.Text = "Manage Test Types";
            manageTestTypesToolStripMenuItem.Click += manageTestTypesToolStripMenuItem_Click;
            // 
            // msPeople
            // 
            msPeople.ForeColor = Color.Gold;
            msPeople.Image = Properties.Resources.People_400;
            msPeople.Name = "msPeople";
            msPeople.Size = new Size(149, 68);
            msPeople.Text = "People";
            msPeople.Click += msPeople_Click;
            // 
            // msDrivers
            // 
            msDrivers.DropDownItems.AddRange(new ToolStripItem[] { driversToolStripMenuItem });
            msDrivers.ForeColor = Color.Gold;
            msDrivers.Image = Properties.Resources.Drivers_64;
            msDrivers.Name = "msDrivers";
            msDrivers.Size = new Size(151, 68);
            msDrivers.Text = "Drivers";
            // 
            // driversToolStripMenuItem
            // 
            driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            driversToolStripMenuItem.Size = new Size(159, 32);
            driversToolStripMenuItem.Text = "Drivers";
            // 
            // msUsers
            // 
            msUsers.ForeColor = Color.Gold;
            msUsers.Image = Properties.Resources.Users_2_64;
            msUsers.Name = "msUsers";
            msUsers.Size = new Size(137, 68);
            msUsers.Text = "Users";
            msUsers.Click += msUsers_Click;
            // 
            // msAccountSetting
            // 
            msAccountSetting.DropDownItems.AddRange(new ToolStripItem[] { currentUserInfoToolStripMenuItem, changePasswordToolStripMenuItem, signOutToolStripMenuItem, toolStripSeparator1 });
            msAccountSetting.ForeColor = Color.Gold;
            msAccountSetting.Image = Properties.Resources.account_settings_64;
            msAccountSetting.Name = "msAccountSetting";
            msAccountSetting.Size = new Size(230, 68);
            msAccountSetting.Text = "Account Setting";
            // 
            // currentUserInfoToolStripMenuItem
            // 
            currentUserInfoToolStripMenuItem.Image = Properties.Resources.PersonDetails_32;
            currentUserInfoToolStripMenuItem.Name = "currentUserInfoToolStripMenuItem";
            currentUserInfoToolStripMenuItem.Size = new Size(294, 70);
            currentUserInfoToolStripMenuItem.Text = "Current User Info";
            currentUserInfoToolStripMenuItem.Click += currentUserInfoToolStripMenuItem_Click;
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Image = Properties.Resources.Password_32;
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(294, 70);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // signOutToolStripMenuItem
            // 
            signOutToolStripMenuItem.Image = Properties.Resources.sign_out_32__2;
            signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            signOutToolStripMenuItem.Size = new Size(294, 70);
            signOutToolStripMenuItem.Text = "Sign Out";
            signOutToolStripMenuItem.Click += signOutToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(291, 6);
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(982, 653);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 653);
            Controls.Add(msMain);
            Controls.Add(pictureBox1);
            MainMenuStrip = msMain;
            Name = "frmMain";
            Text = "Main";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            msMain.ResumeLayout(false);
            msMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip msMain;
        private ToolStripMenuItem msApplications;
        private ToolStripMenuItem msPeople;
        private ToolStripMenuItem msDrivers;
        private ToolStripMenuItem msUsers;
        private ToolStripMenuItem msAccountSetting;
        private ToolStripMenuItem drivingLicensesServicesToolStripMenuItem;
        private ToolStripMenuItem newDrivingLicenseToolStripMenuItem;
        private ToolStripMenuItem renewDrivingLicenseToolStripMenuItem;
        private ToolStripMenuItem replacementForLostOrDamagedLicenseToolStripMenuItem;
        private ToolStripMenuItem releaseDetainedDrivingLicenseToolStripMenuItem;
        private ToolStripMenuItem retakeTestToolStripMenuItem;
        private ToolStripMenuItem manageApplicationsToolStripMenuItem;
        private ToolStripMenuItem detainLicensesToolStripMenuItem;
        private ToolStripMenuItem manageApplicationTypesToolStripMenuItem;
        private ToolStripMenuItem manageTestTypesToolStripMenuItem;
        private ToolStripMenuItem localDrivingLicenseApplicationToolStripMenuItem;
        private ToolStripMenuItem internationalDrivingLicenseApplicationsToolStripMenuItem;
        private ToolStripMenuItem manageDetainLicenseToolStripMenuItem;
        private ToolStripMenuItem detainLicenseToolStripMenuItem;
        private ToolStripMenuItem releaseDetainLicenseToolStripMenuItem;
        private ToolStripMenuItem currentUserInfoToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem signOutToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem driversToolStripMenuItem;
        private ToolStripMenuItem localLicenseToolStripMenuItem;
        private ToolStripMenuItem internationalLicenseToolStripMenuItem;
    }
}
