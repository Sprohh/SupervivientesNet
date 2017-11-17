using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupervivientesNet.Negocios
{
    public class Estadisticas
    {
        public string recintoMasSolicitado()
        {
            int i = 1;
            int max = 0;
            int id = 0;
            int tope = Conexion.AutomatizacionDB.petition.Max(idc => idc.infrastructure);
            while (i <= tope)
            {
                int idMasSolicitado = Conexion.AutomatizacionDB.petition.Count(idc => idc.infrastructure == i);
                if (idMasSolicitado > max)
                {
                    max = idMasSolicitado;
                    id = i;
                }
                i++;
            }
            return Conexion.AutomatizacionDB.infrastructure.First(nom => nom.idinfrastructure == id).name;
        }

        public string DiaConMasSolicitudes()
        {
            int i = 1;
            int max = 0;
            int id = 0;
            int tope = Conexion.AutomatizacionDB.petition.Max(idc => idc.dayoftheweek);
            while (i <= tope)
            {
                int idMasSolicitado = Conexion.AutomatizacionDB.petition.Count(idc => idc.dayoftheweek == i);
                if (idMasSolicitado > max)
                {
                    max = idMasSolicitado;
                    id = i;
                }
                i++;
            }
            return Conexion.AutomatizacionDB.dayoftheweek.First(nom => nom.idday == id).name;
        }

        public string BloqueMasPedido()
        {
            int i = 1;
            int max = 0;
            int id = 0;
            int tope = Conexion.AutomatizacionDB.petition.Max(idc => idc.block);
            while (i <= tope)
            {
                int idMasSolicitado = Conexion.AutomatizacionDB.petition.Count(idc => idc.block == i);
                if (idMasSolicitado > max)
                {
                    max = idMasSolicitado;
                    id = i;
                }
                i++;
            }
            return Conexion.AutomatizacionDB.block.First(nom => nom.idblock == id).name;
        }
    }
}
