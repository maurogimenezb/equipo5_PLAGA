
namespace Juego_de_la_Plaga
{
    partial class Modos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modos));
            this.btnCvH = new System.Windows.Forms.Button();
            this.btnHvH = new System.Windows.Forms.Button();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.salir = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnATR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salir)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCvH
            // 
            this.btnCvH.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCvH.Location = new System.Drawing.Point(419, 328);
            this.btnCvH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCvH.Name = "btnCvH";
            this.btnCvH.Size = new System.Drawing.Size(355, 45);
            this.btnCvH.TabIndex = 0;
            this.btnCvH.Text = "Computadora vs Humano";
            this.btnCvH.UseVisualStyleBackColor = true;
            this.btnCvH.Click += new System.EventHandler(this.btnCvH_Click);
            // 
            // btnHvH
            // 
            this.btnHvH.Location = new System.Drawing.Point(419, 236);
            this.btnHvH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHvH.Name = "btnHvH";
            this.btnHvH.Size = new System.Drawing.Size(355, 45);
            this.btnHvH.TabIndex = 2;
            this.btnHvH.Text = "Humano vs Humano";
            this.btnHvH.UseVisualStyleBackColor = true;
            this.btnHvH.Click += new System.EventHandler(this.btnHvH_Click);
            // 
            // minimizar
            // 
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
            this.minimizar.Location = new System.Drawing.Point(840, 12);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(28, 27);
            this.minimizar.TabIndex = 11;
            this.minimizar.TabStop = false;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
            // 
            // salir
            // 
            this.salir.Image = ((System.Drawing.Image)(resources.GetObject("salir.Image")));
            this.salir.Location = new System.Drawing.Point(874, 12);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(28, 27);
            this.salir.TabIndex = 10;
            this.salir.TabStop = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 600);
            this.panel1.TabIndex = 12;
            // 
            // btnATR
            // 
            this.btnATR.FlatAppearance.BorderSize = 0;
            this.btnATR.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnATR.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnATR.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnATR.Location = new System.Drawing.Point(557, 510);
            this.btnATR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnATR.Name = "btnATR";
            this.btnATR.Size = new System.Drawing.Size(106, 30);
            this.btnATR.TabIndex = 14;
            this.btnATR.Text = "Atràs";
            this.btnATR.UseVisualStyleBackColor = true;
            this.btnATR.Click += new System.EventHandler(this.btnATR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(483, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Modalidad del Juego";
            // 
            // Modos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnATR);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.minimizar);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.btnHvH);
            this.Controls.Add(this.btnCvH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Modos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCvH;
        private System.Windows.Forms.Button btnHvH;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.PictureBox salir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnATR;
        private System.Windows.Forms.Label label1;
    }
}