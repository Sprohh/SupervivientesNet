using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SupervivientesNet.Negocios;
using System.Web.Security;

namespace SupervivientesNet.Presentacion
{
    public partial class Solicitudes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
       
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            Pedido pedido = Indexacion();

            if (!pedido.existePedido())
            {
                pedido.Create();
                /*switch(pedido.Infraestructura)
                {
                    case 1:
                        Response.Redirect("Horario Futbolito.aspx");
                        break;
                    case 2:
                        Response.Redirect("Horario Gimnasio.aspx");
                        break;
                    case 3:
                        Response.Redirect("Horario Multicancha.aspx");
                        break;
                    case 4:
                        Response.Redirect("Horario Otros.aspx");
                        break;
                }*/
                lblMensaje.Text = "Solicitud ingresada con éxito";
            }
            else
            {
                lblMensaje.Text = "Verifique que exista disponibilidad horaria";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            bool exito;
            Pedido pedido = Indexacion();
            exito = pedido.Delete();
            if (exito == false)
                lblMensaje.Text = "No se pudo eliminar, verifique que la solicitud le pertenezca y exista";
            else
                lblMensaje.Text = "Solicitud eliminada";

        }

        protected Pedido Indexacion()
        {
            int dia = ddlDay.SelectedIndex + 1;
            int bloque = ddlBloque.SelectedIndex + 1;
            int recinto = ddlRecinto.SelectedIndex + 1;
            Pedido pedido = new Pedido()
            {
                Dia = dia,
                Bloque = bloque,
                Infraestructura = recinto,
                Username = Page.User.Identity.Name
            };
            return pedido;
        }
    }
}