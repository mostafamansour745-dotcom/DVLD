namespace DVLD.Tests
{
    partial class frmListTestAppointments
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            cmsApplications = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            takeTestToolStripMenuItem = new ToolStripMenuItem();
            lblRecordsCount = new Label();
            label2 = new Label();
            dgvLicenseTestAppointments = new DataGridView();
            lblTitle = new Label();
            label1 = new Label();
            btnClose = new Button();
            pbTestTypeImage = new PictureBox();
            btnAddNewAppointment = new Button();
            ctrlDrivingLicenseApplicationInfo1 = new DVLD.Application.LocalDrivingLicenseApplications.ctrlDrivingLicenseApplicationInfo();
            cmsApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLicenseTestAppointments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTestTypeImage).BeginInit();
            SuspendLayout();
            // 
            // cmsApplications
            // 
            cmsApplications.BackColor = Color.FromArgb(30, 30, 36);
            cmsApplications.ImageScalingSize = new Size(20, 20);
            cmsApplications.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, takeTestToolStripMenuItem });
            cmsApplications.Name = "contextMenuStrip1";
            cmsApplications.Size = new Size(157, 60);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            editToolStripMenuItem.ForeColor = Color.Gold;
            editToolStripMenuItem.Image = Properties.Resources.edit_322;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(156, 28);
            editToolStripMenuItem.Text = "&Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // takeTestToolStripMenuItem
            // 
            takeTestToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            takeTestToolStripMenuItem.ForeColor = Color.Gold;
            takeTestToolStripMenuItem.Image = Properties.Resources.Test_321;
            takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            takeTestToolStripMenuItem.Size = new Size(156, 28);
            takeTestToolStripMenuItem.Text = "Take Test";
            takeTestToolStripMenuItem.Click += takeTestToolStripMenuItem_Click;
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.ForeColor = Color.White;
            lblRecordsCount.Location = new Point(135, 738);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(34, 25);
            lblRecordsCount.TabIndex = 131;
            lblRecordsCount.Text = "??";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(20, 738);
            label2.Name = "label2";
            label2.Size = new Size(116, 25);
            label2.TabIndex = 130;
            label2.Text = "# Records:";
            // 
            // dgvLicenseTestAppointments
            // 
            dgvLicenseTestAppointments.AllowUserToAddRows = false;
            dgvLicenseTestAppointments.AllowUserToDeleteRows = false;
            dgvLicenseTestAppointments.AllowUserToResizeRows = false;
            dgvLicenseTestAppointments.BackgroundColor = Color.FromArgb(30, 30, 36);
            dgvLicenseTestAppointments.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(45, 45, 52);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Gold;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(45, 45, 52);
            dataGridViewCellStyle1.SelectionForeColor = Color.Gold;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLicenseTestAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLicenseTestAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLicenseTestAppointments.ContextMenuStrip = cmsApplications;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 30, 36);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(218, 165, 32);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(20, 20, 25);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvLicenseTestAppointments.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLicenseTestAppointments.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvLicenseTestAppointments.EnableHeadersVisualStyles = false;
            dgvLicenseTestAppointments.GridColor = Color.FromArgb(50, 50, 60);
            dgvLicenseTestAppointments.Location = new Point(20, 585);
            dgvLicenseTestAppointments.Margin = new Padding(4, 5, 4, 5);
            dgvLicenseTestAppointments.MultiSelect = false;
            dgvLicenseTestAppointments.Name = "dgvLicenseTestAppointments";
            dgvLicenseTestAppointments.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 45, 52);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(218, 165, 32);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvLicenseTestAppointments.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvLicenseTestAppointments.RowHeadersWidth = 51;
            dgvLicenseTestAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLicenseTestAppointments.Size = new Size(887, 147);
            dgvLicenseTestAppointments.TabIndex = 129;
            dgvLicenseTestAppointments.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Gold;
            lblTitle.Location = new Point(266, 120);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(441, 39);
            lblTitle.TabIndex = 133;
            lblTitle.Text = "Test Appointments";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 534);
            label1.Name = "label1";
            label1.Size = new Size(151, 25);
            label1.TabIndex = 135;
            label1.Text = "Appointments:";
            // 
            // btnClose
            // 
            btnClose.AutoEllipsis = true;
            btnClose.BackColor = Color.FromArgb(35, 35, 42);
            btnClose.Cursor = Cursors.Hand;
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.FlatAppearance.BorderColor = Color.Gold;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(184, 134, 11);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 60);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Microsoft Sans Serif", 10.5F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(772, 738);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(135, 36);
            btnClose.TabIndex = 128;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pbTestTypeImage
            // 
            pbTestTypeImage.BackgroundImageLayout = ImageLayout.Zoom;
            pbTestTypeImage.Image = Properties.Resources.Vision_5121;
            pbTestTypeImage.InitialImage = null;
            pbTestTypeImage.Location = new Point(431, 5);
            pbTestTypeImage.Margin = new Padding(4, 5, 4, 5);
            pbTestTypeImage.Name = "pbTestTypeImage";
            pbTestTypeImage.Size = new Size(113, 104);
            pbTestTypeImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbTestTypeImage.TabIndex = 132;
            pbTestTypeImage.TabStop = false;
            // 
            // btnAddNewAppointment
            // 
            btnAddNewAppointment.BackColor = Color.FromArgb(30, 30, 36);
            btnAddNewAppointment.Cursor = Cursors.Hand;
            btnAddNewAppointment.FlatAppearance.BorderColor = Color.Gold;
            btnAddNewAppointment.FlatAppearance.MouseDownBackColor = Color.FromArgb(184, 134, 11);
            btnAddNewAppointment.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 55);
            btnAddNewAppointment.FlatStyle = FlatStyle.Flat;
            btnAddNewAppointment.Image = Properties.Resources.AddAppointment_321;
            btnAddNewAppointment.Location = new Point(837, 534);
            btnAddNewAppointment.Name = "btnAddNewAppointment";
            btnAddNewAppointment.Size = new Size(70, 47);
            btnAddNewAppointment.TabIndex = 137;
            btnAddNewAppointment.UseVisualStyleBackColor = false;
            btnAddNewAppointment.Click += btnAddNewAppointment_Click;
            // 
            // ctrlDrivingLicenseApplicationInfo1
            // 
            ctrlDrivingLicenseApplicationInfo1.BackColor = Color.FromArgb(30, 30, 36);
            ctrlDrivingLicenseApplicationInfo1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlDrivingLicenseApplicationInfo1.ForeColor = Color.White;
            ctrlDrivingLicenseApplicationInfo1.Location = new Point(13, 164);
            ctrlDrivingLicenseApplicationInfo1.Margin = new Padding(4, 5, 4, 5);
            ctrlDrivingLicenseApplicationInfo1.Name = "ctrlDrivingLicenseApplicationInfo1";
            ctrlDrivingLicenseApplicationInfo1.Size = new Size(909, 365);
            ctrlDrivingLicenseApplicationInfo1.TabIndex = 134;
            // 
            // frmListTestAppointments
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 30);
            ClientSize = new Size(934, 789);
            Controls.Add(btnAddNewAppointment);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(ctrlDrivingLicenseApplicationInfo1);
            Controls.Add(btnClose);
            Controls.Add(pbTestTypeImage);
            Controls.Add(lblRecordsCount);
            Controls.Add(label2);
            Controls.Add(dgvLicenseTestAppointments);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmListTestAppointments";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Test Appointments";
            Load += frmListTestAppointments_Load;
            cmsApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLicenseTestAppointments).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbTestTypeImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pbTestTypeImage;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsApplications;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLicenseTestAppointments;
        private System.Windows.Forms.Label lblTitle;
        private DVLD.Application.LocalDrivingLicenseApplications.ctrlDrivingLicenseApplicationInfo ctrlDrivingLicenseApplicationInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNewAppointment;
    }
}