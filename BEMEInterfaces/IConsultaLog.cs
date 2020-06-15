using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BEME.Entities;

namespace BEME.Interfaces
{
    public interface IConsultaLog
    {
        List<LogPersonaNaturalDTO> LstLogPersonaNatural { set; } 
    }
}
