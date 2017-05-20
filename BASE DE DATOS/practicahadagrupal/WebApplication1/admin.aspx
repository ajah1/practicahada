<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="WebApplication1.admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <h1>Administrador</h1>
    <div style="text-align: left">
        <table align="left" style="width: 45%; height: 299px;">
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
            <tr>
                <td style="text-align: left; width: 175px">
                    &nbsp;</td>
                <td style="text-align: left; width: 194px">
                    &nbsp;</td>
                <td style="text-align: center; width: 165px">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: left; width: 175px">
                    &nbsp;</td>
                <td style="text-align: left; width: 194px">
                    &nbsp;</td>
                <td style="text-align: center; width: 165px">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: left; width: 175px">
                    <asp:Label ID="Label8" runat="server" BackColor="#3366FF" BorderColor="#FFFF66" Text="Borrar Promocion"></asp:Label>
                </td>
                <td style="text-align: left; width: 194px">
                    &nbsp;</td>
                <td style="text-align: center; width: 165px">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: left; width: 175px">
                    <asp:Label ID="Label2" runat="server" BackColor="#00CC99" Text="ID Promoción: "></asp:Label>
                </td>
                <td style="text-align: left; width: 194px">
                    <asp:TextBox ID="TextBox2" runat="server" Width="198px"></asp:TextBox>
                </td>
                <td style="text-align: center; width: 165px">
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Borrar Promo" Width="158px" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: left; width: 175px">
                    &nbsp;</td>
                <td style="text-align: left; width: 194px">
                    &nbsp;</td>
                <td style="text-align: center; width: 165px">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: left; width: 175px">
                    &nbsp;</td>
                <td style="text-align: left; width: 194px">
                    &nbsp;</td>
                <td style="text-align: center; width: 165px">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: left; width: 175px">
                    <asp:Label ID="Label9" runat="server" BackColor="#3366FF" BorderColor="#FFFF66" Text="Insertar Promocion"></asp:Label>
                </td>
                <td style="text-align: left; width: 194px">
                    &nbsp;</td>
                <td style="text-align: center; width: 165px">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: left; width: 175px; height: 33px;">
                    <asp:Label ID="Label3" runat="server" BackColor="#00CC99" Text="ID Promoción: "></asp:Label>
                </td>
                <td style="text-align: left; width: 194px; height: 33px;">
                    <asp:TextBox ID="TextBox3" runat="server" Width="198px"></asp:TextBox>
                </td>
                <td style="text-align: center; width: 165px; height: 33px;">
                    </td>
                <td style="height: 33px"></td>
            </tr>
            <tr>
                <td style="text-align: left; width: 175px; height: 31px;">
                    <asp:Label ID="Label4" runat="server" BackColor="#00CC99" Text="ID Producto: "></asp:Label>
                </td>
                <td style="text-align: left; width: 194px; height: 31px;">
                    <asp:TextBox ID="TextBox4" runat="server" Width="198px"></asp:TextBox>
                </td>
                <td style="text-align: center; width: 165px; height: 31px;">
                    </td>
                <td style="height: 31px"></td>
            </tr>
            <tr>
                <td style="text-align: left; width: 175px; height: 30px;">
                    <asp:Label ID="Label5" runat="server" BackColor="#00CC99" Text="Descuento: "></asp:Label>
                </td>
                <td style="text-align: left; width: 194px; height: 30px;">
                    <asp:TextBox ID="TextBox5" runat="server" Width="198px"></asp:TextBox>
                </td>
                <td style="text-align: center; width: 165px; height: 30px;">
                    </td>
                <td style="height: 30px"></td>
            </tr>
            <tr>
                <td style="text-align: left; width: 175px; height: 31px;">
                    <asp:Label ID="Label6" runat="server" BackColor="#00CC99" Text="F_ini: "></asp:Label>
                </td>
                <td style="text-align: left; width: 194px; height: 31px;">
                    <asp:TextBox ID="TextBox6" runat="server" Width="198px"></asp:TextBox>
                </td>
                <td style="text-align: center; width: 165px; height: 31px;">
                    </td>
                <td style="height: 31px"></td>
            </tr>
            <tr>
                <td style="text-align: left; width: 175px">
                    <asp:Label ID="Label7" runat="server" BackColor="#00CC99" Text="F_fin: "></asp:Label>
                </td>
                <td style="text-align: left; width: 194px">
                    <asp:TextBox ID="TextBox7" runat="server" Width="198px"></asp:TextBox>
                </td>
                <td style="text-align: center; width: 165px">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: left; width: 175px">
                    &nbsp;</td>
                <td style="text-align: left; width: 194px">
                    &nbsp;</td>
                <td style="text-align: center; width: 165px">
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Crear Promo" Width="160px" />
                </td>
                <td>&nbsp;</td>
            </tr>
            </table>
        <div style="text-align: left">
            <asp:DataList ID="DataList2" runat="server" DataKeyField="idpromocion" DataSourceID="SqlDataSource2" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" Align="left">
                <AlternatingItemStyle BackColor="#F7F7F7" />
                <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                <ItemStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                <ItemTemplate>
                    idpromocion:
                    <asp:Label ID="idpromocionLabel" runat="server" Text='<%# Eval("idpromocion") %>' />
                    <br />
                    idproducto:
                    <asp:Label ID="idproductoLabel" runat="server" Text='<%# Eval("idproducto") %>' />
                    <br />
                    descuento:
                    <asp:Label ID="descuentoLabel" runat="server" Text='<%# Eval("descuento") %>' />
                    <br />
                    f_ini:
                    <asp:Label ID="f_iniLabel" runat="server" Text='<%# Eval("f_ini") %>' />
                    <br />
                    f_fin:
                    <asp:Label ID="f_finLabel" runat="server" Text='<%# Eval("f_fin") %>' />
                    <br />
<br />
                </ItemTemplate>
                <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
            </asp:DataList>
        </div>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database.mdf;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [promociones]"></asp:SqlDataSource>
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
