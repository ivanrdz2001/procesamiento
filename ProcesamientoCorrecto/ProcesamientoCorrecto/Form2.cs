using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcesamientoCorrecto
{
    public partial class FormImage : Form
    {
        private Bitmap original;
        private Bitmap resultante;
        private int[] histograma = new int[256];
        private int[,] conv3x3 = new int[3, 3];
        private int factor;
        private int offset;

        //variables para el double buffer

        private int anchoVentana, altoVentana;

        public FormImage()
        {

            //fin del combo box
         
            InitializeComponent();

            resultante = new Bitmap(800, 600);

            anchoVentana = 800;
            altoVentana = 600;

        }

        private void aboutMainForm_Click(object sender, EventArgs e)
        {

        }

        private void resetMainButton_Click(object sender, EventArgs e)
        {
            Reset();
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void loadImagePictureForm_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                original = (Bitmap)(Bitmap.FromFile(openFileDialog1.FileName));
                anchoVentana = original.Width;
                altoVentana = original.Height;

                resultante = original;

                this.Invalidate();
            }
        }

        private void SaveImage_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                resultante.Save(saveFileDialog1.FileName,System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void FormImage_Paint(object sender, PaintEventArgs e)
        {
            if (resultante != null)
            {
                Graphics g = e.Graphics;

                AutoScrollMinSize = new Size(anchoVentana, altoVentana);



                g.DrawImage(resultante, new Rectangle(this.AutoScrollPosition.X, this.AutoScrollPosition.Y + 30, anchoVentana, altoVentana));

                g.Dispose();
            }

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
