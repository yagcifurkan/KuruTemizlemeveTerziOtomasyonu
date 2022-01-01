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
    public partial class Giris : Form
    {
        string id = "";
        string adsoyad = "";
        string sifre = "";
        SqlConnection con;

        public Giris()
        {
            InitializeComponent();
            con = new SqlConnection("Server=MONSTER;Database=kurutemizlemeveterzi;Trusted_Connection=True;");
            con.Open();
        }

        private void GirisYap(int yonetici)
        {
            SqlCommand cmd;
            try
            {
                if (yonetici == 1)
                {
                    cmd = new SqlCommand("SELECT personel_id, personel_ad_soyad, sifre FROM Personel WHERE yonetici_calisan=1 and kullanici_adi='" + txt_kullaniciadi.Text.ToString() + "'", con);

                }
                else
                {
                    cmd = new SqlCommand("SELECT personel_id, personel_ad_soyad, sifre FROM Personel WHERE yonetici_calisan=0 and kullanici_adi='" + txt_kullaniciadi.Text.ToString() + "'", con);

                }

                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = reader["personel_id"].ToString();
                    adsoyad = reader["personel_ad_soyad"].ToString();
                    sifre = reader["sifre"].ToString();

                }
                reader.Close();

                if (txt_sifre.Text.ToString() == sifre)
                {
                    int _id = int.Parse(id);
                    Form a = new AnaSayfa(_id, adsoyad, yonetici, this);
                    a.Show();

                }

            }
            catch
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
            }
        }

        private void btn_yonetici_Click(object sender, EventArgs e)
        {
            GirisYap(1);
        }

        private void btn_calisan_Click(object sender, EventArgs e)
        {
            GirisYap(0);
        }
    }
}
