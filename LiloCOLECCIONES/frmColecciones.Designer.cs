namespace LiloCOLECCIONES
{
    partial class frmColecciones
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
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.lstCurso = new System.Windows.Forms.ListBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.txtPosicion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSeleccion = new System.Windows.Forms.Button();
            this.BorararSelecc = new System.Windows.Forms.Button();
            this.btnCU = new System.Windows.Forms.Button();
            this.btnBorra = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnPosicion = new System.Windows.Forms.Button();
            this.btnCantidad = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblPosi = new System.Windows.Forms.Label();
            this.lblCant = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.lblMostrarDato = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboCurso
            // 
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Location = new System.Drawing.Point(2, 12);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(121, 21);
            this.cboCurso.TabIndex = 0;
            // 
            // lstCurso
            // 
            this.lstCurso.FormattingEnabled = true;
            this.lstCurso.Location = new System.Drawing.Point(193, 5);
            this.lstCurso.Name = "lstCurso";
            this.lstCurso.Size = new System.Drawing.Size(120, 95);
            this.lstCurso.TabIndex = 1;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(57, 77);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "CARGAR";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(57, 51);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(100, 20);
            this.txtDato.TabIndex = 3;
            // 
            // txtPosicion
            // 
            this.txtPosicion.Location = new System.Drawing.Point(57, 122);
            this.txtPosicion.Name = "txtPosicion";
            this.txtPosicion.Size = new System.Drawing.Size(100, 20);
            this.txtPosicion.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "INSERTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Posicion";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(57, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "INSERTAR ULTIMO";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSeleccion
            // 
            this.btnSeleccion.Location = new System.Drawing.Point(57, 206);
            this.btnSeleccion.Name = "btnSeleccion";
            this.btnSeleccion.Size = new System.Drawing.Size(129, 23);
            this.btnSeleccion.TabIndex = 9;
            this.btnSeleccion.Text = "INSERTAR SELECC";
            this.btnSeleccion.UseVisualStyleBackColor = true;
            this.btnSeleccion.Click += new System.EventHandler(this.btnSeleccion_Click);
            // 
            // BorararSelecc
            // 
            this.BorararSelecc.Location = new System.Drawing.Point(193, 206);
            this.BorararSelecc.Name = "BorararSelecc";
            this.BorararSelecc.Size = new System.Drawing.Size(129, 23);
            this.BorararSelecc.TabIndex = 12;
            this.BorararSelecc.Text = "BORRAR SELEC";
            this.BorararSelecc.UseVisualStyleBackColor = true;
            this.BorararSelecc.Click += new System.EventHandler(this.BorararSelecc_Click);
            // 
            // btnCU
            // 
            this.btnCU.Location = new System.Drawing.Point(193, 177);
            this.btnCU.Name = "btnCU";
            this.btnCU.Size = new System.Drawing.Size(129, 23);
            this.btnCU.TabIndex = 11;
            this.btnCU.Text = "Borar Ultimo";
            this.btnCU.UseVisualStyleBackColor = true;
            this.btnCU.Click += new System.EventHandler(this.btnCU_Click);
            // 
            // btnBorra
            // 
            this.btnBorra.Location = new System.Drawing.Point(193, 148);
            this.btnBorra.Name = "btnBorra";
            this.btnBorra.Size = new System.Drawing.Size(75, 23);
            this.btnBorra.TabIndex = 10;
            this.btnBorra.Text = "BORRAR";
            this.btnBorra.UseVisualStyleBackColor = true;
            this.btnBorra.Click += new System.EventHandler(this.btnBorra_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(193, 235);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "BORRAR POSICION";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPosicion
            // 
            this.btnPosicion.Location = new System.Drawing.Point(193, 294);
            this.btnPosicion.Name = "btnPosicion";
            this.btnPosicion.Size = new System.Drawing.Size(120, 23);
            this.btnPosicion.TabIndex = 14;
            this.btnPosicion.Text = "MOSTRAR POSI";
            this.btnPosicion.UseVisualStyleBackColor = true;
            this.btnPosicion.Click += new System.EventHandler(this.btnPosicion_Click);
            // 
            // btnCantidad
            // 
            this.btnCantidad.Location = new System.Drawing.Point(193, 323);
            this.btnCantidad.Name = "btnCantidad";
            this.btnCantidad.Size = new System.Drawing.Size(120, 23);
            this.btnCantidad.TabIndex = 15;
            this.btnCantidad.Text = "MOSTRAR CANTI";
            this.btnCantidad.UseVisualStyleBackColor = true;
            this.btnCantidad.Click += new System.EventHandler(this.btnCantidad_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(193, 264);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 23);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "BORRAR LISTA";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblPosi
            // 
            this.lblPosi.AutoSize = true;
            this.lblPosi.Location = new System.Drawing.Point(151, 299);
            this.lblPosi.Name = "lblPosi";
            this.lblPosi.Size = new System.Drawing.Size(13, 13);
            this.lblPosi.TabIndex = 17;
            this.lblPosi.Text = "0";
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Location = new System.Drawing.Point(152, 328);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(13, 13);
            this.lblCant.TabIndex = 18;
            this.lblCant.Text = "0";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(193, 352);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "MOSTRAR DATO";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblMostrarDato
            // 
            this.lblMostrarDato.AutoSize = true;
            this.lblMostrarDato.Location = new System.Drawing.Point(152, 357);
            this.lblMostrarDato.Name = "lblMostrarDato";
            this.lblMostrarDato.Size = new System.Drawing.Size(13, 13);
            this.lblMostrarDato.TabIndex = 20;
            this.lblMostrarDato.Text = "0";
            // 
            // frmColecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 384);
            this.Controls.Add(this.lblMostrarDato);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lblCant);
            this.Controls.Add(this.lblPosi);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCantidad);
            this.Controls.Add(this.btnPosicion);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BorararSelecc);
            this.Controls.Add(this.btnCU);
            this.Controls.Add(this.btnBorra);
            this.Controls.Add(this.btnSeleccion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPosicion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.lstCurso);
            this.Controls.Add(this.cboCurso);
            this.Name = "frmColecciones";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.frmColecciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.ListBox lstCurso;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.TextBox txtPosicion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSeleccion;
        private System.Windows.Forms.Button BorararSelecc;
        private System.Windows.Forms.Button btnCU;
        private System.Windows.Forms.Button btnBorra;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnPosicion;
        private System.Windows.Forms.Button btnCantidad;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblPosi;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblMostrarDato;
    }
}

