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


namespace Radyator_Kasabasi_Otel
{
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-EELQ0C13\\SQLEXPRESS;Initial Catalog=RadyatorKasabasiOteli;Integrated Security=True");

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from MusteriEkle", baglanti);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from MusteriEkle where Adi like '" + textBox1.Text + "%'", baglanti);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        int id = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            TxtAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TxtSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            MskTxtTelefon.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            TxtMail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            TxtKimlikNo.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            TxtOdaNo.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            TxtUcret.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            DtpGirisTarihi.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            DtpCikisTarihi.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (TxtOdaNo.Text == "101")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Oda101", baglanti);
                komut.Parameters.AddWithValue("@id", id);
                komut.ExecuteNonQuery();
                baglanti.Close();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MusteriEkle", baglanti);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }


            if (TxtOdaNo.Text == "102")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Oda102", baglanti);
                komut.Parameters.AddWithValue("@id", id);
                komut.ExecuteNonQuery();
                baglanti.Close();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MusteriEkle", baglanti);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }


            if (TxtOdaNo.Text == "103")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Oda103", baglanti);
                komut.Parameters.AddWithValue("@id", id);
                komut.ExecuteNonQuery();
                baglanti.Close();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MusteriEkle", baglanti);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }


            if (TxtOdaNo.Text == "104")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Oda104", baglanti);
                komut.Parameters.AddWithValue("@id", id);
                komut.ExecuteNonQuery();
                baglanti.Close();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MusteriEkle", baglanti);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }


            if (TxtOdaNo.Text == "106")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Oda106", baglanti);
                komut.Parameters.AddWithValue("@id", id);
                komut.ExecuteNonQuery();
                baglanti.Close();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MusteriEkle", baglanti);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }


            if (TxtOdaNo.Text == "107")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Oda107", baglanti);
                komut.Parameters.AddWithValue("@id", id);
                komut.ExecuteNonQuery();
                baglanti.Close();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MusteriEkle", baglanti);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }


            if (TxtOdaNo.Text == "108")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Oda108", baglanti);
                komut.Parameters.AddWithValue("@id", id);
                komut.ExecuteNonQuery();
                baglanti.Close();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MusteriEkle", baglanti);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }


            if (TxtOdaNo.Text == "109")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Oda109", baglanti);
                komut.Parameters.AddWithValue("@id", id);
                komut.ExecuteNonQuery();
                baglanti.Close();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MusteriEkle", baglanti);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }

        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAdi.Text = "";
            TxtSoyadi.Text = "";
            comboBox1.Text = "";
            MskTxtTelefon.Text = "";
            TxtMail.Text = "";
            TxtKimlikNo.Text = "";
            TxtOdaNo.Text = "";
            TxtUcret.Text = "";
            DtpGirisTarihi.Text = "";
            DtpCikisTarihi.Text = "";
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE MusteriEkle SET Adi=@Adi, Soyadi=@Soyadi, Cinsiyet=@Cinsiyet, Telefon=@Telefon, Mail=@Mail, TC=@KimlikNo, OdaNo=@OdaNo, Ucret=@Ucret, GirisTarihi=@GirisTarihi, CikisTarihi=@CikisTarihi WHERE Musteriid=@id", baglanti);

                komut.Parameters.AddWithValue("@Adi", TxtAdi.Text);
                komut.Parameters.AddWithValue("@Soyadi", TxtSoyadi.Text);
                komut.Parameters.AddWithValue("@Cinsiyet", comboBox1.Text);
                komut.Parameters.AddWithValue("@Telefon", MskTxtTelefon.Text);
                komut.Parameters.AddWithValue("@Mail", TxtMail.Text);
                komut.Parameters.AddWithValue("@KimlikNo", TxtKimlikNo.Text);
                komut.Parameters.AddWithValue("@OdaNo", TxtOdaNo.Text);
                komut.Parameters.AddWithValue("@Ucret", TxtUcret.Text);
                komut.Parameters.AddWithValue("@GirisTarihi", DtpGirisTarihi.Value);
                komut.Parameters.AddWithValue("@CikisTarihi", DtpCikisTarihi.Value);
                komut.Parameters.AddWithValue("@id", id);

                komut.ExecuteNonQuery();
                baglanti.Close();

                // Güncelleme işlemi tamamlandıktan sonra DataGridView'ı güncelle
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MusteriEkle", baglanti);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme işlemi sırasında bir hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
    }
}
