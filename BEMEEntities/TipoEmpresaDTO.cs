using System;
using System.Collections.Generic;
using System.Text;

namespace BEME.Entities
{
    public class TipoEmpresaDTO
    {
        private int idTipoEmpresa;
        private string descTipoEmpresa;

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
    }
}
