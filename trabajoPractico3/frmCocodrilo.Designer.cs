namespace trabajoPractico3
{
    partial class frmCocodrilo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbxPrimerNumero = new System.Windows.Forms.PictureBox();
            this.pbxSegundoNumero = new System.Windows.Forms.PictureBox();
            this.pbxEleccion = new System.Windows.Forms.PictureBox();
            this.btnMayor = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnMenor = new System.Windows.Forms.Button();
            this.pbxResultado = new System.Windows.Forms.PictureBox();
            this.btnJugar = new System.Windows.Forms.Button();
            this.lblAciertos = new System.Windows.Forms.Label();
            this.lblErrores = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbxResultadoFinal = new System.Windows.Forms.PictureBox();
            this.btnVolverAJugar = new System.Windows.Forms.Button();
            this.lblTextoFinal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPrimerNumero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSegundoNumero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEleccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxResultado)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxResultadoFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxPrimerNumero
            // 
            this.pbxPrimerNumero.BackColor = System.Drawing.SystemColors.Control;
            this.pbxPrimerNumero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxPrimerNumero.Location = new System.Drawing.Point(51, 12);
            this.pbxPrimerNumero.Name = "pbxPrimerNumero";
            this.pbxPrimerNumero.Size = new System.Drawing.Size(175, 175);
            this.pbxPrimerNumero.TabIndex = 0;
            this.pbxPrimerNumero.TabStop = false;
            // 
            // pbxSegundoNumero
            // 
            this.pbxSegundoNumero.BackColor = System.Drawing.SystemColors.Control;
            this.pbxSegundoNumero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxSegundoNumero.Location = new System.Drawing.Point(566, 12);
            this.pbxSegundoNumero.Name = "pbxSegundoNumero";
            this.pbxSegundoNumero.Size = new System.Drawing.Size(175, 175);
            this.pbxSegundoNumero.TabIndex = 1;
            this.pbxSegundoNumero.TabStop = false;
            // 
            // pbxEleccion
            // 
            this.pbxEleccion.BackColor = System.Drawing.SystemColors.Control;
            this.pbxEleccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxEleccion.Location = new System.Drawing.Point(308, 28);
            this.pbxEleccion.Name = "pbxEleccion";
            this.pbxEleccion.Size = new System.Drawing.Size(175, 175);
            this.pbxEleccion.TabIndex = 2;
            this.pbxEleccion.TabStop = false;
            // 
            // btnMayor
            // 
            this.btnMayor.BackgroundImage = global::trabajoPractico3.Properties.Resources.Mayor;
            this.btnMayor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMayor.Location = new System.Drawing.Point(245, 304);
            this.btnMayor.Name = "btnMayor";
            this.btnMayor.Size = new System.Drawing.Size(80, 80);
            this.btnMayor.TabIndex = 3;
            this.btnMayor.UseVisualStyleBackColor = true;
            this.btnMayor.Visible = false;
            this.btnMayor.Click += new System.EventHandler(this.btnMayor_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.BackgroundImage = global::trabajoPractico3.Properties.Resources.Igual;
            this.btnIgual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIgual.Location = new System.Drawing.Point(365, 304);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(80, 80);
            this.btnIgual.TabIndex = 4;
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Visible = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnMenor
            // 
            this.btnMenor.BackgroundImage = global::trabajoPractico3.Properties.Resources.Menor;
            this.btnMenor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenor.Location = new System.Drawing.Point(476, 304);
            this.btnMenor.Name = "btnMenor";
            this.btnMenor.Size = new System.Drawing.Size(80, 80);
            this.btnMenor.TabIndex = 5;
            this.btnMenor.UseVisualStyleBackColor = true;
            this.btnMenor.Visible = false;
            this.btnMenor.Click += new System.EventHandler(this.btnMenor_Click);
            // 
            // pbxResultado
            // 
            this.pbxResultado.BackColor = System.Drawing.SystemColors.Control;
            this.pbxResultado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxResultado.Location = new System.Drawing.Point(365, 221);
            this.pbxResultado.Name = "pbxResultado";
            this.pbxResultado.Size = new System.Drawing.Size(79, 63);
            this.pbxResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxResultado.TabIndex = 6;
            this.pbxResultado.TabStop = false;
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(245, 320);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(307, 49);
            this.btnJugar.TabIndex = 7;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // lblAciertos
            // 
            this.lblAciertos.AutoSize = true;
            this.lblAciertos.Location = new System.Drawing.Point(6, 27);
            this.lblAciertos.Name = "lblAciertos";
            this.lblAciertos.Size = new System.Drawing.Size(48, 13);
            this.lblAciertos.TabIndex = 8;
            this.lblAciertos.Text = "Aciertos:";
            // 
            // lblErrores
            // 
            this.lblErrores.AutoSize = true;
            this.lblErrores.Location = new System.Drawing.Point(6, 52);
            this.lblErrores.Name = "lblErrores";
            this.lblErrores.Size = new System.Drawing.Size(43, 13);
            this.lblErrores.TabIndex = 9;
            this.lblErrores.Text = "Errores:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblErrores);
            this.groupBox1.Controls.Add(this.lblAciertos);
            this.groupBox1.Location = new System.Drawing.Point(649, 304);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 133);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados";
            // 
            // pbxResultadoFinal
            // 
            this.pbxResultadoFinal.BackColor = System.Drawing.SystemColors.Control;
            this.pbxResultadoFinal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxResultadoFinal.Location = new System.Drawing.Point(258, 12);
            this.pbxResultadoFinal.Name = "pbxResultadoFinal";
            this.pbxResultadoFinal.Size = new System.Drawing.Size(312, 212);
            this.pbxResultadoFinal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxResultadoFinal.TabIndex = 11;
            this.pbxResultadoFinal.TabStop = false;
            this.pbxResultadoFinal.Visible = false;
            // 
            // btnVolverAJugar
            // 
            this.btnVolverAJugar.Location = new System.Drawing.Point(245, 320);
            this.btnVolverAJugar.Name = "btnVolverAJugar";
            this.btnVolverAJugar.Size = new System.Drawing.Size(311, 51);
            this.btnVolverAJugar.TabIndex = 12;
            this.btnVolverAJugar.Text = "Volver a jugar";
            this.btnVolverAJugar.UseVisualStyleBackColor = true;
            this.btnVolverAJugar.Visible = false;
            this.btnVolverAJugar.Click += new System.EventHandler(this.btnVolverAJugar_Click);
            // 
            // lblTextoFinal
            // 
            this.lblTextoFinal.AutoSize = true;
            this.lblTextoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoFinal.Location = new System.Drawing.Point(335, 242);
            this.lblTextoFinal.Name = "lblTextoFinal";
            this.lblTextoFinal.Size = new System.Drawing.Size(0, 28);
            this.lblTextoFinal.TabIndex = 13;
            this.lblTextoFinal.UseWaitCursor = true;
            this.lblTextoFinal.Visible = false;
            // 
            // frmCocodrilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTextoFinal);
            this.Controls.Add(this.btnVolverAJugar);
            this.Controls.Add(this.pbxResultadoFinal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.pbxResultado);
            this.Controls.Add(this.btnMenor);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnMayor);
            this.Controls.Add(this.pbxEleccion);
            this.Controls.Add(this.pbxSegundoNumero);
            this.Controls.Add(this.pbxPrimerNumero);
            this.Name = "frmCocodrilo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coco el cocodrilo";
            ((System.ComponentModel.ISupportInitialize)(this.pbxPrimerNumero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSegundoNumero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEleccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxResultado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxResultadoFinal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxPrimerNumero;
        private System.Windows.Forms.PictureBox pbxSegundoNumero;
        private System.Windows.Forms.PictureBox pbxEleccion;
        private System.Windows.Forms.Button btnMayor;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnMenor;
        private System.Windows.Forms.PictureBox pbxResultado;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Label lblAciertos;
        private System.Windows.Forms.Label lblErrores;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbxResultadoFinal;
        private System.Windows.Forms.Button btnVolverAJugar;
        private System.Windows.Forms.Label lblTextoFinal;
    }
}

