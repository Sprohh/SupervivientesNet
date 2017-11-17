using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupervivientesNet.Negocios
{
    public class Contacto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Sede { get; set; }
        public string Comentario { get; set; }

        public Contacto(int id, string nombre, string email, string sede, string comentario)
        {
            Id = id;
            Nombre = nombre;
            Email = email;
            Sede = sede;
            Comentario = comentario;
        }
        public Contacto()
        {
            Id = 0;
            Nombre = "";
            Email = "";
            Sede = "";
            Comentario = "";
        }

        public bool Create()
        {
            try
            {
                Datos.contact co = new Datos.contact();
                co.idContact = ultimoId() + 1;
                co.name = Nombre;
                co.email = Email;
                co.campus = Sede;
                co.comment = Comentario;
                Conexion.AutomatizacionDB.contact.Add(co);
                Conexion.AutomatizacionDB.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int ultimoId()
        {
            try
            {
                return Conexion.AutomatizacionDB.contact.Max(re => re.idContact);
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
