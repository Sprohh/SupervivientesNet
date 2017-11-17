using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SupervivientesNet.Servicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IUsuarios
    {
        [OperationContract]
        CompositeType Autenticar(string user, string pass);

        // TODO: agregue aquí sus operaciones de servicio
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class CompositeType
    {
        bool _autenticado = true;
        string _nombre = "";

        [DataMember]
        public bool Autenticado
        {
            get { return _autenticado; }
            set { _autenticado = value; }
        }

        [DataMember]
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
    }
}
