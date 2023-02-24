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
    public partial class Manual : Form
    {
        public Manual()
        {
            InitializeComponent();
        }

        private void menuMainForm_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1(); 
            inicio.ShowDialog();
            this.Close();
        }
    }
}
