namespace Juego_de_la_Plaga
{
    partial class J1CvH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(J1CvH));
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.salir = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtJ1CvH = new System.Windows.Forms.TextBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnSgte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salir)).BeginInit();
            this.SuspendLayout();
            // 
            // minimizar
            // 
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
            this.minimizar.Location = new System.Drawing.Point(592, 12);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(28, 27);
            this.minimizar.TabIndex = 11;
            this.minimizar.TabStop = false;
            // 
            // salir
            // 
            this.salir.Image = ((System.Drawing.Image)(resources.GetObject("salir.Image")));
            this.salir.Location = new System.Drawing.Point(626, 12);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(28, 27);
            this.salir.TabIndex = 10;
            this.salir.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 520);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(170, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ingrese el nombre del Jugador 1 :";
            // 
            // txtJ1CvH
            // 
            this.txtJ1CvH.Location = new System.Drawing.Point(158, 248);
            this.txtJ1CvH.Name = "txtJ1CvH";
            this.txtJ1CvH.Size = new System.Drawing.Size(371, 27);
            this.txtJ1CvH.TabIndex = 23;
            // 
            // btnAtras
            // 
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAtras.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAtras.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAtras.Location = new System.Drawing.Point(336, 444);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(106, 30);
            this.btnAtras.TabIndex = 24;
            this.btnAtras.Text = "Atràs";
            this.btnAtras.UseVisualStyleBackColor = true;
            // 
            // btnSgte
            // 
            this.btnSgte.FlatAppearance.BorderSize = 0;
            this.btnSgte.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSgte.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSgte.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSgte.Location = new System.Drawing.Point(469, 444);
            this.btnSgte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSgte.Name = "btnSgte";
            this.btnSgte.Size = new System.Drawing.Size(106, 30);
            this.btnSgte.TabIndex = 25;
            this.btnSgte.Text = "Siguiente";
            this.btnSgte.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 520);
            this.Controls.Add(this.btnSgte);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.txtJ1CvH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.minimizar);
            this.Controls.Add(this.salir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.PictureBox salir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJ1CvH;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnSgte;
    }
}