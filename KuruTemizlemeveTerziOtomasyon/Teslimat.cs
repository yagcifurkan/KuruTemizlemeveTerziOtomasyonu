using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuruTemizlemeveTerziOtomasyon
{
    public partial class Teslimat : Form
    {
        SqlConnection con;
        public Teslimat()
        {
            InitializeComponent();
        }

        private void Teslimat_Load(object sender, EventArgs e)
        {
            btn_TeslimEt.Hide();
            con = new SqlConnection("Server=MONSTER;Database=kurutemizlemeveterzi;Trusted_Connection=True;");
            con.Open();
        }

        private void btn_Getir_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT urun_id, musteri_ad_soyad,  urun_turu_aciklama, ucret, getirme_tarihi, tahmini_teslimat_tarihi, onarim_tamamlanma_tarihi, teslim_tarihi FROM Urunler, Musteri, Urun_Turleri WHERE urun_id=" + txt_FisNo.Text.ToString() + " AND Urunler.musteri_id=Musteri.musteri_id AND Urunler.urun_turu_kodu=Urun_Turleri.urun_turu_kodu", con);
            DataSet ds = new DataSet();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.Columns["urun_id"].HeaderText = "Ürün ID";
            dataGridView1.Columns["musteri_ad_soyad"].HeaderText = "Müşteri Ad-Soyad";
            dataGridView1.Columns["urun_turu_aciklama"].HeaderText = "Ürün Tipi";
            dataGridView1.Columns["ucret"].HeaderText = "Tutar";
            dataGridView1.Columns["getirme_tarihi"].HeaderText = "Ürün Giriş Tarihi";
            dataGridView1.Columns["tahmini_teslimat_tarihi"].HeaderText = "Tahmini Teslimat Tarihi";
            dataGridView1.Columns["onarim_tamamlanma_tarihi"].HeaderText = "Onarım Tamamlanma Tarihi";
            dataGridView1.Columns["teslim_tarihi"].HeaderText = "Ürün Teslim Tarihi";

            btn_TeslimEt.Show();
        }

        private void btn_TeslimEt_Click(object sender, EventArgs e)
        {
            if (dataGridView1[7, 0].Value.ToString() == "")
            {
                if (dataGridView1[6, 0].Value.ToString() != "")
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Urunler SET teslim_tarihi='" +
                    DateTime.Now.ToString("yyyy-MM-dd") + "' WHERE urun_id = " + dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString(), con);
                    cmd.ExecuteNonQuery();
                    dataGridView1.Columns.Clear();

                    btn_Getir_Click(this, e);
                    MessageBox.Show("Ürün teslimi tamamlandı.");
                }
                else
                    MessageBox.Show("Ürün henüz hazır değil.");
            }
            else
                MessageBox.Show("Ürün daha önce teslim edilmiş görünüyor. Teslim Tarihi: " + dataGridView1[7, 0].Value.ToString());
        }
    }
}
