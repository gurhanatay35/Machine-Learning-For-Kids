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
using DevExpress.XtraPrinting.Native;

namespace geziBul
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
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            
            string[] kategoriler = { label2.Text, label3.Text, label4.Text };
            Random rastgeleKategori = new Random();
            int no = rastgeleKategori.Next(0, kategoriler.Length);
            //MessageBox.Show(kategoriler[no]);
            string kategoriNo = kategoriler[no];
            string sql;
           
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-1DMDCN6;Initial Catalog=dbgezi;Integrated Security=True");
            if (label5.Text=="1")
            {
                sql = "select TOP 1 yerAd, ulkeAd, sehir, geziTur, yerHakkinda, resim FROM tblGezi WHERE geziTur=" + "'" + kategoriNo + "'" + "ORDER BY NEWID()";
                SqlDataAdapter da = new SqlDataAdapter(sql, con); // SqlDataAdapter komutuyla sql cümlesini ve cnn bağlantısını kullanarak adp adında bir adapter oluşturuyoruz.
                DataSet ds = new DataSet(); // Verileri içine yerleştirebilmemiz için DataSet komutuyla ds isimli DataSet nesnesi oluşturuyoruz.
                da.Fill(ds); // Fill komutuyla oluşturduğumuz adapterdaki çektiğimiz verileri dataset içine aktarıyoruz.
                dataGridView1.DataSource = ds.Tables[0]; // dataseti gridOgrenci isimli ekrana yerletirdiğimiz gridcontrol içinde görünmesini sağlıyoruz.

            }
            else if (label5.Text=="0")
            {
                sql = "select TOP 1 yerAd, ulkeAd, sehir, geziTur, yerHakkinda, resim from tblGezi where ulkeAd=" + "'" + kategoriNo + "'" + "ORDER BY NEWID()";
                SqlDataAdapter da = new SqlDataAdapter(sql, con); // SqlDataAdapter komutuyla sql cümlesini ve cnn bağlantısını kullanarak adp adında bir adapter oluşturuyoruz.
                DataSet ds = new DataSet(); // Verileri içine yerleştirebilmemiz için DataSet komutuyla ds isimli DataSet nesnesi oluşturuyoruz.
                da.Fill(ds); // Fill komutuyla oluşturduğumuz adapterdaki çektiğimiz verileri dataset içine aktarıyoruz.
                dataGridView1.DataSource = ds.Tables[0]; // dataseti gridOgrenci isimli ekrana yerletirdiğimiz gridcontrol içinde görünmesini sağlıyoruz.

            }
            
            lblYer.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            lblUlke.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            lblSehir.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            lblYerTur.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
            lblYerHakkinda.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.Rows[0].Cells[5].Value.ToString();   



        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            string[] kategoriler = { label2.Text, label3.Text, label4.Text };
            Random rastgeleKategori = new Random();
            int no = rastgeleKategori.Next(0, kategoriler.Length);
            //MessageBox.Show(kategoriler[no]);
            string kategoriNo = kategoriler[no];
            string sql;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-1DMDCN6;Initial Catalog=dbgezi;Integrated Security=True");
            if (label5.Text == "1")
            {
                sql = "select TOP 1 yerAd, ulkeAd, sehir, geziTur, yerHakkinda, resim FROM tblGezi WHERE geziTur=" + "'" + kategoriNo + "'" + "ORDER BY NEWID()";
                SqlDataAdapter da = new SqlDataAdapter(sql, con); // SqlDataAdapter komutuyla sql cümlesini ve cnn bağlantısını kullanarak adp adında bir adapter oluşturuyoruz.
                DataSet ds = new DataSet(); // Verileri içine yerleştirebilmemiz için DataSet komutuyla ds isimli DataSet nesnesi oluşturuyoruz.
                da.Fill(ds); // Fill komutuyla oluşturduğumuz adapterdaki çektiğimiz verileri dataset içine aktarıyoruz.
                dataGridView1.DataSource = ds.Tables[0]; // dataseti gridOgrenci isimli ekrana yerletirdiğimiz gridcontrol içinde görünmesini sağlıyoruz.

            }
            else if (label5.Text == "0")
            {
                sql = "select TOP 1 yerAd, ulkeAd, sehir, geziTur, yerHakkinda, resim from tblGezi where ulkeAd=" + "'" + kategoriNo + "'" + "ORDER BY NEWID()";
                SqlDataAdapter da = new SqlDataAdapter(sql, con); // SqlDataAdapter komutuyla sql cümlesini ve cnn bağlantısını kullanarak adp adında bir adapter oluşturuyoruz.
                DataSet ds = new DataSet(); // Verileri içine yerleştirebilmemiz için DataSet komutuyla ds isimli DataSet nesnesi oluşturuyoruz.
                da.Fill(ds); // Fill komutuyla oluşturduğumuz adapterdaki çektiğimiz verileri dataset içine aktarıyoruz.
                dataGridView1.DataSource = ds.Tables[0]; // dataseti gridOgrenci isimli ekrana yerletirdiğimiz gridcontrol içinde görünmesini sağlıyoruz.

            }

            lblYer.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            lblUlke.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            lblSehir.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            lblYerTur.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
            lblYerHakkinda.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.Rows[0].Cells[5].Value.ToString();

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmSecim frm = new frmSecim();
            frm.Show();
            this.Hide();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}