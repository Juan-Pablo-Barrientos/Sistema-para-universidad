<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Comisiones.aspx.cs" Inherits="UI.Web.Comisiones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="gridPanel" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"
            SelectedRowStyle-BackColor="Black"
            SelectedRowStyle-ForeColor="White"
            DataKeyNames="ID" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:BoundField HeaderText="Id" DataField="Id" />
                <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
                <asp:BoundField HeaderText="Año Especialidad" DataField="AnioEspecialidad" />
                <asp:BoundField HeaderText="Id plan" DataField="IDPlan" />
                <asp:TemplateField HeaderText="Descripcion plan">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text=''></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text=''></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField HeaderText="Seleccionar" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    </asp:Panel>
    <asp:Panel ID="formPanel" Visible="false" runat="server">
        <asp:Label ID="IdLabel" runat="server" Text="Id: "></asp:Label>
        <asp:TextBox ID="IdTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="DescripcionLabel" runat="server" Text="Descripcion: "></asp:Label>
        <asp:TextBox ID="DescripcionTextBox" runat="server" Width="452px"></asp:TextBox>
        <br />
        <asp:Label ID="AnioEspecialidadLabel" runat="server" Text="Año especialidad: "></asp:Label>
        <asp:DropDownList ID="AnioDdl" runat="server"></asp:DropDownList>
        <br />
        Plan:
        <asp:DropDownList ID="idPlanDdl" runat="server">
        </asp:DropDownList>
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
        <title>Comisiones</title>
    </head>
    <body>
        
    </body>
</html>
</asp:Content>

