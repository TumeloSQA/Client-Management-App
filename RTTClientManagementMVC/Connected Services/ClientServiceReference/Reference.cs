﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RTTClientManagementMVC.ClientServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ClientDetails", Namespace="http://schemas.datacontract.org/2004/07/RTTWcfService.Models")]
    [System.SerializableAttribute()]
    public partial class ClientDetails : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CellNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ClientIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string WorkTelField;
        
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
        public string CellNumber {
            get {
                return this.CellNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.CellNumberField, value) != true)) {
                    this.CellNumberField = value;
                    this.RaisePropertyChanged("CellNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ClientId {
            get {
                return this.ClientIdField;
            }
            set {
                if ((this.ClientIdField.Equals(value) != true)) {
                    this.ClientIdField = value;
                    this.RaisePropertyChanged("ClientId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((object.ReferenceEquals(this.GenderField, value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string WorkTel {
            get {
                return this.WorkTelField;
            }
            set {
                if ((object.ReferenceEquals(this.WorkTelField, value) != true)) {
                    this.WorkTelField = value;
                    this.RaisePropertyChanged("WorkTel");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AddressDetails", Namespace="http://schemas.datacontract.org/2004/07/RTTWcfService.Models")]
    [System.SerializableAttribute()]
    public partial class AddressDetails : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AddressIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ClientIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PosAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ResAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string WorkAddressField;
        
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
        public int AddressId {
            get {
                return this.AddressIdField;
            }
            set {
                if ((this.AddressIdField.Equals(value) != true)) {
                    this.AddressIdField = value;
                    this.RaisePropertyChanged("AddressId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ClientId {
            get {
                return this.ClientIdField;
            }
            set {
                if ((this.ClientIdField.Equals(value) != true)) {
                    this.ClientIdField = value;
                    this.RaisePropertyChanged("ClientId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PosAddress {
            get {
                return this.PosAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.PosAddressField, value) != true)) {
                    this.PosAddressField = value;
                    this.RaisePropertyChanged("PosAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ResAddress {
            get {
                return this.ResAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.ResAddressField, value) != true)) {
                    this.ResAddressField = value;
                    this.RaisePropertyChanged("ResAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string WorkAddress {
            get {
                return this.WorkAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.WorkAddressField, value) != true)) {
                    this.WorkAddressField = value;
                    this.RaisePropertyChanged("WorkAddress");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExceptionMessage", Namespace="http://schemas.datacontract.org/2004/07/RTTWcfService")]
    [System.SerializableAttribute()]
    public partial class ExceptionMessage : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string errorMessageOfActionField;
        
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
        public string errorMessageOfAction {
            get {
                return this.errorMessageOfActionField;
            }
            set {
                if ((object.ReferenceEquals(this.errorMessageOfActionField, value) != true)) {
                    this.errorMessageOfActionField = value;
                    this.RaisePropertyChanged("errorMessageOfAction");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ClientServiceReference.IClientDataService")]
    public interface IClientDataService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientDataService/InsertClientDetails", ReplyAction="http://tempuri.org/IClientDataService/InsertClientDetailsResponse")]
        string InsertClientDetails(RTTClientManagementMVC.ClientServiceReference.ClientDetails clientDetails, RTTClientManagementMVC.ClientServiceReference.AddressDetails addressDetails);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientDataService/InsertClientDetails", ReplyAction="http://tempuri.org/IClientDataService/InsertClientDetailsResponse")]
        System.Threading.Tasks.Task<string> InsertClientDetailsAsync(RTTClientManagementMVC.ClientServiceReference.ClientDetails clientDetails, RTTClientManagementMVC.ClientServiceReference.AddressDetails addressDetails);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientDataService/GetClientDetails", ReplyAction="http://tempuri.org/IClientDataService/GetClientDetailsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(RTTClientManagementMVC.ClientServiceReference.ExceptionMessage), Action="http://tempuri.org/IClientDataService/GetClientDetailsExceptionMessageFault", Name="ExceptionMessage", Namespace="http://schemas.datacontract.org/2004/07/RTTWcfService")]
        System.Data.DataSet GetClientDetails();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientDataService/GetClientDetails", ReplyAction="http://tempuri.org/IClientDataService/GetClientDetailsResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetClientDetailsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientDataService/DeleteClient", ReplyAction="http://tempuri.org/IClientDataService/DeleteClientResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(RTTClientManagementMVC.ClientServiceReference.ExceptionMessage), Action="http://tempuri.org/IClientDataService/DeleteClientExceptionMessageFault", Name="ExceptionMessage", Namespace="http://schemas.datacontract.org/2004/07/RTTWcfService")]
        int DeleteClient(int clientId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientDataService/DeleteClient", ReplyAction="http://tempuri.org/IClientDataService/DeleteClientResponse")]
        System.Threading.Tasks.Task<int> DeleteClientAsync(int clientId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IClientDataServiceChannel : RTTClientManagementMVC.ClientServiceReference.IClientDataService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClientDataServiceClient : System.ServiceModel.ClientBase<RTTClientManagementMVC.ClientServiceReference.IClientDataService>, RTTClientManagementMVC.ClientServiceReference.IClientDataService {
        
        public ClientDataServiceClient() {
        }
        
        public ClientDataServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClientDataServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientDataServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientDataServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string InsertClientDetails(RTTClientManagementMVC.ClientServiceReference.ClientDetails clientDetails, RTTClientManagementMVC.ClientServiceReference.AddressDetails addressDetails) {
            return base.Channel.InsertClientDetails(clientDetails, addressDetails);
        }
        
        public System.Threading.Tasks.Task<string> InsertClientDetailsAsync(RTTClientManagementMVC.ClientServiceReference.ClientDetails clientDetails, RTTClientManagementMVC.ClientServiceReference.AddressDetails addressDetails) {
            return base.Channel.InsertClientDetailsAsync(clientDetails, addressDetails);
        }
        
        public System.Data.DataSet GetClientDetails() {
            return base.Channel.GetClientDetails();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetClientDetailsAsync() {
            return base.Channel.GetClientDetailsAsync();
        }
        
        public int DeleteClient(int clientId) {
            return base.Channel.DeleteClient(clientId);
        }
        
        public System.Threading.Tasks.Task<int> DeleteClientAsync(int clientId) {
            return base.Channel.DeleteClientAsync(clientId);
        }
    }
}
