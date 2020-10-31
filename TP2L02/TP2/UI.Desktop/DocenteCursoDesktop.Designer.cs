namespace UI.Desktop
{
    partial class DocCurDesktop
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
            this.cBCurso = new System.Windows.Forms.ComboBox();
            this.cBCargo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdDocenteCurso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cBDocente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.ColumnCount = 4;
            this.container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.container.Controls.Add(this.cBCurso, 1, 1);
            this.container.Controls.Add(this.cBCargo, 3, 1);
            this.container.Controls.Add(this.label1, 0, 1);
            this.container.Controls.Add(this.txtIdDocenteCurso, 1, 0);
            this.container.Controls.Add(this.label2, 0, 0);
            this.container.Controls.Add(this.label3, 2, 0);
            this.container.Controls.Add(this.cBDocente, 3, 0);
            this.container.Controls.Add(this.label4, 2, 1);
            this.container.Controls.Add(this.btnCancelar, 3, 2);
            this.container.Controls.Add(this.btnAceptar, 2, 2);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Margin = new System.Windows.Forms.Padding(4);
            this.container.Name = "container";
            this.container.RowCount = 1;
            this.container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.container.Size = new System.Drawing.Size(667, 116);
            this.container.TabIndex = 0;
            // 
            // cBCurso
            // 
            this.cBCurso.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cBCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBCurso.FormattingEnabled = true;
            this.cBCurso.Location = new System.Drawing.Point(129, 42);
            this.cBCurso.Margin = new System.Windows.Forms.Padding(4);
            this.cBCurso.Name = "cBCurso";
            this.cBCurso.Size = new System.Drawing.Size(200, 24);
            this.cBCurso.TabIndex = 5;
            // 
            // cBCargo
            // 
            this.cBCargo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cBCargo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBCargo.FormattingEnabled = true;
            this.cBCargo.Items.AddRange(new object[] {
            "Docente",
            "Jefecatedra",
            "Auxiliar"});
            this.cBCargo.Location = new System.Drawing.Point(462, 42);
            this.cBCargo.Margin = new System.Windows.Forms.Padding(4);
            this.cBCargo.Name = "cBCargo";
            this.cBCargo.Size = new System.Drawing.Size(201, 24);
            this.cBCargo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Curso";
            // 
            // txtIdDocenteCurso
            // 
            this.txtIdDocenteCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIdDocenteCurso.Location = new System.Drawing.Point(129, 4);
            this.txtIdDocenteCurso.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdDocenteCurso.Name = "txtIdDocenteCurso";
            this.txtIdDocenteCurso.ReadOnly = true;
            this.txtIdDocenteCurso.Size = new System.Drawing.Size(200, 22);
            this.txtIdDocenteCurso.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Dictado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Docente";
            // 
            // cBDocente
            // 
            this.cBDocente.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cBDocente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBDocente.FormattingEnabled = true;
            this.cBDocente.Location = new System.Drawing.Point(462, 4);
            this.cBDocente.Margin = new System.Windows.Forms.Padding(4);
            this.cBDocente.Name = "cBDocente";
            this.cBDocente.Size = new System.Drawing.Size(201, 24);
            this.cBDocente.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cargo";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(462, 80);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(337, 80);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 28);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // DocCurDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 116);
            this.Controls.Add(this.container);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DocCurDesktop";
            this.Text = "DocenteCursoDesktop";
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel container;
        private System.Windows.Forms.ComboBox cBCurso;
        private System.Windows.Forms.ComboBox cBCargo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdDocenteCurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBDocente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAceptar;
    }
}