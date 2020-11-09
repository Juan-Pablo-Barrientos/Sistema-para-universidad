namespace UI.Desktop
{
    partial class AlumnosInscripcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlumnosInscripcion));
            this.tscAlumIns = new System.Windows.Forms.ToolStripContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvAlumIns = new System.Windows.Forms.DataGridView();
            this.id_inscripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.tscAlumIns.ContentPanel.SuspendLayout();
            this.tscAlumIns.TopToolStripPanel.SuspendLayout();
            this.tscAlumIns.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumIns)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tscAlumIns
            // 
            // 
            // tscAlumIns.ContentPanel
            // 
            this.tscAlumIns.ContentPanel.Controls.Add(this.tableLayoutPanel1);
            this.tscAlumIns.ContentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.tscAlumIns.ContentPanel.Size = new System.Drawing.Size(600, 341);
            this.tscAlumIns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscAlumIns.Location = new System.Drawing.Point(0, 0);
            this.tscAlumIns.Margin = new System.Windows.Forms.Padding(2);
            this.tscAlumIns.Name = "tscAlumIns";
            this.tscAlumIns.Size = new System.Drawing.Size(600, 366);
            this.tscAlumIns.TabIndex = 0;
            this.tscAlumIns.Text = "toolStripContainer1";
            // 
            // tscAlumIns.TopToolStripPanel
            // 
            this.tscAlumIns.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnActualizar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvAlumIns, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 341);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(470, 320);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(68, 19);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(542, 320);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(56, 19);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvAlumIns
            // 
            this.dgvAlumIns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumIns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_inscripcion,
            this.id_alumno,
            this.id_curso,
            this.usuario,
            this.curso,
            this.condicion,
            this.nota});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvAlumIns, 2);
            this.dgvAlumIns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlumIns.Location = new System.Drawing.Point(2, 2);
            this.dgvAlumIns.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAlumIns.MultiSelect = false;
            this.dgvAlumIns.Name = "dgvAlumIns";
            this.dgvAlumIns.RowHeadersWidth = 51;
            this.dgvAlumIns.RowTemplate.Height = 24;
            this.dgvAlumIns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumIns.Size = new System.Drawing.Size(596, 314);
            this.dgvAlumIns.TabIndex = 2;
            // 
            // id_inscripcion
            // 
            this.id_inscripcion.DataPropertyName = "ID";
            this.id_inscripcion.HeaderText = "ID Inscripcion";
            this.id_inscripcion.Name = "id_inscripcion";
            this.id_inscripcion.ReadOnly = true;
            // 
            // id_alumno
            // 
            this.id_alumno.DataPropertyName = "IDAlumno";
            this.id_alumno.HeaderText = "ID Alumno";
            this.id_alumno.Name = "id_alumno";
            this.id_alumno.ReadOnly = true;
            this.id_alumno.Visible = false;
            // 
            // id_curso
            // 
            this.id_curso.DataPropertyName = "IDCurso";
            this.id_curso.HeaderText = "ID Curso";
            this.id_curso.Name = "id_curso";
            this.id_curso.ReadOnly = true;
            this.id_curso.Visible = false;
            // 
            // usuario
            // 
            this.usuario.HeaderText = "Alumno";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            // 
            // curso
            // 
            this.curso.HeaderText = "Curso";
            this.curso.Name = "curso";
            this.curso.ReadOnly = true;
            // 
            // condicion
            // 
            this.condicion.DataPropertyName = "Condicion";
            this.condicion.HeaderText = "Condicion";
            this.condicion.Name = "condicion";
            this.condicion.ReadOnly = true;
            // 
            // nota
            // 
            this.nota.DataPropertyName = "Nota";
            this.nota.HeaderText = "Nota";
            this.nota.Name = "nota";
            this.nota.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnEditar,
            this.btnEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(153, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // btnNuevo
            // 
            this.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(46, 22);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(41, 22);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(54, 22);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // AlumnosInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tscAlumIns);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "AlumnosInscripcion";
            this.Text = "AlumnosIncripcion";
            this.Load += new System.EventHandler(this.AlumIns_Load);
            this.tscAlumIns.ContentPanel.ResumeLayout(false);
            this.tscAlumIns.TopToolStripPanel.ResumeLayout(false);
            this.tscAlumIns.TopToolStripPanel.PerformLayout();
            this.tscAlumIns.ResumeLayout(false);
            this.tscAlumIns.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumIns)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscAlumIns;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvAlumIns;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_inscripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn condicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota;
    }
}