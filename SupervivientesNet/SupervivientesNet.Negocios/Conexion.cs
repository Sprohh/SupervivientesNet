using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupervivientesNet.Datos;

namespace SupervivientesNet.Negocios
{
    internal class Conexion
    {
        private static AutomatizacionEntities _automatizacionBD;

        public static AutomatizacionEntities AutomatizacionDB
        {
            get
            {
                if (_automatizacionBD == null)
                    _automatizacionBD = new AutomatizacionEntities();
                return _automatizacionBD;
            }
            set
            {
                _automatizacionBD = value;
            }
        }

    }
}
