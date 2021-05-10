
namespace Juego_de_la_Plaga
{
    partial class J1J2HvH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(J1J2HvH));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSgte = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.txtJ1HvH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtJ2HvH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.salir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salir)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 520);
            this.panel1.TabIndex = 17;
            // 
            // btnSgte
            // 
            this.btnSgte.FlatAppearance.BorderSize = 0;
            this.btnSgte.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSgte.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSgte.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSgte.Location = new System.Drawing.Point(511, 452);
            this.btnSgte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSgte.Name = "btnSgte";
            this.btnSgte.Size = new System.Drawing.Size(106, 30);
            this.btnSgte.TabIndex = 29;
            this.btnSgte.Text = "Siguiente";
            this.btnSgte.UseVisualStyleBackColor = true;
            // 
            // btnAtras
            // 
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAtras.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAtras.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAtras.Location = new System.Drawing.Point(378, 452);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(106, 30);
            this.btnAtras.TabIndex = 28;
            this.btnAtras.Text = "Atràs";
            this.btnAtras.UseVisualStyleBackColor = true;
            // 
            // txtJ1HvH
            // 
            this.txtJ1HvH.Location = new System.Drawing.Point(159, 191);
            this.txtJ1HvH.Name = "txtJ1HvH";
            this.txtJ1HvH.Size = new System.Drawing.Size(371, 27);
            this.txtJ1HvH.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(171, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Ingrese el nombre del Jugador 1 :";
            // 
            // txtJ2HvH
            // 
            this.txtJ2HvH.Location = new System.Drawing.Point(159, 344);
            this.txtJ2HvH.Name = "txtJ2HvH";
            this.txtJ2HvH.Size = new System.Drawing.Size(371, 27);
            this.txtJ2HvH.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(171, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Ingrese el nombre del Jugador 2 :";
            // 
            // minimizar
            // 
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
            this.minimizar.Location = new System.Drawing.Point(586, 12);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(28, 27);
            this.minimizar.TabIndex = 33;
            this.minimizar.TabStop = false;
            // 
            // salir
            // 
            this.salir.Image = ((System.Drawing.Image)(resources.GetObject("salir.Image")));
            this.salir.Location = new System.Drawing.Point(626, 12);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(28, 27);
            this.salir.TabIndex = 32;
            this.salir.TabStop = false;
            // 
            // J1J2HvH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 520);
            this.Controls.Add(this.minimizar);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.txtJ2HvH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSgte);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.txtJ1HvH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "J1J2HvH";
            this.Text = "J1J2HvH";
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSgte;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.TextBox txtJ1HvH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJ2HvH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.PictureBox salir;
    }
}