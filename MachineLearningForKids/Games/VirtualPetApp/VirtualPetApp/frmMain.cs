using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualPetApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void pBox_Dog_Click(object sender, EventArgs e)
        {
            frmDog frmDog = new frmDog();
            frmDog.Show();
            this.Hide();

        }

        private void pBox_Cat_Click(object sender, EventArgs e)
        {
            frmCat frmCat = new frmCat();
            frmCat.Show();
            this.Hide();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
