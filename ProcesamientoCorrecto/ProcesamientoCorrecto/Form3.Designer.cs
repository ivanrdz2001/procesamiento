
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
            panel1 = new System.Windows.Forms.Panel();
            detectPeople = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            detectedUsers = new System.Windows.Forms.Label();
            Salir = new System.Windows.Forms.Button();
            groupBox3 = new System.Windows.Forms.GroupBox();
            panel2 = new System.Windows.Forms.Panel();
            resetMainButton = new System.Windows.Forms.PictureBox();
            button2 = new System.Windows.Forms.Button();
            camaraWebFoto = new System.Windows.Forms.ComboBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            pBVideoPreview = new System.Windows.Forms.PictureBox();
            groupBox4 = new System.Windows.Forms.GroupBox();
            NEWFACE = new System.Windows.Forms.PictureBox();
            nombrePersonTB = new System.Windows.Forms.TextBox();
            btnActivarCamara = new System.Windows.Forms.Button();
            analyzeFace = new System.Windows.Forms.Button();
            NameListCB = new System.Windows.Forms.ComboBox();
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resetMainButton).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBVideoPreview).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NEWFACE).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Gold;
            panel1.Controls.Add(detectPeople);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(Salir);
            panel1.Controls.Add(groupBox3);
            panel1.Location = new System.Drawing.Point(0, 109);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(207, 505);
            panel1.TabIndex = 5;
            // 
            // detectPeople
            // 
            detectPeople.BackColor = System.Drawing.Color.Orange;
            detectPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            detectPeople.ForeColor = System.Drawing.Color.Transparent;
            detectPeople.Location = new System.Drawing.Point(15, 37);
            detectPeople.Name = "detectPeople";
            detectPeople.Size = new System.Drawing.Size(177, 120);
            detectPeople.TabIndex = 19;
            detectPeople.Text = "Añadir personas";
            detectPeople.UseVisualStyleBackColor = false;
            detectPeople.Click += detectPeople_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(detectedUsers);
            groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox1.Location = new System.Drawing.Point(22, 181);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(170, 86);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personas detectadas";
            // 
            // detectedUsers
            // 
            detectedUsers.AutoSize = true;
            detectedUsers.Location = new System.Drawing.Point(48, 52);
            detectedUsers.Name = "detectedUsers";
            detectedUsers.Size = new System.Drawing.Size(0, 20);
            detectedUsers.TabIndex = 0;
            detectedUsers.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Salir
            // 
            Salir.BackColor = System.Drawing.Color.PaleVioletRed;
            Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Salir.Location = new System.Drawing.Point(10, 431);
            Salir.Name = "Salir";
            Salir.Size = new System.Drawing.Size(194, 55);
            Salir.TabIndex = 18;
            Salir.Text = "Salir";
            Salir.UseVisualStyleBackColor = false;
            Salir.Click += Salir_Click;
            // 
            // groupBox3
            // 
            groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox3.Location = new System.Drawing.Point(8, 333);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(170, 94);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Personas en movimiento";
            // 
            // panel2
            // 
            panel2.Controls.Add(resetMainButton);
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(207, 111);
            panel2.TabIndex = 6;
            // 
            // resetMainButton
            // 
            resetMainButton.Dock = System.Windows.Forms.DockStyle.Fill;
            resetMainButton.Image = (System.Drawing.Image)resources.GetObject("resetMainButton.Image");
            resetMainButton.Location = new System.Drawing.Point(0, 0);
            resetMainButton.Name = "resetMainButton";
            resetMainButton.Size = new System.Drawing.Size(207, 111);
            resetMainButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            resetMainButton.TabIndex = 2;
            resetMainButton.TabStop = false;
            resetMainButton.Click += resetMainButton_Click_1;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button2.ForeColor = System.Drawing.Color.White;
            button2.Location = new System.Drawing.Point(1059, 315);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(166, 97);
            button2.TabIndex = 17;
            button2.Text = "Guardar foto";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // camaraWebFoto
            // 
            camaraWebFoto.BackColor = System.Drawing.Color.MediumSlateBlue;
            camaraWebFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            camaraWebFoto.ForeColor = System.Drawing.Color.White;
            camaraWebFoto.FormattingEnabled = true;
            camaraWebFoto.Location = new System.Drawing.Point(455, 382);
            camaraWebFoto.Name = "camaraWebFoto";
            camaraWebFoto.Size = new System.Drawing.Size(553, 28);
            camaraWebFoto.TabIndex = 15;
            camaraWebFoto.Text = "Elige una cámara";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = System.Drawing.Color.Transparent;
            groupBox2.Controls.Add(pBVideoPreview);
            groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox2.Location = new System.Drawing.Point(455, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(525, 364);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Imagen";
            // 
            // pBVideoPreview
            // 
            pBVideoPreview.Location = new System.Drawing.Point(41, 52);
            pBVideoPreview.Name = "pBVideoPreview";
            pBVideoPreview.Size = new System.Drawing.Size(456, 277);
            pBVideoPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pBVideoPreview.TabIndex = 0;
            pBVideoPreview.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = System.Drawing.Color.Transparent;
            groupBox4.Controls.Add(NEWFACE);
            groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox4.Location = new System.Drawing.Point(1032, 25);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(221, 165);
            groupBox4.TabIndex = 20;
            groupBox4.TabStop = false;
            groupBox4.Text = "Cara detectada";
            // 
            // NEWFACE
            // 
            NEWFACE.Location = new System.Drawing.Point(9, 25);
            NEWFACE.Name = "NEWFACE";
            NEWFACE.Size = new System.Drawing.Size(192, 134);
            NEWFACE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            NEWFACE.TabIndex = 0;
            NEWFACE.TabStop = false;
            // 
            // nombrePersonTB
            // 
            nombrePersonTB.Location = new System.Drawing.Point(1032, 215);
            nombrePersonTB.Name = "nombrePersonTB";
            nombrePersonTB.Size = new System.Drawing.Size(221, 23);
            nombrePersonTB.TabIndex = 21;
            // 
            // btnActivarCamara
            // 
            btnActivarCamara.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
            btnActivarCamara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnActivarCamara.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnActivarCamara.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btnActivarCamara.Location = new System.Drawing.Point(559, 427);
            btnActivarCamara.Name = "btnActivarCamara";
            btnActivarCamara.Size = new System.Drawing.Size(354, 73);
            btnActivarCamara.TabIndex = 23;
            btnActivarCamara.Text = "Activar cámara";
            btnActivarCamara.UseVisualStyleBackColor = false;
            btnActivarCamara.Click += btnActivarCamara_Click;
            // 
            // analyzeFace
            // 
            analyzeFace.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
            analyzeFace.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            analyzeFace.ForeColor = System.Drawing.SystemColors.ControlText;
            analyzeFace.Location = new System.Drawing.Point(1059, 438);
            analyzeFace.Name = "analyzeFace";
            analyzeFace.Size = new System.Drawing.Size(166, 62);
            analyzeFace.TabIndex = 24;
            analyzeFace.Text = "Analizar";
            analyzeFace.UseVisualStyleBackColor = false;
            // 
            // NameListCB
            // 
            NameListCB.FormattingEnabled = true;
            NameListCB.Location = new System.Drawing.Point(1032, 260);
            NameListCB.Name = "NameListCB";
            NameListCB.Size = new System.Drawing.Size(221, 23);
            NameListCB.TabIndex = 25;
            NameListCB.SelectedIndexChanged += NameListCB_SelectedIndexChanged_1;
            // 
            // Form3
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(253, 202, 64);
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1308, 607);
            ControlBox = false;
            Controls.Add(NameListCB);
            Controls.Add(analyzeFace);
            Controls.Add(btnActivarCamara);
            Controls.Add(nombrePersonTB);
            Controls.Add(groupBox4);
            Controls.Add(button2);
            Controls.Add(camaraWebFoto);
            Controls.Add(groupBox2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)resetMainButton).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pBVideoPreview).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NEWFACE).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.TextBox nombrePersonTB;
        private System.Windows.Forms.Button detectPeople;
        private System.Windows.Forms.Button btnActivarCamara;
        private System.Windows.Forms.PictureBox pBVideoPreview;
        private System.Windows.Forms.Button analyzeFace;
        private System.Windows.Forms.ComboBox NameListCB;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox NEWFACE;
    }
}