<%@ Page Title="Ranking" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ranking.aspx.cs" Inherits="WebApplication1.ranking" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<h1 class="auto-style1"> Ranking</h1>
        <h2 class="auto-style2">Puntuación</h2>
            <td style="padding-left: 50px; color:white"> Puntuacion
                <asp:DataList ID="DataList2" runat="server" BackColor="Black" DataKeyField="usuario" DataSourceID="SqlDataSource1" ForeColor="#FF3300" Width="385px" Align="center">
                <ItemTemplate>
                    usuario:
                    <asp:Label ID="usuarioLabel" runat="server" Text='<%# Eval("usuario") %>' />
                          
                    <asp:Label ID="puntuacionLabel" runat="server" Text='<%# Eval("puntuacion") %>' />
                    <br />
                        </ItemTemplate>
                </asp:DataList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Database1ConnectionString %>" SelectCommand="SELECT [puntuacion], [usuario] FROM [ranking] ORDER BY [puntuacion] DESC"></asp:SqlDataSource>
            </td>
 </asp:Content>
