using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.CV.CvEnum;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using OpenTK.Graphics.OpenGL;
using static ProcesamientoCorrecto.VideoManipulation;

namespace ProcesamientoCorrecto
{
    public partial class Form4 : Form
    {
        Bitmap newFile;
        Bitmap originalFile;
        VideoCapture videoCapture;
        bool isPlaying = false;
        int activeFilter = -1;
        int totalFrames;
        int currentFrameNumber;
        int fps;
        String fileName;

        Mat currentFrame = new Mat();
        VideoManipulation modifyRGB = new VideoManipulation();



        public string[] ItemObject =
{
            "SOLARIZAR","BLANCO/NEGRO","NEGATIVO","ESPEJO","RELIEVE","GLITCH","PIXEL"
        };

        public Form4()
        {
            InitializeComponent();
            //System.Object[] ItemObject = new System.Object[8];

            modifyRGB.ImageFinished += OnImageFinished;
            comboEfectosImagen.Items.AddRange(ItemObject);

        }



        private void resetMainButton_Click(object sender, EventArgs e)
        {

            FormMenu frm = new FormMenu();

            frm.Show();

            this.Hide();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void playVideo_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                playVideo.BackColor = Color.FromArgb(210, 150, 57);

                isPlaying = false;
            }
            else
            {
                playVideo.BackColor = Color.FromArgb(10, 13, 39);


                if (currentFrameNumber == 0)
                {
                    videoCapture = new VideoCapture(fileName);
                    totalFrames = Convert.ToInt32(videoCapture.Get(Emgu.CV.CvEnum.CapProp.FrameCount));
                    fps = Convert.ToInt32(videoCapture.Get(Emgu.CV.CvEnum.CapProp.Fps));
                    currentFrame = new Mat();
                }
                PlayVideo();
            }
        }

        public string openVideoFile()
        {

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.InitialDirectory = "C:\\Downloads";
            ofd.Filter = "videos| *.mp4; *.mkv; *.mov";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileName = ofd.FileName;
            }

            return fileName;
        }

        private void loadImagePictureForm_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            fileName = openVideoFile();

            if (fileName != null)
            {
                videoCapture = new VideoCapture(fileName);
                totalFrames = Convert.ToInt32(videoCapture.Get(Emgu.CV.CvEnum.CapProp.FrameCount));
                fps = Convert.ToInt32(videoCapture.Get(Emgu.CV.CvEnum.CapProp.Fps));
                currentFrame = new Mat();
                currentFrameNumber = 0;
                comboEfectosImagen.Enabled = true;
                reestablecerVideo.Enabled = true;
                playVideo.BackColor = Color.FromArgb(210, 150, 57);

                PlayVideo();
            }
            if (fileName != null)
            {

                comboEfectosImagen.Enabled = true;
                reestablecerVideo.Enabled = true;
            }
        }

        private async void PlayVideo()
        {
            if (videoCapture != null)
            {
                isPlaying = true;
                playVideo.Enabled = true;
                try
                {
                    playVideo.BackColor = Color.FromArgb(210, 150, 57);


                    while (isPlaying && currentFrameNumber < totalFrames)
                    {



                        videoCapture.Read(currentFrame);

                        newFile = currentFrame.ToBitmap();

                        originalFile = new Bitmap(newFile);

                        mostrarImagen(originalFile, 1);
                        mostrarImagen(newFile, 2);

                        modifyRGB.getLockBitsHistogram(originalFile, 'r', 1);
                        modifyRGB.getLockBitsHistogram(originalFile, 'b', 1);
                        modifyRGB.getLockBitsHistogram(originalFile, 'g', 1);

                        if (activeFilter >= 0)
                            modifyRGB.ManipulateLockBits(newFile, activeFilter + 1);


                        currentFrameNumber++;

                        await Task.Delay(1000 / fps);

                    }

                    playVideo.BackColor = Color.FromArgb(10, 13, 39);


                    if (currentFrameNumber >= totalFrames)
                    {
                        currentFrameNumber = 0;
                        isPlaying = false;
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void comboEfectosImagen_SelectedIndexChanged(object sender, EventArgs e)
        {
            activeFilter = comboEfectosImagen.SelectedIndex;
        }

        private void reestablecerVideo_Click(object sender, EventArgs e)
        {
            activeFilter = -1;
        }

        void OnImageFinished(object sender, ImageEventArgs e)
        {
            mostrarImagen(e.bmap, 2);
            modifyRGB.getLockBitsHistogram(e.bmap, 'r', 2);
            modifyRGB.getLockBitsHistogram(e.bmap, 'g', 2);
            modifyRGB.getLockBitsHistogram(e.bmap, 'b', 2);
        }

        public void mostrarImagen(Bitmap b, int window)
        {
            if (window == 1)
            {
                pictureBox1.Image = b;
            }
            else if (window == 2)
            {
                newpicture2.Image = b;
            }
            else
            {
                pictureBox1.Image = b;
                newpicture2.Image = b;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e) //NEW PICTURE 2
        {

        }
    }
}
