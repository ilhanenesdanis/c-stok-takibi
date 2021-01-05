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
    public partial class frmmüşterilistele : Form
    {
        public frmmüşterilistele()
        {
            InitializeComponent();
        }
        //baglantımızı tanımladık
        //form load olunca datagridwiev de verilerin gösterilmesini sağlıyoruz
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-MTEL2T5\SQLEXPRESS;Initial Catalog=StokTakibi;Integrated Security=True");
        DataSet dataset = new DataSet();
        private void frmmüşterilistele_Load(object sender, EventArgs e)
        {
            kayıtgöster();
        }

        private void kayıtgöster()
        {
            //yeni bir bilgi *****ctrl+r+m ile yazılan kodu metot hale dönüstürebiliriz
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from müsteri", baglan);
            adtr.Fill(dataset,"müsteri");//buraya geçici tablo ve sql deki tabloyu yazıyoruz
            dataGridView1.DataSource = dataset.Tables["müsteri"];
            baglan.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //burda event kısmından buldugumuz datagrid e 2 kez tıklandıgında olması gereken olayı yazıcaz
            //burda tıkladıgımız hücreyi textbox a yazdırcaz
            txttc.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
            txtad.Text = dataGridView1.CurrentRow.Cells["adsoyad"].Value.ToString();
            txttel.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            txtadres.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            txtmail.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();

        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand kmt = new SqlCommand("update müsteri set adsoyad=@adsoyad,telefon=@telefon,adres=@adres,email=@email where tc=@tc", baglan);
            kmt.Parameters.AddWithValue("@tc", txttc.Text);
            kmt.Parameters.AddWithValue("@adsoyad", txtad.Text);
            kmt.Parameters.AddWithValue("@telefon", txttel.Text);
            kmt.Parameters.AddWithValue("@adres", txtadres.Text);
            kmt.Parameters.AddWithValue("@email", txtmail.Text);
            kmt.ExecuteNonQuery();
            baglan.Close();
            dataset.Tables["müsteri"].Clear();
            kayıtgöster();
            MessageBox.Show("Kayıt güncellendi");
            foreach(Control item in this.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand kmt = new SqlCommand("delete from müsteri where tc='" + dataGridView1.CurrentRow.Cells["tc"].Value.ToString() + "'", baglan);
            kmt.ExecuteNonQuery();
            baglan.Close();
            dataset.Tables["müsteri"].Clear();
            kayıtgöster();
            MessageBox.Show("Kayıt silindi");
        }

        private void txttcara_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from müsteri where tc like'%"+txttcara.Text+"%'", baglan);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglan.Close();
        }
    }
}
