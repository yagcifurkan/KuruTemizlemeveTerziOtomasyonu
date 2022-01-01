namespace KuruTemizlemeveTerziOtomasyon
{
    partial class Teslimat
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
            this.txt_FisNo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_TeslimEt = new System.Windows.Forms.Button();
            this.btn_Getir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fiş Numarası";
            // 
            // txt_FisNo
            // 
            this.txt_FisNo.Location = new System.Drawing.Point(85, 12);
            this.txt_FisNo.Name = "txt_FisNo";
            this.txt_FisNo.Size = new System.Drawing.Size(100, 20);
            this.txt_FisNo.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(860, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // btn_TeslimEt
            // 
            this.btn_TeslimEt.Location = new System.Drawing.Point(12, 194);
            this.btn_TeslimEt.Name = "btn_TeslimEt";
            this.btn_TeslimEt.Size = new System.Drawing.Size(860, 23);
            this.btn_TeslimEt.TabIndex = 3;
            this.btn_TeslimEt.Text = "Teslim Et";
            this.btn_TeslimEt.UseVisualStyleBackColor = true;
            this.btn_TeslimEt.Click += new System.EventHandler(this.btn_TeslimEt_Click);
            // 
            // btn_Getir
            // 
            this.btn_Getir.Location = new System.Drawing.Point(191, 12);
            this.btn_Getir.Name = "btn_Getir";
            this.btn_Getir.Size = new System.Drawing.Size(100, 20);
            this.btn_Getir.TabIndex = 4;
            this.btn_Getir.Text = "Getir";
            this.btn_Getir.UseVisualStyleBackColor = true;
            this.btn_Getir.Click += new System.EventHandler(this.btn_Getir_Click);
            // 
            // Teslimat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 226);
            this.Controls.Add(this.btn_Getir);
            this.Controls.Add(this.btn_TeslimEt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_FisNo);
            this.Controls.Add(this.label1);
            this.Name = "Teslimat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teslimat";
            this.Load += new System.EventHandler(this.Teslimat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_FisNo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_TeslimEt;
        private System.Windows.Forms.Button btn_Getir;
    }
}