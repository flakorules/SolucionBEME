using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BEME.DA;
using BEME.Entities;

namespace BEME.Business
{
    public class LogClienteAntiguoBL : BaseBL
    {

       

        public void Insert(LogClienteAntiguoDTO objIn) 
        {
            ObjLogClienteAntiguoDA.Insert(objIn);
        }

        public List<LogClienteAntiguoDTO> GetAllByParameters(LogClienteAntiguoDTO objIN) 
        {
            return ObjLogClienteAntiguoDA.GetAllByParameters(objIN);
        }
    }
}
