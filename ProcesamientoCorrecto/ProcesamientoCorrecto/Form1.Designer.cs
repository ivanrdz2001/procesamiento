
namespace ProcesamientoCorrecto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.Salir = new System.Windows.Forms.Button();
            this.aboutMainForm = new System.Windows.Forms.Button();
            this.menuMainForm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.resetMainButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.panelSideMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resetMainButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelSideMenu.Controls.Add(this.Salir);
            this.panelSideMenu.Controls.Add(this.aboutMainForm);
            this.panelSideMenu.Controls.Add(this.menuMainForm);
            this.panelSideMenu.Controls.Add(this.panel1);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(194, 450);
            this.panelSideMenu.TabIndex = 0;
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.PaleVioletRed;
            this.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salir.Font = new System.Drawing.Font("Coolvetica Rg", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Salir.Location = new System.Drawing.Point(0, 383);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(194, 55);
            this.Salir.TabIndex = 1;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // aboutMainForm
            // 
            this.aboutMainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.aboutMainForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutMainForm.Font = new System.Drawing.Font("Coolvetica Rg", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aboutMainForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.aboutMainForm.Location = new System.Drawing.Point(0, 268);
            this.aboutMainForm.Name = "aboutMainForm";
            this.aboutMainForm.Size = new System.Drawing.Size(194, 52);
            this.aboutMainForm.TabIndex = 2;
            this.aboutMainForm.Text = "Acerca de";
            this.aboutMainForm.UseVisualStyleBackColor = false;
            this.aboutMainForm.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuMainForm
            // 
            this.menuMainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.menuMainForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuMainForm.Font = new System.Drawing.Font("Coolvetica Rg", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuMainForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuMainForm.Location = new System.Drawing.Point(0, 154);
            this.menuMainForm.Name = "menuMainForm";
            this.menuMainForm.Size = new System.Drawing.Size(194, 52);
            this.menuMainForm.TabIndex = 1;
            this.menuMainForm.Text = "Inicio";
            this.menuMainForm.UseVisualStyleBackColor = false;
            this.menuMainForm.Click += new System.EventHandler(this.menuMainForm_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.resetMainButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 100);
            this.panel1.TabIndex = 0;
            // 
            // resetMainButton
            // 
            this.resetMainButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resetMainButton.Image = ((System.Drawing.Image)(resources.GetObject("resetMainButton.Image")));
            this.resetMainButton.Location = new System.Drawing.Point(0, 0);
            this.resetMainButton.Name = "resetMainButton";
            this.resetMainButton.Size = new System.Drawing.Size(194, 100);
            this.resetMainButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resetMainButton.TabIndex = 0;
            this.resetMainButton.TabStop = false;
            this.resetMainButton.Click += new System.EventHandler(this.resetMainButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(263, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(499, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Black", 29F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(222, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido a CyberMorph";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(202)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelSideMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelSideMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resetMainButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox resetMainButton;
        private System.Windows.Forms.Button menuMainForm;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button aboutMainForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

