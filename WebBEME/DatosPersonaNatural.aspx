<%@ Page Language="C#" MasterPageFile="~/BEME.Master" AutoEventWireup="true" CodeBehind="DatosPersonaNatural.aspx.cs"
    Inherits="BEME.Web.DatosPersonaNatural" Title="Untitled Page" %>

<%@ Register Assembly="AjaxControlToolkit, Version=1.0.20229.20821, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e"
    Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HiddenField ID="HdnIdFormAction" runat="server" />
    <b>Persona Natural</b>
    <fieldset>
        <legend>Datos del Cliente</legend>
        <table align="center" style="width: 99%" cellpadding="0" cellspacing="0" class="inputForm">
            <tr>
                <td style="width: 15%;">
                    <label style="font-weight: bold;">
                        Nombre de Usuario:</label>
                </td>
                <td style="width: 35%;">
                    <asp:DropDownList ID="ddlUsuarios" runat="server" AppendDataBoundItems="True" DataTextField="NombreUsuario"
                        DataValueField="IdUsuario" Width="100%" ValidationGroup="Datos">
                        <asp:ListItem Value="-1" Text="--Seleccionar--" />
                    </asp:DropDownList>
                </td>
                <td style="width: 15%;">
                </td>
                <td style="width: 35%;">
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
                        RUT Cliente:</label>
                </td>
                <td style="width: 35%;">
                    <asp:TextBox ID="txtRutCliente" runat="server" CssClass="txt" ValidationGroup="Datos"
                        Columns="10" MaxLength="10" ToolTip="Sin puntos ni guión. Ejemplo:12345678-K" />
                </td>
            </tr>
            <tr>
                <td style="border-bottom: solid 1px black">
                    <label style="font-weight: bold;">
                        Teléfono:</label>
                </td>
                <td style="border-bottom: solid 1px black">
                    <asp:TextBox ID="txtTelefonoCliente" runat="server" Width="95%" CssClass="txt" ValidationGroup="Datos"></asp:TextBox>
                </td>
                <td style="border-bottom: solid 1px black">
                    <label style="font-weight: bold;">
                        Correo:</label>
                </td>
                <td style="border-bottom: solid 1px black">
                    <asp:TextBox ID="txtCorreoCliente" runat="server" Width="95%" CssClass="txt" ValidationGroup="Datos"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="padding-top: 10px;">
                    <label style="font-weight: bold;">
                        Nombre Empresa:</label>
                </td>
                <td style="padding-top: 10px;">
                    <asp:TextBox ID="txtNombreEmpresaCliente" runat="server" Width="95%" CssClass="txt"
                        ValidationGroup="Datos"></asp:TextBox>
                </td>
                <td style="padding-top: 10px;">
                    <label style="font-weight: bold;">
                        RUT Empresa:</label>
                </td>
                <td style="padding-top: 10px;">
                    <asp:TextBox ID="txtRutEmpresaCliente" runat="server" CssClass="txt" ValidationGroup="Datos"
                        Columns="10" ToolTip="Sin puntos ni guión. Ejemplo:12345678-K" />
                </td>
            </tr>
            <tr>
                <td>
                    <label style="font-weight: bold;">
                        Giro Comercial:</label>
                </td>
                <td>
                    <asp:TextBox ID="txtGiroComercial" runat="server" Width="95%" CssClass="txt" ValidationGroup="Datos"></asp:TextBox>
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    <label style="font-weight: bold;">
                        Formalidad:</label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlTipoFormalidad" runat="server" AppendDataBoundItems="True"
                        DataTextField="DescTipoFormalidad" DataValueField="IdFormalidad" Enabled="False">
                        <asp:ListItem Value="-1" Text="--Seleccionar--" />
                    </asp:DropDownList>
                </td>
                <td>
                    <label style="font-weight: bold;">
                        Nivel de Ventas:</label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlNivelVentas" runat="server" AppendDataBoundItems="True"
                        DataTextField="DescNivelVentas" DataValueField="IdNivelVentas" Enabled="False">
                        <asp:ListItem Value="-1" Text="--Seleccionar--" />
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <label style="font-weight: bold;">
                        Tipo de Empresa:</label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlTipoEmpresa" runat="server" AppendDataBoundItems="True"
                        DataTextField="DescTipoEmpresa" DataValueField="IdTipoEmpresa" Width="100%" ValidationGroup="Datos"
                        Enabled="False">
                        <asp:ListItem Value="-1" Text="--Seleccionar--" />
                    </asp:DropDownList>
                </td>
                <td>
                    <label style="font-weight: bold;">
                        Permanencia en el Rubro:</label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlPermanenciaRubro" runat="server" AppendDataBoundItems="True"
                        DataTextField="DescPermanenciaRubro" DataValueField="IdPermanenciaRubro" Width="100%"
                        ValidationGroup="Datos" Enabled="False">
                        <asp:ListItem Value="-1" Text="--Seleccionar--" />
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <label style="font-weight: bold;">
                        Familia de Productos:</label>
                </td>
                <td>
                    <div style="height: 120px; overflow: auto;">
                        <asp:Repeater ID="repFamiliaProductos" runat="server">
                            <ItemTemplate>
                                <b>
                                    <asp:HiddenField ID="hdnIdFamiliaProductos" runat="server" Value='<%# Eval("IdFamiliaProductos")%>' />
                                    <asp:Literal ID="litDescFamiliaProductos" runat="server" Text='<%# Eval("DescFamiliaProductos")%>'>
                                    </asp:Literal>
                                </b>
                                <br />
                                <asp:Repeater ID="repProductosDisponibles" runat="server" DataSource='<%# Eval("LstProductosDisponibles")%>'>
                                    <ItemTemplate>
                                        <asp:HiddenField ID="hdnIdProductosDisponibles" runat="server" Value='<%# Eval("IdProductosDisponibles")%>' />
                                        <asp:HiddenField ID="hdnIdFamiliaProductos" runat="server" Value='<%# Eval("IdFamiliaProductos")%>' />
                                        <asp:Literal ID="litDescProductosDisponibles" runat="server" Text='<%# Eval("DescProductosDisponibles")%>' />
                                        <br />
                                    </ItemTemplate>
                                </asp:Repeater>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    <label style="font-weight: bold;">
                        Observaciones:</label>
                </td>
                <td colspan="3">
                    <asp:TextBox ID="txtObservaciones" runat="server" Width="90%" TextMode="MultiLine"
                        ValidationGroup="Datos" Rows="5" MaxLength="255" />
                </td>
            </tr>
            <tr>
                <td>
                    <label style="font-weight: bold;">
                        Gestiones:</label>
                </td>
                <td colspan="3">
                    <asp:GridView ID="gvLog" runat="server" AutoGenerateColumns="False" CssClass="mGrid">
                        <Columns>
                            <asp:BoundField DataField="Fecha" HeaderText="Fecha/Hora" />
                            <asp:BoundField DataField="NombreUsuario" HeaderText="Usuario" />
                            <asp:BoundField DataField="Texto" HeaderText="Observaciones" />
                        </Columns>
                        <EditRowStyle BorderStyle="None" />
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td colspan="4" align="center">
                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar y Continuar" OnClick="btnGuardar_Click"
                        ValidationGroup="Datos" />
                </td>
            </tr>
            <tr style="visibility: hidden;">
                <td>
                    <label style="font-weight: bold;">
                        Ejecutivo Responsable:</label>
                </td>
                <td colspan="3">
                    <asp:DropDownList ID="DropDownList3" runat="server">
                        <asp:ListItem Text="--Sucursales--" />
                    </asp:DropDownList>
                    <asp:DropDownList ID="DropDownList4" runat="server">
                        <asp:ListItem Text="--Ejecutivos--" />
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
        <asp:RequiredFieldValidator ID="rfvNombreCliente" runat="server" ErrorMessage="Dato Obligatorio"
            ControlToValidate="txtNombreCliente" ValidationGroup="Datos" Display="None" />
        <cc1:ValidatorCalloutExtender ID="vceNombreCliente" runat="server" TargetControlID="rfvNombreCliente" />
        <br />
        <asp:RequiredFieldValidator ID="rfvRutCliente" runat="server" ErrorMessage="Dato Obligatorio"
            ControlToValidate="txtRutCliente" ValidationGroup="Datos" Display="None" />
        <asp:CustomValidator ID="cuvRutCliente" runat="server" ErrorMessage="RUT No Válido"
            ControlToValidate="txtRutCliente" ValidationGroup="Datos" Display="None" ClientValidationFunction="validar_rut" />
        <cc1:ValidatorCalloutExtender ID="vceRutCliente" runat="server" TargetControlID="rfvRutCliente" />
        <cc1:ValidatorCalloutExtender ID="vceRutCliente2" runat="server" TargetControlID="cuvRutCliente" />
        <br />
        <asp:RequiredFieldValidator ID="rfvTelefonoCliente" runat="server" ErrorMessage="Dato Obligatorio"
            ControlToValidate="txtTelefonoCliente" ValidationGroup="Datos" Display="None" />
        <cc1:ValidatorCalloutExtender ID="vceTelefonoCliente" runat="server" TargetControlID="rfvTelefonoCliente" />
        <br />
        <asp:RequiredFieldValidator ID="rfvCorreoCliente" runat="server" ErrorMessage="Dato Obligatorio"
            ControlToValidate="txtCorreoCliente" ValidationGroup="Datos" Display="None" />
        <asp:RegularExpressionValidator ID="revCorreoCliente" runat="server" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
            ControlToValidate="txtCorreoCliente" ErrorMessage="Email Inválido" ValidationGroup="Datos"
            Display="None" />
        <cc1:ValidatorCalloutExtender ID="vceCorreoCliente" runat="server" TargetControlID="rfvCorreoCliente" />
        <cc1:ValidatorCalloutExtender ID="vceCorreoCliente2" runat="server" TargetControlID="revCorreoCliente" />
        <br />
        <asp:RequiredFieldValidator ID="rfvNombreEmpresaCliente" runat="server" ErrorMessage="Dato Obligatorio"
            ControlToValidate="txtNombreEmpresaCliente" ValidationGroup="Datos" Display="None" />
        <cc1:ValidatorCalloutExtender ID="vceNombreEmpresaCliente" runat="server" TargetControlID="rfvNombreEmpresaCliente" />
        <br />
        <asp:RequiredFieldValidator ID="rfvRutEmpresaCliente" runat="server" ErrorMessage="Dato Obligatorio"
            ControlToValidate="txtRutEmpresaCliente" ValidationGroup="Datos" Display="None" />
        <asp:CustomValidator ID="cuvRutEmpresaCliente" runat="server" ErrorMessage="RUT No Válido"
            ControlToValidate="txtRutEmpresaCliente" ValidationGroup="Datos" Display="None"
            ClientValidationFunction="validar_rut" />
        <cc1:ValidatorCalloutExtender ID="vceRutEmpresaCliente" runat="server" TargetControlID="rfvRutEmpresaCliente" />
        <cc1:ValidatorCalloutExtender ID="vceRutEmpresaCliente2" runat="server" TargetControlID="cuvRutEmpresaCliente" />
        <br />
        <asp:RequiredFieldValidator ID="rfvGiroComercial" runat="server" ErrorMessage="Dato Obligatorio"
            ControlToValidate="txtGiroComercial" ValidationGroup="Datos" Display="None" />
        <cc1:ValidatorCalloutExtender ID="vceGiroComercial" runat="server" TargetControlID="rfvGiroComercial" />
        
        <asp:RequiredFieldValidator ID="rfvObservaciones" runat="server" ErrorMessage="Dato Obligatorio"
            ControlToValidate="txtObservaciones" Display="None" ValidationGroup="Datos" />
        <cc1:ValidatorCalloutExtender ID="vceObservaciones" runat="server" TargetControlID="rfvObservaciones" />
        
        
        <br />
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
