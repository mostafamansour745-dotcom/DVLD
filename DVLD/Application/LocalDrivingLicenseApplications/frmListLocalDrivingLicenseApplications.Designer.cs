namespace DVLD.Application.LocalDrivingLicenseApplications
{
    partial class frmListLocalDrivingLicenseApplications
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();

            lblTitle = new Label();
            lblRecordsCount = new Label();
            label2 = new Label();
            dgvLocalDrivingLicenseApplications = new DataGridView();
            cmsApplications = new ContextMenuStrip(components);
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            editToolStripMenuItem = new ToolStripMenuItem();
            DeleteApplicationToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            CancelApplicaitonToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            ScheduleTestsMenue = new ToolStripMenuItem();
            scheduleVisionTestToolStripMenuItem = new ToolStripMenuItem();
            scheduleWrittenTestToolStripMenuItem = new ToolStripMenuItem();
            scheduleStreetTestToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            issueDrivingLicenseFirstTimeToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            showLicenseToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            showPersonLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            cbFilterBy = new ComboBox();
            txtFilterValue = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnAddNewApplication = new Button();
            pbPersonImage = new PictureBox();
            btnClose = new Button();

            ((System.ComponentModel.ISupportInitialize)dgvLocalDrivingLicenseApplications).BeginInit();
            cmsApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).BeginInit();
            SuspendLayout();

            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Gold;
            lblTitle.Location = new Point(375, 185);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(700, 50);
            lblTitle.TabIndex = 123;
            lblTitle.Text = "Local Driving License Applications";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            lblRecordsCount.ForeColor = Color.Gold;
            lblRecordsCount.Location = new Point(120, 762);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(30, 24);
            lblRecordsCount.TabIndex = 121;
            lblRecordsCount.Text = "??";

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(180, 180, 180);
            label2.Location = new Point(15, 762);
            label2.Name = "label2";
            label2.Size = new Size(105, 24);
            label2.TabIndex = 120;
            label2.Text = "# Records:";

            // 
            // dgvLocalDrivingLicenseApplications
            // 
            dgvLocalDrivingLicenseApplications.AllowUserToAddRows = false;
            dgvLocalDrivingLicenseApplications.AllowUserToDeleteRows = false;
            dgvLocalDrivingLicenseApplications.AllowUserToResizeRows = false;
            dgvLocalDrivingLicenseApplications.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLocalDrivingLicenseApplications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLocalDrivingLicenseApplications.BackgroundColor = Color.FromArgb(34, 34, 42);

            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(34, 34, 42);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Gold;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;

            dgvLocalDrivingLicenseApplications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLocalDrivingLicenseApplications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLocalDrivingLicenseApplications.ContextMenuStrip = cmsApplications;

            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(44, 44, 52);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(80, 65, 20);
            dataGridViewCellStyle2.SelectionForeColor = Color.Gold;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;

            dgvLocalDrivingLicenseApplications.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLocalDrivingLicenseApplications.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvLocalDrivingLicenseApplications.EnableHeadersVisualStyles = false;
            dgvLocalDrivingLicenseApplications.GridColor = Color.FromArgb(60, 60, 70);
            dgvLocalDrivingLicenseApplications.Location = new Point(12, 325);
            dgvLocalDrivingLicenseApplications.Margin = new Padding(3, 5, 3, 5);
            dgvLocalDrivingLicenseApplications.MultiSelect = false;
            dgvLocalDrivingLicenseApplications.Name = "dgvLocalDrivingLicenseApplications";
            dgvLocalDrivingLicenseApplications.ReadOnly = true;
            dgvLocalDrivingLicenseApplications.RowHeadersVisible = false;
            dgvLocalDrivingLicenseApplications.RowHeadersWidth = 51;
            dgvLocalDrivingLicenseApplications.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLocalDrivingLicenseApplications.Size = new Size(1426, 420);
            dgvLocalDrivingLicenseApplications.TabIndex = 119;
            dgvLocalDrivingLicenseApplications.TabStop = false;

            // 
            // cmsApplications
            // 
            cmsApplications.BackColor = Color.FromArgb(40, 40, 48);
            cmsApplications.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            cmsApplications.ImageScalingSize = new Size(20, 20);
            cmsApplications.Items.AddRange(new ToolStripItem[] {
                showDetailsToolStripMenuItem, toolStripSeparator2, editToolStripMenuItem,
                DeleteApplicationToolStripMenuItem, toolStripSeparator5, CancelApplicaitonToolStripMenuItem,
                toolStripSeparator1, ScheduleTestsMenue, toolStripSeparator3,
                issueDrivingLicenseFirstTimeToolStripMenuItem, toolStripSeparator4,
                showLicenseToolStripMenuItem, toolStripSeparator6, showPersonLicenseHistoryToolStripMenuItem
            });
            cmsApplications.Name = "cmsApplications";
            cmsApplications.Size = new Size(346, 344);
            cmsApplications.Opening += cmsApplications_Opening;

            // 
            // Menu Items
            // 
            showDetailsToolStripMenuItem.ForeColor = Color.Gold;
            showDetailsToolStripMenuItem.Image = Properties.Resources.PersonDetails_321;
            showDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(345, 38);
            showDetailsToolStripMenuItem.Text = "&Show Application Details";
            showDetailsToolStripMenuItem.Click += showDetailsToolStripMenuItem_Click;

            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(342, 6);

            editToolStripMenuItem.ForeColor = Color.Gold;
            editToolStripMenuItem.Image = Properties.Resources.edit_321;
            editToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(345, 38);
            editToolStripMenuItem.Text = "&Edit Application";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;

            DeleteApplicationToolStripMenuItem.ForeColor = Color.FromArgb(220, 80, 80);
            DeleteApplicationToolStripMenuItem.Image = Properties.Resources.Delete_32_21;
            DeleteApplicationToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            DeleteApplicationToolStripMenuItem.Name = "DeleteApplicationToolStripMenuItem";
            DeleteApplicationToolStripMenuItem.Size = new Size(345, 38);
            DeleteApplicationToolStripMenuItem.Text = "&Delete Application";
            DeleteApplicationToolStripMenuItem.Click += DeleteApplicationToolStripMenuItem_Click;

            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(342, 6);

            CancelApplicaitonToolStripMenuItem.ForeColor = Color.FromArgb(220, 80, 80);
            CancelApplicaitonToolStripMenuItem.Image = Properties.Resources.Delete_32;
            CancelApplicaitonToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            CancelApplicaitonToolStripMenuItem.Name = "CancelApplicaitonToolStripMenuItem";
            CancelApplicaitonToolStripMenuItem.Size = new Size(345, 38);
            CancelApplicaitonToolStripMenuItem.Text = "&Cancel Application";
            CancelApplicaitonToolStripMenuItem.Click += CancelApplicaitonToolStripMenuItem_Click;

            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(342, 6);

            // 
            // ScheduleTestsMenue
            // 
            ScheduleTestsMenue.DropDownItems.AddRange(new ToolStripItem[] {
                scheduleVisionTestToolStripMenuItem,
                scheduleWrittenTestToolStripMenuItem,
                scheduleStreetTestToolStripMenuItem
            });
            ScheduleTestsMenue.ForeColor = Color.Gold;
            ScheduleTestsMenue.Image = Properties.Resources.Schedule_Test_32;
            ScheduleTestsMenue.ImageScaling = ToolStripItemImageScaling.None;
            ScheduleTestsMenue.Name = "ScheduleTestsMenue";
            ScheduleTestsMenue.Size = new Size(345, 38);
            ScheduleTestsMenue.Text = "Schedule &Tests";

            scheduleVisionTestToolStripMenuItem.ForeColor = Color.Gold;
            scheduleVisionTestToolStripMenuItem.Image = Properties.Resources.Vision_Test_32;
            scheduleVisionTestToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            scheduleVisionTestToolStripMenuItem.Name = "scheduleVisionTestToolStripMenuItem";
            scheduleVisionTestToolStripMenuItem.Size = new Size(272, 38);
            scheduleVisionTestToolStripMenuItem.Text = "Schedule Vision Test";
            scheduleVisionTestToolStripMenuItem.Click += scheduleVisionTestToolStripMenuItem_Click;

            scheduleWrittenTestToolStripMenuItem.ForeColor = Color.Gold;
            scheduleWrittenTestToolStripMenuItem.Image = Properties.Resources.Written_Test_32;
            scheduleWrittenTestToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            scheduleWrittenTestToolStripMenuItem.Name = "scheduleWrittenTestToolStripMenuItem";
            scheduleWrittenTestToolStripMenuItem.Size = new Size(272, 38);
            scheduleWrittenTestToolStripMenuItem.Text = "Schedule Written Test";
            scheduleWrittenTestToolStripMenuItem.Click += scheduleWrittenTestToolStripMenuItem_Click;

            scheduleStreetTestToolStripMenuItem.ForeColor = Color.Gold;
            scheduleStreetTestToolStripMenuItem.Image = Properties.Resources.Street_Test_32;
            scheduleStreetTestToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            scheduleStreetTestToolStripMenuItem.Name = "scheduleStreetTestToolStripMenuItem";
            scheduleStreetTestToolStripMenuItem.Size = new Size(272, 38);
            scheduleStreetTestToolStripMenuItem.Text = "Schedule Street Test";
            scheduleStreetTestToolStripMenuItem.Click += scheduleStreetTestToolStripMenuItem_Click;

            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(342, 6);

            issueDrivingLicenseFirstTimeToolStripMenuItem.ForeColor = Color.Gold;
            issueDrivingLicenseFirstTimeToolStripMenuItem.Image = Properties.Resources.IssueDrivingLicense_32;
            issueDrivingLicenseFirstTimeToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            issueDrivingLicenseFirstTimeToolStripMenuItem.Name = "issueDrivingLicenseFirstTimeToolStripMenuItem";
            issueDrivingLicenseFirstTimeToolStripMenuItem.Size = new Size(345, 38);
            issueDrivingLicenseFirstTimeToolStripMenuItem.Text = "&Issue Driving License (First Time)";
            issueDrivingLicenseFirstTimeToolStripMenuItem.Click += issueDrivingLicenseFirstTimeToolStripMenuItem_Click;

            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(342, 6);

            showLicenseToolStripMenuItem.ForeColor = Color.Gold;
            showLicenseToolStripMenuItem.Image = Properties.Resources.License_View_32;
            showLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            showLicenseToolStripMenuItem.Size = new Size(345, 38);
            showLicenseToolStripMenuItem.Text = "Show &License";
            showLicenseToolStripMenuItem.Click += showLicenseToolStripMenuItem_Click;

            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(342, 6);

            showPersonLicenseHistoryToolStripMenuItem.ForeColor = Color.Gold;
            showPersonLicenseHistoryToolStripMenuItem.Image = Properties.Resources.PersonLicenseHistory_32;
            showPersonLicenseHistoryToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            showPersonLicenseHistoryToolStripMenuItem.Size = new Size(345, 38);
            showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            showPersonLicenseHistoryToolStripMenuItem.Click += showPersonLicenseHistoryToolStripMenuItem_Click;

            // 
            // cbFilterBy
            // 
            cbFilterBy.BackColor = Color.FromArgb(40, 40, 48);
            cbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterBy.FlatStyle = FlatStyle.Flat;
            cbFilterBy.Font = new Font("Microsoft Sans Serif", 10F);
            cbFilterBy.ForeColor = Color.White;
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "L.D.L.AppID", "National No.", "Full Name", "Status" });
            cbFilterBy.Location = new Point(105, 271);
            cbFilterBy.Margin = new Padding(3, 4, 3, 4);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(180, 28);
            cbFilterBy.TabIndex = 127;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;

            // 
            // txtFilterValue
            // 
            txtFilterValue.BackColor = Color.FromArgb(40, 40, 48);
            txtFilterValue.BorderStyle = BorderStyle.FixedSingle;
            txtFilterValue.Font = new Font("Microsoft Sans Serif", 10F);
            txtFilterValue.ForeColor = Color.White;
            txtFilterValue.Location = new Point(295, 271);
            txtFilterValue.Margin = new Padding(3, 5, 3, 5);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(230, 26);
            txtFilterValue.TabIndex = 126;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            txtFilterValue.KeyPress += txtFilterValue_KeyPress;

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(180, 180, 180);
            label1.Location = new Point(15, 275);
            label1.Name = "label1";
            label1.Size = new Size(88, 24);
            label1.TabIndex = 125;
            label1.Text = "Filter By:";

            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = Properties.Resources.Local_32;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(805, 60);
            pictureBox1.Margin = new Padding(3, 5, 3, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 130;
            pictureBox1.TabStop = false;

            // 
            // btnAddNewApplication
            // 
            btnAddNewApplication.BackColor = Color.FromArgb(30, 30, 36);
            btnAddNewApplication.FlatAppearance.BorderColor = Color.Gold;
            btnAddNewApplication.FlatStyle = FlatStyle.Flat;
            btnAddNewApplication.ForeColor = Color.Gold;
            btnAddNewApplication.Image = Properties.Resources.New_Application_641;
            btnAddNewApplication.Location = new Point(1358, 235);
            btnAddNewApplication.Margin = new Padding(3, 4, 3, 4);
            btnAddNewApplication.Name = "btnAddNewApplication";
            btnAddNewApplication.Size = new Size(80, 80);
            btnAddNewApplication.TabIndex = 129;
            btnAddNewApplication.UseVisualStyleBackColor = false;
            btnAddNewApplication.Click += btnAddNewApplication_Click;

            // 
            // pbPersonImage
            // 
            pbPersonImage.BackgroundImageLayout = ImageLayout.Zoom;
            pbPersonImage.Image = Properties.Resources.Application_Types_512;
            pbPersonImage.InitialImage = null;
            pbPersonImage.Location = new Point(625, 15);
            pbPersonImage.Margin = new Padding(3, 5, 3, 5);
            pbPersonImage.Name = "pbPersonImage";
            pbPersonImage.Size = new Size(200, 160);
            pbPersonImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbPersonImage.TabIndex = 128;
            pbPersonImage.TabStop = false;

            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.AutoEllipsis = true;
            btnClose.BackColor = Color.FromArgb(30, 30, 36);
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(184, 134, 11);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(1318, 755);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 48);
            btnClose.TabIndex = 118;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;

            // 
            // frmListLocalDrivingLicenseApplications
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(34, 34, 42);
            ClientSize = new Size(1450, 820);
            Controls.Add(pictureBox1);
            Controls.Add(btnAddNewApplication);
            Controls.Add(pbPersonImage);
            Controls.Add(cbFilterBy);
            Controls.Add(txtFilterValue);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(lblRecordsCount);
            Controls.Add(label2);
            Controls.Add(dgvLocalDrivingLicenseApplications);
            Controls.Add(btnClose);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmListLocalDrivingLicenseApplications";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Local Driving License Applications";
            Load += frmListLocalDrivingLicenseApplications_Load;

            ((System.ComponentModel.ISupportInitialize)dgvLocalDrivingLicenseApplications).EndInit();
            cmsApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblRecordsCount;
        private Label label2;
        private DataGridView dgvLocalDrivingLicenseApplications;
        private ContextMenuStrip cmsApplications;
        private ToolStripMenuItem showDetailsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem DeleteApplicationToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem CancelApplicaitonToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem ScheduleTestsMenue;
        private ToolStripMenuItem scheduleVisionTestToolStripMenuItem;
        private ToolStripMenuItem scheduleWrittenTestToolStripMenuItem;
        private ToolStripMenuItem scheduleStreetTestToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem issueDrivingLicenseFirstTimeToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem showLicenseToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private ComboBox cbFilterBy;
        private TextBox txtFilterValue;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnAddNewApplication;
        private PictureBox pbPersonImage;
        private Button btnClose;
    }
}