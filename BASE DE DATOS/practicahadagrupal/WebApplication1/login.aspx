<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication1.login" %>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <meta charset="utf-8" />

       <style type="text/css">
        canvas { border:5px dotted #ccc; }
        h1 { font-size:50px; text-align: center; padding-bottom: 25px;}
        </style>

        <h1> LOGIN </h1>

    <table style="width: 100%; height: 237px;">
        <tr>
            <td style="width: 121px">&nbsp;</td>
            <td style="width: 144px">
                User</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 121px">&nbsp;</td>
            <td style="width: 144px">
                <asp:TextBox ID="TextBox1" runat="server" Height="32px" Width="172px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 121px">&nbsp;</td>
            <td style="width: 144px">Password</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 121px">&nbsp;</td>
            <td style="width: 144px">
                <asp:TextBox ID="TextBox2" runat="server" Height="33px" Width="177px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 121px">&nbsp;</td>
            <td style="width: 144px">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Login" Width="120px" style="margin-left: 34px" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    


</asp:Content>


