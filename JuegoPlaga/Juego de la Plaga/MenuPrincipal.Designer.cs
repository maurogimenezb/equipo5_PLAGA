
namespace Juego_de_la_Plaga
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.btnNJ = new System.Windows.Forms.Button();
            this.btnCJ = new System.Windows.Forms.Button();
            this.btnAdeA = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.salir = new System.Windows.Forms.PictureBox();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNJ
            // 
            this.btnNJ.FlatAppearance.BorderSize = 0;
            this.btnNJ.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnNJ.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNJ.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNJ.Location = new System.Drawing.Point(346, 282);
            this.btnNJ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNJ.Name = "btnNJ";
            this.btnNJ.Size = new System.Drawing.Size(483, 38);
            this.btnNJ.TabIndex = 0;
            this.btnNJ.Text = "Nuevo Juego";
            this.btnNJ.UseVisualStyleBackColor = true;
            this.btnNJ.Click += new System.EventHandler(this.btnNJ_Click_1);
            // 
            // btnCJ
            // 
            this.btnCJ.FlatAppearance.BorderSize = 0;
            this.btnCJ.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCJ.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCJ.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCJ.Location = new System.Drawing.Point(346, 346);
            this.btnCJ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCJ.Name = "btnCJ";
            this.btnCJ.Size = new System.Drawing.Size(483, 38);
            this.btnCJ.TabIndex = 2;
            this.btnCJ.Text = "¿Como Jugar?";
            this.btnCJ.UseVisualStyleBackColor = true;
            this.btnCJ.Click += new System.EventHandler(this.btnCJ_Click);
            // 
            // btnAdeA
            // 
            this.btnAdeA.FlatAppearance.BorderSize = 0;
            this.btnAdeA.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAdeA.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdeA.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdeA.Location = new System.Drawing.Point(346, 409);
            this.btnAdeA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdeA.Name = "btnAdeA";
            this.btnAdeA.Size = new System.Drawing.Size(483, 38);
            this.btnAdeA.TabIndex = 4;
            this.btnAdeA.Text = "Acerca de los Autores";
            this.btnAdeA.UseVisualStyleBackColor = true;
            this.btnAdeA.Click += new System.EventHandler(this.btnAdeA_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.FlatAppearance.BorderSize = 0;
            this.btnsalir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnsalir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnsalir.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnsalir.Location = new System.Drawing.Point(346, 473);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(483, 38);
            this.btnsalir.TabIndex = 5;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 600);
            this.panel1.TabIndex = 6;
            // 
            // salir
            // 
            this.salir.Image = ((System.Drawing.Image)(resources.GetObject("salir.Image")));
            this.salir.Location = new System.Drawing.Point(874, 12);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(28, 27);
            this.salir.TabIndex = 7;
            this.salir.TabStop = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // minimizar
            // 
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
            this.minimizar.Location = new System.Drawing.Point(840, 12);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(28, 27);
            this.minimizar.TabIndex = 9;
            this.minimizar.TabStop = false;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(433, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.minimizar);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnAdeA);
            this.Controls.Add(this.btnCJ);
            this.Controls.Add(this.btnNJ);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNJ;
        private System.Windows.Forms.Button btnCJ;
        private System.Windows.Forms.Button btnAdeA;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox salir;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

