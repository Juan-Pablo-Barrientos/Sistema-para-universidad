<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AlumnosInscripciones.aspx.cs" Inherits="UI.Web.AlumnosInscripciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="GridPanel" runat="server">    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" />
                <asp:BoundField DataField="IDAlumno" HeaderText="ID Alumno" />
                <asp:BoundField DataField="IDCurso" HeaderText="ID Curso" />
                <asp:BoundField DataField="Condicion" HeaderText="Condicion" />
                <asp:BoundField DataField="Nota" HeaderText="Nota" />
                <asp:TemplateField HeaderText="Alumno"></asp:TemplateField>
                <asp:TemplateField HeaderText="Curso"></asp:TemplateField>
                <asp:CommandField AccessibleHeaderText="Seleccionar" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    </asp:Panel>
     <asp:Panel ID="FormPanel" runat="server"  Visible="False">
   <asp:Label ID="LabelID" runat="server" Text="ID"></asp:Label>
  <asp:TextBox ID="IDtxt" runat="server" Height="16px" Width="92px" ReadOnly="True"></asp:TextBox>
         <br />
<asp:Label ID="LabelAlum" runat="server" Text="Alumno"></asp:Label>
          <asp:DropDownList ID="Alumnoddl" runat="server">
    </asp:DropDownList>
       <br />
    <asp:Label ID="LabelCur" runat="server" Text="Curso"></asp:Label>
  <asp:DropDownList ID="Cursoddl" runat="server">
    </asp:DropDownList>
                <br />
         <asp:Label ID="LabelCond" runat="server" Text="Condicion"></asp:Label>
  <asp:DropDownList ID="Condicionddl" runat="server" AutoPostBack="True" OnTextChanged="Condicionddl_TextChanged">
      <asp:ListItem Value="Inscripto"></asp:ListItem>
      <asp:ListItem Value="Regular"></asp:ListItem>
      <asp:ListItem Value="Aprobado"></asp:ListItem>
      <asp:ListItem Value="Libre"></asp:ListItem>
    </asp:DropDownList>
            <br />
         <asp:Label ID="LabelNota" runat="server" Text="Nota"></asp:Label>
         <asp:DropDownList ID="Notatxt" runat="server">
         </asp:DropDownList>
     <asp:Panel ID="FormActionPanel" runat="server" Height="20px" Width="119px">                
         <asp:LinkButton ID="aceptarLinkButton" runat="server" OnClick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
         <asp:LinkButton ID="cancelarLinkButton" runat="server" OnClick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
     </asp:Panel>
     </asp:Panel>
     <asp:Panel ID="GridActionPanel" runat="server" Height="21px" Width="134px">
         <asp:LinkButton ID="editarLinkButton" runat="server" OnClick="editarLinkButton_Click">Editar</asp:LinkButton>
        <asp:LinkButton ID="eliminarLinkButton" runat="server" OnClick="eliminarLinkButton_Click">Eliminar</asp:LinkButton>
        <asp:LinkButton ID="nuevoLinkButton" runat="server" OnClick="nuevoLinkButton_Click">Nuevo</asp:LinkButton>
    </asp:Panel>
</asp:Content>
