<%@ Page Title="Ranking" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ranking.aspx.cs" Inherits="WebApplication1.ranking" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="auto-style1"> Ranking</h1>
                <asp:DataList ID="DataList2" runat="server" BackColor="Black" DataKeyField="usuario" DataSourceID="datosRanking2" ForeColor="#FF3300" Width="385px" Align="center">
	                <ItemTemplate>
	                    puntuacion:
	                    <asp:Label ID="puntuacionLabel" runat="server" Text='<%# Eval("puntuacion") %>' />
	                          
	                    <br />
                        usuario:
	                          
	                    <asp:Label ID="usuarioLabel" runat="server" Text='<%# Eval("usuario") %>' />
				        <br />
                        <br />
				    </ItemTemplate>
                </asp:DataList>
	<asp:SqlDataSource ID="datosRanking2" runat="server" ConnectionString="<%$ ConnectionStrings:database %>" SelectCommand="SELECT usuario, puntuacion, fecha FROM ranking ORDER BY puntuacion"></asp:SqlDataSource>
    <asp:SqlDataSource ID="datosranking" runat="server"></asp:SqlDataSource>
	<asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:database %>" SelectCommand="SELECT [puntuacion], [usuario] FROM [ranking] ORDER BY [puntuacion] DESC"></asp:SqlDataSource>
	<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database.mdf;Initial Catalog=database;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [ranking]"></asp:SqlDataSource>
	//necesario para el orden del ranking
                </asp:Content>
