﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="perfil.aspx.cs" Inherits="WebApplication1.perfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

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
           .auto-style4 {
               text-align: left;
           }
           .auto-style5 {
               text-align: left;
               width: 147px;
           }
           .auto-style6 {
               width: 147px;
           }
           .auto-style7 {
               text-align: left;
               height: 22px;
               width: 147px;
           }
        </style>

        <h1 class="auto-style1"> Perfil</h1>

    <p style="height: 563px" class="auto-style4">
        <table align="left" style="width: 49%; margin-left: 104px;">
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label2" runat="server" Text="Usuario :" CssClass="auto-style3"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="Label11" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align: center; " class="auto-style6">
                    &nbsp;</td>
                <td style="text-align: center">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="Label5" runat="server" Text="Dirección :" CssClass="auto-style3"></asp:Label>
                </td>
                <td style="height: 22px" class="auto-style4">
                    <asp:Label ID="Label12" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align: center; " class="auto-style6">
                    &nbsp;</td>
                <td style="text-align: center">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label6" runat="server" Text="Email :" CssClass="auto-style3"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="Label13" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align: center; " class="auto-style6">&nbsp;</td>
                <td style="text-align: center">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label7" runat="server" Text="Ciudad :" CssClass="auto-style3"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="Label17" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align: center; " class="auto-style6">
                    &nbsp;</td>
                <td style="text-align: center">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label8" runat="server" Text="País :" CssClass="auto-style3"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="Label14" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align: center; " class="auto-style6">
                    &nbsp;</td>
                <td style="text-align: center">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label9" runat="server" Text="Edad :" CssClass="auto-style3"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="Label15" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align: center; " class="auto-style6">&nbsp;</td>
                <td style="text-align: center">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label10" runat="server" Text="Descripción :" CssClass="auto-style3"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="Label16" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Button ID="Button1" runat="server" Text="Editar Perfil" />
                </td>
            </tr>
        </table>

</asp:Content>