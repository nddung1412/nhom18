﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace giayit.ServiceReferenceChiTietPhieuNhap {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceChiTietPhieuNhap.IServiceChiTietPhieuNhap")]
    public interface IServiceChiTietPhieuNhap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChiTietPhieuNhap/DoWork", ReplyAction="http://tempuri.org/IServiceChiTietPhieuNhap/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChiTietPhieuNhap/DoWork", ReplyAction="http://tempuri.org/IServiceChiTietPhieuNhap/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChiTietPhieuNhapChannel : giayit.ServiceReferenceChiTietPhieuNhap.IServiceChiTietPhieuNhap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceChiTietPhieuNhapClient : System.ServiceModel.ClientBase<giayit.ServiceReferenceChiTietPhieuNhap.IServiceChiTietPhieuNhap>, giayit.ServiceReferenceChiTietPhieuNhap.IServiceChiTietPhieuNhap {
        
        public ServiceChiTietPhieuNhapClient() {
        }
        
        public ServiceChiTietPhieuNhapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceChiTietPhieuNhapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceChiTietPhieuNhapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceChiTietPhieuNhapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
    }
}