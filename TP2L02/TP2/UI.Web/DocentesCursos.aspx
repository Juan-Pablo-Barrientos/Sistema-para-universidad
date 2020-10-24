<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DocentesCursos.aspx.cs" Inherits="UI.Web.DocentesCursos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="gridPanel" runat="server" >
        <asp:GridView ID="GridView1" runat="server" Width="679px" AutoGenerateColumns="False" Height="141px" DataKeyNames="ID" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"  SelectedRowStyle-BackColor="Black"
            SelectedRowStyle-ForeColor="White">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" />
                <asp:BoundField DataField="IDCurso" HeaderText="ID Curso" />
                <asp:BoundField DataField="IDDocente" HeaderText="ID Docente" />
                <asp:BoundField DataField="Cargo" HeaderText="Cargo" />
                <asp:TemplateField HeaderText="Curso"></asp:TemplateField>
                <asp:TemplateField HeaderText="Docente"></asp:TemplateField>
                <asp:CommandField  HeaderText="Seleccionar" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
     
</asp:Panel>
    <asp:Panel ID="formPanel" runat="server" Height="146px" Width="422px" Visible="False">
        <asp:Label ID="Label1" runat="server" Text="ID :"></asp:Label>
        <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Curso"></asp:Label>
        <br />
        <asp:DropDownList ID="ddlCurso" runat="server">
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Docente"></asp:Label>
        <br />
        <asp:DropDownList ID="ddlDocente" runat="server">
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Cargo"></asp:Label>
        <br />
        <asp:DropDownList ID="ddlCargo" runat="server">
            <asp:ListItem Value="Jefecatedra">Jefecatedra</asp:ListItem>
            <asp:ListItem Value="Auxiliar"></asp:ListItem>
            <asp:ListItem>Docente</asp:ListItem>
        </asp:DropDownList>
        
        <asp:Panel ID="formActionsPanel" runat="server">
            <asp:LinkButton ID="aceptarLinkButton" runat="server" OnClick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
            <asp:LinkButton ID="cancelarLinkButton" runat="server" OnClick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
        </asp:Panel>
        
 </asp:Panel>
    
    <asp:Panel ID="gridActionsPanel" runat="server" Height="16px" Width="205px">
        <asp:LinkButton ID="editarLinkButton" runat="server" OnClick="editarLinkButton_Click">Editar</asp:LinkButton>
        <asp:LinkButton ID="eliminarLinkButton" runat="server" OnClick="eliminarLinkButton_Click">Eliminar</asp:LinkButton>
        <asp:LinkButton ID="nuevoLinkButton" runat="server" OnClick="nuevoLinkButton_Click">Nuevo</asp:LinkButton>
 </asp:Panel>
     
    
</asp:Content>
