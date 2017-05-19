<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Articulo.aspx.cs" Inherits="WebApplication1.Articulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h2>
            <asp:Label ID="NProducto" runat="server" Text="Label"></asp:Label>
        </h2>
    </div>

    <div>
        <asp:Image ID="Image1" runat="server" Width="300" Height="300" />
    </div>

    <div>

    </div>


    <div>
        <h5>
            <asp:Label ID="Label1" runat="server" Text="Precio: "></asp:Label>
            <asp:Label ID="NPrecio" runat="server" Text=""></asp:Label>
        </h5>
    </div>

    <div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Comentarios: "></asp:Label>
        </div>
        <div>
            <asp:Label ID="NComentarios" runat="server" Text=""></asp:Label>
        </div>
    </div>

    <div>
        <div>
            <asp:Label ID="Label3" runat="server" Text="Introduce la cantidad a comprar:"></asp:Label>
        </div>
        <div>
            <asp:TextBox ID="Ncantidad" runat="server" Textmode="Number"></asp:TextBox>
            <asp:Button CssClass="product-btn" ID="Button1" runat="server"  Text="Comprar" OnClick="Button1_Click" />
            
        </div>

        <div>
            <a href="Account/Login.aspx"><asp:Label ID="Label4" runat="server" Text="Inicia sesión para poder comprar el producto" ForeColor="red" Visible="false"></asp:Label></a>
        </div>
        
    </div>










</asp:Content>



