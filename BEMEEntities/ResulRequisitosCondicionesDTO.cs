using System;
using System.Collections.Generic;

using System.Text;

namespace BEME.Entities
{
    public class ResulRequisitosCondicionesDTO
    {
        private int idBancaDerivacion;
        private int idTipoEmpresa;
        private int idRequisitosCondiciones;

        public int IdBancaDerivacion
        {
            get { return idBancaDerivacion; }
            set { idBancaDerivacion = value; }
        }
        

        public int IdTipoEmpresa
        {
            get { return idTipoEmpresa; }
            set { idTipoEmpresa = value; }
        }
        

        public int IdRequisitosCondiciones
        {
            get { return idRequisitosCondiciones; }
            set { idRequisitosCondiciones = value; }
        }
    }
}
