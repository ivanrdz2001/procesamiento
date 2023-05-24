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
        List<Bitmap> arrayBitmaps;
        //ImageManipulation modifyRGB = new ImageManipulation();
        //FileOperations getFile = new FileOperations();





        public Form4()
        {
            InitializeComponent();
            System.Object[] ItemObject = new System.Object[8];

            ItemObject[0] = "NEGATIVO";
            ItemObject[1] = "BLANCO/NEGRO";
            ItemObject[2] = "DESENFOQUE";
            ItemObject[3] = "BORDES GRISES";
            ItemObject[4] = "SEPIA";
            ItemObject[5] = "ABERRACION CROMATICA";
            ItemObject[6] = "PIXEL";
            ItemObject[7] = "MEXICO EN BREAKING BAD";



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
            if (index == 0)
            {
                playVideo.Text = "Play";
                timer1.Stop();
                index = 1;

            }
            else if (index != 0)
            {
                playVideo.Text = "Pausa";
                timer1.Start();
                index = 0;

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

                        chartHistOriginal.Series["Red"].Points.Clear();
                        chartHistOriginal.Series["Green"].Points.Clear();
                        chartHistOriginal.Series["Blue"].Points.Clear();

                        chartHistEdited.Series["Red"].Points.Clear();
                        chartHistEdited.Series["Green"].Points.Clear();
                        chartHistEdited.Series["Blue"].Points.Clear();

                        videoCapture.Read(currentFrame);

                        newFile = currentFrame.ToBitmap();

                        originalFile = new Bitmap(newFile);

                        DisplayImage(originalFile, 1);
                        DisplayImage(newFile, 2);

                        modifyRGB.getLockBitsHistogram(originalFile, 'r', 1);
                        modifyRGB.getLockBitsHistogram(originalFile, 'b', 1);
                        modifyRGB.getLockBitsHistogram(originalFile, 'g', 1);

                        if (activeFilter >= 0)
                            modifyRGB.ManipulateLockBits(newFile, activeFilter + 1, tbSliderControl.Value);


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
    }
}
