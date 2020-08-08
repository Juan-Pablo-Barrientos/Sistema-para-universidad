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
            this.materiaListadoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.materiaAltaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.UsuariosMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioListadoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosAltaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.especializacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especialidadlistadoMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.especialidadaltaMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.modulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.altaModulo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchivoMenu,
            this.MateriasMenu,
            this.UsuariosMenu,
            this.especializacionesToolStripMenuItem,
            this.modulosToolStripMenuItem});
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
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // MateriasMenu
            // 
            this.MateriasMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materiaListadoMenu,
            this.materiaAltaMenu});
            this.MateriasMenu.Name = "MateriasMenu";
            this.MateriasMenu.Size = new System.Drawing.Size(80, 24);
            this.MateriasMenu.Text = "Materias";
            this.MateriasMenu.Click += new System.EventHandler(this.materiasToolStripMenuItem_Click);
            // 
            // materiaListadoMenu
            // 
            this.materiaListadoMenu.Name = "materiaListadoMenu";
            this.materiaListadoMenu.Size = new System.Drawing.Size(140, 26);
            this.materiaListadoMenu.Text = "Listado";
            this.materiaListadoMenu.Click += new System.EventHandler(this.materialistadomenu_Click);
            // 
            // materiaAltaMenu
            // 
            this.materiaAltaMenu.Name = "materiaAltaMenu";
            this.materiaAltaMenu.Size = new System.Drawing.Size(140, 26);
            this.materiaAltaMenu.Text = "Alta";
            this.materiaAltaMenu.Click += new System.EventHandler(this.materiaAltaMenu_Click);
            // 
            // UsuariosMenu
            // 
            this.UsuariosMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioListadoMenu,
            this.usuariosAltaMenu});
            this.UsuariosMenu.Name = "UsuariosMenu";
            this.UsuariosMenu.Size = new System.Drawing.Size(79, 24);
            this.UsuariosMenu.Text = "Usuarios";
            // 
            // usuarioListadoMenu
            // 
            this.usuarioListadoMenu.Name = "usuarioListadoMenu";
            this.usuarioListadoMenu.Size = new System.Drawing.Size(140, 26);
            this.usuarioListadoMenu.Text = "Listado";
            this.usuarioListadoMenu.Click += new System.EventHandler(this.usuarioListadoMenu_Click);
            // 
            // usuariosAltaMenu
            // 
            this.usuariosAltaMenu.Name = "usuariosAltaMenu";
            this.usuariosAltaMenu.Size = new System.Drawing.Size(140, 26);
            this.usuariosAltaMenu.Text = "Alta";
            this.usuariosAltaMenu.Click += new System.EventHandler(this.usuariosAltaMenu_Click);
            // 
            // especializacionesToolStripMenuItem
            // 
            this.especializacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.especialidadlistadoMenuStrip,
            this.especialidadaltaMenuStrip});
            this.especializacionesToolStripMenuItem.Name = "especializacionesToolStripMenuItem";
            this.especializacionesToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.especializacionesToolStripMenuItem.Text = "Especialidades";
            // 
            // especialidadlistadoMenuStrip
            // 
            this.especialidadlistadoMenuStrip.Name = "especialidadlistadoMenuStrip";
            this.especialidadlistadoMenuStrip.Size = new System.Drawing.Size(224, 26);
            this.especialidadlistadoMenuStrip.Text = "Listado";
            this.especialidadlistadoMenuStrip.Click += new System.EventHandler(this.especialidadlistadoMenuStrip_Click);
            // 
            // especialidadaltaMenuStrip
            // 
            this.especialidadaltaMenuStrip.Name = "especialidadaltaMenuStrip";
            this.especialidadaltaMenuStrip.Size = new System.Drawing.Size(224, 26);
            this.especialidadaltaMenuStrip.Text = "Alta";
            this.especialidadaltaMenuStrip.Click += new System.EventHandler(this.especialidadaltaMenuStrip_Click);
            // 
            // modulosToolStripMenuItem
            // 
            this.modulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoBtn,
            this.altaModulo});
            this.modulosToolStripMenuItem.Name = "modulosToolStripMenuItem";
            this.modulosToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.modulosToolStripMenuItem.Text = "Modulos";
            // 
            // listadoBtn
            // 
            this.listadoBtn.Name = "listadoBtn";
            this.listadoBtn.Size = new System.Drawing.Size(224, 26);
            this.listadoBtn.Text = "Listado";
            this.listadoBtn.Click += new System.EventHandler(this.listadoBtn_Click);
            // 
            // altaModulo
            // 
            this.altaModulo.Name = "altaModulo";
            this.altaModulo.Size = new System.Drawing.Size(224, 26);
            this.altaModulo.Text = "Alta";
            this.altaModulo.Click += new System.EventHandler(this.altaModulo_Click);
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
            this.Activated += new System.EventHandler(this.FormMain_Activated);
            this.Load += new System.EventHandler(this.FormMainLoad);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
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
        private System.Windows.Forms.ToolStripMenuItem materiaListadoMenu;
        private System.Windows.Forms.ToolStripMenuItem materiaAltaMenu;
        private System.Windows.Forms.ToolStripMenuItem UsuariosMenu;
        private System.Windows.Forms.ToolStripMenuItem usuarioListadoMenu;
        private System.Windows.Forms.ToolStripMenuItem usuariosAltaMenu;
        private System.Windows.Forms.ToolStripMenuItem especializacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especialidadlistadoMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem especialidadaltaMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem modulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoBtn;
        private System.Windows.Forms.ToolStripMenuItem altaModulo;
    }
}