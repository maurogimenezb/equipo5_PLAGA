
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
            this.btnCvH = new System.Windows.Forms.Button();
            this.btnatras = new System.Windows.Forms.Button();
            this.btnHvH = new System.Windows.Forms.Button();
            this.btnCvC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCvH
            // 
            this.btnCvH.Location = new System.Drawing.Point(287, 113);
            this.btnCvH.Name = "btnCvH";
            this.btnCvH.Size = new System.Drawing.Size(180, 40);
            this.btnCvH.TabIndex = 0;
            this.btnCvH.Text = "Computadora vs Humano";
            this.btnCvH.UseVisualStyleBackColor = true;
            this.btnCvH.Click += new System.EventHandler(this.btnCvH_Click);
            // 
            // btnatras
            // 
            this.btnatras.Location = new System.Drawing.Point(636, 320);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(75, 23);
            this.btnatras.TabIndex = 1;
            this.btnatras.Text = "Atras";
            this.btnatras.UseVisualStyleBackColor = true;
            this.btnatras.Click += new System.EventHandler(this.btnatras_Click);
            // 
            // btnHvH
            // 
            this.btnHvH.Location = new System.Drawing.Point(287, 159);
            this.btnHvH.Name = "btnHvH";
            this.btnHvH.Size = new System.Drawing.Size(180, 40);
            this.btnHvH.TabIndex = 2;
            this.btnHvH.Text = "Humano vs Humano";
            this.btnHvH.UseVisualStyleBackColor = true;
            this.btnHvH.Click += new System.EventHandler(this.btnHvH_Click);
            // 
            // btnCvC
            // 
            this.btnCvC.Location = new System.Drawing.Point(287, 205);
            this.btnCvC.Name = "btnCvC";
            this.btnCvC.Size = new System.Drawing.Size(180, 40);
            this.btnCvC.TabIndex = 3;
            this.btnCvC.Text = "Computadora vs Computadora";
            this.btnCvC.UseVisualStyleBackColor = true;
            this.btnCvC.Click += new System.EventHandler(this.btnCvC_Click_1);
            // 
            // Modos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCvC);
            this.Controls.Add(this.btnHvH);
            this.Controls.Add(this.btnatras);
            this.Controls.Add(this.btnCvH);
            this.Name = "Modos";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCvH;
        private System.Windows.Forms.Button btnatras;
        private System.Windows.Forms.Button btnHvH;
        private System.Windows.Forms.Button btnCvC;
    }
}