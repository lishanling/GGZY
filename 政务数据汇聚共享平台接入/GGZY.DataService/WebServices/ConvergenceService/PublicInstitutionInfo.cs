﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码由 wsdl 自动生成, Version=4.8.3928.0。
// 
namespace GGZY.DataService.ConvergenceService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="PublicInstitutionInfoSoap", Namespace="http://tempuri.org/")]
    public partial class PublicInstitutionInfo : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback queryByTyshxydmOperationCompleted;
        
        private System.Threading.SendOrPostCallback queryByMcOperationCompleted;
        
        /// <remarks/>
        public PublicInstitutionInfo() {
            this.Url = "http://220.160.52.50:801/ConvergenceSerivce/PublicInstitutionInfo.asmx";
        }
        
        /// <remarks/>
        public event queryByTyshxydmCompletedEventHandler queryByTyshxydmCompleted;
        
        /// <remarks/>
        public event queryByMcCompletedEventHandler queryByMcCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/queryByTyshxydm", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string queryByTyshxydm(string guid, string requestid, string tyshxydm) {
            object[] results = this.Invoke("queryByTyshxydm", new object[] {
                        guid,
                        requestid,
                        tyshxydm});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginqueryByTyshxydm(string guid, string requestid, string tyshxydm, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("queryByTyshxydm", new object[] {
                        guid,
                        requestid,
                        tyshxydm}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndqueryByTyshxydm(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void queryByTyshxydmAsync(string guid, string requestid, string tyshxydm) {
            this.queryByTyshxydmAsync(guid, requestid, tyshxydm, null);
        }
        
        /// <remarks/>
        public void queryByTyshxydmAsync(string guid, string requestid, string tyshxydm, object userState) {
            if ((this.queryByTyshxydmOperationCompleted == null)) {
                this.queryByTyshxydmOperationCompleted = new System.Threading.SendOrPostCallback(this.OnqueryByTyshxydmOperationCompleted);
            }
            this.InvokeAsync("queryByTyshxydm", new object[] {
                        guid,
                        requestid,
                        tyshxydm}, this.queryByTyshxydmOperationCompleted, userState);
        }
        
        private void OnqueryByTyshxydmOperationCompleted(object arg) {
            if ((this.queryByTyshxydmCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.queryByTyshxydmCompleted(this, new queryByTyshxydmCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/queryByMc", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string queryByMc(string guid, string requestid, string mc) {
            object[] results = this.Invoke("queryByMc", new object[] {
                        guid,
                        requestid,
                        mc});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginqueryByMc(string guid, string requestid, string mc, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("queryByMc", new object[] {
                        guid,
                        requestid,
                        mc}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndqueryByMc(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void queryByMcAsync(string guid, string requestid, string mc) {
            this.queryByMcAsync(guid, requestid, mc, null);
        }
        
        /// <remarks/>
        public void queryByMcAsync(string guid, string requestid, string mc, object userState) {
            if ((this.queryByMcOperationCompleted == null)) {
                this.queryByMcOperationCompleted = new System.Threading.SendOrPostCallback(this.OnqueryByMcOperationCompleted);
            }
            this.InvokeAsync("queryByMc", new object[] {
                        guid,
                        requestid,
                        mc}, this.queryByMcOperationCompleted, userState);
        }
        
        private void OnqueryByMcOperationCompleted(object arg) {
            if ((this.queryByMcCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.queryByMcCompleted(this, new queryByMcCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    public delegate void queryByTyshxydmCompletedEventHandler(object sender, queryByTyshxydmCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class queryByTyshxydmCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal queryByTyshxydmCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    public delegate void queryByMcCompletedEventHandler(object sender, queryByMcCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class queryByMcCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal queryByMcCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}
