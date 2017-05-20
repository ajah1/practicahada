<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="WebApplication1.admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <h1>Administrador</h1>
    <div style="text-align: left">
        <table align="left" style="width: 45%;">
            <tr>
                <td style="text-align: left; width: 175px">
                    <asp:Label ID="Label1" runat="server" Text="Nombre Usuario a Borrar: " BackColor="#66FF66"></asp:Label>
                </td>
                <td style="text-align: left; width: 194px">
                    <asp:TextBox ID="TextBox1" runat="server" Width="200px"></asp:TextBox>
                </td>
                <td style="text-align: center; width: 165px">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Confirmar Borrado" />
                </td>
                <td>&nbsp;</td>
            </tr>
            </table>
        <asp:DataList ID="DataList1" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyField="usuario" DataSourceID="SqlDataSource1" GridLines="Horizontal" Align="center">
            <AlternatingItemStyle BackColor="#F7F7F7" />
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
            <ItemStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
            <ItemTemplate>
                usuario:
                <asp:Label ID="usuarioLabel" runat="server" Text='<%# Eval("usuario") %>' />
                <br />
                contraseña:
                <asp:Label ID="contraseñaLabel" runat="server" Text='<%# Eval("contraseña") %>' />
                <br />
<br />
            </ItemTemplate>
            <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
        </asp:DataList>
    </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database.mdf;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [usuario], [contraseña] FROM [usuario]"></asp:SqlDataSource>
</asp:Content>
