using System;
using System.Collections.Generic;

using System.Text;
using BEME.Entities;

namespace BEME.Interfaces
{
    public interface IDownload
    {
        ResulRequisitosCondicionesDTO ObjResulRequisitosCondiciones { get; }
        RequisitosCondicionesDTO ObjRequisitosCondiciones { set; }
    }
}
