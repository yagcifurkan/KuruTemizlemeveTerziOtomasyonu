namespace KuruTemizlemeveTerziOtomasyon
{
    partial class AnaSayfa
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.müşteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniKayıtEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teslimEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tümKayıtlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onarımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onarımEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniÜrünToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniŞikayetEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniOnarımEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yönetimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniÇalışanEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eskiÇalışanıSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Yenile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(860, 393);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriToolStripMenuItem,
            this.onarımToolStripMenuItem,
            this.işlemlerToolStripMenuItem,
            this.yönetimToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // müşteriToolStripMenuItem
            // 
            this.müşteriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniKayıtEkleToolStripMenuItem,
            this.teslimEtToolStripMenuItem,
            this.tümKayıtlarToolStripMenuItem});
            this.müşteriToolStripMenuItem.Name = "müşteriToolStripMenuItem";
            this.müşteriToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.müşteriToolStripMenuItem.Text = "Müşteri";
            // 
            // yeniKayıtEkleToolStripMenuItem
            // 
            this.yeniKayıtEkleToolStripMenuItem.Name = "yeniKayıtEkleToolStripMenuItem";
            this.yeniKayıtEkleToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.yeniKayıtEkleToolStripMenuItem.Text = "Yeni Kayıt Ekle";
            this.yeniKayıtEkleToolStripMenuItem.Click += new System.EventHandler(this.yeniKayıtEkleToolStripMenuItem_Click);
            // 
            // teslimEtToolStripMenuItem
            // 
            this.teslimEtToolStripMenuItem.Name = "teslimEtToolStripMenuItem";
            this.teslimEtToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.teslimEtToolStripMenuItem.Text = "Teslim Et";
            this.teslimEtToolStripMenuItem.Click += new System.EventHandler(this.teslimEtToolStripMenuItem_Click);
            // 
            // tümKayıtlarToolStripMenuItem
            // 
            this.tümKayıtlarToolStripMenuItem.Name = "tümKayıtlarToolStripMenuItem";
            this.tümKayıtlarToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.tümKayıtlarToolStripMenuItem.Text = "Tüm Kayıtlar";
            this.tümKayıtlarToolStripMenuItem.Click += new System.EventHandler(this.tümKayıtlarToolStripMenuItem_Click);
            // 
            // onarımToolStripMenuItem
            // 
            this.onarımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onarımEkleToolStripMenuItem});
            this.onarımToolStripMenuItem.Name = "onarımToolStripMenuItem";
            this.onarımToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.onarımToolStripMenuItem.Text = "Onarım";
            // 
            // onarımEkleToolStripMenuItem
            // 
            this.onarımEkleToolStripMenuItem.Name = "onarımEkleToolStripMenuItem";
            this.onarımEkleToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.onarımEkleToolStripMenuItem.Text = "Onarım Ekle";
            this.onarımEkleToolStripMenuItem.Click += new System.EventHandler(this.onarımEkleToolStripMenuItem_Click);
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniÜrünToolStripMenuItem,
            this.yeniŞikayetEkleToolStripMenuItem,
            this.yeniOnarımEkleToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // yeniÜrünToolStripMenuItem
            // 
            this.yeniÜrünToolStripMenuItem.Name = "yeniÜrünToolStripMenuItem";
            this.yeniÜrünToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.yeniÜrünToolStripMenuItem.Text = "Yeni Ürün Ekle";
            this.yeniÜrünToolStripMenuItem.Click += new System.EventHandler(this.yeniÜrünToolStripMenuItem_Click);
            // 
            // yeniŞikayetEkleToolStripMenuItem
            // 
            this.yeniŞikayetEkleToolStripMenuItem.Name = "yeniŞikayetEkleToolStripMenuItem";
            this.yeniŞikayetEkleToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.yeniŞikayetEkleToolStripMenuItem.Text = "Yeni Şikayet Ekle";
            this.yeniŞikayetEkleToolStripMenuItem.Click += new System.EventHandler(this.yeniŞikayetEkleToolStripMenuItem_Click);
            // 
            // yeniOnarımEkleToolStripMenuItem
            // 
            this.yeniOnarımEkleToolStripMenuItem.Name = "yeniOnarımEkleToolStripMenuItem";
            this.yeniOnarımEkleToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.yeniOnarımEkleToolStripMenuItem.Text = "Yeni Onarım Ekle";
            this.yeniOnarımEkleToolStripMenuItem.Click += new System.EventHandler(this.yeniOnarımEkleToolStripMenuItem_Click);
            // 
            // yönetimToolStripMenuItem
            // 
            this.yönetimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniÇalışanEkleToolStripMenuItem,
            this.eskiÇalışanıSilToolStripMenuItem});
            this.yönetimToolStripMenuItem.Name = "yönetimToolStripMenuItem";
            this.yönetimToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.yönetimToolStripMenuItem.Text = "Yönetim";
            // 
            // yeniÇalışanEkleToolStripMenuItem
            // 
            this.yeniÇalışanEkleToolStripMenuItem.Name = "yeniÇalışanEkleToolStripMenuItem";
            this.yeniÇalışanEkleToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.yeniÇalışanEkleToolStripMenuItem.Text = "Yeni Çalışan Ekle";
            this.yeniÇalışanEkleToolStripMenuItem.Click += new System.EventHandler(this.yeniÇalışanEkleToolStripMenuItem_Click);
            // 
            // eskiÇalışanıSilToolStripMenuItem
            // 
            this.eskiÇalışanıSilToolStripMenuItem.Name = "eskiÇalışanıSilToolStripMenuItem";
            this.eskiÇalışanıSilToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.eskiÇalışanıSilToolStripMenuItem.Text = "Eski Çalışanı Sil";
            this.eskiÇalışanıSilToolStripMenuItem.Click += new System.EventHandler(this.eskiÇalışanıSilToolStripMenuItem_Click);
            // 
            // btn_Yenile
            // 
            this.btn_Yenile.Location = new System.Drawing.Point(12, 426);
            this.btn_Yenile.Name = "btn_Yenile";
            this.btn_Yenile.Size = new System.Drawing.Size(860, 23);
            this.btn_Yenile.TabIndex = 2;
            this.btn_Yenile.Text = "Yenile";
            this.btn_Yenile.UseVisualStyleBackColor = true;
            this.btn_Yenile.Click += new System.EventHandler(this.btn_Yenile_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.btn_Yenile);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kuru Temizleme ve Terzi Otomasyonu";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müşteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniKayıtEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teslimEtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tümKayıtlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniÜrünToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniŞikayetEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniOnarımEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onarımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onarımEkleToolStripMenuItem;
        private System.Windows.Forms.Button btn_Yenile;
        private System.Windows.Forms.ToolStripMenuItem yönetimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniÇalışanEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eskiÇalışanıSilToolStripMenuItem;
    }
}