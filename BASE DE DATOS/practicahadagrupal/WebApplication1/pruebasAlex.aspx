<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="pruebasAlex.aspx.cs" Inherits="WebApplication1.pruebasAlex" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div _designerregion="0">
        <asp:DataList ID="DataList1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataSourceID="ObjectDataSource1" GridLines="Both" Width="418px">
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <ItemStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <ItemTemplate>
                Length:
                <asp:Label ID="LengthLabel" runat="server" Text='<%# Eval("idpromocion") %>' />
                <br />
                <br />
                <br />
            </ItemTemplate>
            <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        </asp:DataList>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="read" TypeName="ClassLibrary.CAD.CADpromocion">
            <SelectParameters>
                <asp:Parameter DefaultValue="0" Name="id" Size="4" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </div>

</asp:Content>
