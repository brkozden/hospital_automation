namespace hospital_automation
{
    partial class DoctorLoginform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorLoginform));
            this.lblDoctorWelcome = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.mtboxTC = new System.Windows.Forms.MaskedTextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDoctorWelcome
            // 
            this.lblDoctorWelcome.AutoSize = true;
            this.lblDoctorWelcome.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDoctorWelcome.Location = new System.Drawing.Point(83, 41);
            this.lblDoctorWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDoctorWelcome.Name = "lblDoctorWelcome";
            this.lblDoctorWelcome.Size = new System.Drawing.Size(448, 67);
            this.lblDoctorWelcome.TabIndex = 13;
            this.lblDoctorWelcome.Text = "Doktor Giriş Paneli";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LightGreen;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogin.Location = new System.Drawing.Point(313, 284);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(216, 46);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Giriş";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(313, 213);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(214, 34);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // mtboxTC
            // 
            this.mtboxTC.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mtboxTC.Location = new System.Drawing.Point(313, 158);
            this.mtboxTC.Margin = new System.Windows.Forms.Padding(4);
            this.mtboxTC.Mask = "00000000000";
            this.mtboxTC.Name = "mtboxTC";
            this.mtboxTC.Size = new System.Drawing.Size(214, 34);
            this.mtboxTC.TabIndex = 9;
            this.mtboxTC.ValidatingType = typeof(int);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(112, 220);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(58, 28);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Şifre:";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTC.Location = new System.Drawing.Point(112, 158);
            this.lblTC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(134, 28);
            this.lblTC.TabIndex = 7;
            this.lblTC.Text = "TC Kimlik No:";
            // 
            // DoctorLoginform
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(636, 367);
            this.Controls.Add(this.lblDoctorWelcome);
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
            this.Name = "DoctorLoginform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorLoginform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDoctorWelcome;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.MaskedTextBox mtboxTC;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblTC;
    }
}