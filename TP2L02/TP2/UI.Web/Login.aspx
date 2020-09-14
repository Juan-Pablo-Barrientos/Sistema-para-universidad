<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UI.Web.Login"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <br />
    <br />
    <table style="width: 100%; height: 186px;">
        <tr>
            <td>
                <asp:Label ID="usuarioLabel" runat="server" Text="Usuario"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="usuarioTextBox" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="contraseñaLabel" runat="server" Text="Contraseña"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="contraseñaTextBox" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 64px">&nbsp;</td>
            <td style="height: 64px">
                <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
            </td>
            <td style="height: 64px"></td>
        </tr>
    </table>
    <br />
    <br />
</asp:Content>
