using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BEME.Entities;

namespace BEME.Interfaces
{
    public interface IDatosClienteAntiguo
    {
        ClienteAntiguoDTO ObjClienteAntiguo { get; set; }
        LogClienteAntiguoDTO LogClienteAntiguo { get; }
        List<UsuariosDTO> LstUsuarios { set; }
    }
}
