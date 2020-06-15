using System;
using System.Collections.Generic;

using System.Text;
using BEME.DA;
using BEME.Entities;

namespace BEME.Business
{
    public class TipoClienteBL : BaseBL
    {
        

        public List<TipoClienteDTO> GetAll()
        {
            return this.ObjTipoClienteDA.GetAll();
        }
    }
}
