<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Estadisticas.aspx.cs" Inherits="SupervivientesNet.Presentacion.Estadisticas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="jumbotron">
        <div class="container">  
          <h1>Estadisticas</h1>
        </div>
    </div>

    <div class="container">
     <div class="form-group">
        <label for="motivo" class="col-lg-2 control-label">Opciones</label>
        <div class="col-lg-10">
            <asp:dropdownlist class="form-control"  ID="ddlEstadistica" runat="server">
                <asp:ListItem>Cancha mas usada</asp:ListItem>
                <asp:ListItem>Dia con mas pedidos</asp:ListItem>
                <asp:ListItem>Hora mas pedida</asp:ListItem>
            </asp:dropdownlist>
        </div>
    </div>   

    <div class="form-group">
        <div class="col-lg-offset-2 col-lg-10">          
            <asp:Button  runat="server" Text="Consultar"   class="btn btn-default" OnClick="Unnamed2_Click" />
        </div>
    </div>
            <asp:Label class="col-lg-2 control-label" ID="lblMensaje" runat="server" Text=""></asp:Label>        
    </div>
    
</asp:Content>
