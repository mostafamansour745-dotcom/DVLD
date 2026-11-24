namespace DVLD.Application.ApplicationTypes
{
    partial class frmEditApplicationTypes
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
            lblApplicationTypeID = new Label();
            label4 = new Label();
            txtTitle = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtFees = new TextBox();
            lblTitle = new Label();
            errorProvider1 = new ErrorProvider(components);
            btnSave = new Button();
            btnClose = new Button();
            pictureBox8 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lblApplicationTypeID
            // 
            lblApplicationTypeID.AutoSize = true;
            lblApplicationTypeID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApplicationTypeID.ForeColor = Color.Gold;
            lblApplicationTypeID.Location = new Point(117, 81);
            lblApplicationTypeID.Margin = new Padding(4, 0, 4, 0);
            lblApplicationTypeID.Name = "lblApplicationTypeID";
            lblApplicationTypeID.Size = new Size(48, 25);
            lblApplicationTypeID.TabIndex = 137;
            lblApplicationTypeID.Text = "???";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(28, 81);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(40, 25);
            label4.TabIndex = 136;
            label4.Text = "ID:";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.FromArgb(40, 40, 48);
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.ForeColor = Color.White;
            txtTitle.Location = new Point(115, 119);
            txtTitle.Margin = new Padding(4, 5, 4, 5);
            txtTitle.MaxLength = 50;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(282, 30);
            txtTitle.TabIndex = 130;
            txtTitle.Validating += txtTitle_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 119);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 132;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(13, 155);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 133;
            label2.Text = "Fees";
            // 
            // txtFees
            // 
            txtFees.BackColor = Color.FromArgb(40, 40, 48);
            txtFees.BorderStyle = BorderStyle.FixedSingle;
            txtFees.ForeColor = Color.White;
            txtFees.Location = new Point(115, 155);
            txtFees.Margin = new Padding(4, 5, 4, 5);
            txtFees.MaxLength = 50;
            txtFees.Name = "txtFees";
            txtFees.Size = new Size(282, 30);
            txtFees.TabIndex = 131;
            txtFees.Validating += txtFees_Validating;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Gold;
            lblTitle.Location = new Point(1, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(419, 39);
            lblTitle.TabIndex = 138;
            lblTitle.Text = "Update Application Type";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(30, 30, 36);
            btnSave.FlatAppearance.BorderColor = Color.Gold;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.Gold;
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(271, 201);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(126, 37);
            btnSave.TabIndex = 139;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(30, 30, 36);
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(184, 134, 11);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(137, 201);
            btnClose.Margin = new Padding(4, 5, 4, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(126, 37);
            btnClose.TabIndex = 140;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.ApplicationTitle;
            pictureBox8.Location = new Point(77, 117);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(31, 26);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 135;
            pictureBox8.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.money_32;
            pictureBox3.Location = new Point(77, 154);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 134;
            pictureBox3.TabStop = false;
            // 
            // frmEditApplicationTypes
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(38, 38, 46);
            CancelButton = btnClose;
            ClientSize = new Size(420, 258);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(lblTitle);
            Controls.Add(lblApplicationTypeID);
            Controls.Add(label4);
            Controls.Add(txtTitle);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtFees);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox3);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmEditApplicationTypes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Update Application Type";
            Load += frmEditApplicationType_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApplicationTypeID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFees;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}