﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="productos.aspx.cs" Inherits="WebApplication1.productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <style type="text/css">
        canvas { border:5px dotted #ccc; }
        h1 { font-size:50px; text-align: center; padding-bottom: 25px;}
           .auto-style1 {
               text-align: center;
           }
         h4 {
             color: white;
         }
         h3 {
            font-style: italic;
            border-color: aqua;
            color: white;
            position: center;

         }

           </style>

        <h1 class="auto-style1"> Productos</h1>

    <div class="clearfix"> </div>

     <h3><asp:Button  CssClass="product-btn" ID="Buttonacer" runat="server" Text="MOSTRAR PRODUCTOS" OnClick="Buttonacer_Click" /></h3>

				<div class="special-products all-poroducts">
					<div class="s-products-head">
						<div class="s-products-head-left">
						</div>

					</div>
					
                    <div runat="server" ID="Columna1">
						<div class="col-md-3 special-products-grid text-center" runat="server" id="hueco0">
                            <tr id="cero" runat="server">
                            <td><img id="Imagen0" class="imagen0" runat="server" src="" width ="420" height="420"/></td></tr>
                            <h4><asp:Label ID="Label0" runat="server" Text="NAME "></asp:Label>
                                / ID: 
                                <asp:Label ID="Labeli0" runat="server" Text=""></asp:Label>
                            </h4>
                            <h4>
                                <asp:Label ID="Labelc0" runat="server" Text="Descripción: "></asp:Label>
                                <asp:Label ID="Labelr0" runat="server" Text=""></asp:Label>

                            </h4>
                            <asp:Button CssClass="product-btn" ID="Button0" runat="server" Text="" OnClick="Buttonprod0_Click" />
						</div>

						<div class="col-md-3 special-products-grid text-center" runat="server" id="hueco1">
                            <tr id="primera" runat="server">
                            <td><img id="Imagen1" class="imagen1" runat="server" src="" width ="420" height="420"/></td></tr>
							<h4><asp:Label ID="Label1" runat="server" Text="NAME"></asp:Label>
                                / ID: 
                                <asp:Label ID="Labeli1" runat="server" Text=""></asp:Label>
							</h4>
                            <h4>
                                <asp:Label ID="Labelc1" runat="server" Text="Descripción: "></asp:Label>
                                <asp:Label ID="Labelr1" runat="server" Text=""></asp:Label>
                            </h4>
						    <asp:Button CssClass="product-btn" ID="Button1" runat="server" Text="" OnClick="Buttonprod1_Click" />
                        </div>

						<div class="col-md-3 special-products-grid text-center" runat="server" id="hueco2">
                            <tr id="segunda" runat="server">
                            <td><img id="Imagen2" class="imagen2" runat="server" src="" width ="420" height="420"/></td></tr>
							<h4><asp:Label ID="Label2" runat="server" Text="NAME"></asp:Label>
                                / ID: 
                                <asp:Label ID="Labeli2" runat="server" Text=""></asp:Label>
							</h4>
                            <h4>
                                <asp:Label ID="Labelc2" runat="server" Text="Descripción: "></asp:Label>
                                <asp:Label ID="Labelr2" runat="server" Text=""></asp:Label>
                            </h4>
                            <asp:Button CssClass="product-btn" ID="Button2" runat="server" Text="Button" OnClick="Buttonprod2_Click"/>
						</div>


						<div class="col-md-3 special-products-grid text-center" runat="server" id="hueco3">
                            <tr id="tercera" runat="server">
                            <td><img id="Imagen3" class="imagen3" runat="server" src="" width ="420" height="420"/></td></tr>
							<h4><asp:Label ID="Label3" runat="server" Text="NAME"></asp:Label>
                                / ID: 
                                <asp:Label ID="Labeli3" runat="server" Text=""></asp:Label>
							</h4>
                            <h4>
                                <asp:Label ID="Labelc3" runat="server" Text="Descripción: "></asp:Label>
                                <asp:Label ID="Labelr3" runat="server" Text=""></asp:Label>
                            </h4>
                            <asp:Button CssClass="product-btn" ID="Button3" runat="server" Text="Button" OnClick="Buttonprod3_Click"/>
						</div>

                        <div class="col-md-3 special-products-grid text-center" runat="server" id="hueco4">
                            <tr id="cuarta" runat="server">
                            <td><img id="Imagen4" class="imagen4" runat="server" src="" width ="420" height="420"/></td></tr>
							<h4><asp:Label ID="Label4" runat="server" Text="NAME"></asp:Label>
                                / ID: 
                                <asp:Label ID="Labeli4" runat="server" Text=""></asp:Label>
							</h4>
                            <h4>
                                <asp:Label ID="Labelc4" runat="server" Text="Descripción: "></asp:Label>
                                <asp:Label ID="Labelr4" runat="server" Text=""></asp:Label>
                            </h4>
                            <asp:Button CssClass="product-btn" ID="Button4" runat="server" Text="Button" OnClick="Buttonprod4_Click"/>
						</div>

                        <div class="col-md-3 special-products-grid text-center" runat="server" id="hueco5">
                            <tr id="quinta" runat="server">
                            <td><img id="Imagen5" class="imagen5" runat="server" src="" width ="420" height="420"/></td></tr>
							<h4><asp:Label ID="Label5" runat="server" Text="NAME"></asp:Label>
                                / ID: 
                                <asp:Label ID="Labeli5" runat="server" Text=""></asp:Label>
							</h4>
                            <h4>
                                <asp:Label ID="Labelc5" runat="server" Text="Descripción: "></asp:Label>
                                <asp:Label ID="Labelr5" runat="server" Text=""></asp:Label>
                            </h4>
                            <asp:Button CssClass="product-btn" ID="Button5" runat="server" Text="Button" OnClick="Buttonprod5_Click"/>
						</div>

                        <div class="col-md-3 special-products-grid text-center" runat="server" id="hueco6">
                            <tr id="sexta" runat="server">
                            <td><img id="Imagen6" class="imagen6" runat="server" src="" width ="420" height="420"/></td></tr>
							<h4><asp:Label ID="Label6" runat="server" Text="NAME"></asp:Label>
                                / ID: 
                                <asp:Label ID="Labeli6" runat="server" Text=""></asp:Label>
							</h4>
                            <h4>
                                <asp:Label ID="Labelc6" runat="server" Text="Descripción: "></asp:Label>
                                <asp:Label ID="Labelr6" runat="server" Text=""></asp:Label>
                            </h4>
                            <asp:Button CssClass="product-btn" ID="Button6" runat="server" Text="Button" OnClick="Buttonprod6_Click"/>
						</div>

                        <div class="col-md-3 special-products-grid text-center" runat="server" id="hueco7">
                            <tr id="septima" runat="server">
                            <td><img id="Imagen7" class="imagen7" runat="server" src="" width ="420" height="420"/></td></tr>
							<h4><asp:Label ID="Label7" runat="server" Text="NAME"></asp:Label>
                                / ID: 
                                <asp:Label ID="Labeli7" runat="server" Text=""></asp:Label>
							</h4>
                            <h4>
                                <asp:Label ID="Labelc7" runat="server" Text="Descripción: "></asp:Label>
                                <asp:Label ID="Labelr7" runat="server" Text=""></asp:Label>
                            </h4>
                            <asp:Button CssClass="product-btn" ID="Button7" runat="server" Text="Button" OnClick="Buttonprod7_Click"/>
						</div>

                        <div class="col-md-3 special-products-grid text-center" runat="server" id="hueco8">
                            <asp:Image ID="Image8_1" runat="server" />
							<h4>&nbsp;</h4>
						</div>
                        	
                    </div>
				</div>

    </asp:Content>