using System;
using System.Collections.Generic;

using System.Text;

namespace BEME.Entities
{
    public class ResultadoProductosDisponiblesDTO
    {
        private int idTipoEmpresa;
        private int idTipoPersonaJuridica;
        private int idPermanenciaRubro;
        private int idFamiliaProductos;
        private int idProductosDisponibles;

        public int IdTipoEmpresa
        {
            get { return idTipoEmpresa; }
            set { idTipoEmpresa = value; }
        }

        public int IdTipoPersonaJuridica
        {
            get { return idTipoPersonaJuridica; }
            set { idTipoPersonaJuridica = value; }
        }
        
        public int IdPermanenciaRubro
        {
            get { return idPermanenciaRubro; }
            set { idPermanenciaRubro = value; }
        }
        
        public int IdFamiliaProductos
        {
            get { return idFamiliaProductos; }
            set { idFamiliaProductos = value; }
        }
        
        public int IdProductosDisponibles
        {
            get { return idProductosDisponibles; }
            set { idProductosDisponibles = value; }
        }
    }
}
