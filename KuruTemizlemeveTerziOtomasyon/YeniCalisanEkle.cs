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
    public partial class YeniCalisanEkle : Form
    {
        SqlConnection con;
        public YeniCalisanEkle()
        {
            InitializeComponent();
            con = new SqlConnection("Server=MONSTER;Database=kurutemizlemeveterzi;Trusted_Connection=True;");
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_AdSoyad.Text != "" && txt_Sifre.Text != "" && txt_KullaniciAdi.Text != "")
                {
                    con.Open();
                    SqlCommand cmdStaff = new SqlCommand("SELECT COUNT(*) AS personel FROM Personel WHERE kullanici_adi='" + txt_KullaniciAdi.Text + "'", con);
                    SqlDataReader readerStaff = cmdStaff.ExecuteReader();
                    readerStaff.Read();
                    int count = int.Parse(readerStaff["personel"].ToString());
                    readerStaff.Close();
                    con.Close();
                    if (count == 0)
                    {
                        con.Open();
                        SqlCommand command = new SqlCommand("INSERT INTO personel(personel_ad_soyad, kullanici_adi, sifre, yonetici_calisan) VALUES ('" + txt_AdSoyad.Text.ToString() + "','" + txt_KullaniciAdi.Text + "','" + txt_Sifre.Text + "','" + checkBox_Yetki.Checked + "')", con);
                        command.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Yeni çalışan başarıyla eklendi.");
                    }
                    else
                        MessageBox.Show("Girdiğiniz kullanıcı adı daha önce kullanılmış.");

                }
                else
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.");

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
