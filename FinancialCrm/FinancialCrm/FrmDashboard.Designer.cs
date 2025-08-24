namespace FinancialCrm
{
    partial class FrmDashboard
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUserNameSurname = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnBankProcesses = new System.Windows.Forms.Button();
            this.btnSpendings = new System.Windows.Forms.Button();
            this.btnBills = new System.Windows.Forms.Button();
            this.btnBanks = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblLastBankProcessAmount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblBillAmount = new System.Windows.Forms.Label();
            this.lblBillTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalBalance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(863, 52);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dashboard / Genel Bakış Formu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblUserNameSurname);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.btnBankProcesses);
            this.panel1.Controls.Add(this.btnSpendings);
            this.panel1.Controls.Add(this.btnBills);
            this.panel1.Controls.Add(this.btnBanks);
            this.panel1.Controls.Add(this.btnCategory);
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblUserNameSurname
            // 
            this.lblUserNameSurname.AutoSize = true;
            this.lblUserNameSurname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserNameSurname.ForeColor = System.Drawing.Color.Transparent;
            this.lblUserNameSurname.Location = new System.Drawing.Point(49, 10);
            this.lblUserNameSurname.Name = "lblUserNameSurname";
            this.lblUserNameSurname.Size = new System.Drawing.Size(137, 28);
            this.lblUserNameSurname.TabIndex = 3;
            this.lblUserNameSurname.Text = "Hüseyin Aydın";
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(12, 393);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(174, 44);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Çıkış";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 2;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(12, 343);
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
            this.btnDashboard.Location = new System.Drawing.Point(12, 293);
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
            this.btnBankProcesses.Location = new System.Drawing.Point(12, 243);
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
            this.btnSpendings.Location = new System.Drawing.Point(12, 193);
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
            this.btnBills.Location = new System.Drawing.Point(12, 143);
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
            this.btnBanks.Location = new System.Drawing.Point(12, 93);
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
            this.btnCategory.Location = new System.Drawing.Point(12, 43);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(174, 44);
            this.btnCategory.TabIndex = 2;
            this.btnCategory.Text = "Kategoriler";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(203)))), ((int)(((byte)(173)))));
            this.panel5.Controls.Add(this.lblLastBankProcessAmount);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(648, 58);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(205, 117);
            this.panel5.TabIndex = 7;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // lblLastBankProcessAmount
            // 
            this.lblLastBankProcessAmount.AutoSize = true;
            this.lblLastBankProcessAmount.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblLastBankProcessAmount.ForeColor = System.Drawing.Color.Black;
            this.lblLastBankProcessAmount.Location = new System.Drawing.Point(5, 46);
            this.lblLastBankProcessAmount.Name = "lblLastBankProcessAmount";
            this.lblLastBankProcessAmount.Size = new System.Drawing.Size(230, 46);
            this.lblLastBankProcessAmount.TabIndex = 3;
            this.lblLastBankProcessAmount.Text = "1.000.000,00 ₺";
            this.lblLastBankProcessAmount.Click += new System.EventHandler(this.lblLastBankProcessAmount_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Gelen Son EFT/Havale";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(229)))), ((int)(((byte)(56)))));
            this.panel4.Controls.Add(this.lblBillAmount);
            this.panel4.Controls.Add(this.lblBillTitle);
            this.panel4.Location = new System.Drawing.Point(427, 58);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(205, 117);
            this.panel4.TabIndex = 6;
            // 
            // lblBillAmount
            // 
            this.lblBillAmount.AutoSize = true;
            this.lblBillAmount.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblBillAmount.ForeColor = System.Drawing.Color.Black;
            this.lblBillAmount.Location = new System.Drawing.Point(6, 46);
            this.lblBillAmount.Name = "lblBillAmount";
            this.lblBillAmount.Size = new System.Drawing.Size(230, 46);
            this.lblBillAmount.TabIndex = 2;
            this.lblBillAmount.Text = "1.000.000,00 ₺";
            // 
            // lblBillTitle
            // 
            this.lblBillTitle.AutoSize = true;
            this.lblBillTitle.ForeColor = System.Drawing.Color.Black;
            this.lblBillTitle.Location = new System.Drawing.Point(8, 8);
            this.lblBillTitle.Name = "lblBillTitle";
            this.lblBillTitle.Size = new System.Drawing.Size(127, 28);
            this.lblBillTitle.TabIndex = 1;
            this.lblBillTitle.Text = "Fatura Başlığı";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(18)))));
            this.panel3.Controls.Add(this.lblTotalBalance);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(206, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(205, 117);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lblTotalBalance
            // 
            this.lblTotalBalance.AutoSize = true;
            this.lblTotalBalance.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblTotalBalance.ForeColor = System.Drawing.Color.Black;
            this.lblTotalBalance.Location = new System.Drawing.Point(6, 46);
            this.lblTotalBalance.Name = "lblTotalBalance";
            this.lblTotalBalance.Size = new System.Drawing.Size(230, 46);
            this.lblTotalBalance.TabIndex = 1;
            this.lblTotalBalance.Text = "1.000.000,00 ₺";
            this.lblTotalBalance.Click += new System.EventHandler(this.lblTotalBalance_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Toplam Bakiyem";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SpringGreen;
            this.panel6.Controls.Add(this.chart2);
            this.panel6.Controls.Add(this.chart1);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(206, 181);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(653, 317);
            this.panel6.TabIndex = 10;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(324, 52);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(326, 262);
            this.chart2.TabIndex = 12;
            this.chart2.Text = "chart2";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(3, 52);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(315, 262);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(389, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 39);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fatura Tutarları";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(55, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "Banka Bakiyeleri";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(859, 495);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard Formu";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnBankProcesses;
        private System.Windows.Forms.Button btnSpendings;
        private System.Windows.Forms.Button btnBills;
        private System.Windows.Forms.Button btnBanks;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblLastBankProcessAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblBillAmount;
        private System.Windows.Forms.Label lblBillTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalBalance;
        private System.Windows.Forms.Label label2;
        //private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        //private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUserNameSurname;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
