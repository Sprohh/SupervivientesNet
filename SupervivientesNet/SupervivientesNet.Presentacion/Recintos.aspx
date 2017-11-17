<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Recintos.aspx.cs" Inherits="SupervivientesNet.Presentacion.Recintos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
         <div class="jumbotron">
        <div class="container">  
          <h1>Recintos Disponibles</h1>
        </div>
    </div>
    
    <section class="content-section-a">
      <div class="container">
        <div class="row">
          <div class="col-lg-5 ml-auto">
            <hr class="section-heading-spacer">
            <div class="clearfix"></div>
            <h2 class="section-heading">Futbolito</h2>
            <p class="lead">Entrena con tu equipo o diviertete con tus amigos en una cancha de alta calidad,
                Revisa el horario a continuacion.
            </p>
              <p><a class="btn btn-info" href="Horario Futbolito.aspx" role="button">Horario &raquo</a></p>
          </div>
          <div class="col-lg-5 mr-auto">
            <img class="img-fluid" src="img/Cancha Futbolito.jpg" alt="imagen" width="800">
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
            <h2 class="section-heading">Multi Cancha</h2>
            <p class="lead">Entrena y comparte con tus amigos diversas actividades, sea Tenis, Baby futbol, Karate, Basquetbol, etc...</p>
            <p><a class="btn btn-info" href="Horario Multicancha.aspx" role="button">Horario &raquo</a></p>
          </div>
          <div class="col-lg-5 ml-auto order-lg-1">
            <img class="img-fluid" src="img/multicancha.jpg"  alt="imagen" width="800">
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
            <h2 class="section-heading">Gimnasio Deportivo</h2>
            <p class="lead">Ven a disfrutar del deporte en un espacio cerrado con todas las comodidades posibles
              </p>
              <p><a class="btn btn-info" href="Horario Gimnasio.aspx" role="button">Horario &raquo</a></p>
          </div>
          <div class="col-lg-5 mr-auto ">
            <img class="img-fluid" src="img/Gimnasio Deportivo.jpg" alt="imagen" width="800">
          </div>
        </div>

      </div>
        </section>
    <section class="content-section-b">

      <div class="container">

        <div class="row">
          <div class="col-lg-5 mr-auto order-lg-2">
            <hr class="section-heading-spacer">
            <div class="clearfix"></div>
            <h2 class="section-heading">Otros</h2>
            <p class="lead">Entrena y comparte con tus amigos diversas actividades, sea Tenis, Baby futbol, Karate, Basquetbol, etc...</p>
            <p><a class="btn btn-info" href="Horario Otros.aspx" role="button">Horario &raquo</a></p>
          </div>
          <div class="col-lg-5 ml-auto order-lg-1">
            <img class="img-fluid" src="img/Otros.png"  alt="imagen" width="800">
          </div>
        </div>

      </div>
      <!-- /.container -->

    </section>
</asp:Content>
