<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication1.login" %>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


        <meta charset="utf-8" />

       <style type="text/css">
            canvas { border:5px dotted #ccc; }
            h1 { font-size:50px; text-align: center; padding-bottom: 25px;}


           .auto-style1 {
               width: 161px;
           }
        .auto-style2 {
        width: 275px;
    }


           .auto-style3 {
               color: #FFFFFF;
           }
           .auto-style4 {
               margin-left: 0px;
           }


        </style>

        <h1> LOGIN </h1>

    <table style="width: 100%; height: 237px;">
        <tr>
            <td style="width: 121px">&nbsp;</td>
            <td class="auto-style2"></td>
            <td class="auto-style1">
                <asp:Label ID="Label1" runat="server" Text="Usuario" style="font-size: medium" CssClass="auto-style3">
                </asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 121px">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style1">
                <asp:TextBox ID="TextBox3" runat="server" Height="30px" Width="200px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 121px">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style1">
                <asp:Label ID="Label2" runat="server" Text="Password" style="font-size: medium" CssClass="auto-style3"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 121px">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style1">
                <asp:TextBox ID="TextBox2" runat="server" Height="33px" Width="197px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 121px">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style1">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Login" Width="120px" CssClass="auto-style4" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    


</asp:Content>


