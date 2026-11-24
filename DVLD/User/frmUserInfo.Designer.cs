using System.Windows.Forms;
using DVLD.User;

namespace DVLD.User
{
    partial class frmUserInfo
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
            ctrlUserCard1 = new ctrlUserCard();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(30, 30, 36);
            btnClose.Cursor = Cursors.Hand;
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.FlatAppearance.BorderColor = Color.Goldenrod;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 45, 25);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(660, 506);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(139, 55);
            btnClose.TabIndex = 17;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // ctrlUserCard1
            // 
            ctrlUserCard1.BackColor = Color.FromArgb(25, 25, 30);
            ctrlUserCard1.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlUserCard1.Location = new Point(12, 49);
            ctrlUserCard1.Margin = new Padding(3, 4, 3, 4);
            ctrlUserCard1.Name = "ctrlUserCard1";
            ctrlUserCard1.Size = new Size(837, 434);
            ctrlUserCard1.TabIndex = 0;
            ctrlUserCard1.Load += ctrlUserCard1_Load;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Gold;
            lblTitle.Location = new Point(32, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(735, 36);
            lblTitle.TabIndex = 89;
            lblTitle.Text = "User Details";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmUserInfo
            // 
            AcceptButton = btnClose;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 38, 46);
            CancelButton = btnClose;
            ClientSize = new Size(850, 585);
            Controls.Add(lblTitle);
            Controls.Add(btnClose);
            Controls.Add(ctrlUserCard1);
            Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmUserInfo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "User Details";
            ResumeLayout(false);

        }

        #endregion

        private ctrlUserCard ctrlUserCard1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
    }
}