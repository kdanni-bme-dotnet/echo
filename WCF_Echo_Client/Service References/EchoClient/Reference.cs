﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_Echo_Client.EchoClient {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EchoClient.EchoService")]
    public interface EchoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EchoService/Echo", ReplyAction="http://tempuri.org/EchoService/EchoResponse")]
        void Echo(string line);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EchoService/Echo", ReplyAction="http://tempuri.org/EchoService/EchoResponse")]
        System.Threading.Tasks.Task EchoAsync(string line);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface EchoServiceChannel : WCF_Echo_Client.EchoClient.EchoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EchoServiceClient : System.ServiceModel.ClientBase<WCF_Echo_Client.EchoClient.EchoService>, WCF_Echo_Client.EchoClient.EchoService {
        
        public EchoServiceClient() {
        }
        
        public EchoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EchoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EchoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EchoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Echo(string line) {
            base.Channel.Echo(line);
        }
        
        public System.Threading.Tasks.Task EchoAsync(string line) {
            return base.Channel.EchoAsync(line);
        }
    }
}
