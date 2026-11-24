namespace DVLD.Tests
{
    partial class frmScheduleTest
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
            ctrlScheduleTest1 = new DVLD.Tests.Controls.ctrlScheduleTest();
            btnClose = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // ctrlScheduleTest1
            // 
            ctrlScheduleTest1.BackColor = System.Drawing.Color.FromArgb(24, 25, 29);
            ctrlScheduleTest1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            ctrlScheduleTest1.ForeColor = System.Drawing.Color.White;
            ctrlScheduleTest1.Location = new System.Drawing.Point(-2, 3);
            ctrlScheduleTest1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ctrlScheduleTest1.Name = "ctrlScheduleTest1";
            ctrlScheduleTest1.Size = new System.Drawing.Size(567, 714);
            ctrlScheduleTest1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.AutoEllipsis = true;
            btnClose.BackColor = System.Drawing.Color.FromArgb(35, 38, 45);
            btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            btnClose.FlatAppearance.BorderSize = 2;
            btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(184, 134, 11);
            btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 45, 25);
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            btnClose.ForeColor = System.Drawing.Color.White;
            btnClose.Location = new System.Drawing.Point(209, 725);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(137, 38);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmScheduleTest
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(24, 25, 29);
            ClientSize = new System.Drawing.Size(584, 773);
            Controls.Add(btnClose);
            Controls.Add(ctrlScheduleTest1);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            ForeColor = System.Drawing.Color.White;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "frmScheduleTest";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Schedule Test";
            Load += frmScheduleTest_Load;
            ResumeLayout(false);
        }

        #endregion

        private Controls.ctrlScheduleTest ctrlScheduleTest1;
        private System.Windows.Forms.Button btnClose;
    }
}