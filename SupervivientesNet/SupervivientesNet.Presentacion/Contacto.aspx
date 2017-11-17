<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Contacto.aspx.cs" Inherits="SupervivientesNet.Presentacion.Contacto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Css/StyleSheet2.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <div class="jumbotron">
        <div class="container">  
          <h1>Formulario de Contacto</h1>
        </div>
    </div>
    <header>
    <div class="container">
            <asp:Label ID="Label1" class="col-lg-2 control-label" runat="server" Text=""></asp:Label>
    <div class="form-group">
        <label for="nombre" class="col-lg-2 control-label">Nombre</label>
        <div class="col-lg-10">
                <asp:TextBox class="form-control" ID="txtName" runat="server" placeholder="Tu Nombre.."></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="txtName" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="*Máximo 30 caracteres" ControlToValidate="txtName" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
    
        </div>
    </div>
        
    <div class="form-group">
        <label for="email" class="col-lg-2 control-label">Email</label>
        <div class="col-lg-10">
                <asp:TextBox class="form-control" ID="txtEmail" runat="server" placeholder="Tu Email.."></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*Campo Obligatorio" ForeColor="Red" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>
            <asp:CustomValidator ID="CustomValidator2" runat="server" ErrorMessage="*Máximo 30 caracteres" ControlToValidate="txtEmail" ForeColor="Red" OnServerValidate="CustomValidator2_ServerValidate"></asp:CustomValidator>
        </div>
    </div>

   
    <div class="form-group">
        <label for="motivo" class="col-lg-2 control-label">Sede</label>
        <div class="col-lg-10">
            <asp:DropDownList class="form-control" ID="ddlSede" runat="server">
                 <asp:ListItem Value="Maipu">Maipú</asp:ListItem>
                 <asp:ListItem Value="PlazaOeste">Plaza Oeste</asp:ListItem>
                 <asp:ListItem Value="SanJoaquin">San Joaquin</asp:ListItem>
                 <asp:ListItem Value="ViñadelMar">Viña del Mar</asp:ListItem>
            </asp:DropDownList>
        </div>
    </div>   
             
    <div class="form-group">
        <label for="comentario" class="col-lg-2 control-label">Comentario</label>
        <div class="col-lg-10">
    <asp:TextBox class="form-control"  ID="txtComentario" runat="server" placeholder="Ingresa tu comentario.." Height="102px"></asp:TextBox>

                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*Campo Obligatorio" ControlToValidate="txtComentario" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:CustomValidator ID="CustomValidator4" runat="server" ErrorMessage="*Máximo 300 caracteres" ControlToValidate="txtComentario" ForeColor="Red" OnServerValidate="CustomValidator4_ServerValidate"></asp:CustomValidator>
        </div>
    </div>  
        
    <div class="form-group">
        <div class="col-lg-offset-2 col-lg-10">      
            <asp:Button ID="btnIngresar" runat="server" Text="Enviar" class="btn btn-default" Onclick="btnIngresar_Click" />
        </div>
    </div>
    </div>
        </header>
</asp:Content>
