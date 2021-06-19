
namespace Juego_de_la_Plaga
{
    partial class Acerca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acerca));
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimizarAA = new System.Windows.Forms.PictureBox();
            this.salirAA = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnATR = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salirAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 600);
            this.panel1.TabIndex = 8;
            // 
            // minimizarAA
            // 
            this.minimizarAA.Image = ((System.Drawing.Image)(resources.GetObject("minimizarAA.Image")));
            this.minimizarAA.Location = new System.Drawing.Point(840, 12);
            this.minimizarAA.Name = "minimizarAA";
            this.minimizarAA.Size = new System.Drawing.Size(28, 27);
            this.minimizarAA.TabIndex = 12;
            this.minimizarAA.TabStop = false;
            this.minimizarAA.Click += new System.EventHandler(this.minimizarAA_Click);
            // 
            // salirAA
            // 
            this.salirAA.Image = ((System.Drawing.Image)(resources.GetObject("salirAA.Image")));
            this.salirAA.Location = new System.Drawing.Point(874, 12);
            this.salirAA.Name = "salirAA";
            this.salirAA.Size = new System.Drawing.Size(28, 27);
            this.salirAA.TabIndex = 11;
            this.salirAA.TabStop = false;
            this.salirAA.Click += new System.EventHandler(this.salirAA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(495, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Acerca de los Autores";
            // 
            // btnATR
            // 
            this.btnATR.FlatAppearance.BorderSize = 0;
            this.btnATR.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnATR.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnATR.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnATR.Location = new System.Drawing.Point(762, 557);
            this.btnATR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnATR.Name = "btnATR";
            this.btnATR.Size = new System.Drawing.Size(106, 30);
            this.btnATR.TabIndex = 14;
            this.btnATR.Text = "Atràs";
            this.btnATR.UseVisualStyleBackColor = true;
            this.btnATR.Click += new System.EventHandler(this.btnATR_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(390, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(415, 321);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Acerca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnATR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minimizarAA);
            this.Controls.Add(this.salirAA);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Acerca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AcercaAutores";
            ((System.ComponentModel.ISupportInitialize)(this.minimizarAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salirAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox minimizarAA;
        private System.Windows.Forms.PictureBox salirAA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnATR;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}