namespace hospital_automation
{
    partial class PatientMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientMenuForm));
            this.grpbxPatientinfo = new System.Windows.Forms.GroupBox();
            this.lblNameSurname3 = new System.Windows.Forms.Label();
            this.lnkEditInformation = new System.Windows.Forms.LinkLabel();
            this.lblNameSurname2 = new System.Windows.Forms.Label();
            this.lblNameSurname1 = new System.Windows.Forms.Label();
            this.lblTC2 = new System.Windows.Forms.Label();
            this.lblTC1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAppointmentID = new System.Windows.Forms.TextBox();
            this.lblAppointmentID = new System.Windows.Forms.Label();
            this.btnMakeanAppointment = new System.Windows.Forms.Button();
            this.lblTrouble = new System.Windows.Forms.Label();
            this.rtxtComplaint = new System.Windows.Forms.RichTextBox();
            this.cmbbxDoctor = new System.Windows.Forms.ComboBox();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.cmbbxBranch = new System.Windows.Forms.ComboBox();
            this.lblBranch = new System.Windows.Forms.Label();
            this.grpbxAppointmentHistory = new System.Windows.Forms.GroupBox();
            this.grpbxActiveAppointments = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpbxPatientinfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpbxAppointmentHistory.SuspendLayout();
            this.grpbxActiveAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbxPatientinfo
            // 
            this.grpbxPatientinfo.Controls.Add(this.lblNameSurname3);
            this.grpbxPatientinfo.Controls.Add(this.lnkEditInformation);
            this.grpbxPatientinfo.Controls.Add(this.lblNameSurname2);
            this.grpbxPatientinfo.Controls.Add(this.lblNameSurname1);
            this.grpbxPatientinfo.Controls.Add(this.lblTC2);
            this.grpbxPatientinfo.Controls.Add(this.lblTC1);
            this.grpbxPatientinfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpbxPatientinfo.Location = new System.Drawing.Point(12, 12);
            this.grpbxPatientinfo.Name = "grpbxPatientinfo";
            this.grpbxPatientinfo.Size = new System.Drawing.Size(285, 151);
            this.grpbxPatientinfo.TabIndex = 0;
            this.grpbxPatientinfo.TabStop = false;
            this.grpbxPatientinfo.Text = "Kişi Bilgisi";
            // 
            // lblNameSurname3
            // 
            this.lblNameSurname3.AutoSize = true;
            this.lblNameSurname3.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNameSurname3.Location = new System.Drawing.Point(149, 107);
            this.lblNameSurname3.Name = "lblNameSurname3";
            this.lblNameSurname3.Size = new System.Drawing.Size(39, 21);
            this.lblNameSurname3.TabIndex = 11;
            this.lblNameSurname3.Text = "Null";
            // 
            // lnkEditInformation
            // 
            this.lnkEditInformation.AutoSize = true;
            this.lnkEditInformation.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lnkEditInformation.Location = new System.Drawing.Point(6, 127);
            this.lnkEditInformation.Name = "lnkEditInformation";
            this.lnkEditInformation.Size = new System.Drawing.Size(123, 21);
            this.lnkEditInformation.TabIndex = 4;
            this.lnkEditInformation.TabStop = true;
            this.lnkEditInformation.Text = "Bilgileri Düzenle";
            this.lnkEditInformation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEditInformation_LinkClicked);
            // 
            // lblNameSurname2
            // 
            this.lblNameSurname2.AutoSize = true;
            this.lblNameSurname2.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNameSurname2.Location = new System.Drawing.Point(149, 74);
            this.lblNameSurname2.Name = "lblNameSurname2";
            this.lblNameSurname2.Size = new System.Drawing.Size(39, 21);
            this.lblNameSurname2.TabIndex = 10;
            this.lblNameSurname2.Text = "Null";
            // 
            // lblNameSurname1
            // 
            this.lblNameSurname1.AutoSize = true;
            this.lblNameSurname1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNameSurname1.Location = new System.Drawing.Point(47, 74);
            this.lblNameSurname1.Name = "lblNameSurname1";
            this.lblNameSurname1.Size = new System.Drawing.Size(96, 24);
            this.lblNameSurname1.TabIndex = 9;
            this.lblNameSurname1.Text = "Ad Soyad:";
            // 
            // lblTC2
            // 
            this.lblTC2.AutoSize = true;
            this.lblTC2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTC2.Location = new System.Drawing.Point(150, 38);
            this.lblTC2.Name = "lblTC2";
            this.lblTC2.Size = new System.Drawing.Size(120, 24);
            this.lblTC2.TabIndex = 6;
            this.lblTC2.Text = "00000000000";
            // 
            // lblTC1
            // 
            this.lblTC1.AutoSize = true;
            this.lblTC1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTC1.Location = new System.Drawing.Point(19, 38);
            this.lblTC1.Name = "lblTC1";
            this.lblTC1.Size = new System.Drawing.Size(125, 24);
            this.lblTC1.TabIndex = 5;
            this.lblTC1.Text = "TC Kimlik No:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAppointmentID);
            this.groupBox1.Controls.Add(this.lblAppointmentID);
            this.groupBox1.Controls.Add(this.btnMakeanAppointment);
            this.groupBox1.Controls.Add(this.lblTrouble);
            this.groupBox1.Controls.Add(this.rtxtComplaint);
            this.groupBox1.Controls.Add(this.cmbbxDoctor);
            this.groupBox1.Controls.Add(this.lblDoctor);
            this.groupBox1.Controls.Add(this.cmbbxBranch);
            this.groupBox1.Controls.Add(this.lblBranch);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(12, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 375);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randevu Al";
            // 
            // txtAppointmentID
            // 
            this.txtAppointmentID.Enabled = false;
            this.txtAppointmentID.Location = new System.Drawing.Point(110, 43);
            this.txtAppointmentID.Name = "txtAppointmentID";
            this.txtAppointmentID.Size = new System.Drawing.Size(160, 32);
            this.txtAppointmentID.TabIndex = 4;
            // 
            // lblAppointmentID
            // 
            this.lblAppointmentID.AutoSize = true;
            this.lblAppointmentID.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAppointmentID.Location = new System.Drawing.Point(19, 44);
            this.lblAppointmentID.Name = "lblAppointmentID";
            this.lblAppointmentID.Size = new System.Drawing.Size(33, 24);
            this.lblAppointmentID.TabIndex = 14;
            this.lblAppointmentID.Text = "ID:";
            // 
            // btnMakeanAppointment
            // 
            this.btnMakeanAppointment.BackColor = System.Drawing.Color.LightGreen;
            this.btnMakeanAppointment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMakeanAppointment.Location = new System.Drawing.Point(110, 322);
            this.btnMakeanAppointment.Name = "btnMakeanAppointment";
            this.btnMakeanAppointment.Size = new System.Drawing.Size(160, 39);
            this.btnMakeanAppointment.TabIndex = 2;
            this.btnMakeanAppointment.Text = "Randevu Al";
            this.btnMakeanAppointment.UseVisualStyleBackColor = false;
            this.btnMakeanAppointment.Click += new System.EventHandler(this.btnMakeanAppointment_Click);
            // 
            // lblTrouble
            // 
            this.lblTrouble.AutoSize = true;
            this.lblTrouble.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTrouble.Location = new System.Drawing.Point(19, 187);
            this.lblTrouble.Name = "lblTrouble";
            this.lblTrouble.Size = new System.Drawing.Size(78, 24);
            this.lblTrouble.TabIndex = 13;
            this.lblTrouble.Text = "Şikayet:";
            // 
            // rtxtComplaint
            // 
            this.rtxtComplaint.Location = new System.Drawing.Point(110, 184);
            this.rtxtComplaint.Name = "rtxtComplaint";
            this.rtxtComplaint.Size = new System.Drawing.Size(160, 118);
            this.rtxtComplaint.TabIndex = 2;
            this.rtxtComplaint.Text = "";
            // 
            // cmbbxDoctor
            // 
            this.cmbbxDoctor.FormattingEnabled = true;
            this.cmbbxDoctor.Location = new System.Drawing.Point(110, 133);
            this.cmbbxDoctor.Name = "cmbbxDoctor";
            this.cmbbxDoctor.Size = new System.Drawing.Size(160, 32);
            this.cmbbxDoctor.TabIndex = 11;
            this.cmbbxDoctor.SelectedIndexChanged += new System.EventHandler(this.cmbbxDoctor_SelectedIndexChanged);
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDoctor.Location = new System.Drawing.Point(19, 136);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(74, 24);
            this.lblDoctor.TabIndex = 12;
            this.lblDoctor.Text = "Doktor:";
            // 
            // cmbbxBranch
            // 
            this.cmbbxBranch.FormattingEnabled = true;
            this.cmbbxBranch.Location = new System.Drawing.Point(110, 88);
            this.cmbbxBranch.Name = "cmbbxBranch";
            this.cmbbxBranch.Size = new System.Drawing.Size(160, 32);
            this.cmbbxBranch.TabIndex = 2;
            this.cmbbxBranch.SelectedIndexChanged += new System.EventHandler(this.cmbbxBranch_SelectedIndexChanged);
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBranch.Location = new System.Drawing.Point(19, 91);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(63, 24);
            this.lblBranch.TabIndex = 10;
            this.lblBranch.Text = "Branş:";
            // 
            // grpbxAppointmentHistory
            // 
            this.grpbxAppointmentHistory.Controls.Add(this.dataGridView1);
            this.grpbxAppointmentHistory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpbxAppointmentHistory.Location = new System.Drawing.Point(303, 12);
            this.grpbxAppointmentHistory.Name = "grpbxAppointmentHistory";
            this.grpbxAppointmentHistory.Size = new System.Drawing.Size(785, 248);
            this.grpbxAppointmentHistory.TabIndex = 2;
            this.grpbxAppointmentHistory.TabStop = false;
            this.grpbxAppointmentHistory.Text = "Geçmiş Randevular";
            // 
            // grpbxActiveAppointments
            // 
            this.grpbxActiveAppointments.Controls.Add(this.dataGridView2);
            this.grpbxActiveAppointments.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpbxActiveAppointments.Location = new System.Drawing.Point(303, 278);
            this.grpbxActiveAppointments.Name = "grpbxActiveAppointments";
            this.grpbxActiveAppointments.Size = new System.Drawing.Size(785, 280);
            this.grpbxActiveAppointments.TabIndex = 3;
            this.grpbxActiveAppointments.TabStop = false;
            this.grpbxActiveAppointments.Text = "Aktif Randevular";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(779, 249);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(779, 217);
            this.dataGridView1.TabIndex = 0;
            // 
            // PatientMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(1100, 570);
            this.Controls.Add(this.grpbxActiveAppointments);
            this.Controls.Add(this.grpbxAppointmentHistory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbxPatientinfo);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "PatientMenuForm";
            this.Text = "Hasta Detay";
            this.Load += new System.EventHandler(this.PatientMenuForm_Load);
            this.grpbxPatientinfo.ResumeLayout(false);
            this.grpbxPatientinfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpbxAppointmentHistory.ResumeLayout(false);
            this.grpbxActiveAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxPatientinfo;
        private System.Windows.Forms.Label lblTC2;
        private System.Windows.Forms.Label lblTC1;
        private System.Windows.Forms.Label lblNameSurname2;
        private System.Windows.Forms.Label lblNameSurname1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMakeanAppointment;
        private System.Windows.Forms.Label lblTrouble;
        private System.Windows.Forms.RichTextBox rtxtComplaint;
        private System.Windows.Forms.ComboBox cmbbxDoctor;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.ComboBox cmbbxBranch;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.GroupBox grpbxAppointmentHistory;
        private System.Windows.Forms.GroupBox grpbxActiveAppointments;
        private System.Windows.Forms.LinkLabel lnkEditInformation;
        private System.Windows.Forms.TextBox txtAppointmentID;
        private System.Windows.Forms.Label lblAppointmentID;
        private System.Windows.Forms.Label lblNameSurname3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}