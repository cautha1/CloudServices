﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TafesaClient.CourseServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Course", Namespace="http://schemas.datacontract.org/2004/07/Assignment614.Classes")]
    [System.SerializableAttribute()]
    public partial class Course : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal CostField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CourseIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CourseNameField;
        
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
        public decimal Cost {
            get {
                return this.CostField;
            }
            set {
                if ((this.CostField.Equals(value) != true)) {
                    this.CostField = value;
                    this.RaisePropertyChanged("Cost");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CourseID {
            get {
                return this.CourseIDField;
            }
            set {
                if ((this.CourseIDField.Equals(value) != true)) {
                    this.CourseIDField = value;
                    this.RaisePropertyChanged("CourseID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CourseName {
            get {
                return this.CourseNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CourseNameField, value) != true)) {
                    this.CourseNameField = value;
                    this.RaisePropertyChanged("CourseName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CourseServiceReference.ICourseAdmin")]
    public interface ICourseAdmin {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourseAdmin/AddCourse", ReplyAction="http://tempuri.org/ICourseAdmin/AddCourseResponse")]
        void AddCourse(string courseName, decimal cost);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourseAdmin/AddCourse", ReplyAction="http://tempuri.org/ICourseAdmin/AddCourseResponse")]
        System.Threading.Tasks.Task AddCourseAsync(string courseName, decimal cost);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourseAdmin/GetAllCourses", ReplyAction="http://tempuri.org/ICourseAdmin/GetAllCoursesResponse")]
        TafesaClient.CourseServiceReference.Course[] GetAllCourses();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourseAdmin/GetAllCourses", ReplyAction="http://tempuri.org/ICourseAdmin/GetAllCoursesResponse")]
        System.Threading.Tasks.Task<TafesaClient.CourseServiceReference.Course[]> GetAllCoursesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICourseAdminChannel : TafesaClient.CourseServiceReference.ICourseAdmin, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CourseAdminClient : System.ServiceModel.ClientBase<TafesaClient.CourseServiceReference.ICourseAdmin>, TafesaClient.CourseServiceReference.ICourseAdmin {
        
        public CourseAdminClient() {
        }
        
        public CourseAdminClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CourseAdminClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CourseAdminClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CourseAdminClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddCourse(string courseName, decimal cost) {
            base.Channel.AddCourse(courseName, cost);
        }
        
        public System.Threading.Tasks.Task AddCourseAsync(string courseName, decimal cost) {
            return base.Channel.AddCourseAsync(courseName, cost);
        }
        
        public TafesaClient.CourseServiceReference.Course[] GetAllCourses() {
            return base.Channel.GetAllCourses();
        }
        
        public System.Threading.Tasks.Task<TafesaClient.CourseServiceReference.Course[]> GetAllCoursesAsync() {
            return base.Channel.GetAllCoursesAsync();
        }
    }
}
