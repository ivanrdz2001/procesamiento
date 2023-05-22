using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcesamientoCorrecto
{
    public partial class Form4 : Form
    {
        int index = 0;

        private string ruta = "";

        private int[,] conv3x3 = new int[3, 3];
        private int[,] conv5x5 = new int[5, 5];

        private int factor;
        private int offset;

        private int filterSelection = 0;


        public Form4()
        {
            InitializeComponent();
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
    }
}
