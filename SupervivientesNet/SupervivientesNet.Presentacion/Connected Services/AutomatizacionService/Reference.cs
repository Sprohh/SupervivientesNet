﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SupervivientesNet.Presentacion.AutomatizacionService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AutomatizacionService.IUsuarios")]
    public interface IUsuarios {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarios/Autenticar", ReplyAction="http://tempuri.org/IUsuarios/AutenticarResponse")]
        SupervivientesNet.Servicios.CompositeType Autenticar(string user, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarios/Autenticar", ReplyAction="http://tempuri.org/IUsuarios/AutenticarResponse")]
        System.Threading.Tasks.Task<SupervivientesNet.Servicios.CompositeType> AutenticarAsync(string user, string pass);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUsuariosChannel : SupervivientesNet.Presentacion.AutomatizacionService.IUsuarios, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UsuariosClient : System.ServiceModel.ClientBase<SupervivientesNet.Presentacion.AutomatizacionService.IUsuarios>, SupervivientesNet.Presentacion.AutomatizacionService.IUsuarios {
        
        public UsuariosClient() {
        }
        
        public UsuariosClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UsuariosClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsuariosClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsuariosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SupervivientesNet.Servicios.CompositeType Autenticar(string user, string pass) {
            return base.Channel.Autenticar(user, pass);
        }
        
        public System.Threading.Tasks.Task<SupervivientesNet.Servicios.CompositeType> AutenticarAsync(string user, string pass) {
            return base.Channel.AutenticarAsync(user, pass);
        }
    }
}
