using Emgu.CV;
using Emgu.CV.Structure;
using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing.Imaging;
using Emgu.CV.Face;
using System.Timers;
using System.IO;
using Emgu.CV.CvEnum;
using Emgu.CV.Util;
using ZedGraph;

namespace ProcesamientoCorrecto
{

    public partial class Form3 : Form
    {

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public ComboboxItem(string text, object value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        class DatosFaciales
        {
            public string PersonName { get; set; }
            public Image<Gray, byte> FaceImage { get; set; }
        }

        //VideoCaptureDevice camara;
        FilterInfoCollection filterInfoCollection;

        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_default.xml");

        //Crear una lista para almacenar las caras de cada cuadro
        private bool OpenCamera = true;
        private Image<Gray, Byte> caradetectada = null;
        private List<DatosFaciales> faceList = new List<DatosFaciales>();

        private VectorOfMat imageList = new VectorOfMat();
        private List<string> namesList = new List<string>();
        private VectorOfInt labelList = new VectorOfInt();
        //private EigenFaceRecognizer recognizer;

        public Form3()
        {
            InitializeComponent();
        }

        private void btnActivarCamara_Click(object sender, EventArgs e)
        {
            var camera = new VideoCapture(camaraWebFoto.SelectedIndex);

            if (!camera.IsOpened)
            {
                MessageBox.Show("No hay cámaras disponibles.");
                return;
            }

            var haarCascade = new CascadeClassifier("haarcascade_frontalface_default.xml");

            while (OpenCamera)
            {
                using (var frame = camera.QueryFrame().ToImage<Bgr, Byte>())
                {
                    if (frame == null)
                        break;

                    var grayFrame = frame.Convert<Gray, Byte>();
                    var faces = haarCascade.DetectMultiScale(grayFrame, 1.1, 3, Size.Empty);

                    foreach (var face in faces)
                    {
                        frame.Draw(face, new Bgr(Color.Orange), 2);
                        caradetectada = grayFrame.Copy(face).Convert<Gray, Byte>();
                    }

                    pBVideoPreview.Image = frame.ToBitmap();

                    if (CvInvoke.WaitKey(1) >= 0) // Salir si se presiona una tecla
                        break;

                    int faceCount = faces.Length;
                    detectedUsers.Text = faceCount + "";
                }
            }
            camera.Dispose();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                camaraWebFoto.Items.Add(filterInfo.Name);
            camaraWebFoto.SelectedIndex = 0;
            GetFacesList();

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            OpenCamera = false;
            pBVideoPreview.Image = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pBVideoPreview.Image != null)
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
                    NEWFACE.Image.Save(sfd.FileName);
                }
            }
            else
            {
                MessageBox.Show("No se está mostrando nada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void detectPeople_Click(object sender, EventArgs e)
        {
            string personName = nombrePersonTB.Text;

            if (NEWFACE == null)
            {
                MessageBox.Show("No hay rostros detectados.");
                return;
            }
            if (personName == "")
            {
                MessageBox.Show("Agregue un nombre.");
                return;
            }

            //Guardar rostro detectado
            caradetectada = caradetectada.Resize(100, 100, Inter.Cubic);
            caradetectada.Save("Faces\\" + "face" + (faceList.Count + 1) + ".bmp"); ;

            StreamWriter writer = new StreamWriter("Faces\\FaceList.txt", true);

            writer.WriteLine(String.Format("face{0}:{1}", (faceList.Count + 1), personName));
            writer.Close();

            GetFacesList();

            MessageBox.Show("Agregado.");
        }

        public void GetFacesList()
        {
            faceList.Clear();
            NameListCB.Items.Clear();

            string line;

            // Cree un directorio / archivo vacío para datos faciales si no existe
            if (!Directory.Exists("Faces\\"))
            {
                Directory.CreateDirectory("Faces\\");
            }

            if (!File.Exists("Faces\\FaceList.txt"))
            {
                string text = "No se puede encontrar el archivo de datos faciales:\n\n";
                text += "Faces\\FaceList.txt" + "\n\n";

                MessageBox.Show(text, "Aviso", MessageBoxButtons.OK);

                String dirName = Path.GetDirectoryName("Faces\\FaceList.txt");
                Directory.CreateDirectory(dirName);
                File.Create("Faces\\FaceList.txt").Close();

            }

            StreamReader reader = new StreamReader("Faces\\FaceList.txt");
            DatosFaciales faceInstance = null;

            int i = 0;
            while ((line = reader.ReadLine()) != null)
            {
                string[] lineParts = line.Split(':');
                faceInstance = new DatosFaciales();
                faceInstance.FaceImage = new Image<Gray, Byte>("Faces\\" + lineParts[0] + ".bmp");
                faceInstance.PersonName = lineParts[1];
                faceList.Add(faceInstance);
            }
            foreach (var face in faceList)
            {
                imageList.Push(face.FaceImage.Mat);
                namesList.Add(face.PersonName);
                labelList.Push(new[] { i++ });
                NameListCB.Items.Add(face.PersonName);
                nombrePersonTB.Text = String.Empty;
            }
            reader.Close();

        }


        private void NameListCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentSelection = ((ComboboxItem)NameListCB.SelectedItem).Text;
            string a;
            a = currentSelection;
            foreach (var face in faceList)
            {
                if (face.PersonName == currentSelection)
                {
                    NEWFACE.Image = face.FaceImage.ToBitmap();
                }
            }

        }


        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resetMainButton_Click_1(object sender, EventArgs e)
        {
            OpenCamera = false;
            pBVideoPreview.Image = null;
            FormMenu frm = new FormMenu();

            frm.Show();

            this.Hide();
        }

        private void NameListCB_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string currentSelection = NameListCB.SelectedItem.ToString();

            foreach (var face in faceList)
            {
                if (face.PersonName == currentSelection)
                {
                    NEWFACE.Image = face.FaceImage.ToBitmap();
                }
            }
        }
    }
}