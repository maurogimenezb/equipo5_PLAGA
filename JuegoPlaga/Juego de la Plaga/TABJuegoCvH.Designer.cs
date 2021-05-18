
namespace Juego_de_la_Plaga
{
    partial class TABJuegoCvH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TABJuegoCvH));
            this.btnMP = new System.Windows.Forms.Button();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.salir = new System.Windows.Forms.PictureBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAtras = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtnIAA = new System.Windows.Forms.RadioButton();
            this.rbtnIAR = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnJA = new System.Windows.Forms.RadioButton();
            this.rbtnJR = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtJug = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGO = new System.Windows.Forms.PictureBox();
            this.btnReiniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salir)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGO)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMP
            // 
            this.btnMP.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMP.Location = new System.Drawing.Point(225, 523);
            this.btnMP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMP.Name = "btnMP";
            this.btnMP.Size = new System.Drawing.Size(148, 32);
            this.btnMP.TabIndex = 3;
            this.btnMP.Text = "Volver al Menu";
            this.btnMP.UseVisualStyleBackColor = true;
            this.btnMP.Click += new System.EventHandler(this.btnMP_Click);
            // 
            // minimizar
            // 
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
            this.minimizar.Location = new System.Drawing.Point(840, 12);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(28, 27);
            this.minimizar.TabIndex = 13;
            this.minimizar.TabStop = false;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
            // 
            // salir
            // 
            this.salir.Image = ((System.Drawing.Image)(resources.GetObject("salir.Image")));
            this.salir.Location = new System.Drawing.Point(874, 12);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(28, 27);
            this.salir.TabIndex = 12;
            this.salir.TabStop = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(713, 88);
            this.txtY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(71, 27);
            this.txtY.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(557, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Cant. Columnas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(606, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cant. Filas:";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(713, 44);
            this.txtX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(71, 27);
            this.txtX.TabIndex = 18;
            this.txtX.TextChanged += new System.EventHandler(this.txtFILA_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Location = new System.Drawing.Point(803, 66);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 31);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(12, 600);
            this.panel1.TabIndex = 22;
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAtras.Location = new System.Drawing.Point(58, 523);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(148, 32);
            this.btnAtras.TabIndex = 23;
            this.btnAtras.Text = "Atràs";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtIA);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.txtJug);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(572, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 453);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "  Introduzca los nombres de los jugadores:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtnIAA);
            this.groupBox3.Controls.Add(this.rbtnIAR);
            this.groupBox3.Location = new System.Drawing.Point(107, 344);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(130, 55);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            // 
            // rbtnIAA
            // 
            this.rbtnIAA.AutoSize = true;
            this.rbtnIAA.Location = new System.Drawing.Point(67, 23);
            this.rbtnIAA.Name = "rbtnIAA";
            this.rbtnIAA.Size = new System.Drawing.Size(60, 24);
            this.rbtnIAA.TabIndex = 1;
            this.rbtnIAA.TabStop = true;
            this.rbtnIAA.Text = "Azul";
            this.rbtnIAA.UseVisualStyleBackColor = true;
            // 
            // rbtnIAR
            // 
            this.rbtnIAR.AutoSize = true;
            this.rbtnIAR.Location = new System.Drawing.Point(6, 23);
            this.rbtnIAR.Name = "rbtnIAR";
            this.rbtnIAR.Size = new System.Drawing.Size(61, 24);
            this.rbtnIAR.TabIndex = 0;
            this.rbtnIAR.TabStop = true;
            this.rbtnIAR.Text = "Rojo";
            this.rbtnIAR.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnJA);
            this.groupBox2.Controls.Add(this.rbtnJR);
            this.groupBox2.Location = new System.Drawing.Point(110, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 55);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            // 
            // rbtnJA
            // 
            this.rbtnJA.AutoSize = true;
            this.rbtnJA.Location = new System.Drawing.Point(67, 23);
            this.rbtnJA.Name = "rbtnJA";
            this.rbtnJA.Size = new System.Drawing.Size(60, 24);
            this.rbtnJA.TabIndex = 1;
            this.rbtnJA.TabStop = true;
            this.rbtnJA.Text = "Azul";
            this.rbtnJA.UseVisualStyleBackColor = true;
            // 
            // rbtnJR
            // 
            this.rbtnJR.AutoSize = true;
            this.rbtnJR.Location = new System.Drawing.Point(6, 23);
            this.rbtnJR.Name = "rbtnJR";
            this.rbtnJR.Size = new System.Drawing.Size(61, 24);
            this.rbtnJR.TabIndex = 0;
            this.rbtnJR.TabStop = true;
            this.rbtnJR.Text = "Rojo";
            this.rbtnJR.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "VS";
            // 
            // txtIA
            // 
            this.txtIA.Location = new System.Drawing.Point(107, 405);
            this.txtIA.Name = "txtIA";
            this.txtIA.Size = new System.Drawing.Size(125, 27);
            this.txtIA.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Jugador 2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(138, 252);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // txtJug
            // 
            this.txtJug.Location = new System.Drawing.Point(110, 179);
            this.txtJug.Name = "txtJug";
            this.txtJug.Size = new System.Drawing.Size(125, 27);
            this.txtJug.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Jugador 1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(141, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // btnGO
            // 
            this.btnGO.Image = ((System.Drawing.Image)(resources.GetObject("btnGO.Image")));
            this.btnGO.Location = new System.Drawing.Point(404, 495);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(100, 93);
            this.btnGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnGO.TabIndex = 26;
            this.btnGO.TabStop = false;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReiniciar.Location = new System.Drawing.Point(143, 563);
            this.btnReiniciar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(148, 32);
            this.btnReiniciar.TabIndex = 27;
            this.btnReiniciar.Text = "Reiniciar Juego";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // TABJuegoCvH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnGO);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.minimizar);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.btnMP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TABJuegoCvH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salir)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMP;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.PictureBox salir;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtJug;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnGO;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtnIAA;
        private System.Windows.Forms.RadioButton rbtnIAR;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnJA;
        private System.Windows.Forms.RadioButton rbtnJR;
    }
}