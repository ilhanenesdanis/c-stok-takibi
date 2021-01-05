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
    public partial class Marka : Form
    {
        public Marka()
        {
            InitializeComponent();
        }
        //connection u globalde tanıttık
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-MTEL2T5\SQLEXPRESS;Initial Catalog=StokTakibi;Integrated Security=True");
        bool durum;
        public void markaengelle()
        {
            durum = true;
            baglan.Open();
            SqlCommand kmt = new SqlCommand("select * from marka", baglan);
            SqlDataReader read = kmt.ExecuteReader();
            while (read.Read())
            {
                if (comboBox1.Text==read["kategori"].ToString()&&textBox1.Text == read["marka"].ToString() || comboBox1.Text==""||textBox1.Text == "")
                {
                    durum = false;
                }
            }
            baglan.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            markaengelle();
            if (durum == true)
            {
                baglan.Open();
                SqlCommand kmt = new SqlCommand("insert into marka(kategori,marka)values('" + comboBox1.Text + "','" + textBox1.Text + "')", baglan);
                kmt.ExecuteNonQuery();
                baglan.Close();
                
                MessageBox.Show("marka eklendi");
            }
            else
            {
                MessageBox.Show("tekrarlanan marka", "uyarı");
            }
            textBox1.Text = "";
            comboBox1.Text = "";

        }

        private void Marka_Load(object sender, EventArgs e)
        {
            //form açılınca kategorilerin combobox a gelmesini sağlamak için metot yazdık
            comboekle();


        }

        private void comboekle()
        {
            baglan.Open();
            SqlCommand kmt = new SqlCommand("select * from kategori", baglan);
            SqlDataReader read = kmt.ExecuteReader();
            while (read.Read())
            {
                comboBox1.Items.Add(read["kategori"].ToString());
            }

            baglan.Close();
        }
    }
}
