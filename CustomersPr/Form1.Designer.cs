namespace CustomersPr
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_guncel = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dg_product = new System.Windows.Forms.DataGridView();
            this.tb_productname = new System.Windows.Forms.TextBox();
            this.tb_stock = new System.Windows.Forms.TextBox();
            this.tb_unitprice = new System.Windows.Forms.TextBox();
            this.tb_order = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_product)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(493, 73);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(87, 23);
            this.btn_sil.TabIndex = 0;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(493, 28);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(87, 23);
            this.btn_ekle.TabIndex = 0;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_guncel
            // 
            this.btn_guncel.Location = new System.Drawing.Point(632, 28);
            this.btn_guncel.Name = "btn_guncel";
            this.btn_guncel.Size = new System.Drawing.Size(87, 23);
            this.btn_guncel.TabIndex = 0;
            this.btn_guncel.Text = "Güncelle";
            this.btn_guncel.UseVisualStyleBackColor = true;
            this.btn_guncel.Click += new System.EventHandler(this.btn_guncel_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(632, 73);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(87, 23);
            this.btn_temizle.TabIndex = 0;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_order);
            this.groupBox1.Controls.Add(this.btn_ekle);
            this.groupBox1.Controls.Add(this.tb_unitprice);
            this.groupBox1.Controls.Add(this.btn_temizle);
            this.groupBox1.Controls.Add(this.tb_stock);
            this.groupBox1.Controls.Add(this.btn_sil);
            this.groupBox1.Controls.Add(this.tb_productname);
            this.groupBox1.Controls.Add(this.btn_guncel);
            this.groupBox1.Location = new System.Drawing.Point(36, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 125);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
            // 
            // dg_product
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            this.dg_product.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_product.BackgroundColor = System.Drawing.Color.Aqua;
            this.dg_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_product.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dg_product.Location = new System.Drawing.Point(36, 13);
            this.dg_product.Name = "dg_product";
            this.dg_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_product.Size = new System.Drawing.Size(759, 197);
            this.dg_product.TabIndex = 2;
            this.dg_product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_product_CellClick);
            this.dg_product.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_product_CellContentClick);
            // 
            // tb_productname
            // 
            this.tb_productname.Location = new System.Drawing.Point(90, 50);
            this.tb_productname.Name = "tb_productname";
            this.tb_productname.Size = new System.Drawing.Size(100, 20);
            this.tb_productname.TabIndex = 1;
            // 
            // tb_stock
            // 
            this.tb_stock.Location = new System.Drawing.Point(90, 75);
            this.tb_stock.Name = "tb_stock";
            this.tb_stock.Size = new System.Drawing.Size(100, 20);
            this.tb_stock.TabIndex = 1;
            // 
            // tb_unitprice
            // 
            this.tb_unitprice.Location = new System.Drawing.Point(326, 50);
            this.tb_unitprice.Name = "tb_unitprice";
            this.tb_unitprice.Size = new System.Drawing.Size(100, 20);
            this.tb_unitprice.TabIndex = 1;
            // 
            // tb_order
            // 
            this.tb_order.Location = new System.Drawing.Point(326, 76);
            this.tb_order.Name = "tb_order";
            this.tb_order.Size = new System.Drawing.Size(100, 20);
            this.tb_order.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Birim Fiyat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sipariş Miktar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün Ad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Stok Miktarı";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(90, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 353);
            this.Controls.Add(this.dg_product);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_product)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_guncel;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dg_product;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_order;
        private System.Windows.Forms.TextBox tb_unitprice;
        private System.Windows.Forms.TextBox tb_stock;
        private System.Windows.Forms.TextBox tb_productname;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
    }
}

