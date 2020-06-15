<%@ Page Language="C#" MasterPageFile="~/BEME.Master" AutoEventWireup="true" CodeBehind="ConsultaLog.aspx.cs"
    Inherits="BEME.Web.ConsultaLog" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <b>Consulta Log</b>
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
                        Width="100%" CssClass="txt" ValidationGroup="Datos">
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
                    <asp:TextBox ID="txtRut" runat="server" MaxLength="10" ValidationGroup="Datos" CssClass="txt"
                        ToolTip="Sin puntos ni guión. Ejemplo:12345678-K" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <center>
                        <asp:Button ID="btnConsultar" runat="server" Text="Consultar" ValidationGroup="Datos" />
                    </center>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <fieldset>
                        <legend>Resultado</legend>
                        <asp:GridView ID="gvLog" runat="server" AutoGenerateColumns="False" CssClass="mGrid">
                            <Columns>
                                <asp:BoundField DataField="Fecha" HeaderText="Fecha/Hora" />
                                <asp:BoundField DataField="NombreUsuario" HeaderText="Usuario" />
                                <asp:BoundField DataField="Texto" HeaderText="Observaciones" />
                            </Columns>
                            <EditRowStyle BorderStyle="None" />
                        </asp:GridView>
                    </fieldset>
                </td>
            </tr>
        </table>
    </fieldset>
</asp:Content>
