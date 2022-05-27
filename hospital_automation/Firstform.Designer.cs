namespace hospital_automation
{
    partial class FirstForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstForm));
            this.btnPatient = new System.Windows.Forms.Button();
            this.btnDoctor = new System.Windows.Forms.Button();
            this.btnSecretary = new System.Windows.Forms.Button();
            this.lblPatient = new System.Windows.Forms.Label();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblSecretary = new System.Windows.Forms.Label();
            this.pbxHeart1 = new System.Windows.Forms.PictureBox();
            this.lblHospitalName = new System.Windows.Forms.Label();
            this.pbxHeart2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHeart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHeart2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPatient
            // 
            this.btnPatient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPatient.BackgroundImage")));
            this.btnPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPatient.Location = new System.Drawing.Point(29, 186);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(227, 143);
            this.btnPatient.TabIndex = 0;
            this.btnPatient.UseVisualStyleBackColor = true;
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // btnDoctor
            // 
            this.btnDoctor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDoctor.BackgroundImage")));
            this.btnDoctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoctor.Location = new System.Drawing.Point(286, 186);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(227, 143);
            this.btnDoctor.TabIndex = 1;
            this.btnDoctor.UseVisualStyleBackColor = true;
            this.btnDoctor.Click += new System.EventHandler(this.btnDoctor_Click);
            // 
            // btnSecretary
            // 
            this.btnSecretary.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSecretary.BackgroundImage")));
            this.btnSecretary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSecretary.Location = new System.Drawing.Point(546, 186);
            this.btnSecretary.Name = "btnSecretary";
            this.btnSecretary.Size = new System.Drawing.Size(227, 143);
            this.btnSecretary.TabIndex = 2;
            this.btnSecretary.UseVisualStyleBackColor = true;
            this.btnSecretary.Click += new System.EventHandler(this.btnSecretary_Click);
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPatient.Location = new System.Drawing.Point(113, 355);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(54, 23);
            this.lblPatient.TabIndex = 3;
            this.lblPatient.Text = "Hasta";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDoctor.Location = new System.Drawing.Point(363, 355);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(63, 23);
            this.lblDoctor.TabIndex = 4;
            this.lblDoctor.Text = "Doktor";
            // 
            // lblSecretary
            // 
            this.lblSecretary.AutoSize = true;
            this.lblSecretary.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSecretary.Location = new System.Drawing.Point(616, 355);
            this.lblSecretary.Name = "lblSecretary";
            this.lblSecretary.Size = new System.Drawing.Size(73, 23);
            this.lblSecretary.TabIndex = 5;
            this.lblSecretary.Text = "Sekreter";
            // 
            // pbxHeart1
            // 
            this.pbxHeart1.Image = ((System.Drawing.Image)(resources.GetObject("pbxHeart1.Image")));
            this.pbxHeart1.Location = new System.Drawing.Point(76, 43);
            this.pbxHeart1.Name = "pbxHeart1";
            this.pbxHeart1.Size = new System.Drawing.Size(135, 90);
            this.pbxHeart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxHeart1.TabIndex = 6;
            this.pbxHeart1.TabStop = false;
            // 
            // lblHospitalName
            // 
            this.lblHospitalName.AutoSize = true;
            this.lblHospitalName.Font = new System.Drawing.Font("Segoe Script", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblHospitalName.Location = new System.Drawing.Point(234, 55);
            this.lblHospitalName.Name = "lblHospitalName";
            this.lblHospitalName.Size = new System.Drawing.Size(317, 52);
            this.lblHospitalName.TabIndex = 7;
            this.lblHospitalName.Text = "İstanbul Hospital";
            // 
            // pbxHeart2
            // 
            this.pbxHeart2.Image = ((System.Drawing.Image)(resources.GetObject("pbxHeart2.Image")));
            this.pbxHeart2.Location = new System.Drawing.Point(594, 43);
            this.pbxHeart2.Name = "pbxHeart2";
            this.pbxHeart2.Size = new System.Drawing.Size(135, 90);
            this.pbxHeart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxHeart2.TabIndex = 8;
            this.pbxHeart2.TabStop = false;
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 406);
            this.Controls.Add(this.pbxHeart2);
            this.Controls.Add(this.lblHospitalName);
            this.Controls.Add(this.pbxHeart1);
            this.Controls.Add(this.lblSecretary);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.btnSecretary);
            this.Controls.Add(this.btnDoctor);
            this.Controls.Add(this.btnPatient);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FirstForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İstanbul Hospital Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.pbxHeart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHeart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Button btnDoctor;
        private System.Windows.Forms.Button btnSecretary;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblSecretary;
        private System.Windows.Forms.PictureBox pbxHeart1;
        private System.Windows.Forms.Label lblHospitalName;
        private System.Windows.Forms.PictureBox pbxHeart2;
    }
}
