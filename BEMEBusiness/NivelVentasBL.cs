using System;
using System.Collections.Generic;

using System.Text;

using BEME.DA;
using BEME.Entities;

namespace BEME.Business
{
    public class NivelVentasBL : BaseBL
    {

        public List<NivelVentasDTO> GetAll()
        {
            return this.ObjNivelVentasDA.GetAll();
        }
    }
}
