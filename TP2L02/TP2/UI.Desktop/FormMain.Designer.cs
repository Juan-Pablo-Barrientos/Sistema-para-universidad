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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ArchivoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MateriasMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.UsuariosMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchivoMenu,
            this.MateriasMenu,
            this.UsuariosMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ArchivoMenu
            // 
            this.ArchivoMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem});
            this.ArchivoMenu.Name = "ArchivoMenu";
            this.ArchivoMenu.Size = new System.Drawing.Size(73, 24);
            this.ArchivoMenu.Text = "Archivo";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // MateriasMenu
            // 
            this.MateriasMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoToolStripMenuItem1,
            this.altaToolStripMenuItem1});
            this.MateriasMenu.Name = "MateriasMenu";
            this.MateriasMenu.Size = new System.Drawing.Size(80, 24);
            this.MateriasMenu.Text = "Materias";
            this.MateriasMenu.Click += new System.EventHandler(this.materiasToolStripMenuItem_Click);
            // 
            // listadoToolStripMenuItem1
            // 
            this.listadoToolStripMenuItem1.Name = "listadoToolStripMenuItem1";
            this.listadoToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.listadoToolStripMenuItem1.Text = "Listado";
            // 
            // altaToolStripMenuItem1
            // 
            this.altaToolStripMenuItem1.Name = "altaToolStripMenuItem1";
            this.altaToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.altaToolStripMenuItem1.Text = "Alta";
            // 
            // UsuariosMenu
            // 
            this.UsuariosMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoToolStripMenuItem,
            this.altaToolStripMenuItem});
            this.UsuariosMenu.Name = "UsuariosMenu";
            this.UsuariosMenu.Size = new System.Drawing.Size(79, 24);
            this.UsuariosMenu.Text = "Usuarios";
            // 
            // listadoToolStripMenuItem
            // 
            this.listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            this.listadoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listadoToolStripMenuItem.Text = "Listado";
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.altaToolStripMenuItem.Text = "Alta";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Academia";
            this.Load += new System.EventHandler(this.FormMain_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ArchivoMenu;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MateriasMenu;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem UsuariosMenu;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
    }
}