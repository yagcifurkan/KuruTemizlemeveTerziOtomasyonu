using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KuruTemizlemeveTerziOtomasyon
{
    public partial class TumKayitlar : Form
    {
        public TumKayitlar()
        {
            InitializeComponent();
        }

        private void TumKayitlar_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=MONSTER;Database=kurutemizlemeveterzi;Trusted_Connection=True;");
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT musteri_ad_soyad, urun_id, ucret, getirme_tarihi, tahmini_teslimat_tarihi, onarim_tamamlanma_tarihi, teslim_tarihi, personel_ad_soyad FROM Urunler, Musteri, Personel WHERE Urunler.musteri_id = Musteri.musteri_id AND Urunler.personel_id= Personel.personel_id ORDER BY urun_id", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.Columns["urun_id"].HeaderText = "Ürün ID";
            dataGridView1.Columns["musteri_ad_soyad"].HeaderText = "Müşteri Ad-Soyad";
            dataGridView1.Columns["personel_ad_soyad"].HeaderText = "Personel Ad-Soyad";
            dataGridView1.Columns["ucret"].HeaderText = "Tutar";
            dataGridView1.Columns["getirme_tarihi"].HeaderText = "Ürün Giriş Tarihi";
            dataGridView1.Columns["tahmini_teslimat_tarihi"].HeaderText = "Tahmini Teslimat Tarihi";
            dataGridView1.Columns["onarim_tamamlanma_tarihi"].HeaderText = "Onarım Tamamlanma Tarihi";
            dataGridView1.Columns["teslim_tarihi"].HeaderText = "Ürün Teslim Tarihi";
        }

        private void btn_Yenile_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=MONSTER;Database=kurutemizlemeveterzi;Trusted_Connection=True;");
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT musteri_ad_soyad, urun_id, ucret, getirme_tarihi, tahmini_teslimat_tarihi, onarim_tamamlanma_tarihi, teslim_tarihi, personel_ad_soyad FROM Urunler, Musteri, Personel WHERE Urunler.musteri_id = Musteri.musteri_id AND Urunler.personel_id= Personel.personel_id ORDER BY urun_id", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
        }
    }
}
