namespace DVLD.Application.ApplicationTypes
{
    partial class frmListApplicationTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListApplicationTypes));
            lblTitle = new Label();
            lblRecordsCount = new Label();
            label2 = new Label();
            dgvApplicationTypes = new DataGridView();
            cmsApplicationTypes = new ContextMenuStrip(components);
            toolStripSeparator2 = new ToolStripSeparator();
            editToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            btnClose = new Button();
            pbApplicationTypesmage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvApplicationTypes).BeginInit();
            cmsApplicationTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbApplicationTypesmage).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Gold;
            lblTitle.Location = new Point(145, 211);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(446, 39);
            lblTitle.TabIndex = 111;
            lblTitle.Text = "Manage Application Types";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblRecordsCount.ForeColor = Color.Gold;
            lblRecordsCount.Location = new Point(129, 640);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(29, 20);
            lblRecordsCount.TabIndex = 109;
            lblRecordsCount.Text = "??";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(180, 180, 180);
            label2.Location = new Point(27, 640);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 108;
            label2.Text = "# Records:";
            // 
            // dgvApplicationTypes
            // 
            dgvApplicationTypes.AllowUserToAddRows = false;
            dgvApplicationTypes.AllowUserToDeleteRows = false;
            dgvApplicationTypes.AllowUserToResizeRows = false;
            dgvApplicationTypes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvApplicationTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvApplicationTypes.BackgroundColor = Color.FromArgb(34, 34, 42);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(34, 34, 42);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Gold;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvApplicationTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvApplicationTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvApplicationTypes.ContextMenuStrip = cmsApplicationTypes;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(44, 44, 52);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(80, 65, 20);
            dataGridViewCellStyle2.SelectionForeColor = Color.Gold;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvApplicationTypes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvApplicationTypes.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvApplicationTypes.EnableHeadersVisualStyles = false;
            dgvApplicationTypes.GridColor = Color.FromArgb(60, 60, 70);
            dgvApplicationTypes.Location = new Point(25, 271);
            dgvApplicationTypes.Margin = new Padding(4, 5, 4, 5);
            dgvApplicationTypes.MultiSelect = false;
            dgvApplicationTypes.Name = "dgvApplicationTypes";
            dgvApplicationTypes.ReadOnly = true;
            dgvApplicationTypes.RowHeadersVisible = false;
            dgvApplicationTypes.RowHeadersWidth = 51;
            dgvApplicationTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvApplicationTypes.Size = new Size(679, 354);
            dgvApplicationTypes.TabIndex = 104;
            dgvApplicationTypes.TabStop = false;
            dgvApplicationTypes.CellContentClick += dgvApplicationTypes_CellContentClick;
            // 
            // cmsApplicationTypes
            // 
            cmsApplicationTypes.BackColor = Color.FromArgb(40, 40, 48);
            cmsApplicationTypes.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            cmsApplicationTypes.ImageScalingSize = new Size(24, 24);
            cmsApplicationTypes.Items.AddRange(new ToolStripItem[] { toolStripSeparator2, editToolStripMenuItem, toolStripSeparator1 });
            cmsApplicationTypes.Name = "contextMenuStrip1";
            cmsApplicationTypes.Size = new Size(289, 54);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(285, 6);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.ForeColor = Color.Gold;
            editToolStripMenuItem.Image = Properties.Resources.edit_32;
            editToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(288, 38);
            editToolStripMenuItem.Text = "&Edit Application Type";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click; ;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(285, 6);
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
            btnClose.Location = new Point(569, 633);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(135, 36);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pbApplicationTypesmage
            // 
            pbApplicationTypesmage.BackgroundImageLayout = ImageLayout.Zoom;
            pbApplicationTypesmage.Image = (Image)resources.GetObject("pbApplicationTypesmage.Image");
            pbApplicationTypesmage.InitialImage = null;
            pbApplicationTypesmage.Location = new Point(269, 6);
            pbApplicationTypesmage.Margin = new Padding(4, 5, 4, 5);
            pbApplicationTypesmage.Name = "pbApplicationTypesmage";
            pbApplicationTypesmage.Size = new Size(220, 189);
            pbApplicationTypesmage.SizeMode = PictureBoxSizeMode.Zoom;
            pbApplicationTypesmage.TabIndex = 110;
            pbApplicationTypesmage.TabStop = false;
            // 
            // frmListApplicationTypes
            // 
            AcceptButton = btnClose;
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 38, 46);
            CancelButton = btnClose;
            ClientSize = new Size(719, 695);
            Controls.Add(btnClose);
            Controls.Add(lblTitle);
            Controls.Add(pbApplicationTypesmage);
            Controls.Add(lblRecordsCount);
            Controls.Add(label2);
            Controls.Add(dgvApplicationTypes);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmListApplicationTypes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Manage Application Types";
            Load += frmListApplicationTypes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvApplicationTypes).EndInit();
            cmsApplicationTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbApplicationTypesmage).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbApplicationTypesmage;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvApplicationTypes;
        private System.Windows.Forms.ContextMenuStrip cmsApplicationTypes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}