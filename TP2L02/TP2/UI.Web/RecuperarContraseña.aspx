<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="RecuperarContraseña.aspx.cs" Inherits="UI.Web.RecuperarContraseña" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 272px;
        }
        .auto-style2 {
            height: 48px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">
                <asp:Label ID="usuariolbl" runat="server" Text="No hay usuario"></asp:Label>
            </td>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Preguntalbl" runat="server" Text="Pregunta"></asp:Label>
            </td>
            <td>
                <asp:Label ID="preguntalbl2" runat="server" Text="Pregunta"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Respuestalbl" runat="server" Text="Respuesta"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="RespuestaTextBox" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="regresarBtn" runat="server" OnClick="regresarBtn_Click" Text="Regresar" />
            </td>
            <td>
                <asp:Button ID="IngresarBtn" runat="server" OnClick="IngresarBtn_Click" Text="Ingresar" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="nuevaContraseñalbl" runat="server" Text="Nueva contraseña" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="nuevaContraseñaTextBox" runat="server" Visible="False"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="confirmarContraseñalbl" runat="server" Text="Confirmar contraseña" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="confirmarContraseñaTextBox" runat="server" Visible="False"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="ingresarNuevaContraseñaBtn" runat="server" Text="Ingresar" Visible="False" OnClick="ingresarNuevaContraseñaBtn_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
