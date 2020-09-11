namespace UI.Desktop
{
    partial class AlumnosInscripcionDesktop
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
            this.container = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNota = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cBCurso = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInscripcion = new System.Windows.Forms.TextBox();
            this.cBAlumno = new System.Windows.Forms.ComboBox();
            this.cBCondicion = new System.Windows.Forms.ComboBox();
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.ColumnCount = 4;
            this.container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.container.Controls.Add(this.label1, 0, 2);
            this.container.Controls.Add(this.label5, 0, 1);
            this.container.Controls.Add(this.label3, 2, 1);
            this.container.Controls.Add(this.labelNota, 2, 0);
            this.container.Controls.Add(this.txtNota, 3, 0);
            this.container.Controls.Add(this.btnCancelar, 3, 3);
            this.container.Controls.Add(this.btnAceptar, 2, 3);
            this.container.Controls.Add(this.cBCurso, 1, 1);
            this.container.Controls.Add(this.label4, 0, 0);
            this.container.Controls.Add(this.txtInscripcion, 1, 0);
            this.container.Controls.Add(this.cBAlumno, 1, 2);
            this.container.Controls.Add(this.cBCondicion, 3, 1);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.RowCount = 4;
            this.container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.container.Size = new System.Drawing.Size(419, 111);
            this.container.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alumno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Curso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Condicion";
            // 
            // labelNota
            // 
            this.labelNota.AutoSize = true;
            this.labelNota.Location = new System.Drawing.Point(211, 0);
            this.labelNota.Name = "labelNota";
            this.labelNota.Size = new System.Drawing.Size(30, 13);
            this.labelNota.TabIndex = 2;
            this.labelNota.Text = "Nota";
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(315, 3);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(100, 20);
            this.txtNota.TabIndex = 8;
            this.txtNota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(315, 84);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(211, 84);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cBCurso
            // 
            this.cBCurso.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cBCurso.FormattingEnabled = true;
            this.cBCurso.Location = new System.Drawing.Point(107, 30);
            this.cBCurso.Name = "cBCurso";
            this.cBCurso.Size = new System.Drawing.Size(98, 21);
            this.cBCurso.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Id Inscripcion";
            // 
            // txtInscripcion
            // 
            this.txtInscripcion.Location = new System.Drawing.Point(107, 3);
            this.txtInscripcion.Name = "txtInscripcion";
            this.txtInscripcion.ReadOnly = true;
            this.txtInscripcion.Size = new System.Drawing.Size(98, 20);
            this.txtInscripcion.TabIndex = 6;
            // 
            // cBAlumno
            // 
            this.cBAlumno.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cBAlumno.FormattingEnabled = true;
            this.cBAlumno.Location = new System.Drawing.Point(107, 57);
            this.cBAlumno.Name = "cBAlumno";
            this.cBAlumno.Size = new System.Drawing.Size(98, 21);
            this.cBAlumno.TabIndex = 14;
            // 
            // cBCondicion
            // 
            this.cBCondicion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cBCondicion.FormattingEnabled = true;
            this.cBCondicion.Items.AddRange(new object[] {
            "Inscripto",
            "Regular",
            "Aprobado",
            "Libre"});
            this.cBCondicion.Location = new System.Drawing.Point(315, 30);
            this.cBCondicion.Name = "cBCondicion";
            this.cBCondicion.Size = new System.Drawing.Size(101, 21);
            this.cBCondicion.TabIndex = 15;
            // 
            // AlumnosInscripcionDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 111);
            this.Controls.Add(this.container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AlumnosInscripcionDesktop";
            this.Text = "AlumnosIncripcionDesktop";
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel container;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNota;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.TextBox txtInscripcion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cBAlumno;
        private System.Windows.Forms.ComboBox cBCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBCondicion;
    }
}