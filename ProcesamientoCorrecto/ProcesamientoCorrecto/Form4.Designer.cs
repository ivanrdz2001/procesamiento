﻿
namespace ProcesamientoCorrecto
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.panel1 = new System.Windows.Forms.Panel();
            this.playVideo = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.loadImagePictureForm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resetMainButton = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboEfectosImagen = new System.Windows.Forms.ComboBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.histogramaOriginal = new System.Windows.Forms.PictureBox();
            this.reestablecerVideo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.histogramaEditado = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resetMainButton)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histogramaOriginal)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histogramaEditado)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.playVideo);
            this.panel1.Controls.Add(this.Salir);
            this.panel1.Controls.Add(this.loadImagePictureForm);
            this.panel1.Location = new System.Drawing.Point(0, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 505);
            this.panel1.TabIndex = 0;
            // 
            // playVideo
            // 
            this.playVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.playVideo.Font = new System.Drawing.Font("Montserrat Black", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playVideo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.playVideo.Location = new System.Drawing.Point(46, 222);
            this.playVideo.Name = "playVideo";
            this.playVideo.Size = new System.Drawing.Size(108, 90);
            this.playVideo.TabIndex = 15;
            this.playVideo.Text = "Play";
            this.playVideo.UseVisualStyleBackColor = false;
            this.playVideo.Click += new System.EventHandler(this.playVideo_Click);
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.PaleVioletRed;
            this.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salir.Font = new System.Drawing.Font("Coolvetica Rg", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Salir.Location = new System.Drawing.Point(10, 365);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(194, 55);
            this.Salir.TabIndex = 14;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // loadImagePictureForm
            // 
            this.loadImagePictureForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.loadImagePictureForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadImagePictureForm.Font = new System.Drawing.Font("Coolvetica Rg", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loadImagePictureForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loadImagePictureForm.Location = new System.Drawing.Point(0, 152);
            this.loadImagePictureForm.Name = "loadImagePictureForm";
            this.loadImagePictureForm.Size = new System.Drawing.Size(207, 52);
            this.loadImagePictureForm.TabIndex = 4;
            this.loadImagePictureForm.Text = "Cargar video";
            this.loadImagePictureForm.UseVisualStyleBackColor = false;
            this.loadImagePictureForm.Click += new System.EventHandler(this.loadImagePictureForm_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.resetMainButton);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 111);
            this.panel2.TabIndex = 1;
            // 
            // resetMainButton
            // 
            this.resetMainButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resetMainButton.Image = ((System.Drawing.Image)(resources.GetObject("resetMainButton.Image")));
            this.resetMainButton.Location = new System.Drawing.Point(0, 0);
            this.resetMainButton.Name = "resetMainButton";
            this.resetMainButton.Size = new System.Drawing.Size(207, 111);
            this.resetMainButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resetMainButton.TabIndex = 3;
            this.resetMainButton.TabStop = false;
            this.resetMainButton.Click += new System.EventHandler(this.resetMainButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Font = new System.Drawing.Font("Coolvetica Rg", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(294, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(525, 364);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Video";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(464, 282);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Montserrat Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(324, 449);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(487, 71);
            this.button2.TabIndex = 13;
            this.button2.Text = "Guardar video";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboEfectosImagen
            // 
            this.comboEfectosImagen.BackColor = System.Drawing.Color.Crimson;
            this.comboEfectosImagen.Font = new System.Drawing.Font("Montserrat Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboEfectosImagen.ForeColor = System.Drawing.Color.White;
            this.comboEfectosImagen.FormattingEnabled = true;
            this.comboEfectosImagen.Location = new System.Drawing.Point(307, 405);
            this.comboEfectosImagen.Name = "comboEfectosImagen";
            this.comboEfectosImagen.Size = new System.Drawing.Size(525, 30);
            this.comboEfectosImagen.TabIndex = 12;
            this.comboEfectosImagen.Text = "Elige un efecto";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.histogramaOriginal);
            this.groupBox1.Location = new System.Drawing.Point(895, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 203);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Histograma original";
            // 
            // histogramaOriginal
            // 
            this.histogramaOriginal.Location = new System.Drawing.Point(15, 25);
            this.histogramaOriginal.Name = "histogramaOriginal";
            this.histogramaOriginal.Size = new System.Drawing.Size(271, 166);
            this.histogramaOriginal.TabIndex = 0;
            this.histogramaOriginal.TabStop = false;
            // 
            // reestablecerVideo
            // 
            this.reestablecerVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.reestablecerVideo.Font = new System.Drawing.Font("Montserrat Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reestablecerVideo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.reestablecerVideo.Location = new System.Drawing.Point(395, 527);
            this.reestablecerVideo.Name = "reestablecerVideo";
            this.reestablecerVideo.Size = new System.Drawing.Size(359, 49);
            this.reestablecerVideo.TabIndex = 15;
            this.reestablecerVideo.Text = "Reestablecer";
            this.reestablecerVideo.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.histogramaEditado);
            this.groupBox3.Location = new System.Drawing.Point(895, 264);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(313, 225);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Histograma editado";
            // 
            // histogramaEditado
            // 
            this.histogramaEditado.Location = new System.Drawing.Point(22, 22);
            this.histogramaEditado.Name = "histogramaEditado";
            this.histogramaEditado.Size = new System.Drawing.Size(264, 188);
            this.histogramaEditado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.histogramaEditado.TabIndex = 0;
            this.histogramaEditado.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(202)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1240, 582);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.reestablecerVideo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.comboEfectosImagen);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resetMainButton)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.histogramaOriginal)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histogramaEditado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox resetMainButton;
        private System.Windows.Forms.Button loadImagePictureForm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboEfectosImagen;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox histogramaEditado;
        private System.Windows.Forms.Button reestablecerVideo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox histogramaOriginal;
        private System.Windows.Forms.Button playVideo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}