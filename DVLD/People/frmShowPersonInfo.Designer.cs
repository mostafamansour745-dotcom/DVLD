using System.Windows.Forms;
using DVLD.People.Controls;

namespace DVLD.People
{
    partial class frmShowPersonInfo
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
            btnClose = new Button();
            ctrlPersonCard1 = new ctrlPersonCard();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(35, 38, 45);
            btnClose.Cursor = Cursors.Hand;
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.FlatAppearance.BorderColor = Color.Goldenrod;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 45, 25);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(642, 378);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(110, 34);
            btnClose.TabIndex = 17;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.BackColor = Color.FromArgb(24, 25, 29);
            ctrlPersonCard1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlPersonCard1.Location = new Point(10, 56);
            ctrlPersonCard1.Margin = new Padding(3, 4, 3, 4);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(742, 312);
            ctrlPersonCard1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Goldenrod;
            lblTitle.Location = new Point(10, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(735, 36);
            lblTitle.TabIndex = 89;
            lblTitle.Text = "Person Details";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmShowPersonInfo
            // 
            AcceptButton = btnClose;
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 25, 29);
            CancelButton = btnClose;
            ClientSize = new Size(762, 424);
            Controls.Add(lblTitle);
            Controls.Add(btnClose);
            Controls.Add(ctrlPersonCard1);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmShowPersonInfo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Person Details";
            ResumeLayout(false);

        }

        #endregion

        private ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
    }
}