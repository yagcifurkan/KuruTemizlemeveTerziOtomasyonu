namespace KuruTemizlemeveTerziOtomasyon
{
    partial class YeniUrun
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_UrunAdi = new System.Windows.Forms.TextBox();
            this.txt_IslemSuresi = new System.Windows.Forms.TextBox();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.listView_Urunler = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ortalama İşlem Süresi";
            // 
            // txt_UrunAdi
            // 
            this.txt_UrunAdi.Location = new System.Drawing.Point(12, 25);
            this.txt_UrunAdi.Name = "txt_UrunAdi";
            this.txt_UrunAdi.Size = new System.Drawing.Size(150, 20);
            this.txt_UrunAdi.TabIndex = 2;
            // 
            // txt_IslemSuresi
            // 
            this.txt_IslemSuresi.Location = new System.Drawing.Point(12, 73);
            this.txt_IslemSuresi.Name = "txt_IslemSuresi";
            this.txt_IslemSuresi.Size = new System.Drawing.Size(150, 20);
            this.txt_IslemSuresi.TabIndex = 3;
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(12, 99);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(150, 23);
            this.btn_Ekle.TabIndex = 4;
            this.btn_Ekle.Text = "Ürün Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // listView_Urunler
            // 
            this.listView_Urunler.HideSelection = false;
            this.listView_Urunler.Location = new System.Drawing.Point(192, 27);
            this.listView_Urunler.Name = "listView_Urunler";
            this.listView_Urunler.Size = new System.Drawing.Size(300, 95);
            this.listView_Urunler.TabIndex = 5;
            this.listView_Urunler.UseCompatibleStateImageBehavior = false;
            this.listView_Urunler.View = System.Windows.Forms.View.List;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mevcut Ürünler";
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(192, 128);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(300, 23);
            this.btn_Sil.TabIndex = 8;
            this.btn_Sil.Text = "Ürün Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // YeniUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 161);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView_Urunler);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.txt_IslemSuresi);
            this.Controls.Add(this.txt_UrunAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "YeniUrun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Ürün";
            this.Load += new System.EventHandler(this.YeniUrun_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_UrunAdi;
        private System.Windows.Forms.TextBox txt_IslemSuresi;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.ListView listView_Urunler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Sil;
    }
}