namespace KuruTemizlemeveTerziOtomasyon
{
    partial class YeniSikayet
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
            this.txt_SikayetAciklama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.listView_Sikayetler = new System.Windows.Forms.ListView();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şikayet Açıklaması";
            // 
            // txt_SikayetAciklama
            // 
            this.txt_SikayetAciklama.Location = new System.Drawing.Point(12, 25);
            this.txt_SikayetAciklama.Name = "txt_SikayetAciklama";
            this.txt_SikayetAciklama.Size = new System.Drawing.Size(150, 20);
            this.txt_SikayetAciklama.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mevcut Şikayetler";
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(12, 51);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(150, 23);
            this.btn_Ekle.TabIndex = 4;
            this.btn_Ekle.Text = "Şikayet Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // listView_Sikayetler
            // 
            this.listView_Sikayetler.HideSelection = false;
            this.listView_Sikayetler.Location = new System.Drawing.Point(192, 29);
            this.listView_Sikayetler.Name = "listView_Sikayetler";
            this.listView_Sikayetler.Size = new System.Drawing.Size(300, 95);
            this.listView_Sikayetler.TabIndex = 6;
            this.listView_Sikayetler.UseCompatibleStateImageBehavior = false;
            this.listView_Sikayetler.View = System.Windows.Forms.View.List;
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(192, 130);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(300, 23);
            this.btn_Sil.TabIndex = 7;
            this.btn_Sil.Text = "Şikayet Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // YeniSikayet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 161);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.listView_Sikayetler);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_SikayetAciklama);
            this.Controls.Add(this.label1);
            this.Name = "YeniSikayet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Şikayet";
            this.Load += new System.EventHandler(this.YeniSikayet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SikayetAciklama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.ListView listView_Sikayetler;
        private System.Windows.Forms.Button btn_Sil;
    }
}