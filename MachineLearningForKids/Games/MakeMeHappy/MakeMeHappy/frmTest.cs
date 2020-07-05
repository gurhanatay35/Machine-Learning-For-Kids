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

namespace MakeMeHappy
{
    public partial class frmTest : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1DMDCN6;Initial Catalog=DBmakemehappy;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader dr;
        string durum;

        public frmTest()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            lblDogspeak.Text = "Good job my friend. Now click button.";
            
        }
        private void KelimeKontrol()
        {
            baglanti.Open();
            komut = new SqlCommand(" SELECT KelimeDurumu FROM tblKelimeler WHERE Kelime=@GirilenKelime",baglanti);
            komut.Parameters.AddWithValue( "@GirilenKelime",txtInput.Text);
            dr = komut.ExecuteReader();
            while(dr.Read()){
                durum = dr["KelimeDurumu"].ToString();

            }
            baglanti.Close();

        }

        private void bntControl_Click(object sender, EventArgs e)
        {
            if (txtInput.Text=="" || txtInput.Text==" ")
            {
                MessageBox.Show("Please write word my friend");
                lblDogspeak.Text = " Please write word my friend then click button";
                pBoxFaces.Image= Properties.Resources.normalemoji;



            }
            else
            {
                KelimeKontrol();

                if (durum == "True")
                {
                    pBoxFaces.Image = Properties.Resources.smile;
                    lblDogspeak.Text = "Look at Right my friend";
                }
                else if (durum == "False")
                {
                    pBoxFaces.Image = Properties.Resources.redfaceemoji;
                    lblDogspeak.Text = "Look at Right my friend";
                }
                else
                {
                    MessageBox.Show("I don't know the word you wrote, Please add it from the train section.");
                }

            }



            

           

            
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            pBoxFaces.Image = Properties.Resources.normalemoji;
        }
    }
}
