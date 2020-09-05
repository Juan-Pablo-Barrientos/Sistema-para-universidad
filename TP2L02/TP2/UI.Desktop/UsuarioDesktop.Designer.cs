namespace UI.Desktop
{
    partial class UsuarioDesktop
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
            this.nombre = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.chkHabilitado = new System.Windows.Forms.CheckBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.usuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labeltelefono = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.labeltipo = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.clave = new System.Windows.Forms.Label();
            this.confirmar = new System.Windows.Forms.Label();
            this.txtConfirmarClave = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelFec = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.cBTipoDeUsuario = new System.Windows.Forms.ComboBox();
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.ColumnCount = 4;
            this.container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.container.Controls.Add(this.nombre, 0, 1);
            this.container.Controls.Add(this.id, 0, 0);
            this.container.Controls.Add(this.chkHabilitado, 2, 0);
            this.container.Controls.Add(this.txtID, 1, 0);
            this.container.Controls.Add(this.txtNombre, 1, 1);
            this.container.Controls.Add(this.usuario, 2, 2);
            this.container.Controls.Add(this.label3, 0, 5);
            this.container.Controls.Add(this.labeltelefono, 2, 5);
            this.container.Controls.Add(this.btnAceptar, 2, 7);
            this.container.Controls.Add(this.btnCancelar, 3, 7);
            this.container.Controls.Add(this.labeltipo, 0, 6);
            this.container.Controls.Add(this.txtDireccion, 1, 5);
            this.container.Controls.Add(this.txtTelefono, 3, 5);
            this.container.Controls.Add(this.clave, 2, 3);
            this.container.Controls.Add(this.confirmar, 2, 4);
            this.container.Controls.Add(this.txtConfirmarClave, 3, 4);
            this.container.Controls.Add(this.txtClave, 3, 3);
            this.container.Controls.Add(this.email, 2, 1);
            this.container.Controls.Add(this.apellido, 0, 2);
            this.container.Controls.Add(this.txtApellido, 1, 2);
            this.container.Controls.Add(this.txtEmail, 3, 1);
            this.container.Controls.Add(this.txtFec, 1, 4);
            this.container.Controls.Add(this.label2, 0, 3);
            this.container.Controls.Add(this.labelFec, 0, 4);
            this.container.Controls.Add(this.txtLegajo, 1, 3);
            this.container.Controls.Add(this.txtUsuario, 3, 2);
            this.container.Controls.Add(this.cBTipoDeUsuario, 1, 6);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.RowCount = 8;
            this.container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.container.Size = new System.Drawing.Size(448, 231);
            this.container.TabIndex = 0;
            // 
            // nombre
            // 
            this.nombre.AutoEllipsis = true;
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(3, 28);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(44, 13);
            this.nombre.TabIndex = 0;
            this.nombre.Text = "Nombre";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(3, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(18, 13);
            this.id.TabIndex = 1;
            this.id.Text = "ID";
            // 
            // chkHabilitado
            // 
            this.chkHabilitado.AutoSize = true;
            this.chkHabilitado.Location = new System.Drawing.Point(221, 3);
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.Size = new System.Drawing.Size(73, 17);
            this.chkHabilitado.TabIndex = 8;
            this.chkHabilitado.Text = "Habilitado";
            this.chkHabilitado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.chkHabilitado.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtID.Location = new System.Drawing.Point(115, 3);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombre.Location = new System.Drawing.Point(115, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 11;
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Location = new System.Drawing.Point(221, 56);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(43, 13);
            this.usuario.TabIndex = 6;
            this.usuario.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Direccion";
            // 
            // labeltelefono
            // 
            this.labeltelefono.AutoSize = true;
            this.labeltelefono.Location = new System.Drawing.Point(221, 140);
            this.labeltelefono.Name = "labeltelefono";
            this.labeltelefono.Size = new System.Drawing.Size(49, 13);
            this.labeltelefono.TabIndex = 23;
            this.labeltelefono.Text = "Telefono";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(221, 199);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 18;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(308, 199);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // labeltipo
            // 
            this.labeltipo.AutoSize = true;
            this.labeltipo.Location = new System.Drawing.Point(3, 168);
            this.labeltipo.Name = "labeltipo";
            this.labeltipo.Size = new System.Drawing.Size(80, 13);
            this.labeltipo.TabIndex = 19;
            this.labeltipo.Text = "Tipo de usuario";
            this.labeltipo.Click += new System.EventHandler(this.labellegajo_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(115, 143);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 27;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTelefono.Location = new System.Drawing.Point(308, 143);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(272, 20);
            this.txtTelefono.TabIndex = 28;
            // 
            // clave
            // 
            this.clave.AutoSize = true;
            this.clave.Location = new System.Drawing.Point(221, 84);
            this.clave.Name = "clave";
            this.clave.Size = new System.Drawing.Size(34, 13);
            this.clave.TabIndex = 3;
            this.clave.Text = "Clave";
            // 
            // confirmar
            // 
            this.confirmar.AutoSize = true;
            this.confirmar.Location = new System.Drawing.Point(221, 112);
            this.confirmar.Name = "confirmar";
            this.confirmar.Size = new System.Drawing.Size(81, 13);
            this.confirmar.TabIndex = 7;
            this.confirmar.Text = "Confirmar Clave";
            // 
            // txtConfirmarClave
            // 
            this.txtConfirmarClave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConfirmarClave.Location = new System.Drawing.Point(308, 115);
            this.txtConfirmarClave.Name = "txtConfirmarClave";
            this.txtConfirmarClave.Size = new System.Drawing.Size(272, 20);
            this.txtConfirmarClave.TabIndex = 16;
            // 
            // txtClave
            // 
            this.txtClave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtClave.Location = new System.Drawing.Point(308, 87);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(272, 20);
            this.txtClave.TabIndex = 15;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(221, 28);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(32, 13);
            this.email.TabIndex = 2;
            this.email.Text = "Email";
            // 
            // apellido
            // 
            this.apellido.AutoSize = true;
            this.apellido.Location = new System.Drawing.Point(3, 56);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(44, 13);
            this.apellido.TabIndex = 5;
            this.apellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(115, 59);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmail.Location = new System.Drawing.Point(308, 31);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(272, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // txtFec
            // 
            this.txtFec.Location = new System.Drawing.Point(115, 115);
            this.txtFec.Name = "txtFec";
            this.txtFec.Size = new System.Drawing.Size(100, 20);
            this.txtFec.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Legajo";
            // 
            // labelFec
            // 
            this.labelFec.AutoSize = true;
            this.labelFec.Location = new System.Drawing.Point(3, 112);
            this.labelFec.Name = "labelFec";
            this.labelFec.Size = new System.Drawing.Size(106, 13);
            this.labelFec.TabIndex = 22;
            this.labelFec.Text = "Fecha de nacimiento";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(115, 87);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(100, 20);
            this.txtLegajo.TabIndex = 29;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsuario.Location = new System.Drawing.Point(308, 59);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(272, 20);
            this.txtUsuario.TabIndex = 14;
            // 
            // cBTipoDeUsuario
            // 
            this.cBTipoDeUsuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cBTipoDeUsuario.FormattingEnabled = true;
            this.cBTipoDeUsuario.Items.AddRange(new object[] {
            "Alumno",
            "Docente",
            "Admin"});
            this.cBTipoDeUsuario.Location = new System.Drawing.Point(115, 171);
            this.cBTipoDeUsuario.Name = "cBTipoDeUsuario";
            this.cBTipoDeUsuario.Size = new System.Drawing.Size(100, 21);
            this.cBTipoDeUsuario.TabIndex = 30;
            // 
            // UsuarioDesktop
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(448, 231);
            this.Controls.Add(this.container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "UsuarioDesktop";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.UsuarioDesktop_Load);
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel container;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label clave;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label apellido;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.Label confirmar;
        private System.Windows.Forms.CheckBox chkHabilitado;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtConfirmarClave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labeltelefono;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label labeltipo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtFec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelFec;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.ComboBox cBTipoDeUsuario;
    }
}