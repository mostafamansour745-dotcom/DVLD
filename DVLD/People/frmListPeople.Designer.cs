namespace DVLD.People
{
    public class DarkMenuColorTable : ProfessionalColorTable
    {
        public override Color MenuItemSelected => Color.FromArgb(80, 65, 20);
        public override Color MenuItemSelectedGradientBegin => Color.FromArgb(80, 65, 20);
        public override Color MenuItemSelectedGradientEnd => Color.FromArgb(80, 65, 20);
        public override Color MenuItemBorder => Color.Gold;
        public override Color MenuItemPressedGradientBegin => Color.FromArgb(90, 72, 22);
        public override Color MenuItemPressedGradientEnd => Color.FromArgb(90, 72, 22);
        public override Color MenuBorder => Color.FromArgb(70, 70, 80);
        public override Color ToolStripDropDownBackground => Color.FromArgb(40, 40, 48);
        public override Color ImageMarginGradientBegin => Color.FromArgb(40, 40, 48);
        public override Color ImageMarginGradientMiddle => Color.FromArgb(40, 40, 48);
        public override Color ImageMarginGradientEnd => Color.FromArgb(40, 40, 48);
        public override Color SeparatorDark => Color.FromArgb(70, 70, 80);
        public override Color SeparatorLight => Color.FromArgb(70, 70, 80);
    }

    partial class frmListPeople
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListPeople));
            dgvPeople = new DataGridView();
            cmsPeople = new ContextMenuStrip(components);
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            sendEmailToolStripMenuItem = new ToolStripMenuItem();
            phoneCallToolStripMenuItem = new ToolStripMenuItem();
            lblTitle = new Label();
            lblRecords = new Label();
            lblRecordsCount = new Label();
            label1 = new Label();
            cbFilterBy = new ComboBox();
            txtFilterValue = new TextBox();
            btnClose = new Button();
            btnAddPerson = new Button();
            pbPersonImage = new PictureBox();
            pbAddPerson = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).BeginInit();
            cmsPeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAddPerson).BeginInit();
            SuspendLayout();
            // 
            // dgvPeople
            // 
            dgvPeople.AllowUserToAddRows = false;
            dgvPeople.AllowUserToDeleteRows = false;
            dgvPeople.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPeople.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPeople.BackgroundColor = Color.FromArgb(34, 34, 42);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(34, 34, 42);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Gold;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPeople.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeople.ContextMenuStrip = cmsPeople;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(44, 44, 52);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(80, 65, 20);
            dataGridViewCellStyle2.SelectionForeColor = Color.Gold;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPeople.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPeople.EnableHeadersVisualStyles = false;
            dgvPeople.GridColor = Color.FromArgb(60, 60, 70);
            dgvPeople.Location = new Point(16, 262);
            dgvPeople.Margin = new Padding(4, 5, 4, 5);
            dgvPeople.Name = "dgvPeople";
            dgvPeople.ReadOnly = true;
            dgvPeople.RowHeadersVisible = false;
            dgvPeople.RowHeadersWidth = 51;
            dgvPeople.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPeople.Size = new Size(1600, 508);
            dgvPeople.TabIndex = 0;

            dgvPeople.CellMouseDown += dgvPeople_CellMouseDown;
            dgvPeople.DoubleClick += dgvPeople_DoubleClick;
            // 
            // cmsPeople
            // 
            cmsPeople.BackColor = Color.FromArgb(40, 40, 48);
            cmsPeople.RenderMode = ToolStripRenderMode.Professional;
            cmsPeople.Renderer = new ToolStripProfessionalRenderer(new DarkMenuColorTable());
            cmsPeople.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            cmsPeople.ImageScalingSize = new Size(24, 24);
            cmsPeople.Items.AddRange(new ToolStripItem[] { showDetailsToolStripMenuItem, toolStripMenuItem1, editToolStripMenuItem, deleteToolStripMenuItem, sendEmailToolStripMenuItem, phoneCallToolStripMenuItem });
            cmsPeople.Name = "cmsPeople";
            cmsPeople.Size = new Size(241, 184);
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.ForeColor = Color.Gold;
            showDetailsToolStripMenuItem.Image = (Image)resources.GetObject("showDetailsToolStripMenuItem.Image");
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(240, 30);
            showDetailsToolStripMenuItem.Text = "Show Details";
            showDetailsToolStripMenuItem.Click += showDetailsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.ForeColor = Color.Gold;
            toolStripMenuItem1.Image = Properties.Resources.AddPerson_32;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(240, 30);
            toolStripMenuItem1.Text = "Add New Person";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.ForeColor = Color.Gold;
            editToolStripMenuItem.Image = Properties.Resources.edit_32;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(240, 30);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.ForeColor = Color.FromArgb(220, 80, 80);
            deleteToolStripMenuItem.Image = Properties.Resources.Delete_32_2;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(240, 30);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // sendEmailToolStripMenuItem
            // 
            sendEmailToolStripMenuItem.ForeColor = Color.Gold;
            sendEmailToolStripMenuItem.Image = Properties.Resources.send_email_32;
            sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            sendEmailToolStripMenuItem.Size = new Size(240, 30);
            sendEmailToolStripMenuItem.Text = "Send Email";
            sendEmailToolStripMenuItem.Click += sendEmailToolStripMenuItem_Click;
            // 
            // phoneCallToolStripMenuItem
            // 
            phoneCallToolStripMenuItem.ForeColor = Color.Gold;
            phoneCallToolStripMenuItem.Image = Properties.Resources.call_32;
            phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            phoneCallToolStripMenuItem.Size = new Size(240, 30);
            phoneCallToolStripMenuItem.Text = "Phone Call";
            phoneCallToolStripMenuItem.Click += phoneCallToolStripMenuItem_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Gold;
            lblTitle.Location = new Point(675, 158);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(269, 39);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Manage People";
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblRecords.ForeColor = Color.FromArgb(180, 180, 180);
            lblRecords.Location = new Point(16, 792);
            lblRecords.Margin = new Padding(4, 0, 4, 0);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(101, 20);
            lblRecords.TabIndex = 2;
            lblRecords.Text = "# Records:";
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblRecordsCount.ForeColor = Color.Gold;
            lblRecordsCount.Location = new Point(147, 792);
            lblRecordsCount.Margin = new Padding(4, 0, 4, 0);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(19, 20);
            lblRecordsCount.TabIndex = 3;
            lblRecordsCount.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(180, 180, 180);
            label1.Location = new Point(16, 211);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 4;
            label1.Text = "Filter By:";
            // 
            // cbFilterBy
            // 
            cbFilterBy.BackColor = Color.FromArgb(40, 40, 48);
            cbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterBy.FlatStyle = FlatStyle.Flat;
            cbFilterBy.ForeColor = Color.White;
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "Person ID", "National No.", "First Name", "Second Name", "Third Name", "Last Name", "Nationality", "Gendor", "Phone", "Email" });
            cbFilterBy.Location = new Point(133, 206);
            cbFilterBy.Margin = new Padding(4, 5, 4, 5);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(239, 28);
            cbFilterBy.TabIndex = 5;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // txtFilterValue
            // 
            txtFilterValue.BackColor = Color.FromArgb(40, 40, 48);
            txtFilterValue.BorderStyle = BorderStyle.FixedSingle;
            txtFilterValue.ForeColor = Color.White;
            txtFilterValue.Location = new Point(387, 206);
            txtFilterValue.Margin = new Padding(4, 5, 4, 5);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(266, 27);
            txtFilterValue.TabIndex = 6;
            txtFilterValue.Visible = false;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            txtFilterValue.KeyPress += txtFilterValue_KeyPress;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(30, 30, 36);
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(184, 134, 11);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1469, 782);
            btnClose.Margin = new Padding(4, 5, 4, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(147, 54);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnAddPerson
            // 
            btnAddPerson.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddPerson.BackColor = Color.FromArgb(30, 30, 36);
            btnAddPerson.FlatAppearance.BorderColor = Color.Gold;
            btnAddPerson.FlatStyle = FlatStyle.Flat;
            btnAddPerson.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnAddPerson.ForeColor = Color.Gold;
            btnAddPerson.Location = new Point(1469, 130);
            btnAddPerson.Margin = new Padding(4, 5, 4, 5);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.Size = new Size(147, 54);
            btnAddPerson.TabIndex = 8;
            btnAddPerson.Text = "+ Add";
            btnAddPerson.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddPerson.UseVisualStyleBackColor = false;
            btnAddPerson.Click += btnAddPerson_Click;
            // 
            // pbPersonImage
            // 
            pbPersonImage.Image = Properties.Resources.People_4002;
            pbPersonImage.Location = new Point(740, 15);
            pbPersonImage.Margin = new Padding(4, 5, 4, 5);
            pbPersonImage.Name = "pbPersonImage";
            pbPersonImage.Size = new Size(147, 138);
            pbPersonImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbPersonImage.TabIndex = 10;
            pbPersonImage.TabStop = false;
            // 
            // pbAddPerson
            // 
            pbAddPerson.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbAddPerson.BackColor = Color.Transparent;
            pbAddPerson.Location = new Point(1469, 15);
            pbAddPerson.Margin = new Padding(4, 5, 4, 5);
            pbAddPerson.Name = "pbAddPerson";
            pbAddPerson.Size = new Size(80, 80);
            pbAddPerson.SizeMode = PictureBoxSizeMode.Zoom;
            pbAddPerson.TabIndex = 11;
            pbAddPerson.TabStop = false;
            // 
            // frmListPeople
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 38, 46);
            CancelButton = btnClose;
            ClientSize = new Size(1632, 854);
            Controls.Add(pbAddPerson);
            Controls.Add(pbPersonImage);
            Controls.Add(btnAddPerson);
            Controls.Add(btnClose);
            Controls.Add(txtFilterValue);
            Controls.Add(cbFilterBy);
            Controls.Add(label1);
            Controls.Add(lblRecordsCount);
            Controls.Add(lblRecords);
            Controls.Add(lblTitle);
            Controls.Add(dgvPeople);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmListPeople";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage People";
            Load += frmListPeople_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPeople).EndInit();
            cmsPeople.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAddPerson).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.ContextMenuStrip cmsPeople;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.PictureBox pbAddPerson;
    }
}