using System;
using System.Collections.Generic;

using System.Text;

using BEME.DA;
using BEME.Entities;
using BEME.Exceptions;

namespace BEME.Business
{
    public class RequisitosCondicionesBL : BaseBL
    {

        public RequisitosCondicionesDTO GetByParameters(ResulRequisitosCondicionesDTO objIn)
        {
            return ObjRequisitosCondicionesDA.GetByParameters(objIn);
        }
    }
}
