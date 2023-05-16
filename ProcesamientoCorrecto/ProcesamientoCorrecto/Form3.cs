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
using Emgu.CV.CvEnum;
using AForge.Video.DirectShow;
using AForge.Video;

using FaceRecognition;
using System.Windows.Media.Media3D;
using System.Drawing.Imaging;

namespace ProcesamientoCorrecto
{
    public partial class Form3 : Form
    {
        private FilterInfoCollection MyDispositivos;
        private VideoCaptureDevice MiWebCam = null;
        private bool HayDispositivos;
        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");


        public Form3()
        {
            InitializeComponent();

        }
        //FaceRec facerec = new FaceRec();
        private void Capturado(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = Imagen;
        }

        public void cargarDispositivos()
        {
            MyDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (MyDispositivos.Count > 0)
            {
                HayDispositivos = true;
                for (int i = 0; i < MyDispositivos.Count; i++)
                {
                    camaraWebFoto.Items.Add(MyDispositivos[i].Name.ToString());
                }
            }
            else
            {
                HayDispositivos = false;

            }
        }
        public void CerrarWebCam()
        {
            if (MiWebCam != null && MiWebCam.IsRunning)
            {
                MiWebCam.SignalToStop();
                MiWebCam = null;


            }
        }
        private void resetMainButton_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cargarDispositivos();
            MiWebCam = new VideoCaptureDevice();
        }

        private void resetMainButton_Click_1(object sender, EventArgs e)
        {

            FormMenu frm = new FormMenu();

            frm.Show();

            this.Hide();
        }

        private void Menu_Click(object sender, EventArgs e)
        {

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void activateCamara_Click(object sender, EventArgs e)
        {
            CerrarWebCam();

            int i = camaraWebFoto.SelectedIndex;
            if (i != -1)
            {
                string nombreVide = MyDispositivos[i].MonikerString;
                MiWebCam = new VideoCaptureDevice(nombreVide);
                MiWebCam.NewFrame += new NewFrameEventHandler(Capturado);
                MiWebCam.Start();
            }

        }

        private void camaraWebFoto_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CerrarWebCam();

            //int i = camaraWebFoto.SelectedIndex;
            //if (i != -1)
            //{
            //    string nombreVide = MyDispositivos[i].MonikerString;
            //    MiWebCam = new VideoCaptureDevice(nombreVide);
            //    MiWebCam.NewFrame += new NewFrameEventHandler(Capturado);
            //    MiWebCam.Start();
            //}

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Device_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();

            // Convertir bitmap a arreglo de bytes
            Rectangle rect = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
            BitmapData bmpData = bitmap.LockBits(rect, ImageLockMode.ReadOnly, bitmap.PixelFormat);
            IntPtr ptr = bmpData.Scan0;
            int bytes = Math.Abs(bmpData.Stride) * bitmap.Height;
            byte[] rgbValues = new byte[bytes];
            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);
            bitmap.UnlockBits(bmpData);

            // Crear nueva imagen a partir del arreglo de bytes
            Image<Bgr, byte> grayImage = new Image<Bgr, byte>(bitmap.Width, bitmap.Height);
            grayImage.Bytes = rgbValues;

            Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.2, 1);
            foreach (Rectangle rectangle in rectangles)
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    using (Pen pen = new Pen(Color.Red, 1))
                    {
                        graphics.DrawRectangle(pen, rectangle);
                    }
                }
            }
        }

        private void detectarRostros_Click(object sender, EventArgs e)
        {
            CerrarWebCam();

            int i = camaraWebFoto.SelectedIndex;
            if (i != -1)
            {
                MiWebCam = new VideoCaptureDevice(MyDispositivos[camaraWebFoto.SelectedIndex].MonikerString);
                MiWebCam.NewFrame += Device_NewFrame;
                MiWebCam.Start();
            }

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MiWebCam.IsRunning) { 
                MiWebCam.Stop();
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}