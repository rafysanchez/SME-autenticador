﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.239.
// 
#pragma warning disable 1591

namespace Autenticador.WebServices.Consumer.Services
{
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Xml.Serialization;


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name = "ServiceUserLiveSoap", Namespace = "http://tempuri.org/")]
    public partial class ServiceUserLive : System.Web.Services.Protocols.SoapHttpClientProtocol
    {

        private ServiceValidation serviceValidationValueField;

        private System.Threading.SendOrPostCallback AlterarContaEmailSenhaOperationCompleted;

        private System.Threading.SendOrPostCallback CriarContaEmailAlunoOperationCompleted;

        private System.Threading.SendOrPostCallback CriarContaEmailDocenteOperationCompleted;

        private System.Threading.SendOrPostCallback CriarContaEmailColaboradorOperationCompleted;

        private System.Threading.SendOrPostCallback VerificarContaEmailExistenteOperationCompleted;

        private bool useDefaultCredentialsSetExplicitly;

        /// <remarks/>
        public ServiceUserLive()
        {
            this.Url = global::Autenticador.WebServices.Consumer.Properties.Settings.Default.Autenticador_WebServices_Consumer_Services_ServiceUserLive;
            if ((this.IsLocalFileSystemWebService(this.Url) == true))
            {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else
            {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }

        public ServiceValidation ServiceValidationValue
        {
            get
            {
                return this.serviceValidationValueField;
            }
            set
            {
                this.serviceValidationValueField = value;
            }
        }

        public new string Url
        {
            get
            {
                return base.Url;
            }
            set
            {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true)
                            && (this.useDefaultCredentialsSetExplicitly == false))
                            && (this.IsLocalFileSystemWebService(value) == false)))
                {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }

        public new bool UseDefaultCredentials
        {
            get
            {
                return base.UseDefaultCredentials;
            }
            set
            {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }

        /// <remarks/>
        public event AlterarContaEmailSenhaCompletedEventHandler AlterarContaEmailSenhaCompleted;

        /// <remarks/>
        public event CriarContaEmailAlunoCompletedEventHandler CriarContaEmailAlunoCompleted;

        /// <remarks/>
        public event CriarContaEmailDocenteCompletedEventHandler CriarContaEmailDocenteCompleted;

        /// <remarks/>
        public event CriarContaEmailColaboradorCompletedEventHandler CriarContaEmailColaboradorCompleted;

        /// <remarks/>
        public event VerificarContaEmailExistenteCompletedEventHandler VerificarContaEmailExistenteCompleted;

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServiceValidationValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AlterarContaEmailSenha", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ContaLive AlterarContaEmailSenha(string email, string novasenha, string situacao)
        {
            object[] results = this.Invoke("AlterarContaEmailSenha", new object[] {
                        email,
                        novasenha,
                        situacao});
            return ((ContaLive)(results[0]));
        }

        /// <remarks/>
        public void AlterarContaEmailSenhaAsync(string email, string novasenha, string situacao)
        {
            this.AlterarContaEmailSenhaAsync(email, novasenha, situacao, null);
        }

        /// <remarks/>
        public void AlterarContaEmailSenhaAsync(string email, string novasenha, string situacao, object userState)
        {
            if ((this.AlterarContaEmailSenhaOperationCompleted == null))
            {
                this.AlterarContaEmailSenhaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAlterarContaEmailSenhaOperationCompleted);
            }
            this.InvokeAsync("AlterarContaEmailSenha", new object[] {
                        email,
                        novasenha,
                        situacao}, this.AlterarContaEmailSenhaOperationCompleted, userState);
        }

        private void OnAlterarContaEmailSenhaOperationCompleted(object arg)
        {
            if ((this.AlterarContaEmailSenhaCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AlterarContaEmailSenhaCompleted(this, new AlterarContaEmailSenhaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServiceValidationValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CriarContaEmailAluno", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ContaLive CriarContaEmailAluno(string nome, string matricula, string escola, string turma, string serie)
        {
            object[] results = this.Invoke("CriarContaEmailAluno", new object[] {
                        nome,
                        matricula,
                        escola,
                        turma,
                        serie});
            return ((ContaLive)(results[0]));
        }

        /// <remarks/>
        public void CriarContaEmailAlunoAsync(string nome, string matricula, string escola, string turma, string serie)
        {
            this.CriarContaEmailAlunoAsync(nome, matricula, escola, turma, serie, null);
        }

        /// <remarks/>
        public void CriarContaEmailAlunoAsync(string nome, string matricula, string escola, string turma, string serie, object userState)
        {
            if ((this.CriarContaEmailAlunoOperationCompleted == null))
            {
                this.CriarContaEmailAlunoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCriarContaEmailAlunoOperationCompleted);
            }
            this.InvokeAsync("CriarContaEmailAluno", new object[] {
                        nome,
                        matricula,
                        escola,
                        turma,
                        serie}, this.CriarContaEmailAlunoOperationCompleted, userState);
        }

        private void OnCriarContaEmailAlunoOperationCompleted(object arg)
        {
            if ((this.CriarContaEmailAlunoCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CriarContaEmailAlunoCompleted(this, new CriarContaEmailAlunoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServiceValidationValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CriarContaEmailDocente", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ContaLive CriarContaEmailDocente(string nome, string matricula, string escola, string turma, string serie, string CPF, string disciplina)
        {
            object[] results = this.Invoke("CriarContaEmailDocente", new object[] {
                        nome,
                        matricula,
                        escola,
                        turma,
                        serie,
                        CPF,
                        disciplina});
            return ((ContaLive)(results[0]));
        }

        /// <remarks/>
        public void CriarContaEmailDocenteAsync(string nome, string matricula, string escola, string turma, string serie, string CPF, string disciplina)
        {
            this.CriarContaEmailDocenteAsync(nome, matricula, escola, turma, serie, CPF, disciplina, null);
        }

        /// <remarks/>
        public void CriarContaEmailDocenteAsync(string nome, string matricula, string escola, string turma, string serie, string CPF, string disciplina, object userState)
        {
            if ((this.CriarContaEmailDocenteOperationCompleted == null))
            {
                this.CriarContaEmailDocenteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCriarContaEmailDocenteOperationCompleted);
            }
            this.InvokeAsync("CriarContaEmailDocente", new object[] {
                        nome,
                        matricula,
                        escola,
                        turma,
                        serie,
                        CPF,
                        disciplina}, this.CriarContaEmailDocenteOperationCompleted, userState);
        }

        private void OnCriarContaEmailDocenteOperationCompleted(object arg)
        {
            if ((this.CriarContaEmailDocenteCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CriarContaEmailDocenteCompleted(this, new CriarContaEmailDocenteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServiceValidationValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CriarContaEmailColaborador", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ContaLive CriarContaEmailColaborador(string nome, string CPF, string cargo, string funcao, string setor)
        {
            object[] results = this.Invoke("CriarContaEmailColaborador", new object[] {
                        nome,
                        CPF,
                        cargo,
                        funcao,
                        setor});
            return ((ContaLive)(results[0]));
        }

        /// <remarks/>
        public void CriarContaEmailColaboradorAsync(string nome, string CPF, string cargo, string funcao, string setor)
        {
            this.CriarContaEmailColaboradorAsync(nome, CPF, cargo, funcao, setor, null);
        }

        /// <remarks/>
        public void CriarContaEmailColaboradorAsync(string nome, string CPF, string cargo, string funcao, string setor, object userState)
        {
            if ((this.CriarContaEmailColaboradorOperationCompleted == null))
            {
                this.CriarContaEmailColaboradorOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCriarContaEmailColaboradorOperationCompleted);
            }
            this.InvokeAsync("CriarContaEmailColaborador", new object[] {
                        nome,
                        CPF,
                        cargo,
                        funcao,
                        setor}, this.CriarContaEmailColaboradorOperationCompleted, userState);
        }

        private void OnCriarContaEmailColaboradorOperationCompleted(object arg)
        {
            if ((this.CriarContaEmailColaboradorCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CriarContaEmailColaboradorCompleted(this, new CriarContaEmailColaboradorCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServiceValidationValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/VerificarContaEmailExistente", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ContaLive VerificarContaEmailExistente(string email)
        {
            object[] results = this.Invoke("VerificarContaEmailExistente", new object[] {
                        email});
            return ((ContaLive)(results[0]));
        }

        /// <remarks/>
        public void VerificarContaEmailExistenteAsync(string email)
        {
            this.VerificarContaEmailExistenteAsync(email, null);
        }

        /// <remarks/>
        public void VerificarContaEmailExistenteAsync(string email, object userState)
        {
            if ((this.VerificarContaEmailExistenteOperationCompleted == null))
            {
                this.VerificarContaEmailExistenteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnVerificarContaEmailExistenteOperationCompleted);
            }
            this.InvokeAsync("VerificarContaEmailExistente", new object[] {
                        email}, this.VerificarContaEmailExistenteOperationCompleted, userState);
        }

        private void OnVerificarContaEmailExistenteOperationCompleted(object arg)
        {
            if ((this.VerificarContaEmailExistenteCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.VerificarContaEmailExistenteCompleted(this, new VerificarContaEmailExistenteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        public new void CancelAsync(object userState)
        {
            base.CancelAsync(userState);
        }

        private bool IsLocalFileSystemWebService(string url)
        {
            if (((url == null)
                        || (url == string.Empty)))
            {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024)
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0)))
            {
                return true;
            }
            return false;
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://tempuri.org/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/", IsNullable = false)]
    public partial class ServiceValidation : System.Web.Services.Protocols.SoapHeader
    {

        private string wSTokenField;

        private System.Xml.XmlAttribute[] anyAttrField;

        /// <remarks/>
        public string WSToken
        {
            get
            {
                return this.wSTokenField;
            }
            set
            {
                this.wSTokenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr
        {
            get
            {
                return this.anyAttrField;
            }
            set
            {
                this.anyAttrField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://tempuri.org/")]
    public partial class ContaLive
    {

        private string emailField;

        private string senhaField;

        private byte situacaoField;

        private byte statusField;

        private string erroField;

        /// <remarks/>
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }

        /// <remarks/>
        public string senha
        {
            get
            {
                return this.senhaField;
            }
            set
            {
                this.senhaField = value;
            }
        }

        /// <remarks/>
        public byte situacao
        {
            get
            {
                return this.situacaoField;
            }
            set
            {
                this.situacaoField = value;
            }
        }

        /// <remarks/>
        public byte status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        public string erro
        {
            get
            {
                return this.erroField;
            }
            set
            {
                this.erroField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void AlterarContaEmailSenhaCompletedEventHandler(object sender, AlterarContaEmailSenhaCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AlterarContaEmailSenhaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal AlterarContaEmailSenhaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ContaLive Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ContaLive)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void CriarContaEmailAlunoCompletedEventHandler(object sender, CriarContaEmailAlunoCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CriarContaEmailAlunoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal CriarContaEmailAlunoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ContaLive Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ContaLive)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void CriarContaEmailDocenteCompletedEventHandler(object sender, CriarContaEmailDocenteCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CriarContaEmailDocenteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal CriarContaEmailDocenteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ContaLive Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ContaLive)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void CriarContaEmailColaboradorCompletedEventHandler(object sender, CriarContaEmailColaboradorCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CriarContaEmailColaboradorCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal CriarContaEmailColaboradorCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ContaLive Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ContaLive)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void VerificarContaEmailExistenteCompletedEventHandler(object sender, VerificarContaEmailExistenteCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class VerificarContaEmailExistenteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal VerificarContaEmailExistenteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ContaLive Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ContaLive)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591