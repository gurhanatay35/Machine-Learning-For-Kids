using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeMeHappy
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            frmTrain frmTrain = new frmTrain();
            frmTrain.Show();
            this.Hide();

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            frmTest frmTest = new frmTest();
            frmTest.Show();
            this.Hide();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Close();
            frm.Close();
        }
    }
}
