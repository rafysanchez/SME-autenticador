﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCUASuperior.ascx.cs" Inherits="Autenticador.UserControlLibrary.Buscas.UCUASuperior" %>

<%@ Register Src="../Combos/UCComboTipoUnidadeAdministrativa.ascx" TagName="UCComboTipoUnidadeAdministrativa"
    TagPrefix="coresso" %>

<div id="divBuscaUA">
    <asp:UpdatePanel ID="updModal" runat="server" UpdateMode="Always">
        <ContentTemplate>
            <fieldset>
                <coresso:UCComboTipoUnidadeAdministrativa ID="UCComboTipoUnidadeAdministrativa1" runat="server" />
                <asp:Label ID="Label3" runat="server" Text="Nome" EnableViewState="False" AssociatedControlID="_txtNome"></asp:Label>
                <asp:TextBox ID="_txtNome" runat="server" MaxLength="200" SkinID="text60C"></asp:TextBox>
                <asp:Label ID="Label4" runat="server" Text="Código" EnableViewState="False" AssociatedControlID="_txtCodigo"></asp:Label>
                <asp:TextBox ID="_txtCodigo" runat="server" MaxLength="20" SkinID="text20C"></asp:TextBox>
                <div class="right">
                    <asp:Button ID="_btnPesquisar" runat="server" OnClick="_btnPesquisar_Click" Text="Pesquisar"
                        CausesValidation="False" />
                    <asp:Button ID="btnModalCancelar" runat="server" Text="Cancelar" CausesValidation="false" OnClick="btnModalCancelar_Click" />
                </div>
            </fieldset>
            <fieldset id="fdsResultados" runat="server">
                <legend>Resultados</legend>
                <asp:GridView ID="_dgvUA" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                    DataKeyNames="ent_id,uad_id,uad_nome" DataSourceID="odsUA" 
                    EmptyDataText="A pesquisa não encontrou resultados." 
                    onrowediting="_dgvUA_RowEditing" OnRowCommand="_dgvUA_RowCommand">
                    <Columns>
                        <asp:BoundField DataField="ent_id" HeaderText="ent_id" ReadOnly="True" Visible="False" />
                        <asp:BoundField DataField="uad_id" HeaderText="uad_id" ReadOnly="True" Visible="False" />
                        <asp:TemplateField HeaderText="Nome">
                            <ItemTemplate>
                                <asp:LinkButton ID="_lkbSelect" runat="server" Text='<%# Eval("uad_nome") %>' CommandArgument='<%# ((GridViewRow) Container).RowIndex %>'
                                    CommandName="Selecionar" CausesValidation="false">
                                </asp:LinkButton>
                            </ItemTemplate>
                            <EditItemTemplate>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="uad_codigo" HeaderText="Código" />
                        <asp:BoundField DataField="tua_nome" HeaderText="Tipo de unidade administrativa" />
                        <asp:BoundField DataField="ent_razaoSocial" HeaderText="Entidade" />
                        <asp:BoundField DataField="uad_nomeSup" HeaderText="Unidade administrativa superior" />
                    </Columns>
                </asp:GridView>
                <asp:ObjectDataSource ID="odsUA" runat="server" DataObjectTypeName="Autenticador.Entities.SYS_UnidadeAdministrativa"
                    EnablePaging="True" MaximumRowsParameterName="pageSize" OnSelecting="odsUA_Selecting"
                    SelectCountMethod="GetTotalRecords" SelectMethod="GetSelect" StartRowIndexParameterName="currentPage"
                    TypeName="Autenticador.BLL.SYS_UnidadeAdministrativaBO">
                </asp:ObjectDataSource>
            </fieldset>
        </ContentTemplate>
    </asp:UpdatePanel>
</div>