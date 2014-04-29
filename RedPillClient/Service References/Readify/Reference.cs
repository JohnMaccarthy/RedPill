﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RedPillClient.Readify {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ContactDetails", Namespace="http://KnockKnock.readify.net")]
    [System.SerializableAttribute()]
    public partial class ContactDetails : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FamilyNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GivenNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneNumberField;
        
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
        public string EmailAddress {
            get {
                return this.EmailAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailAddressField, value) != true)) {
                    this.EmailAddressField = value;
                    this.RaisePropertyChanged("EmailAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FamilyName {
            get {
                return this.FamilyNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FamilyNameField, value) != true)) {
                    this.FamilyNameField = value;
                    this.RaisePropertyChanged("FamilyName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string GivenName {
            get {
                return this.GivenNameField;
            }
            set {
                if ((object.ReferenceEquals(this.GivenNameField, value) != true)) {
                    this.GivenNameField = value;
                    this.RaisePropertyChanged("GivenName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhoneNumber {
            get {
                return this.PhoneNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneNumberField, value) != true)) {
                    this.PhoneNumberField = value;
                    this.RaisePropertyChanged("PhoneNumber");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="TriangleType", Namespace="http://KnockKnock.readify.net")]
    public enum TriangleType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Error = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Equilateral = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Isosceles = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Scalene = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://KnockKnock.readify.net", ConfigurationName="Readify.IRedPill")]
    public interface IRedPill {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://KnockKnock.readify.net/IRedPill/WhoAreYou", ReplyAction="http://KnockKnock.readify.net/IRedPill/WhoAreYouResponse")]
        ContactDetails WhoAreYou();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://KnockKnock.readify.net/IRedPill/WhoAreYou", ReplyAction="http://KnockKnock.readify.net/IRedPill/WhoAreYouResponse")]
        System.Threading.Tasks.Task<ContactDetails> WhoAreYouAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://KnockKnock.readify.net/IRedPill/FibonacciNumber", ReplyAction="http://KnockKnock.readify.net/IRedPill/FibonacciNumberResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.ArgumentOutOfRangeException), Action="http://KnockKnock.readify.net/IRedPill/FibonacciNumberArgumentOutOfRangeException" +
            "Fault", Name="ArgumentOutOfRangeException", Namespace="http://schemas.datacontract.org/2004/07/System")]
        long FibonacciNumber(long n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://KnockKnock.readify.net/IRedPill/FibonacciNumber", ReplyAction="http://KnockKnock.readify.net/IRedPill/FibonacciNumberResponse")]
        System.Threading.Tasks.Task<long> FibonacciNumberAsync(long n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://KnockKnock.readify.net/IRedPill/WhatShapeIsThis", ReplyAction="http://KnockKnock.readify.net/IRedPill/WhatShapeIsThisResponse")]
        TriangleType WhatShapeIsThis(int a, int b, int c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://KnockKnock.readify.net/IRedPill/WhatShapeIsThis", ReplyAction="http://KnockKnock.readify.net/IRedPill/WhatShapeIsThisResponse")]
        System.Threading.Tasks.Task<TriangleType> WhatShapeIsThisAsync(int a, int b, int c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://KnockKnock.readify.net/IRedPill/ReverseWords", ReplyAction="http://KnockKnock.readify.net/IRedPill/ReverseWordsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.ArgumentNullException), Action="http://KnockKnock.readify.net/IRedPill/ReverseWordsArgumentNullExceptionFault", Name="ArgumentNullException", Namespace="http://schemas.datacontract.org/2004/07/System")]
        string ReverseWords(string s);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://KnockKnock.readify.net/IRedPill/ReverseWords", ReplyAction="http://KnockKnock.readify.net/IRedPill/ReverseWordsResponse")]
        System.Threading.Tasks.Task<string> ReverseWordsAsync(string s);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRedPillChannel : IRedPill, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RedPillClient : System.ServiceModel.ClientBase<IRedPill>, IRedPill {
        
        public RedPillClient() {
        }
        
        public RedPillClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RedPillClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RedPillClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RedPillClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ContactDetails WhoAreYou() {
            return base.Channel.WhoAreYou();
        }
        
        public System.Threading.Tasks.Task<ContactDetails> WhoAreYouAsync() {
            return base.Channel.WhoAreYouAsync();
        }
        
        public long FibonacciNumber(long n) {
            return base.Channel.FibonacciNumber(n);
        }
        
        public System.Threading.Tasks.Task<long> FibonacciNumberAsync(long n) {
            return base.Channel.FibonacciNumberAsync(n);
        }
        
        public TriangleType WhatShapeIsThis(int a, int b, int c) {
            return base.Channel.WhatShapeIsThis(a, b, c);
        }
        
        public System.Threading.Tasks.Task<TriangleType> WhatShapeIsThisAsync(int a, int b, int c) {
            return base.Channel.WhatShapeIsThisAsync(a, b, c);
        }
        
        public string ReverseWords(string s) {
            return base.Channel.ReverseWords(s);
        }
        
        public System.Threading.Tasks.Task<string> ReverseWordsAsync(string s) {
            return base.Channel.ReverseWordsAsync(s);
        }
    }
}