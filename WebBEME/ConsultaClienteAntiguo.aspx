<%@ Page Language="C#" MasterPageFile="~/BEME.Master" AutoEventWireup="true" CodeBehind="ConsultaClienteAntiguo.aspx.cs" Inherits="BEME.Web.ConsultaClienteAntiguo" Title="Untitled Page" %>

<%@ Register Assembly="AjaxControlToolkit, Version=1.0.20229.20821, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e"
    Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<b>Consulta - Cliente Antiguo</b>
    <fieldset>
        <table align="center" style="width: 60%" class="inputForm">
            <tr>
                <td>
                    <label style="font-weight: bold;">
                        RUT:</label>
                </td>
                <td>
                    <asp:TextBox ID="txtRut" runat="server" MaxLength="10" ValidationGroup="Datos" CssClass="txt" ReadOnly="True" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <fieldset>
                        <legend>Resultado</legend>
                        <asp:GridView ID="gvClientes" runat="server" AutoGenerateColumns="False" 
                            CssClass="mGrid" onrowcommand="gvClientes_RowCommand" DataKeyNames="IdClienteAntiguo">
                            <Columns>
                                <asp:ButtonField Text="Ver" />
                                <asp:BoundField DataField="IdClienteAntiguo" HeaderText="Correlativo" />
                                <asp:BoundField DataField="NombreUsuario" HeaderText="Usuario" />
                                <asp:BoundField DataField="FecPresClienteAntiguo" HeaderText="Fecha Atención Real" DataFormatString="{0:dd-MM-yyyy}"/>
                                <asp:BoundField DataField="ReqClienteAntiguo" HeaderText="Requerimiento Cliente" />
                                <asp:BoundField DataField="ResClienteAntiguo" HeaderText="Gestiones Realizadas" />
                                
                            </Columns>
                            <EditRowStyle BorderStyle="None" />
                        </asp:GridView>
                    </fieldset>
                </td>
            </tr>
        </table>
    </fieldset>



<asp:Button ID="btnDummyPopup" runat="server" Text="dummy" Style="display: none" />
    <cc1:ModalPopupExtender ID="mpeMensaje" runat="server" PopupControlID="udpMensaje"
        TargetControlID="btnDummyPopup" BackgroundCssClass="modalBackground">
    </cc1:ModalPopupExtender>
    <asp:UpdatePanel ID="udpMensaje" runat="server">
        <ContentTemplate>
            <asp:Panel ID="panMensaje" runat="server" CssClass="modalPopup" align="center">
                <asp:Literal ID="litMensaje" runat="server" />
                <br />
                <asp:Button ID="btnClose" runat="server" Text="Continuar" PostBackUrl="~/Ingreso.aspx" />
            </asp:Panel>
        </ContentTemplate>
        <Triggers>
        </Triggers>
    </asp:UpdatePanel>
</asp:Content>
