using System;
using System.Collections.Generic;

using System.Text;

using BEME.DA;
using BEME.Entities;

namespace BEME.Business
{
    public class PermanenciaRubroBL : BaseBL
    {
        public List<PermanenciaRubroDTO> GetAll()
        {
            return this.ObjPermanenciaRubroDA.GetAll();
        }
    }
}
