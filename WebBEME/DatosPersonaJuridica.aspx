<%@ Page Language="C#" MasterPageFile="~/BEME.Master" AutoEventWireup="true" CodeBehind="DatosPersonaJuridica.aspx.cs"
    Inherits="BEME.Web.DatosPersonaJuridica" Title="Untitled Page" %>

<%@ Register Assembly="AjaxControlToolkit, Version=1.0.20229.20821, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e"
    Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HiddenField ID="HdnIdFormAction" runat="server" />
    <b>Persona Jurídica</b>
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
                <td>
                    <label style="font-weight: bold;">
                        Nombre Empresa:</label>
                </td>
                <td>
                    <asp:TextBox ID="txtNombreEmpresa" runat="server" CssClass="txt" ValidationGroup="Datos"
                        MaxLength="50" Width="90%"></asp:TextBox>
                </td>
                <td>
                    <label style="font-weight: bold;">
                        RUT Empresa:</label>
                </td>
                <td>
                    <asp:TextBox ID="txtRutEmpresa" runat="server" CssClass="txt" ValidationGroup="Datos"
                        MaxLength="10" Rows="10" Columns="10" ToolTip="Sin puntos ni guión. Ejemplo:12345678-K" />
                        
                       
                </td>
            </tr>
            <tr>
                <td>
                    <label style="font-weight: bold;">
                        Repres. Legal:</label>
                </td>
                <td>
                    <asp:TextBox ID="txtRepresLegal" runat="server" CssClass="txt" ValidationGroup="Datos"
                        Width="90%"></asp:TextBox>
                </td>
                <td>
                    <label style="font-weight: bold;">
                        RUT Repres Legal:</label>
                </td>
                <td>
                    <asp:TextBox ID="txtRutRepresLegal" runat="server" CssClass="txt" ValidationGroup="Datos"
                        MaxLength="10" Rows="10" Columns="10" ToolTip="Sin puntos ni guión. Ejemplo:12345678-K"/>
                </td>
            </tr>
            <tr>
                <td>
                    <label style="font-weight: bold;">
                        Giro Comercial:</label>
                </td>
                <td>
                    <asp:TextBox ID="txtGiroComercial" runat="server" CssClass="txt" ValidationGroup="Datos"
                        Width="90%"></asp:TextBox>
                </td>
                <td>
                    <label style="font-weight: bold;">
                        Tipo de PJ:</label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlTipoPersonaJuridica" runat="server" DataTextField="DescTipoPersonaJuridica"
                        DataValueField="IdTipoPersonaJuridica" ValidationGroup="Datos" AppendDataBoundItems="True"
                        Width="95%" Enabled="False">
                        <asp:ListItem Text="--Seleccionar--" Value="-1" />
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <label style="font-weight: bold;">
                        Teléfono:</label>
                </td>
                <td>
                    <asp:TextBox ID="txtTelefono" runat="server" CssClass="txt" ValidationGroup="Datos"
                        Width="90%"></asp:TextBox>
                </td>
                <td>
                    <label style="font-weight: bold;">
                        Correo:</label>
                </td>
                <td>
                    <asp:TextBox ID="txtCorreo" runat="server" CssClass="txt" ValidationGroup="Datos"
                        Width="95%"></asp:TextBox>
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
                    <asp:TextBox ID="txtObservaciones" runat="server" TextMode="MultiLine" ValidationGroup="Datos"
                        Rows="5" Width="95%" />
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
            <tr style="display: none;">
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
        <asp:RequiredFieldValidator ID="rfvNombreEmpresa" runat="server" ErrorMessage="Dato Obligatorio"
            ControlToValidate="txtNombreEmpresa" Display="None" ValidationGroup="Datos" />
        <cc1:ValidatorCalloutExtender ID="vceNombreEmpresa" runat="server" TargetControlID="rfvNombreEmpresa" />
        <br />
        <asp:RequiredFieldValidator ID="rfvRutEmpresa" runat="server" ErrorMessage="Dato Obligatorio"
            ControlToValidate="txtRutEmpresa" Display="None" ValidationGroup="Datos" />
        <asp:CustomValidator ID="cuvRutEmpresa" runat="server" ErrorMessage="RUT No válido"
            ControlToValidate="txtRutEmpresa" Display="None" ValidationGroup="Datos" ClientValidationFunction="validar_rut" />
        <cc1:ValidatorCalloutExtender ID="vceRutEmpresa" runat="server" TargetControlID="rfvRutEmpresa" />
        <cc1:ValidatorCalloutExtender ID="vceRutEmpresa2" runat="server" TargetControlID="cuvRutEmpresa" />
        <br />
        <asp:RequiredFieldValidator ID="rfvRepresLegal" runat="server" ErrorMessage="Dato Obligatorio"
            ControlToValidate="txtRepresLegal" Display="None" ValidationGroup="Datos" />
        <cc1:ValidatorCalloutExtender ID="vceRepresLegal" runat="server" TargetControlID="rfvRepresLegal" />
        <br />
        <asp:RequiredFieldValidator ID="rfvRutRepresLegal" runat="server" ErrorMessage="Dato Obligatorio"
            ControlToValidate="txtRutRepresLegal" Display="None" ValidationGroup="Datos" />
        <asp:CustomValidator ID="cuvRutRepresLegal" runat="server" ErrorMessage="RUT No válido"
            ControlToValidate="txtRutRepresLegal" Display="None" ValidationGroup="Datos"
            ClientValidationFunction="validar_rut" />
        <cc1:ValidatorCalloutExtender ID="vceRutRepresLegal" runat="server" TargetControlID="rfvRutRepresLegal" />
        <cc1:ValidatorCalloutExtender ID="vceRutRepresLegal2" runat="server" TargetControlID="cuvRutRepresLegal" />
        <br />
        <asp:RequiredFieldValidator ID="rfvGiroComercial" runat="server" ErrorMessage="Dato Obligatorio"
            ControlToValidate="txtGiroComercial" Display="None" ValidationGroup="Datos" />
        <cc1:ValidatorCalloutExtender ID="vceGiroComercial" runat="server" TargetControlID="rfvGiroComercial" />
        <asp:CompareValidator ID="covTipoPersonaJuridica" runat="server" ControlToValidate="ddlTipoPersonaJuridica"
            Display="None" ErrorMessage="Dato Obligatorio" Operator="NotEqual" ValidationGroup="Datos"
            ValueToCompare="-1" />
        <cc1:ValidatorCalloutExtender ID="vceTipoPersonaJuridica" runat="server" TargetControlID="covTipoPersonaJuridica" />
        <br />
        <asp:RequiredFieldValidator ID="rfvTelefono" runat="server" ErrorMessage="Dato Obligatorio"
            ControlToValidate="txtTelefono" Display="None" ValidationGroup="Datos" />
        <cc1:ValidatorCalloutExtender ID="vceTelefono" runat="server" TargetControlID="rfvTelefono" />
        <br />
        <asp:RequiredFieldValidator ID="rfvCorreo" runat="server" ErrorMessage="Dato Obligatorio"
            ControlToValidate="txtCorreo" Display="None" ValidationGroup="Datos" />
        <asp:RegularExpressionValidator ID="revCorreoCliente" runat="server" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
            ControlToValidate="txtCorreo" ErrorMessage="Email Inválido" ValidationGroup="Datos"
            Display="None" />
        <cc1:ValidatorCalloutExtender ID="vceCorreo" runat="server" TargetControlID="rfvCorreo" />
        <cc1:ValidatorCalloutExtender ID="vceCorreo2" runat="server" TargetControlID="revCorreoCliente" />
        <br />
        
        <asp:RequiredFieldValidator ID="rfvObservaciones" runat="server" ErrorMessage="Dato Obligatorio"
            ControlToValidate="txtObservaciones" Display="None" ValidationGroup="Datos" />
        <cc1:ValidatorCalloutExtender ID="vceObservaciones" runat="server" TargetControlID="rfvObservaciones" />
        
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
