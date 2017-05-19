<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication1.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script src="http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.5.2.min.js" type="text/javascript"></script>


     <script type="text/javascript">

                $.ajax({
                    //Tipo de llamada
                    type: "POST",

                    //Dirección del WebMethod, o sea, Página.aspx/Método
                    url: "WebForm3.aspx/Sumar",

                    //Parámetros para pasarle al método 
                    data: '{Valor1: 2, Valor2: 1}',

                    //Tipo de contenido
                    contentType: "application/json; charset=utf-8",

                    //Tipo de datos
                    dataType: "json",

                    //Función a la cual llamar cuando se pudo llamar satisfactoriamente al método
                    success: resultado,

                    //Función a la cual llamar cuando se producen errores
                    error: errores
                });

        function resultado() {
            //msg.d tiene el resultado devuelto por el método
            
        }
        function errores() {
            //msg.responseText tiene el mensaje de error enviado por el servidor
            
        }
    </script>

</asp:Content>
