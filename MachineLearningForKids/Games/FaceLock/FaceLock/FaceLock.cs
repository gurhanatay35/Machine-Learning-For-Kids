using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceLock
{
    public partial class FaceLock : Form
    {
        int mov, movX, movY;
        Capture capture = new Capture();
        private bool isCaptureInProgress; // if capture is in being captured?
        public FaceLock()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private async void btn_trained_piece_Click(object sender, EventArgs e)
        {
            btn_train_delete.Visible = true;
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    if (!recognition.SaveTrainingData(pictureBox2.Image, txt_face_name.Text))
                    MessageBox.Show("Hata", "Profil alınırken beklenmeyen bir hata oluştu.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Thread.Sleep(100);
                    //lbl_trained_piece.Text = (i + 1) + " adet profil.";
                    lbl_trained_piece.Text = "Eğitiliyor...";
                    if (lbl_trained_piece.Text == "Eğitiliyor...")
                    {
                        btn_train.IconChar = FontAwesome.Sharp.IconChar.Redo;
                    }
                }

                lbl_trained_piece.Text = "Eğitim Tamamlandı.";
                if (lbl_trained_piece.Text == "Eğitim Tamamlandı.")
                {
                    btn_train.IconChar = FontAwesome.Sharp.IconChar.Check;
                }

                recognition = null;
                train = null;

                recognition = new BusinessRecognition("C:\\", "Users\\umt_m\\source\\repos\\FaceLock\\Faces", "face.xml");
                train = new Classifier_Train("C:\\", "Users\\umt_m\\source\\repos\\FaceLock\\Faces", "face.xml");
            });

        }
        BusinessRecognition recognition = new BusinessRecognition("C:\\", "Users\\umt_m\\source\\repos\\FaceLock\\Faces", "face.xml");
        Classifier_Train train = new Classifier_Train("C:\\", "Users\\umt_m\\source\\repos\\FaceLock\\Faces", "face.xml");

        private void btn_train_delete_Click(object sender, EventArgs e)
        {
            txt_face_name.Text = "Adınızı Giriniz...";
            recognition.DeleteTrains();
            lbl_trained_piece.Text = "Eğitilen Yüz Silindi.";
        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            capture.Stop();
            Application.Exit();
        }

        private void bunifuGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void bunifuGradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov==1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }


        private void btn_camera_Click(object sender, EventArgs e)
        {
            btn_trained_piece.Visible = true;
            txt_face_name.Visible = true;
            btn_name.Visible = true;
            if (capture != null)
            {
                if (isCaptureInProgress)
                {   // start capturing if the camera is not being used by any other application 
                    // and change the btnTxt to Start so user can start webcam
                    btn_camera.Text = "Kamerayı Başlat"; //
                    Application.Idle -= DetectOrgansInFace;
                    capture.Pause();
                }
                else
                {
                    // capturing, so by press one more time it will pause/stop so
                    btn_camera.Text = " Kamerayı Durdur";
                    Application.Idle += DetectOrgansInFace;
                }

                isCaptureInProgress = !isCaptureInProgress;
            }
        }

        private void DetectOrgansInFace(object sender, EventArgs arg)
        {
            string name = "";
            pictureBox1.Visible = true;
            capture.Start();
            capture.ImageGrabbed += (a, b) =>
            {
                var image = capture.RetrieveBgrFrame();
                var grayimage = image.Convert<Gray, byte>();
                HaarCascade haaryuz = new HaarCascade("haarcascade_frontalface_alt2.xml");
                MCvAvgComp[][] Yuzler = grayimage.DetectHaarCascade(haaryuz, 1.2, 5, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(15, 15));
                MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_COMPLEX, 0.5, 0.5);
                foreach (MCvAvgComp yuz in Yuzler[0])
                {
                    var sadeyuz = grayimage.Copy(yuz.rect).Convert<Gray, byte>().Resize(100, 100, INTER.CV_INTER_CUBIC);
                    //Resimler aynı boyutta olmalıdır. O yüzden Resize ile yeniden boyutlandırma yapılmıştır. Aksi taktirde Classifier_Train sınıfının 245. satırında hata alınacaktır.
                    pictureBox2.Image = sadeyuz.ToBitmap();
                    if (train != null)
                    {
                        if (train.IsTrained)
                        {
                            name = train.Recognise(sadeyuz);
                            int match_value = (int)train.Get_Eigen_Distance;
                            image.Draw(name + " ", ref font, new Point(yuz.rect.X - 2, yuz.rect.Y - 2), new Bgr(Color.LightGreen));
                        }
                    }

                    image.Draw(yuz.rect, new Bgr(Color.Red), 2);
                    if (train != null)
                    {
                        if (train.IsTrained)
                        {
                            DialogResult dialog = new DialogResult();
                            dialog = MessageBox.Show("Telefon Açıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (dialog == DialogResult.OK)
                            {
                                Phone phone = new Phone();
                                phone.Show();
                                capture.Pause();
                            }
                        }
                    }
                }
                pictureBox1.Image = image.ToBitmap();
            };
        }

        private void bunifuGradientPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void txt_face_name_Click(object sender, EventArgs e)
        {
            txt_face_name.Text = "";
        }
    }
}
