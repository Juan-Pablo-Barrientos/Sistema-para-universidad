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
            this.labelAlumno = new System.Windows.Forms.Label();
            this.labelCurso = new System.Windows.Forms.Label();
            this.labelCondicion = new System.Windows.Forms.Label();
            this.labelNota = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cBCurso = new System.Windows.Forms.ComboBox();
            this.labelID = new System.Windows.Forms.Label();
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
            this.container.Controls.Add(this.labelAlumno, 0, 2);
            this.container.Controls.Add(this.labelCurso, 0, 1);
            this.container.Controls.Add(this.labelCondicion, 2, 1);
            this.container.Controls.Add(this.labelNota, 2, 0);
            this.container.Controls.Add(this.txtNota, 3, 0);
            this.container.Controls.Add(this.btnCancelar, 3, 3);
            this.container.Controls.Add(this.btnAceptar, 2, 3);
            this.container.Controls.Add(this.cBCurso, 1, 1);
            this.container.Controls.Add(this.labelID, 0, 0);
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
            // labelAlumno
            // 
            this.labelAlumno.AutoSize = true;
            this.labelAlumno.Location = new System.Drawing.Point(3, 54);
            this.labelAlumno.Name = "labelAlumno";
            this.labelAlumno.Size = new System.Drawing.Size(42, 13);
            this.labelAlumno.TabIndex = 1;
            this.labelAlumno.Text = "Alumno";
            // 
            // labelCurso
            // 
            this.labelCurso.AutoSize = true;
            this.labelCurso.Location = new System.Drawing.Point(3, 27);
            this.labelCurso.Name = "labelCurso";
            this.labelCurso.Size = new System.Drawing.Size(34, 13);
            this.labelCurso.TabIndex = 5;
            this.labelCurso.Text = "Curso";
            // 
            // labelCondicion
            // 
            this.labelCondicion.AutoSize = true;
            this.labelCondicion.Location = new System.Drawing.Point(211, 27);
            this.labelCondicion.Name = "labelCondicion";
            this.labelCondicion.Size = new System.Drawing.Size(54, 13);
            this.labelCondicion.TabIndex = 3;
            this.labelCondicion.Text = "Condicion";
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
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(3, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(70, 13);
            this.labelID.TabIndex = 4;
            this.labelID.Text = "Id Inscripcion";
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
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelCurso;
        private System.Windows.Forms.Label labelCondicion;
        private System.Windows.Forms.Label labelNota;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.TextBox txtInscripcion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cBAlumno;
        private System.Windows.Forms.ComboBox cBCurso;
        private System.Windows.Forms.Label labelAlumno;
        private System.Windows.Forms.ComboBox cBCondicion;
    }
}