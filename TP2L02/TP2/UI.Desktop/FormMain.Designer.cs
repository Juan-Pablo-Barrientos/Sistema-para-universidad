namespace UI.Desktop
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbUsuarios = new System.Windows.Forms.ToolStripButton();
            this.tsbMaterias = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbUsuarios,
            this.tsbMaterias});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbUsuarios
            // 
            this.tsbUsuarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("tsbUsuarios.Image")));
            this.tsbUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUsuarios.Name = "tsbUsuarios";
            this.tsbUsuarios.Size = new System.Drawing.Size(69, 24);
            this.tsbUsuarios.Text = "Usuarios";
            this.tsbUsuarios.Click += new System.EventHandler(this.tsbUsuarios_Click);
            // 
            // tsbMaterias
            // 
            this.tsbMaterias.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbMaterias.Image = ((System.Drawing.Image)(resources.GetObject("tsbMaterias.Image")));
            this.tsbMaterias.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMaterias.Name = "tsbMaterias";
            this.tsbMaterias.Size = new System.Drawing.Size(70, 24);
            this.tsbMaterias.Text = "Materias";
            this.tsbMaterias.Click += new System.EventHandler(this.tsbMaterias_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.Text = "Academia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbUsuarios;
        private System.Windows.Forms.ToolStripButton tsbMaterias;
    }
}