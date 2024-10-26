namespace pryFinalTP
{
    partial class CargaAlumnos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.marcoCargaFilas = new System.Windows.Forms.GroupBox();
            this.btnFilas = new System.Windows.Forms.Button();
            this.numCargarFilas = new System.Windows.Forms.NumericUpDown();
            this.marcoCargaAlumnos = new System.Windows.Forms.GroupBox();
            this.btnCargarAlumno = new System.Windows.Forms.Button();
            this.lblCantFilas = new System.Windows.Forms.Label();
            this.numTp = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numParcial2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numParcial1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.marcoResultados = new System.Windows.Forms.GroupBox();
            this.btnResultados = new System.Windows.Forms.Button();
            this.lblDesaprobados = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAprobados = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPromo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPromGral = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.marcoCargaFilas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCargarFilas)).BeginInit();
            this.marcoCargaAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numParcial2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numParcial1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.marcoResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // marcoCargaFilas
            // 
            this.marcoCargaFilas.Controls.Add(this.btnFilas);
            this.marcoCargaFilas.Controls.Add(this.numCargarFilas);
            this.marcoCargaFilas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcoCargaFilas.Location = new System.Drawing.Point(37, 35);
            this.marcoCargaFilas.Name = "marcoCargaFilas";
            this.marcoCargaFilas.Size = new System.Drawing.Size(224, 120);
            this.marcoCargaFilas.TabIndex = 0;
            this.marcoCargaFilas.TabStop = false;
            this.marcoCargaFilas.Text = "Cantidad de Alumnos";
            // 
            // btnFilas
            // 
            this.btnFilas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilas.Location = new System.Drawing.Point(62, 81);
            this.btnFilas.Name = "btnFilas";
            this.btnFilas.Size = new System.Drawing.Size(96, 33);
            this.btnFilas.TabIndex = 1;
            this.btnFilas.Text = "Cargar";
            this.btnFilas.UseVisualStyleBackColor = true;
            this.btnFilas.Click += new System.EventHandler(this.btnFilas_Click);
            // 
            // numCargarFilas
            // 
            this.numCargarFilas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCargarFilas.Location = new System.Drawing.Point(43, 38);
            this.numCargarFilas.Name = "numCargarFilas";
            this.numCargarFilas.Size = new System.Drawing.Size(133, 22);
            this.numCargarFilas.TabIndex = 0;
            this.numCargarFilas.ValueChanged += new System.EventHandler(this.numCargarFilas_ValueChanged);
            // 
            // marcoCargaAlumnos
            // 
            this.marcoCargaAlumnos.Controls.Add(this.btnCargarAlumno);
            this.marcoCargaAlumnos.Controls.Add(this.lblCantFilas);
            this.marcoCargaAlumnos.Controls.Add(this.numTp);
            this.marcoCargaAlumnos.Controls.Add(this.label4);
            this.marcoCargaAlumnos.Controls.Add(this.numParcial2);
            this.marcoCargaAlumnos.Controls.Add(this.label3);
            this.marcoCargaAlumnos.Controls.Add(this.label2);
            this.marcoCargaAlumnos.Controls.Add(this.numParcial1);
            this.marcoCargaAlumnos.Controls.Add(this.label1);
            this.marcoCargaAlumnos.Controls.Add(this.txtAlumno);
            this.marcoCargaAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcoCargaAlumnos.Location = new System.Drawing.Point(316, 35);
            this.marcoCargaAlumnos.Name = "marcoCargaAlumnos";
            this.marcoCargaAlumnos.Size = new System.Drawing.Size(357, 184);
            this.marcoCargaAlumnos.TabIndex = 1;
            this.marcoCargaAlumnos.TabStop = false;
            this.marcoCargaAlumnos.Text = "Notas de Alumno";
            // 
            // btnCargarAlumno
            // 
            this.btnCargarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarAlumno.Location = new System.Drawing.Point(52, 130);
            this.btnCargarAlumno.Name = "btnCargarAlumno";
            this.btnCargarAlumno.Size = new System.Drawing.Size(127, 40);
            this.btnCargarAlumno.TabIndex = 9;
            this.btnCargarAlumno.Text = "Cargar Alumno";
            this.btnCargarAlumno.UseVisualStyleBackColor = true;
            this.btnCargarAlumno.Click += new System.EventHandler(this.btnCargarAlumno_Click);
            // 
            // lblCantFilas
            // 
            this.lblCantFilas.AutoSize = true;
            this.lblCantFilas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantFilas.Location = new System.Drawing.Point(113, 104);
            this.lblCantFilas.Name = "lblCantFilas";
            this.lblCantFilas.Size = new System.Drawing.Size(0, 16);
            this.lblCantFilas.TabIndex = 8;
            // 
            // numTp
            // 
            this.numTp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTp.Location = new System.Drawing.Point(254, 140);
            this.numTp.Name = "numTp";
            this.numTp.Size = new System.Drawing.Size(74, 22);
            this.numTp.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(277, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tp";
            // 
            // numParcial2
            // 
            this.numParcial2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numParcial2.Location = new System.Drawing.Point(254, 89);
            this.numParcial2.Name = "numParcial2";
            this.numParcial2.Size = new System.Drawing.Size(74, 22);
            this.numParcial2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Parcial 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parcial 1";
            // 
            // numParcial1
            // 
            this.numParcial1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numParcial1.Location = new System.Drawing.Point(254, 38);
            this.numParcial1.Name = "numParcial1";
            this.numParcial1.Size = new System.Drawing.Size(74, 22);
            this.numParcial1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre y Apellido";
            // 
            // txtAlumno
            // 
            this.txtAlumno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlumno.Location = new System.Drawing.Point(33, 49);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.Size = new System.Drawing.Size(162, 22);
            this.txtAlumno.TabIndex = 0;
            // 
            // dgvAlumnos
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlumnos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAlumnos.Location = new System.Drawing.Point(12, 225);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlumnos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAlumnos.RowHeadersWidth = 51;
            this.dgvAlumnos.RowTemplate.Height = 24;
            this.dgvAlumnos.Size = new System.Drawing.Size(740, 414);
            this.dgvAlumnos.TabIndex = 2;
            // 
            // marcoResultados
            // 
            this.marcoResultados.Controls.Add(this.btnResultados);
            this.marcoResultados.Controls.Add(this.lblDesaprobados);
            this.marcoResultados.Controls.Add(this.label8);
            this.marcoResultados.Controls.Add(this.lblAprobados);
            this.marcoResultados.Controls.Add(this.label7);
            this.marcoResultados.Controls.Add(this.lblPromo);
            this.marcoResultados.Controls.Add(this.label6);
            this.marcoResultados.Controls.Add(this.lblPromGral);
            this.marcoResultados.Controls.Add(this.label5);
            this.marcoResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcoResultados.Location = new System.Drawing.Point(778, 35);
            this.marcoResultados.Name = "marcoResultados";
            this.marcoResultados.Size = new System.Drawing.Size(311, 604);
            this.marcoResultados.TabIndex = 3;
            this.marcoResultados.TabStop = false;
            this.marcoResultados.Text = "Resultados";
            // 
            // btnResultados
            // 
            this.btnResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultados.Location = new System.Drawing.Point(47, 526);
            this.btnResultados.Name = "btnResultados";
            this.btnResultados.Size = new System.Drawing.Size(210, 48);
            this.btnResultados.TabIndex = 8;
            this.btnResultados.Text = "Ver Resultados";
            this.btnResultados.UseVisualStyleBackColor = true;
            this.btnResultados.Click += new System.EventHandler(this.btnResultados_Click);
            // 
            // lblDesaprobados
            // 
            this.lblDesaprobados.AutoSize = true;
            this.lblDesaprobados.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesaprobados.Location = new System.Drawing.Point(127, 428);
            this.lblDesaprobados.Name = "lblDesaprobados";
            this.lblDesaprobados.Size = new System.Drawing.Size(0, 16);
            this.lblDesaprobados.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Desaprobados:";
            // 
            // lblAprobados
            // 
            this.lblAprobados.AutoSize = true;
            this.lblAprobados.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAprobados.Location = new System.Drawing.Point(100, 312);
            this.lblAprobados.Name = "lblAprobados";
            this.lblAprobados.Size = new System.Drawing.Size(0, 16);
            this.lblAprobados.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Aprobados:";
            // 
            // lblPromo
            // 
            this.lblPromo.AutoSize = true;
            this.lblPromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromo.Location = new System.Drawing.Point(132, 190);
            this.lblPromo.Name = "lblPromo";
            this.lblPromo.Size = new System.Drawing.Size(0, 16);
            this.lblPromo.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Promocionados:";
            // 
            // lblPromGral
            // 
            this.lblPromGral.AutoSize = true;
            this.lblPromGral.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromGral.Location = new System.Drawing.Point(149, 81);
            this.lblPromGral.Name = "lblPromGral";
            this.lblPromGral.Size = new System.Drawing.Size(0, 16);
            this.lblPromGral.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Promedio General:";
            // 
            // CargaAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1101, 651);
            this.Controls.Add(this.marcoResultados);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.marcoCargaAlumnos);
            this.Controls.Add(this.marcoCargaFilas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CargaAlumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga de Alumnos y Consulta";
            this.Load += new System.EventHandler(this.CargaAlumnos_Load);
            this.marcoCargaFilas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numCargarFilas)).EndInit();
            this.marcoCargaAlumnos.ResumeLayout(false);
            this.marcoCargaAlumnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numParcial2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numParcial1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.marcoResultados.ResumeLayout(false);
            this.marcoResultados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox marcoCargaFilas;
        private System.Windows.Forms.Button btnFilas;
        private System.Windows.Forms.NumericUpDown numCargarFilas;
        private System.Windows.Forms.GroupBox marcoCargaAlumnos;
        private System.Windows.Forms.NumericUpDown numTp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numParcial2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numParcial1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.Button btnCargarAlumno;
        private System.Windows.Forms.Label lblCantFilas;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.GroupBox marcoResultados;
        private System.Windows.Forms.Label lblDesaprobados;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAprobados;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPromo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPromGral;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnResultados;
    }
}

