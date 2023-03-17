﻿using System;
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
        private Bitmap apilado;
        private int[] histograma = new int[256];
        private int[,] conv3x3 = new int [3, 3];
        private int factor;
        private int offset;

        private string rutaAux;
        //variables para el double buffer

        private int anchoVentana, altoVentana;

        public FormImage()
        {
         
            InitializeComponent();

            System.Object[] ItemObject = new System.Object[8];

            ItemObject[0] = "NEGATIVO";
            ItemObject[1] = "ROJO";
            ItemObject[2] = "VERDE";
            ItemObject[3] = "AZUL";
            ItemObject[4] = "SEPIA";
            ItemObject[5] = "3D";
            ItemObject[6] = "PIXEL";
            ItemObject[7] = "BLANCO/NEGRO";          
            
            //26:34
            //TODO: poner el resto de efectos

            comboEfectosImagen.Items.AddRange(ItemObject);

        }


        private void aboutMainForm_Click(object sender, EventArgs e)
        {

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


            resultante = new Bitmap(original.Width, original.Height);

            Color rColor = new Color();
            Color oColor = new Color();

            switch (comboEfectosImagen.Text)
            {
                case "NEGATIVO" :
                    {
                        for (x = 0; x < original.Width; x++)
                        {
                            for (y = 0; y < original.Height; y++)
                            {
                                oColor=original.GetPixel(x,y);

                                rColor = Color.FromArgb(255-oColor.R,
                                    255-oColor.G, 255-oColor.B);

                                resultante.SetPixel(x,y,rColor);
                            }
                        }  
                        
                        this.Invalidate();
                        break;
                    }
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

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
