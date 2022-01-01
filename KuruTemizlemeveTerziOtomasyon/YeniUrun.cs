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
    public partial class YeniUrun : Form
    {
        public SqlConnection con;
        public List<String> UrunValues = new List<string>();
        public YeniUrun()
        {
            String conString = String.Format("Server=MONSTER;Database=kurutemizlemeveterzi;Trusted_Connection=True;");
            con = new SqlConnection(conString);
            InitializeComponent();
        }

        private void YeniUrun_Load(object sender, EventArgs e)
        {
            UrunValues.Clear();

            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Urun_Turleri", con);
                SqlDataReader read = command.ExecuteReader();

                while (read.Read())
                {
                    listView_Urunler.Items.Add(read["urun_turu_aciklama"].ToString() + " - " + read["tahmini_sure"].ToString() + " Gün");
                    UrunValues.Add(read["urun_turu_kodu"].ToString());

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
                if (txt_UrunAdi.Text != "" && txt_IslemSuresi.Text != "")
                {
                    con.Open();
                    SqlCommand cmdCustomer = new SqlCommand("SELECT COUNT(*) AS cnt FROM Urun_Turleri WHERE urun_turu_aciklama='" + txt_UrunAdi.Text + "'", con);
                    SqlDataReader readerCustomer = cmdCustomer.ExecuteReader();
                    readerCustomer.Read();
                    int count = int.Parse(readerCustomer["cnt"].ToString());
                    readerCustomer.Close();
                    con.Close();

                    if (count == 0)
                    {
                        con.Open();
                        SqlCommand command = new SqlCommand("INSERT INTO Urun_Turleri (urun_turu_aciklama, tahmini_sure) VALUES ('" + txt_UrunAdi.Text + "','" + txt_IslemSuresi.Text.ToString() + "')", con);

                        command.ExecuteNonQuery();
                        con.Close();
                    }
                    else
                        MessageBox.Show("Böyle bir kayıt mevcut.");

                }
                else
                    MessageBox.Show("Bütün alanları doldurun.");

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            listView_Urunler.Clear();
            UrunValues.Clear();

            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Urun_Turleri", con);
                SqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    listView_Urunler.Items.Add(read["urun_turu_aciklama"].ToString() + " - " + read["tahmini_sure"].ToString() + " Gün");
                    UrunValues.Add(read["urun_turu_kodu"].ToString());

                }
                read.Close();

                con.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Urun_Turleri WHERE urun_turu_kodu=" + UrunValues[listView_Urunler.SelectedItems[0].Index].ToString(), con);
                command.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show("Bu ürüne ait kayıt mevcut olduğu için silinemez.");
                con.Close();
            }

            listView_Urunler.Clear();
            UrunValues.Clear();

            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Urun_Turleri", con);
                SqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    listView_Urunler.Items.Add(read["urun_turu_aciklama"].ToString() + " - " + read["tahmini_sure"].ToString() + " Gün");
                    UrunValues.Add(read["urun_turu_kodu"].ToString());

                }
                read.Close();

                con.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
