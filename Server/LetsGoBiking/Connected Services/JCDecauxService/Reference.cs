﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RoutingServer.JCDecauxService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Contract", Namespace="http://schemas.datacontract.org/2004/07/JCDecauxProxy.Models")]
    [System.SerializableAttribute()]
    public partial class Contract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] CitiesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CommercialNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CountryCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public string[] Cities {
            get {
                return this.CitiesField;
            }
            set {
                if ((object.ReferenceEquals(this.CitiesField, value) != true)) {
                    this.CitiesField = value;
                    this.RaisePropertyChanged("Cities");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CommercialName {
            get {
                return this.CommercialNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CommercialNameField, value) != true)) {
                    this.CommercialNameField = value;
                    this.RaisePropertyChanged("CommercialName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CountryCode {
            get {
                return this.CountryCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.CountryCodeField, value) != true)) {
                    this.CountryCodeField = value;
                    this.RaisePropertyChanged("CountryCode");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Station", Namespace="http://schemas.datacontract.org/2004/07/JCDecauxProxy.Models")]
    [System.SerializableAttribute()]
    public partial class Station : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BankingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BonusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] CitiesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContractNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private RoutingServer.JCDecauxService.Location PositionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private RoutingServer.JCDecauxService.StationStatus StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private RoutingServer.JCDecauxService.Stand TotalStandsField;
        
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
        public bool Banking {
            get {
                return this.BankingField;
            }
            set {
                if ((this.BankingField.Equals(value) != true)) {
                    this.BankingField = value;
                    this.RaisePropertyChanged("Banking");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Bonus {
            get {
                return this.BonusField;
            }
            set {
                if ((this.BonusField.Equals(value) != true)) {
                    this.BonusField = value;
                    this.RaisePropertyChanged("Bonus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] Cities {
            get {
                return this.CitiesField;
            }
            set {
                if ((object.ReferenceEquals(this.CitiesField, value) != true)) {
                    this.CitiesField = value;
                    this.RaisePropertyChanged("Cities");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ContractName {
            get {
                return this.ContractNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ContractNameField, value) != true)) {
                    this.ContractNameField = value;
                    this.RaisePropertyChanged("ContractName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Number {
            get {
                return this.NumberField;
            }
            set {
                if ((this.NumberField.Equals(value) != true)) {
                    this.NumberField = value;
                    this.RaisePropertyChanged("Number");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public RoutingServer.JCDecauxService.Location Position {
            get {
                return this.PositionField;
            }
            set {
                if ((object.ReferenceEquals(this.PositionField, value) != true)) {
                    this.PositionField = value;
                    this.RaisePropertyChanged("Position");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public RoutingServer.JCDecauxService.StationStatus Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public RoutingServer.JCDecauxService.Stand TotalStands {
            get {
                return this.TotalStandsField;
            }
            set {
                if ((object.ReferenceEquals(this.TotalStandsField, value) != true)) {
                    this.TotalStandsField = value;
                    this.RaisePropertyChanged("TotalStands");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Location", Namespace="http://schemas.datacontract.org/2004/07/JCDecauxProxy.Models")]
    [System.SerializableAttribute()]
    public partial class Location : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double LatitudeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double LongitudeField;
        
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
        public double Latitude {
            get {
                return this.LatitudeField;
            }
            set {
                if ((this.LatitudeField.Equals(value) != true)) {
                    this.LatitudeField = value;
                    this.RaisePropertyChanged("Latitude");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Longitude {
            get {
                return this.LongitudeField;
            }
            set {
                if ((this.LongitudeField.Equals(value) != true)) {
                    this.LongitudeField = value;
                    this.RaisePropertyChanged("Longitude");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Stand", Namespace="http://schemas.datacontract.org/2004/07/JCDecauxProxy.Models.BaseModels")]
    [System.SerializableAttribute()]
    public partial class Stand : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private RoutingServer.JCDecauxService.Availability AvailabilityField;
        
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
        public RoutingServer.JCDecauxService.Availability Availability {
            get {
                return this.AvailabilityField;
            }
            set {
                if ((object.ReferenceEquals(this.AvailabilityField, value) != true)) {
                    this.AvailabilityField = value;
                    this.RaisePropertyChanged("Availability");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="StationStatus", Namespace="http://schemas.datacontract.org/2004/07/JCDecauxProxy.Models")]
    public enum StationStatus : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        OPEN = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CLOSED = 1,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Availability", Namespace="http://schemas.datacontract.org/2004/07/JCDecauxProxy.Models.BaseModels")]
    [System.SerializableAttribute()]
    public partial class Availability : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BikesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ElectricalBikesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ElectricalInternalBatteryBikesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ElectricalRemovableBatteryBikesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MechanicalBikesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StandsField;
        
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
        public int Bikes {
            get {
                return this.BikesField;
            }
            set {
                if ((this.BikesField.Equals(value) != true)) {
                    this.BikesField = value;
                    this.RaisePropertyChanged("Bikes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ElectricalBikes {
            get {
                return this.ElectricalBikesField;
            }
            set {
                if ((this.ElectricalBikesField.Equals(value) != true)) {
                    this.ElectricalBikesField = value;
                    this.RaisePropertyChanged("ElectricalBikes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ElectricalInternalBatteryBikes {
            get {
                return this.ElectricalInternalBatteryBikesField;
            }
            set {
                if ((this.ElectricalInternalBatteryBikesField.Equals(value) != true)) {
                    this.ElectricalInternalBatteryBikesField = value;
                    this.RaisePropertyChanged("ElectricalInternalBatteryBikes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ElectricalRemovableBatteryBikes {
            get {
                return this.ElectricalRemovableBatteryBikesField;
            }
            set {
                if ((this.ElectricalRemovableBatteryBikesField.Equals(value) != true)) {
                    this.ElectricalRemovableBatteryBikesField = value;
                    this.RaisePropertyChanged("ElectricalRemovableBatteryBikes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MechanicalBikes {
            get {
                return this.MechanicalBikesField;
            }
            set {
                if ((this.MechanicalBikesField.Equals(value) != true)) {
                    this.MechanicalBikesField = value;
                    this.RaisePropertyChanged("MechanicalBikes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Stands {
            get {
                return this.StandsField;
            }
            set {
                if ((this.StandsField.Equals(value) != true)) {
                    this.StandsField = value;
                    this.RaisePropertyChanged("Stands");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/JCDecauxProxy")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="JCDecauxService.IProxyService")]
    public interface IProxyService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProxyService/GetContracts", ReplyAction="http://tempuri.org/IProxyService/GetContractsResponse")]
        RoutingServer.JCDecauxService.Contract[] GetContracts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProxyService/GetContracts", ReplyAction="http://tempuri.org/IProxyService/GetContractsResponse")]
        System.Threading.Tasks.Task<RoutingServer.JCDecauxService.Contract[]> GetContractsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProxyService/GetStations", ReplyAction="http://tempuri.org/IProxyService/GetStationsResponse")]
        RoutingServer.JCDecauxService.Station[] GetStations(string contractName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProxyService/GetStations", ReplyAction="http://tempuri.org/IProxyService/GetStationsResponse")]
        System.Threading.Tasks.Task<RoutingServer.JCDecauxService.Station[]> GetStationsAsync(string contractName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProxyService/FindClosestStationWithBikes", ReplyAction="http://tempuri.org/IProxyService/FindClosestStationWithBikesResponse")]
        RoutingServer.JCDecauxService.Station FindClosestStationWithBikes(string contractName, RoutingServer.JCDecauxService.Location origin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProxyService/FindClosestStationWithBikes", ReplyAction="http://tempuri.org/IProxyService/FindClosestStationWithBikesResponse")]
        System.Threading.Tasks.Task<RoutingServer.JCDecauxService.Station> FindClosestStationWithBikesAsync(string contractName, RoutingServer.JCDecauxService.Location origin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProxyService/FindClosestStationWithStands", ReplyAction="http://tempuri.org/IProxyService/FindClosestStationWithStandsResponse")]
        RoutingServer.JCDecauxService.Station FindClosestStationWithStands(string contractName, RoutingServer.JCDecauxService.Location origin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProxyService/FindClosestStationWithStands", ReplyAction="http://tempuri.org/IProxyService/FindClosestStationWithStandsResponse")]
        System.Threading.Tasks.Task<RoutingServer.JCDecauxService.Station> FindClosestStationWithStandsAsync(string contractName, RoutingServer.JCDecauxService.Location origin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProxyService/UpdateStationWithBikesStateOrFindClosest", ReplyAction="http://tempuri.org/IProxyService/UpdateStationWithBikesStateOrFindClosestResponse" +
            "")]
        RoutingServer.JCDecauxService.Station UpdateStationWithBikesStateOrFindClosest(RoutingServer.JCDecauxService.Station station, RoutingServer.JCDecauxService.Location location);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProxyService/UpdateStationWithBikesStateOrFindClosest", ReplyAction="http://tempuri.org/IProxyService/UpdateStationWithBikesStateOrFindClosestResponse" +
            "")]
        System.Threading.Tasks.Task<RoutingServer.JCDecauxService.Station> UpdateStationWithBikesStateOrFindClosestAsync(RoutingServer.JCDecauxService.Station station, RoutingServer.JCDecauxService.Location location);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProxyService/UpdateStationWithStandsStateOrFindClosest", ReplyAction="http://tempuri.org/IProxyService/UpdateStationWithStandsStateOrFindClosestRespons" +
            "e")]
        RoutingServer.JCDecauxService.Station UpdateStationWithStandsStateOrFindClosest(RoutingServer.JCDecauxService.Station station, RoutingServer.JCDecauxService.Location location);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProxyService/UpdateStationWithStandsStateOrFindClosest", ReplyAction="http://tempuri.org/IProxyService/UpdateStationWithStandsStateOrFindClosestRespons" +
            "e")]
        System.Threading.Tasks.Task<RoutingServer.JCDecauxService.Station> UpdateStationWithStandsStateOrFindClosestAsync(RoutingServer.JCDecauxService.Station station, RoutingServer.JCDecauxService.Location location);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProxyService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IProxyService/GetDataUsingDataContractResponse")]
        RoutingServer.JCDecauxService.CompositeType GetDataUsingDataContract(RoutingServer.JCDecauxService.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProxyService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IProxyService/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<RoutingServer.JCDecauxService.CompositeType> GetDataUsingDataContractAsync(RoutingServer.JCDecauxService.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProxyServiceChannel : RoutingServer.JCDecauxService.IProxyService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProxyServiceClient : System.ServiceModel.ClientBase<RoutingServer.JCDecauxService.IProxyService>, RoutingServer.JCDecauxService.IProxyService {
        
        public ProxyServiceClient() {
        }
        
        public ProxyServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProxyServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProxyServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProxyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public RoutingServer.JCDecauxService.Contract[] GetContracts() {
            return base.Channel.GetContracts();
        }
        
        public System.Threading.Tasks.Task<RoutingServer.JCDecauxService.Contract[]> GetContractsAsync() {
            return base.Channel.GetContractsAsync();
        }
        
        public RoutingServer.JCDecauxService.Station[] GetStations(string contractName) {
            return base.Channel.GetStations(contractName);
        }
        
        public System.Threading.Tasks.Task<RoutingServer.JCDecauxService.Station[]> GetStationsAsync(string contractName) {
            return base.Channel.GetStationsAsync(contractName);
        }
        
        public RoutingServer.JCDecauxService.Station FindClosestStationWithBikes(string contractName, RoutingServer.JCDecauxService.Location origin) {
            return base.Channel.FindClosestStationWithBikes(contractName, origin);
        }
        
        public System.Threading.Tasks.Task<RoutingServer.JCDecauxService.Station> FindClosestStationWithBikesAsync(string contractName, RoutingServer.JCDecauxService.Location origin) {
            return base.Channel.FindClosestStationWithBikesAsync(contractName, origin);
        }
        
        public RoutingServer.JCDecauxService.Station FindClosestStationWithStands(string contractName, RoutingServer.JCDecauxService.Location origin) {
            return base.Channel.FindClosestStationWithStands(contractName, origin);
        }
        
        public System.Threading.Tasks.Task<RoutingServer.JCDecauxService.Station> FindClosestStationWithStandsAsync(string contractName, RoutingServer.JCDecauxService.Location origin) {
            return base.Channel.FindClosestStationWithStandsAsync(contractName, origin);
        }
        
        public RoutingServer.JCDecauxService.Station UpdateStationWithBikesStateOrFindClosest(RoutingServer.JCDecauxService.Station station, RoutingServer.JCDecauxService.Location location) {
            return base.Channel.UpdateStationWithBikesStateOrFindClosest(station, location);
        }
        
        public System.Threading.Tasks.Task<RoutingServer.JCDecauxService.Station> UpdateStationWithBikesStateOrFindClosestAsync(RoutingServer.JCDecauxService.Station station, RoutingServer.JCDecauxService.Location location) {
            return base.Channel.UpdateStationWithBikesStateOrFindClosestAsync(station, location);
        }
        
        public RoutingServer.JCDecauxService.Station UpdateStationWithStandsStateOrFindClosest(RoutingServer.JCDecauxService.Station station, RoutingServer.JCDecauxService.Location location) {
            return base.Channel.UpdateStationWithStandsStateOrFindClosest(station, location);
        }
        
        public System.Threading.Tasks.Task<RoutingServer.JCDecauxService.Station> UpdateStationWithStandsStateOrFindClosestAsync(RoutingServer.JCDecauxService.Station station, RoutingServer.JCDecauxService.Location location) {
            return base.Channel.UpdateStationWithStandsStateOrFindClosestAsync(station, location);
        }
        
        public RoutingServer.JCDecauxService.CompositeType GetDataUsingDataContract(RoutingServer.JCDecauxService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<RoutingServer.JCDecauxService.CompositeType> GetDataUsingDataContractAsync(RoutingServer.JCDecauxService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}
