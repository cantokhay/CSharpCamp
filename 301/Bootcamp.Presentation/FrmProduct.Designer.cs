namespace Bootcamp.Presentation
{
    partial class FrmProduct
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
            this.dgvProductsList = new System.Windows.Forms.DataGridView();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.btnGetById = new System.Windows.Forms.Button();
            this.btnUpgrade = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numProductStock = new System.Windows.Forms.NumericUpDown();
            this.txtProductDescription = new System.Windows.Forms.RichTextBox();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnList2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProductStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductsList
            // 
            this.dgvProductsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductsList.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvProductsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsList.Location = new System.Drawing.Point(280, 20);
            this.dgvProductsList.Name = "dgvProductsList";
            this.dgvProductsList.Size = new System.Drawing.Size(660, 375);
            this.dgvProductsList.TabIndex = 43;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(125, 50);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(135, 20);
            this.txtProductName.TabIndex = 2;
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(125, 20);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(135, 20);
            this.txtProductId.TabIndex = 1;
            // 
            // btnGetById
            // 
            this.btnGetById.BackColor = System.Drawing.Color.DarkOrange;
            this.btnGetById.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetById.Location = new System.Drawing.Point(45, 372);
            this.btnGetById.Name = "btnGetById";
            this.btnGetById.Size = new System.Drawing.Size(190, 30);
            this.btnGetById.TabIndex = 11;
            this.btnGetById.Text = "ID\'YE GORE GETIR";
            this.btnGetById.UseVisualStyleBackColor = false;
            // 
            // btnUpgrade
            // 
            this.btnUpgrade.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpgrade.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpgrade.Location = new System.Drawing.Point(45, 336);
            this.btnUpgrade.Name = "btnUpgrade";
            this.btnUpgrade.Size = new System.Drawing.Size(190, 30);
            this.btnUpgrade.TabIndex = 10;
            this.btnUpgrade.Text = "GUNCELLE";
            this.btnUpgrade.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(45, 300);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(190, 30);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "SIL";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(45, 264);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(190, 30);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "EKLE";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.DarkOrange;
            this.btnList.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnList.Location = new System.Drawing.Point(45, 228);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 30);
            this.btnList.TabIndex = 7;
            this.btnList.Text = "LISTELE";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Ürün Adı : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Ürün ID : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Ürün Stok Sayısı : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Ürün Fiyatı : ";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(125, 110);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(135, 20);
            this.txtProductPrice.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Ürün Açıklaması : ";
            // 
            // numProductStock
            // 
            this.numProductStock.Location = new System.Drawing.Point(125, 80);
            this.numProductStock.Name = "numProductStock";
            this.numProductStock.Size = new System.Drawing.Size(135, 20);
            this.numProductStock.TabIndex = 3;
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Location = new System.Drawing.Point(125, 140);
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(135, 50);
            this.txtProductDescription.TabIndex = 5;
            this.txtProductDescription.Text = "";
            // 
            // cmbCategories
            // 
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(125, 200);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(135, 21);
            this.cmbCategories.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Kategori : ";
            // 
            // btnList2
            // 
            this.btnList2.BackColor = System.Drawing.Color.DarkOrange;
            this.btnList2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnList2.Location = new System.Drawing.Point(160, 228);
            this.btnList2.Name = "btnList2";
            this.btnList2.Size = new System.Drawing.Size(75, 30);
            this.btnList2.TabIndex = 7;
            this.btnList2.Text = "LISTELE2";
            this.btnList2.UseVisualStyleBackColor = false;
            this.btnList2.Click += new System.EventHandler(this.btnList2_Click);
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(959, 411);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.txtProductDescription);
            this.Controls.Add(this.numProductStock);
            this.Controls.Add(this.dgvProductsList);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.btnGetById);
            this.Controls.Add(this.btnUpgrade);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnList2);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmProduct";
            this.Text = "Ürünler";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProductStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvProductsList;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Button btnGetById;
        private System.Windows.Forms.Button btnUpgrade;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numProductStock;
        private System.Windows.Forms.RichTextBox txtProductDescription;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnList2;
    }
}