﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Kaynak kodu Microsoft.VSDesigner tarafından otomatik üretilmiş , Sürüm 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace webServisUygulamaConsole.urunWebServis {
    using System.Diagnostics;
    using System;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="urunServisSoap", Namespace="http://tempuri.org/")]
    public partial class urunServis : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback urunKayitYeniOperationCompleted;
        
        private System.Threading.SendOrPostCallback urunKayitDuzenleOperationCompleted;
        
        private System.Threading.SendOrPostCallback urunKayitSilOperationCompleted;
        
        private System.Threading.SendOrPostCallback urunTumListeOperationCompleted;
        
        private System.Threading.SendOrPostCallback urunGetirOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public urunServis() {
            this.Url = global::webServisUygulamaConsole.Properties.Settings.Default.webServisUygulamaConsole_urunWebServis_urunServis;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event urunKayitYeniCompletedEventHandler urunKayitYeniCompleted;
        
        /// <remarks/>
        public event urunKayitDuzenleCompletedEventHandler urunKayitDuzenleCompleted;
        
        /// <remarks/>
        public event urunKayitSilCompletedEventHandler urunKayitSilCompleted;
        
        /// <remarks/>
        public event urunTumListeCompletedEventHandler urunTumListeCompleted;
        
        /// <remarks/>
        public event urunGetirCompletedEventHandler urunGetirCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/urunKayitYeni", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public outputType urunKayitYeni(urun u, guvenlik g) {
            object[] results = this.Invoke("urunKayitYeni", new object[] {
                        u,
                        g});
            return ((outputType)(results[0]));
        }
        
        /// <remarks/>
        public void urunKayitYeniAsync(urun u, guvenlik g) {
            this.urunKayitYeniAsync(u, g, null);
        }
        
        /// <remarks/>
        public void urunKayitYeniAsync(urun u, guvenlik g, object userState) {
            if ((this.urunKayitYeniOperationCompleted == null)) {
                this.urunKayitYeniOperationCompleted = new System.Threading.SendOrPostCallback(this.OnurunKayitYeniOperationCompleted);
            }
            this.InvokeAsync("urunKayitYeni", new object[] {
                        u,
                        g}, this.urunKayitYeniOperationCompleted, userState);
        }
        
        private void OnurunKayitYeniOperationCompleted(object arg) {
            if ((this.urunKayitYeniCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.urunKayitYeniCompleted(this, new urunKayitYeniCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/urunKayitDuzenle", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public outputType urunKayitDuzenle(urun u) {
            object[] results = this.Invoke("urunKayitDuzenle", new object[] {
                        u});
            return ((outputType)(results[0]));
        }
        
        /// <remarks/>
        public void urunKayitDuzenleAsync(urun u) {
            this.urunKayitDuzenleAsync(u, null);
        }
        
        /// <remarks/>
        public void urunKayitDuzenleAsync(urun u, object userState) {
            if ((this.urunKayitDuzenleOperationCompleted == null)) {
                this.urunKayitDuzenleOperationCompleted = new System.Threading.SendOrPostCallback(this.OnurunKayitDuzenleOperationCompleted);
            }
            this.InvokeAsync("urunKayitDuzenle", new object[] {
                        u}, this.urunKayitDuzenleOperationCompleted, userState);
        }
        
        private void OnurunKayitDuzenleOperationCompleted(object arg) {
            if ((this.urunKayitDuzenleCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.urunKayitDuzenleCompleted(this, new urunKayitDuzenleCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/urunKayitSil", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public outputType urunKayitSil(string urunKimlik) {
            object[] results = this.Invoke("urunKayitSil", new object[] {
                        urunKimlik});
            return ((outputType)(results[0]));
        }
        
        /// <remarks/>
        public void urunKayitSilAsync(string urunKimlik) {
            this.urunKayitSilAsync(urunKimlik, null);
        }
        
        /// <remarks/>
        public void urunKayitSilAsync(string urunKimlik, object userState) {
            if ((this.urunKayitSilOperationCompleted == null)) {
                this.urunKayitSilOperationCompleted = new System.Threading.SendOrPostCallback(this.OnurunKayitSilOperationCompleted);
            }
            this.InvokeAsync("urunKayitSil", new object[] {
                        urunKimlik}, this.urunKayitSilOperationCompleted, userState);
        }
        
        private void OnurunKayitSilOperationCompleted(object arg) {
            if ((this.urunKayitSilCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.urunKayitSilCompleted(this, new urunKayitSilCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/urunTumListe", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public urun[] urunTumListe() {
            object[] results = this.Invoke("urunTumListe", new object[0]);
            return ((urun[])(results[0]));
        }
        
        /// <remarks/>
        public void urunTumListeAsync() {
            this.urunTumListeAsync(null);
        }
        
        /// <remarks/>
        public void urunTumListeAsync(object userState) {
            if ((this.urunTumListeOperationCompleted == null)) {
                this.urunTumListeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnurunTumListeOperationCompleted);
            }
            this.InvokeAsync("urunTumListe", new object[0], this.urunTumListeOperationCompleted, userState);
        }
        
        private void OnurunTumListeOperationCompleted(object arg) {
            if ((this.urunTumListeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.urunTumListeCompleted(this, new urunTumListeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/urunGetir", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public urun urunGetir(string urunKimlik) {
            object[] results = this.Invoke("urunGetir", new object[] {
                        urunKimlik});
            return ((urun)(results[0]));
        }
        
        /// <remarks/>
        public void urunGetirAsync(string urunKimlik) {
            this.urunGetirAsync(urunKimlik, null);
        }
        
        /// <remarks/>
        public void urunGetirAsync(string urunKimlik, object userState) {
            if ((this.urunGetirOperationCompleted == null)) {
                this.urunGetirOperationCompleted = new System.Threading.SendOrPostCallback(this.OnurunGetirOperationCompleted);
            }
            this.InvokeAsync("urunGetir", new object[] {
                        urunKimlik}, this.urunGetirOperationCompleted, userState);
        }
        
        private void OnurunGetirOperationCompleted(object arg) {
            if ((this.urunGetirCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.urunGetirCompleted(this, new urunGetirCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class urun {
        
        private int idField;
        
        private string urunKimlikField;
        
        private string tanimField;
        
        private string aciklamaField;
        
        private int stokAdetField;
        
        /// <remarks/>
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string urunKimlik {
            get {
                return this.urunKimlikField;
            }
            set {
                this.urunKimlikField = value;
            }
        }
        
        /// <remarks/>
        public string tanim {
            get {
                return this.tanimField;
            }
            set {
                this.tanimField = value;
            }
        }
        
        /// <remarks/>
        public string aciklama {
            get {
                return this.aciklamaField;
            }
            set {
                this.aciklamaField = value;
            }
        }
        
        /// <remarks/>
        public int stokAdet {
            get {
                return this.stokAdetField;
            }
            set {
                this.stokAdetField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class guvenlik {
        
        private string kullaniciAdiField;
        
        private string sifreField;
        
        private string clientKeyField;
        
        private string tokenTimeField;
        
        private int privateValueField;
        
        /// <remarks/>
        public string kullaniciAdi {
            get {
                return this.kullaniciAdiField;
            }
            set {
                this.kullaniciAdiField = value;
            }
        }
        
        /// <remarks/>
        public string sifre {
            get {
                return this.sifreField;
            }
            set {
                this.sifreField = value;
            }
        }
        
        /// <remarks/>
        public string clientKey {
            get {
                return this.clientKeyField;
            }
            set {
                this.clientKeyField = value;
            }
        }
        
        /// <remarks/>
        public string tokenTime {
            get {
                return this.tokenTimeField;
            }
            set {
                this.tokenTimeField = value;
            }
        }
        
        /// <remarks/>
        public int privateValue {
            get {
                return this.privateValueField;
            }
            set {
                this.privateValueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public enum outputType {
        
        /// <remarks/>
        islemBasarili,
        
        /// <remarks/>
        islemBasarisiz,
        
        /// <remarks/>
        tanimsiz,
        
        /// <remarks/>
        kayitliUrun,
        
        /// <remarks/>
        yeniUrun,
        
        /// <remarks/>
        urunBulunamadi,
        
        /// <remarks/>
        guvenlikHatasi,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void urunKayitYeniCompletedEventHandler(object sender, urunKayitYeniCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class urunKayitYeniCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal urunKayitYeniCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public outputType Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((outputType)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void urunKayitDuzenleCompletedEventHandler(object sender, urunKayitDuzenleCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class urunKayitDuzenleCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal urunKayitDuzenleCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public outputType Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((outputType)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void urunKayitSilCompletedEventHandler(object sender, urunKayitSilCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class urunKayitSilCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal urunKayitSilCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public outputType Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((outputType)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void urunTumListeCompletedEventHandler(object sender, urunTumListeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class urunTumListeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal urunTumListeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public urun[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((urun[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void urunGetirCompletedEventHandler(object sender, urunGetirCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class urunGetirCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal urunGetirCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public urun Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((urun)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591