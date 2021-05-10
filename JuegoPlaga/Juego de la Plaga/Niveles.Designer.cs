
namespace Juego_de_la_Plaga
{
    partial class Niveles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Niveles));
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.salir = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnATR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFACIL = new System.Windows.Forms.Button();
            this.btnNORMAL = new System.Windows.Forms.Button();
            this.btnDIFICIL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 600);
            this.panel1.TabIndex = 15;
            // 
            // minimizar
            // 
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
            this.minimizar.Location = new System.Drawing.Point(840, 12);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(0, 0);
            this.minimizar.TabIndex = 17;
            this.minimizar.TabStop = false;
            // 
            // salir
            // 
            this.salir.Image = ((System.Drawing.Image)(resources.GetObject("salir.Image")));
            this.salir.Location = new System.Drawing.Point(874, 12);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(0, 0);
            this.salir.TabIndex = 16;
            this.salir.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(840, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 27);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(874, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 27);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnATR
            // 
            this.btnATR.FlatAppearance.BorderSize = 0;
            this.btnATR.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnATR.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnATR.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnATR.Location = new System.Drawing.Point(722, 530);
            this.btnATR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnATR.Name = "btnATR";
            this.btnATR.Size = new System.Drawing.Size(106, 30);
            this.btnATR.TabIndex = 20;
            this.btnATR.Text = "Atràs";
            this.btnATR.UseVisualStyleBackColor = true;
            this.btnATR.Click += new System.EventHandler(this.btnATR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(430, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Niveles";
            // 
            // btnFACIL
            // 
            this.btnFACIL.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFACIL.Location = new System.Drawing.Point(184, 188);
            this.btnFACIL.Name = "btnFACIL";
            this.btnFACIL.Size = new System.Drawing.Size(590, 45);
            this.btnFACIL.TabIndex = 22;
            this.btnFACIL.Text = "F A C I L";
            this.btnFACIL.UseVisualStyleBackColor = true;
            // 
            // btnNORMAL
            // 
            this.btnNORMAL.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNORMAL.Location = new System.Drawing.Point(184, 265);
            this.btnNORMAL.Name = "btnNORMAL";
            this.btnNORMAL.Size = new System.Drawing.Size(590, 45);
            this.btnNORMAL.TabIndex = 23;
            this.btnNORMAL.Text = "N O R M A L";
            this.btnNORMAL.UseVisualStyleBackColor = true;
            // 
            // btnDIFICIL
            // 
            this.btnDIFICIL.Location = new System.Drawing.Point(184, 341);
            this.btnDIFICIL.Name = "btnDIFICIL";
            this.btnDIFICIL.Size = new System.Drawing.Size(590, 45);
            this.btnDIFICIL.TabIndex = 24;
            this.btnDIFICIL.Text = "D I F I C I L";
            this.btnDIFICIL.UseVisualStyleBackColor = true;
            // 
            // Niveles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.btnDIFICIL);
            this.Controls.Add(this.btnNORMAL);
            this.Controls.Add(this.btnFACIL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnATR);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.minimizar);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Niveles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NivelesCvH";
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.PictureBox salir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnATR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFACIL;
        private System.Windows.Forms.Button btnNORMAL;
        private System.Windows.Forms.Button btnDIFICIL;
    }
}