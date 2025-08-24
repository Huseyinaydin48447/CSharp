namespace FinancialCrm
{
    partial class FrmSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDateClock = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUserNameSurname = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnBankProcesses = new System.Windows.Forms.Button();
            this.btnSpendings = new System.Windows.Forms.Button();
            this.btnBills = new System.Windows.Forms.Button();
            this.btnBanks = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserNameSurname = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.cbPassword = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNewPasswordAgain = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ayarlar";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.lblDateClock);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(863, 52);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblDateClock
            // 
            this.lblDateClock.AutoSize = true;
            this.lblDateClock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDateClock.ForeColor = System.Drawing.Color.White;
            this.lblDateClock.Location = new System.Drawing.Point(689, 16);
            this.lblDateClock.Name = "lblDateClock";
            this.lblDateClock.Size = new System.Drawing.Size(195, 28);
            this.lblDateClock.TabIndex = 4;
            this.lblDateClock.Text = "00/00/0000 00:00:00";
            this.lblDateClock.Click += new System.EventHandler(this.lblDateClock_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblUserNameSurname
            // 
            this.lblUserNameSurname.AutoSize = true;
            this.lblUserNameSurname.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblUserNameSurname.ForeColor = System.Drawing.Color.Black;
            this.lblUserNameSurname.Location = new System.Drawing.Point(112, 66);
            this.lblUserNameSurname.Name = "lblUserNameSurname";
            this.lblUserNameSurname.Size = new System.Drawing.Size(207, 41);
            this.lblUserNameSurname.TabIndex = 11;
            this.lblUserNameSurname.Text = "Hüseyin Aydın";
            this.lblUserNameSurname.Click += new System.EventHandler(this.lblUserNameSurname_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 2;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 371);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(174, 44);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Geri";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 2;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(12, 321);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(174, 44);
            this.btnSettings.TabIndex = 8;
            this.btnSettings.Text = "Ayarlar";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 2;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(12, 271);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(174, 44);
            this.btnDashboard.TabIndex = 7;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnBankProcesses
            // 
            this.btnBankProcesses.FlatAppearance.BorderSize = 2;
            this.btnBankProcesses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankProcesses.ForeColor = System.Drawing.Color.White;
            this.btnBankProcesses.Location = new System.Drawing.Point(12, 221);
            this.btnBankProcesses.Name = "btnBankProcesses";
            this.btnBankProcesses.Size = new System.Drawing.Size(174, 44);
            this.btnBankProcesses.TabIndex = 6;
            this.btnBankProcesses.Text = "Banka Hareketleri";
            this.btnBankProcesses.UseVisualStyleBackColor = true;
            this.btnBankProcesses.Click += new System.EventHandler(this.btnBankProcesses_Click);
            // 
            // btnSpendings
            // 
            this.btnSpendings.FlatAppearance.BorderSize = 2;
            this.btnSpendings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpendings.ForeColor = System.Drawing.Color.White;
            this.btnSpendings.Location = new System.Drawing.Point(12, 171);
            this.btnSpendings.Name = "btnSpendings";
            this.btnSpendings.Size = new System.Drawing.Size(174, 44);
            this.btnSpendings.TabIndex = 5;
            this.btnSpendings.Text = "Giderler";
            this.btnSpendings.UseVisualStyleBackColor = true;
            this.btnSpendings.Click += new System.EventHandler(this.btnSpendings_Click);
            // 
            // btnBills
            // 
            this.btnBills.FlatAppearance.BorderSize = 2;
            this.btnBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBills.ForeColor = System.Drawing.Color.White;
            this.btnBills.Location = new System.Drawing.Point(12, 121);
            this.btnBills.Name = "btnBills";
            this.btnBills.Size = new System.Drawing.Size(174, 44);
            this.btnBills.TabIndex = 4;
            this.btnBills.Text = "Faturalar";
            this.btnBills.UseVisualStyleBackColor = true;
            this.btnBills.Click += new System.EventHandler(this.btnBills_Click);
            // 
            // btnBanks
            // 
            this.btnBanks.FlatAppearance.BorderSize = 2;
            this.btnBanks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanks.ForeColor = System.Drawing.Color.White;
            this.btnBanks.Location = new System.Drawing.Point(12, 71);
            this.btnBanks.Name = "btnBanks";
            this.btnBanks.Size = new System.Drawing.Size(174, 44);
            this.btnBanks.TabIndex = 3;
            this.btnBanks.Text = "Bankalar";
            this.btnBanks.UseVisualStyleBackColor = true;
            this.btnBanks.Click += new System.EventHandler(this.btnBanks_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.FlatAppearance.BorderSize = 2;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.Location = new System.Drawing.Point(12, 21);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(174, 44);
            this.btnCategory.TabIndex = 2;
            this.btnCategory.Text = "Kategoriler";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.btnBankProcesses);
            this.panel1.Controls.Add(this.btnSpendings);
            this.panel1.Controls.Add(this.btnBills);
            this.panel1.Controls.Add(this.btnBanks);
            this.panel1.Controls.Add(this.btnCategory);
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 448);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Kullanıcı Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(4, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ad ve Soyad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(4, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "E-Mail:";
            // 
            // txtUsername
            // 
            this.txtUsername.Enabled = false;
            this.txtUsername.Location = new System.Drawing.Point(122, 131);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(180, 34);
            this.txtUsername.TabIndex = 16;
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(122, 167);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(180, 34);
            this.txtPassword.TabIndex = 17;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserNameSurname
            // 
            this.txtUserNameSurname.Enabled = false;
            this.txtUserNameSurname.Location = new System.Drawing.Point(122, 202);
            this.txtUserNameSurname.Name = "txtUserNameSurname";
            this.txtUserNameSurname.Size = new System.Drawing.Size(180, 34);
            this.txtUserNameSurname.TabIndex = 18;
            // 
            // txtMail
            // 
            this.txtMail.Enabled = false;
            this.txtMail.Location = new System.Drawing.Point(122, 237);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(180, 34);
            this.txtMail.TabIndex = 19;
            // 
            // cbPassword
            // 
            this.cbPassword.AutoSize = true;
            this.cbPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbPassword.Location = new System.Drawing.Point(122, 277);
            this.cbPassword.Name = "cbPassword";
            this.cbPassword.Size = new System.Drawing.Size(141, 27);
            this.cbPassword.TabIndex = 20;
            this.cbPassword.Text = "Şifreyi Göster";
            this.cbPassword.UseVisualStyleBackColor = true;
            this.cbPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBox1_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(18)))));
            this.groupBox1.Controls.Add(this.btnChangePassword);
            this.groupBox1.Controls.Add(this.txtNewPassword);
            this.groupBox1.Controls.Add(this.txtOldPassword);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNewPasswordAgain);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(557, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 305);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şifre Değiştir";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.FlatAppearance.BorderSize = 2;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnChangePassword.Location = new System.Drawing.Point(187, 244);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(103, 38);
            this.btnChangePassword.TabIndex = 10;
            this.btnChangePassword.Text = "Değiştir";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(155, 166);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(135, 34);
            this.txtNewPassword.TabIndex = 25;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(155, 131);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(135, 34);
            this.txtOldPassword.TabIndex = 24;
            this.txtOldPassword.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 23);
            this.label8.TabIndex = 23;
            this.label8.Text = "Yeni Şifre Tekrar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "Yeni Şifre:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtNewPasswordAgain
            // 
            this.txtNewPasswordAgain.Location = new System.Drawing.Point(155, 201);
            this.txtNewPasswordAgain.Name = "txtNewPasswordAgain";
            this.txtNewPasswordAgain.Size = new System.Drawing.Size(135, 34);
            this.txtNewPasswordAgain.TabIndex = 21;
            this.txtNewPasswordAgain.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "Şifre:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(18)))));
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.lblUserNameSurname);
            this.groupBox2.Controls.Add(this.cbPassword);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtMail);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtUserNameSurname);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtUsername);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(206, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 305);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kullanıcı Bilgileri";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(4, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 23);
            this.label9.TabIndex = 13;
            this.label9.Text = "Şifre:";
            // 
            // btnRestart
            // 
            this.btnRestart.FlatAppearance.BorderSize = 2;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRestart.Location = new System.Drawing.Point(744, 426);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(103, 57);
            this.btnRestart.TabIndex = 26;
            this.btnRestart.Text = "Yeniden Başlat";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(860, 495);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSettings";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUserNameSurname;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnBankProcesses;
        private System.Windows.Forms.Button btnSpendings;
        private System.Windows.Forms.Button btnBills;
        private System.Windows.Forms.Button btnBanks;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserNameSurname;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.CheckBox cbPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNewPasswordAgain;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblDateClock;
        private System.Windows.Forms.Label label9;
    }
}