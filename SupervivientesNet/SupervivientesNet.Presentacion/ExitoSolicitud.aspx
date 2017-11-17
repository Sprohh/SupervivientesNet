<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ExitoSolicitud.aspx.cs" Inherits="SupervivientesNet.Presentacion.ExitoSolicitud" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <div class="jumbotron">
        <div class="container">  
          <h2>Solicitud ingresada con éxito!</h2>
        <div class="col-lg-offset-2 col-lg-10">
            <asp:Button ID="btnVolver" runat="server" Text="Volver" class="btn btn-default" OnClick="btnVolver_Click"  />
        </div>
        </div>
    </div>
        </center>
</asp:Content>
