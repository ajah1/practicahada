<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="registro.aspx.cs" Inherits="WebApplication1.registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style type="text/css">
        body {
            background-color: deepskyblue;
        }
    </style>

     <title>Registro</title>

    <meta charset="utf-8" />

       <style type="text/css">
        canvas { border:5px dotted #ccc; }
        h1 { font-size:50px; text-align: center; padding-bottom: 25px;}
           .auto-style1 {
               text-align: center;
           }
           .auto-style3 {
               font-size: medium;
           }
        </style>

        <h1 class="auto-style1"> Registro</h1>

    <p style="height: 563px">
        <table align="center" style="width: 49%; margin-left: 104px;">
            <tr>
                <td style="width: 278px; text-align: center">
                    <asp:Label ID="Label2" runat="server" Text="Nombre (Usuario)" CssClass="auto-style3"></asp:Label>
                </td>
                <td style="text-align: center">
                    <asp:Label ID="Label1" runat="server" Text="Contraseña" CssClass="auto-style3"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align: center; width: 278px">
                    <asp:TextBox ID="TextBox1" runat="server" Width="230px"></asp:TextBox>
                </td>
                <td style="text-align: center">
                    <asp:TextBox ID="TextBox2" runat="server" Width="245px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="height: 22px; text-align: center; width: 278px"></td>
                <td style="height: 22px"></td>
            </tr>
            <tr>
                <td style="text-align: center; width: 278px">
                    <asp:Label ID="Label5" runat="server" Text="Dirección" CssClass="auto-style3"></asp:Label>
                </td>
                <td style="text-align: center">
                    <asp:Label ID="Label6" runat="server" Text="Email" CssClass="auto-style3"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align: center; width: 278px">
                    <asp:TextBox ID="TextBox3" runat="server" Width="219px"></asp:TextBox>
                </td>
                <td style="text-align: center">
                    <asp:TextBox ID="TextBox4" runat="server" Width="283px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="text-align: center; width: 278px">&nbsp;</td>
                <td style="text-align: center">&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: center; width: 278px">
                    <asp:Label ID="Label7" runat="server" Text="Ciudad" CssClass="auto-style3"></asp:Label>
                </td>
                <td style="text-align: center">
                    <asp:Label ID="Label8" runat="server" Text="País" CssClass="auto-style3"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align: center; width: 278px">
                    <asp:TextBox ID="TextBox5" runat="server" Width="164px"></asp:TextBox>
                </td>
                <td style="text-align: center">
                    <asp:TextBox ID="TextBox6" runat="server" Width="167px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="text-align: center; width: 278px">&nbsp;</td>
                <td style="text-align: center">&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: center; width: 278px">
                    <asp:Label ID="Label9" runat="server" Text="Edad" CssClass="auto-style3"></asp:Label>
                </td>
                <td style="text-align: center">&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: center; width: 278px">
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                </td>
                <td style="text-align: center">&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: center; width: 278px">&nbsp;</td>
                <td style="text-align: center">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 278px; text-align: center">
                    <asp:Label ID="Label10" runat="server" Text="Descripción" CssClass="auto-style3"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:TextBox ID="TextBox8" runat="server" Height="65px" Width="619px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Button ID="Button1" runat="server" Text="Confirmar" />
                </td>
            </tr>
        </table>
    </p>

</asp:Content>
