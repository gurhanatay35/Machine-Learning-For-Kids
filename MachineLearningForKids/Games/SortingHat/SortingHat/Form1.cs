using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingHat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            int gryffindor=0, slytherin=0, hufflepuff=0, rawenclaw=0;

            if (quest1.selectedValue == "Owl")
            { gryffindor++; }
            if (quest1.selectedValue == "Cat")
            { hufflepuff++; }
            if (quest1.selectedValue == "Toad")
            { rawenclaw++; }
            if (quest1.selectedValue == "Nothing")
            { slytherin++; }

            if (quest2.selectedValue == "The Elder Wand")
            { gryffindor++; }
            if (quest2.selectedValue == "The Ressurection Stone")
            { hufflepuff++; }
            if (quest2.selectedValue == "The Cloak Of Invisibility")
            { slytherin++; }

            if (quest3.selectedValue == "My ability to absorb new information.")
            { gryffindor++; }
            if (quest3.selectedValue == "My ability to make new friends.")
            { slytherin++; }
            if (quest3.selectedValue == "My ability to get what I want.")
            { rawenclaw++; }
            if (quest3.selectedValue == "My ability to keep secrets..")
            { hufflepuff++; }

            if (quest4.selectedValue == "Weak")
            { gryffindor++; }
            if (quest4.selectedValue == "Ignorant")
            { hufflepuff++; }
            if (quest4.selectedValue == "Unkind")
            { slytherin++; }
            if (quest4.selectedValue == "Boring")
            { rawenclaw++; }

            if (quest5.selectedValue == "Friends")
            { gryffindor++; }
            if (quest5.selectedValue == "Familiy")
            { rawenclaw++; }
            if (quest5.selectedValue == "School")
            { slytherin++; }
            if (quest5.selectedValue == "Power")
            { hufflepuff++; }

            if (gryffindor>rawenclaw &&  gryffindor>slytherin  &&  gryffindor>hufflepuff)
            {
                bunifuCustomLabel6.Text = "You are going to be in Gryfindor";
            }
            if (rawenclaw > gryffindor && rawenclaw > slytherin && rawenclaw > hufflepuff)
            {
                bunifuCustomLabel6.Text = "You are going to be in Rawenclaw";
            } 
            if (slytherin > rawenclaw && slytherin > gryffindor && slytherin > hufflepuff)
            {
                bunifuCustomLabel6.Text = "You are going to be in Slytherin";
            }
            if (hufflepuff > rawenclaw && hufflepuff > slytherin && hufflepuff > gryffindor)
            {
                bunifuCustomLabel6.Text = "You are going to be in Hufflepuff";
            }











        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
