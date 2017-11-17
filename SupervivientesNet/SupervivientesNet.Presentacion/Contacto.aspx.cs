using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SupervivientesNet.Negocios;
namespace SupervivientesNet.Presentacion
{
    public partial class Contacto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Negocios.Contacto co = new Negocios.Contacto()
                {
                    Nombre = txtName.Text,
                    Email = txtEmail.Text,
                    Sede = ddlSede.SelectedValue,
                    Comentario = txtComentario.Text
                };
                
                if (co.Create())
                {
                    Response.Redirect("ExitoSolicitud.aspx");
                }
                else
                {
                    Label1.Text = "Error al ingresar solicitud";
                }
                
            }
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = args.Value.Length < 31;
        }

        protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = args.Value.Length < 31;
        }

        protected void CustomValidator4_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = args.Value.Length < 301;
        }
    }
}