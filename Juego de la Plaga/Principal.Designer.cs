
namespace Juego_de_la_Plaga
{
    partial class Principal
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
            this.btnNJ = new System.Windows.Forms.Button();
            this.btnRJ = new System.Windows.Forms.Button();
            this.btnCJ = new System.Windows.Forms.Button();
            this.btnRdeJ = new System.Windows.Forms.Button();
            this.btnAdeA = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNJ
            // 
            this.btnNJ.Location = new System.Drawing.Point(301, 112);
            this.btnNJ.Name = "btnNJ";
            this.btnNJ.Size = new System.Drawing.Size(196, 44);
            this.btnNJ.TabIndex = 0;
            this.btnNJ.Text = "Nuevo Juego";
            this.btnNJ.UseVisualStyleBackColor = true;
            this.btnNJ.Click += new System.EventHandler(this.btnNJ_Click_1);
            // 
            // btnRJ
            // 
            this.btnRJ.Location = new System.Drawing.Point(301, 162);
            this.btnRJ.Name = "btnRJ";
            this.btnRJ.Size = new System.Drawing.Size(196, 44);
            this.btnRJ.TabIndex = 1;
            this.btnRJ.Text = "Reanudar Juego";
            this.btnRJ.UseVisualStyleBackColor = true;
            // 
            // btnCJ
            // 
            this.btnCJ.Location = new System.Drawing.Point(301, 212);
            this.btnCJ.Name = "btnCJ";
            this.btnCJ.Size = new System.Drawing.Size(196, 44);
            this.btnCJ.TabIndex = 2;
            this.btnCJ.Text = "¿Como Jugar?";
            this.btnCJ.UseVisualStyleBackColor = true;
            // 
            // btnRdeJ
            // 
            this.btnRdeJ.Location = new System.Drawing.Point(301, 262);
            this.btnRdeJ.Name = "btnRdeJ";
            this.btnRdeJ.Size = new System.Drawing.Size(196, 44);
            this.btnRdeJ.TabIndex = 3;
            this.btnRdeJ.Text = "Registro de Jugadas";
            this.btnRdeJ.UseVisualStyleBackColor = true;
            // 
            // btnAdeA
            // 
            this.btnAdeA.Location = new System.Drawing.Point(301, 312);
            this.btnAdeA.Name = "btnAdeA";
            this.btnAdeA.Size = new System.Drawing.Size(196, 44);
            this.btnAdeA.TabIndex = 4;
            this.btnAdeA.Text = "Acerca de los Autores";
            this.btnAdeA.UseVisualStyleBackColor = true;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(301, 362);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(196, 44);
            this.btnsalir.TabIndex = 5;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnAdeA);
            this.Controls.Add(this.btnRdeJ);
            this.Controls.Add(this.btnCJ);
            this.Controls.Add(this.btnRJ);
            this.Controls.Add(this.btnNJ);
            this.Name = "Principal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNJ;
        private System.Windows.Forms.Button btnRJ;
        private System.Windows.Forms.Button btnCJ;
        private System.Windows.Forms.Button btnRdeJ;
        private System.Windows.Forms.Button btnAdeA;
        private System.Windows.Forms.Button btnsalir;
    }
}

