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
    public partial class OnarimEkle : Form
    {
        public List<String> UrunValues = new List<string>();
        public List<string> IslemValues = new List<string>();
        public List<string> IslemListValues = new List<string>();

        public SqlConnection con;
        public OnarimEkle()
        {
            InitializeComponent();
        }

        private void OnarimEkle_Load(object sender, EventArgs e)
        {
            String conString = String.Format("Server=MONSTER;Database=kurutemizlemeveterzi;Trusted_Connection=True;");
            con = new SqlConnection(conString);
            try
            {
                con.Open();
                getUrunler(con);
                getIslem(con);
                con.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        void getUrunler(SqlConnection con)
        {
            cmb_Urun.Items.Clear();
            UrunValues.Clear();

            try
            {
                SqlCommand command = new SqlCommand("SELECT urun_id, musteri_ad_soyad, urun_turu_aciklama, onarim_tamamlanma_tarihi FROM Urunler, Urun_Turleri, Musteri WHERE Musteri.musteri_id=Urunler.musteri_id AND Urun_Turleri.urun_turu_kodu = Urunler.urun_turu_kodu AND onarim_tamamlanma_tarihi IS NULL", con);
                SqlDataReader read = command.ExecuteReader();

                while (read.Read())
                {
                    cmb_Urun.Items.Add(read["musteri_ad_soyad"].ToString() + " - " + read["urun_turu_aciklama"].ToString());
                    UrunValues.Add(read["urun_id"].ToString());
                }
                read.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }


        }
        void getIslem(SqlConnection con)
        {
            cmb_Islem.Items.Clear();

            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Onarim_Turleri", con);
                SqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    cmb_Islem.Items.Add(read["onarim_turu_aciklama"].ToString());
                    IslemValues.Add(read["onarim_turu_kodu"].ToString());
                }
                read.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void cmb_Urun_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView_Islemler.Items.Clear();
            listView_Yapılacaklar.Items.Clear();
            IslemListValues.Clear();

            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Onarim_Turleri, Onarimlar WHERE Onarimlar.onarim_turu_kodu=Onarim_Turleri.onarim_turu_kodu AND Onarimlar.urun_id=" + UrunValues[cmb_Urun.SelectedIndex].ToString(), con);
                SqlDataReader read = command.ExecuteReader();
                
                while (read.Read())
                {
                    listView_Islemler.Items.Add(read["onarim_turu_aciklama"].ToString());
                    IslemListValues.Add(read["onarim_id"].ToString());
                }
                read.Close();

                command = new SqlCommand("SELECT * FROM Sikayet_Turleri, Sikayetler, Urunler WHERE Sikayet_Turleri.sikayet_turu_kodu=Sikayetler.sikayet_turu_kodu AND Sikayetler.urun_id=Urunler.urun_id AND Sikayetler.urun_id=" + UrunValues[cmb_Urun.SelectedIndex].ToString(), con);
                read = command.ExecuteReader();
                
                while (read.Read())
                {
                    listView_Yapılacaklar.Items.Add(read["sikayet_turu_aciklama"].ToString());
                    IslemListValues.Add(read["sikayet_id"].ToString());
                }

                read.Close();
                con.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Onarimlar (urun_id, onarim_turu_kodu) VALUES (" + UrunValues[cmb_Urun.SelectedIndex].ToString() + "," + IslemValues[cmb_Islem.SelectedIndex].ToString() + ")", con);
                command.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            listView_Islemler.Items.Clear();
            IslemListValues.Clear();

            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Onarim_Turleri, Onarimlar WHERE Onarimlar.onarim_turu_kodu=Onarim_Turleri.onarim_turu_kodu AND Onarimlar.urun_id=" + UrunValues[cmb_Urun.SelectedIndex].ToString(), con);
                SqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    listView_Islemler.Items.Add(read["onarim_turu_aciklama"].ToString());
                    IslemListValues.Add(read["onarim_id"].ToString());
                }
                read.Close();
                con.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btn_IslemSil_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Onarimlar WHERE onarim_id=" + IslemListValues[listView_Islemler.SelectedItems[0].Index].ToString(), con);
                command.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                con.Close();
            }

            listView_Islemler.Items.Clear();
            IslemListValues.Clear();
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Onarim_Turleri, Onarimlar WHERE Onarimlar.onarim_turu_kodu=Onarim_Turleri.onarim_turu_kodu AND Onarimlar.urun_id=" + UrunValues[cmb_Urun.SelectedIndex].ToString(), con);
                SqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    listView_Islemler.Items.Add(read["onarim_turu_aciklama"].ToString());
                    IslemListValues.Add(read["onarim_id"].ToString());
                }
                read.Close();
                con.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btn_TamiratiBitir_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("UPDATE Urunler SET onarim_tamamlanma_tarihi='" + DateTime.Now.ToString("yyyy-MM-dd") + "' WHERE urun_id=" + UrunValues[cmb_Urun.SelectedIndex].ToString(), con);
                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Tamirat tamamlandı.");

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
