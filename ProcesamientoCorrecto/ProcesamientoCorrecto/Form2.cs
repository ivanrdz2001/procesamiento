using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace ProcesamientoCorrecto
{
    public partial class FormImage : Form
    {
        private Bitmap original;
        private Bitmap resultante;
        private Bitmap apilado;
        private int[] histograma = new int[256];
        private int[,] conv3x3 = new int [3, 3];
        private int factor;
        private int offset;

        private bool HayDispositivos;
        private FilterInfoCollection MyDispositivos;
        private VideoCaptureDevice MiWebCam = null;

        private string rutaAux;
        private bool hayImagen=true;
        //variables para el double buffer

        private int anchoVentana, altoVentana;

        public FormImage()
        {
         
            InitializeComponent();
            cargarDispositivos();


            System.Object[] ItemObject = new System.Object[7];

            ItemObject[0] = "NEGATIVO";
            ItemObject[1] = "BLANCO/NEGRO";
            ItemObject[2] = "DESENFOQUE";
            ItemObject[3] = "BORDES OSCUROS";
            ItemObject[4] = "SEPIA";
            ItemObject[5] = "ABERRACION CROMATICA";
            ItemObject[6] = "PIXEL";
            
            //26:34
            //TODO: poner el resto de efectos

            comboEfectosImagen.Items.AddRange(ItemObject);

        }


        private void aboutMainForm_Click(object sender, EventArgs e)
        {

        }

        private void Capturado(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            cameraBox.Image = Imagen;
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

        private void comboEfectosImagen_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            int a = 100;

            int r = 0;
            int g = 0;
            int b = 0; 

            if (picImage.Image!=null)
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

                    case "ABERRACION CROMATICA":
                        {
                            a = 15;
                            resultante = new Bitmap(original.Width, original.Height);

                            for (x = 0; x < original.Width; x++)
                            {
                                for(y = 0;y < original.Height; y++)
                                {
                                    g = original.GetPixel(x, y).G;
                                    if (x + a < original.Width)
                                    {
                                        r = original.GetPixel(x + a, y).R;
                                    }
                                    else
                                        r = 0;

                                    if (x - a >= 0)
                                    {
                                        b = original.GetPixel(x - a, y).B;
                                    }
                                    else
                                        b = 0;

                                    resultante.SetPixel(x, y, Color.FromArgb(r, g, b));
                                }

                            }
                            this.Invalidate();
                            break;
                        }

                    case "PIXEL":
                        {
                            int mosaico = 30;
                            int xm = 0;
                            int ym = 0;
                            int rs = 0;
                            int gs = 0;
                            int bs = 0;


                            for (x = 0; x < original.Width - mosaico; x += mosaico)
                            {
                                for (y = 0; y < original.Height - mosaico; y += mosaico)
                                {
                                    rs = 0;
                                    gs = 0;
                                    bs = 0;
                                    for (xm = x; xm < (x + mosaico); xm++)
                                    {
                                        for (ym = y; ym < (y + mosaico); ym++)
                                        {
                                            oColor = original.GetPixel(xm, ym);
                                            rs += oColor.R;
                                            gs += oColor.G;
                                            bs += oColor.B;
                                        }
                                    }
                                    r = rs / (mosaico * mosaico);
                                    g = gs / (mosaico * mosaico);
                                    b = bs / (mosaico * mosaico);
                                    rColor = Color.FromArgb(r, g, b);
                                    // Colocamos el color en resultante
                                    for (xm = x; xm < (x + mosaico); xm++)
                                    {
                                        for (ym = y; ym < (y + mosaico); ym++)
                                        {
                                            resultante.SetPixel(xm, ym, rColor);
                                        }

                                    }
                                }
                            }
                            this.Invalidate();
                            break;
                        }

                }

            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
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
                cameraBox.Image.Save(sfd.FileName);
            }
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void resetMainButton_Click_1(object sender, EventArgs e)
        {
            FormMenu frm = new FormMenu();

            frm.Show();

            this.Hide();
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
            if(picImage.Image != null)
            {
                SaveFileDialog sfd = new SaveFileDialog
                {
                    AddExtension = true,
                    FileName = "foto.jpeg",
                    Filter = "JPEG File ( *.jpg )|*.jpg|Enhanced Metafile (*.emf )|*.emf|Portable Network Graphic ( *.png )|*.png",
                    FilterIndex = 1,
                    Title = "Guardar Imagen",
                };
                sfd.InitialDirectory = @"..\CyberMorph";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    picImage.Image.Save(sfd.FileName);
                }
            }
            else
            {
                MessageBox.Show("Importa una imagen", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                hayImagen = false;
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void activarCamara_Click(object sender, EventArgs e)
        {
            CerrarWebCam();

            int i = camaraWebFoto.SelectedIndex;
            if(i != -1)
            {
                string nombreVide = MyDispositivos[i].MonikerString;
                MiWebCam = new VideoCaptureDevice(nombreVide);
                MiWebCam.NewFrame += new NewFrameEventHandler(Capturado);
                MiWebCam.Start();
            }


        }



        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
