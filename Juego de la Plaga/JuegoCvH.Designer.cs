
namespace Juego_de_la_Plaga
{
    partial class JuegoCvH
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
            this.txtFILA = new System.Windows.Forms.TextBox();
            this.txtCOLUMNA = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFILA
            // 
            this.txtFILA.Location = new System.Drawing.Point(561, 41);
            this.txtFILA.Name = "txtFILA";
            this.txtFILA.Size = new System.Drawing.Size(43, 23);
            this.txtFILA.TabIndex = 0;
            // 
            // txtCOLUMNA
            // 
            this.txtCOLUMNA.Location = new System.Drawing.Point(610, 41);
            this.txtCOLUMNA.Name = "txtCOLUMNA";
            this.txtCOLUMNA.Size = new System.Drawing.Size(42, 23);
            this.txtCOLUMNA.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(687, 46);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnMP
            // 
            this.btnMP.Location = new System.Drawing.Point(625, 400);
            this.btnMP.Name = "btnMP";
            this.btnMP.Size = new System.Drawing.Size(137, 23);
            this.btnMP.TabIndex = 3;
            this.btnMP.Text = "Menu Principal";
            this.btnMP.UseVisualStyleBackColor = true;
            this.btnMP.Click += new System.EventHandler(this.btnMP_Click);
            // 
            // JuegoCvH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMP);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCOLUMNA);
            this.Controls.Add(this.txtFILA);
            this.Name = "JuegoCvH";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFILA;
        private System.Windows.Forms.TextBox txtCOLUMNA;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMP;
    }
}