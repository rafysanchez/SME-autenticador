﻿using Microsoft.Owin.Security;
using Autenticador.BLL;
using Autenticador.Entities;
using Autenticador.Web.WebProject;
using Autenticador.Web.WebProject.Authentication;
using System;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace Autenticador.Web.WebProject.HttpHandlers
{
    public class LoginServiceAspNetIdentity : MotherPage, IHttpHandler, IRequiresSessionState
    {
        private RetornoLoginJSON retorno = new RetornoLoginJSON();

        #region Propriedades

        private string entidade;
        private string login;
        private string senha;
        private string urlSistema;
        private string _formato = "html";

        private readonly string[] Formatos = { "html", "json" };

        #endregion Propriedades

        #region Métodos

        #region IHttpHandler Members

        public new bool IsReusable
        {
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            string provider = "";

            if (context.Request.Form.Count > 0)
            {
                this.entidade = context.Request.Form["txtEntidade"];
                this.login = context.Request.Form["txtLogin"];
                this.senha = context.Request.Form["txtSenha"];
                this.urlSistema = context.Request.Form["txtUrlSistema"];
                var formato = context.Request.Form["formato"];
                provider = context.Request.Form["provider"];

                if (string.IsNullOrEmpty(provider))
                {
                    try
                    {
                        if (FormatoValido(formato))
                        {
                            this._formato = formato;
                        }
                        Entrar();
                    }
                    catch (Exception ex)
                    {
                        ApplicationWEB._GravaErro(ex);

                        retorno.Mensagem = UtilBO.GetErroMessage("Erro ao tentar carregar o sistema.", UtilBO.TipoMensagem.Erro);
                        UtilBO.MessageJSON(context.Response.Output, retorno);
                    }
                }
            }
        }

        #endregion IHttpHandler Members

        private void Entrar()
        {
            try
            {
                // Carrega os dados do usuário necessário para o login
                SYS_Usuario entityUsuario = new SYS_Usuario
                {
                    ent_id = new Guid(this.entidade)
                    ,
                    usu_login = this.login
                    ,
                    usu_senha = this.senha
                };

                // Checa as credenciais do usuário
                LoginStatus status = SYS_UsuarioBO.ValidarLogin(entityUsuario);
                var mensagem = "";

                switch (status)
                {
                    case LoginStatus.Erro:
                        {
                            ApplicationWEB._GravaLogSistema(LOG_SistemaTipo.Login, "Erro ao tentar entrar no sistema.", entityUsuario.usu_login);
                            mensagem = "Erro ao tentar entrar no sistema.";
                            retorno.Mensagem = MensagemDeRetorno(mensagem, UtilBO.TipoMensagem.Erro);
                            UtilBO.MessageJSON(HttpContext.Current.Response.Output, retorno);
                            break;
                        }
                    case LoginStatus.Bloqueado:
                        {
                            ApplicationWEB._GravaLogSistema(LOG_SistemaTipo.Login, "Usuário bloqueado.", entityUsuario.usu_login);
                            mensagem = "Usuário bloqueado.";
                            retorno.Mensagem = MensagemDeRetorno(mensagem, UtilBO.TipoMensagem.Alerta);
                            UtilBO.MessageJSON(HttpContext.Current.Response.Output, retorno);
                            break;
                        }
                    case LoginStatus.NaoEncontrado:
                        {
                            ApplicationWEB._GravaLogSistema(LOG_SistemaTipo.Login, "Usuário não encontrado.", entityUsuario.usu_login);
                            mensagem = "Usuário e/ou senha inválidos.";
                            retorno.Mensagem = MensagemDeRetorno(mensagem, UtilBO.TipoMensagem.Alerta);

                            UtilBO.MessageJSON(HttpContext.Current.Response.Output, retorno);
                            break;
                        }
                    case LoginStatus.SenhaInvalida:
                        {
                            ApplicationWEB._GravaLogSistema(LOG_SistemaTipo.Login, "Senha inválida.", entityUsuario.usu_login);
                            mensagem = "Usuário e/ou senha inválidos.";
                            retorno.Mensagem = MensagemDeRetorno(mensagem, UtilBO.TipoMensagem.Alerta);
                            UtilBO.MessageJSON(HttpContext.Current.Response.Output, retorno);
                            break;
                        }
                    case LoginStatus.Expirado:
                        {
                            ApplicationWEB._GravaLogSistema(LOG_SistemaTipo.Login, "Senha expirada.", entityUsuario.usu_login);
                            mensagem = "Senha expirada.";
                            retorno.Mensagem = MensagemDeRetorno(mensagem, UtilBO.TipoMensagem.Alerta);
                            UtilBO.MessageJSON(HttpContext.Current.Response.Output, retorno);
                            break;
                        }
                    case LoginStatus.Sucesso:
                        {
                            SignHelper.AutenticarUsuario(entityUsuario);

                            // Configura usuário na Session
                            LoadSession(entityUsuario);
                            ApplicationWEB._GravaLogSistema(LOG_SistemaTipo.Login, "Login efetuado com sucesso.");

                            if (!string.IsNullOrEmpty(this.urlSistema))
                            {
                                //Chama o Login.ashx do site cliente.
                                HttpContext.Current.Response.Redirect(this.urlSistema, false);
                                HttpContext.Current.ApplicationInstance.CompleteRequest();
                            }
                            else
                            {
                                retorno.Mensagem = MensagemDeRetorno("sucesso", UtilBO.TipoMensagem.Alerta);
                                UtilBO.MessageJSON(HttpContext.Current.Response.Output, retorno);
                            }

                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                ApplicationWEB._GravaErro(ex);
                retorno.Mensagem = UtilBO.GetErroMessage("Erro ao tentar entrar no sistema.", UtilBO.TipoMensagem.Erro);
                UtilBO.MessageJSON(HttpContext.Current.Response.Output, retorno);
            }
        }

        /// <summary>
        /// Metodo para retornar a mensagem conforme o formato.
        /// </summary>
        /// <param name="mensagem">Mensagem de resposta</param>
        /// <param name="tipoMensagem">Tipo</param>
        /// <returns>Mensagem formatada</returns>
        private string MensagemDeRetorno(string mensagem, UtilBO.TipoMensagem tipoMensagem)
        {
            return this._formato.Equals("json", StringComparison.OrdinalIgnoreCase) ? mensagem : UtilBO.GetErroMessage(mensagem, tipoMensagem);
        }

        /// <summary>
        /// Verifica se o parametro de formato está válido.
        /// </summary>
        /// <param name="formato">formato html opção default ou json</param>
        /// <returns>True se OK.</returns>
        private bool FormatoValido(string formato)
        {
            return !string.IsNullOrEmpty(formato) && (Formatos.Count(p => p.Equals(formato, StringComparison.OrdinalIgnoreCase)) > 0);
        }

        #endregion Métodos
    }
}