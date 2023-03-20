namespace ProcesamientoCorrecto
{
    partial class Deteccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deteccion));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.webcamBox = new System.Windows.Forms.PictureBox();
            this.camaraWebFoto = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webcamBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.webcamBox);
            this.groupBox2.Font = new System.Drawing.Font("Coolvetica Rg", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(371, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(536, 348);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Camara web";
            // 
            // webcamBox
            // 
            this.webcamBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webcamBox.Location = new System.Drawing.Point(3, 26);
            this.webcamBox.Name = "webcamBox";
            this.webcamBox.Size = new System.Drawing.Size(530, 319);
            this.webcamBox.TabIndex = 0;
            this.webcamBox.TabStop = false;
            this.webcamBox.Click += new System.EventHandler(this.webcamBox_Click);
            // 
            // camaraWebFoto
            // 
            this.camaraWebFoto.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.camaraWebFoto.Font = new System.Drawing.Font("Montserrat Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.camaraWebFoto.ForeColor = System.Drawing.Color.White;
            this.camaraWebFoto.FormattingEnabled = true;
            this.camaraWebFoto.Location = new System.Drawing.Point(371, 444);
            this.camaraWebFoto.Name = "camaraWebFoto";
            this.camaraWebFoto.Size = new System.Drawing.Size(525, 30);
            this.camaraWebFoto.TabIndex = 16;
            this.camaraWebFoto.Text = "Elige una cámara";
            // 
            // Deteccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1071, 632);
            this.Controls.Add(this.camaraWebFoto);
            this.Controls.Add(this.groupBox2);
            this.Name = "Deteccion";
            this.Text = "Deteccion";
            this.Load += new System.EventHandler(this.Deteccion_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webcamBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox webcamBox;
        private System.Windows.Forms.ComboBox camaraWebFoto;
    }
}