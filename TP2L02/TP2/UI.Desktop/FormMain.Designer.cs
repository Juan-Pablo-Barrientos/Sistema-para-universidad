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
            this.EspecialidadesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.especialidadlistadoMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.especialidadaltaMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ModulosMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoModulo = new System.Windows.Forms.ToolStripMenuItem();
            this.altaModulo = new System.Windows.Forms.ToolStripMenuItem();
            this.PlanesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoPlanes = new System.Windows.Forms.ToolStripMenuItem();
            this.altaPlanes = new System.Windows.Forms.ToolStripMenuItem();
            this.ComisionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuarioLogeado = new System.Windows.Forms.TextBox();
            this.InscribirseMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MisCursosAlumnoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MisCursosDocenteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.InscribirUsuarioMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.docenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDocenteCurso = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDocenteCurso = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaAlumnoInscripcion = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoAlumnoInscripcion = new System.Windows.Forms.ToolStripMenuItem();
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
            this.EspecialidadesMenu,
            this.ModulosMenu,
            this.PlanesMenu,
            this.ComisionMenu,
            this.InscribirUsuarioMenu,
            this.InscribirseMenu,
            this.MisCursosAlumnoMenu,
            this.MisCursosDocenteMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(855, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ArchivoMenu
            // 
            this.ArchivoMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem});
            this.ArchivoMenu.Name = "ArchivoMenu";
            this.ArchivoMenu.Size = new System.Drawing.Size(60, 20);
            this.ArchivoMenu.Text = "Archivo";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // MateriasMenu
            // 
            this.MateriasMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materiaListadoMenu,
            this.materiaAltaMenu});
            this.MateriasMenu.Name = "MateriasMenu";
            this.MateriasMenu.Size = new System.Drawing.Size(64, 20);
            this.MateriasMenu.Text = "Materias";
            // 
            // materiaListadoMenu
            // 
            this.materiaListadoMenu.Name = "materiaListadoMenu";
            this.materiaListadoMenu.Size = new System.Drawing.Size(180, 22);
            this.materiaListadoMenu.Text = "Listado";
            this.materiaListadoMenu.Click += new System.EventHandler(this.materialistadomenu_Click);
            // 
            // materiaAltaMenu
            // 
            this.materiaAltaMenu.Name = "materiaAltaMenu";
            this.materiaAltaMenu.Size = new System.Drawing.Size(180, 22);
            this.materiaAltaMenu.Text = "Alta";
            this.materiaAltaMenu.Click += new System.EventHandler(this.materiaAltaMenu_Click);
            // 
            // UsuariosMenu
            // 
            this.UsuariosMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioListadoMenu,
            this.usuariosAltaMenu});
            this.UsuariosMenu.Name = "UsuariosMenu";
            this.UsuariosMenu.Size = new System.Drawing.Size(64, 20);
            this.UsuariosMenu.Text = "Usuarios";
            // 
            // usuarioListadoMenu
            // 
            this.usuarioListadoMenu.Name = "usuarioListadoMenu";
            this.usuarioListadoMenu.Size = new System.Drawing.Size(180, 22);
            this.usuarioListadoMenu.Text = "Listado";
            this.usuarioListadoMenu.Click += new System.EventHandler(this.usuarioListadoMenu_Click);
            // 
            // usuariosAltaMenu
            // 
            this.usuariosAltaMenu.Name = "usuariosAltaMenu";
            this.usuariosAltaMenu.Size = new System.Drawing.Size(180, 22);
            this.usuariosAltaMenu.Text = "Alta";
            this.usuariosAltaMenu.Click += new System.EventHandler(this.usuariosAltaMenu_Click);
            // 
            // EspecialidadesMenu
            // 
            this.EspecialidadesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.especialidadlistadoMenuStrip,
            this.especialidadaltaMenuStrip});
            this.EspecialidadesMenu.Name = "EspecialidadesMenu";
            this.EspecialidadesMenu.Size = new System.Drawing.Size(95, 20);
            this.EspecialidadesMenu.Text = "Especialidades";
            // 
            // especialidadlistadoMenuStrip
            // 
            this.especialidadlistadoMenuStrip.Name = "especialidadlistadoMenuStrip";
            this.especialidadlistadoMenuStrip.Size = new System.Drawing.Size(180, 22);
            this.especialidadlistadoMenuStrip.Text = "Listado";
            this.especialidadlistadoMenuStrip.Click += new System.EventHandler(this.especialidadlistadoMenuStrip_Click);
            // 
            // especialidadaltaMenuStrip
            // 
            this.especialidadaltaMenuStrip.Name = "especialidadaltaMenuStrip";
            this.especialidadaltaMenuStrip.Size = new System.Drawing.Size(180, 22);
            this.especialidadaltaMenuStrip.Text = "Alta";
            this.especialidadaltaMenuStrip.Click += new System.EventHandler(this.especialidadaltaMenuStrip_Click);
            // 
            // ModulosMenu
            // 
            this.ModulosMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoModulo,
            this.altaModulo});
            this.ModulosMenu.Name = "ModulosMenu";
            this.ModulosMenu.Size = new System.Drawing.Size(66, 20);
            this.ModulosMenu.Text = "Modulos";
            // 
            // listadoModulo
            // 
            this.listadoModulo.Name = "listadoModulo";
            this.listadoModulo.Size = new System.Drawing.Size(180, 22);
            this.listadoModulo.Text = "Listado";
            this.listadoModulo.Click += new System.EventHandler(this.listadoModulo_Click);
            // 
            // altaModulo
            // 
            this.altaModulo.Name = "altaModulo";
            this.altaModulo.Size = new System.Drawing.Size(180, 22);
            this.altaModulo.Text = "Alta";
            this.altaModulo.Click += new System.EventHandler(this.altaModulo_Click);
            // 
            // PlanesMenu
            // 
            this.PlanesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoPlanes,
            this.altaPlanes});
            this.PlanesMenu.Name = "PlanesMenu";
            this.PlanesMenu.Size = new System.Drawing.Size(53, 20);
            this.PlanesMenu.Text = "Planes";
            // 
            // listadoPlanes
            // 
            this.listadoPlanes.Name = "listadoPlanes";
            this.listadoPlanes.Size = new System.Drawing.Size(180, 22);
            this.listadoPlanes.Text = "Listado";
            this.listadoPlanes.Click += new System.EventHandler(this.listadoPlanes_Click);
            // 
            // altaPlanes
            // 
            this.altaPlanes.Name = "altaPlanes";
            this.altaPlanes.Size = new System.Drawing.Size(180, 22);
            this.altaPlanes.Text = "Alta";
            this.altaPlanes.Click += new System.EventHandler(this.altaPlanes_Click);
            // 
            // ComisionMenu
            // 
            this.ComisionMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoToolStripMenuItem,
            this.altaToolStripMenuItem});
            this.ComisionMenu.Name = "ComisionMenu";
            this.ComisionMenu.Size = new System.Drawing.Size(70, 20);
            this.ComisionMenu.Text = "Comision";
            // 
            // listadoToolStripMenuItem
            // 
            this.listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            this.listadoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listadoToolStripMenuItem.Text = "Listado";
            this.listadoToolStripMenuItem.Click += new System.EventHandler(this.listadoToolStripMenuItem_Click);
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaToolStripMenuItem.Text = "Alta";
            this.altaToolStripMenuItem.Click += new System.EventHandler(this.altaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario :";
            // 
            // txtUsuarioLogeado
            // 
            this.txtUsuarioLogeado.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtUsuarioLogeado.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtUsuarioLogeado.Location = new System.Drawing.Point(67, 334);
            this.txtUsuarioLogeado.Name = "txtUsuarioLogeado";
            this.txtUsuarioLogeado.ReadOnly = true;
            this.txtUsuarioLogeado.Size = new System.Drawing.Size(100, 20);
            this.txtUsuarioLogeado.TabIndex = 3;
            // 
            // InscribirseMenu
            // 
            this.InscribirseMenu.Name = "InscribirseMenu";
            this.InscribirseMenu.Size = new System.Drawing.Size(72, 20);
            this.InscribirseMenu.Text = "Inscribirse";
            this.InscribirseMenu.Click += new System.EventHandler(this.InscribirseMenu_Click);
            // 
            // MisCursosAlumnoMenu
            // 
            this.MisCursosAlumnoMenu.Name = "MisCursosAlumnoMenu";
            this.MisCursosAlumnoMenu.Size = new System.Drawing.Size(77, 20);
            this.MisCursosAlumnoMenu.Text = "Mis Cursos";
            this.MisCursosAlumnoMenu.Click += new System.EventHandler(this.MisCursosAlumnoMenu_Click);
            // 
            // MisCursosDocenteMenu
            // 
            this.MisCursosDocenteMenu.Name = "MisCursosDocenteMenu";
            this.MisCursosDocenteMenu.Size = new System.Drawing.Size(77, 20);
            this.MisCursosDocenteMenu.Text = "Mis Cursos";
            this.MisCursosDocenteMenu.Click += new System.EventHandler(this.MisCursosDocenteMenu_Click);
            // 
            // InscribirUsuarioMenu
            // 
            this.InscribirUsuarioMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.docenteToolStripMenuItem,
            this.alumnoToolStripMenuItem});
            this.InscribirUsuarioMenu.Name = "InscribirUsuarioMenu";
            this.InscribirUsuarioMenu.Size = new System.Drawing.Size(103, 20);
            this.InscribirUsuarioMenu.Text = "Inscribir usuario";
            // 
            // docenteToolStripMenuItem
            // 
            this.docenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDocenteCurso,
            this.listadoDocenteCurso});
            this.docenteToolStripMenuItem.Name = "docenteToolStripMenuItem";
            this.docenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.docenteToolStripMenuItem.Text = "Docente";
            // 
            // altaDocenteCurso
            // 
            this.altaDocenteCurso.Name = "altaDocenteCurso";
            this.altaDocenteCurso.Size = new System.Drawing.Size(180, 22);
            this.altaDocenteCurso.Text = "Alta";
            this.altaDocenteCurso.Click += new System.EventHandler(this.altaDocenteCurso_Click);
            // 
            // listadoDocenteCurso
            // 
            this.listadoDocenteCurso.Name = "listadoDocenteCurso";
            this.listadoDocenteCurso.Size = new System.Drawing.Size(180, 22);
            this.listadoDocenteCurso.Text = "Listado";
            this.listadoDocenteCurso.Click += new System.EventHandler(this.listadoDocenteCurso_Click);
            // 
            // alumnoToolStripMenuItem
            // 
            this.alumnoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaAlumnoInscripcion,
            this.listadoAlumnoInscripcion});
            this.alumnoToolStripMenuItem.Name = "alumnoToolStripMenuItem";
            this.alumnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alumnoToolStripMenuItem.Text = "Alumno";
            // 
            // altaAlumnoInscripcion
            // 
            this.altaAlumnoInscripcion.Name = "altaAlumnoInscripcion";
            this.altaAlumnoInscripcion.Size = new System.Drawing.Size(180, 22);
            this.altaAlumnoInscripcion.Text = "Alta";
            this.altaAlumnoInscripcion.Click += new System.EventHandler(this.altaAlumnoInscripcion_Click);
            // 
            // listadoAlumnoInscripcion
            // 
            this.listadoAlumnoInscripcion.Name = "listadoAlumnoInscripcion";
            this.listadoAlumnoInscripcion.Size = new System.Drawing.Size(180, 22);
            this.listadoAlumnoInscripcion.Text = "Listado";
            this.listadoAlumnoInscripcion.Click += new System.EventHandler(this.listadoAlumnoInscripcion_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(855, 366);
            this.Controls.Add(this.txtUsuarioLogeado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
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
        private System.Windows.Forms.ToolStripMenuItem EspecialidadesMenu;
        private System.Windows.Forms.ToolStripMenuItem especialidadlistadoMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem especialidadaltaMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ModulosMenu;
        private System.Windows.Forms.ToolStripMenuItem listadoModulo;
        private System.Windows.Forms.ToolStripMenuItem altaModulo;
        private System.Windows.Forms.ToolStripMenuItem PlanesMenu;
        private System.Windows.Forms.ToolStripMenuItem listadoPlanes;
        private System.Windows.Forms.ToolStripMenuItem altaPlanes;
        private System.Windows.Forms.ToolStripMenuItem ComisionMenu;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuarioLogeado;
        private System.Windows.Forms.ToolStripMenuItem InscribirseMenu;
        private System.Windows.Forms.ToolStripMenuItem MisCursosAlumnoMenu;
        private System.Windows.Forms.ToolStripMenuItem MisCursosDocenteMenu;
        private System.Windows.Forms.ToolStripMenuItem InscribirUsuarioMenu;
        private System.Windows.Forms.ToolStripMenuItem docenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDocenteCurso;
        private System.Windows.Forms.ToolStripMenuItem listadoDocenteCurso;
        private System.Windows.Forms.ToolStripMenuItem alumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaAlumnoInscripcion;
        private System.Windows.Forms.ToolStripMenuItem listadoAlumnoInscripcion;
    }
}