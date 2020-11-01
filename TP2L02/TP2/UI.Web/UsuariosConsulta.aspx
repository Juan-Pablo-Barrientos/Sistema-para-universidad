<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UsuariosConsulta.aspx.cs" Inherits="UI.Web.UsuariosConsulta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <table style="width:100%;">
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:TextBox ID="nombreUsuarioTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnConsultar" runat="server" OnClick="btnConsultar_Click" Text="Consultar" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="nombreUsuarioTextBox" ErrorMessage="Escriba un nombre" ForeColor="#0000CC"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Label ID="Label223" runat="server" Text="ID: "></asp:Label>
            </td>
            <td>
                <asp:Label ID="idLabel" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Label ID="label2222" runat="server" Text="Nombre de usuario: "></asp:Label>
            </td>
            <td>
                <asp:Label ID="nombreUsuarioLabel" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Label ID="Label23233" runat="server" Text="Habilitado"></asp:Label>
            </td>
            <td>
                <asp:CheckBox ID="habilitadoCheck" runat="server" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Nombre: "></asp:Label>
            </td>
            <td>
                <asp:Label ID="nombreLabel" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Apellido: "></asp:Label>
            </td>
            <td>
                <asp:Label ID="apellidoLabel" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Email: "></asp:Label>
            </td>
            <td>
                <asp:Label ID="emailLabel" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Tipo de usuario: "></asp:Label>
            </td>
            <td>
                <asp:Label ID="tipoUsrLabel" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Label ID="Label8" runat="server" Text="Legajo: "></asp:Label>
            </td>
            <td>
                <asp:Label ID="legajoLabel" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Label ID="Label9" runat="server" Text="Telefono: "></asp:Label>
            </td>
            <td>
                <asp:Label ID="telefonoLabel" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Label ID="Label10" runat="server" Text="Direccion: "></asp:Label>
            </td>
            <td>
                <asp:Label ID="direccionLabel" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Label ID="Label23234" runat="server" Text="Fecha de Nacimiento: "></asp:Label>
            </td>
            <td>
                <asp:Label ID="fechaNacLabel" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
