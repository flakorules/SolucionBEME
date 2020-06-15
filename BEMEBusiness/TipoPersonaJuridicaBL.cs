using System;
using System.Collections.Generic;

using System.Text;
using BEME.DA;
using BEME.Entities;

namespace BEME.Business
{
    public class TipoPersonaJuridicaBL : BaseBL
    {
        public List<TipoPersonaJuridicaDTO> GetAll()
        {
            return ObjTipoPersonaJuridicaDA.GetAll();
        }

        public List<TipoPersonaJuridicaDTO> GetAllByParameters(ResultadoProductosDisponiblesDTO objIn) 
        {
            return ObjTipoPersonaJuridicaDA.GetAllByParameters(objIn);
        }
    }
}
