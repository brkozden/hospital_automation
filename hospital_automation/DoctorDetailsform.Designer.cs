namespace hospital_automation
{
    partial class DoctorDetailsform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorDetailsform));
            this.grpbxDoctorInfo = new System.Windows.Forms.GroupBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNameSurname1 = new System.Windows.Forms.Label();
            this.lblTC2 = new System.Windows.Forms.Label();
            this.lblTC1 = new System.Windows.Forms.Label();
            this.grpbxAppointmentDetails = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblTrouble = new System.Windows.Forms.Label();
            this.txtPatientSurname = new System.Windows.Forms.TextBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lblPatientSurname = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblPatientTC = new System.Windows.Forms.Label();
            this.grpbxAppointmentList = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpbxFastAccess = new System.Windows.Forms.GroupBox();
            this.btnEditInformation = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAnnouncements = new System.Windows.Forms.Button();
            this.grpbxDoctorInfo.SuspendLayout();
            this.grpbxAppointmentDetails.SuspendLayout();
            this.grpbxAppointmentList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpbxFastAccess.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxDoctorInfo
            // 
            this.grpbxDoctorInfo.Controls.Add(this.lblSurname);
            this.grpbxDoctorInfo.Controls.Add(this.lblName);
            this.grpbxDoctorInfo.Controls.Add(this.lblNameSurname1);
            this.grpbxDoctorInfo.Controls.Add(this.lblTC2);
            this.grpbxDoctorInfo.Controls.Add(this.lblTC1);
            this.grpbxDoctorInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpbxDoctorInfo.Location = new System.Drawing.Point(12, 12);
            this.grpbxDoctorInfo.Name = "grpbxDoctorInfo";
            this.grpbxDoctorInfo.Size = new System.Drawing.Size(285, 151);
            this.grpbxDoctorInfo.TabIndex = 0;
            this.grpbxDoctorInfo.TabStop = false;
            this.grpbxDoctorInfo.Text = "Doktor Bilgileri";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSurname.Location = new System.Drawing.Point(146, 109);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(44, 24);
            this.lblSurname.TabIndex = 15;
            this.lblSurname.Text = "Null";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(146, 84);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 24);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Null";
            // 
            // lblNameSurname1
            // 
            this.lblNameSurname1.AutoSize = true;
            this.lblNameSurname1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNameSurname1.Location = new System.Drawing.Point(15, 84);
            this.lblNameSurname1.Name = "lblNameSurname1";
            this.lblNameSurname1.Size = new System.Drawing.Size(96, 24);
            this.lblNameSurname1.TabIndex = 13;
            this.lblNameSurname1.Text = "Ad Soyad:";
            // 
            // lblTC2
            // 
            this.lblTC2.AutoSize = true;
            this.lblTC2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTC2.Location = new System.Drawing.Point(146, 46);
            this.lblTC2.Name = "lblTC2";
            this.lblTC2.Size = new System.Drawing.Size(120, 24);
            this.lblTC2.TabIndex = 12;
            this.lblTC2.Text = "00000000000";
            // 
            // lblTC1
            // 
            this.lblTC1.AutoSize = true;
            this.lblTC1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTC1.Location = new System.Drawing.Point(15, 46);
            this.lblTC1.Name = "lblTC1";
            this.lblTC1.Size = new System.Drawing.Size(125, 24);
            this.lblTC1.TabIndex = 11;
            this.lblTC1.Text = "TC Kimlik No:";
            // 
            // grpbxAppointmentDetails
            // 
            this.grpbxAppointmentDetails.Controls.Add(this.richTextBox1);
            this.grpbxAppointmentDetails.Controls.Add(this.lblTrouble);
            this.grpbxAppointmentDetails.Controls.Add(this.txtPatientSurname);
            this.grpbxAppointmentDetails.Controls.Add(this.txtPatientName);
            this.grpbxAppointmentDetails.Controls.Add(this.maskedTextBox1);
            this.grpbxAppointmentDetails.Controls.Add(this.lblPatientSurname);
            this.grpbxAppointmentDetails.Controls.Add(this.lblPatientName);
            this.grpbxAppointmentDetails.Controls.Add(this.lblPatientTC);
            this.grpbxAppointmentDetails.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpbxAppointmentDetails.Location = new System.Drawing.Point(12, 169);
            this.grpbxAppointmentDetails.Name = "grpbxAppointmentDetails";
            this.grpbxAppointmentDetails.Size = new System.Drawing.Size(285, 430);
            this.grpbxAppointmentDetails.TabIndex = 1;
            this.grpbxAppointmentDetails.TabStop = false;
            this.grpbxAppointmentDetails.Text = "Randevu Detayları";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 214);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(252, 210);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // lblTrouble
            // 
            this.lblTrouble.AutoSize = true;
            this.lblTrouble.Location = new System.Drawing.Point(14, 187);
            this.lblTrouble.Name = "lblTrouble";
            this.lblTrouble.Size = new System.Drawing.Size(78, 24);
            this.lblTrouble.TabIndex = 4;
            this.lblTrouble.Text = "Şikayet:";
            // 
            // txtPatientSurname
            // 
            this.txtPatientSurname.Location = new System.Drawing.Point(120, 132);
            this.txtPatientSurname.Name = "txtPatientSurname";
            this.txtPatientSurname.Size = new System.Drawing.Size(146, 32);
            this.txtPatientSurname.TabIndex = 3;
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(120, 86);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(146, 32);
            this.txtPatientName.TabIndex = 0;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(120, 38);
            this.maskedTextBox1.Mask = "00000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(146, 32);
            this.maskedTextBox1.TabIndex = 0;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // lblPatientSurname
            // 
            this.lblPatientSurname.AutoSize = true;
            this.lblPatientSurname.Location = new System.Drawing.Point(14, 135);
            this.lblPatientSurname.Name = "lblPatientSurname";
            this.lblPatientSurname.Size = new System.Drawing.Size(68, 24);
            this.lblPatientSurname.TabIndex = 2;
            this.lblPatientSurname.Text = "Soyad:";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Location = new System.Drawing.Point(14, 89);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(39, 24);
            this.lblPatientName.TabIndex = 1;
            this.lblPatientName.Text = "Ad:";
            // 
            // lblPatientTC
            // 
            this.lblPatientTC.AutoSize = true;
            this.lblPatientTC.Location = new System.Drawing.Point(15, 46);
            this.lblPatientTC.Name = "lblPatientTC";
            this.lblPatientTC.Size = new System.Drawing.Size(89, 24);
            this.lblPatientTC.TabIndex = 0;
            this.lblPatientTC.Text = "Hasta TC:";
            // 
            // grpbxAppointmentList
            // 
            this.grpbxAppointmentList.Controls.Add(this.dataGridView1);
            this.grpbxAppointmentList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpbxAppointmentList.Location = new System.Drawing.Point(303, 12);
            this.grpbxAppointmentList.Name = "grpbxAppointmentList";
            this.grpbxAppointmentList.Size = new System.Drawing.Size(921, 740);
            this.grpbxAppointmentList.TabIndex = 2;
            this.grpbxAppointmentList.TabStop = false;
            this.grpbxAppointmentList.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(915, 709);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // grpbxFastAccess
            // 
            this.grpbxFastAccess.Controls.Add(this.btnEditInformation);
            this.grpbxFastAccess.Controls.Add(this.btnExit);
            this.grpbxFastAccess.Controls.Add(this.btnAnnouncements);
            this.grpbxFastAccess.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpbxFastAccess.Location = new System.Drawing.Point(12, 605);
            this.grpbxFastAccess.Name = "grpbxFastAccess";
            this.grpbxFastAccess.Size = new System.Drawing.Size(285, 147);
            this.grpbxFastAccess.TabIndex = 0;
            this.grpbxFastAccess.TabStop = false;
            this.grpbxFastAccess.Text = "Hızlı Erişim";
            // 
            // btnEditInformation
            // 
            this.btnEditInformation.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditInformation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditInformation.Location = new System.Drawing.Point(14, 41);
            this.btnEditInformation.Name = "btnEditInformation";
            this.btnEditInformation.Size = new System.Drawing.Size(126, 35);
            this.btnEditInformation.TabIndex = 4;
            this.btnEditInformation.Text = "Bilgi Düzenle";
            this.btnEditInformation.UseVisualStyleBackColor = true;
            this.btnEditInformation.Click += new System.EventHandler(this.btnEditInformation_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(14, 93);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(259, 35);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Çıkış";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAnnouncements
            // 
            this.btnAnnouncements.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnnouncements.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAnnouncements.Location = new System.Drawing.Point(146, 41);
            this.btnAnnouncements.Name = "btnAnnouncements";
            this.btnAnnouncements.Size = new System.Drawing.Size(126, 35);
            this.btnAnnouncements.TabIndex = 1;
            this.btnAnnouncements.Text = "Duyurular";
            this.btnAnnouncements.UseVisualStyleBackColor = true;
            this.btnAnnouncements.Click += new System.EventHandler(this.btnAnnouncements_Click);
            // 
            // DoctorDetailsform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(1233, 760);
            this.Controls.Add(this.grpbxFastAccess);
            this.Controls.Add(this.grpbxAppointmentList);
            this.Controls.Add(this.grpbxAppointmentDetails);
            this.Controls.Add(this.grpbxDoctorInfo);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "DoctorDetailsform";
            this.Text = "Doktor Detay Ekranı";
            this.Load += new System.EventHandler(this.DoctorDetailsform_Load);
            this.grpbxDoctorInfo.ResumeLayout(false);
            this.grpbxDoctorInfo.PerformLayout();
            this.grpbxAppointmentDetails.ResumeLayout(false);
            this.grpbxAppointmentDetails.PerformLayout();
            this.grpbxAppointmentList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpbxFastAccess.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxDoctorInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNameSurname1;
        private System.Windows.Forms.Label lblTC2;
        private System.Windows.Forms.Label lblTC1;
        private System.Windows.Forms.GroupBox grpbxAppointmentDetails;
        private System.Windows.Forms.Label lblTrouble;
        private System.Windows.Forms.TextBox txtPatientSurname;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lblPatientSurname;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblPatientTC;
        private System.Windows.Forms.GroupBox grpbxAppointmentList;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpbxFastAccess;
        private System.Windows.Forms.Button btnEditInformation;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAnnouncements;
        private System.Windows.Forms.Label lblSurname;
    }
}