namespace UI.Desktop
{
    partial class Materias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Materias));
            this.tscMateria = new System.Windows.Forms.ToolStripContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Actualizar = new System.Windows.Forms.Button();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hs_semanales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hs_totales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsEditar = new System.Windows.Forms.ToolStripButton();
            this.tsEliminar = new System.Windows.Forms.ToolStripButton();
            this.tscMateria.ContentPanel.SuspendLayout();
            this.tscMateria.TopToolStripPanel.SuspendLayout();
            this.tscMateria.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tscMateria
            // 
            // 
            // tscMateria.ContentPanel
            // 
            this.tscMateria.ContentPanel.Controls.Add(this.tableLayoutPanel1);
            this.tscMateria.ContentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.tscMateria.ContentPanel.Size = new System.Drawing.Size(683, 341);
            this.tscMateria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscMateria.Location = new System.Drawing.Point(0, 0);
            this.tscMateria.Margin = new System.Windows.Forms.Padding(2);
            this.tscMateria.Name = "tscMateria";
            this.tscMateria.Size = new System.Drawing.Size(683, 366);
            this.tscMateria.TabIndex = 0;
            this.tscMateria.Text = "toolStripContainer1";
            // 
            // tscMateria.TopToolStripPanel
            // 
            this.tscMateria.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Actualizar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvMaterias, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(683, 341);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(615, 318);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(66, 21);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Actualizar
            // 
            this.Actualizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Actualizar.Location = new System.Drawing.Point(531, 318);
            this.Actualizar.Margin = new System.Windows.Forms.Padding(2);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(80, 21);
            this.Actualizar.TabIndex = 1;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.AllowUserToAddRows = false;
            this.dgvMaterias.AllowUserToDeleteRows = false;
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.desc_materia,
            this.hs_semanales,
            this.hs_totales,
            this.ID_Plan,
            this.NombrePlan});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvMaterias, 2);
            this.dgvMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaterias.Location = new System.Drawing.Point(2, 2);
            this.dgvMaterias.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMaterias.MultiSelect = false;
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.ReadOnly = true;
            this.dgvMaterias.RowHeadersWidth = 51;
            this.dgvMaterias.RowTemplate.Height = 24;
            this.dgvMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterias.Size = new System.Drawing.Size(679, 312);
            this.dgvMaterias.TabIndex = 2;
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // desc_materia
            // 
            this.desc_materia.DataPropertyName = "Descripcion";
            this.desc_materia.HeaderText = "Descripcion";
            this.desc_materia.MinimumWidth = 6;
            this.desc_materia.Name = "desc_materia";
            this.desc_materia.ReadOnly = true;
            this.desc_materia.Width = 125;
            // 
            // hs_semanales
            // 
            this.hs_semanales.DataPropertyName = "HSSemanales";
            this.hs_semanales.HeaderText = "Horas Semanales";
            this.hs_semanales.MinimumWidth = 6;
            this.hs_semanales.Name = "hs_semanales";
            this.hs_semanales.ReadOnly = true;
            this.hs_semanales.Width = 125;
            // 
            // hs_totales
            // 
            this.hs_totales.DataPropertyName = "HSTotales";
            this.hs_totales.HeaderText = "Horas Totales";
            this.hs_totales.MinimumWidth = 6;
            this.hs_totales.Name = "hs_totales";
            this.hs_totales.ReadOnly = true;
            this.hs_totales.Width = 125;
            // 
            // ID_Plan
            // 
            this.ID_Plan.DataPropertyName = "IDPlan";
            this.ID_Plan.HeaderText = "ID Plan";
            this.ID_Plan.MinimumWidth = 6;
            this.ID_Plan.Name = "ID_Plan";
            this.ID_Plan.ReadOnly = true;
            this.ID_Plan.Visible = false;
            this.ID_Plan.Width = 125;
            // 
            // NombrePlan
            // 
            this.NombrePlan.HeaderText = "Plan";
            this.NombrePlan.Name = "NombrePlan";
            this.NombrePlan.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNuevo,
            this.tsEditar,
            this.tsEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(153, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // tsNuevo
            // 
            this.tsNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsNuevo.Image")));
            this.tsNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNuevo.Name = "tsNuevo";
            this.tsNuevo.Size = new System.Drawing.Size(46, 22);
            this.tsNuevo.Text = "Nuevo";
            this.tsNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsEditar
            // 
            this.tsEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsEditar.Image")));
            this.tsEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEditar.Name = "tsEditar";
            this.tsEditar.Size = new System.Drawing.Size(41, 22);
            this.tsEditar.Text = "Editar";
            this.tsEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // tsEliminar
            // 
            this.tsEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsEliminar.Image")));
            this.tsEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEliminar.Name = "tsEliminar";
            this.tsEliminar.Size = new System.Drawing.Size(54, 22);
            this.tsEliminar.Text = "Eliminar";
            this.tsEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // Materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 366);
            this.Controls.Add(this.tscMateria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Materias";
            this.Text = "Materias";
            this.Load += new System.EventHandler(this.MateriaForm_Load);
            this.tscMateria.ContentPanel.ResumeLayout(false);
            this.tscMateria.TopToolStripPanel.ResumeLayout(false);
            this.tscMateria.TopToolStripPanel.PerformLayout();
            this.tscMateria.ResumeLayout(false);
            this.tscMateria.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscMateria;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button Actualizar;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsNuevo;
        private System.Windows.Forms.ToolStripButton tsEditar;
        private System.Windows.Forms.ToolStripButton tsEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn hs_semanales;
        private System.Windows.Forms.DataGridViewTextBoxColumn hs_totales;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Plan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePlan;
    }
}