namespace hospital_automation
{
    partial class Doctorformcs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctorformcs));
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbxBranch = new System.Windows.Forms.ComboBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblBranch = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.mtxtTC = new System.Windows.Forms.MaskedTextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.dtDoctors = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtDoctors)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(30, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 24);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Ad:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(146, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(161, 32);
            this.txtName.TabIndex = 1;
            // 
            // cbxBranch
            // 
            this.cbxBranch.FormattingEnabled = true;
            this.cbxBranch.Location = new System.Drawing.Point(146, 109);
            this.cbxBranch.Name = "cbxBranch";
            this.cbxBranch.Size = new System.Drawing.Size(161, 32);
            this.cbxBranch.TabIndex = 3;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSurname.Location = new System.Drawing.Point(30, 74);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(68, 24);
            this.lblSurname.TabIndex = 31;
            this.lblSurname.Text = "Soyad:";
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBranch.Location = new System.Drawing.Point(30, 112);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(63, 24);
            this.lblBranch.TabIndex = 32;
            this.lblBranch.Text = "Branş:";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTC.Location = new System.Drawing.Point(31, 150);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(38, 24);
            this.lblTC.TabIndex = 33;
            this.lblTC.Text = "TC:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(31, 188);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(54, 24);
            this.lblPassword.TabIndex = 34;
            this.lblPassword.Text = "Şifre:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(146, 71);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(161, 32);
            this.txtSurname.TabIndex = 2;
            // 
            // mtxtTC
            // 
            this.mtxtTC.Location = new System.Drawing.Point(146, 147);
            this.mtxtTC.Mask = "00000000000";
            this.mtxtTC.Name = "mtxtTC";
            this.mtxtTC.Size = new System.Drawing.Size(161, 32);
            this.mtxtTC.TabIndex = 4;
            this.mtxtTC.ValidatingType = typeof(int);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(146, 185);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(161, 32);
            this.txtPassword.TabIndex = 5;
            // 
            // dtDoctors
            // 
            this.dtDoctors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtDoctors.BackgroundColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtDoctors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtDoctors.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtDoctors.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtDoctors.Location = new System.Drawing.Point(342, 3);
            this.dtDoctors.Name = "dtDoctors";
            this.dtDoctors.RowHeadersWidth = 51;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.dtDoctors.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dtDoctors.RowTemplate.Height = 29;
            this.dtDoctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtDoctors.Size = new System.Drawing.Size(830, 354);
            this.dtDoctors.TabIndex = 38;
            this.dtDoctors.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtDoctors_CellDoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(146, 237);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(161, 32);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(146, 275);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(161, 32);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(146, 313);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(161, 32);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(33, 241);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 24);
            this.lblID.TabIndex = 39;
            this.lblID.Visible = false;
            // 
            // Doctorformcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(1174, 361);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtDoctors);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.mtxtTC);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.lblBranch);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.cbxBranch);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Doctorformcs";
            this.Text = "Doktor Paneli";
            this.Load += new System.EventHandler(this.Doctorformcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtDoctors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbxBranch;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.MaskedTextBox mtxtTC;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.DataGridView dtDoctors;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblID;
    }
}