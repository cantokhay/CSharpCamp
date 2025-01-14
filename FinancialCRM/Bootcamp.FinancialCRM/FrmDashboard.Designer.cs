namespace Bootcamp.FinancialCRM
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnBankProcesses = new System.Windows.Forms.Button();
            this.btnSpendings = new System.Windows.Forms.Button();
            this.btnInvoices = new System.Windows.Forms.Button();
            this.btnBanks = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblLastBankProcessAmount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblInvoiceAmount = new System.Windows.Forms.Label();
            this.lblInvoiceTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalBalance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chartBankData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartInvoiceData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBankData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartInvoiceData)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dashboard / Genel Bakış";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(827, 34);
            this.panel2.TabIndex = 7;
            // 
            // btnQuit
            // 
            this.btnQuit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(48)))), ((int)(((byte)(95)))));
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Location = new System.Drawing.Point(37, 436);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(149, 36);
            this.btnQuit.TabIndex = 0;
            this.btnQuit.Text = "Çıkış Yap";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(48)))), ((int)(((byte)(95)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(37, 376);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(149, 36);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "Ayarlar";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDashboard.Enabled = false;
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(48)))), ((int)(((byte)(95)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDashboard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(37, 316);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(149, 36);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnBankProcesses
            // 
            this.btnBankProcesses.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(48)))), ((int)(((byte)(95)))));
            this.btnBankProcesses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankProcesses.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankProcesses.ForeColor = System.Drawing.Color.White;
            this.btnBankProcesses.Location = new System.Drawing.Point(37, 256);
            this.btnBankProcesses.Name = "btnBankProcesses";
            this.btnBankProcesses.Size = new System.Drawing.Size(149, 36);
            this.btnBankProcesses.TabIndex = 0;
            this.btnBankProcesses.Text = "Banka Hareketleri";
            this.btnBankProcesses.UseVisualStyleBackColor = true;
            // 
            // btnSpendings
            // 
            this.btnSpendings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(48)))), ((int)(((byte)(95)))));
            this.btnSpendings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpendings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSpendings.ForeColor = System.Drawing.Color.White;
            this.btnSpendings.Location = new System.Drawing.Point(37, 196);
            this.btnSpendings.Name = "btnSpendings";
            this.btnSpendings.Size = new System.Drawing.Size(149, 36);
            this.btnSpendings.TabIndex = 0;
            this.btnSpendings.Text = "Giderler";
            this.btnSpendings.UseVisualStyleBackColor = true;
            // 
            // btnInvoices
            // 
            this.btnInvoices.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(48)))), ((int)(((byte)(95)))));
            this.btnInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoices.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInvoices.ForeColor = System.Drawing.Color.White;
            this.btnInvoices.Location = new System.Drawing.Point(37, 136);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(149, 36);
            this.btnInvoices.TabIndex = 0;
            this.btnInvoices.Text = "Faturalar";
            this.btnInvoices.UseVisualStyleBackColor = true;
            this.btnInvoices.Click += new System.EventHandler(this.btnInvoices_Click);
            // 
            // btnBanks
            // 
            this.btnBanks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(48)))), ((int)(((byte)(95)))));
            this.btnBanks.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(48)))), ((int)(((byte)(95)))));
            this.btnBanks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanks.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanks.ForeColor = System.Drawing.Color.White;
            this.btnBanks.Location = new System.Drawing.Point(37, 76);
            this.btnBanks.Name = "btnBanks";
            this.btnBanks.Size = new System.Drawing.Size(149, 36);
            this.btnBanks.TabIndex = 0;
            this.btnBanks.Text = "Bankalar";
            this.btnBanks.UseVisualStyleBackColor = false;
            this.btnBanks.Click += new System.EventHandler(this.btnBanks_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(48)))), ((int)(((byte)(95)))));
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategories.ForeColor = System.Drawing.Color.White;
            this.btnCategories.Location = new System.Drawing.Point(37, 16);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(149, 36);
            this.btnCategories.TabIndex = 0;
            this.btnCategories.Text = "Kategoriler";
            this.btnCategories.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(48)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.btnQuit);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.btnBankProcesses);
            this.panel1.Controls.Add(this.btnSpendings);
            this.panel1.Controls.Add(this.btnInvoices);
            this.panel1.Controls.Add(this.btnBanks);
            this.panel1.Controls.Add(this.btnCategories);
            this.panel1.Location = new System.Drawing.Point(-1, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 507);
            this.panel1.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.panel5.Controls.Add(this.lblLastBankProcessAmount);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(613, 41);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 121);
            this.panel5.TabIndex = 8;
            // 
            // lblLastBankProcessAmount
            // 
            this.lblLastBankProcessAmount.AutoSize = true;
            this.lblLastBankProcessAmount.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastBankProcessAmount.ForeColor = System.Drawing.Color.White;
            this.lblLastBankProcessAmount.Location = new System.Drawing.Point(2, 49);
            this.lblLastBankProcessAmount.Name = "lblLastBankProcessAmount";
            this.lblLastBankProcessAmount.Size = new System.Drawing.Size(175, 49);
            this.lblLastBankProcessAmount.TabIndex = 3;
            this.lblLastBankProcessAmount.Text = "????,?? ₺";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "Son Gelen Transfer";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel4.Controls.Add(this.lblInvoiceAmount);
            this.panel4.Controls.Add(this.lblInvoiceTitle);
            this.panel4.Location = new System.Drawing.Point(407, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 121);
            this.panel4.TabIndex = 9;
            // 
            // lblInvoiceAmount
            // 
            this.lblInvoiceAmount.AutoSize = true;
            this.lblInvoiceAmount.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInvoiceAmount.ForeColor = System.Drawing.Color.White;
            this.lblInvoiceAmount.Location = new System.Drawing.Point(2, 49);
            this.lblInvoiceAmount.Name = "lblInvoiceAmount";
            this.lblInvoiceAmount.Size = new System.Drawing.Size(175, 49);
            this.lblInvoiceAmount.TabIndex = 3;
            this.lblInvoiceAmount.Text = "????,?? ₺";
            // 
            // lblInvoiceTitle
            // 
            this.lblInvoiceTitle.AutoSize = true;
            this.lblInvoiceTitle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInvoiceTitle.ForeColor = System.Drawing.Color.White;
            this.lblInvoiceTitle.Location = new System.Drawing.Point(3, 4);
            this.lblInvoiceTitle.Name = "lblInvoiceTitle";
            this.lblInvoiceTitle.Size = new System.Drawing.Size(90, 18);
            this.lblInvoiceTitle.TabIndex = 3;
            this.lblInvoiceTitle.Text = "Fatura Başlığı";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.panel3.Controls.Add(this.lblTotalBalance);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(201, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 121);
            this.panel3.TabIndex = 10;
            // 
            // lblTotalBalance
            // 
            this.lblTotalBalance.AutoSize = true;
            this.lblTotalBalance.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalBalance.ForeColor = System.Drawing.Color.White;
            this.lblTotalBalance.Location = new System.Drawing.Point(2, 49);
            this.lblTotalBalance.Name = "lblTotalBalance";
            this.lblTotalBalance.Size = new System.Drawing.Size(175, 49);
            this.lblTotalBalance.TabIndex = 3;
            this.lblTotalBalance.Text = "????,?? ₺";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Toplam Bakiyem";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chartBankData
            // 
            chartArea1.Name = "ChartArea1";
            this.chartBankData.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chartBankData.Legends.Add(legend1);
            this.chartBankData.Location = new System.Drawing.Point(206, 227);
            this.chartBankData.Name = "chartBankData";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartBankData.Series.Add(series1);
            this.chartBankData.Size = new System.Drawing.Size(295, 300);
            this.chartBankData.TabIndex = 11;
            this.chartBankData.Text = "chart1";
            // 
            // chartInvoiceData
            // 
            chartArea2.Name = "ChartArea1";
            this.chartInvoiceData.ChartAreas.Add(chartArea2);
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chartInvoiceData.Legends.Add(legend2);
            this.chartInvoiceData.Location = new System.Drawing.Point(515, 227);
            this.chartInvoiceData.Name = "chartInvoiceData";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chartInvoiceData.Series.Add(series2);
            this.chartInvoiceData.Size = new System.Drawing.Size(295, 300);
            this.chartInvoiceData.TabIndex = 11;
            this.chartInvoiceData.Text = "chart1";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(206, 168);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(295, 53);
            this.panel6.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bankalar arası transferlerde hız ve güvenlik önemlidir. \r\nTeknolojik gelişmelerle" +
    ", işlemleriniz saniyeler içinde \r\ntamamlanır. Veriler, bu değişimi grafiklerle g" +
    "österir.";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(515, 168);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(295, 53);
            this.panel7.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(17, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bankalar arası transferlerde hız ve güvenlik önemlidir. \r\nTeknolojik gelişmelerle" +
    ", işlemleriniz saniyeler içinde \r\ntamamlanır. Veriler, bu değişimi grafiklerle g" +
    "österir.";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label5);
            this.panel8.Location = new System.Drawing.Point(515, 168);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(295, 53);
            this.panel8.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(9, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 39);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ödenen ve ödenecek faturalar, finansal planlamada kritik \r\nrol oynar. Grafikler, " +
    "ödeme düzenlerini ve gelecekteki \r\nyükümlülükleri görselleştirmede etkili bir ar" +
    "açtır.";
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(825, 535);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.chartInvoiceData);
            this.Controls.Add(this.chartBankData);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBankData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartInvoiceData)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnBankProcesses;
        private System.Windows.Forms.Button btnSpendings;
        private System.Windows.Forms.Button btnInvoices;
        private System.Windows.Forms.Button btnBanks;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblLastBankProcessAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblInvoiceAmount;
        private System.Windows.Forms.Label lblInvoiceTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBankData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartInvoiceData;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label5;
    }
}

