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
    public partial class AnaSayfa : Form
    {
        private string personelAdSoyad = "";
        private int yonetici_calisan;
        private int personelId;
        Giris grs;

        public AnaSayfa(int personelId, string personelAdSoyad, int yonetici_calisan, Giris _grs)
        {
            this.personelId = personelId;
            this.personelAdSoyad = personelAdSoyad;
            this.yonetici_calisan = yonetici_calisan;
            grs = _grs;
            InitializeComponent();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            if (this.yonetici_calisan == 0)
            {
                yönetimToolStripMenuItem.Enabled = false;
                yönetimToolStripMenuItem.Visible = false;
            }

            SqlConnection con = new SqlConnection("Server=MONSTER;Database=kurutemizlemeveterzi;Trusted_Connection=True;");
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT musteri_ad_soyad, urun_id, ucret, getirme_tarihi, tahmini_teslimat_tarihi, onarim_tamamlanma_tarihi, teslim_tarihi, personel_ad_soyad FROM Urunler, Musteri, Personel WHERE Urunler.musteri_id = Musteri.musteri_id AND Urunler.personel_id = Personel.personel_id AND teslim_tarihi IS NULL ORDER BY tahmini_teslimat_tarihi", con);
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

        private void tümKayıtlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TumKayitlar t = new TumKayitlar();
            t.Show();
        }

        private void yeniÜrünToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniUrun yu = new YeniUrun();
            yu.Show();
        }

        private void yeniŞikayetEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniSikayet ys = new YeniSikayet();
            ys.Show();
        }

        private void yeniOnarımEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniOnarim yo = new YeniOnarim();
            yo.Show();
        }

        private void yeniKayıtEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniKayitEkle yke = new YeniKayitEkle(personelId, personelAdSoyad);  
            yke.Show();
        }

        private void onarımEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnarimEkle oe = new OnarimEkle();
            oe.Show();
        }

        private void btn_Yenile_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=MONSTER;Database=kurutemizlemeveterzi;Trusted_Connection=True;");
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT musteri_ad_soyad, urun_id, ucret, getirme_tarihi, tahmini_teslimat_tarihi, onarim_tamamlanma_tarihi, teslim_tarihi, personel_ad_soyad FROM Urunler, Musteri, Personel WHERE Urunler.musteri_id = Musteri.musteri_id AND Urunler.personel_id = Personel.personel_id AND teslim_tarihi IS NULL ORDER BY tahmini_teslimat_tarihi", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void teslimEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teslimat te = new Teslimat();
            te.Show();
        }

        private void yeniÇalışanEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniCalisanEkle yce = new YeniCalisanEkle();
            yce.Show();
        }

        private void eskiÇalışanıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalisanSil cs = new CalisanSil();
            cs.Show();
        }
    }
}
