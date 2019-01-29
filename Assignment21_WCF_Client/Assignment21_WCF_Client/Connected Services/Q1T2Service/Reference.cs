﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment21_WCF_Client.Q1T2Service {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Openings", Namespace="http://schemas.datacontract.org/2004/07/Assignment21_WCF_Service_Q1_Task2")]
    [System.SerializableAttribute()]
    public partial class Openings : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string JobField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Assignment21_WCF_Client.Q1T2Service.RoleType RoleField;
        
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
        public string Job {
            get {
                return this.JobField;
            }
            set {
                if ((object.ReferenceEquals(this.JobField, value) != true)) {
                    this.JobField = value;
                    this.RaisePropertyChanged("Job");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Assignment21_WCF_Client.Q1T2Service.RoleType Role {
            get {
                return this.RoleField;
            }
            set {
                if ((this.RoleField.Equals(value) != true)) {
                    this.RoleField = value;
                    this.RaisePropertyChanged("Role");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RoleType", Namespace="http://schemas.datacontract.org/2004/07/Assignment21_WCF_Service_Q1_Task2")]
    public enum RoleType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Trainee = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Analyst = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SeniorAnalyst = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Lead = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Q1T2Service.IQ1T2")]
    public interface IQ1T2 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQ1T2/OpeningsJobs", ReplyAction="http://tempuri.org/IQ1T2/OpeningsJobsResponse")]
        System.Collections.Generic.List<Assignment21_WCF_Client.Q1T2Service.Openings> OpeningsJobs();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQ1T2/OpeningsJobs", ReplyAction="http://tempuri.org/IQ1T2/OpeningsJobsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Assignment21_WCF_Client.Q1T2Service.Openings>> OpeningsJobsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQ1T2/OpeningJobsByRole", ReplyAction="http://tempuri.org/IQ1T2/OpeningJobsByRoleResponse")]
        System.Collections.Generic.List<Assignment21_WCF_Client.Q1T2Service.Openings> OpeningJobsByRole(Assignment21_WCF_Client.Q1T2Service.RoleType Role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQ1T2/OpeningJobsByRole", ReplyAction="http://tempuri.org/IQ1T2/OpeningJobsByRoleResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Assignment21_WCF_Client.Q1T2Service.Openings>> OpeningJobsByRoleAsync(Assignment21_WCF_Client.Q1T2Service.RoleType Role);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IQ1T2Channel : Assignment21_WCF_Client.Q1T2Service.IQ1T2, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Q1T2Client : System.ServiceModel.ClientBase<Assignment21_WCF_Client.Q1T2Service.IQ1T2>, Assignment21_WCF_Client.Q1T2Service.IQ1T2 {
        
        public Q1T2Client() {
        }
        
        public Q1T2Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Q1T2Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Q1T2Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Q1T2Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<Assignment21_WCF_Client.Q1T2Service.Openings> OpeningsJobs() {
            return base.Channel.OpeningsJobs();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Assignment21_WCF_Client.Q1T2Service.Openings>> OpeningsJobsAsync() {
            return base.Channel.OpeningsJobsAsync();
        }
        
        public System.Collections.Generic.List<Assignment21_WCF_Client.Q1T2Service.Openings> OpeningJobsByRole(Assignment21_WCF_Client.Q1T2Service.RoleType Role) {
            return base.Channel.OpeningJobsByRole(Role);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Assignment21_WCF_Client.Q1T2Service.Openings>> OpeningJobsByRoleAsync(Assignment21_WCF_Client.Q1T2Service.RoleType Role) {
            return base.Channel.OpeningJobsByRoleAsync(Role);
        }
    }
}
