using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SupervivientesNet.Negocios;
namespace SupervivientesNet.Presentacion
{
    public partial class Estadisticas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                lblMensaje.Text = "";
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            int index = ddlEstadistica.SelectedIndex;
            Negocios.Estadisticas stats = new Negocios.Estadisticas();
            switch (index)
            {
                case 0:
                    lblMensaje.Text = "El recinto más usado es: " + stats.recintoMasSolicitado();
                    break;
                case 1:
                    lblMensaje.Text = "El Día con más solicitudes es: " + stats.DiaConMasSolicitudes();
                    break;
                case 2:
                    lblMensaje.Text = "El bloque más pedido es: " + stats.BloqueMasPedido();
                    break;

            }
        }
    }
}