<%@ Page Language="C#" MasterPageFile="~/BEME.Master" AutoEventWireup="true" CodeBehind="Informes.aspx.cs"
    Inherits="BEME.Web.Informes" Title="Untitled Page" %>

<%@ Register Assembly="AjaxControlToolkit, Version=1.0.20229.20821, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e"
    Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <cc1:TabContainer ID="tabInformes" runat="server">
        <cc1:TabPanel ID="tabPersonaNatural" runat="server" HeaderText="Persona Natural">
            <ContentTemplate>
                <fieldset>
                    <legend>Listado Persona Natural</legend>
                    <asp:Button ID="btnExpPersNat" runat="server" Text="Exportar a Excel" OnClick="btnExpPersNat_Click" />
                    <div style="height: 800px; width: 1000px; overflow: auto;">
                        <asp:GridView ID="gvPersonaNatural" runat="server" AutoGenerateColumns="False" CssClass="mGrid">
                            <Columns>
                                <asp:BoundField DataField="NombreUsuario" HeaderText="Usuario" />
                                <asp:BoundField DataField="NombrePersonaNatural" HeaderText="Nombre Cliente" />
                                <asp:BoundField DataField="RutEmpresaPersonaNatural" HeaderText="RUT Cliente" />
                                <asp:BoundField DataField="TelefonoPersonaNatural" HeaderText="Teléfono" />
                                <asp:BoundField DataField="CorreoPersonaNatural" HeaderText="Correo" />
                                <asp:BoundField DataField="NomEmpresaPersonaNatural" HeaderText="Nombre Empresa" />
                                <asp:BoundField DataField="RutEmpresaPersonaNatural" HeaderText="RUT Empresa" />
                                <asp:BoundField DataField="GiroComercialEmpresaPersonaNatural" HeaderText="Giro Comercial" />
                                <asp:BoundField DataField="DescTipoFormalidad" HeaderText="Formalidad" />
                                <asp:BoundField DataField="DescNivelVentas" HeaderText="Nivel de Ventas" />
                                <asp:BoundField DataField="DescTipoEmpresa" HeaderText="Tipo de Empresa" />
                                <asp:BoundField DataField="DescPermanenciaRubro" HeaderText="Permanencia en el Rubro" />
                                <asp:BoundField DataField="NombreUsuarioCnx" HeaderText="Conexion" />
                                <asp:BoundField DataField="FechaLogPN" HeaderText="Fecha Conexion" DataFormatString="{0:dd-MM-yyyy}" />
                                <asp:BoundField DataField="FechaLogPN" HeaderText="Hora" DataFormatString="{0:HH:mm:ss}"  />
                                <asp:BoundField DataField="TextoLogPN" HeaderText="Gestión" />                                    
                            </Columns>
                            <EditRowStyle BorderStyle="None" />
                        </asp:GridView>
                    </div>
                </fieldset>
            </ContentTemplate>
        </cc1:TabPanel>
        <cc1:TabPanel ID="tabPersonaJuridica" runat="server" HeaderText="Persona Jurídica">
            <ContentTemplate>
                <fieldset>
                    <legend>Listado Persona Jurídica</legend>
                    <asp:Button ID="btnExpPersJur" runat="server" Text="Exportar a Excel" OnClick="btnExpPersJur_Click" />
                    <div style="height: 800px; width: 1000px; overflow: auto;">
                        <asp:GridView ID="gvPersonaJuridica" runat="server" AutoGenerateColumns="False" CssClass="mGrid">
                            <Columns>
                                <asp:BoundField DataField="NombreUsuario" HeaderText="Nombre de Usuario" />
                                <asp:BoundField DataField="NombreEmpresa" HeaderText="Nombre Empresa" />
                                <asp:BoundField DataField="RutEmpresa" HeaderText="RUT Empresa" />
                                <asp:BoundField DataField="NombreRepresLegal" HeaderText="Repres. Legal" />
                                <asp:BoundField DataField="RutRepresLegal" HeaderText="RUT Repres Legal" />
                                <asp:BoundField DataField="GiroComercial" HeaderText="Giro Comercial" />
                                <asp:BoundField DataField="DescTipoPersonaJuridica" HeaderText="Tipo de PJ" />
                                <asp:BoundField DataField="Telefono" HeaderText="Teléfono" />
                                <asp:BoundField DataField="Correo" HeaderText="Correo" />
                                <asp:BoundField DataField="DescTipoFormalidad" HeaderText="Formalidad" />
                                <asp:BoundField DataField="DescNivelVentas" HeaderText="Nivel de Ventas" />
                                <asp:BoundField DataField="DescTipoEmpresa" HeaderText="Tipo de Empresa" />
                                <asp:BoundField DataField="DescPermanenciaRubro" HeaderText="Permanencia en el Rubro" />
                                <asp:BoundField DataField="NombreUsuarioCnx" HeaderText="Conexion" />
                                <asp:BoundField DataField="FechaLogPJ" HeaderText="Fecha Conexion" DataFormatString="{0:dd-MM-yyyy}" />
                                <asp:BoundField DataField="FechaLogPJ" HeaderText="Hora" DataFormatString="{0:HH:mm:ss}"  />
                                <asp:BoundField DataField="TextoLogPJ" HeaderText="Gestión" />                                    
                            </Columns>
                            <EditRowStyle BorderStyle="None" />
                        </asp:GridView>
                    </div>
                </fieldset>
            </ContentTemplate>
        </cc1:TabPanel>
        <cc1:TabPanel ID="tabClienteAntiguo" runat="server" HeaderText="Clientes Antiguos">
            <ContentTemplate>
                <fieldset>
                    <legend>Listado Persona Jurídica</legend>
                    <asp:Button ID="btnExpCliAnt" runat="server" Text="Exportar a Excel" OnClick="btnExpCliAnt_Click" />
                    <div style="height: 800px; width: 1000px; overflow: auto;">
                        <asp:GridView ID="gvClienteAntiguo" runat="server" AutoGenerateColumns="False" CssClass="mGrid">
                            <Columns>
                                <asp:BoundField DataField="IdClienteAntiguo" HeaderText="Correlativo" />
                                <asp:BoundField DataField="RutClienteAntiguo" HeaderText="RUT Cliente" />
                                <asp:BoundField DataField="NombreClienteAntiguo" HeaderText="Nombre Cliente" />
                                <asp:BoundField DataField="FecPresClienteAntiguo" HeaderText="Fecha Presentación"
                                    DataFormatString="{0:dd-MM-yyyy}" />
                                <asp:BoundField DataField="ReqClienteAntiguo" HeaderText="Requerimiento" />
                                <asp:BoundField DataField="ResClienteAntiguo" HeaderText="Resolucion" />
                                <asp:BoundField DataField="NombreUsuarioCnx" HeaderText="Conexion" />
                                <asp:BoundField DataField="FechaLogCA" HeaderText="Fecha Conexion" DataFormatString="{0:dd-MM-yyyy}" />
                                <asp:BoundField DataField="FechaLogCA" HeaderText="Hora" DataFormatString="{0:HH:mm:ss}" />
                                <asp:BoundField DataField="ResFinClienteAntiguo" HeaderText="Gestión" />
                            </Columns>
                            <EditRowStyle BorderStyle="None" />
                        </asp:GridView>
                    </div>
            </ContentTemplate>
        </cc1:TabPanel>
    </cc1:TabContainer>
</asp:Content>
