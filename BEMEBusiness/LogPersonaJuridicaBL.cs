using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BEME.DA;
using BEME.Entities;

namespace BEME.Business
{
    public class LogPersonaJuridicaBL : BaseBL
    {
        public void Insert(LogPersonaJuridicaDTO objIn) 
        {
            ObjLogPersonaJuridicaDA.Insert(objIn);
        }


        public List<LogPersonaJuridicaDTO> GetAllByParameters(LogPersonaJuridicaDTO objIN) 
        {
            return ObjLogPersonaJuridicaDA.GetAllByParameters(objIN);
        }
    }
}
