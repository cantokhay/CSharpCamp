﻿namespace Bootcamp.Presentation
{
    partial class FrmCategory
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
            this.btnList = new System.Windows.Forms.Button();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.dgvCategoryList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radCategoryStatusActive = new System.Windows.Forms.RadioButton();
            this.radCategoryStatusPassive = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpgrade = new System.Windows.Forms.Button();
            this.btnGetById = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori ID : ";
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.DarkOrange;
            this.btnList.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnList.Location = new System.Drawing.Point(35, 103);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(210, 30);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "LISTELE";
            this.btnList.UseVisualStyleBackColor = false;
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Location = new System.Drawing.Point(125, 20);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(135, 20);
            this.txtCategoryId.TabIndex = 1;
            // 
            // dgvCategoryList
            // 
            this.dgvCategoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoryList.Location = new System.Drawing.Point(280, 20);
            this.dgvCategoryList.Name = "dgvCategoryList";
            this.dgvCategoryList.Size = new System.Drawing.Size(300, 250);
            this.dgvCategoryList.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kategori Adı : ";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(125, 50);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(135, 20);
            this.txtCategoryName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kategori Durumu : ";
            // 
            // radCategoryStatusActive
            // 
            this.radCategoryStatusActive.AutoSize = true;
            this.radCategoryStatusActive.Location = new System.Drawing.Point(125, 80);
            this.radCategoryStatusActive.Name = "radCategoryStatusActive";
            this.radCategoryStatusActive.Size = new System.Drawing.Size(46, 17);
            this.radCategoryStatusActive.TabIndex = 3;
            this.radCategoryStatusActive.TabStop = true;
            this.radCategoryStatusActive.Text = "Aktif";
            this.radCategoryStatusActive.UseVisualStyleBackColor = true;
            // 
            // radCategoryStatusPassive
            // 
            this.radCategoryStatusPassive.AutoSize = true;
            this.radCategoryStatusPassive.Location = new System.Drawing.Point(212, 80);
            this.radCategoryStatusPassive.Name = "radCategoryStatusPassive";
            this.radCategoryStatusPassive.Size = new System.Drawing.Size(48, 17);
            this.radCategoryStatusPassive.TabIndex = 4;
            this.radCategoryStatusPassive.TabStop = true;
            this.radCategoryStatusPassive.Text = "Pasif";
            this.radCategoryStatusPassive.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(35, 139);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(210, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "EKLE";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(35, 175);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(210, 30);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "SIL";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpgrade
            // 
            this.btnUpgrade.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpgrade.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpgrade.Location = new System.Drawing.Point(35, 211);
            this.btnUpgrade.Name = "btnUpgrade";
            this.btnUpgrade.Size = new System.Drawing.Size(210, 30);
            this.btnUpgrade.TabIndex = 1;
            this.btnUpgrade.Text = "GUNCELLE";
            this.btnUpgrade.UseVisualStyleBackColor = false;
            // 
            // btnGetById
            // 
            this.btnGetById.BackColor = System.Drawing.Color.DarkOrange;
            this.btnGetById.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetById.Location = new System.Drawing.Point(35, 247);
            this.btnGetById.Name = "btnGetById";
            this.btnGetById.Size = new System.Drawing.Size(210, 30);
            this.btnGetById.TabIndex = 1;
            this.btnGetById.Text = "ID\'YE GORE GETIR";
            this.btnGetById.UseVisualStyleBackColor = false;
            // 
            // FrmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 286);
            this.Controls.Add(this.radCategoryStatusPassive);
            this.Controls.Add(this.radCategoryStatusActive);
            this.Controls.Add(this.dgvCategoryList);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.txtCategoryId);
            this.Controls.Add(this.btnGetById);
            this.Controls.Add(this.btnUpgrade);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCategory";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.DataGridView dgvCategoryList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radCategoryStatusActive;
        private System.Windows.Forms.RadioButton radCategoryStatusPassive;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpgrade;
        private System.Windows.Forms.Button btnGetById;
    }
}

