<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Solicitudes.aspx.cs" Inherits="SupervivientesNet.Presentacion.Solicitudes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
    <div class="jumbotron">
    <div class="container">  
          <h1>Solicitud de Infraestructura</h1>
        </div>
    </div>
    <div class="container">
    <div class="form-group">
        <label for="motivo" class="col-lg-2 control-label">Elija día</label>
        <div class="col-lg-10">
        <asp:DropDownList class="form-control" ID="ddlDay" runat="server">
            <asp:ListItem>Lunes</asp:ListItem>
            <asp:ListItem>Martes</asp:ListItem>
            <asp:ListItem>Miercoles</asp:ListItem>
            <asp:ListItem>Jueves</asp:ListItem>
            <asp:ListItem>Viernes</asp:ListItem>
            <asp:ListItem>Sábado</asp:ListItem>
        </asp:DropDownList>
        </div>
    </div> 

        <div class="form-group">
        <label for="motivo" class="col-lg-2 control-label">Elija bloque</label>
        <div class="col-lg-10">
        <asp:DropDownList class="form-control" ID="ddlBloque" runat="server">
            <asp:ListItem>08:31 a 09:15</asp:ListItem>
            <asp:ListItem>09:16 a 10:00</asp:ListItem>
            <asp:ListItem>10:01 a 10:45</asp:ListItem>
            <asp:ListItem>10:46 a 11:30</asp:ListItem>
            <asp:ListItem>11:31 a 12:15</asp:ListItem>
            <asp:ListItem>12:16 a 13:00</asp:ListItem>
            <asp:ListItem>14:30 a 15:15</asp:ListItem>
            <asp:ListItem>15:16 a 16:00</asp:ListItem>
            <asp:ListItem>16:01 a 16:45</asp:ListItem>
            <asp:ListItem>16:46 a 17:30</asp:ListItem>
            <asp:ListItem>17:31 a 18:15</asp:ListItem>
            <asp:ListItem>18:16 a 19:00</asp:ListItem>
            <asp:ListItem>19:01 a 19:45</asp:ListItem>
            <asp:ListItem>19:46 a 20:30</asp:ListItem>
            <asp:ListItem>20:31 a 21:15</asp:ListItem>
        </asp:DropDownList>
        </div>
    </div> 


        <div class="form-group">
        <label for="motivo" class="col-lg-2 control-label">Elija Tipo de Recinto</label>
        <div class="col-lg-10">
        <asp:DropDownList class="form-control" ID="ddlRecinto" runat="server">
            <asp:ListItem>Futbolito</asp:ListItem>
            <asp:ListItem>Gimnasio</asp:ListItem>
            <asp:ListItem>Multicancha</asp:ListItem>
            <asp:ListItem>Otros</asp:ListItem>
        </asp:DropDownList>
        </div>
    </div> 


    <div class="form-group">
        <div class="col-lg-offset-2 col-lg-10">
            <asp:Button ID="btnSend" runat="server" Text="Enviar Solicitud" class="btn btn-default" OnClick="btnSend_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Borrar Solicitud" class="btn btn-default" OnClick="btnDelete_Click" />
        </div>
         <asp:Label ID="lblMensaje" runat="server" Text="" class="col-lg-2 control-label"></asp:Label>
    </div>
    </div>
</asp:Content>
