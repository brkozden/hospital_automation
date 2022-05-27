namespace hospital_automation
{
    partial class PatientLoginform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientLoginform));
            this.lblTC = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.mtboxTC = new System.Windows.Forms.MaskedTextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lnkSignUp = new System.Windows.Forms.LinkLabel();
            this.lblPatientWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTC.Location = new System.Drawing.Point(99, 150);
            this.lblTC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(134, 28);
            this.lblTC.TabIndex = 0;
            this.lblTC.Text = "TC Kimlik No:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(99, 212);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(58, 28);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Şifre:";
            // 
            // mtboxTC
            // 
            this.mtboxTC.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mtboxTC.Location = new System.Drawing.Point(300, 150);
            this.mtboxTC.Margin = new System.Windows.Forms.Padding(4);
            this.mtboxTC.Mask = "00000000000";
            this.mtboxTC.Name = "mtboxTC";
            this.mtboxTC.Size = new System.Drawing.Size(214, 34);
            this.mtboxTC.TabIndex = 2;
            this.mtboxTC.ValidatingType = typeof(int);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(300, 205);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(214, 34);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LightGreen;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogin.Location = new System.Drawing.Point(300, 276);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(216, 46);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Giriş";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lnkSignUp
            // 
            this.lnkSignUp.AutoSize = true;
            this.lnkSignUp.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lnkSignUp.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.lnkSignUp.Location = new System.Drawing.Point(99, 276);
            this.lnkSignUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkSignUp.Name = "lnkSignUp";
            this.lnkSignUp.Size = new System.Drawing.Size(73, 28);
            this.lnkSignUp.TabIndex = 5;
            this.lnkSignUp.TabStop = true;
            this.lnkSignUp.Text = "Üye Ol";
            this.lnkSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSignUp_LinkClicked);
            // 
            // lblPatientWelcome
            // 
            this.lblPatientWelcome.AutoSize = true;
            this.lblPatientWelcome.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPatientWelcome.Location = new System.Drawing.Point(99, 39);
            this.lblPatientWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatientWelcome.Name = "lblPatientWelcome";
            this.lblPatientWelcome.Size = new System.Drawing.Size(419, 67);
            this.lblPatientWelcome.TabIndex = 6;
            this.lblPatientWelcome.Text = "Hasta Giriş Paneli";
            // 
            // PatientLoginform
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(636, 367);
            this.Controls.Add(this.lblPatientWelcome);
            this.Controls.Add(this.lnkSignUp);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.mtboxTC);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblTC);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "PatientLoginform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Giriş Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.MaskedTextBox mtboxTC;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lnkSignUp;
        private System.Windows.Forms.Label lblPatientWelcome;
    }
}