namespace KuruTemizlemeveTerziOtomasyon
{
    partial class YeniOnarim
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_OnarimAciklama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_StandartUcret = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listView_Onarimlar = new System.Windows.Forms.ListView();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mevcut Onarımlar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Onarım Açıklaması";
            // 
            // txt_OnarimAciklama
            // 
            this.txt_OnarimAciklama.Location = new System.Drawing.Point(12, 25);
            this.txt_OnarimAciklama.Name = "txt_OnarimAciklama";
            this.txt_OnarimAciklama.Size = new System.Drawing.Size(150, 20);
            this.txt_OnarimAciklama.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Standart Ücret";
            // 
            // txt_StandartUcret
            // 
            this.txt_StandartUcret.Location = new System.Drawing.Point(12, 73);
            this.txt_StandartUcret.Name = "txt_StandartUcret";
            this.txt_StandartUcret.Size = new System.Drawing.Size(150, 20);
            this.txt_StandartUcret.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Şikayet Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView_Onarimlar
            // 
            this.listView_Onarimlar.HideSelection = false;
            this.listView_Onarimlar.Location = new System.Drawing.Point(192, 27);
            this.listView_Onarimlar.Name = "listView_Onarimlar";
            this.listView_Onarimlar.Size = new System.Drawing.Size(300, 95);
            this.listView_Onarimlar.TabIndex = 10;
            this.listView_Onarimlar.UseCompatibleStateImageBehavior = false;
            this.listView_Onarimlar.View = System.Windows.Forms.View.List;
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(192, 128);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(300, 23);
            this.btn_Sil.TabIndex = 11;
            this.btn_Sil.Text = "Onarım Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // YeniOnarim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 161);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.listView_Onarimlar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_StandartUcret);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_OnarimAciklama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "YeniOnarim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Onarım Ekle";
            this.Load += new System.EventHandler(this.YeniOnarim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_OnarimAciklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_StandartUcret;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView_Onarimlar;
        private System.Windows.Forms.Button btn_Sil;
    }
}