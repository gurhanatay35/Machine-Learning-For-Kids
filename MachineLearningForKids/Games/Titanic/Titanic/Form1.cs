using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Titanic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            int deathratio = 0;
            if (man.Checked==true) {  deathratio+=2;}
            if (woman.Checked == true) { deathratio++; }
            if (age.selectedValue=="18-") { deathratio += 5;}
            if (age.selectedValue == "18-25") { deathratio += 1; }
            if (age.selectedValue == "26-34") { deathratio += 2; }
            if (age.selectedValue == "35-46") { deathratio += 3; }
            if (age.selectedValue == "50+") { deathratio += 5; }
            if (ticketclass.selectedValue=="A") {deathratio--;}
            if (ticketclass.selectedValue == "B") { deathratio++; }
            if (ticketclass.selectedValue == "C") { deathratio+=2; }
            if (ticketclass.selectedValue == "D") { deathratio+=3; }
            if (ticketclass.selectedValue == "E") { deathratio+=4; }

            if (deathratio>5)
            {
                bunifuCustomLabel4.Text = "You Are Dead";
            }
            else
            {
                bunifuCustomLabel4.Text = "You Survived";
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
