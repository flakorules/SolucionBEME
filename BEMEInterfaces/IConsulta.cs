using System;
using System.Collections.Generic;

using System.Text;
using BEME.Entities;


namespace BEME.Interfaces
{
    public interface IConsulta
    {
        TipoEmpresaDTO ObjTipooEmpresa { get; }
        List<TipoEmpresaDTO> LstTipoEmpresa { set; }
        string Rut { get; }
    }
}
