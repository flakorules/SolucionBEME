﻿using System;
using System.Collections.Generic;

using System.Text;

using BEME.DA;
using BEME.Entities;

namespace BEME.Business
{
    public class TipoEmpresaBL : BaseBL
    {

        public List<TipoEmpresaDTO> GetAll()
        {
            return this.ObjTipoEmpresaDA.GetAll();
        }

    }
}
