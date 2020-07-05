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
    public partial class frmDog : Form
    {
        public frmDog()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }

        private void frmDog_Load(object sender, EventArgs e)
        {
            timerNight.Start();
            timerSteak.Start();
            timerWater.Start();
        }
        int nightsayac = 400 , watersayac=300,steaksayac=200, healthValue = 100;
        int level = 0;

        private void pBox_steak_Click(object sender, EventArgs e)
        {
            progBar_steak.EditValue = 100;
            steaksayac = 200;
            if (level != 500)
            {
                level += 1;
                if (level % 5 == 0)
                {
                    progBar_level.EditValue = level;
                }

            }
            txtDogspeak.Text = "Thanks friends for steak !";

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
            txtDogspeak.Text = "Thanks friends for water";

        }

        private void pBox_shower_Click(object sender, EventArgs e)
        {
            //shower
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
            txtDogspeak.Text = "Hııııırrrr";

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

            txtDogspeak.Text = "Lets go";
        }

        private void timerWater_Tick(object sender, EventArgs e)
        {
            watersayac--;
            Kontrol();
        }

        private void timerSteak_Tick(object sender, EventArgs e)
        {
            steaksayac--;
            Kontrol();

        }

        private void Kontrol()
        {

            if (steaksayac == 150)
            {
                progBar_steak.EditValue = 90;
                txtDogspeak.Text = "Please steak hav!";
            }
            if (steaksayac == 100)
            {
                progBar_steak.EditValue = 85;
                txtDogspeak.Text = "Please steak hav!";
            }
            if (steaksayac == 50)
            {
                progBar_steak.EditValue = 50;
                txtDogspeak.Text = "Please steak hav!";
            }
            if (steaksayac == 25)
            {
                progBar_steak.EditValue = 25;
                txtDogspeak.Text = "Please steak hav!";
            }
            if (steaksayac == 0)
            {
                progBar_steak.EditValue = 0;
                healthValue -= 10;
                progBar_health.EditValue = healthValue;
                txtDogspeak.Text = "Please steak hav!";

            }
            //nightsayac
            if (nightsayac == 150)
            {
                progBar_night.EditValue = 80;
                txtDogspeak.Text = "Please sleep Hav hav!";

            }
            if (nightsayac == 100)
            {
                progBar_night.EditValue = 60;
                txtDogspeak.Text = "Please sleep Hav hav!";

            }
            if (nightsayac == 50)
            {
                progBar_night.EditValue = 30;
                txtDogspeak.Text = "Please sleep Hav hav!";

            }
            if (nightsayac == 25)
            {
                progBar_night.EditValue = 25;
                txtDogspeak.Text = "Please sleep Hav hav!";

            }
            if (nightsayac == 0)
            {
                progBar_night.EditValue = 0;
                healthValue -= 10;
                progBar_health.EditValue = healthValue;
                txtDogspeak.Text = "Please sleep Hav hav!";


            }
            //water

            if (watersayac == 150)
            {
                progBar_water.EditValue = 80;
                txtDogspeak.Text = "Please water Hav hav!";

            }
            if (watersayac == 100)
            {
                progBar_water.EditValue = 60;
                txtDogspeak.Text = "Please water Hav hav!";

            }
            if (watersayac == 50)
            {
                progBar_water.EditValue = 30;
                txtDogspeak.Text = "Please water Hav hav!";

            }
            if (watersayac == 25)
            {
                progBar_water.EditValue = 25;
                txtDogspeak.Text = "Please water Hav hav!";

            }
            if (watersayac == 0)
            {
                progBar_water.EditValue = 0;
                healthValue -= 10;
                progBar_health.EditValue = healthValue;
                txtDogspeak.Text = "Please water Hav hav!";

            }







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
            txtDogspeak.Text = "Zzz";
        }

        private void timerNight_Tick(object sender, EventArgs e)
        {
            nightsayac--;
            Kontrol();
        }
    }
}
