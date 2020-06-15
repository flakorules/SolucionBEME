using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BEME.Entities;

namespace BEME.Interfaces
{
    public interface IConsultaClienteAntiguo
    {
        int Id { get; }
        ClienteAntiguoDTO ObjClienteAntiguo { get; }
        List<ClienteAntiguoDTO> LstClienteAntiguo { set; }
    }
}
