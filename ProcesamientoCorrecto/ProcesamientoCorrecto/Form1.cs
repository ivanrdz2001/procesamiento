using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcesamientoCorrecto
{
    public partial class Form1 : Form
    {

        private Bitmap resultante;
        private int[] histograma = new int[256];
        private int[,] conv3x3 = new int[3, 3];
        private int factor;


        //Variables para el double buffer y evitar el flicker
        private int anchoVentana, altoVentana;
        private PrivateFontCollection pfc = new PrivateFontCollection();

        public Form1()
        {

            InitializeComponent();


            resultante = new Bitmap(800, 600);

            anchoVentana = 800;
            altoVentana = 600;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Manual frm = new Manual();
            frm.ShowDialog();
        }

        private void resetMainButton_Click(object sender, EventArgs e)
        {
           
        }

        private void Reset()
        {
            
        }

        private void menuMainForm_Click(object sender, EventArgs e)
        {

            FormMenu frm = new FormMenu();

            frm.Show();

            this.Hide();



        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            pfc.Dispose();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
