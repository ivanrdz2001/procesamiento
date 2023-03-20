using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcesamientoCorrecto
{
    public partial class FormImage : Form
    {
<<<<<<< Updated upstream

=======
        private string Path = @"D:\Procesamiento\";
        private bool HayDispositivos;
        private FilterInfoCollection MisDispositivos;
        private VideoCaptureDevice MiWebCam;


        private Bitmap original;
        private Bitmap resultante;
        private Bitmap apilado;
        private int[] histograma = new int[256];
        private int[,] conv3x3 = new int [3, 3];


        private string rutaAux;
        //variables para el double buffer


>>>>>>> Stashed changes

        public FormImage()
        {

            //fin del combo box
         
            InitializeComponent();
            CargaDispositivos();


        }

<<<<<<< Updated upstream
        private void aboutMainForm_Click(object sender, EventArgs e)
=======
        private void CargaDispositivos()
>>>>>>> Stashed changes
        {
            MisDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (MisDispositivos.Count > 0)
            {
                HayDispositivos = true;
                for(int i=0;i<MisDispositivos.Count; i++)
                {
                    camaraWebFoto.Items.Add(MisDispositivos[i].Name.ToString());
                }
                camaraWebFoto.Text = MisDispositivos[0].Name.ToString();
            }else
                HayDispositivos=false;
        }

<<<<<<< Updated upstream
        private void resetMainButton_Click(object sender, EventArgs e)
        {
            Reset();
=======
        private void Capture(object sender,NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            webcamBox.Image= Imagen;
>>>>>>> Stashed changes
        }

        private void Reset()
        {
            throw new NotImplementedException();
        }

        private void comboEfectosImagen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if(MiWebCam!=null&&MiWebCam.IsRunning)
            {
                picImage.Image = webcamBox.Image;


                SaveFileDialog sfd = new SaveFileDialog
                {
                    AddExtension = true,
                    FileName = "foto.jpeg",
                    Filter = "JPEG File ( *.jpg )|*.jpg|Enhanced Metafile (*.emf )|*.emf|Portable Network Graphic ( *.png )|*.png",
                    FilterIndex = 1,
                    Title = "Guardar Imagen",
                };
                sfd.InitialDirectory = @"..\CamarApp";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    picImage.Image.Save(sfd.FileName);
                }
            }
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void resetMainButton_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void loadImagePictureForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
<<<<<<< Updated upstream
=======

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void loadImagePictureForm_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                original = (Bitmap)(Bitmap.FromFile(openFileDialog1.FileName));
                rutaAux = openFileDialog1.FileName;
                resultante = original;
                apilado = resultante;
            }

            if(original!= null)
            {

                picImage.Image = resultante;
            }
        }

        private void SaveImage_Click(object sender, EventArgs e)
        {

            int x = 0;
            int y = 0;
            int a = 100;

            int r = 0;
            int g = 0;
            int b = 0;

            Random rnd = new Random();
            int num = rnd.Next();

            if (original!= null)
            {
                resultante = new Bitmap(original.Width, original.Height);
                Color rColor = new Color();
                Color oColor = new Color();

                switch (comboEfectosImagen.Text)
                {
                    case "NEGATIVO":
                        {
                            for (x = 0; x < original.Width; x++)
                            {
                                for (y = 0; y < original.Height; y++)
                                {
                                    oColor = original.GetPixel(x, y);

                                    rColor = Color.FromArgb(255 - oColor.R,
                                        255 - oColor.G, 255 - oColor.B);

                                    resultante.SetPixel(x, y, rColor);
                                }
                            }

                            this.Invalidate();
                            break;
                        }

                }
                picImage.Image = resultante;
            }
            else
            {
                MessageBox.Show("Importe una foto", "Advertencia");
            }


        }





            private void picImage_Click(object sender, EventArgs e)
            {

            }

        private void picImage_Paint(object sender, PaintEventArgs e)
        {
            if (resultante != null)
            {
                picImage.Image = resultante;
            }
        }
        
        private void CerrarWebCam()
        {
            if(MiWebCam!=null&&MiWebCam.IsRunning)
            {
               MiWebCam.SignalToStop();
               MiWebCam=null;
            }
        }

        private void camaraWebFoto_SelectedIndexChanged(object sender, EventArgs e)
        {
            CerrarWebCam();
            int i = camaraWebFoto.SelectedIndex;
            string NombreVideo = MisDispositivos[i].MonikerString;
            MiWebCam=new VideoCaptureDevice(NombreVideo);
            MiWebCam.NewFrame += new NewFrameEventHandler(Capture);
            MiWebCam.Start();
        }

        private void FormImage_FormClosed(object sender, FormClosedEventArgs e)
        {
            CerrarWebCam();

        }

        private void webcamBox_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveResult_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                AddExtension = true,
                FileName = "foto.jpeg",
                Filter = "JPEG File ( *.jpg )|*.jpg|Enhanced Metafile (*.emf )|*.emf|Portable Network Graphic ( *.png )|*.png",
                FilterIndex = 1,
                Title = "Guardar Imagen",
            };
            sfd.InitialDirectory = @"..\CamarApp";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                picImage.Image.Save(sfd.FileName);
            }
        }
>>>>>>> Stashed changes
    }
}
