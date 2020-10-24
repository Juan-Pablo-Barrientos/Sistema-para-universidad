<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cursos.aspx.cs" Inherits="UI.Web.Cursos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="gridPanel" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"
            SelectedRowStyle-BackColor="Black"
            SelectedRowStyle-ForeColor="White"
            DataKeyNames="ID" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:BoundField HeaderText="Id" DataField="Id" />
                <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
                <asp:BoundField HeaderText="Cupo" DataField="Cupo" />
                <asp:BoundField HeaderText="Año Calendario" DataField="AnioCalendario" />
                <asp:BoundField HeaderText="Id Comision" DataField="IDComision" />
                <asp:TemplateField HeaderText="Descripcion Comision">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text=''></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text=''></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField HeaderText="Id Materia" DataField="IDMateria" />
                <asp:TemplateField HeaderText="Descripcion Materia">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text=''></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text=''></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField HeaderText="Seleccionar" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    </asp:Panel>
    <asp:Panel ID="formPanel" Visible="false" runat="server" Height="208px" Width="454px">
        <asp:Label ID="IdLabel" runat="server" Text="Id: "></asp:Label>
        <asp:TextBox ID="IdTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="DescripcionLabel" runat="server" Text="Descripcion: "></asp:Label>
        <asp:TextBox ID="DescripcionTextBox" runat="server" Width="452px"></asp:TextBox>
        <br />
        <asp:Label ID="CupoLabel" runat="server" Text="Cupo: "></asp:Label>
        <asp:TextBox ID="CupoTextBox" runat="server" Width="452px"></asp:TextBox>
        <br />
        <asp:Label ID="AnioCalendarioLabel" runat="server" Text="Año calendario: "></asp:Label>
        <asp:DropDownList ID="AnioDdl" runat="server"></asp:DropDownList>
        <br />
        Comision:
        <asp:DropDownList ID="idComisionDdl" runat="server">
        </asp:DropDownList>
        <br />
        Materia:
        <asp:DropDownList ID="idMateriaDdl" runat="server">
        </asp:DropDownList>
        <br />
        <asp:Panel ID="formActionsPanel" runat="server">
            <asp:LinkButton ID="aceptarLinkButton" runat="server" OnClick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
            <asp:LinkButton ID="cancelarLinkButton" runat="server" OnClick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
        </asp:Panel>
    </asp:Panel>
    <asp:Panel ID="gridActionsPanel" runat="server" Height="18px" Width="154px">
        <asp:LinkButton ID="editarLinkButton" runat="server" OnClick="editarLinkButton_Click">Editar</asp:LinkButton>
        <asp:LinkButton ID="eliminarLinkButton" runat="server" OnClick="eliminarLinkButton_Click">Eliminar</asp:LinkButton>
        <asp:LinkButton ID="nuevoLinkButton" runat="server" OnClick="nuevoLinkButton_Click">Nuevo</asp:LinkButton>
    </asp:Panel>

<html >
    <head>
        <title>Cursos</title>
    </head>
    <body>
        
    </body>
</html>
</asp:Content>