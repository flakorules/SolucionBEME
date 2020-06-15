using System;
using System.Collections.Generic;
using System.Text;

namespace BEME.Entities
{
    public class BancaDerivacionDTO
    {

        private int idBancaDerivacion;
        private string descBancaDerivacion;

        public int IdBancaDerivacion
        {
            get { return idBancaDerivacion; }
            set { idBancaDerivacion = value; }
        }        

        public string DescBancaDerivacion
        {
            get { return descBancaDerivacion; }
            set { descBancaDerivacion = value; }
        }
    }
}
