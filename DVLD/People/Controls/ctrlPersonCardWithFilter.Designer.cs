namespace DVLD.Controls
{
    partial class ctrlPersonCardWithFilter
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlPersonCardWithFilter));
            errorProvider1 = new ErrorProvider(components);
            gbFilters = new GroupBox();
            btnAddNewPerson = new Button();
            btnFind = new Button();
            cbFilterBy = new ComboBox();
            txtFilterValue = new TextBox();
            label1 = new Label();
            ctrlPersonCard1 = new DVLD.People.Controls.ctrlPersonCard();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            gbFilters.SuspendLayout();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // gbFilters
            // 
            gbFilters.BackColor = Color.Transparent;
            gbFilters.Controls.Add(btnAddNewPerson);
            gbFilters.Controls.Add(btnFind);
            gbFilters.Controls.Add(cbFilterBy);
            gbFilters.Controls.Add(txtFilterValue);
            gbFilters.Controls.Add(label1);
            gbFilters.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbFilters.ForeColor = Color.White;
            gbFilters.Location = new Point(10, 10);
            gbFilters.Name = "gbFilters";
            gbFilters.Size = new Size(836, 75);
            gbFilters.TabIndex = 16;
            gbFilters.TabStop = false;
            gbFilters.Text = "Filter";
            // 
            // btnAddNewPerson
            // 
            btnAddNewPerson.BackColor = Color.FromArgb(45, 45, 52);
            btnAddNewPerson.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 90);
            btnAddNewPerson.FlatStyle = FlatStyle.Flat;
            btnAddNewPerson.ForeColor = Color.White;
            btnAddNewPerson.Image = (Image)resources.GetObject("btnAddNewPerson.Image");
            btnAddNewPerson.Location = new Point(525, 21);
            btnAddNewPerson.Margin = new Padding(4, 5, 4, 5);
            btnAddNewPerson.Name = "btnAddNewPerson";
            btnAddNewPerson.Size = new Size(40, 38);
            btnAddNewPerson.TabIndex = 20;
            btnAddNewPerson.UseVisualStyleBackColor = false;
            btnAddNewPerson.Click += btnAddNewPerson_Click;
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.FromArgb(45, 45, 52);
            btnFind.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 90);
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.ForeColor = Color.White;
            btnFind.Image = Properties.Resources.SearchPerson;
            btnFind.Location = new Point(475, 21);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(40, 38);
            btnFind.TabIndex = 18;
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // cbFilterBy
            // 
            cbFilterBy.BackColor = Color.FromArgb(45, 45, 52);
            cbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterBy.FlatStyle = FlatStyle.Flat;
            cbFilterBy.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFilterBy.ForeColor = Color.White;
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "National No.", "Person ID" });
            cbFilterBy.Location = new Point(90, 26);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(180, 29);
            cbFilterBy.TabIndex = 16;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // txtFilterValue
            // 
            txtFilterValue.BackColor = Color.FromArgb(45, 45, 52);
            txtFilterValue.BorderStyle = BorderStyle.FixedSingle;
            txtFilterValue.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFilterValue.ForeColor = Color.White;
            txtFilterValue.Location = new Point(280, 26);
            txtFilterValue.Margin = new Padding(4, 5, 4, 5);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(180, 29);
            txtFilterValue.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 30);
            label1.Name = "label1";
            label1.Size = new Size(70, 21);
            label1.TabIndex = 19;
            label1.Text = "Find By:";
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.BackColor = Color.Transparent;
            ctrlPersonCard1.BorderStyle = BorderStyle.FixedSingle;
            ctrlPersonCard1.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlPersonCard1.Location = new Point(6, 131);
            ctrlPersonCard1.Margin = new Padding(6, 8, 6, 8);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(836, 377);
            ctrlPersonCard1.TabIndex = 0;
            // 
            // ctrlPersonCardWithFilter
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(25, 25, 30);
            Controls.Add(gbFilters);
            Controls.Add(ctrlPersonCard1);
            Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ctrlPersonCardWithFilter";
            Size = new Size(849, 523);
            
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            gbFilters.ResumeLayout(false);
            gbFilters.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private DVLD.People.Controls.ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.Button btnAddNewPerson;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Label label1;
    }
}