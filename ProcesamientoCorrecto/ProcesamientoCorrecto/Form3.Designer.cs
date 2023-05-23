
namespace ProcesamientoCorrecto
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.detectPeople = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.detectedUsers = new System.Windows.Forms.Label();
            this.Salir = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resetMainButton = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.camaraWebFoto = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pBVideoPreview = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.detectedFace = new System.Windows.Forms.PictureBox();
            this.nombrePersonTB = new System.Windows.Forms.TextBox();
            this.btnActivarCamara = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resetMainButton)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBVideoPreview)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detectedFace)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.detectPeople);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.Salir);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(0, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 505);
            this.panel1.TabIndex = 5;
            // 
            // detectPeople
            // 
            this.detectPeople.BackColor = System.Drawing.Color.Orange;
            this.detectPeople.Font = new System.Drawing.Font("Montserrat Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.detectPeople.ForeColor = System.Drawing.Color.Transparent;
            this.detectPeople.Location = new System.Drawing.Point(15, 37);
            this.detectPeople.Name = "detectPeople";
            this.detectPeople.Size = new System.Drawing.Size(177, 120);
            this.detectPeople.TabIndex = 19;
            this.detectPeople.Text = "Detectar personas";
            this.detectPeople.UseVisualStyleBackColor = false;
            this.detectPeople.Click += new System.EventHandler(this.detectPeople_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.detectedUsers);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(22, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 86);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personas detectadas";
            // 
            // detectedUsers
            // 
            this.detectedUsers.AutoSize = true;
            this.detectedUsers.Location = new System.Drawing.Point(48, 52);
            this.detectedUsers.Name = "detectedUsers";
            this.detectedUsers.Size = new System.Drawing.Size(0, 22);
            this.detectedUsers.TabIndex = 0;
            this.detectedUsers.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.PaleVioletRed;
            this.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salir.Font = new System.Drawing.Font("Coolvetica Rg", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Salir.Location = new System.Drawing.Point(10, 431);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(194, 55);
            this.Salir.TabIndex = 18;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("Montserrat Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(8, 333);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(170, 94);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Personas en movimiento";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.resetMainButton);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 111);
            this.panel2.TabIndex = 6;
            // 
            // resetMainButton
            // 
            this.resetMainButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resetMainButton.Image = ((System.Drawing.Image)(resources.GetObject("resetMainButton.Image")));
            this.resetMainButton.Location = new System.Drawing.Point(0, 0);
            this.resetMainButton.Name = "resetMainButton";
            this.resetMainButton.Size = new System.Drawing.Size(207, 111);
            this.resetMainButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resetMainButton.TabIndex = 2;
            this.resetMainButton.TabStop = false;
            this.resetMainButton.Click += new System.EventHandler(this.resetMainButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Montserrat Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(479, 442);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(487, 71);
            this.button2.TabIndex = 17;
            this.button2.Text = "Guardar foto";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // camaraWebFoto
            // 
            this.camaraWebFoto.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.camaraWebFoto.Font = new System.Drawing.Font("Montserrat Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.camaraWebFoto.ForeColor = System.Drawing.Color.White;
            this.camaraWebFoto.FormattingEnabled = true;
            this.camaraWebFoto.Location = new System.Drawing.Point(455, 382);
            this.camaraWebFoto.Name = "camaraWebFoto";
            this.camaraWebFoto.Size = new System.Drawing.Size(553, 30);
            this.camaraWebFoto.TabIndex = 15;
            this.camaraWebFoto.Text = "Elige una cámara";
            this.camaraWebFoto.SelectedIndexChanged += new System.EventHandler(this.camaraWebFoto_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.pBVideoPreview);
            this.groupBox2.Font = new System.Drawing.Font("Coolvetica Rg", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(455, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(525, 364);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Imagen";
            // 
            // pBVideoPreview
            // 
            this.pBVideoPreview.Location = new System.Drawing.Point(41, 52);
            this.pBVideoPreview.Name = "pBVideoPreview";
            this.pBVideoPreview.Size = new System.Drawing.Size(456, 277);
            this.pBVideoPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBVideoPreview.TabIndex = 0;
            this.pBVideoPreview.TabStop = false;
            this.pBVideoPreview.Click += new System.EventHandler(this.pBVideoPreview_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.detectedFace);
            this.groupBox4.Font = new System.Drawing.Font("Montserrat Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(1032, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(221, 165);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cara detectada";
            // 
            // detectedFace
            // 
            this.detectedFace.Location = new System.Drawing.Point(0, 26);
            this.detectedFace.Name = "detectedFace";
            this.detectedFace.Size = new System.Drawing.Size(215, 133);
            this.detectedFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.detectedFace.TabIndex = 0;
            this.detectedFace.TabStop = false;
            // 
            // nombrePersonTB
            // 
            this.nombrePersonTB.Location = new System.Drawing.Point(1032, 215);
            this.nombrePersonTB.Name = "nombrePersonTB";
            this.nombrePersonTB.Size = new System.Drawing.Size(221, 23);
            this.nombrePersonTB.TabIndex = 21;
            // 
            // btnActivarCamara
            // 
            this.btnActivarCamara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnActivarCamara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivarCamara.Font = new System.Drawing.Font("Montserrat Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnActivarCamara.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActivarCamara.Location = new System.Drawing.Point(557, 522);
            this.btnActivarCamara.Name = "btnActivarCamara";
            this.btnActivarCamara.Size = new System.Drawing.Size(354, 73);
            this.btnActivarCamara.TabIndex = 23;
            this.btnActivarCamara.Text = "Activar cámara";
            this.btnActivarCamara.UseVisualStyleBackColor = false;
            this.btnActivarCamara.Click += new System.EventHandler(this.btnActivarCamara_Click_1);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(202)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1308, 607);
            this.ControlBox = false;
            this.Controls.Add(this.btnActivarCamara);
            this.Controls.Add(this.nombrePersonTB);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.camaraWebFoto);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resetMainButton)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBVideoPreview)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detectedFace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox resetMainButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox camaraWebFoto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Label detectedUsers;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox detectedFace;
        private System.Windows.Forms.TextBox nombrePersonTB;
        private System.Windows.Forms.Button detectPeople;
        private System.Windows.Forms.Button btnActivarCamara;
        private System.Windows.Forms.PictureBox pBVideoPreview;
    }
}