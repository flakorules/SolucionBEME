using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BEME.Entities
{
    public class InformePersonaNaturalDTO
    {
        private string rutPersonaNatural;
        private int idUsuario;
        private string nombreUsuario;
        private string nombrePersonaNatural;
        private string telefonoPersonaNatural;
        private string correoPersonaNatural;
        private string nomEmpresaPersonaNatural;
        private string rutEmpresaPersonaNatural;
        private string giroComercialEmpresaPersonaNatural;
        private string observacionesPersonaNatural;
        private int idFormalidad;
        private string descTipoFormalidad;
        private int idNivelVentas;
        private string descNivelVentas;
        private int idTipoEmpresa;
        private string descTipoEmpresa;
        private int idTipoPersonaJuridica;
        private string descTipoPersonaJuridica;
        private int idPermanenciaRubro;
        private string descPermanenciaRubro;
        private string nombreUsuarioCnx;
        private DateTime fechaLogPN;
        private string textoLogPN;
        
        

        public string RutPersonaNatural
        {
            get { return rutPersonaNatural; }
            set { rutPersonaNatural = value; }
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

        public string NombrePersonaNatural
        {
            get { return nombrePersonaNatural; }
            set { nombrePersonaNatural = value; }
        }

        public string TelefonoPersonaNatural
        {
            get { return telefonoPersonaNatural; }
            set { telefonoPersonaNatural = value; }
        }

        public string CorreoPersonaNatural
        {
            get { return correoPersonaNatural; }
            set { correoPersonaNatural = value; }
        }

        public string NomEmpresaPersonaNatural
        {
            get { return nomEmpresaPersonaNatural; }
            set { nomEmpresaPersonaNatural = value; }
        }

        public string RutEmpresaPersonaNatural
        {
            get { return rutEmpresaPersonaNatural; }
            set { rutEmpresaPersonaNatural = value; }
        }

        public string GiroComercialEmpresaPersonaNatural
        {
            get { return giroComercialEmpresaPersonaNatural; }
            set { giroComercialEmpresaPersonaNatural = value; }
        }

        public string ObservacionesPersonaNatural
        {
            get { return observacionesPersonaNatural; }
            set { observacionesPersonaNatural = value; }
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

        public string NombreUsuarioCnx
        {
            get { return nombreUsuarioCnx; }
            set { nombreUsuarioCnx = value; }
        }

        public DateTime FechaLogPN
        {
            get { return fechaLogPN; }
            set { fechaLogPN = value; }
        }

        public string TextoLogPN
        {
            get { return textoLogPN; }
            set { textoLogPN = value; }
        }
    }
}
