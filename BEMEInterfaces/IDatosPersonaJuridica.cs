using System;
using System.Collections.Generic;

using System.Text;
using BEME.Entities;

namespace BEME.Interfaces
{
    public interface IDatosPersonaJuridica
    {
        PersonaJuridicaDTO ObjPersonaJuridica { get; set; }
        List<UsuariosDTO> LstUsuarios { set; }
        List<TipoFormalidadDTO> LstTipoFormalidad { set; }
        List<NivelVentasDTO> LstNivelVentas { set; }
        List<TipoEmpresaDTO> LstTipoEmpresa { set; }
        List<TipoPersonaJuridicaDTO> LstTipoPersonaJuridica { set; }
        List<PermanenciaRubroDTO> LstPermanenciaRubro { set; }
        LogPersonaJuridicaDTO LogPersonaJuridica { get; } 
        List<LogPersonaJuridicaDTO> LstLogPersonaJuridica { set; } 
    }
}
