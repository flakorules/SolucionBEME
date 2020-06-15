using System;
using System.Collections.Generic;

using System.Text;

namespace BEME.Entities
{
    public class ResultadoDerivacionDTO
    {
        private int idTipoCliente;
        private int idFormalidad;
        private int idNivelVentas;
        private int idBancaDerivacion;

        public int IdTipoCliente
        {
            get { return idTipoCliente; }
            set { idTipoCliente = value; }
        }        

        public int IdFormalidad
        {
            get { return idFormalidad; }
            set { idFormalidad = value; }
        }        

        public int IdNivelVentas
        {
            get { return idNivelVentas; }
            set { idNivelVentas = value; }
        }        

        public int IdBancaDerivacion
        {
            get { return idBancaDerivacion; }
            set { idBancaDerivacion = value; }
        }
    }
}
