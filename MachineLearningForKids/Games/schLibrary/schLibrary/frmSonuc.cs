using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Collections;

namespace schLibrary
{
    public partial class frmSonuc : DevExpress.XtraEditors.XtraForm
    {
        public frmSonuc()
        {
            InitializeComponent();
        }
       
        private void frmSonuc_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            



            label1.Hide();
            label2.Hide();
           // label3.Hide();
            label3.Visible = false;
            string[] kategoriler = { label1.Text, label2.Text, label3.Text };
            Random rastgeleKategori = new Random();
            int no = rastgeleKategori.Next(0, kategoriler.Length);
           // MessageBox.Show(kategoriler[no]);
            string kategoriNo = kategoriler[no];


            SqlConnection con = new SqlConnection("Data Source=DESKTOP-1DMDCN6;Initial Catalog=dblibrary;Integrated Security=True");
            string sql = "select TOP 1 kitapAd , kitapSayfa, kitapTur, kitapKonu, kitapYayinEvi, kitapYazar, kitapKapak, kitapLike, kitapDislike, kitapKapak from tblKitap where kitapTur=" + "'" + kategoriNo + "'" + "ORDER BY NEWID()";
            
          
            
            SqlDataAdapter da = new SqlDataAdapter(sql, con); // SqlDataAdapter komutuyla sql cümlesini ve cnn bağlantısını kullanarak adp adında bir adapter oluşturuyoruz.
            DataSet ds = new DataSet(); // Verileri içine yerleştirebilmemiz için DataSet komutuyla ds isimli DataSet nesnesi oluşturuyoruz.
            da.Fill(ds); // Fill komutuyla oluşturduğumuz adapterdaki çektiğimiz verileri dataset içine aktarıyoruz.
            dataGridView1.DataSource = ds.Tables[0]; // dataseti gridOgrenci isimli ekrana yerletirdiğimiz gridcontrol içinde görünmesini sağlıyoruz.
            lblKitapAdi.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            lblKitapSayfa.Text= dataGridView1.Rows[0].Cells[1].Value.ToString();
            lblKitapTur.Text= dataGridView1.Rows[0].Cells[2].Value.ToString();
            lblKitapKonu.Text= dataGridView1.Rows[0].Cells[3].Value.ToString();
            lblKitapYayinEvi.Text= dataGridView1.Rows[0].Cells[4].Value.ToString();
            lblKitapYazar.Text= dataGridView1.Rows[0].Cells[5].Value.ToString();

            string kitapLike = dataGridView1.Rows[0].Cells[7].Value.ToString();
            string kitapDislike= dataGridView1.Rows[0].Cells[8].Value.ToString();
            double kitapBegeni = 100 / (Convert.ToDouble(kitapLike) + Convert.ToDouble(kitapDislike))*(Convert.ToDouble(kitapLike));
            lblKitapBegeni.Text = "%"+kitapBegeni.ToString();
            pictureBox1.ImageLocation= dataGridView1.Rows[0].Cells[9].Value.ToString();




        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string[] kategoriler = { label1.Text, label2.Text, label3.Text };
            Random rastgeleKategori = new Random();
            int no = rastgeleKategori.Next(0, kategoriler.Length);
           // MessageBox.Show(kategoriler[no]);
            string kategoriNo = kategoriler[no];


            SqlConnection con = new SqlConnection("Data Source=DESKTOP-1DMDCN6;Initial Catalog=dblibrary;Integrated Security=True");
            string sql = "select TOP 1 kitapAd , kitapSayfa, kitapTur, kitapKonu, kitapYayinEvi, kitapYazar, kitapKapak, kitapLike, kitapDislike, kitapKapak from tblKitap where kitapTur=" + "'" + kategoriNo + "'" + "ORDER BY NEWID()";



            SqlDataAdapter da = new SqlDataAdapter(sql, con); // SqlDataAdapter komutuyla sql cümlesini ve cnn bağlantısını kullanarak adp adında bir adapter oluşturuyoruz.
            DataSet ds = new DataSet(); // Verileri içine yerleştirebilmemiz için DataSet komutuyla ds isimli DataSet nesnesi oluşturuyoruz.
            da.Fill(ds); // Fill komutuyla oluşturduğumuz adapterdaki çektiğimiz verileri dataset içine aktarıyoruz.
            dataGridView1.DataSource = ds.Tables[0]; // dataseti gridOgrenci isimli ekrana yerletirdiğimiz gridcontrol içinde görünmesini sağlıyoruz.
            lblKitapAdi.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            lblKitapSayfa.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            lblKitapTur.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            lblKitapKonu.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
            lblKitapYayinEvi.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
            lblKitapYazar.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
            string kitapID = dataGridView1.Rows[0].Cells[9].Value.ToString();
            string kitapLike = dataGridView1.Rows[0].Cells[7].Value.ToString();
            string kitapDislike = dataGridView1.Rows[0].Cells[8].Value.ToString();
            double kitapBegeni = 100 / (Convert.ToDouble(kitapLike) + Convert.ToDouble(kitapDislike)) * (Convert.ToDouble(kitapLike));
            lblKitapBegeni.Text = "%" + kitapBegeni.ToString();
            pictureBox1.ImageLocation = dataGridView1.Rows[0].Cells[9].Value.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void lblKitapKonu_Click(object sender, EventArgs e)
        {

        }

        private void lblKitapSayfa_Click(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uygulama Kapatılıyor.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmTurSec tursec = new frmTurSec();
            this.Close();
            tursec.Show();
        }
    }
}