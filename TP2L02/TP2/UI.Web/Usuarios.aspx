<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="UI.Web.Usuarios" %>
<%@ Register src="usrCtrlFecha.ascx" tagname="usrCtrlFecha" tagprefix="uc1" %>

    
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <link href="~/CSS/StyleSheet1.css" rel="stylesheet" type="text/css" />

    <asp:Panel ID="gridPanel" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"
            SelectedRowStyle-BackColor="Black"
            SelectedRowStyle-ForeColor="White"
            DataKeyNames="ID" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
                <asp:BoundField HeaderText="EMail" DataField="EMail" />
                <asp:BoundField HeaderText="Usuario" DataField="NombreUsuario" />
                <asp:BoundField HeaderText="Habilitado" DataField="Habilitado" />
                <asp:CommandField HeaderText="Seleccionar" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    </asp:Panel>
    <asp:Panel ID="formPanel" Visible="false" runat="server">
        <asp:Label ID="nombreLabel" runat="server" Text="Nombre: "></asp:Label>
        <asp:TextBox ID="nombreTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="nombreTextBox" Display="None" ErrorMessage="Complete nombre"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="apellidoLabel" runat="server" Text="Apellido: "></asp:Label>
        <asp:TextBox ID="apellidoTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="apellidoTextBox" Display="None" ErrorMessage="Complete apellido"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="emailLabel" runat="server" Text="EMail: "></asp:Label>
        <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="emailTextBox" Display="None" ErrorMessage="Formato de email invalido" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="emailTextBox" Display="None" ErrorMessage="Complete email"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="habilitadoLabel" runat="server" Text="Habilitado: "></asp:Label>
        <asp:CheckBox ID="habilitadoCheckBox" runat="server"></asp:CheckBox>
        <br />
        <asp:Label ID="nombreUsuarioLabel" runat="server" Text="Usuario: "></asp:Label>
        <asp:TextBox ID="nombreUsuarioTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="nombreUsuarioTextBox" Display="None" ErrorMessage="Complete usuario"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="claveLabel" runat="server" Text="Clave: "></asp:Label>
        <asp:TextBox ID="claveTextBox" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="claveTextBox" Display="None" ErrorMessage="La contraseña tiene que tener 8 o mas caracteres y menos de 32" ValidationExpression="^.{8,32}$"></asp:RegularExpressionValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="claveTextBox" Display="None" ErrorMessage="Complete clave"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="repetirClaveLabel" runat="server" Text="Repetir Clave: "></asp:Label>
        <asp:TextBox ID="repetirClaveTextBox" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="claveTextBox" ControlToValidate="repetirClaveTextBox" Display="None" ErrorMessage="La contraseña tiene que coincidir"></asp:CompareValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="repetirClaveTextBox" Display="None" ErrorMessage="Complete repetir contraseña"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="tipo_usuarioLabel" runat="server" Text="Tipo de Usuario: "></asp:Label>
        <asp:DropDownList ID="tipoUsuarioDdl" runat="server">
            <asp:ListItem>Alumno</asp:ListItem>
            <asp:ListItem>Admin</asp:ListItem>
            <asp:ListItem>Docente</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="legajoLabel" runat="server" Text="Legajo: "></asp:Label>
        <asp:TextBox ID="legajoTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="legajoTextBox" Display="None" ErrorMessage="Complete legajo"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="fechaNacLabel" runat="server" Text="Fecha de nacimiento: "></asp:Label>
        <br />
        <uc1:usrCtrlFecha ID="usrCtrlFecha1" runat="server" />
        <br />
        <asp:Label ID="telefonoLabel" runat="server" Text="Telefono: "></asp:Label>
        <asp:TextBox ID="telefonoTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="telefonoTextBox" Display="None" ErrorMessage="Complete telefono"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="direccionLabel" runat="server" Text="Direccion: "></asp:Label>
        <asp:TextBox ID="direccionTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="direccionTextBox" Display="None" ErrorMessage="Complete direccion"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="preguntaContralbl" runat="server" Text="Pregunta para recuperar contraseña"></asp:Label>
        <asp:DropDownList ID="preguntaContraDdl" runat="server" Height="19px" Width="307px">
            <asp:ListItem>Nombre de su primer perro</asp:ListItem>
            <asp:ListItem>Nombre de su ciudad de nacimiento</asp:ListItem>
            <asp:ListItem>Apodo de su infancia</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="respuestaContralbl" runat="server" Text="Respuesta: "></asp:Label>
        <asp:TextBox ID="respuestaContraTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="respuestaContraTextBox" Display="None" ErrorMessage="Complete respuesta"></asp:RequiredFieldValidator>
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
        <br />
        <asp:Panel ID="formActionsPanel" runat="server">
            <asp:LinkButton ID="aceptarLinkButton" runat="server" OnClick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
            <asp:LinkButton ID="cancelarLinkButton" runat="server" OnClick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
        </asp:Panel>
    </asp:Panel>
    <asp:Panel ID="gridActionsPanel" runat="server">
        <asp:LinkButton ID="editarLinkButton" runat="server" OnClick="editarLinkButton_Click">Editar</asp:LinkButton>
        <asp:LinkButton ID="eliminarLinkButton" runat="server" OnClick="eliminarLinkButton_Click">Eliminar</asp:LinkButton>
        <asp:LinkButton ID="nuevoLinkButton" runat="server" OnClick="nuevoLinkButton_Click">Nuevo</asp:LinkButton>
    </asp:Panel>

<html >
    <head>
        <title>Usuarios</title>
    </head>
    <body>
        
    </body>
</html>
</asp:Content>