
namespace Juego_de_la_Plaga
{
    partial class MsjSalirTAB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsjSalirTAB));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalirNO = new System.Windows.Forms.Button();
            this.btnSalirSI = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 199);
            this.panel1.TabIndex = 16;
            // 
            // btnSalirNO
            // 
            this.btnSalirNO.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalirNO.Location = new System.Drawing.Point(251, 105);
            this.btnSalirNO.Name = "btnSalirNO";
            this.btnSalirNO.Size = new System.Drawing.Size(95, 32);
            this.btnSalirNO.TabIndex = 21;
            this.btnSalirNO.Text = "NO";
            this.btnSalirNO.UseVisualStyleBackColor = true;
            // 
            // btnSalirSI
            // 
            this.btnSalirSI.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalirSI.Location = new System.Drawing.Point(122, 105);
            this.btnSalirSI.Name = "btnSalirSI";
            this.btnSalirSI.Size = new System.Drawing.Size(95, 32);
            this.btnSalirSI.TabIndex = 20;
            this.btnSalirSI.Text = "SI";
            this.btnSalirSI.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(109, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Estàs seguro que deseas salir?";
            // 
            // MsjSalirTAB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 199);
            this.Controls.Add(this.btnSalirNO);
            this.Controls.Add(this.btnSalirSI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MsjSalirTAB";
            this.Text = "MsjSalirTAB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalirNO;
        private System.Windows.Forms.Button btnSalirSI;
        private System.Windows.Forms.Label label1;
    }
}