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
    public partial class YeniOnarim : Form
    {
        public SqlConnection con;
        public List<String> OnarimValues = new List<string>();
        public YeniOnarim()
        {
            String conString = String.Format("Server=MONSTER;Database=kurutemizlemeveterzi;Trusted_Connection=True;");
            con = new SqlConnection(conString);
            InitializeComponent();
        }

        private void YeniOnarim_Load(object sender, EventArgs e)
        {
            OnarimValues.Clear();
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Onarim_Turleri", con);
                SqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    listView_Onarimlar.Items.Add(read["onarim_turu_aciklama"].ToString() + " - " + read["standart_fiyat"].ToString() + " ₺");
                    OnarimValues.Add(read["onarim_turu_kodu"].ToString());

                }
                read.Close();

                con.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_OnarimAciklama.Text != "" && txt_StandartUcret.Text != "")
                {
                    con.Open();
                    SqlCommand cmdCustomer = new SqlCommand("SELECT COUNT(*) AS cnt FROM Onarim_Turleri WHERE onarim_turu_aciklama='" + txt_OnarimAciklama.Text + "'", con);
                    SqlDataReader readerCustomer = cmdCustomer.ExecuteReader();
                    readerCustomer.Read();
                    int count = int.Parse(readerCustomer["cnt"].ToString());
                    readerCustomer.Close();
                    con.Close();

                    if (count == 0)
                    {
                        con.Open();
                        SqlCommand command = new SqlCommand("INSERT INTO Onarim_Turleri (onarim_turu_aciklama, standart_fiyat) VALUES ('" + txt_OnarimAciklama.Text + "','" + txt_StandartUcret.Text.ToString() + "')", con);

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

            listView_Onarimlar.Clear();
            OnarimValues.Clear();

            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Onarim_Turleri", con);
                SqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    listView_Onarimlar.Items.Add(read["onarim_turu_aciklama"].ToString() + " - " + read["standart_fiyat"].ToString() + " ₺");
                    OnarimValues.Add(read["onarim_turu_kodu"].ToString());

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
                SqlCommand command = new SqlCommand("DELETE FROM Onarim_Turleri WHERE onarim_turu_kodu=" + OnarimValues[listView_Onarimlar.SelectedItems[0].Index].ToString(), con);
                command.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show("Bu ürüne ait kayıt mevcut olduğu için silinemez.");
                con.Close();
            }

            listView_Onarimlar.Clear();
            OnarimValues.Clear();

            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Onarim_Turleri", con);
                SqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    listView_Onarimlar.Items.Add(read["onarim_turu_aciklama"].ToString() + " - " + read["standart_fiyat"].ToString() + " ₺");
                    OnarimValues.Add(read["onarim_turu_kodu"].ToString());

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
