using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupervivientesNet.Negocios
{
    public class Usuario
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Usuario()
        {
            Username = "";
            Password = "";
        }

        public Usuario(string user, string pass)
        {
            Username = user;
            Password = pass;
        }


        public bool Read()
        {
            try
            {
                Datos.account cuenta = Conexion.AutomatizacionDB.account.First(user => user.username == Username);
                Username = cuenta.username;
                Password = cuenta.password;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Authenticate ()
        {
            try
            {
                Datos.account cuenta = Conexion.AutomatizacionDB.account.First(user => user.username == Username && user.password == Password);
                Username = cuenta.username;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
