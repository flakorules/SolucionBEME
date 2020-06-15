using System;
using System.Collections.Generic;

using System.Text;

namespace BEME.Entities
{
    public class TipoFormalidadDTO
    {
        private int idFormalidad;
        private string descTipoFormalidad;

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


    }
}
