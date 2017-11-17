using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using SupervivientesNet.Negocios;
namespace SupervivientesNet.Presentacion
{
    public partial class Login : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LgnLogin_Authenticate(object sender, AuthenticateEventArgs e)
        {
            AutomatizacionService.UsuariosClient servicio = new AutomatizacionService.UsuariosClient();
            if (servicio.Autenticar(LgnLogin.UserName, LgnLogin.Password).Autenticado)
            {

                FormsAuthentication.RedirectFromLoginPage(servicio.Autenticar(LgnLogin.UserName, LgnLogin.Password).Nombre, true);
            }
            else
            {
                Response.Redirect("Index.aspx");
            }
        }
    }
}