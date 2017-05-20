<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Articulo.aspx.cs" Inherits="WebApplication1.Articulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style>
        h3 {
            font-style: italic;
            border-color: aqua;
            color: white;
            position: center;

         }
        
    </style>
    <div>
         <h1 class="auto-style1"> Articulo</h1>
        </div>
    <div>
        <h3>
            <asp:Label ID="NomProd" runat="server" Text="Label"></asp:Label>
        </h3>
    </div>

    <div>
        <tr id="primera" runat="server">
             <td><img id="Imagen1" class="imagen1" runat="server" src="" width ="420" height="420"/></td></tr>
    </div>

    <div>
    </div>

    <div>
           <h3> <asp:Label ID="Label1" runat="server" Text="Precio: "></asp:Label>
            <asp:Label ID="CantPrecio" runat="server" Text=""></asp:Label></h3>
    </div>

    <div>
    </div>

    <div>
        <div>
            <asp:Button CssClass="product-btn" ID="Button1" runat="server"  Text="Comprar" OnClick="Button1_Click" />
            
        </div>

        <div>
            <a href="login.aspx"><asp:Label ID="Label4" runat="server" Text="Para comprar este producto es necesario iniciar sesion" ForeColor="red" Visible="false"></asp:Label></a>
        </div>
        
    </div>

</asp:Content>



