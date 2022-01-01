namespace KuruTemizlemeveTerziOtomasyon
{
    partial class OnarimEkle
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
            this.cmb_Urun = new System.Windows.Forms.ComboBox();
            this.cmb_Islem = new System.Windows.Forms.ComboBox();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.listView_Yapılacaklar = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listView_Islemler = new System.Windows.Forms.ListView();
            this.btn_TamiratiBitir = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_IslemSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "İşlem";
            // 
            // cmb_Urun
            // 
            this.cmb_Urun.FormattingEnabled = true;
            this.cmb_Urun.Location = new System.Drawing.Point(48, 12);
            this.cmb_Urun.Name = "cmb_Urun";
            this.cmb_Urun.Size = new System.Drawing.Size(150, 21);
            this.cmb_Urun.TabIndex = 2;
            this.cmb_Urun.SelectedIndexChanged += new System.EventHandler(this.cmb_Urun_SelectedIndexChanged);
            // 
            // cmb_Islem
            // 
            this.cmb_Islem.FormattingEnabled = true;
            this.cmb_Islem.Location = new System.Drawing.Point(48, 39);
            this.cmb_Islem.Name = "cmb_Islem";
            this.cmb_Islem.Size = new System.Drawing.Size(150, 21);
            this.cmb_Islem.TabIndex = 3;
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(15, 66);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(183, 23);
            this.btn_Ekle.TabIndex = 4;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // listView_Yapılacaklar
            // 
            this.listView_Yapılacaklar.HideSelection = false;
            this.listView_Yapılacaklar.Location = new System.Drawing.Point(12, 121);
            this.listView_Yapılacaklar.Name = "listView_Yapılacaklar";
            this.listView_Yapılacaklar.Size = new System.Drawing.Size(186, 97);
            this.listView_Yapılacaklar.TabIndex = 5;
            this.listView_Yapılacaklar.UseCompatibleStateImageBehavior = false;
            this.listView_Yapılacaklar.View = System.Windows.Forms.View.List;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yapılacak İşlemler";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Yapılan İşlemler";
            // 
            // listView_Islemler
            // 
            this.listView_Islemler.HideSelection = false;
            this.listView_Islemler.Location = new System.Drawing.Point(234, 121);
            this.listView_Islemler.Name = "listView_Islemler";
            this.listView_Islemler.Size = new System.Drawing.Size(186, 97);
            this.listView_Islemler.TabIndex = 8;
            this.listView_Islemler.UseCompatibleStateImageBehavior = false;
            this.listView_Islemler.View = System.Windows.Forms.View.List;
            // 
            // btn_TamiratiBitir
            // 
            this.btn_TamiratiBitir.Location = new System.Drawing.Point(12, 224);
            this.btn_TamiratiBitir.Name = "btn_TamiratiBitir";
            this.btn_TamiratiBitir.Size = new System.Drawing.Size(408, 23);
            this.btn_TamiratiBitir.TabIndex = 9;
            this.btn_TamiratiBitir.Text = "Tamiratı Bitir";
            this.btn_TamiratiBitir.UseVisualStyleBackColor = true;
            this.btn_TamiratiBitir.Click += new System.EventHandler(this.btn_TamiratiBitir_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(234, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(186, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // btn_IslemSil
            // 
            this.btn_IslemSil.Location = new System.Drawing.Point(234, 66);
            this.btn_IslemSil.Name = "btn_IslemSil";
            this.btn_IslemSil.Size = new System.Drawing.Size(183, 23);
            this.btn_IslemSil.TabIndex = 11;
            this.btn_IslemSil.Text = "İşlem Sil";
            this.btn_IslemSil.UseVisualStyleBackColor = true;
            this.btn_IslemSil.Click += new System.EventHandler(this.btn_IslemSil_Click);
            // 
            // OnarimEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 256);
            this.Controls.Add(this.btn_IslemSil);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_TamiratiBitir);
            this.Controls.Add(this.listView_Islemler);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView_Yapılacaklar);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.cmb_Islem);
            this.Controls.Add(this.cmb_Urun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OnarimEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Onarım Ekle";
            this.Load += new System.EventHandler(this.OnarimEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Urun;
        private System.Windows.Forms.ComboBox cmb_Islem;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.ListView listView_Yapılacaklar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView_Islemler;
        private System.Windows.Forms.Button btn_TamiratiBitir;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_IslemSil;
    }
}