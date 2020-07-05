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
    public partial class frmCat : Form
    {
        public frmCat()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }

        private void frmCat_Load(object sender, EventArgs e)
        {
            timerSteak.Start();
            timerNight.Start();
            timerWater.Start();
            //ProgBar_deneme.Properties.Maximum = 100;
            //ProgBar_deneme.Properties.Minimum = 0;

            //ProgBar_deneme.Properties.Step = 1;

        }

        
       
        
        private void Kontrol()
        {
           
            if (steaksayac==150 )
            {
            progBar_steak.EditValue = 90;
                txtCatspeak.Text="Please fish Miav";
            }
            if (steaksayac==100)
            {
                progBar_steak.EditValue = 85;
                txtCatspeak.Text = "Please fish Miav";
            }
            if (steaksayac == 50)
            {
                progBar_steak.EditValue = 50;
                txtCatspeak.Text = "Please fish Miav";
            }
            if (steaksayac == 25)
            {
                progBar_steak.EditValue = 25;
                txtCatspeak.Text = "Please fish Miav";
            }
            if (steaksayac == 0)
            {
                progBar_steak.EditValue = 0;
                healthValue -= 10;
                progBar_health.EditValue = healthValue;
                txtCatspeak.Text = "Please fish Miav";

            }
            //nightsayac
            if (nightsayac==150)
            {
                progBar_night.EditValue = 80;
                txtCatspeak.Text = "Please sleep Miav";

            }
            if (nightsayac == 100)
            {
                progBar_night.EditValue = 60;
                txtCatspeak.Text = "Please sleep Miav";

            }
            if (nightsayac == 50)
            {
                progBar_night.EditValue = 30;
                txtCatspeak.Text = "Please sleep Miav";

            }
            if (nightsayac == 25)
            {
                progBar_night.EditValue = 25;
                txtCatspeak.Text = "Please sleep Miav";

            }
            if (nightsayac == 0)
            {
                progBar_night.EditValue = 0;
                healthValue -= 10;
                progBar_health.EditValue = healthValue;
                txtCatspeak.Text = "Please sleep Miav";


            }
            //water

            if (watersayac == 150)
            {
                progBar_water.EditValue = 80;
                txtCatspeak.Text = "Please water Miav";

            }
            if (watersayac == 100)
            {
                progBar_water.EditValue = 60;
                txtCatspeak.Text = "Please water Miav";

            }
            if (watersayac == 50)
            {
                progBar_water.EditValue = 30;
                txtCatspeak.Text = "Please water Miav";

            }
            if (watersayac == 25)
            {
                progBar_water.EditValue = 25;
                txtCatspeak.Text = "Please water Miav";

            }
            if (watersayac == 0)
            {
                progBar_water.EditValue = 0;
                healthValue -= 10;
                progBar_health.EditValue = healthValue;
                txtCatspeak.Text = "Please water Miav";

            }
            






        }
        int steaksayac = 200;int level = 0;
        private void pBox_steak_Click(object sender, EventArgs e)
        {
            progBar_steak.EditValue = 100;
            steaksayac = 200;
            if (level!=500)
            {
            level += 1;
                if (level%5==0)
                {
                    progBar_level.EditValue = level;
                }
            
            }
            txtCatspeak.Text = "Thanks friends for fish";

        }
        
        private void timerSteak_Tick(object sender, EventArgs e)
        {
            steaksayac--;
            Kontrol();

        }
        int nightsayac = 400;
        private void timerNight_Tick(object sender, EventArgs e)
        {
            nightsayac--;
            Kontrol();
        }

        private void pBox_bed_Click(object sender, EventArgs e)
        {
            progBar_night.EditValue = 100;
            nightsayac = 400;
            if (level != 500)
            {
                level += 1;
                if (level % 5 == 0)
                {
                    progBar_level.EditValue = level;
                }

            }
            txtCatspeak.Text = "Zzz";
        }
        int watersayac = 200;
        private void timerWater_Tick(object sender, EventArgs e)
        {
            watersayac--;
            Kontrol();
        }

        private void pBox_glasswater_Click(object sender, EventArgs e)
        {
            progBar_water.EditValue = 100;
            watersayac = 200;
            if (level != 500)
            {
                level += 1;
                if (level % 5 == 0)
                {
                    progBar_level.EditValue = level;
                }

            }
            txtCatspeak.Text = "Thanks friends for water";

        }
        int healthValue = 100;
        private void pBox_shower_Click(object sender, EventArgs e)
        {
            //shower
            if (healthValue!=100)
            {
              healthValue += 10;
            }
            progBar_health.EditValue = healthValue;
            if (level != 500)
            {
                level += 1;
                if (level % 5 == 0)
                {
                    progBar_level.EditValue = level;
                }

            }
            txtCatspeak.Text = "Hııııırrrr";

        }

        private void pBox_exit_Click(object sender, EventArgs e)
        {
            if (healthValue != 100)
            {
                healthValue += 10;
            }
            progBar_health.EditValue = healthValue;
            if (level != 500)
            {
                level += 1;
                if (level % 5 == 0)
                {
                    progBar_level.EditValue = level;
                }

            }

            txtCatspeak.Text = "Lets go";
        }
    }
}
