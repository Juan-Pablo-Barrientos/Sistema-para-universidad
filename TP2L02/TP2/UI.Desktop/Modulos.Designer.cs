namespace UI.Desktop
{
    partial class Modulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modulos));
            this.tSModulo = new System.Windows.Forms.ToolStripContainer();
            this.tLModulo = new System.Windows.Forms.TableLayoutPanel();
            this.dgvModulo = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.tSModulo.ContentPanel.SuspendLayout();
            this.tSModulo.TopToolStripPanel.SuspendLayout();
            this.tSModulo.SuspendLayout();
            this.tLModulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModulo)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tSModulo
            // 
            // 
            // tSModulo.ContentPanel
            // 
            this.tSModulo.ContentPanel.Controls.Add(this.tLModulo);
            this.tSModulo.ContentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.tSModulo.ContentPanel.Size = new System.Drawing.Size(600, 341);
            this.tSModulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tSModulo.Location = new System.Drawing.Point(0, 0);
            this.tSModulo.Margin = new System.Windows.Forms.Padding(2);
            this.tSModulo.Name = "tSModulo";
            this.tSModulo.Size = new System.Drawing.Size(600, 366);
            this.tSModulo.TabIndex = 0;
            this.tSModulo.Text = "toolStripContainer1";
            // 
            // tSModulo.TopToolStripPanel
            // 
            this.tSModulo.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // tLModulo
            // 
            this.tLModulo.ColumnCount = 2;
            this.tLModulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLModulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tLModulo.Controls.Add(this.dgvModulo, 0, 0);
            this.tLModulo.Controls.Add(this.btnSalir, 1, 1);
            this.tLModulo.Controls.Add(this.btnActualizar, 0, 1);
            this.tLModulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLModulo.Location = new System.Drawing.Point(0, 0);
            this.tLModulo.Margin = new System.Windows.Forms.Padding(2);
            this.tLModulo.Name = "tLModulo";
            this.tLModulo.RowCount = 2;
            this.tLModulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLModulo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tLModulo.Size = new System.Drawing.Size(600, 341);
            this.tLModulo.TabIndex = 0;
            // 
            // dgvModulo
            // 
            this.dgvModulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModulo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Descripcion});
            this.tLModulo.SetColumnSpan(this.dgvModulo, 2);
            this.dgvModulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvModulo.Location = new System.Drawing.Point(2, 2);
            this.dgvModulo.Margin = new System.Windows.Forms.Padding(2);
            this.dgvModulo.MultiSelect = false;
            this.dgvModulo.Name = "dgvModulo";
            this.dgvModulo.RowHeadersWidth = 51;
            this.dgvModulo.RowTemplate.Height = 24;
            this.dgvModulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModulo.Size = new System.Drawing.Size(596, 314);
            this.dgvModulo.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 125;
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
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(467, 320);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(71, 19);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
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
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(41, 22);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(54, 22);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Modulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tSModulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Modulos";
            this.Text = "Modulos";
            this.Load += new System.EventHandler(this.Modulos_Load);
            this.tSModulo.ContentPanel.ResumeLayout(false);
            this.tSModulo.TopToolStripPanel.ResumeLayout(false);
            this.tSModulo.TopToolStripPanel.PerformLayout();
            this.tSModulo.ResumeLayout(false);
            this.tSModulo.PerformLayout();
            this.tLModulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModulo)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tSModulo;
        private System.Windows.Forms.TableLayoutPanel tLModulo;
        private System.Windows.Forms.DataGridView dgvModulo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
    }
}