<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Horario Otros.aspx.cs" Inherits="SupervivientesNet.Presentacion.Horario_Otros" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <center>
     <div class="jumbotron">
        <div class="container">  
          <h1>Horario Otros</h1>
        </div>
    </div>
    </center>
<!--Tabla del horario-->
    <div class="container">
    <center>
        <table class="table table-hover">
        <br /><br />

    <!--Dias-->
        <tr>
        <th class="Dias">Horario</th>
        <th class="Dias">Lunes</th>
        <th class="Dias">Martes</th>
        <th class="Dias">Miercoles</th>
        <th class="Dias">Jueves</th>
        <th class="Dias">Viernes</th>
        <th class="Dias">Sabado</th>
        </tr>
        </table>

    <!--Horas-->
        <table class="table table-hover">
                        <!--Fila 1-->
            <tr>
            <th class="Horas">08:31 a 09:15</th>
            <th class="Horas"><asp:Label ID="Lbl00" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl01" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl02" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl03" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl04" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl05" runat="server" Text=""></asp:Label></th>
            </tr>
                         <!--Fila 2-->
            <tr>
            <th class="Horas">09:16 a 10:00</th>
            <th class="Horas"><asp:Label ID="Lbl10" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl11" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl12" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl13" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl14" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl15" runat="server" Text=""></asp:Label></th>
            </tr>
                        <!--Fila 3-->
            <tr>
            <th class="Horas">10:01 a 10:45</th>
            <th class="Horas"><asp:Label ID="Lbl20" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl21" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl22" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl23" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl24" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl25" runat="server" Text=""></asp:Label></th>
            </tr>
                        <!--Fila 4-->
            <tr>
            <th class="Horas">10:46 a 11:30</th>
            <th class="Horas"><asp:Label ID="Lbl30" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl31" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl32" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl33" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl34" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl35" runat="server" Text=""></asp:Label></th>
            </tr>

                        <!--Fila 5-->
            <tr>
            <th class="Horas">11:31 a 12:15</th>
            <th class="Horas"><asp:Label ID="Lbl40" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl41" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl42" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl43" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl44" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl45" runat="server" Text=""></asp:Label></th>
            </tr>

                        <!--Fila 6-->
            <tr>
            <th class="Horas">12:16 a 13:00</th>
            <th class="Horas"><asp:Label ID="Lbl50" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl51" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl52" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl53" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl54" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl55" runat="server" Text=""></asp:Label></th>
            </tr>

                        <!--Break-->
              <tr>
            <th class="Horas">13:00 a 14:29</th>
            <th class="Horas"><asp:Label ID="Label" runat="server" Text="Break" ForeColor="Red" Font-Size="Large"></asp:Label></th>
            <th class="Horas"><asp:Label ID="Label1" runat="server" Text="Break" ForeColor="Red" Font-Size="Large"></asp:Label></th>
            <th class="Horas"><asp:Label ID="Label2" runat="server" Text="Break" ForeColor="Red" Font-Size="Large"></asp:Label></th>
            <th class="Horas"><asp:Label ID="Label3" runat="server" Text="Break" ForeColor="Red" Font-Size="Large"></asp:Label></th>
            <th class="Horas"><asp:Label ID="Label4" runat="server" Text="Break" ForeColor="Red" Font-Size="Large"></asp:Label></th>
            <th class="Horas"><asp:Label ID="Label5" runat="server" Text="Break" ForeColor="Red" Font-Size="Large"></asp:Label></th>
            </tr>
                        <!--Fila 7-->
            <tr>
            <th class="Horas">14:30 a 15:15</th>
            <th class="Horas"><asp:Label ID="Lbl60" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl61" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl62" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl63" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl64" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl65" runat="server" Text=""></asp:Label></th>
            </tr>

                        <!--Fila 8-->
            <tr>
            <th class="Horas">15:16 a 16:00</th>
            <th class="Horas"><asp:Label ID="Lbl70" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl71" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl72" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl73" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl74" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl75" runat="server" Text=""></asp:Label></th>
            </tr>

                        <!--Fila 9-->
            <tr>
            <th class="Horas">16:01 a 16:45 </th>
            <th class="Horas"><asp:Label ID="Lbl80" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl81" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl82" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl83" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl84" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl85" runat="server" Text=""></asp:Label></th>
            </tr>

                        <!--Fila 10-->
            <tr>
            <th class="Horas">16:46 a 17:30</th>
            <th class="Horas"><asp:Label ID="Lbl90" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl91" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl92" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl93" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl94" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl95" runat="server" Text=""></asp:Label></th>
            </tr>

                        <!--Fila 11-->
            <tr>
            <th class="Horas">17:31 a 18:15</th>
            <th class="Horas"><asp:Label ID="Lbl100" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl101" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl102" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl103" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl104" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl105" runat="server" Text=""></asp:Label></th>
            </tr>

                        <!--Fila 12-->
            <tr>
            <th class="Horas">18:16 a 19:00</th>
            <th class="Horas"><asp:Label ID="Lbl110" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl111" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl112" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl113" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl114" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl115" runat="server" Text=""></asp:Label></th>
            </tr>

                        <!--Fila 13-->
            <tr>
            <th class="Horas">19:01 a 19:45</th>
            <th class="Horas"><asp:Label ID="Lbl120" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl121" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl122" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl123" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl124" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl125" runat="server" Text=""></asp:Label></th>
            </tr>

                        <!--Fila 14-->
            <tr>
            <th class="Horas">19:46 a 20:30</th>
            <th class="Horas"><asp:Label ID="Lbl130" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl131" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl132" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl133" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl134" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl135" runat="server" Text=""></asp:Label></th>
            </tr>

                       <!--Fila 15-->
            <tr>
            <th class="Horas">20:31 a 21:15</th>
            <th class="Horas"><asp:Label ID="Lbl140" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl141" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl142" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl143" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl144" runat="server" Text=""></asp:Label></th>
            <th class="Horas"><asp:Label ID="Lbl145" runat="server" Text=""></asp:Label></th>
            </tr>
        </table>
        </div>
        </center>
</asp:Content>
