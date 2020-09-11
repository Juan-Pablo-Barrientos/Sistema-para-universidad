<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="UI.Web.Usuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
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
        <br />
        <asp:Label ID="apellidoLabel" runat="server" Text="Apellido: "></asp:Label>
        <asp:TextBox ID="apellidoTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="emailLabel" runat="server" Text="EMail: "></asp:Label>
        <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="habilitadoLabel" runat="server" Text="Habilitado: "></asp:Label>
        <asp:CheckBox ID="habilitadoCheckBox" runat="server"></asp:CheckBox>
        <br />
        <asp:Label ID="nombreUsuarioLabel" runat="server" Text="Usuario: "></asp:Label>
        <asp:TextBox ID="nombreUsuarioTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="claveLabel" runat="server" Text="Clave: "></asp:Label>
        <asp:TextBox ID="claveTextBox" TextMode="Password" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="repetirClaveLabel" runat="server" Text="Repetir Clave: "></asp:Label>
        <asp:TextBox ID="repetirClaveTextBox" TextMode="Password" runat="server"></asp:TextBox>
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
        <br />
        <asp:Label ID="fechaNacLabel" runat="server" Text="Fecha de nacimiento: "></asp:Label>
        <br />
        <asp:Label ID="diaNacLabel" runat="server" Text="Dia: "></asp:Label>
        <asp:DropDownList ID="diaNacDdl" runat="server" >
        </asp:DropDownList>
        <asp:Label ID="mesNacLabel" runat="server" Text="Mes: "></asp:Label>
        <asp:DropDownList ID="mesNacDdl" runat="server" onselectedindexchanged="mesNacDdl_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:Label ID="añoNacLabel" runat="server" Text="Año: "></asp:Label>
        <asp:DropDownList ID="añoNacDdl" runat="server" onselectedindexchanged="añoNacDdl_SelectedIndexChanged"></asp:DropDownList>
        <br />
        <asp:Label ID="telefonoLabel" runat="server" Text="Telefono: "></asp:Label>
        <asp:TextBox ID="telefonoTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="direccionLabel" runat="server" Text="direccion: "></asp:Label>
        <asp:TextBox ID="direccionTextBox" runat="server"></asp:TextBox>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
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