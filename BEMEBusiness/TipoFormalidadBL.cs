using System;
using System.Collections.Generic;

using System.Text;
using BEME.DA;
using BEME.Entities;

namespace BEME.Business
{
    public class TipoFormalidadBL : BaseBL
    {

        public List<TipoFormalidadDTO> GetAll()
        {
            return this.ObjTipoFormalidadDA.GetAll();
        }
    }
}
