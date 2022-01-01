namespace KuruTemizlemeveTerziOtomasyon
{
    partial class Giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_kullaniciadi = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_yonetici = new System.Windows.Forms.Button();
            this.btn_calisan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_kullaniciadi
            // 
            this.txt_kullaniciadi.Location = new System.Drawing.Point(12, 35);
            this.txt_kullaniciadi.Name = "txt_kullaniciadi";
            this.txt_kullaniciadi.Size = new System.Drawing.Size(210, 20);
            this.txt_kullaniciadi.TabIndex = 0;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(12, 93);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '*';
            this.txt_sifre.Size = new System.Drawing.Size(210, 20);
            this.txt_sifre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_yonetici
            // 
            this.btn_yonetici.Location = new System.Drawing.Point(12, 126);
            this.btn_yonetici.Name = "btn_yonetici";
            this.btn_yonetici.Size = new System.Drawing.Size(100, 23);
            this.btn_yonetici.TabIndex = 4;
            this.btn_yonetici.Text = "Yönetici Giriş";
            this.btn_yonetici.UseVisualStyleBackColor = true;
            this.btn_yonetici.Click += new System.EventHandler(this.btn_yonetici_Click);
            // 
            // btn_calisan
            // 
            this.btn_calisan.Location = new System.Drawing.Point(122, 126);
            this.btn_calisan.Name = "btn_calisan";
            this.btn_calisan.Size = new System.Drawing.Size(100, 23);
            this.btn_calisan.TabIndex = 5;
            this.btn_calisan.Text = "Çalışan Giriş";
            this.btn_calisan.UseVisualStyleBackColor = true;
            this.btn_calisan.Click += new System.EventHandler(this.btn_calisan_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 161);
            this.Controls.Add(this.btn_calisan);
            this.Controls.Add(this.btn_yonetici);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_kullaniciadi);
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_kullaniciadi;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_yonetici;
        private System.Windows.Forms.Button btn_calisan;
    }
}

