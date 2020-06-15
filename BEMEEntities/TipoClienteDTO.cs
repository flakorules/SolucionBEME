using System;
using System.Collections.Generic;

using System.Text;

namespace BEME.Entities
{
    public class TipoClienteDTO
    {
        private int idTipoCliente;
        private string descTipoCliente;

        public int IdTipoCliente
        {
            get { return idTipoCliente; }
            set { idTipoCliente = value; }
        }
      
        public string DescTipoCliente
        {
            get { return descTipoCliente; }
            set { descTipoCliente = value; }
        }
    }
}
