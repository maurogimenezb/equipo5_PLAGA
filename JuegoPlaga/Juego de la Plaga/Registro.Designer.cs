
namespace Juego_de_la_Plaga
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimizarRJ = new System.Windows.Forms.PictureBox();
            this.salirRJ = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnATR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarRJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salirRJ)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 600);
            this.panel1.TabIndex = 9;
            // 
            // minimizarRJ
            // 
            this.minimizarRJ.Image = ((System.Drawing.Image)(resources.GetObject("minimizarRJ.Image")));
            this.minimizarRJ.Location = new System.Drawing.Point(840, 12);
            this.minimizarRJ.Name = "minimizarRJ";
            this.minimizarRJ.Size = new System.Drawing.Size(28, 27);
            this.minimizarRJ.TabIndex = 14;
            this.minimizarRJ.TabStop = false;
            this.minimizarRJ.Click += new System.EventHandler(this.minimizarRJ_Click);
            // 
            // salirRJ
            // 
            this.salirRJ.Image = ((System.Drawing.Image)(resources.GetObject("salirRJ.Image")));
            this.salirRJ.Location = new System.Drawing.Point(874, 12);
            this.salirRJ.Name = "salirRJ";
            this.salirRJ.Size = new System.Drawing.Size(28, 27);
            this.salirRJ.TabIndex = 13;
            this.salirRJ.TabStop = false;
            this.salirRJ.Click += new System.EventHandler(this.salirRJ_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(494, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Registro de Jugadas";
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
            this.btnATR.TabIndex = 16;
            this.btnATR.Text = "Atràs";
            this.btnATR.UseVisualStyleBackColor = true;
            this.btnATR.Click += new System.EventHandler(this.btnATR_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.btnATR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minimizarRJ);
            this.Controls.Add(this.salirRJ);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroJugadas";
            this.Load += new System.EventHandler(this.Registro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minimizarRJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salirRJ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox minimizarRJ;
        private System.Windows.Forms.PictureBox salirRJ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnATR;
    }
}