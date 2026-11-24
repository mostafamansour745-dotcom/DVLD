namespace DVLD.Tests
{
    partial class frmTakeTest
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
            ctrlSecheduledTest1 = new DVLD.Tests.Controls.ctrlSecheduledTest();
            lblResult = new Label();
            pictureBox1 = new PictureBox();
            rbPass = new RadioButton();
            rbFail = new RadioButton();
            lblUserMessage = new Label();
            lblNotes = new Label();
            pictureBox2 = new PictureBox();
            txtNotes = new TextBox();
            btnClose = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // ctrlSecheduledTest1
            // 
            ctrlSecheduledTest1.BackColor = Color.FromArgb(25, 25, 30);
            ctrlSecheduledTest1.Dock = DockStyle.Top;
            ctrlSecheduledTest1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlSecheduledTest1.ForeColor = Color.White;
            ctrlSecheduledTest1.Location = new Point(0, 0);
            ctrlSecheduledTest1.Margin = new Padding(0);
            ctrlSecheduledTest1.Name = "ctrlSecheduledTest1";
            ctrlSecheduledTest1.Size = new Size(530, 415);
            ctrlSecheduledTest1.TabIndex = 0;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.ForeColor = Color.FromArgb(212, 175, 55);
            lblResult.Location = new Point(25, 432);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(71, 25);
            lblResult.TabIndex = 1;
            lblResult.Text = "Result:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Number_32;
            pictureBox1.Location = new Point(105, 428);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // rbPass
            // 
            rbPass.AutoSize = true;
            rbPass.Checked = true;
            rbPass.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbPass.ForeColor = Color.LimeGreen;
            rbPass.Location = new Point(145, 429);
            rbPass.Name = "rbPass";
            rbPass.Size = new Size(71, 29);
            rbPass.TabIndex = 3;
            rbPass.TabStop = true;
            rbPass.Text = "Pass";
            rbPass.UseVisualStyleBackColor = true;
            // 
            // rbFail
            // 
            rbFail.AutoSize = true;
            rbFail.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbFail.ForeColor = Color.FromArgb(235, 87, 87);
            rbFail.Location = new Point(225, 429);
            rbFail.Name = "rbFail";
            rbFail.Size = new Size(62, 29);
            rbFail.TabIndex = 4;
            rbFail.Text = "Fail";
            rbFail.UseVisualStyleBackColor = true;
            // 
            // lblUserMessage
            // 
            lblUserMessage.AutoSize = true;
            lblUserMessage.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserMessage.ForeColor = Color.FromArgb(235, 87, 87);
            lblUserMessage.Location = new Point(295, 432);
            lblUserMessage.Name = "lblUserMessage";
            lblUserMessage.Size = new Size(225, 23);
            lblUserMessage.TabIndex = 5;
            lblUserMessage.Text = "You cannot change results";
            lblUserMessage.Visible = false;
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNotes.ForeColor = Color.FromArgb(212, 175, 55);
            lblNotes.Location = new Point(25, 477);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(69, 25);
            lblNotes.TabIndex = 6;
            lblNotes.Text = "Notes:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Notes_32;
            pictureBox2.Location = new Point(105, 473);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // txtNotes
            // 
            txtNotes.BackColor = Color.FromArgb(37, 37, 45);
            txtNotes.BorderStyle = BorderStyle.FixedSingle;
            txtNotes.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNotes.ForeColor = Color.White;
            txtNotes.Location = new Point(145, 473);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(360, 100);
            txtNotes.TabIndex = 8;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(50, 50, 60);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(220, 590);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(130, 42);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.TextAlign = ContentAlignment.MiddleRight;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(212, 175, 55);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Black;
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(360, 590);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 42);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // frmTakeTest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 30);
            ClientSize = new Size(530, 650);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(txtNotes);
            Controls.Add(pictureBox2);
            Controls.Add(lblNotes);
            Controls.Add(lblUserMessage);
            Controls.Add(rbFail);
            Controls.Add(rbPass);
            Controls.Add(pictureBox1);
            Controls.Add(lblResult);
            Controls.Add(ctrlSecheduledTest1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmTakeTest";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Take Test";
            Load += frmTakeTest_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.ctrlSecheduledTest ctrlSecheduledTest1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbPass;
        private System.Windows.Forms.RadioButton rbFail;
        private System.Windows.Forms.Label lblUserMessage;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}