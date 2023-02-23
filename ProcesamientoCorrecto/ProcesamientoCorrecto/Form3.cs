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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void resetMainButton_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

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
    }
}
