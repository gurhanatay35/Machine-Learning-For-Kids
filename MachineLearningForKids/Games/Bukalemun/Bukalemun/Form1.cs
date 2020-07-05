using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bukalemun
{
    public partial class Form1 : Form
    {
        int mov, movX, movY;
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void renkBul(object sender, EventArgs e)
        {
            imageVisible.Visible = false;
            openFileDialog1.Title = "Lütfen Bir Rresim Seçiniz...";
            openFileDialog1.FileName = "Seçim Senin :)";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName == "Seçim Senin :)")
            {
                DialogResult dialog = new DialogResult();
                MessageBoxManager.Yes = "Devam Et";
                MessageBoxManager.No = "Kapat";
                MessageBoxManager.Register();
                dialog = MessageBox.Show("Resim Seçmediniz. Seçmek İstiyor Musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                    openFileDialog1.ShowDialog();
                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {
                imageChange.Image = Image.FromFile(openFileDialog1.FileName);
                try
                {
                    pictureBox2.BackColor = System.Drawing.Color.FromArgb(baskinRengiBul());
                    pictureBox2.Visible = true;
                    lbl_file_name.Text = openFileDialog1.SafeFileName;
                    imageVisible.Location = new Point(imageChange.Location.X+100, imageChange.Location.Y+100);
                }
                catch
                {
                    MessageBox.Show("Saydam renk uygulanamıyor.");
                }

            }
        }

        Dictionary<int, int> renk = new Dictionary<int, int>();
        private int baskinRengiBul()
        {
            renk.Clear();
            Bitmap resim = (Bitmap)imageChange.Image;

            for (int x = 0; x < resim.Width; x++)
            {
                for (int y = 0; y < resim.Height; y++)
                {
                    //Saydam alanlar hesaplanmıyor
                    if (resim.GetPixel(x, y).A != 0)
                    {
                        int pikseldekiRenk = resim.GetPixel(x, y).ToArgb();

                        if (renk.ContainsKey(pikseldekiRenk))
                            renk[pikseldekiRenk]++;
                        else
                            renk.Add(pikseldekiRenk, 1);
                    }
                }
            }
            int baskinRenk = renk.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value).First().Key;
                return baskinRenk;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if(bunifuGradientPanel1.Visible==false)
            {
                bunifuTransition1.ShowSync(bunifuGradientPanel1);
            }
        }
        private void bunifuGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void bunifuGradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void bunifuGradientPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void lbl_full_screen_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
    }
}
