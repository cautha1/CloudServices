﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TafesaClient.StudentServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Student", Namespace="http://schemas.datacontract.org/2004/07/Assignment614.Classes")]
    [System.SerializableAttribute()]
    public partial class Student : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateEnrolledField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StudentIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StudentNameField;
        
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
        public System.DateTime DateEnrolled {
            get {
                return this.DateEnrolledField;
            }
            set {
                if ((this.DateEnrolledField.Equals(value) != true)) {
                    this.DateEnrolledField = value;
                    this.RaisePropertyChanged("DateEnrolled");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int StudentID {
            get {
                return this.StudentIDField;
            }
            set {
                if ((this.StudentIDField.Equals(value) != true)) {
                    this.StudentIDField = value;
                    this.RaisePropertyChanged("StudentID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StudentName {
            get {
                return this.StudentNameField;
            }
            set {
                if ((object.ReferenceEquals(this.StudentNameField, value) != true)) {
                    this.StudentNameField = value;
                    this.RaisePropertyChanged("StudentName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="StudentServiceReference.IStudentAdmin")]
    public interface IStudentAdmin {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentAdmin/AddStudent", ReplyAction="http://tempuri.org/IStudentAdmin/AddStudentResponse")]
        void AddStudent(string studentName, System.DateTime dateEnrolled);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentAdmin/AddStudent", ReplyAction="http://tempuri.org/IStudentAdmin/AddStudentResponse")]
        System.Threading.Tasks.Task AddStudentAsync(string studentName, System.DateTime dateEnrolled);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentAdmin/GetAllStudents", ReplyAction="http://tempuri.org/IStudentAdmin/GetAllStudentsResponse")]
        TafesaClient.StudentServiceReference.Student[] GetAllStudents();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentAdmin/GetAllStudents", ReplyAction="http://tempuri.org/IStudentAdmin/GetAllStudentsResponse")]
        System.Threading.Tasks.Task<TafesaClient.StudentServiceReference.Student[]> GetAllStudentsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IStudentAdminChannel : TafesaClient.StudentServiceReference.IStudentAdmin, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StudentAdminClient : System.ServiceModel.ClientBase<TafesaClient.StudentServiceReference.IStudentAdmin>, TafesaClient.StudentServiceReference.IStudentAdmin {
        
        public StudentAdminClient() {
        }
        
        public StudentAdminClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StudentAdminClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StudentAdminClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StudentAdminClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddStudent(string studentName, System.DateTime dateEnrolled) {
            base.Channel.AddStudent(studentName, dateEnrolled);
        }
        
        public System.Threading.Tasks.Task AddStudentAsync(string studentName, System.DateTime dateEnrolled) {
            return base.Channel.AddStudentAsync(studentName, dateEnrolled);
        }
        
        public TafesaClient.StudentServiceReference.Student[] GetAllStudents() {
            return base.Channel.GetAllStudents();
        }
        
        public System.Threading.Tasks.Task<TafesaClient.StudentServiceReference.Student[]> GetAllStudentsAsync() {
            return base.Channel.GetAllStudentsAsync();
        }
    }
}
