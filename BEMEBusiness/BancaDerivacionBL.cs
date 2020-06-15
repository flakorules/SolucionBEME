using System;
using System.Collections.Generic;

using System.Text;

using BEME.DA;
using BEME.Entities;


namespace BEME.Business
{
    public class BancaDerivacionBL: BaseBL
    {
        public List<BancaDerivacionDTO> GetAll()
        {
            return this.ObjBancaDerivacionDA.GetAll();
        }

        public BancaDerivacionDTO GetAllByParameters(ResultadoDerivacionDTO obj) 
        {
            return this.ObjBancaDerivacionDA.GetAllByParameters(obj);
        }
    }
}
