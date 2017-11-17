using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupervivientesNet.Negocios
{
    class DiaSemana
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public DiaSemana()
        {
            Id = 0;
            Nombre = "";
        }

        public DiaSemana(int i, string nom)
        {
            Id = i;
            Nombre = nom;
        }

        public bool Read()
        {
            try
            {
                Datos.dayoftheweek dofw = Conexion.AutomatizacionDB.dayoftheweek.First(dow => dow.idday == Id);
                Id = dofw.idday;
                Nombre = dofw.name;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
