using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupervivientesNet.Negocios
{
    class Bloque
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Bloque()
        {
            Id = 0;
            Nombre = "";
        }

        public Bloque(int i, string nom)
        {
            Id = i;
            Nombre = nom;
        }

        public bool Read()
        {
            try
            {
                Datos.block bl = Conexion.AutomatizacionDB.block.First(blo => blo.idblock == Id);
                Id = bl.idblock;
                Nombre = bl.name;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
