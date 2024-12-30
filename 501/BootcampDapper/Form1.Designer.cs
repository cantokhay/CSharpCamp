namespace BootcampDapper
{
    partial class Form1
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
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.btnList = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductStock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductCategory = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblTotalProductCountLabel = new System.Windows.Forms.Label();
            this.lblTotalProductCountStat = new System.Windows.Forms.Label();
            this.lblMaxPricedProductLabel = new System.Windows.Forms.Label();
            this.lblMaxPricedProductStat = new System.Windows.Forms.Label();
            this.lblCategoryCountLabel = new System.Windows.Forms.Label();
            this.lblCategoryCountStat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Id : ";
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(85, 23);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(100, 20);
            this.txtProductId.TabIndex = 0;
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.Yellow;
            this.btnList.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnList.Location = new System.Drawing.Point(45, 159);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(124, 31);
            this.btnList.TabIndex = 6;
            this.btnList.Text = "LİSTELE";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(205, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(512, 286);
            this.dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Adı : ";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(85, 49);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 20);
            this.txtProductName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Stok Sayısı : ";
            // 
            // txtProductStock
            // 
            this.txtProductStock.Location = new System.Drawing.Point(85, 75);
            this.txtProductStock.Name = "txtProductStock";
            this.txtProductStock.Size = new System.Drawing.Size(100, 20);
            this.txtProductStock.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ürün Fiyatı : ";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(85, 101);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(100, 20);
            this.txtProductPrice.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kategori : ";
            // 
            // txtProductCategory
            // 
            this.txtProductCategory.Location = new System.Drawing.Point(85, 127);
            this.txtProductCategory.Name = "txtProductCategory";
            this.txtProductCategory.Size = new System.Drawing.Size(100, 20);
            this.txtProductCategory.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Yellow;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAdd.Location = new System.Drawing.Point(45, 191);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 31);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "EKLE";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Yellow;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Location = new System.Drawing.Point(45, 223);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 31);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "SİL";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUpdate.Location = new System.Drawing.Point(45, 255);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(124, 31);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "GÜNCELLE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblTotalProductCountLabel
            // 
            this.lblTotalProductCountLabel.AutoSize = true;
            this.lblTotalProductCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalProductCountLabel.Location = new System.Drawing.Point(13, 309);
            this.lblTotalProductCountLabel.Name = "lblTotalProductCountLabel";
            this.lblTotalProductCountLabel.Size = new System.Drawing.Size(178, 20);
            this.lblTotalProductCountLabel.TabIndex = 10;
            this.lblTotalProductCountLabel.Text = "Toplam Ürün Sayısı : ";
            // 
            // lblTotalProductCountStat
            // 
            this.lblTotalProductCountStat.AutoSize = true;
            this.lblTotalProductCountStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalProductCountStat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalProductCountStat.Location = new System.Drawing.Point(181, 305);
            this.lblTotalProductCountStat.Name = "lblTotalProductCountStat";
            this.lblTotalProductCountStat.Size = new System.Drawing.Size(81, 29);
            this.lblTotalProductCountStat.TabIndex = 10;
            this.lblTotalProductCountStat.Text = "666??";
            // 
            // lblMaxPricedProductLabel
            // 
            this.lblMaxPricedProductLabel.AutoSize = true;
            this.lblMaxPricedProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaxPricedProductLabel.Location = new System.Drawing.Point(47, 340);
            this.lblMaxPricedProductLabel.Name = "lblMaxPricedProductLabel";
            this.lblMaxPricedProductLabel.Size = new System.Drawing.Size(144, 20);
            this.lblMaxPricedProductLabel.TabIndex = 10;
            this.lblMaxPricedProductLabel.Text = "En Pahalı Ürün : ";
            // 
            // lblMaxPricedProductStat
            // 
            this.lblMaxPricedProductStat.AutoSize = true;
            this.lblMaxPricedProductStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaxPricedProductStat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMaxPricedProductStat.Location = new System.Drawing.Point(181, 336);
            this.lblMaxPricedProductStat.Name = "lblMaxPricedProductStat";
            this.lblMaxPricedProductStat.Size = new System.Drawing.Size(81, 29);
            this.lblMaxPricedProductStat.TabIndex = 10;
            this.lblMaxPricedProductStat.Text = "666??";
            // 
            // lblCategoryCountLabel
            // 
            this.lblCategoryCountLabel.AutoSize = true;
            this.lblCategoryCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategoryCountLabel.Location = new System.Drawing.Point(47, 369);
            this.lblCategoryCountLabel.Name = "lblCategoryCountLabel";
            this.lblCategoryCountLabel.Size = new System.Drawing.Size(143, 20);
            this.lblCategoryCountLabel.TabIndex = 10;
            this.lblCategoryCountLabel.Text = "Kategori Sayısı : ";
            // 
            // lblCategoryCountStat
            // 
            this.lblCategoryCountStat.AutoSize = true;
            this.lblCategoryCountStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategoryCountStat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCategoryCountStat.Location = new System.Drawing.Point(181, 365);
            this.lblCategoryCountStat.Name = "lblCategoryCountStat";
            this.lblCategoryCountStat.Size = new System.Drawing.Size(81, 29);
            this.lblCategoryCountStat.TabIndex = 10;
            this.lblCategoryCountStat.Text = "666??";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(729, 421);
            this.Controls.Add(this.lblCategoryCountStat);
            this.Controls.Add(this.lblCategoryCountLabel);
            this.Controls.Add(this.lblMaxPricedProductStat);
            this.Controls.Add(this.lblMaxPricedProductLabel);
            this.Controls.Add(this.lblTotalProductCountStat);
            this.Controls.Add(this.lblTotalProductCountLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.txtProductCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProductStock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProductCategory;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblTotalProductCountLabel;
        private System.Windows.Forms.Label lblTotalProductCountStat;
        private System.Windows.Forms.Label lblMaxPricedProductLabel;
        private System.Windows.Forms.Label lblMaxPricedProductStat;
        private System.Windows.Forms.Label lblCategoryCountLabel;
        private System.Windows.Forms.Label lblCategoryCountStat;
    }
}

