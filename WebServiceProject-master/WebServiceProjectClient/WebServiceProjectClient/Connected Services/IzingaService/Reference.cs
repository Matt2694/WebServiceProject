﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServiceProjectClient.IzingaService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Log", Namespace="http://schemas.datacontract.org/2004/07/WebServiceProjectTest")]
    [System.SerializableAttribute()]
    public partial class Log : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AfdelingValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime AfmeldtValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AlarmValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BoligValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NavnValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime TidValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AfdelingValue {
            get {
                return this.AfdelingValueField;
            }
            set {
                if ((object.ReferenceEquals(this.AfdelingValueField, value) != true)) {
                    this.AfdelingValueField = value;
                    this.RaisePropertyChanged("AfdelingValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime AfmeldtValue {
            get {
                return this.AfmeldtValueField;
            }
            set {
                if ((this.AfmeldtValueField.Equals(value) != true)) {
                    this.AfmeldtValueField = value;
                    this.RaisePropertyChanged("AfmeldtValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AlarmValue {
            get {
                return this.AlarmValueField;
            }
            set {
                if ((object.ReferenceEquals(this.AlarmValueField, value) != true)) {
                    this.AlarmValueField = value;
                    this.RaisePropertyChanged("AlarmValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BoligValue {
            get {
                return this.BoligValueField;
            }
            set {
                if ((object.ReferenceEquals(this.BoligValueField, value) != true)) {
                    this.BoligValueField = value;
                    this.RaisePropertyChanged("BoligValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IDValue {
            get {
                return this.IDValueField;
            }
            set {
                if ((this.IDValueField.Equals(value) != true)) {
                    this.IDValueField = value;
                    this.RaisePropertyChanged("IDValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NavnValue {
            get {
                return this.NavnValueField;
            }
            set {
                if ((object.ReferenceEquals(this.NavnValueField, value) != true)) {
                    this.NavnValueField = value;
                    this.RaisePropertyChanged("NavnValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime TidValue {
            get {
                return this.TidValueField;
            }
            set {
                if ((this.TidValueField.Equals(value) != true)) {
                    this.TidValueField = value;
                    this.RaisePropertyChanged("TidValue");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IzingaService.IIzingaService", CallbackContract=typeof(WebServiceProjectClient.IzingaService.IIzingaServiceCallback), SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IIzingaService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIzingaService/Subscribe", ReplyAction="http://tempuri.org/IIzingaService/SubscribeResponse")]
        void Subscribe();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIzingaService/Subscribe", ReplyAction="http://tempuri.org/IIzingaService/SubscribeResponse")]
        System.Threading.Tasks.Task SubscribeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIzingaService/Unsubscribe", ReplyAction="http://tempuri.org/IIzingaService/UnsubscribeResponse")]
        void Unsubscribe();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIzingaService/Unsubscribe", ReplyAction="http://tempuri.org/IIzingaService/UnsubscribeResponse")]
        System.Threading.Tasks.Task UnsubscribeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIzingaService/PublishResult", ReplyAction="http://tempuri.org/IIzingaService/PublishResultResponse")]
        void PublishResult();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIzingaService/PublishResult", ReplyAction="http://tempuri.org/IIzingaService/PublishResultResponse")]
        System.Threading.Tasks.Task PublishResultAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IIzingaServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IIzingaService/CallbackPublishResult")]
        void CallbackPublishResult(WebServiceProjectClient.IzingaService.Log[] list);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IIzingaServiceChannel : WebServiceProjectClient.IzingaService.IIzingaService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IzingaServiceClient : System.ServiceModel.DuplexClientBase<WebServiceProjectClient.IzingaService.IIzingaService>, WebServiceProjectClient.IzingaService.IIzingaService {
        
        public IzingaServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public IzingaServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public IzingaServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public IzingaServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public IzingaServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void Subscribe() {
            base.Channel.Subscribe();
        }
        
        public System.Threading.Tasks.Task SubscribeAsync() {
            return base.Channel.SubscribeAsync();
        }
        
        public void Unsubscribe() {
            base.Channel.Unsubscribe();
        }
        
        public System.Threading.Tasks.Task UnsubscribeAsync() {
            return base.Channel.UnsubscribeAsync();
        }
        
        public void PublishResult() {
            base.Channel.PublishResult();
        }
        
        public System.Threading.Tasks.Task PublishResultAsync() {
            return base.Channel.PublishResultAsync();
        }
    }
}
