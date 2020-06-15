using System;
using System.Collections.Generic;

using System.Text;

namespace BEME.Entities
{
    public class TipoPersonaJuridicaDTO
    {
        private int idTipoPersonaJuridica;
        private string descTipoPersonaJuridica;

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
    }
}
