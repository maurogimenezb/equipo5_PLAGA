
namespace Juego_de_la_Plaga
{
    partial class ComoJugar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComoJugar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.salirCJ = new System.Windows.Forms.PictureBox();
            this.minimizarCJ = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnATR = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.salirCJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarCJ)).BeginInit();
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
            this.panel1.TabIndex = 7;
            // 
            // salirCJ
            // 
            this.salirCJ.Image = ((System.Drawing.Image)(resources.GetObject("salirCJ.Image")));
            this.salirCJ.Location = new System.Drawing.Point(874, 12);
            this.salirCJ.Name = "salirCJ";
            this.salirCJ.Size = new System.Drawing.Size(28, 27);
            this.salirCJ.TabIndex = 8;
            this.salirCJ.TabStop = false;
            this.salirCJ.Click += new System.EventHandler(this.salirCJ_Click);
            // 
            // minimizarCJ
            // 
            this.minimizarCJ.Image = ((System.Drawing.Image)(resources.GetObject("minimizarCJ.Image")));
            this.minimizarCJ.Location = new System.Drawing.Point(840, 12);
            this.minimizarCJ.Name = "minimizarCJ";
            this.minimizarCJ.Size = new System.Drawing.Size(28, 27);
            this.minimizarCJ.TabIndex = 10;
            this.minimizarCJ.TabStop = false;
            this.minimizarCJ.Click += new System.EventHandler(this.minimizarCJ_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(526, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Como Jugar?";
            // 
            // btnATR
            // 
            this.btnATR.FlatAppearance.BorderSize = 0;
            this.btnATR.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnATR.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnATR.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnATR.Location = new System.Drawing.Point(733, 521);
            this.btnATR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnATR.Name = "btnATR";
            this.btnATR.Size = new System.Drawing.Size(106, 30);
            this.btnATR.TabIndex = 12;
            this.btnATR.Text = "Atràs";
            this.btnATR.UseVisualStyleBackColor = true;
            this.btnATR.Click += new System.EventHandler(this.btnNJ_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(373, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(456, 402);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // ComoJugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnATR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minimizarCJ);
            this.Controls.Add(this.salirCJ);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ComoJugar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComoJugar";
            ((System.ComponentModel.ISupportInitialize)(this.salirCJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarCJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox salirCJ;
        private System.Windows.Forms.PictureBox minimizarCJ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnATR;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}