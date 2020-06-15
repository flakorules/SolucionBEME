using System;
using System.Collections.Generic;

using System.Text;

namespace BEME.Entities
{
    public class PersonaJuridicaDTO
    {
        private string rutEmpresa;
        private int idUsuario;
        private string nombreUsuario;
        private string nombreEmpresa;
        private string nombreRepresLegal;
        private string rutRepresLegal;
        private string giroComercial;
        private int idTipoPersonaJuridica;
        private string descTipoPersonaJuridica;
        private string telefono;
        private string correo;
        private string observaciones;
        private List<FamiliaProductosDTO> lstFamiliaProductos;
        private int idFormalidad;
        private string descTipoFormalidad;
        private int idNivelVentas;
        private string descNivelVentas;
        private int idTipoEmpresa;
        private string descTipoEmpresa;
        private int idPermanenciaRubro;
        private string descPermanenciaRubro;

        public string RutEmpresa
        {
            get { return rutEmpresa; }
            set { rutEmpresa = value; }
        }

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }

        public string NombreEmpresa
        {
            get { return nombreEmpresa; }
            set { nombreEmpresa = value; }
        }
        
        public string NombreRepresLegal
        {
            get { return nombreRepresLegal; }
            set { nombreRepresLegal = value; }
        }
        
        public string RutRepresLegal
        {
            get { return rutRepresLegal; }
            set { rutRepresLegal = value; }
        }
        
        public string GiroComercial
        {
            get { return giroComercial; }
            set { giroComercial = value; }
        }
        
        public int IdTipoPersonaJuridica
        {
            get { return idTipoPersonaJuridica; }
            set { idTipoPersonaJuridica = value; }
        }

        public string DescTipoPersonaJuridica
        {
            get { return descTipoPersonaJuridica; }
            set { descTipoPersonaJuridica = value; }
        }
        
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        
        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }

        public List<FamiliaProductosDTO> LstFamiliaProductos
        {
            get { return lstFamiliaProductos; }
            set { lstFamiliaProductos = value; }
        }

        public int IdFormalidad
        {
            get { return idFormalidad; }
            set { idFormalidad = value; }
        }

        public string DescTipoFormalidad
        {
            get { return descTipoFormalidad; }
            set { descTipoFormalidad = value; }
        }

        public int IdNivelVentas
        {
            get { return idNivelVentas; }
            set { idNivelVentas = value; }
        }
        
        public string DescNivelVentas
        {
            get { return descNivelVentas; }
            set { descNivelVentas = value; }
        }

        public int IdTipoEmpresa
        {
            get { return idTipoEmpresa; }
            set { idTipoEmpresa = value; }
        }
        
        public string DescTipoEmpresa
        {
            get { return descTipoEmpresa; }
            set { descTipoEmpresa = value; }
        }

        public int IdPermanenciaRubro
        {
            get { return idPermanenciaRubro; }
            set { idPermanenciaRubro = value; }
        }

        public string DescPermanenciaRubro
        {
            get { return descPermanenciaRubro; }
            set { descPermanenciaRubro = value; }
        }

    }
}
