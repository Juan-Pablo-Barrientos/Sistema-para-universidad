<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="RecuperarContraseña2.aspx.cs" Inherits="UI.Web.RecuperarContraseña2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="nombreUsuario" runat="server" Text="Nombre de Usuario"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="nombreUsuarioTextBox" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="regresarBtn" runat="server" OnClick="regresarBtn_Click" Text="Regresar" />
            </td>
            <td>
                <asp:Button ID="nextBtn" runat="server" OnClick="nextBtn_Click" Text="Siguiente" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
