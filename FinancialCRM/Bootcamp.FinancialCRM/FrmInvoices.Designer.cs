namespace Bootcamp.FinancialCRM
{
    partial class FrmInvoices
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
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnBankProcesses = new System.Windows.Forms.Button();
            this.btnSpendings = new System.Windows.Forms.Button();
            this.btnInvoices = new System.Windows.Forms.Button();
            this.btnBanks = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInvoiceId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInvoiceTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInvoiceAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInvoicePeriod = new System.Windows.Forms.TextBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvInvoiceList = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fatura Ödeme";
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
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(48)))), ((int)(((byte)(95)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(37, 316);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(149, 36);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
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
            this.btnInvoices.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnInvoices.Enabled = false;
            this.btnInvoices.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(48)))), ((int)(((byte)(95)))));
            this.btnInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInvoices.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInvoices.ForeColor = System.Drawing.Color.White;
            this.btnInvoices.Location = new System.Drawing.Point(37, 136);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(149, 36);
            this.btnInvoices.TabIndex = 0;
            this.btnInvoices.Text = "Faturalar";
            this.btnInvoices.UseVisualStyleBackColor = false;
            // 
            // btnBanks
            // 
            this.btnBanks.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(48)))), ((int)(((byte)(95)))));
            this.btnBanks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanks.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanks.ForeColor = System.Drawing.Color.White;
            this.btnBanks.Location = new System.Drawing.Point(37, 76);
            this.btnBanks.Name = "btnBanks";
            this.btnBanks.Size = new System.Drawing.Size(149, 36);
            this.btnBanks.TabIndex = 0;
            this.btnBanks.Text = "Bankalar";
            this.btnBanks.UseVisualStyleBackColor = true;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(827, 34);
            this.panel2.TabIndex = 0;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnList);
            this.panel3.Controls.Add(this.txtInvoicePeriod);
            this.panel3.Controls.Add(this.txtInvoiceAmount);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtInvoiceTitle);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtInvoiceId);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(201, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(612, 190);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvInvoiceList);
            this.panel4.Location = new System.Drawing.Point(201, 238);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(612, 285);
            this.panel4.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ödeme Id :";
            // 
            // txtInvoiceId
            // 
            this.txtInvoiceId.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtInvoiceId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtInvoiceId.Location = new System.Drawing.Point(98, 8);
            this.txtInvoiceId.Name = "txtInvoiceId";
            this.txtInvoiceId.Size = new System.Drawing.Size(494, 27);
            this.txtInvoiceId.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(35, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Başlık :";
            // 
            // txtInvoiceTitle
            // 
            this.txtInvoiceTitle.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtInvoiceTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtInvoiceTitle.Location = new System.Drawing.Point(98, 43);
            this.txtInvoiceTitle.Name = "txtInvoiceTitle";
            this.txtInvoiceTitle.Size = new System.Drawing.Size(494, 27);
            this.txtInvoiceTitle.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(31, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Miktar :";
            // 
            // txtInvoiceAmount
            // 
            this.txtInvoiceAmount.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtInvoiceAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtInvoiceAmount.Location = new System.Drawing.Point(98, 78);
            this.txtInvoiceAmount.Name = "txtInvoiceAmount";
            this.txtInvoiceAmount.Size = new System.Drawing.Size(494, 27);
            this.txtInvoiceAmount.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(27, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Dönem :";
            // 
            // txtInvoicePeriod
            // 
            this.txtInvoicePeriod.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtInvoicePeriod.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtInvoicePeriod.Location = new System.Drawing.Point(98, 113);
            this.txtInvoicePeriod.Name = "txtInvoicePeriod";
            this.txtInvoicePeriod.Size = new System.Drawing.Size(494, 27);
            this.txtInvoicePeriod.TabIndex = 3;
            // 
            // btnList
            // 
            this.btnList.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnList.Location = new System.Drawing.Point(36, 150);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(123, 30);
            this.btnList.TabIndex = 4;
            this.btnList.Text = "Ödeme Listesi";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(306, 150);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 30);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Ödeme Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(171, 150);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 30);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Yeni Ödeme";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(441, 150);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 30);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Ödeme Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvInvoiceList
            // 
            this.dgvInvoiceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoiceList.Location = new System.Drawing.Point(0, 0);
            this.dgvInvoiceList.Name = "dgvInvoiceList";
            this.dgvInvoiceList.Size = new System.Drawing.Size(612, 285);
            this.dgvInvoiceList.TabIndex = 0;
            // 
            // FrmInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(825, 535);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInvoices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInvoices";
            this.Load += new System.EventHandler(this.FrmInvoices_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnBankProcesses;
        private System.Windows.Forms.Button btnSpendings;
        private System.Windows.Forms.Button btnInvoices;
        private System.Windows.Forms.Button btnBanks;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtInvoiceId;
        private System.Windows.Forms.TextBox txtInvoiceTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInvoicePeriod;
        private System.Windows.Forms.TextBox txtInvoiceAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvInvoiceList;
    }
}