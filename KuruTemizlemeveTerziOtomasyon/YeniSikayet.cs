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
    public partial class YeniSikayet : Form
    {
        public SqlConnection con;
        public List<String> SikayetValues = new List<string>();
        public YeniSikayet()
        {
            String conString = String.Format("Server=MONSTER;Database=kurutemizlemeveterzi;Trusted_Connection=True;");
            con = new SqlConnection(conString);
            InitializeComponent();
        }

        private void YeniSikayet_Load(object sender, EventArgs e)
        {
            SikayetValues.Clear();

            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Sikayet_Turleri", con);
                SqlDataReader read = command.ExecuteReader();

                while (read.Read())
                {
                    listView_Sikayetler.Items.Add(read["sikayet_turu_aciklama"].ToString());
                    SikayetValues.Add(read["sikayet_turu_kodu"].ToString());

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
                if (txt_SikayetAciklama.Text != "")
                {
                    con.Open();
                    SqlCommand cmdCustomer = new SqlCommand("SELECT COUNT(*) AS cnt FROM Sikayet_Turleri WHERE sikayet_turu_aciklama='" + txt_SikayetAciklama.Text + "'", con);
                    SqlDataReader readerCustomer = cmdCustomer.ExecuteReader();
                    readerCustomer.Read();
                    int count = int.Parse(readerCustomer["cnt"].ToString());
                    readerCustomer.Close();
                    con.Close();

                    if (count == 0)
                    {
                        con.Open();
                        SqlCommand command = new SqlCommand("INSERT INTO Sikayet_Turleri (sikayet_turu_aciklama) VALUES ('" + txt_SikayetAciklama.Text + "')", con);

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

            listView_Sikayetler.Clear();
            SikayetValues.Clear();

            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Sikayet_Turleri", con);
                SqlDataReader read = command.ExecuteReader();

                while (read.Read())
                {
                    listView_Sikayetler.Items.Add(read["sikayet_turu_aciklama"].ToString());
                    SikayetValues.Add(read["sikayet_turu_kodu"].ToString());

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
                SqlCommand command = new SqlCommand("DELETE FROM Sikayet_Turleri WHERE sikayet_turu_kodu=" + SikayetValues[listView_Sikayetler.SelectedItems[0].Index].ToString(), con);
                command.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show("Bu ürüne ait kayıt mevcut olduğu için silinemez");
                con.Close();
            }

            listView_Sikayetler.Clear();
            SikayetValues.Clear();

            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Sikayet_Turleri", con);
                SqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    listView_Sikayetler.Items.Add(read["sikayet_turu_aciklama"].ToString());
                    SikayetValues.Add(read["sikayet_turu_kodu"].ToString());

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
