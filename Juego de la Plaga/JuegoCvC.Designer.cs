
namespace Juego_de_la_Plaga
{
    partial class JuegoCvC
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtFILA = new System.Windows.Forms.TextBox();
            this.txtCOLUMNA = new System.Windows.Forms.TextBox();
            this.btnMP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(691, 37);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // txtFILA
            // 
            this.txtFILA.Location = new System.Drawing.Point(570, 37);
            this.txtFILA.Name = "txtFILA";
            this.txtFILA.Size = new System.Drawing.Size(36, 23);
            this.txtFILA.TabIndex = 1;
            // 
            // txtCOLUMNA
            // 
            this.txtCOLUMNA.Location = new System.Drawing.Point(612, 37);
            this.txtCOLUMNA.Name = "txtCOLUMNA";
            this.txtCOLUMNA.Size = new System.Drawing.Size(36, 23);
            this.txtCOLUMNA.TabIndex = 2;
            // 
            // btnMP
            // 
            this.btnMP.Location = new System.Drawing.Point(632, 397);
            this.btnMP.Name = "btnMP";
            this.btnMP.Size = new System.Drawing.Size(134, 23);
            this.btnMP.TabIndex = 3;
            this.btnMP.Text = "Menu Principal";
            this.btnMP.UseVisualStyleBackColor = true;
            this.btnMP.Click += new System.EventHandler(this.btnMP_Click_1);
            // 
            // JuegoCvC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMP);
            this.Controls.Add(this.txtCOLUMNA);
            this.Controls.Add(this.txtFILA);
            this.Controls.Add(this.btnAgregar);
            this.Name = "JuegoCvC";
            this.Text = "JuegoCvC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtFILA;
        private System.Windows.Forms.TextBox txtCOLUMNA;
        private System.Windows.Forms.Button btnMP;
    }
}