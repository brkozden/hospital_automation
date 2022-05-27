namespace hospital_automation
{
    partial class SecretaryDetailsform
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecretaryDetailsform));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNameSurname1 = new System.Windows.Forms.Label();
            this.lblTC2 = new System.Windows.Forms.Label();
            this.lblTC1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAnnouncementCreate = new System.Windows.Forms.Button();
            this.rtxtAnnouncement = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.chbxStatus = new System.Windows.Forms.CheckBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.cbbxDoctor = new System.Windows.Forms.ComboBox();
            this.cbbxBranch = new System.Windows.Forms.ComboBox();
            this.mtxtTime = new System.Windows.Forms.MaskedTextBox();
            this.mtxtDate = new System.Windows.Forms.MaskedTextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblPatientTC = new System.Windows.Forms.Label();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblBranch = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtBranch = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtDoctors = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnAppointmentList = new System.Windows.Forms.Button();
            this.btnBranch = new System.Windows.Forms.Button();
            this.btnDoctor = new System.Windows.Forms.Button();
            this.btnAnnouncements = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtBranch)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDoctors)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSurname);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblNameSurname1);
            this.groupBox1.Controls.Add(this.lblTC2);
            this.groupBox1.Controls.Add(this.lblTC1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Secreter Bilgi";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSurname.Location = new System.Drawing.Point(134, 117);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(40, 22);
            this.lblSurname.TabIndex = 19;
            this.lblSurname.Text = "Null";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(134, 91);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 22);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Null";
            // 
            // lblNameSurname1
            // 
            this.lblNameSurname1.AutoSize = true;
            this.lblNameSurname1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNameSurname1.Location = new System.Drawing.Point(32, 91);
            this.lblNameSurname1.Name = "lblNameSurname1";
            this.lblNameSurname1.Size = new System.Drawing.Size(96, 24);
            this.lblNameSurname1.TabIndex = 17;
            this.lblNameSurname1.Text = "Ad Soyad:";
            // 
            // lblTC2
            // 
            this.lblTC2.AutoSize = true;
            this.lblTC2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTC2.Location = new System.Drawing.Point(163, 53);
            this.lblTC2.Name = "lblTC2";
            this.lblTC2.Size = new System.Drawing.Size(120, 24);
            this.lblTC2.TabIndex = 16;
            this.lblTC2.Text = "00000000000";
            // 
            // lblTC1
            // 
            this.lblTC1.AutoSize = true;
            this.lblTC1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTC1.Location = new System.Drawing.Point(32, 53);
            this.lblTC1.Name = "lblTC1";
            this.lblTC1.Size = new System.Drawing.Size(125, 24);
            this.lblTC1.TabIndex = 15;
            this.lblTC1.Text = "TC Kimlik No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAnnouncementCreate);
            this.groupBox2.Controls.Add(this.rtxtAnnouncement);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(12, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 276);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // btnAnnouncementCreate
            // 
            this.btnAnnouncementCreate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAnnouncementCreate.Location = new System.Drawing.Point(6, 219);
            this.btnAnnouncementCreate.Name = "btnAnnouncementCreate";
            this.btnAnnouncementCreate.Size = new System.Drawing.Size(303, 35);
            this.btnAnnouncementCreate.TabIndex = 2;
            this.btnAnnouncementCreate.Text = "Oluştur";
            this.btnAnnouncementCreate.UseVisualStyleBackColor = true;
            this.btnAnnouncementCreate.Click += new System.EventHandler(this.btnAnnouncementCreate_Click);
            // 
            // rtxtAnnouncement
            // 
            this.rtxtAnnouncement.Location = new System.Drawing.Point(6, 31);
            this.rtxtAnnouncement.Name = "rtxtAnnouncement";
            this.rtxtAnnouncement.Size = new System.Drawing.Size(303, 178);
            this.rtxtAnnouncement.TabIndex = 2;
            this.rtxtAnnouncement.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.chbxStatus);
            this.groupBox3.Controls.Add(this.maskedTextBox3);
            this.groupBox3.Controls.Add(this.cbbxDoctor);
            this.groupBox3.Controls.Add(this.cbbxBranch);
            this.groupBox3.Controls.Add(this.mtxtTime);
            this.groupBox3.Controls.Add(this.mtxtDate);
            this.groupBox3.Controls.Add(this.txtID);
            this.groupBox3.Controls.Add(this.lblPatientTC);
            this.groupBox3.Controls.Add(this.lblDoctor);
            this.groupBox3.Controls.Add(this.lblBranch);
            this.groupBox3.Controls.Add(this.lblTime);
            this.groupBox3.Controls.Add(this.lblDate);
            this.groupBox3.Controls.Add(this.lblID);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(333, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 465);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Paneli";
            // 
            // btnSave
            // 
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(5, 394);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(289, 49);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chbxStatus
            // 
            this.chbxStatus.AutoSize = true;
            this.chbxStatus.Location = new System.Drawing.Point(122, 281);
            this.chbxStatus.Name = "chbxStatus";
            this.chbxStatus.Size = new System.Drawing.Size(89, 28);
            this.chbxStatus.TabIndex = 31;
            this.chbxStatus.Text = "Durum";
            this.chbxStatus.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(122, 240);
            this.maskedTextBox3.Mask = "00000000000";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(161, 32);
            this.maskedTextBox3.TabIndex = 30;
            this.maskedTextBox3.ValidatingType = typeof(int);
            // 
            // cbbxDoctor
            // 
            this.cbbxDoctor.FormattingEnabled = true;
            this.cbbxDoctor.Location = new System.Drawing.Point(122, 202);
            this.cbbxDoctor.Name = "cbbxDoctor";
            this.cbbxDoctor.Size = new System.Drawing.Size(161, 32);
            this.cbbxDoctor.TabIndex = 29;
            // 
            // cbbxBranch
            // 
            this.cbbxBranch.FormattingEnabled = true;
            this.cbbxBranch.Location = new System.Drawing.Point(122, 164);
            this.cbbxBranch.Name = "cbbxBranch";
            this.cbbxBranch.Size = new System.Drawing.Size(161, 32);
            this.cbbxBranch.TabIndex = 28;
            this.cbbxBranch.SelectedIndexChanged += new System.EventHandler(this.cbbxBranch_SelectedIndexChanged);
            // 
            // mtxtTime
            // 
            this.mtxtTime.Location = new System.Drawing.Point(122, 126);
            this.mtxtTime.Mask = "00:00";
            this.mtxtTime.Name = "mtxtTime";
            this.mtxtTime.Size = new System.Drawing.Size(161, 32);
            this.mtxtTime.TabIndex = 27;
            this.mtxtTime.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtDate
            // 
            this.mtxtDate.Location = new System.Drawing.Point(122, 88);
            this.mtxtDate.Mask = "00/00/0000";
            this.mtxtDate.Name = "mtxtDate";
            this.mtxtDate.Size = new System.Drawing.Size(161, 32);
            this.mtxtDate.TabIndex = 26;
            this.mtxtDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(122, 50);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(161, 32);
            this.txtID.TabIndex = 25;
            // 
            // lblPatientTC
            // 
            this.lblPatientTC.AutoSize = true;
            this.lblPatientTC.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPatientTC.Location = new System.Drawing.Point(21, 243);
            this.lblPatientTC.Name = "lblPatientTC";
            this.lblPatientTC.Size = new System.Drawing.Size(89, 24);
            this.lblPatientTC.TabIndex = 23;
            this.lblPatientTC.Text = "Hasta TC:";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDoctor.Location = new System.Drawing.Point(21, 205);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(69, 24);
            this.lblDoctor.TabIndex = 22;
            this.lblDoctor.Text = "Doktor";
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBranch.Location = new System.Drawing.Point(21, 167);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(63, 24);
            this.lblBranch.TabIndex = 21;
            this.lblBranch.Text = "Branş:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.Location = new System.Drawing.Point(21, 129);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(53, 24);
            this.lblTime.TabIndex = 20;
            this.lblTime.Text = "Saat:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(21, 91);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(58, 24);
            this.lblDate.TabIndex = 19;
            this.lblDate.Text = "Tarih:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblID.Location = new System.Drawing.Point(21, 53);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(33, 24);
            this.lblID.TabIndex = 18;
            this.lblID.Text = "ID:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtBranch);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox4.Location = new System.Drawing.Point(639, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(403, 229);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // dtBranch
            // 
            this.dtBranch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtBranch.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dtBranch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtBranch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtBranch.ColumnHeadersHeight = 29;
            this.dtBranch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtBranch.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtBranch.Location = new System.Drawing.Point(3, 28);
            this.dtBranch.Name = "dtBranch";
            this.dtBranch.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtBranch.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dtBranch.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtBranch.RowTemplate.Height = 29;
            this.dtBranch.Size = new System.Drawing.Size(397, 198);
            this.dtBranch.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtDoctors);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox5.Location = new System.Drawing.Point(639, 248);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(403, 342);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // dtDoctors
            // 
            this.dtDoctors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtDoctors.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dtDoctors.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtDoctors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtDoctors.ColumnHeadersHeight = 29;
            this.dtDoctors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtDoctors.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtDoctors.Location = new System.Drawing.Point(3, 28);
            this.dtDoctors.Name = "dtDoctors";
            this.dtDoctors.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtDoctors.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dtDoctors.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtDoctors.RowTemplate.Height = 29;
            this.dtDoctors.Size = new System.Drawing.Size(397, 311);
            this.dtDoctors.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnAnnouncements);
            this.groupBox6.Controls.Add(this.btnAppointmentList);
            this.groupBox6.Controls.Add(this.btnBranch);
            this.groupBox6.Controls.Add(this.btnDoctor);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox6.Location = new System.Drawing.Point(12, 483);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(621, 107);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hızlı Erişim";
            // 
            // btnAppointmentList
            // 
            this.btnAppointmentList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAppointmentList.Location = new System.Drawing.Point(326, 38);
            this.btnAppointmentList.Name = "btnAppointmentList";
            this.btnAppointmentList.Size = new System.Drawing.Size(152, 45);
            this.btnAppointmentList.TabIndex = 2;
            this.btnAppointmentList.Text = "Randevu Listesi";
            this.btnAppointmentList.UseVisualStyleBackColor = true;
            this.btnAppointmentList.Click += new System.EventHandler(this.btnAppointmentList_Click);
            // 
            // btnBranch
            // 
            this.btnBranch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBranch.Location = new System.Drawing.Point(182, 38);
            this.btnBranch.Name = "btnBranch";
            this.btnBranch.Size = new System.Drawing.Size(127, 45);
            this.btnBranch.TabIndex = 1;
            this.btnBranch.Text = "Branş Paneli ";
            this.btnBranch.UseVisualStyleBackColor = true;
            this.btnBranch.Click += new System.EventHandler(this.btnBranch_Click);
            // 
            // btnDoctor
            // 
            this.btnDoctor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDoctor.Location = new System.Drawing.Point(11, 38);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(146, 45);
            this.btnDoctor.TabIndex = 0;
            this.btnDoctor.Text = "Doktor Paneli ";
            this.btnDoctor.UseVisualStyleBackColor = true;
            this.btnDoctor.Click += new System.EventHandler(this.btnDoctor_Click);
            // 
            // btnAnnouncements
            // 
            this.btnAnnouncements.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAnnouncements.Location = new System.Drawing.Point(484, 38);
            this.btnAnnouncements.Name = "btnAnnouncements";
            this.btnAnnouncements.Size = new System.Drawing.Size(120, 45);
            this.btnAnnouncements.TabIndex = 3;
            this.btnAnnouncements.Text = "Duyurular";
            this.btnAnnouncements.UseVisualStyleBackColor = true;
            this.btnAnnouncements.Click += new System.EventHandler(this.btnAnnouncements_Click);
            // 
            // SecretaryDetailsform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(1055, 621);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SecretaryDetailsform";
            this.Text = "Sekreter Ekranı";
            this.Load += new System.EventHandler(this.SecretaryDetailsform_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtBranch)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtDoctors)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNameSurname1;
        private System.Windows.Forms.Label lblTC2;
        private System.Windows.Forms.Label lblTC1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAnnouncementCreate;
        private System.Windows.Forms.RichTextBox rtxtAnnouncement;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chbxStatus;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.ComboBox cbbxDoctor;
        private System.Windows.Forms.ComboBox cbbxBranch;
        private System.Windows.Forms.MaskedTextBox mtxtTime;
        private System.Windows.Forms.MaskedTextBox mtxtDate;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblPatientTC;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dtBranch;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dtDoctors;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnAppointmentList;
        private System.Windows.Forms.Button btnBranch;
        private System.Windows.Forms.Button btnDoctor;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Button btnAnnouncements;
    }
}