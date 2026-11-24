using System.Drawing;
using System.Windows.Forms;

namespace DVLD.Tests.Controls
{
    partial class ctrlSecheduledTest
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbTestType = new GroupBox();
            lblTestID = new Label();
            label4 = new Label();
            pictureBox5 = new PictureBox();
            lblDate = new Label();
            pictureBox7 = new PictureBox();
            lblDrivingClass = new Label();
            label10 = new Label();
            pictureBox4 = new PictureBox();
            lblLocalDrivingLicenseAppID = new Label();
            label8 = new Label();
            lblFullName = new Label();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            lblTrial = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            lblFees = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            pictureBox8 = new PictureBox();
            lblTitle = new Label();
            pbTestTypeImage = new PictureBox();
            gbTestType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTestTypeImage).BeginInit();
            SuspendLayout();
            // 
            // gbTestType
            // 
            gbTestType.BackColor = Color.FromArgb(28, 30, 36);
            gbTestType.Controls.Add(lblTestID);
            gbTestType.Controls.Add(label4);
            gbTestType.Controls.Add(pictureBox5);
            gbTestType.Controls.Add(lblDate);
            gbTestType.Controls.Add(pictureBox7);
            gbTestType.Controls.Add(lblDrivingClass);
            gbTestType.Controls.Add(label10);
            gbTestType.Controls.Add(pictureBox4);
            gbTestType.Controls.Add(lblLocalDrivingLicenseAppID);
            gbTestType.Controls.Add(label8);
            gbTestType.Controls.Add(lblFullName);
            gbTestType.Controls.Add(pictureBox2);
            gbTestType.Controls.Add(label6);
            gbTestType.Controls.Add(lblTrial);
            gbTestType.Controls.Add(label5);
            gbTestType.Controls.Add(pictureBox1);
            gbTestType.Controls.Add(lblFees);
            gbTestType.Controls.Add(label2);
            gbTestType.Controls.Add(pictureBox3);
            gbTestType.Controls.Add(label1);
            gbTestType.Controls.Add(pictureBox8);
            gbTestType.Controls.Add(lblTitle);
            gbTestType.Controls.Add(pbTestTypeImage);
            gbTestType.Dock = DockStyle.Fill;
            gbTestType.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbTestType.ForeColor = Color.FromArgb(248, 250, 252);
            gbTestType.Location = new Point(0, 0);
            gbTestType.Margin = new Padding(0);
            gbTestType.Name = "gbTestType";
            gbTestType.Padding = new Padding(0);
            gbTestType.Size = new Size(520, 415);
            gbTestType.TabIndex = 153;
            gbTestType.TabStop = false;
            gbTestType.Text = "Scheduled Test";
            // 
            // pbTestTypeImage
            // 
            pbTestTypeImage.BackgroundImageLayout = ImageLayout.Zoom;
            pbTestTypeImage.Image = Properties.Resources.driving_test_512;
            pbTestTypeImage.InitialImage = null;
            pbTestTypeImage.Location = new Point(202, 16);
            pbTestTypeImage.Name = "pbTestTypeImage";
            pbTestTypeImage.Size = new Size(116, 90);
            pbTestTypeImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbTestTypeImage.TabIndex = 152;
            pbTestTypeImage.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 16.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Gold;
            lblTitle.Location = new Point(0, 110);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(520, 36);
            lblTitle.TabIndex = 153;
            lblTitle.Text = "Scheduled Test";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8 (D.L.App.ID)
            // 
            label8.AutoSize = false;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(148, 163, 184);
            label8.Location = new Point(70, 156);
            label8.Name = "label8";
            label8.Size = new Size(160, 26);
            label8.TabIndex = 167;
            label8.Text = "D.L.App.ID:";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Number_32;
            pictureBox4.Location = new Point(235, 156);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(26, 26);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 169;
            pictureBox4.TabStop = false;
            // 
            // lblLocalDrivingLicenseAppID
            // 
            lblLocalDrivingLicenseAppID.AutoSize = true;
            lblLocalDrivingLicenseAppID.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocalDrivingLicenseAppID.ForeColor = Color.Gold;
            lblLocalDrivingLicenseAppID.Location = new Point(268, 156);
            lblLocalDrivingLicenseAppID.Name = "lblLocalDrivingLicenseAppID";
            lblLocalDrivingLicenseAppID.Size = new Size(42, 26);
            lblLocalDrivingLicenseAppID.TabIndex = 168;
            lblLocalDrivingLicenseAppID.Text = "[??]";
            // 
            // label10 (D. Class)
            // 
            label10.AutoSize = false;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(148, 163, 184);
            label10.Location = new Point(70, 191);
            label10.Name = "label10";
            label10.Size = new Size(160, 26);
            label10.TabIndex = 170;
            label10.Text = "D. Class:";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.License_Type_32;
            pictureBox7.Location = new Point(235, 191);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(26, 26);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 187;
            pictureBox7.TabStop = false;
            // 
            // lblDrivingClass
            // 
            lblDrivingClass.AutoSize = true;
            lblDrivingClass.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrivingClass.ForeColor = Color.FromArgb(248, 250, 252);
            lblDrivingClass.Location = new Point(268, 191);
            lblDrivingClass.Name = "lblDrivingClass";
            lblDrivingClass.Size = new Size(90, 25);
            lblDrivingClass.TabIndex = 171;
            lblDrivingClass.Text = "[???????]";
            // 
            // label6 (Name)
            // 
            label6.AutoSize = false;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(148, 163, 184);
            label6.Location = new Point(70, 226);
            label6.Name = "label6";
            label6.Size = new Size(160, 26);
            label6.TabIndex = 163;
            label6.Text = "Name:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Person_32;
            pictureBox2.Location = new Point(235, 226);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 164;
            pictureBox2.TabStop = false;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullName.ForeColor = Color.FromArgb(248, 250, 252);
            lblFullName.Location = new Point(268, 226);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(90, 25);
            lblFullName.TabIndex = 165;
            lblFullName.Text = "[???????]";
            // 
            // label5 (Trial)
            // 
            label5.AutoSize = false;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(148, 163, 184);
            label5.Location = new Point(70, 261);
            label5.Name = "label5";
            label5.Size = new Size(160, 26);
            label5.TabIndex = 160;
            label5.Text = "Trial:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Count_32;
            pictureBox1.Location = new Point(235, 261);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 161;
            pictureBox1.TabStop = false;
            // 
            // lblTrial
            // 
            lblTrial.AutoSize = true;
            lblTrial.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTrial.ForeColor = Color.FromArgb(248, 250, 252);
            lblTrial.Location = new Point(268, 261);
            lblTrial.Name = "lblTrial";
            lblTrial.Size = new Size(42, 26);
            lblTrial.TabIndex = 162;
            lblTrial.Text = "[??]";
            // 
            // label1 (Date)
            // 
            label1.AutoSize = false;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(148, 163, 184);
            label10.Name = "label1";
            label1.Location = new Point(70, 296);
            label1.Name = "label1";
            label1.Size = new Size(160, 26);
            label1.TabIndex = 153;
            label1.Text = "Date:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.Calendar_32;
            pictureBox8.Location = new Point(235, 296);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(26, 26);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 154;
            pictureBox8.TabStop = false;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.FromArgb(248, 250, 252);
            lblDate.Location = new Point(268, 296);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(136, 25);
            lblDate.TabIndex = 188;
            lblDate.Text = "[dd/mm/yyyy]";
            // 
            // label2 (Fees)
            // 
            label2.AutoSize = false;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(148, 163, 184);
            label2.Location = new Point(70, 331);
            label2.Name = "label2";
            label2.Size = new Size(160, 26);
            label2.TabIndex = 157;
            label2.Text = "Fees:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.money_32;
            pictureBox3.Location = new Point(235, 331);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(26, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 158;
            pictureBox3.TabStop = false;
            // 
            // lblFees
            // 
            lblFees.AutoSize = true;
            lblFees.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFees.ForeColor = Color.FromArgb(16, 185, 129);
            lblFees.Location = new Point(268, 331);
            lblFees.Name = "lblFees";
            lblFees.Size = new Size(58, 26);
            lblFees.TabIndex = 159;
            lblFees.Text = "[$$$]";
            // 
            // label4 (Test ID)
            // 
            label4.AutoSize = false;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(148, 163, 184);
            label4.Location = new Point(70, 366);
            label4.Name = "label4";
            label4.Size = new Size(160, 26);
            label4.TabIndex = 189;
            label4.Text = "Test ID:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Number_32;
            pictureBox5.Location = new Point(235, 366);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(26, 26);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 190;
            pictureBox5.TabStop = false;
            // 
            // lblTestID
            // 
            lblTestID.AutoSize = true;
            lblTestID.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTestID.ForeColor = Color.Gold;
            lblTestID.Location = new Point(268, 366);
            lblTestID.Name = "lblTestID";
            lblTestID.Size = new Size(137, 25);
            lblTestID.TabIndex = 191;
            lblTestID.Text = "Not Taken Yet";
            // 
            // ctrlSecheduledTest
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 21, 25);
            Controls.Add(gbTestType);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(0);
            Name = "ctrlSecheduledTest";
            Size = new Size(520, 415);
            gbTestType.ResumeLayout(false);
            gbTestType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbTestTypeImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbTestType;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblDrivingClass;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblLocalDrivingLicenseAppID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTrial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbTestTypeImage;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTestID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}