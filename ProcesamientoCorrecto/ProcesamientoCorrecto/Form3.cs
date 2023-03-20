using AForge.Video.DirectShow;
using AForge.Video;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Vision.Motion;

namespace ProcesamientoCorrecto
{
    public partial class Form3 : Form
    {
        private bool HayDispositivos;
        private FilterInfoCollection MisDispositivos;
        private VideoCaptureDevice MiWebCam;
        private Bitmap resultante;

        public Form3()
        {

            InitializeComponent();
        }

        MotionDetector Detector;
        public float NivelDeDeteccion;
        private void resetMainButton_Click(object sender, EventArgs e)
        {

        }

        private void CargaDispositivos()
        {
            MisDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (MisDispositivos.Count > 0)
            {
                HayDispositivos = true;
                for (int i = 0; i < MisDispositivos.Count; i++)
                {
                    camaraWebFoto.Items.Add(MisDispositivos[i].Name.ToString());
                }
                camaraWebFoto.Text = MisDispositivos[0].Name.ToString();
            }
            else
                HayDispositivos = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            Detector = new MotionDetector(new TwoFramesDifferenceDetector(), new MotionBorderHighlighting());
            NivelDeDeteccion = 0;

            CargaDispositivos();

        }

        private void Capture(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            webcamBox.Image = Imagen;
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


        private void CerrarWebCam()
        {
            if (MiWebCam != null && MiWebCam.IsRunning)
            {
                MiWebCam.SignalToStop();
                MiWebCam = null;
            }
        }
        private void camaraWebFoto_SelectedIndexChanged(object sender, EventArgs e)
        {
            CerrarWebCam();
            int i = camaraWebFoto.SelectedIndex;
            string NombreVideo = MisDispositivos[i].MonikerString;
            MiWebCam = new VideoCaptureDevice(NombreVideo);
            MiWebCam.NewFrame += new NewFrameEventHandler(Capture);
            MiWebCam.Start();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void test2_Paint(object sender, PaintEventArgs e)
        {
            if (resultante != null)
            {
                webcamBox.Image = resultante;
            }
        }
    }
}
