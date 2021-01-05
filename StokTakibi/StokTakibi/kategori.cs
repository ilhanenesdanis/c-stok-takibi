using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//ilk kütüphanemizi ekledik

namespace StokTakibi
{
    public partial class kategori : Form
    {
        public kategori()
        {
            InitializeComponent();
        }
        //connection u globalde tanıttık
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-MTEL2T5\SQLEXPRESS;Initial Catalog=StokTakibi;Integrated Security=True");
        //tekrar kayıtların engellenmesi için gerekli kodu yazıyoruz
        bool durum;
        public void kategoriengelle()
        {
            durum = true;
            baglan.Open();
            SqlCommand kmt = new SqlCommand("select * from kategori", baglan);
            SqlDataReader read = kmt.ExecuteReader();
            while (read.Read())
            {
                if (textBox1.Text == read["kategori"].ToString() || textBox1.Text == "")
                {
                    durum = false;
                }
            }
            baglan.Close();
        }
        private void btnkategoriekle_Click(object sender, EventArgs e)
        {
            kategoriengelle();
            if (durum == true)
            {
                baglan.Open();//baglantıyı açtık
                SqlCommand kmt = new SqlCommand("insert into kategori(kategori) values('" + textBox1.Text + "')", baglan);//sql komutumuzu yazdık
                kmt.ExecuteNonQuery();//komutu çalıştırdık
                baglan.Close();//baglantıyı kapattık
               
                MessageBox.Show("kategori eklendi");
            }
            else
            {
                MessageBox.Show("böyle bir kategori var", "uyarı");
            }
            textBox1.Text = "";//textbox içini temizledik

        }
    }
}
