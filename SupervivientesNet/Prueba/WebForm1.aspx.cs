using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Prueba
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            ServiceReference1.UsuariosClient servicio = new ServiceReference1.UsuariosClient();
            if (servicio.Autenticar(Login1.UserName, Login1.Password).Autenticado)
            {
                FormsAuthentication.RedirectFromLoginPage(servicio.Autenticar(Login1.UserName, Login1.Password).Nombre, true);
            }
            else
            {
                Response.Redirect("WebForm2.aspx");
            }
        }
    }
}