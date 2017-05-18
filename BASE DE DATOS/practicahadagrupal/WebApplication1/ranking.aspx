<%@ Page Title="Ranking" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ranking.aspx.cs" Inherits="WebApplication1.ranking" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

	<style="text/css">
		canvas { border:10px dotted #ccc; }
		h1 { font-size:50px; text-align:center; padding-bottom: 25px; }
		 .auto-style1{
		    text-align:center;
		    color: black;
		    border: double;
		}
        .auto-style2 {
		    text-align: center;
		    color: white;
		    font-size: small;
		}
		.auto-style3 { 
		    text-align: center;
		    color: white;
		    font-size: x-small;
		}
		</style>
	<h1 class="auto-style1"> Ranking</h1>
    <table align="center">
        <tr>
            <td class="auto-style2" style="width: 615px"> Puntuacio<asp:DataList ID="DataList2" runat="server" BackColor="Black" DataKeyField="usuario" DataSourceID="SqlDataSource1" ForeColor="#FF3300" Width="308px">
                <ItemTemplate>
                    usuario:
                    <asp:Label ID="usuarioLabel" runat="server" Text='<%# Eval("usuario") %>' />
                    <asp:Label ID="puntuacionLabel" runat="server" Text='<%# Eval("puntuacion") %>' />
                    <br />
                    
                    <br />
<br />
                </ItemTemplate>
                </asp:DataList>
                ne<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Database1ConnectionString %>" SelectCommand="SELECT [puntuacion], [usuario] FROM [ranking] ORDER BY [puntuacion] DESC"></asp:SqlDataSource>
                s </td>
        </tr>
</asp:Content>
