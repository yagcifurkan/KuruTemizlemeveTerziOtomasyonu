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
    public partial class CalisanSil : Form
    {
        SqlConnection con;
        List<String> cmbPersonelId = new List<string>();
        public CalisanSil()
        {
            con = new SqlConnection("Server=MONSTER;Database=kurutemizlemeveterzi;Trusted_Connection=True;");
            con.Open();
            InitializeComponent();
        }

        private void CalisanSil_Load(object sender, EventArgs e)
        {
            comboDoldur();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM personel WHERE personel_ad_soyad='" + comboBox1.SelectedItem.ToString() + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı silindi.");
                comboBox1.Text = "";
                comboBox1.Items.Clear();
                comboDoldur();
            }
            catch (Exception)
            {
                MessageBox.Show("Şu an kullandığınız kullanıcıyı silemezsiniz.");
            }
            
        }

        private void comboDoldur()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM personel", con);
            cmd.ExecuteNonQuery();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["personel_ad_soyad"].ToString());
                cmbPersonelId.Add(reader["personel_id"].ToString());
            }
            reader.Close();
        }
    }
}
