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
using System.Data.Common;
using System.Collections;

namespace schLibrary
{
    public partial class frmTurSec : DevExpress.XtraEditors.XtraForm
    {
        
        public frmTurSec()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand com;
        DataSet ds;
        SqlDataReader dr;




        void griddoldur()
        {
            
          
            con = new SqlConnection("server=DESKTOP-1DMDCN6; Initial Catalog=dblibrary;Integrated Security=SSPI");
            com = new SqlCommand("Select DISTINCT kitapTur from tblKitap", con);
            con.Open();
            dr = com.ExecuteReader();
            ds = new DataSet();
            
            ArrayList dizi = new ArrayList();
            while (dr.Read())
            {
                dizi.Add(dr["kitapTur"].ToString());
            }
     
            for (int i = 0; i < dizi.Count; i++)
            {
                checkList.Items.Add(dizi[i]);
            }
            con.Close();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmTurSec_Load(object sender, EventArgs e)
        {
            griddoldur();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmSonuc form = new frmSonuc();            
            string ilgiAlanlari = "İlgi Alanlarınız:\n";

            if (checkList.CheckedItems.Count < 1)
            {
                MessageBox.Show("Lütfen listeden eleman seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
          else if (checkList.CheckedItems.Count > 3)
            {
                MessageBox.Show("Lütfen listeden en fazla 3 eleman seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (checkList.CheckedItems.Count<3)
            {
                MessageBox.Show("Lütfen listeden 3 eleman seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           else if (checkList.CheckedItems.Count > 0)
            {
                foreach (string title in checkList.CheckedItems)
                {
                    ilgiAlanlari += "- " + title + "\n";
                    
                }
                MessageBox.Show(ilgiAlanlari);
                form.label1.Text = checkList.CheckedItems[0].ToString();
                form.label2.Text = checkList.CheckedItems[1].ToString();
                form.label3.Text = checkList.CheckedItems[2].ToString();

                form.Show();
                this.Hide();
            }
           
            
           



        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uygulama Kapatılıyor.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}