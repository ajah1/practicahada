<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="carrito.aspx.cs" Inherits="WebApplication1.carrito" %>




<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div>
          
        <h1 style="text-decoration-color:red">CARRITO</h1>
        
        
    </div>

    

        
       

    <div style:"grid-area">
    
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id,usuario,producto" DataSourceID="SqlDataSource1" CellPadding="3" ForeColor="Black" GridLines="Vertical" Width="1618px" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" Height="279px" style="text-align: center">
    <AlternatingRowStyle BackColor="#CCCCCC" />
    <Columns>
        <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
        <asp:BoundField DataField="usuario" HeaderText="usuario" ReadOnly="True" SortExpression="usuario" />
        <asp:BoundField DataField="producto" HeaderText="producto" ReadOnly="True" SortExpression="producto" />
    </Columns>
    <FooterStyle BackColor="#CCCCCC" />
    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
    <SortedAscendingCellStyle BackColor="#F1F1F1" />
    <SortedAscendingHeaderStyle BackColor="#808080" />
    <SortedDescendingCellStyle BackColor="#CAC9C9" />
    <SortedDescendingHeaderStyle BackColor="#383838" />
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Database1ConnectionString2 %>" SelectCommand="SELECT * FROM [carrito]"></asp:SqlDataSource>
    

        </div>
</asp:Content>

