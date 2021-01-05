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
namespace StokTakibi
{
    public partial class frmsatıs : Form
    {

        public frmsatıs()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-MTEL2T5\SQLEXPRESS;Initial Catalog=StokTakibi;Integrated Security=True");
        DataSet daset = new DataSet();
        private void btnmüşteriekle_Click(object sender, EventArgs e)
        {
            frmmusteriekle mus = new frmmusteriekle();
            mus.ShowDialog();


        }
        private void sepetlistele()
        {
            baglan.Open();
            SqlDataAdapter astr = new SqlDataAdapter("select * from sepet", baglan);
            astr.Fill(daset, "sepet");
            dgwsatıssayfası.DataSource = daset.Tables["sepet"];
            dgwsatıssayfası.Columns[0].Visible = false;
            dgwsatıssayfası.Columns[1].Visible = false;
            dgwsatıssayfası.Columns[2].Visible = false;
            baglan.Close();


        }

        private void btnmüşterilistele_Click(object sender, EventArgs e)
        {
            frmmüşterilistele frmmüşterilistele = new frmmüşterilistele();
            frmmüşterilistele.ShowDialog();
        }

        private void btnürünekle_Click(object sender, EventArgs e)
        {
            Ürünekle ürünekle = new Ürünekle();
            ürünekle.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kategori kategori = new kategori();
            kategori.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Marka marka = new Marka();
            marka.ShowDialog();
        }

        private void btnürünlistele_Click(object sender, EventArgs e)
        {
            frmürünlistele liste = new frmürünlistele();
            liste.ShowDialog();
        }

        private void frmsatıs_Load(object sender, EventArgs e)
        {
            sepetlistele();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            yenileme();
            baglan.Open();
            SqlCommand kmt = new SqlCommand("select*from urunekle where barkodno like '" + textBox4.Text + "'", baglan);
            SqlDataReader read = kmt.ExecuteReader();
            while (read.Read())
            {
                textBox5.Text = read["urunadı"].ToString();

                textBox7.Text = read["satışfiyatı"].ToString();


            }
            baglan.Close();
        }

        private void yenileme()
        {
            if (textBox4.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != textBox6)
                        {
                            item.Text = "";
                        }

                    }

                }
            }
        }

        private void txttc_TextChanged(object sender, EventArgs e)
        {
            if (txttc.Text == "")
            {
                txtad.Text = "";
                txttelefon.Text = "";
            }
            baglan.Open();
            SqlCommand kmt = new SqlCommand("select * from müsteri where tc like '" + txttc.Text + "'", baglan);
            SqlDataReader read = kmt.ExecuteReader();
            while (read.Read())
            {
                txtad.Text = read["adsoyad"].ToString();
                txttelefon.Text = read["telefon"].ToString();

            }
            baglan.Close();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {

            baglan.Open();
         
            SqlCommand kmt = new SqlCommand("insert into sepet(tc,adsoyad,telefon,barkodno,urunadı,miktar,satışfiyatı,toplamfiyat,tarih) values(@tc,@adsoyad,@telefon,@barkodno,@urunadı,@miktar,@satışfiyatı,@toplamfiyat,@tarih)", baglan);

            kmt.Parameters.AddWithValue("@tc", txttc.Text);
            kmt.Parameters.AddWithValue("@adsoyad", txtad.Text);
            kmt.Parameters.AddWithValue("@telefon", txttelefon.Text);
            kmt.Parameters.AddWithValue("@barkodno", textBox4.Text);
            kmt.Parameters.AddWithValue("@urunadı", textBox5.Text);
            kmt.Parameters.AddWithValue("@miktar", int.Parse(textBox6.Text));
            kmt.Parameters.AddWithValue("@satışfiyatı", double.Parse(textBox7.Text));
            kmt.Parameters.AddWithValue("@toplamfiyat", double.Parse(textBox8.Text));
            kmt.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            kmt.ExecuteNonQuery();
            baglan.Close();
            daset.Tables["sepet"].Clear();

            yenileme();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox8.Text = (double.Parse(textBox6.Text) * double.Parse(textBox7.Text)).ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox8.Text = (double.Parse(textBox6.Text) * double.Parse(textBox7.Text)).ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
