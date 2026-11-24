namespace DVLD.People
{
    partial class frmFindPerson
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
            lblTitle = new Label();
            ctrlPersonCardWithFilter1 = new DVLD.Controls.ctrlPersonCardWithFilter();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Goldenrod;
            lblTitle.Location = new Point(7, 23);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(884, 54);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Find Person";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ctrlPersonCardWithFilter1
            // 
            ctrlPersonCardWithFilter1.AutoValidate = AutoValidate.EnableAllowFocusChange;
            ctrlPersonCardWithFilter1.BackColor = Color.FromArgb(24, 25, 29);
            ctrlPersonCardWithFilter1.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlPersonCardWithFilter1.Location = new Point(25, 85);
            ctrlPersonCardWithFilter1.Margin = new Padding(5, 8, 5, 8);
            ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            ctrlPersonCardWithFilter1.Size = new Size(865, 517);
            ctrlPersonCardWithFilter1.TabIndex = 1;
            // 
            // frmFindPerson
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 25, 29);
            ClientSize = new Size(904, 629);
            Controls.Add(ctrlPersonCardWithFilter1);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmFindPerson";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Find Person";
           
            ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitle;
        private DVLD.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
      
        #endregion

       
    }
}