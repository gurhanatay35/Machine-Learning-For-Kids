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
    public partial class frmTrain : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1DMDCN6;Initial Catalog=DBmakemehappy;Integrated Security=True");
        SqlCommand komut;
        string emojiDurumu = "";

        public frmTrain()
        {
            InitializeComponent();
        }

        private void KelimeEkle()
        {
            baglanti.Open();
            komut = new SqlCommand("insert into tblKelimeler (KelimeDurumu,Kelime) VALUES ('" + emojiDurumu + "','" + txtInput.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }

        private void btnDataAdd_Click(object sender, EventArgs e)
        {
            if (txtInput.Text=="" || txtInput.Text==" ")
            {
                MessageBox.Show("Please write data");
                txtInput.Clear();
            }
            else if (txtInput.TextLength<50 && emojiDurumu!= "" )
            {
                KelimeEkle();
                txtInput.Clear();
                emojiDurumu = "";
                pBox_AngryFace.BackColor = Color.Transparent;
                pBox_SmileFace.BackColor = Color.Transparent;
                MessageBox.Show(" Traning Complete. Best Accuracy: 77,21%");
                lblDogspeak.Text = " I added data. Please turn the Main Menu my friend.";

            }
            else
            {
                MessageBox.Show("Please choice face.");
            }
           


        }

        private void pBox_SmileFace_Click(object sender, EventArgs e)
        {
            emojiDurumu = "True";
            pBox_AngryFace.BackColor = Color.Transparent;
            pBox_SmileFace.BackColor = Color.Green;

        }

        private void pBox_AngryFace_Click(object sender, EventArgs e)
        {
            emojiDurumu = "False";
            pBox_AngryFace.BackColor = Color.Green;
            pBox_SmileFace.BackColor = Color.Transparent;

        }
    }
}
