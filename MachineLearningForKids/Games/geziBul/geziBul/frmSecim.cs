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

namespace geziBul
{
    public partial class frmSecim : DevExpress.XtraEditors.XtraForm
    {
        public frmSecim()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand com;
        SqlDataReader dr;
        void griddoldur()
        {

            con = new SqlConnection("server=DESKTOP-1DMDCN6; Initial Catalog=dbgezi;Integrated Security=SSPI");
            com = new SqlCommand("SELECT DISTINCT ulkeAd from tblGezi", con);
            con.Open();
            dr = com.ExecuteReader();

            ArrayList diziUlke = new ArrayList();

            while (dr.Read())
            {
                diziUlke.Add(dr["ulkeAd"].ToString());

            }

            for (int i = 0; i < diziUlke.Count; i++)
            {
                checkedUlke.Items.Add(diziUlke[i]);
            }
            con.Close();
        }

        void doldur2()
        {
            con = new SqlConnection("server=DESKTOP-1DMDCN6; Initial Catalog=dbgezi;Integrated Security=SSPI");
            com = new SqlCommand("SELECT DISTINCT geziTur from tblGezi", con);
            con.Open();
            dr = com.ExecuteReader();

            ArrayList diziUlke = new ArrayList();

            while (dr.Read())
            {
                diziUlke.Add(dr["geziTur"].ToString());

            }



            for (int i = 0; i < diziUlke.Count; i++)
            {
                checkedTur.Items.Add(diziUlke[i]);
            }
            con.Close();
        }

        private void btnUlke_Click(object sender, EventArgs e)
        {
            label2.Text = "0";

            btnUlke.Visible = false;
            btnTur.Visible = false;
            checkedUlke.Visible = true;
            btnNext.Visible = true;
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTur_Click(object sender, EventArgs e)
        {
            label2.Text = "1";
            btnTur.Visible = false;
            btnUlke.Visible = false;
            checkedTur.Visible = true;
            btnNext.Visible = true;
        }

        private void frmSecim_Load(object sender, EventArgs e)
        {
            label2.Hide();
            griddoldur();
            doldur2();
            btnNext.Visible = false;
            checkedUlke.Visible = false;
            checkedTur.Visible = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmSonuc frm = new frmSonuc();
            string ilgiAlanlari = "İlgi Alanlarınız:\n";

            if (label2.Text == "0")
            {
                if (checkedUlke.CheckedItems.Count < 1)
                {
                    MessageBox.Show("Lütfen listeden eleman seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else if (checkedUlke.CheckedItems.Count > 3)
                {
                    MessageBox.Show("Lütfen listeden en fazla 3 eleman seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (checkedUlke.CheckedItems.Count < 3)
                {
                    MessageBox.Show("Lütfen listeden 3 eleman seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (checkedUlke.CheckedItems.Count > 0)
                {
                    foreach (string title in checkedUlke.CheckedItems)
                    {
                        ilgiAlanlari += "- " + title + "\n";

                    }
                    MessageBox.Show(ilgiAlanlari);
                   
                    frm.label2.Text = checkedUlke.CheckedItems[0].ToString();
                    frm.label3.Text = checkedUlke.CheckedItems[1].ToString();
                    frm.label4.Text = checkedUlke.CheckedItems[2].ToString();
                    frm.label5.Text = label2.Text;
                    frm.Show();
                    this.Hide();
                }
            }
            else if (label2.Text == "1")
            {
                if (checkedTur.CheckedItems.Count < 1)
                {
                    MessageBox.Show("Lütfen listeden eleman seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else if (checkedTur.CheckedItems.Count > 3)
                {
                    MessageBox.Show("Lütfen listeden en fazla 3 eleman seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (checkedTur.CheckedItems.Count < 3)
                {
                    MessageBox.Show("Lütfen listeden 3 eleman seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (checkedTur.CheckedItems.Count > 0)
                {
                    foreach (string title in checkedTur.CheckedItems)
                    {
                        ilgiAlanlari += "- " + title + "\n";

                    }
                    MessageBox.Show(ilgiAlanlari);

                    frm.label2.Text = checkedTur.CheckedItems[0].ToString();
                    frm.label3.Text = checkedTur.CheckedItems[1].ToString();
                    frm.label4.Text = checkedTur.CheckedItems[2].ToString();
                    frm.label5.Text = label2.Text;
                    frm.Show();
                    this.Hide();
                }
            }
           
                    
                
            }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
        }

