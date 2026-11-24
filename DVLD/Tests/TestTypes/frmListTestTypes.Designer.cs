namespace DVLD.Tests.TestTypes
{
    partial class frmListTestTypes
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
            lblTitle = new Label();
            lblRecordsCount = new Label();
            label2 = new Label();
            dgvTestTypes = new DataGridView();
            cmsTestTypes = new ContextMenuStrip(components);
            toolStripSeparator2 = new ToolStripSeparator();
            editToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            btnClose = new Button();
            pbApplicationTypesmage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvTestTypes).BeginInit();
            cmsTestTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbApplicationTypesmage).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Gold;
            lblTitle.Location = new Point(274, 223);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(446, 39);
            lblTitle.TabIndex = 117;
            lblTitle.Text = "Manage Test Types";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblRecordsCount.ForeColor = Color.Gold;
            lblRecordsCount.Location = new Point(117, 647);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(29, 20);
            lblRecordsCount.TabIndex = 115;
            lblRecordsCount.Text = "??";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(180, 180, 180);
            label2.Location = new Point(15, 647);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 114;
            label2.Text = "# Records:";
            // 
            // dgvTestTypes
            // 
            dgvTestTypes.AllowUserToAddRows = false;
            dgvTestTypes.AllowUserToDeleteRows = false;
            dgvTestTypes.AllowUserToResizeRows = false;
            dgvTestTypes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTestTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTestTypes.BackgroundColor = Color.FromArgb(34, 34, 42);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(34, 34, 42);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Gold;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTestTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTestTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTestTypes.ContextMenuStrip = cmsTestTypes;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(44, 44, 52);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(80, 65, 20);
            dataGridViewCellStyle2.SelectionForeColor = Color.Gold;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTestTypes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTestTypes.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvTestTypes.EnableHeadersVisualStyles = false;
            dgvTestTypes.GridColor = Color.FromArgb(60, 60, 70);
            dgvTestTypes.Location = new Point(13, 278);
            dgvTestTypes.Margin = new Padding(4, 5, 4, 5);
            dgvTestTypes.MultiSelect = false;
            dgvTestTypes.Name = "dgvTestTypes";
            dgvTestTypes.ReadOnly = true;
            dgvTestTypes.RowHeadersVisible = false;
            dgvTestTypes.RowHeadersWidth = 51;
            dgvTestTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTestTypes.Size = new Size(931, 354);
            dgvTestTypes.TabIndex = 113;
            dgvTestTypes.TabStop = false;
            // 
            // cmsTestTypes
            // 
            cmsTestTypes.BackColor = Color.FromArgb(40, 40, 48);
            cmsTestTypes.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            cmsTestTypes.ImageScalingSize = new Size(24, 24);
            cmsTestTypes.Items.AddRange(new ToolStripItem[] { toolStripSeparator2, editToolStripMenuItem, toolStripSeparator1 });
            cmsTestTypes.Name = "contextMenuStrip1";
            cmsTestTypes.Size = new Size(221, 54);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(217, 6);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.ForeColor = Color.Gold;
            editToolStripMenuItem.Image = Properties.Resources.edit_32;
            editToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(220, 38);
            editToolStripMenuItem.Text = "&Edit Test Type";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(217, 6);
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.AutoEllipsis = true;
            btnClose.BackColor = Color.FromArgb(30, 30, 36);
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(184, 134, 11);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(809, 639);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(135, 36);
            btnClose.TabIndex = 112;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pbApplicationTypesmage
            // 
            pbApplicationTypesmage.BackgroundImageLayout = ImageLayout.Zoom;
            pbApplicationTypesmage.Image = Properties.Resources.TestType_512;
            pbApplicationTypesmage.InitialImage = null;
            pbApplicationTypesmage.Location = new Point(398, 18);
            pbApplicationTypesmage.Margin = new Padding(4, 5, 4, 5);
            pbApplicationTypesmage.Name = "pbApplicationTypesmage";
            pbApplicationTypesmage.Size = new Size(220, 189);
            pbApplicationTypesmage.SizeMode = PictureBoxSizeMode.Zoom;
            pbApplicationTypesmage.TabIndex = 116;
            pbApplicationTypesmage.TabStop = false;
            // 
            // frmListTestTypes
            // 
            AcceptButton = btnClose;
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 38, 46);
            CancelButton = btnClose;
            ClientSize = new Size(954, 692);
            Controls.Add(lblTitle);
            Controls.Add(pbApplicationTypesmage);
            Controls.Add(lblRecordsCount);
            Controls.Add(label2);
            Controls.Add(dgvTestTypes);
            Controls.Add(btnClose);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmListTestTypes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "List Test Types";
            Load += frmListTestTypes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTestTypes).EndInit();
            cmsTestTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbApplicationTypesmage).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbApplicationTypesmage;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTestTypes;
        private System.Windows.Forms.ContextMenuStrip cmsTestTypes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btnClose;
    }
}