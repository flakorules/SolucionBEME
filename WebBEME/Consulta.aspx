<%@ Page Language="C#" MasterPageFile="~/BEME.Master" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs"
    Inherits="BEME.Web.Consulta" Title="Untitled Page" %>

<%@ Register Assembly="AjaxControlToolkit, Version=1.0.20229.20821, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e"
    Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <b>Consulta</b>
    <fieldset>
        <table align="center" style="width: 60%" class="inputForm">
            <tr>
                <td>
                    <label style="font-weight: bold;">
                        Tipo de Empresa:</label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlTipoEmpresa" runat="server" AppendDataBoundItems="True"
                        DataTextField="DescTipoEmpresa" DataValueField="IdTipoEmpresa" AutoPostBack="True"
                        Width="100%" CssClass="txt" ValidationGroup="Datos" OnSelectedIndexChanged="ddlTipoEmpresa_SelectedIndexChanged">
                        <asp:ListItem Value="-1" Text="--Seleccionar--" />
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <label style="font-weight: bold;">
                        RUT:</label>
                </td>
                <td>
                    <asp:TextBox ID="txtRut" runat="server" 
                    MaxLength="10" ValidationGroup="Datos" CssClass="txt" ToolTip="Sin puntos ni guión. Ejemplo:12345678-K" />
                </td>
            </tr>
        </table>
    </fieldset>
    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>
            <fieldset>
                <center>
                    <asp:Button ID="btnConsultar" runat="server" Text="Consultar" ValidationGroup="Datos" />
                </center>
            </fieldset>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="ddlTipoEmpresa" 
                EventName="SelectedIndexChanged" />
        </Triggers>
    </asp:UpdatePanel>
    <asp:CompareValidator ID="covTipoEmpresa" runat="server" ErrorMessage="Dato Obligatorio"
        ValidationGroup="Datos" Display="None" ControlToValidate="ddlTipoEmpresa" ValueToCompare="-1"
        Operator="NotEqual" />
    <cc1:ValidatorCalloutExtender ID="vceTipoEmpresa" runat="server" TargetControlID="covTipoEmpresa" />
    <asp:RequiredFieldValidator ID="rfvRut" runat="server" ErrorMessage="Dato Obligatorio"
        ValidationGroup="Datos" Display="None" ControlToValidate="txtRut" />
    <asp:CustomValidator ID="cuvRut" runat="server" ErrorMessage="RUT No Válido" ControlToValidate="txtRut"
        ValidationGroup="Datos" Display="None" ClientValidationFunction="validar_rut" />
    <cc1:ValidatorCalloutExtender ID="vceRut" runat="server" TargetControlID="rfvRut" />
    <cc1:ValidatorCalloutExtender ID="vceRut1" runat="server" TargetControlID="cuvRut"/>
</asp:Content>
