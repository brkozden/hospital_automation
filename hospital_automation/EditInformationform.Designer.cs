namespace hospital_automation
{
    partial class EditInformationform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditInformationform));
            this.mtboxPhone = new System.Windows.Forms.MaskedTextBox();
            this.rbtnWoman = new System.Windows.Forms.RadioButton();
            this.rbtnMan = new System.Windows.Forms.RadioButton();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.mtboxTC = new System.Windows.Forms.MaskedTextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mtboxPhone
            // 
            this.mtboxPhone.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtboxPhone.Location = new System.Drawing.Point(161, 145);
            this.mtboxPhone.Mask = "(999) 000-0000";
            this.mtboxPhone.Name = "mtboxPhone";
            this.mtboxPhone.Size = new System.Drawing.Size(171, 32);
            this.mtboxPhone.TabIndex = 4;
            // 
            // rbtnWoman
            // 
            this.rbtnWoman.AutoSize = true;
            this.rbtnWoman.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnWoman.Location = new System.Drawing.Point(252, 222);
            this.rbtnWoman.Name = "rbtnWoman";
            this.rbtnWoman.Size = new System.Drawing.Size(80, 28);
            this.rbtnWoman.TabIndex = 7;
            this.rbtnWoman.TabStop = true;
            this.rbtnWoman.Text = "Kadın";
            this.rbtnWoman.UseVisualStyleBackColor = true;
            // 
            // rbtnMan
            // 
            this.rbtnMan.AutoSize = true;
            this.rbtnMan.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnMan.Location = new System.Drawing.Point(161, 222);
            this.rbtnMan.Name = "rbtnMan";
            this.rbtnMan.Size = new System.Drawing.Size(84, 28);
            this.rbtnMan.TabIndex = 6;
            this.rbtnMan.TabStop = true;
            this.rbtnMan.Text = "Erkek:";
            this.rbtnMan.UseVisualStyleBackColor = true;
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSurname.Location = new System.Drawing.Point(161, 70);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(171, 32);
            this.txtSurname.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(161, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(171, 32);
            this.txtName.TabIndex = 1;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGender.Location = new System.Drawing.Point(24, 223);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(83, 24);
            this.lblGender.TabIndex = 24;
            this.lblGender.Text = "Cinsiyet:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPhone.Location = new System.Drawing.Point(24, 148);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(78, 24);
            this.lblPhone.TabIndex = 23;
            this.lblPhone.Text = "Telefon:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSurname.Location = new System.Drawing.Point(24, 72);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(68, 24);
            this.lblSurname.TabIndex = 22;
            this.lblSurname.Text = "Soyad:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(24, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 24);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "Ad:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(161, 183);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(171, 32);
            this.txtPassword.TabIndex = 5;
            // 
            // mtboxTC
            // 
            this.mtboxTC.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtboxTC.Location = new System.Drawing.Point(161, 107);
            this.mtboxTC.Mask = "00000000000";
            this.mtboxTC.Name = "mtboxTC";
            this.mtboxTC.ReadOnly = true;
            this.mtboxTC.Size = new System.Drawing.Size(171, 32);
            this.mtboxTC.TabIndex = 3;
            this.mtboxTC.ValidatingType = typeof(int);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(24, 185);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(54, 24);
            this.lblPassword.TabIndex = 18;
            this.lblPassword.Text = "Şifre:";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTC.Location = new System.Drawing.Point(24, 110);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(125, 24);
            this.lblTC.TabIndex = 17;
            this.lblTC.Text = "TC Kimlik No:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightGreen;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(161, 274);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(171, 39);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // EditInformationform
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(358, 339);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.mtboxPhone);
            this.Controls.Add(this.rbtnWoman);
            this.Controls.Add(this.rbtnMan);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.mtboxTC);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblTC);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "EditInformationform";
            this.Text = "Bilgileri Güncelle";
            this.Load += new System.EventHandler(this.EditInformationform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtboxPhone;
        private System.Windows.Forms.RadioButton rbtnWoman;
        private System.Windows.Forms.RadioButton rbtnMan;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.MaskedTextBox mtboxTC;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Button btnUpdate;
    }
}