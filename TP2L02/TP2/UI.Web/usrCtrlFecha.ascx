<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="usrCtrlFecha.ascx.cs" Inherits="UI.Web.usrCtrlFecha" %>
<asp:Label ID="lblDia" runat="server" Text="Dia"></asp:Label>
<asp:DropDownList ID="ddlDia" runat="server">
</asp:DropDownList>
<asp:Label ID="lblMes" runat="server" Text="Mes"></asp:Label>
<asp:DropDownList ID="ddlMes" runat="server" AutoPostBack="True">
</asp:DropDownList>
<asp:Label ID="lblAnio" runat="server" Text="Año"></asp:Label>
<asp:DropDownList ID="ddlAnio" runat="server" AutoPostBack="True">
</asp:DropDownList>

