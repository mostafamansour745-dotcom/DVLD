namespace DVLD.Licenses.Local_Licenses
{
    partial class frmIssueDriverLicenseFirstTime
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
            ctrlDrivingLicenseApplicationInfo1 = new DVLD.Application.LocalDrivingLicenseApplications.ctrlDrivingLicenseApplicationInfo();
            btnClose = new Button();
            btnIssueLicense = new Button();
            txtNotes = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ctrlDrivingLicenseApplicationInfo1
            // 
            ctrlDrivingLicenseApplicationInfo1.BackColor = Color.FromArgb(34, 34, 42);
            ctrlDrivingLicenseApplicationInfo1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlDrivingLicenseApplicationInfo1.Location = new Point(13, 14);
            ctrlDrivingLicenseApplicationInfo1.Margin = new Padding(4, 5, 4, 5);
            ctrlDrivingLicenseApplicationInfo1.Name = "ctrlDrivingLicenseApplicationInfo1";
            ctrlDrivingLicenseApplicationInfo1.Size = new Size(909, 376);
            ctrlDrivingLicenseApplicationInfo1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.AutoEllipsis = true;
            btnClose.BackColor = Color.FromArgb(30, 30, 36);
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(184, 134, 11);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(647, 534);
            btnClose.Margin = new Padding(4, 5, 4, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(126, 37);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnIssueLicense
            // 
            btnIssueLicense.AutoEllipsis = true;
            btnIssueLicense.BackColor = Color.FromArgb(30, 30, 36);
            btnIssueLicense.FlatAppearance.BorderColor = Color.Gold;
            btnIssueLicense.FlatStyle = FlatStyle.Flat;
            btnIssueLicense.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnIssueLicense.ForeColor = Color.Gold;
            btnIssueLicense.Image = Properties.Resources.License_Type_32;
            btnIssueLicense.ImageAlign = ContentAlignment.MiddleLeft;
            btnIssueLicense.Location = new Point(781, 534);
            btnIssueLicense.Margin = new Padding(4, 5, 4, 5);
            btnIssueLicense.Name = "btnIssueLicense";
            btnIssueLicense.Size = new Size(126, 37);
            btnIssueLicense.TabIndex = 2;
            btnIssueLicense.Text = "Issue";
            btnIssueLicense.UseVisualStyleBackColor = false;
            btnIssueLicense.Click += btnIssueLicense_Click;
            // 
            // txtNotes
            // 
            txtNotes.BackColor = Color.FromArgb(40, 40, 48);
            txtNotes.BorderStyle = BorderStyle.FixedSingle;
            txtNotes.ForeColor = Color.White;
            txtNotes.Location = new Point(124, 399);
            txtNotes.MaxLength = 500;
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(783, 127);
            txtNotes.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Notes_32;
            pictureBox1.Location = new Point(87, 398);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 175;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(180, 180, 180);
            label1.Location = new Point(23, 399);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 174;
            label1.Text = "Notes:";
            // 
            // frmIssueDriverLicenseFirstTime
            // 
            AcceptButton = btnIssueLicense;
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 42);
            CancelButton = btnClose;
            ClientSize = new Size(931, 591);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(txtNotes);
            Controls.Add(btnClose);
            Controls.Add(btnIssueLicense);
            Controls.Add(ctrlDrivingLicenseApplicationInfo1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmIssueDriverLicenseFirstTime";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Issue Driver License For The First Time";
            Load += frmIssueDriverLicenseFirstTime_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private DVLD.Application.LocalDrivingLicenseApplications.ctrlDrivingLicenseApplicationInfo ctrlDrivingLicenseApplicationInfo1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnIssueLicense;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}