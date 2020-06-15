using System;
using System.Collections.Generic;

using System.Text;
using BEME.Entities;

namespace BEME.Interfaces
{
    public interface IIngreso
    {
        UsuariosDTO ObjUsuariosDTO { get; }
        List<UsuariosDTO> LstUsuarios { set; }
        
        List<TipoClienteDTO> LstTipoCliente {set;}

        TipoFormalidadDTO ObjTipoFormalidadDTO { get; }
        List<TipoFormalidadDTO> LstTipoFormalidad { set; }

        NivelVentasDTO ObjNivelVentasDTO { get; }
        List<NivelVentasDTO> LstNivelVentas { set; }
        
        List<BancaDerivacionDTO> LstBancaDerivacion { set; }

        ResultadoDerivacionDTO ObjResultadoDerivacion { get; }
        BancaDerivacionDTO ObjBancaDerivacion { set; }

        TipoEmpresaDTO ObjTipoEmpresaDTO { get; }
        List<TipoEmpresaDTO> LstTipoEmpresa { set; }

        TipoPersonaJuridicaDTO ObjTipoPersonaJuridica { get; }
        List<TipoPersonaJuridicaDTO> LstTipoPersonaJuridica { set; }

        PermanenciaRubroDTO ObjPermanenciaRubroDTO { get; }
        List<PermanenciaRubroDTO> LstPermanenciaRubro { set; }
        
        List<FamiliaProductosDTO> LstFamiliaProductos { set; get; }

        ResultadoProductosDisponiblesDTO ObjResultadoProductosDisponibles { get; }
        

        ResulRequisitosCondicionesDTO ObjResulRequisitosCondiciones { get; }
        RequisitosCondicionesDTO ObjRequisitosCondiciones { set; }

        
    }
}
