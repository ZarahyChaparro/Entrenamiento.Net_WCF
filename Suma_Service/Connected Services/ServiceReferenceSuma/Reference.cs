﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Suma_Service.ServiceReferenceSuma {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceSuma.Service_Suma")]
    public interface Service_Suma {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Service_Suma/sumarNumeros", ReplyAction="http://tempuri.org/Service_Suma/sumarNumerosResponse")]
        int sumarNumeros(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Service_Suma/sumarNumeros", ReplyAction="http://tempuri.org/Service_Suma/sumarNumerosResponse")]
        System.Threading.Tasks.Task<int> sumarNumerosAsync(int num1, int num2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Service_SumaChannel : Suma_Service.ServiceReferenceSuma.Service_Suma, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service_SumaClient : System.ServiceModel.ClientBase<Suma_Service.ServiceReferenceSuma.Service_Suma>, Suma_Service.ServiceReferenceSuma.Service_Suma {
        
        public Service_SumaClient() {
        }
        
        public Service_SumaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service_SumaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service_SumaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service_SumaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int sumarNumeros(int num1, int num2) {
            return base.Channel.sumarNumeros(num1, num2);
        }
        
        public System.Threading.Tasks.Task<int> sumarNumerosAsync(int num1, int num2) {
            return base.Channel.sumarNumerosAsync(num1, num2);
        }
    }
}