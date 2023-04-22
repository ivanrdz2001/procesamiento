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
    public partial class Histograma : Form
    {
        private int[] histograma;
        private int mayor;
        public Histograma(int[] pHistograma)
        {
            InitializeComponent();
            this.histograma = pHistograma;
            int n = 0;

            mayor= 0;
            for(n=0;n<256;n++)
            {
                if (histograma[n]>mayor)
                    mayor = histograma[n];
            }

            for(n=0;n<256;n++)
                histograma[n] = (int)((float)histograma[n]/(float)mayor*256.0f);
        }

        private void Histograma_Load(object sender, EventArgs e)
        {

        }

        private void Histograma_Paint(object sender, PaintEventArgs e)
        {
            int n = 20;
            int altura = 0;
            Graphics g = e.Graphics;
            Pen plumaH = new Pen(Color.Black);
            Pen plumaEjes = new Pen(Color.Coral);

            g.DrawLine(plumaEjes, 19, 271, 277, 271);
            g.DrawLine(plumaEjes, 19, 270, 19, 14);

            for (n = 0; n < 256; n++) { g.DrawLine(plumaH, n + 20, 270, n + 20, 270 - histograma[n]); }
        }
    }
}
