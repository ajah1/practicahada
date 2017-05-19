<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="productos.aspx.cs" Inherits="WebApplication1.productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <style type="text/css">
        canvas { border:5px dotted #ccc; }
        h1 { font-size:50px; text-align: center; padding-bottom: 25px;}
           .auto-style1 {
               text-align: center;
           }
           .auto-style4 {
             text-align: center;
         }
         .auto-style6 {
             text-align: left;
         }
         .auto-style7 {
             text-align: right;
         }
         .auto-style8 {
             color: #FFFFFF;
         }
         .auto-style9 {
             text-align: center;
             color: #FFFFFF;
         }
        </style>

        <h1 class="auto-style1"> Productos</h1>


    <table style="width:100%;">
        <tr>
            <td class="auto-style7"><span class="auto-style8">BUSCADOR</span>:&nbsp;</td>
            <td class="auto-style6" colspan="2">
                <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 0px" Width="299px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" Text="Buscar" />
            </td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">IMAGEN</td>
            <td class="auto-style9">IMAGEN</td>
            <td class="auto-style9">IMAGEN</td>
        </tr>
        <tr>
            <td class="auto-style9"> </td>
            <td class="auto-style9">NOMBRE</td>
            <td class="auto-style9">NOMBRE</td>
        </tr>
        <tr>
            <td class="auto-style9">PRECIO</td>
            <td class="auto-style9">PRECIO</td>
            <td class="auto-style9">PRECIO</td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">IMAGEN</td>
            <td class="auto-style9">IMAGEN</td>
            <td class="auto-style9">IMAGEN</td>
        </tr>
        <tr>
            <td class="auto-style9">NOMBRE</td>
            <td class="auto-style9">NOMBRE</td>
            <td class="auto-style9">NOMBRE</td>
        </tr>
        <tr>
            <td class="auto-style9">PRECIO</td>
            <td class="auto-style9">PRECIO</td>
            <td class="auto-style9">PRECIO</td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">IMAGEN</td>
            <td class="auto-style9">IMAGEN</td>
            <td class="auto-style9">IMAGEN</td>
        </tr>
        <tr>
            <td class="auto-style9">NOMBRE</td>
            <td class="auto-style9">NOMBRE</td>
            <td class="auto-style9">NOMBRE</td>
        </tr>
        <tr>
            <td class="auto-style9">PRECIO</td>
            <td class="auto-style9">PRECIO</td>
            <td class="auto-style9">PRECIO</td>
        </tr>
    </table>
</asp:Content>