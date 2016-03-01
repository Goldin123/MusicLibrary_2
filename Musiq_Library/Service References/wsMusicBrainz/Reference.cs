﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Musiq_Library.wsMusicBrainz {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Artists", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Artists : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ArtistNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CountryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AliasesField;
        
        private System.Nullable<bool> FavouritesField;
        
        private System.Nullable<bool> ShortListField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string ArtistName {
            get {
                return this.ArtistNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ArtistNameField, value) != true)) {
                    this.ArtistNameField = value;
                    this.RaisePropertyChanged("ArtistName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Country {
            get {
                return this.CountryField;
            }
            set {
                if ((object.ReferenceEquals(this.CountryField, value) != true)) {
                    this.CountryField = value;
                    this.RaisePropertyChanged("Country");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Aliases {
            get {
                return this.AliasesField;
            }
            set {
                if ((object.ReferenceEquals(this.AliasesField, value) != true)) {
                    this.AliasesField = value;
                    this.RaisePropertyChanged("Aliases");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public System.Nullable<bool> Favourites {
            get {
                return this.FavouritesField;
            }
            set {
                if ((this.FavouritesField.Equals(value) != true)) {
                    this.FavouritesField = value;
                    this.RaisePropertyChanged("Favourites");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public System.Nullable<bool> ShortList {
            get {
                return this.ShortListField;
            }
            set {
                if ((this.ShortListField.Equals(value) != true)) {
                    this.ShortListField = value;
                    this.RaisePropertyChanged("ShortList");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Releases", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Releases : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LabelField;
        
        private int NumberOfTracksField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OtherArtistsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string YearReleaseField;
        
        private System.Nullable<bool> bFavouriteField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Status {
            get {
                return this.StatusField;
            }
            set {
                if ((object.ReferenceEquals(this.StatusField, value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Label {
            get {
                return this.LabelField;
            }
            set {
                if ((object.ReferenceEquals(this.LabelField, value) != true)) {
                    this.LabelField = value;
                    this.RaisePropertyChanged("Label");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public int NumberOfTracks {
            get {
                return this.NumberOfTracksField;
            }
            set {
                if ((this.NumberOfTracksField.Equals(value) != true)) {
                    this.NumberOfTracksField = value;
                    this.RaisePropertyChanged("NumberOfTracks");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string OtherArtists {
            get {
                return this.OtherArtistsField;
            }
            set {
                if ((object.ReferenceEquals(this.OtherArtistsField, value) != true)) {
                    this.OtherArtistsField = value;
                    this.RaisePropertyChanged("OtherArtists");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string YearRelease {
            get {
                return this.YearReleaseField;
            }
            set {
                if ((object.ReferenceEquals(this.YearReleaseField, value) != true)) {
                    this.YearReleaseField = value;
                    this.RaisePropertyChanged("YearRelease");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=7)]
        public System.Nullable<bool> bFavourite {
            get {
                return this.bFavouriteField;
            }
            set {
                if ((this.bFavouriteField.Equals(value) != true)) {
                    this.bFavouriteField = value;
                    this.RaisePropertyChanged("bFavourite");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="wsMusicBrainz.MusicBrainzSoap")]
    public interface MusicBrainzSoap {
        
        // CODEGEN: Generating message contract since element name Name from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getArtistList", ReplyAction="*")]
        Musiq_Library.wsMusicBrainz.getArtistListResponse getArtistList(Musiq_Library.wsMusicBrainz.getArtistListRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getArtistList", ReplyAction="*")]
        System.Threading.Tasks.Task<Musiq_Library.wsMusicBrainz.getArtistListResponse> getArtistListAsync(Musiq_Library.wsMusicBrainz.getArtistListRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateFavouriteReleases", ReplyAction="*")]
        void UpdateFavouriteReleases(int ID, bool bFavourites);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateFavouriteReleases", ReplyAction="*")]
        System.Threading.Tasks.Task UpdateFavouriteReleasesAsync(int ID, bool bFavourites);
        
        // CODEGEN: Generating message contract since element name getArtistReleasesResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getArtistReleases", ReplyAction="*")]
        Musiq_Library.wsMusicBrainz.getArtistReleasesResponse getArtistReleases(Musiq_Library.wsMusicBrainz.getArtistReleasesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getArtistReleases", ReplyAction="*")]
        System.Threading.Tasks.Task<Musiq_Library.wsMusicBrainz.getArtistReleasesResponse> getArtistReleasesAsync(Musiq_Library.wsMusicBrainz.getArtistReleasesRequest request);
        
        // CODEGEN: Generating message contract since element name getFavouriteReleasesResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getFavouriteReleases", ReplyAction="*")]
        Musiq_Library.wsMusicBrainz.getFavouriteReleasesResponse getFavouriteReleases(Musiq_Library.wsMusicBrainz.getFavouriteReleasesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getFavouriteReleases", ReplyAction="*")]
        System.Threading.Tasks.Task<Musiq_Library.wsMusicBrainz.getFavouriteReleasesResponse> getFavouriteReleasesAsync(Musiq_Library.wsMusicBrainz.getFavouriteReleasesRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getArtistListRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getArtistList", Namespace="http://tempuri.org/", Order=0)]
        public Musiq_Library.wsMusicBrainz.getArtistListRequestBody Body;
        
        public getArtistListRequest() {
        }
        
        public getArtistListRequest(Musiq_Library.wsMusicBrainz.getArtistListRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getArtistListRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Name;
        
        public getArtistListRequestBody() {
        }
        
        public getArtistListRequestBody(string Name) {
            this.Name = Name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getArtistListResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getArtistListResponse", Namespace="http://tempuri.org/", Order=0)]
        public Musiq_Library.wsMusicBrainz.getArtistListResponseBody Body;
        
        public getArtistListResponse() {
        }
        
        public getArtistListResponse(Musiq_Library.wsMusicBrainz.getArtistListResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getArtistListResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Musiq_Library.wsMusicBrainz.Artists[] getArtistListResult;
        
        public getArtistListResponseBody() {
        }
        
        public getArtistListResponseBody(Musiq_Library.wsMusicBrainz.Artists[] getArtistListResult) {
            this.getArtistListResult = getArtistListResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getArtistReleasesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getArtistReleases", Namespace="http://tempuri.org/", Order=0)]
        public Musiq_Library.wsMusicBrainz.getArtistReleasesRequestBody Body;
        
        public getArtistReleasesRequest() {
        }
        
        public getArtistReleasesRequest(Musiq_Library.wsMusicBrainz.getArtistReleasesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getArtistReleasesRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int ID;
        
        public getArtistReleasesRequestBody() {
        }
        
        public getArtistReleasesRequestBody(int ID) {
            this.ID = ID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getArtistReleasesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getArtistReleasesResponse", Namespace="http://tempuri.org/", Order=0)]
        public Musiq_Library.wsMusicBrainz.getArtistReleasesResponseBody Body;
        
        public getArtistReleasesResponse() {
        }
        
        public getArtistReleasesResponse(Musiq_Library.wsMusicBrainz.getArtistReleasesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getArtistReleasesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Musiq_Library.wsMusicBrainz.Releases[] getArtistReleasesResult;
        
        public getArtistReleasesResponseBody() {
        }
        
        public getArtistReleasesResponseBody(Musiq_Library.wsMusicBrainz.Releases[] getArtistReleasesResult) {
            this.getArtistReleasesResult = getArtistReleasesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getFavouriteReleasesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getFavouriteReleases", Namespace="http://tempuri.org/", Order=0)]
        public Musiq_Library.wsMusicBrainz.getFavouriteReleasesRequestBody Body;
        
        public getFavouriteReleasesRequest() {
        }
        
        public getFavouriteReleasesRequest(Musiq_Library.wsMusicBrainz.getFavouriteReleasesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class getFavouriteReleasesRequestBody {
        
        public getFavouriteReleasesRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getFavouriteReleasesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getFavouriteReleasesResponse", Namespace="http://tempuri.org/", Order=0)]
        public Musiq_Library.wsMusicBrainz.getFavouriteReleasesResponseBody Body;
        
        public getFavouriteReleasesResponse() {
        }
        
        public getFavouriteReleasesResponse(Musiq_Library.wsMusicBrainz.getFavouriteReleasesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getFavouriteReleasesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Musiq_Library.wsMusicBrainz.Releases[] getFavouriteReleasesResult;
        
        public getFavouriteReleasesResponseBody() {
        }
        
        public getFavouriteReleasesResponseBody(Musiq_Library.wsMusicBrainz.Releases[] getFavouriteReleasesResult) {
            this.getFavouriteReleasesResult = getFavouriteReleasesResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MusicBrainzSoapChannel : Musiq_Library.wsMusicBrainz.MusicBrainzSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MusicBrainzSoapClient : System.ServiceModel.ClientBase<Musiq_Library.wsMusicBrainz.MusicBrainzSoap>, Musiq_Library.wsMusicBrainz.MusicBrainzSoap {
        
        public MusicBrainzSoapClient() {
        }
        
        public MusicBrainzSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MusicBrainzSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MusicBrainzSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MusicBrainzSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Musiq_Library.wsMusicBrainz.getArtistListResponse Musiq_Library.wsMusicBrainz.MusicBrainzSoap.getArtistList(Musiq_Library.wsMusicBrainz.getArtistListRequest request) {
            return base.Channel.getArtistList(request);
        }
        
        public Musiq_Library.wsMusicBrainz.Artists[] getArtistList(string Name) {
            Musiq_Library.wsMusicBrainz.getArtistListRequest inValue = new Musiq_Library.wsMusicBrainz.getArtistListRequest();
            inValue.Body = new Musiq_Library.wsMusicBrainz.getArtistListRequestBody();
            inValue.Body.Name = Name;
            Musiq_Library.wsMusicBrainz.getArtistListResponse retVal = ((Musiq_Library.wsMusicBrainz.MusicBrainzSoap)(this)).getArtistList(inValue);
            return retVal.Body.getArtistListResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Musiq_Library.wsMusicBrainz.getArtistListResponse> Musiq_Library.wsMusicBrainz.MusicBrainzSoap.getArtistListAsync(Musiq_Library.wsMusicBrainz.getArtistListRequest request) {
            return base.Channel.getArtistListAsync(request);
        }
        
        public System.Threading.Tasks.Task<Musiq_Library.wsMusicBrainz.getArtistListResponse> getArtistListAsync(string Name) {
            Musiq_Library.wsMusicBrainz.getArtistListRequest inValue = new Musiq_Library.wsMusicBrainz.getArtistListRequest();
            inValue.Body = new Musiq_Library.wsMusicBrainz.getArtistListRequestBody();
            inValue.Body.Name = Name;
            return ((Musiq_Library.wsMusicBrainz.MusicBrainzSoap)(this)).getArtistListAsync(inValue);
        }
        
        public void UpdateFavouriteReleases(int ID, bool bFavourites) {
            base.Channel.UpdateFavouriteReleases(ID, bFavourites);
        }
        
        public System.Threading.Tasks.Task UpdateFavouriteReleasesAsync(int ID, bool bFavourites) {
            return base.Channel.UpdateFavouriteReleasesAsync(ID, bFavourites);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Musiq_Library.wsMusicBrainz.getArtistReleasesResponse Musiq_Library.wsMusicBrainz.MusicBrainzSoap.getArtistReleases(Musiq_Library.wsMusicBrainz.getArtistReleasesRequest request) {
            return base.Channel.getArtistReleases(request);
        }
        
        public Musiq_Library.wsMusicBrainz.Releases[] getArtistReleases(int ID) {
            Musiq_Library.wsMusicBrainz.getArtistReleasesRequest inValue = new Musiq_Library.wsMusicBrainz.getArtistReleasesRequest();
            inValue.Body = new Musiq_Library.wsMusicBrainz.getArtistReleasesRequestBody();
            inValue.Body.ID = ID;
            Musiq_Library.wsMusicBrainz.getArtistReleasesResponse retVal = ((Musiq_Library.wsMusicBrainz.MusicBrainzSoap)(this)).getArtistReleases(inValue);
            return retVal.Body.getArtistReleasesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Musiq_Library.wsMusicBrainz.getArtistReleasesResponse> Musiq_Library.wsMusicBrainz.MusicBrainzSoap.getArtistReleasesAsync(Musiq_Library.wsMusicBrainz.getArtistReleasesRequest request) {
            return base.Channel.getArtistReleasesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Musiq_Library.wsMusicBrainz.getArtistReleasesResponse> getArtistReleasesAsync(int ID) {
            Musiq_Library.wsMusicBrainz.getArtistReleasesRequest inValue = new Musiq_Library.wsMusicBrainz.getArtistReleasesRequest();
            inValue.Body = new Musiq_Library.wsMusicBrainz.getArtistReleasesRequestBody();
            inValue.Body.ID = ID;
            return ((Musiq_Library.wsMusicBrainz.MusicBrainzSoap)(this)).getArtistReleasesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Musiq_Library.wsMusicBrainz.getFavouriteReleasesResponse Musiq_Library.wsMusicBrainz.MusicBrainzSoap.getFavouriteReleases(Musiq_Library.wsMusicBrainz.getFavouriteReleasesRequest request) {
            return base.Channel.getFavouriteReleases(request);
        }
        
        public Musiq_Library.wsMusicBrainz.Releases[] getFavouriteReleases() {
            Musiq_Library.wsMusicBrainz.getFavouriteReleasesRequest inValue = new Musiq_Library.wsMusicBrainz.getFavouriteReleasesRequest();
            inValue.Body = new Musiq_Library.wsMusicBrainz.getFavouriteReleasesRequestBody();
            Musiq_Library.wsMusicBrainz.getFavouriteReleasesResponse retVal = ((Musiq_Library.wsMusicBrainz.MusicBrainzSoap)(this)).getFavouriteReleases(inValue);
            return retVal.Body.getFavouriteReleasesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Musiq_Library.wsMusicBrainz.getFavouriteReleasesResponse> Musiq_Library.wsMusicBrainz.MusicBrainzSoap.getFavouriteReleasesAsync(Musiq_Library.wsMusicBrainz.getFavouriteReleasesRequest request) {
            return base.Channel.getFavouriteReleasesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Musiq_Library.wsMusicBrainz.getFavouriteReleasesResponse> getFavouriteReleasesAsync() {
            Musiq_Library.wsMusicBrainz.getFavouriteReleasesRequest inValue = new Musiq_Library.wsMusicBrainz.getFavouriteReleasesRequest();
            inValue.Body = new Musiq_Library.wsMusicBrainz.getFavouriteReleasesRequestBody();
            return ((Musiq_Library.wsMusicBrainz.MusicBrainzSoap)(this)).getFavouriteReleasesAsync(inValue);
        }
    }
}
