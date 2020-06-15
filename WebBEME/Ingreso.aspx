<%@ Page Language="C#" MasterPageFile="~/BEME.Master" AutoEventWireup="true" CodeBehind="Ingreso.aspx.cs"
    Inherits="BEME.Web.Ingreso" Title="BEME" %>

<%@ Register Assembly="AjaxControlToolkit, Version=1.0.20229.20821, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e"
    Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
    
    
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:UpdatePanel ID="udpDatos" runat="server">
        <ContentTemplate>
            <b>Inicio</b>
            <fieldset>
                <%--<legend>Datos</legend>--%>
                <table align="center" style="width: 60%" class="inputForm">
                    <tr>
                        <td style="width: 34%;">
                            <label style="font-weight: bold;">
                                Nombre de Usuario:</label>
                        </td>
                        <td style="width: 66%;">
                            <asp:DropDownList ID="ddlUsuarios" runat="server" AppendDataBoundItems="True" DataTextField="NombreUsuario"
                                DataValueField="IdUsuario" Width="100%" ValidationGroup="Datos">
                                <asp:ListItem Value="-1" Text="--Seleccionar--" />
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label style="font-weight: bold;">
                                Tipo Cliente:</label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlTipoCliente" runat="server" AppendDataBoundItems="True"
                                DataTextField="DescTipoCliente" DataValueField="IdTipoCliente" AutoPostBack="True"
                                OnSelectedIndexChanged="ddlTipoCliente_SelectedIndexChanged" Width="100%">
                                <asp:ListItem Value="-1" Text="--Seleccionar--" />
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label style="font-weight: bold;">
                                Formalidad:</label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlTipoFormalidad" runat="server" AppendDataBoundItems="True"
                                DataTextField="DescTipoFormalidad" DataValueField="IdFormalidad" AutoPostBack="True"
                                OnSelectedIndexChanged="ddlTipoFormalidad_SelectedIndexChanged" Width="100%">
                                <asp:ListItem Value="-1" Text="--Seleccionar--" />
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label style="font-weight: bold;">
                                Nivel de Ventas:</label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlNivelVentas" runat="server" AppendDataBoundItems="True"
                                DataTextField="DescNivelVentas" DataValueField="IdNivelVentas" AutoPostBack="True"
                                OnSelectedIndexChanged="ddlNivelVentas_SelectedIndexChanged" Width="100%">
                                <asp:ListItem Value="-1" Text="--Seleccionar--" />
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label style="font-weight: bold;">
                                Banca de Conexión:</label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlBancaDerivacion" runat="server" AppendDataBoundItems="True"
                                DataTextField="DescBancaDerivacion" DataValueField="IdBancaDerivacion" Enabled="False"
                                Width="100%">
                                <asp:ListItem Value="-1" Text="--Seleccionar--" />
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table>
            </fieldset>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="btnLimpiar" EventName="Click" />
        </Triggers>
    </asp:UpdatePanel>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <fieldset>
                <!--<legend>Datos</legend>-->
                <table align="center" style="width: 60%" class="inputForm">
                    <tr>
                        <td style="width: 34%;">
                            <label style="font-weight: bold;">
                                Tipo de Empresa:</label>
                        </td>
                        <td style="width: 66%;">
                            <asp:DropDownList ID="ddlTipoEmpresa" runat="server" AppendDataBoundItems="True"
                                DataTextField="DescTipoEmpresa" DataValueField="IdTipoEmpresa" AutoPostBack="True"
                                OnSelectedIndexChanged="ddlTipoEmpresa_SelectedIndexChanged" Width="100%" ValidationGroup="Datos">
                                <asp:ListItem Value="-1" Text="--Seleccionar--" />
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label style="font-weight: bold;">
                                Tipo Persona Jurídica:</label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlTipoPersonaJuridica" runat="server" AppendDataBoundItems="True"
                                DataTextField="DescTipoPersonaJuridica" DataValueField="IdTipoPersonaJuridica"
                                AutoPostBack="True" OnSelectedIndexChanged="ddlTipoPersonaJuridica_SelectedIndexChanged"
                                Enabled="False" Width="100%" ValidationGroup="Datos">
                                <asp:ListItem Value="-1" Text="--Seleccionar--" />
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label style="font-weight: bold;">
                                Permanencia en el Rubro:</label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlPermanenciaRubro" runat="server" AppendDataBoundItems="True"
                                DataTextField="DescPermanenciaRubro" DataValueField="IdPermanenciaRubro" AutoPostBack="True"
                                OnSelectedIndexChanged="ddlPermanenciaRubro_SelectedIndexChanged" Width="100%"
                                ValidationGroup="Datos">
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
                            <div style="height: 250px; overflow: auto;">
                                <asp:Repeater ID="repFamiliaProductos" runat="server">
                                    <ItemTemplate>
                                        <b>
                                            <asp:HiddenField ID="hdnIdFamiliaProductos" runat="server" Value='<%# Eval("IdFamiliaProductos")%>' />
                                            <asp:Literal ID="litDescFamiliaProductos" runat="server" Text='<%# Eval("DescFamiliaProductos")%>'>
                                            </asp:Literal>
                                        </b>
                                        <br />
                                        <asp:CheckBoxList ID="cblProductosDisponibles" runat="server" DataSource='<%# Eval("LstProductosDisponibles")%>'
                                            DataValueField="IdProductosDisponibles" DataTextField="DescProductosDisponibles" />
                                    </ItemTemplate>
                                </asp:Repeater>
                            </div>
                        </td>
                    </tr>
                    <tr id="trRequisitosCondiciones" runat="server" visible="false">
                        <td>
                            <label style="font-weight: bold;">
                                Requisitos y Condiciones:</label>
                        </td>
                        <td>
                            <asp:LinkButton ID="lnbDownload" runat="server" PostBackUrl="~/Download.aspx" Visible="False"
                                CausesValidation="False">Descargar</asp:LinkButton>
                        </td>
                    </tr>
                </table>
            </fieldset>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="btnLimpiar" EventName="Click" />
        </Triggers>
    </asp:UpdatePanel>
    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>
            <fieldset>
                <center>
                    <asp:Button ID="btnContinuar" runat="server" Text="Guardar" PostBackUrl="~/DatosPersonaNatural.aspx"
                        ValidationGroup="Datos" />
                    <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" OnClick="btnLimpiar_Click"
                        CausesValidation="False" />
                </center>
            </fieldset>
            <asp:CompareValidator ID="covUsuarios" runat="server" ControlToValidate="ddlUsuarios"
                Display="None" ErrorMessage="Dato Obligatorio" Operator="NotEqual" ValidationGroup="Datos"
                ValueToCompare="-1" />
            <cc1:ValidatorCalloutExtender ID="vcoUsuarios" runat="server" TargetControlID="covUsuarios" />
            <asp:CompareValidator ID="covTipoEmpresa" runat="server" ControlToValidate="ddlTipoEmpresa"
                Display="None" ErrorMessage="Dato Obligatorio" Operator="NotEqual" ValidationGroup="Datos"
                ValueToCompare="-1" />
            <cc1:ValidatorCalloutExtender ID="vceTipoEmpresa" runat="server" TargetControlID="covTipoEmpresa" />
            <asp:CompareValidator ID="covTipoPersonaJuridica" runat="server" ControlToValidate="ddlTipoPersonaJuridica"
                Display="None" ErrorMessage="Dato Obligatorio" Operator="NotEqual" ValidationGroup="Datos"
                ValueToCompare="-1" />
            <cc1:ValidatorCalloutExtender ID="vceTipoPersonaJuridica" runat="server" TargetControlID="covTipoPersonaJuridica" />
            <asp:CompareValidator ID="covPermanenciaRubro" runat="server" ControlToValidate="ddlPermanenciaRubro"
                Display="None" ErrorMessage="Dato Obligatorio" Operator="NotEqual" ValidationGroup="Datos"
                ValueToCompare="-1" />
            <cc1:ValidatorCalloutExtender ID="vcePermanenciaRubro" runat="server" TargetControlID="covPermanenciaRubro" />
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="ddlTipoEmpresa" EventName="SelectedIndexChanged" />
            <asp:PostBackTrigger ControlID="btnContinuar" />
        </Triggers>
    </asp:UpdatePanel>
</asp:Content>
