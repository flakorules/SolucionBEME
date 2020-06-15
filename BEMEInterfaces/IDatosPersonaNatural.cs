using System;
using System.Collections.Generic;

using System.Text;
using BEME.Entities;

namespace BEME.Interfaces
{
    public interface IDatosPersonaNatural
    {
        PersonaNaturalDTO ObjPersonaNatural { get; set; }
        List<UsuariosDTO> LstUsuarios { set; }
        List<TipoFormalidadDTO> LstTipoFormalidad { set; }
        List<NivelVentasDTO> LstNivelVentas { set; }
        List<TipoEmpresaDTO> LstTipoEmpresa { set; }
        List<PermanenciaRubroDTO> LstPermanenciaRubro { set; }
        LogPersonaNaturalDTO LogPersonaNatural { get; } 
        List<LogPersonaNaturalDTO> LstLogPersonaNatural { set; } 
    }
}
