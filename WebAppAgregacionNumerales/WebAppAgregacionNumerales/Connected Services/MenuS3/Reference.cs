﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAppAgregacionNumerales.MenuS3 {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://banrep.gov.co/s3")]
    public partial class AdministradorMenuException : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("message");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://banrep.gov.co/s3")]
    public partial class menuElement : object, System.ComponentModel.INotifyPropertyChanged {
        
        private long idField;
        
        private bool idFieldSpecified;
        
        private long idPadreField;
        
        private bool idPadreFieldSpecified;
        
        private bool isItemField;
        
        private bool isItemFieldSpecified;
        
        private int levelField;
        
        private bool levelFieldSpecified;
        
        private string linkField;
        
        private menuElement[] menuField;
        
        private string nombreField;
        
        private int ordenField;
        
        private bool ordenFieldSpecified;
        
        private string pathField;
        
        private string textoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public long id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idSpecified {
            get {
                return this.idFieldSpecified;
            }
            set {
                this.idFieldSpecified = value;
                this.RaisePropertyChanged("idSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public long idPadre {
            get {
                return this.idPadreField;
            }
            set {
                this.idPadreField = value;
                this.RaisePropertyChanged("idPadre");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idPadreSpecified {
            get {
                return this.idPadreFieldSpecified;
            }
            set {
                this.idPadreFieldSpecified = value;
                this.RaisePropertyChanged("idPadreSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public bool isItem {
            get {
                return this.isItemField;
            }
            set {
                this.isItemField = value;
                this.RaisePropertyChanged("isItem");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isItemSpecified {
            get {
                return this.isItemFieldSpecified;
            }
            set {
                this.isItemFieldSpecified = value;
                this.RaisePropertyChanged("isItemSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int level {
            get {
                return this.levelField;
            }
            set {
                this.levelField = value;
                this.RaisePropertyChanged("level");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool levelSpecified {
            get {
                return this.levelFieldSpecified;
            }
            set {
                this.levelFieldSpecified = value;
                this.RaisePropertyChanged("levelSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string link {
            get {
                return this.linkField;
            }
            set {
                this.linkField = value;
                this.RaisePropertyChanged("link");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("menu", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=5)]
        public menuElement[] menu {
            get {
                return this.menuField;
            }
            set {
                this.menuField = value;
                this.RaisePropertyChanged("menu");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("nombre");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public int orden {
            get {
                return this.ordenField;
            }
            set {
                this.ordenField = value;
                this.RaisePropertyChanged("orden");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ordenSpecified {
            get {
                return this.ordenFieldSpecified;
            }
            set {
                this.ordenFieldSpecified = value;
                this.RaisePropertyChanged("ordenSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string path {
            get {
                return this.pathField;
            }
            set {
                this.pathField = value;
                this.RaisePropertyChanged("path");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string texto {
            get {
                return this.textoField;
            }
            set {
                this.textoField = value;
                this.RaisePropertyChanged("texto");
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(respuestaConsultarMenuPerfil))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(menuRequest))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://banrep.gov.co/s3")]
    public partial class mensajeBase : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int codigoRespuestaField;
        
        private string descripcionField;
        
        private string idMensajeField;
        
        private string operacionField;
        
        private string origenField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int codigoRespuesta {
            get {
                return this.codigoRespuestaField;
            }
            set {
                this.codigoRespuestaField = value;
                this.RaisePropertyChanged("codigoRespuesta");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
                this.RaisePropertyChanged("descripcion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string idMensaje {
            get {
                return this.idMensajeField;
            }
            set {
                this.idMensajeField = value;
                this.RaisePropertyChanged("idMensaje");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string operacion {
            get {
                return this.operacionField;
            }
            set {
                this.operacionField = value;
                this.RaisePropertyChanged("operacion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string origen {
            get {
                return this.origenField;
            }
            set {
                this.origenField = value;
                this.RaisePropertyChanged("origen");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://banrep.gov.co/s3")]
    public partial class respuestaConsultarMenuPerfil : mensajeBase {
        
        private menuElement menuField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public menuElement menu {
            get {
                return this.menuField;
            }
            set {
                this.menuField = value;
                this.RaisePropertyChanged("menu");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://banrep.gov.co/s3")]
    public partial class menuRequest : mensajeBase {
        
        private string aplicacionField;
        
        private string usuarioField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string aplicacion {
            get {
                return this.aplicacionField;
            }
            set {
                this.aplicacionField = value;
                this.RaisePropertyChanged("aplicacion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string usuario {
            get {
                return this.usuarioField;
            }
            set {
                this.usuarioField = value;
                this.RaisePropertyChanged("usuario");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://banrep.gov.co/s3")]
    public partial class peticionConsultarMenuPerfil : object, System.ComponentModel.INotifyPropertyChanged {
        
        private menuRequest requestField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public menuRequest request {
            get {
                return this.requestField;
            }
            set {
                this.requestField = value;
                this.RaisePropertyChanged("request");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://banrep.gov.co/s3", ConfigurationName="MenuS3.AdministradorMenuWS")]
    public interface AdministradorMenuWS {
        
        // CODEGEN: El parámetro 'data' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="consultarMenuPerfil", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(WebAppAgregacionNumerales.MenuS3.AdministradorMenuException), Action="consultarMenuPerfil", Name="AdministradorMenuException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(mensajeBase))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WebAppAgregacionNumerales.MenuS3.consultarMenuPerfilResponse consultarMenuPerfil(WebAppAgregacionNumerales.MenuS3.consultarMenuPerfilRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="consultarMenuPerfil", ReplyAction="*")]
        System.Threading.Tasks.Task<WebAppAgregacionNumerales.MenuS3.consultarMenuPerfilResponse> consultarMenuPerfilAsync(WebAppAgregacionNumerales.MenuS3.consultarMenuPerfilRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="consultarMenuPerfil", WrapperNamespace="http://banrep.gov.co/s3", IsWrapped=true)]
    public partial class consultarMenuPerfilRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://banrep.gov.co/s3", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WebAppAgregacionNumerales.MenuS3.peticionConsultarMenuPerfil data;
        
        public consultarMenuPerfilRequest() {
        }
        
        public consultarMenuPerfilRequest(WebAppAgregacionNumerales.MenuS3.peticionConsultarMenuPerfil data) {
            this.data = data;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="consultarMenuPerfilResponse", WrapperNamespace="http://banrep.gov.co/s3", IsWrapped=true)]
    public partial class consultarMenuPerfilResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://banrep.gov.co/s3", Order=0)]
        public WebAppAgregacionNumerales.MenuS3.respuestaConsultarMenuPerfil @return;
        
        public consultarMenuPerfilResponse() {
        }
        
        public consultarMenuPerfilResponse(WebAppAgregacionNumerales.MenuS3.respuestaConsultarMenuPerfil @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AdministradorMenuWSChannel : WebAppAgregacionNumerales.MenuS3.AdministradorMenuWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AdministradorMenuWSClient : System.ServiceModel.ClientBase<WebAppAgregacionNumerales.MenuS3.AdministradorMenuWS>, WebAppAgregacionNumerales.MenuS3.AdministradorMenuWS {
        
        public AdministradorMenuWSClient() {
        }
        
        public AdministradorMenuWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AdministradorMenuWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdministradorMenuWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdministradorMenuWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebAppAgregacionNumerales.MenuS3.consultarMenuPerfilResponse WebAppAgregacionNumerales.MenuS3.AdministradorMenuWS.consultarMenuPerfil(WebAppAgregacionNumerales.MenuS3.consultarMenuPerfilRequest request) {
            return base.Channel.consultarMenuPerfil(request);
        }
        
        public WebAppAgregacionNumerales.MenuS3.respuestaConsultarMenuPerfil consultarMenuPerfil(WebAppAgregacionNumerales.MenuS3.peticionConsultarMenuPerfil data) {
            WebAppAgregacionNumerales.MenuS3.consultarMenuPerfilRequest inValue = new WebAppAgregacionNumerales.MenuS3.consultarMenuPerfilRequest();
            inValue.data = data;
            WebAppAgregacionNumerales.MenuS3.consultarMenuPerfilResponse retVal = ((WebAppAgregacionNumerales.MenuS3.AdministradorMenuWS)(this)).consultarMenuPerfil(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebAppAgregacionNumerales.MenuS3.consultarMenuPerfilResponse> WebAppAgregacionNumerales.MenuS3.AdministradorMenuWS.consultarMenuPerfilAsync(WebAppAgregacionNumerales.MenuS3.consultarMenuPerfilRequest request) {
            return base.Channel.consultarMenuPerfilAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebAppAgregacionNumerales.MenuS3.consultarMenuPerfilResponse> consultarMenuPerfilAsync(WebAppAgregacionNumerales.MenuS3.peticionConsultarMenuPerfil data) {
            WebAppAgregacionNumerales.MenuS3.consultarMenuPerfilRequest inValue = new WebAppAgregacionNumerales.MenuS3.consultarMenuPerfilRequest();
            inValue.data = data;
            return ((WebAppAgregacionNumerales.MenuS3.AdministradorMenuWS)(this)).consultarMenuPerfilAsync(inValue);
        }
    }
}
