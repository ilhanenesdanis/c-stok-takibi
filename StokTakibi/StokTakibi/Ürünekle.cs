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
    public partial class Ürünekle : Form
    {
        public Ürünekle()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-MTEL2T5\SQLEXPRESS;Initial Catalog=StokTakibi;Integrated Security=True");
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        bool durum;
        public void barkodengelle()
        {
            durum = true;
            baglan.Open();
            SqlCommand kmt = new SqlCommand("select * from urunekle", baglan);
            SqlDataReader read = kmt.ExecuteReader();
            while (read.Read())
            {
                if (txtbarkod.Text == read["barkodno"].ToString() ||txtbarkod.Text=="")
                {
                    durum = false;
                }
                
            }
            baglan.Close();
        }
        private void comboekle()
        {
            //veri tabanından sql verilerimizi çektik
            baglan.Open();
            SqlCommand kmt = new SqlCommand("select * from kategori", baglan);
            SqlDataReader read = kmt.ExecuteReader();
            while (read.Read())//verileri sıra ile combobox a yazdırdık
            {
                cmbkategori.Items.Add(read["kategori"].ToString());
            }

            baglan.Close();
        }

        private void Ürünekle_Load(object sender, EventArgs e)
        {
            //form load kısmına metot halinde ekledim
            comboekle();
            
        }

        private void marka()
        {
            baglan.Open();
            SqlCommand kmt = new SqlCommand("select * from marka where kategori='"+cmbkategori.Text+"'", baglan);//seçilen kategoriye gore marka gelmesi için 
            SqlDataReader read = kmt.ExecuteReader();
            while (read.Read())
            {
                cmbmarka.Items.Add(read["marka"].ToString());
            }

            baglan.Close();
        }

        private void cmbkategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbmarka.Items.Clear();//seçilen kategoriye göre marka gelmesi için cmbkategori içine ekledik
            cmbmarka.Text = "";
            marka();
        }

        private void btnyeniekle_Click(object sender, EventArgs e)
        {
            barkodengelle();
            if (durum == true)
            {
                baglan.Open();
            SqlCommand kmt = new SqlCommand("insert into urunekle(barkodno,kategori,marka,urunadı,miktar,alışfiyatı,satışfiyatı,tarih)values(@barkodno,@kategori,@marka,@urunadı,@miktar,@alışfiyatı,@satışfiyatı,@tarih)", baglan);
            kmt.Parameters.AddWithValue("@barkodno", txtbarkod.Text);
            kmt.Parameters.AddWithValue("@kategori", cmbkategori.Text);
            kmt.Parameters.AddWithValue("@marka", cmbmarka.Text);
            kmt.Parameters.AddWithValue("@urunadı", txtürünadı.Text);
            kmt.Parameters.AddWithValue("@miktar",int.Parse(txtmiktar.Text));//bunlar int ve double türünde oldugu için onları tanımladık
            kmt.Parameters.AddWithValue("@alışfiyatı",double.Parse( txtalış.Text));
            kmt.Parameters.AddWithValue("@satışfiyatı", double.Parse(txtsatış.Text));
            kmt.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());//tarih kısmına bugünün tariini verdik
            kmt.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("ürün eklendi");

            }
            else
            {
                MessageBox.Show("boyle bir ürün var", "uyarı");
            }
            
            foreach (Control item in groupBox1.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                    item.Text = "";

            }
        }

        private void txtvarbarkod_TextChanged(object sender, EventArgs e)
        {
            //ürünleri güncellemek için txtvarbarkod adlı olayı açıyoruz

            if (txtvarbarkod.Text == "")//içi dolu ise boşaltıyoruz
            {
                foreach(Control item in groupBox2.Controls)
                {
                    lblmiktar.Text = "";
                    if(item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            baglan.Open();//baglantı açtık
            SqlCommand kmt = new SqlCommand("select * from urunekle where barkodno='"+txtvarbarkod.Text+"'", baglan);//barkod no yu aramak için sql kodumuzu yazdık
            SqlDataReader read = kmt.ExecuteReader();
            while (read.Read())//while döngüsü ile barkod kodun çıktısını yazdırıyoruz
            {
                combovarolankategori.Text = read["kategori"].ToString();
                cmbvarolanmarka.Text = read["marka"].ToString();
                txtvarürün.Text = read["urunadı"].ToString();
                lblmiktar.Text = read["miktar"].ToString();
                txtvaralış.Text = read["alışfiyatı"].ToString();
                txtvarsatış.Text = read["satışfiyatı"].ToString();
                
            }
            baglan.Close();//ve baglantıyı kapatıyoruz
        }

        private void btnvarolan_Click(object sender, EventArgs e)
        {
            baglan.Open();//baglantı açtık
            SqlCommand kmt = new SqlCommand("update urunekle set miktar=miktar+'"+int.Parse(txtvarmiktar.Text)+"'where barkodno='"+txtvarbarkod.Text+"'", baglan);
            //yukarıda güncelleme için kodu yazdık
            kmt.ExecuteNonQuery();
            baglan.Close();
            foreach (Control item in groupBox2.Controls)
            {
                lblmiktar.Text = "";
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                    item.Text = "";
            }//eylem tamamlanınca textbox ve combobox ları kapatıyoruz
            MessageBox.Show("ürün güncellendi");
        }
    }
}
