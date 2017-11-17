using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupervivientesNet.Negocios
{
    class Infraestructura
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Infraestructura()
        {
            Id = 0;
            Nombre = "";
        }

        public Infraestructura(int i, string nom)
        {
            Id = i;
            Nombre = nom;
        }

        public bool Read()
        {
            try
            {
                Datos.infrastructure inf = Conexion.AutomatizacionDB.infrastructure.First(i => i.idinfrastructure == Id);
                Id = inf.idinfrastructure;
                Nombre = inf.name;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
