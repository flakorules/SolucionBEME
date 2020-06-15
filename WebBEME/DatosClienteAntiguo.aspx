<%@ Page Language="C#" MasterPageFile="~/BEME.Master" AutoEventWireup="true" CodeBehind="DatosClienteAntiguo.aspx.cs"
    Inherits="BEME.Web.DatosClienteAntiguo" Title="Cliente Antiguo" UICulture="es"
    Culture="es-CL" %>

<%@ Register Assembly="AjaxControlToolkit, Version=1.0.20229.20821, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e"
    Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HiddenField ID="HdnIdFormAction" runat="server" />
    <b><asp:Literal ID="litTitulo" runat="server" /></b>
    <fieldset>
        <legend>Datos del Cliente</legend>
        <table align="center" style="width: 99%" cellpadding="0" cellspacing="0" class="inputForm">
            <tr id="trCorrelativo" runat="server">
                <td style="width: 15%;">
                    <label style="font-weight: bold;">
                        Correlativo:</label>
                </td>
                <td style="width: 35%;">
                    <asp:TextBox ID="txtIdClienteAntiguo" runat="server" CssClass="txt" ReadOnly="true"
                        Columns="10" MaxLength="10" />
                </td>
                <td style="width: 15%;">
                </td>
                <td style="width: 35%;">
                </td>
            </tr>
            <tr>
                <td>
                    <label style="font-weight: bold;">
                        Nombre de Usuario:</label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlUsuarios" runat="server" AppendDataBoundItems="True" DataTextField="NombreUsuario"
                        DataValueField="IdUsuario" Width="100%" ValidationGroup="Datos">
                        <asp:ListItem Value="-1" Text="--Seleccionar--" />
                    </asp:DropDownList>
                </td>
                <td>
                    <label style="font-weight: bold;">
                        <asp:Literal ID="litFechaPresentacion" runat="server" Text="Fecha Atención Real" />
                    </label>
                </td>
                <td>
                    <asp:TextBox ID="txtFechaPresentacion" runat="server" CssClass="txt" ValidationGroup="Datos"
                        Columns="10" MaxLength="10" />
                    <asp:ImageButton ID="imbFechaPresentacion" runat="server" ImageUrl="~/Images/date.png" />
                    <cc1:CalendarExtender ID="ceFechaPresentacion" runat="server" PopupButtonID="imbFechaPresentacion"
                        TargetControlID="txtFechaPresentacion" Format="dd-MM-yyyy" />
                </td>
            </tr>
            <tr>
                <td style="width: 15%;">
                    <label style="font-weight: bold;">
                        Nombre Cliente:</label>
                </td>
                <td style="width: 35%;">
                    <asp:TextBox ID="txtNombreCliente" runat="server" Width="95%" CssClass="txt" ValidationGroup="Datos"></asp:TextBox>
                </td>
                <td style="width: 15%;">
                    <label style="font-weight: bold;">
                        RUT Cliente/Empresa:</label>
                </td>
                <td style="width: 35%;">
                    <asp:TextBox ID="txtRutCliente" runat="server" CssClass="txt" ValidationGroup="Datos"
                        Columns="10" MaxLength="10" ToolTip="Sin puntos ni guión. Ejemplo:12345678-K" />
                </td>
            </tr>
            <tr>
                <td>
                    <label style="font-weight: bold;">
                        Requerimiento Cliente:</label>
                </td>
                <td colspan="3">
                    <asp:TextBox ID="txtReqCliente" runat="server" Width="90%" TextMode="MultiLine" ValidationGroup="Datos"
                        Rows="5" MaxLength="255" />
                </td>
            </tr>
            <tr>
                <td>
                    <label style="font-weight: bold;">
                        Gestiones Realizadas:</label>
                </td>
                <td colspan="3">
                    <asp:TextBox ID="txtResolucion" runat="server" Width="90%" TextMode="MultiLine" ValidationGroup="Datos"
                        Rows="5" MaxLength="255" />
                </td>
            </tr>
            <tr id="trFecAtancion" runat="server" visible="false">
                <td>
                    <label style="font-weight: bold;">
                        Fecha de Resolución Real:</label>
                </td>
                <td>
                    <asp:TextBox ID="txtFecAtencion" runat="server" CssClass="txt" ValidationGroup="Datos"
                        Columns="10" MaxLength="10" />
                    <asp:ImageButton ID="imbFecAtencion" runat="server" ImageUrl="~/Images/date.png" />
                    <cc1:CalendarExtender ID="ceFecAtencion" runat="server" PopupButtonID="imbFecAtencion"
                        TargetControlID="txtFecAtencion" Format="dd-MM-yyyy" />
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr id="trResolucionFinal" runat="server" visible="false">
                <td>
                    <label style="font-weight: bold;">
                        Resolución:</label>
                </td>
                <td colspan="3">
                    <asp:TextBox ID="txtResolucionFinal" runat="server" Width="90%" TextMode="MultiLine"
                        ValidationGroup="Datos" Rows="5" MaxLength="255" />
                </td>
            </tr>
            <tr id="trGestiones" runat="server" visible="false">
                <td>
                    <label style="font-weight: bold;">
                        Gestiones:</label>
                </td>
                <td colspan="3">
                    <asp:GridView ID="gvLog" runat="server" AutoGenerateColumns="False" CssClass="mGrid">
                        <Columns>
                            <asp:BoundField DataField="FechaLogCA" HeaderText="Fecha/Hora Registro en Sistema" />
                            <asp:BoundField DataField="NombreUsuario" HeaderText="Usuario" />
                            <asp:BoundField DataField="FecAtenClienteAntiguo" HeaderText="Fecha de Atención Real de Cliente"  DataFormatString="{0:dd-MM-yyyy}"/>
                            <asp:BoundField DataField="ResFinClienteAntiguo" HeaderText="Gestiones Realizadas/Resolución" />
                        </Columns>
                        <EditRowStyle BorderStyle="None" />
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td colspan="4" align="center">
                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar y Continuar" ValidationGroup="Datos"
                        OnClick="btnGuardar_Click" />
                </td>
            </tr>
        </table>
        <asp:CompareValidator ID="covUsuarios" runat="server" ControlToValidate="ddlUsuarios"
            Display="None" ErrorMessage="Dato Obligatorio" Operator="NotEqual" ValidationGroup="Datos"
            ValueToCompare="-1" />
        <cc1:ValidatorCalloutExtender ID="vcoUsuarios" runat="server" TargetControlID="covUsuarios" />
        <asp:RequiredFieldValidator ID="rfvFechaPresentacion" runat="server" ErrorMessage="Dato Obligatorio"
            ControlToValidate="txtFechaPresentacion" Display="None" ValidationGroup="Datos" />
        <cc1:ValidatorCalloutExtender ID="vceFechaPresentacion" runat="server" TargetControlID="rfvFechaPresentacion" />
        <asp:RequiredFieldValidator ID="rfvNombreCliente" runat="server" ErrorMessage="Dato Obligatorio"
            ControlToValidate="txtNombreCliente" Display="None" ValidationGroup="Datos" />
        <cc1:ValidatorCalloutExtender ID="vceNombreCliente" runat="server" TargetControlID="rfvNombreCliente" />
        <asp:RequiredFieldValidator ID="rfvRutCliente" runat="server" ErrorMessage="Dato Obligatorio"
            ControlToValidate="txtRutCliente" Display="None" ValidationGroup="Datos" />
        <asp:CustomValidator ID="cuvRutCliente" runat="server" ErrorMessage="RUT No válido"
            ControlToValidate="txtRutCliente" Display="None" ValidationGroup="Datos" ClientValidationFunction="validar_rut" />
        <cc1:ValidatorCalloutExtender ID="vceRutEmpresa" runat="server" TargetControlID="rfvRutCliente" />
        <cc1:ValidatorCalloutExtender ID="vceRutEmpresa2" runat="server" TargetControlID="cuvRutCliente" />
        <asp:RequiredFieldValidator ID="rfvReqCliente" runat="server" ErrorMessage="Dato Obligatorio"
            ControlToValidate="txtReqCliente" Display="None" ValidationGroup="Datos" />
        <cc1:ValidatorCalloutExtender ID="vceReqCliente" runat="server" TargetControlID="rfvReqCliente" />
        <asp:RequiredFieldValidator ID="rvfResolucion" runat="server" ErrorMessage="Dato Obligatorio"
            ControlToValidate="txtResolucion" Display="None" ValidationGroup="Datos" />
        <cc1:ValidatorCalloutExtender ID="vceResolucion" runat="server" TargetControlID="rvfResolucion" />
        <asp:RequiredFieldValidator ID="rfvFecAtencion" runat="server" ErrorMessage="Dato Obligatorio"
            ControlToValidate="txtFecAtencion" Display="None" ValidationGroup="Datos" />
        <cc1:ValidatorCalloutExtender ID="vceFecAtencion" runat="server" TargetControlID="rfvFecAtencion" />
        <asp:RequiredFieldValidator ID="rfvResolucionFinal" runat="server" ErrorMessage="Dato Obligatorio"
            ControlToValidate="txtResolucionFinal" Display="None" ValidationGroup="Datos" />
        <cc1:ValidatorCalloutExtender ID="vceResolucionFinal" runat="server" TargetControlID="rfvResolucionFinal" />
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
            <asp:AsyncPostBackTrigger ControlID="btnGuardar" EventName="Click" />
        </Triggers>
    </asp:UpdatePanel>
</asp:Content>
