using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupervivientesNet.Datos;
namespace SupervivientesNet.Negocios
{
    public class Coleccion
    {
        public string[,] getHorario(int idInfraestructura) //Valor entre 1 y 4
        {
            string[,] salida = new string[15, 6];
            foreach(Datos.petition elemento in Conexion.AutomatizacionDB.petition)
            {
                int bloque = elemento.block - 1;
                int dia = elemento.dayoftheweek - 1;
                if (elemento.infrastructure == idInfraestructura)
                {
                    salida[bloque, dia] = elemento.account;
                }
            }
            return salida;
        }
    }
}
