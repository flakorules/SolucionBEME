using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BEME.Entities;

namespace BEME.Interfaces
{
    public interface IInformes
    {
        List<InformePersonaNaturalDTO> LstPersonaNatural { set; }
        List<InformePersonaJuridicaDTO> LstPersonaJuridica { set; }
        List<InformeClienteAntiguoDTO> LstClienteAntiguo { set; }
    }
}
