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
    public partial class frmmusteriekle : Form
    {
        public frmmusteriekle()
        {
            InitializeComponent();
        }
        //baglantımızı oluşturduk
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-MTEL2T5\SQLEXPRESS;Initial Catalog=StokTakibi;Integrated Security=True"); 
        private void frmmusteriekle_Load(object sender, EventArgs e)
        {

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            //sqlcommanda ile sql e ekleme komutu yazdık
            baglan.Open();
            SqlCommand kmt = new SqlCommand("insert into müsteri(tc,adsoyad,telefon,adres,email) values(@tc,@adsoyad,@telefon,@adres,@email)", baglan);
            kmt.Parameters.AddWithValue("@tc", txttc.Text);
            kmt.Parameters.AddWithValue("@adsoyad", txtad.Text);
            kmt.Parameters.AddWithValue("@telefon", txttel.Text);
            kmt.Parameters.AddWithValue("@adres", txtadres.Text);
            kmt.Parameters.AddWithValue("@email", txtmail.Text);
            kmt.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("müşteri kaydı eklendi");
            //aşagıda textboxları kontrol edip içi dolu ise silmesini sağladık

            foreach(Control item in this.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
    }
}
