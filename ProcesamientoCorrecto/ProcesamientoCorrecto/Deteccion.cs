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

using Emgu.CV;
using Emgu.CV.Structure;

namespace ProcesamientoCorrecto
{
    public partial class Deteccion : Form
    {
        private bool HayDispositivos;
        private FilterInfoCollection MisDispositivos;
        private VideoCaptureDevice MiWebCam = null;

        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml"); // Para reconocer el rostro

        private Bitmap resultante;
        MotionDetector Detector;
        public float NivelDeDeteccion;




        public Deteccion()
        {
            InitializeComponent();
            CargaDispositivos();

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
            }
            else
            {
                HayDispositivos = false;

            }
        }

        private void webcamBox_Click(object sender, EventArgs e)
        {

        }

        private void Deteccion_Load(object sender, EventArgs e)
        {
            Detector = new MotionDetector(new TwoFramesDifferenceDetector(), new MotionBorderHighlighting());
            NivelDeDeteccion = 0;
        }

        private void Capturar(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            webcamBox.Image = Imagen;
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
            MiWebCam.NewFrame += new NewFrameEventHandler(Capturar);
            MiWebCam.Start();
        }
    }
}
