namespace UI.Desktop
{
    partial class EspecialidadDesktop
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.desc_especialidad = new System.Windows.Forms.Label();
            this.txtIdespecialidades = new System.Windows.Forms.TextBox();
            this.id_especialidad = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.txtDescripcion, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.desc_especialidad, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtIdespecialidades, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.id_especialidad, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(440, 59);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescripcion.Location = new System.Drawing.Point(333, 3);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(104, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(333, 32);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(223, 32);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // desc_especialidad
            // 
            this.desc_especialidad.AutoSize = true;
            this.desc_especialidad.Location = new System.Drawing.Point(223, 0);
            this.desc_especialidad.Name = "desc_especialidad";
            this.desc_especialidad.Size = new System.Drawing.Size(63, 13);
            this.desc_especialidad.TabIndex = 1;
            this.desc_especialidad.Text = "Descripcion";
            // 
            // txtIdespecialidades
            // 
            this.txtIdespecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIdespecialidades.Location = new System.Drawing.Point(113, 3);
            this.txtIdespecialidades.Name = "txtIdespecialidades";
            this.txtIdespecialidades.ReadOnly = true;
            this.txtIdespecialidades.Size = new System.Drawing.Size(104, 20);
            this.txtIdespecialidades.TabIndex = 2;
            // 
            // id_especialidad
            // 
            this.id_especialidad.AutoSize = true;
            this.id_especialidad.Location = new System.Drawing.Point(3, 0);
            this.id_especialidad.Name = "id_especialidad";
            this.id_especialidad.Size = new System.Drawing.Size(93, 13);
            this.id_especialidad.TabIndex = 0;
            this.id_especialidad.Text = "Id de especialidad";
            // 
            // EspecialidadDesktop
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 59);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EspecialidadDesktop";
            this.Text = "EspecialidadDesktop";
            this.Load += new System.EventHandler(this.EspecialidadDesktop_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label id_especialidad;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label desc_especialidad;
        private System.Windows.Forms.TextBox txtIdespecialidades;
    }
}