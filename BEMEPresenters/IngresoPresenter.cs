using System;
using System.Collections.Generic;

using System.Text;
using BEME.Business;
using BEME.Entities;
using BEME.Interfaces;


namespace BEME.Presenters
{
    public class IngresoPresenter : PresenterBase
    {
        private IIngreso view;
        
        public IngresoPresenter(IIngreso view) 
        {
            this.view = view;
        }

        public void GetAllUsuarios() 
        {
            view.LstUsuarios = ObjUsuariosBL.GetAll();
        }

        public void GetAllTipoCliente() 
        {
            view.LstTipoCliente = this.ObjTipoClienteBL.GetAll();
        }

        public void GetAllTipoFormalidad()
        {
            view.LstTipoFormalidad = this.ObjTipoFormalidadBL.GetAll();
        }

        public void GetAllNivelVentas()
        {
            view.LstNivelVentas = this.ObjNivelVentasBL.GetAll();
        }

        public void GetAllBancaDerivacion()
        {
            view.LstBancaDerivacion = this.ObjBancaDerivacionBL.GetAll();
        }

        public void GetAllTipoEmpresa()
        {
            view.LstTipoEmpresa = ObjTipoEmpresaBL.GetAll();
        }

        public void GetAllTipoPersonaJuridica()
        {
            view.LstTipoPersonaJuridica = ObjTipoPersonaJuridicaBL.GetAll();
        }

        public void GetAllTipoPersonaJuridicaByParameters()
        {
            view.LstTipoPersonaJuridica = ObjTipoPersonaJuridicaBL.GetAllByParameters(view.ObjResultadoProductosDisponibles);
        }

        public void GetAllPermanenciaRubro()
        {
            view.LstPermanenciaRubro = ObjPermanenciaRubroBL.GetAll();
        }

        public void GetAllFamiliaProductos()
        {
            view.LstFamiliaProductos = ObjFamiliaProductosBL.GetAll();
        }

        public void GetAllFamiliaProductosByParameters()
        {
            view.LstFamiliaProductos = ObjFamiliaProductosBL.GetAllByParameters(view.ObjResultadoProductosDisponibles);
        }

        public void GetAllDerivacionByParameters() 
        {
            view.ObjBancaDerivacion = ObjBancaDerivacionBL.GetAllByParameters(view.ObjResultadoDerivacion);
        }

        public void GetResulRequisitosCondicionesDTO() 
        {
            view.ObjRequisitosCondiciones = ObjRequisitosCondicionesBL.GetByParameters(view.ObjResulRequisitosCondiciones);
        }


    }
}
