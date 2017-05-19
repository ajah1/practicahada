<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="perfil.aspx.cs" Inherits="WebApplication1.perfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <meta charset="utf-8" />

       <style type="text/css">
        canvas { border:5px dotted #ccc; }
        h1 { font-size:50px; text-align: center; padding-bottom: 25px;}
           .auto-style1 {
               text-align: center;
           }
           .auto-style4 {
               text-align: left;
           }
           .auto-style7 {
               text-align: right;
               height: 22px;
               width: 176px;
           }
           .auto-style8 {
               width: 176px;
               text-align: right;
           }
           .auto-style10 {
               text-align: right;
           }
           .auto-style11 {
               text-align: center;
               width: 296px;
           }
           .auto-style13 {
               color: #FFFFFF;
               font-size: large;
           }
           .auto-style14 {
               width: 49%;
           }
           .auto-style15 {
               width: 296px;
           }
           .auto-style16 {
               text-align: center;
               height: 22px;
               width: 296px;
           }
           .auto-style17 {
               width: 176px;
           }
        </style>

        <h1 class="auto-style1"> Perfil</h1>

    <p style="height: 563px" class="auto-style4">
        <table align="center" style="margin-left: 104px;" class="auto-style14">
            <tr>
                <td class="auto-style8">
                    <strong>
                    <asp:Label ID="Label2" runat="server" Text="Usuario :" CssClass="auto-style13"></asp:Label>
                    </strong>
                </td>
                <td class="auto-style11">
                    <strong>
                    <asp:Label ID="Label11" runat="server" Text="Label" CssClass="auto-style13"></asp:Label>
                    </strong>
                </td>
            </tr>
            <tr>
                <td style="text-align: center; " class="auto-style17">
                    &nbsp;</td>
                <td style="text-align: center" class="auto-style15">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <strong>
                    <asp:Label ID="Label5" runat="server" Text="Dirección :" CssClass="auto-style13"></asp:Label>
                    </strong>
                </td>
                <td class="auto-style16">
                    <strong>
                    <asp:Label ID="Label12" runat="server" Text="Label" CssClass="auto-style13"></asp:Label>
                    </strong>
                </td>
            </tr>
            <tr>
                <td style="text-align: center; " class="auto-style17">
                    &nbsp;</td>
                <td style="text-align: center" class="auto-style15">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <strong>
                    <asp:Label ID="Label6" runat="server" Text="Email :" CssClass="auto-style13"></asp:Label>
                    </strong>
                </td>
                <td class="auto-style11">
                    <strong>
                    <asp:Label ID="Label13" runat="server" Text="Label" CssClass="auto-style13"></asp:Label>
                    </strong>
                </td>
            </tr>
            <tr>
                <td style="text-align: center; " class="auto-style17">&nbsp;</td>
                <td style="text-align: center" class="auto-style15">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <strong>
                    <asp:Label ID="Label7" runat="server" Text="Ciudad :" CssClass="auto-style13"></asp:Label>
                    </strong>
                </td>
                <td class="auto-style11">
                    <strong>
                    <asp:Label ID="Label17" runat="server" Text="Label" CssClass="auto-style13"></asp:Label>
                    </strong>
                </td>
            </tr>
            <tr>
                <td style="text-align: center; " class="auto-style17">
                    &nbsp;</td>
                <td style="text-align: center" class="auto-style15">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <strong>
                    <asp:Label ID="Label8" runat="server" Text="País :" CssClass="auto-style13"></asp:Label>
                    </strong>
                </td>
                <td class="auto-style11">
                    <strong>
                    <asp:Label ID="Label14" runat="server" Text="Label" CssClass="auto-style13"></asp:Label>
                    </strong>
                </td>
            </tr>
            <tr>
                <td style="text-align: center; " class="auto-style17">
                    &nbsp;</td>
                <td style="text-align: center" class="auto-style15">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <strong>
                    <asp:Label ID="Label9" runat="server" Text="Edad :" CssClass="auto-style13"></asp:Label>
                    </strong>
                </td>
                <td class="auto-style11">
                    <strong>
                    <asp:Label ID="Label15" runat="server" Text="Label" CssClass="auto-style13"></asp:Label>
                    </strong>
                </td>
            </tr>
            <tr>
                <td style="text-align: center; " class="auto-style17">&nbsp;</td>
                <td style="text-align: center" class="auto-style15">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <strong>
                    <asp:Label ID="Label10" runat="server" Text="Descripción :" CssClass="auto-style13"></asp:Label>
                    </strong>
                </td>
                <td class="auto-style11">
                    <strong>
                    <asp:Label ID="Label16" runat="server" Text="Label" CssClass="auto-style13"></asp:Label>
                    </strong>
                </td>
            </tr>
            <tr>
                <td colspan="2" class="auto-style10">
                    <asp:Button ID="Button2" runat="server" Text="Darse de Baja" OnClick="Button2_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Button ID="Button1" runat="server" Text="Editar Perfil" OnClick="Button1_Click" />
                </td>
            </tr>
        </table>

</asp:Content>
