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
    public partial class frmürünlistele : Form
    {
        public frmürünlistele()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-MTEL2T5\SQLEXPRESS;Initial Catalog=StokTakibi;Integrated Security=True");
        DataSet daset = new DataSet();
        private void frmürünlistele_Load(object sender, EventArgs e)
        {
            dgwgoster();
            comboekle();
            marka();
            
        }

        private void dgwgoster()
        {
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from urunekle", baglan);
            adtr.Fill(daset, "urunekle");
            dataGridView1.DataSource = daset.Tables["urunekle"];
            baglan.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbarkod.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
            txtkategori.Text = dataGridView1.CurrentRow.Cells["kategori"].Value.ToString();
            txtmarka.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            txtürün.Text = dataGridView1.CurrentRow.Cells["urunadı"].Value.ToString();
            txtmiktar.Text = dataGridView1.CurrentRow.Cells["miktar"].Value.ToString();
            txtalış.Text = dataGridView1.CurrentRow.Cells["alışfiyatı"].Value.ToString();
            txtsatış.Text = dataGridView1.CurrentRow.Cells["satışfiyatı"].Value.ToString();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand kmt = new SqlCommand("update urunekle set urunadı=@urunadı,miktar=@miktar,alışfiyatı=@alışfiyatı,satışfiyatı=@satışfiyatı where barkodno=@barkodno", baglan);
            kmt.Parameters.AddWithValue("@barkodno", txtbarkod.Text);
            kmt.Parameters.AddWithValue("@urunadı", txtürün.Text);
            kmt.Parameters.AddWithValue("@miktar", int.Parse(txtmiktar.Text));
            kmt.Parameters.AddWithValue("@alışfiyatı", double.Parse(txtalış.Text));
            kmt.Parameters.AddWithValue("@satışfiyatı", double.Parse(txtsatış.Text));
            kmt.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("güncelleme yapıldı");
            foreach(Control item in this.Controls)
            {
                if (item is TextBox)
                    item.Text = ""; 
                    
            }

        }
       

        private void btnkatgüncelle_Click(object sender, EventArgs e)
        {
            if (txtbarkod.Text != "")
            {
                baglan.Open();
                SqlCommand kmt = new SqlCommand("update urunekle set kategori=@kategori,marka=@marka where barkodno=@barkodno", baglan);
                kmt.Parameters.AddWithValue("@barkodno", txtbarkod.Text);
                kmt.Parameters.AddWithValue("@kategori", comboBox1.Text);
                kmt.Parameters.AddWithValue("@marka", comboBox1.Text);
                kmt.ExecuteNonQuery();
                
                baglan.Close();
                
                
                MessageBox.Show("güncelleme yapıldı");
                daset.Tables["urunekle"].Clear();
                dgwgoster();
                
            }
            else
            {
                MessageBox.Show("barkod no girilmedi");
            }
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                    item.Text = "";
                if (item is ComboBox)
                    item.Text = "";

            }


        }
        private void comboekle()
        {
            //veri tabanından sql verilerimizi çektik
            baglan.Open();
            SqlCommand kmt = new SqlCommand("select * from kategori", baglan);
            SqlDataReader read = kmt.ExecuteReader();
            while (read.Read())//verileri sıra ile combobox a yazdırdık
            {
                comboBox1.Items.Add(read["kategori"].ToString());
            }

            baglan.Close();
        }
        

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            marka();

        }

        private void marka()
        {
            baglan.Open();
            SqlCommand kmt = new SqlCommand("select * from marka where marka='" + comboBox2.Text + "'", baglan);//seçilen kategoriye gore marka gelmesi için 
            SqlDataReader read = kmt.ExecuteReader();
            while (read.Read())
            {
                comboBox2.Items.Add(read["marka"].ToString());
            }

            baglan.Close();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand kmt = new SqlCommand("delete from urunekle where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglan);
            kmt.ExecuteNonQuery();
            baglan.Close();
            daset.Tables["urunekle"].Clear();
            dgwgoster();
            MessageBox.Show("silindi");
        }

        private void txtara_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from urunekle where barkodno like'%" + txtara.Text + "%'",baglan);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglan.Close();
        }
    }
}
