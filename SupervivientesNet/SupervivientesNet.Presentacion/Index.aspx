<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="SupervivientesNet.Presentacion.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <header class="intro-header">
      <div class="container">
        <div class="intro-message">
          <h1>Bienvenido</h1>
          <h3>Solicitudes de Recintos Deportivos DuocUC</h3>
          <hr class="intro-divider">
          <ul class="list-inline intro-social-buttons">
            <li class="list-inline-item">
              <a href="https://twitter.com/duocuc?lang=es" class="btn btn-secondary btn-lg">
                <i class="fa fa-twitter fa-fw"></i>
                <span class="network-name">Twitter</span>
              </a>
            </li>
            <li class="list-inline-item">
              <a href="https://www.facebook.com/DuocUC.Maipu/" class="btn btn-secondary btn-lg">
                <i class="fa fa-facebook fa-fw"></i>
                <span class="network-name">Facebook</span>
              </a>
            </li>
            <li class="list-inline-item">
              <a href="http://www.duoc.cl/" class="btn btn-secondary btn-lg">
                <i class="fa fa-pencil fa-fw"></i>
                <span class="network-name">DuocUC</span>
              </a>
            </li>
          </ul>
        </div>
      </div>
    </header>

    <!-- Page Content -->
    <section class="content-section-a">

      <div class="container">
        <div class="row">
          <div class="col-lg-5 ml-auto">
            <hr class="section-heading-spacer">
            <div class="clearfix"></div>
            <h2 class="section-heading">Solicita tu recinto sin tramites</h2>
            <p class="lead">Mejor acceso para todos gracias al sistema automatizado de 
              <a target="_blank" href="Solicitudes.aspx">Solicitudes</a>
              la cual nos permite elegir Recinto,dia y hora</p>
          </div>
          <div class="col-lg-5 mr-auto">
            <img class="img-fluid" src="img/ipad.png" alt="">
          </div>
        </div>

      </div>
      <!-- /.container -->
    </section>

    <section class="content-section-b">

      <div class="container">

        <div class="row">
          <div class="col-lg-5 mr-auto order-lg-2">
            <hr class="section-heading-spacer">
            <div class="clearfix"></div>
            <h2 class="section-heading">Entrena y Superate</h2>
            <p class="lead">No hay obstaculos para no superarte, solo depende de ti, ven y representa a 
              <a target="_blank" href="http://www.duoc.cl/">DuocUC</a> como un verdadero Campeón</p>
          </div>
          <div class="col-lg-5 ml-auto order-lg-1">
            <img class="img-fluid" src="img/mujer.jpg"  alt="imagen" width="900" height="696" >
          </div>
        </div>

      </div>
      <!-- /.container -->

    </section>
    <!-- /.content-section-b -->

    <section class="content-section-a">

      <div class="container">

        <div class="row">
          <div class="col-lg-5 ml-auto">
            <hr class="section-heading-spacer">
            <div class="clearfix"></div>
            <h2 class="section-heading">Reglas y Normas</h2>
            <p class="lead">Algo muy importante para una sana convivencia son las <a target="_blank" href="Reglas y Normas.aspx">Reglas y Normas</a>, las cuales deben ser respetadas para no incurrir en sanciones</p>
          </div>
          <div class="col-lg-5 mr-auto ">
            <img class="img-fluid" src="img/arbitro.jpg" alt="imagen" width="900" height="696">
          </div>
        </div>

      </div>
        </section>
</asp:Content>
