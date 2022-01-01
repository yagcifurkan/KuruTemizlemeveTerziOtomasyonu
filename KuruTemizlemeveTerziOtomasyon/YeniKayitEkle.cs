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
    public partial class YeniKayitEkle : Form
    {
        List<String> cmbTurId = new List<string>();
        List<String> cmbSkytId = new List<string>();
        List<String> cmbSkytListId = new List<string>();

        private int personelId;
        private string personelAdSoyad = "";

        SqlConnection con;
        public YeniKayitEkle(int personelId, string personelAdSoyad)
        {
            this.personelId = personelId;
            this.personelAdSoyad = personelAdSoyad;
            con = new SqlConnection("Server=MONSTER;Database=kurutemizlemeveterzi;Trusted_Connection=True;");
            con.Open();
            InitializeComponent();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {        
            SqlCommand cmd;

            String urunId = cmbTurId[cmb_Tur.SelectedIndex];

            SqlCommand command = new SqlCommand("INSERT INTO Urunler (urun_turu_kodu, personel_id, ucret, getirme_tarihi, tahmini_teslimat_tarihi, musteri_id) VALUES (" + urunId + "," + personelId + ",'" +
            txt_Tutar.Text.ToString() + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "', '" + txt_Musteri.Text.ToString() + "')", con);
            command.ExecuteNonQuery();

            SqlCommand cmdUrun= new SqlCommand("SELECT MAX(urun_id) AS urunId FROM Urunler", con);
            SqlDataReader readerUrun = cmdUrun.ExecuteReader();
            readerUrun.Read();
            String urunlerId = readerUrun["urunId"].ToString();
            readerUrun.Close();

            for (int i = 0; i < listView_Sikayet.Items.Count; i++)
            {
                cmd = new SqlCommand("INSERT INTO Sikayetler(sikayet_turu_kodu, musteri_id, urun_id) VALUES ('" + cmbSkytListId[i].ToString() + "','" + txt_Musteri.Text.ToString() + "','" + urunlerId + "')", con);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Kayıt " + urunlerId + " fiş numarasıyla eklendi.");
            listView_Sikayet.Clear();
        }

        private void YeniKayitEkle_Load(object sender, EventArgs e)
        {
            lbl_PersoneAdSoyad.Text = personelAdSoyad;

            SqlCommand cmd = new SqlCommand("SELECT * FROM Urun_Turleri", con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cmb_Tur.Items.Add(reader["urun_turu_aciklama"].ToString());
                cmbTurId.Add(reader["urun_turu_kodu"].ToString());
            }

            reader.Close();

            cmd = new SqlCommand("SELECT * FROM Sikayet_Turleri", con);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cmb_Sikayet.Items.Add(reader["sikayet_turu_aciklama"].ToString());
                cmbSkytId.Add(reader["sikayet_turu_kodu"].ToString());
            }
            reader.Close(); 
           
        }
        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            listView_Sikayet.Items.Add(cmb_Sikayet.Text);
            cmbSkytListId.Add(cmbSkytId[cmb_Sikayet.SelectedIndex]);
        }

        private void txt_Musteri_TextChanged(object sender, EventArgs e)
        { 
            SqlCommand cmdMusteri = new SqlCommand("SELECT * FROM Musteri WHERE musteri_id LIKE '" + txt_Musteri.Text + "'", con);
            SqlDataReader readerMusteri = cmdMusteri.ExecuteReader();
            
            while (readerMusteri.Read())
            {
                txt_AdSoyad.Text = readerMusteri["musteri_ad_soyad"].ToString();
            }

            readerMusteri.Close();
        }

        private void btn_MusteriKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Musteri(musteri_id, musteri_ad_soyad) VALUES ('" + txt_Musteri.Text.ToString() + "','" + txt_AdSoyad.Text.ToString() + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Müşteri sisteme başarıyla kaydedildi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Bu müşteri sistemde kayıtlı.");
            }
            
        }
    }
}


