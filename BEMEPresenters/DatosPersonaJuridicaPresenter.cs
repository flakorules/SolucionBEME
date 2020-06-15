using System;
using System.Collections.Generic;

using System.Text;

using BEME.Business;
using BEME.Entities;
using BEME.Interfaces;

namespace BEME.Presenters
{
    public class DatosPersonaJuridicaPresenter : PresenterBase
    {
        private IDatosPersonaJuridica view;

        public DatosPersonaJuridicaPresenter(IDatosPersonaJuridica view) 
        {
            this.view = view;
        }

        public void Insert()
        {
            ObjPersonaJuridicaBL.Insert(view.ObjPersonaJuridica);
        }

        public void Update()
        {
            ObjPersonaJuridicaBL.UpdateObservaciones(view.ObjPersonaJuridica);
        }

        public void GetAllTipoPersonaJuridica()
        {
            view.LstTipoPersonaJuridica = ObjTipoPersonaJuridicaBL.GetAll();
        }

        public void GetById() 
        {
            view.ObjPersonaJuridica = ObjPersonaJuridicaBL.GetById(view.ObjPersonaJuridica);
        }

        public void GetAllTipoFormalidad()
        {
            view.LstTipoFormalidad = this.ObjTipoFormalidadBL.GetAll();
        }

        public void GetAllNivelVentas()
        {
            view.LstNivelVentas = this.ObjNivelVentasBL.GetAll();
        }

        public void GetAllTipoEmpresa()
        {
            view.LstTipoEmpresa = ObjTipoEmpresaBL.GetAll();
        }

        public void GetAllPermanenciaRubro()
        {
            view.LstPermanenciaRubro = ObjPermanenciaRubroBL.GetAll();
        }

        public void GetAllUsuarios()
        {
            view.LstUsuarios = ObjUsuariosBL.GetAll();
        }

        public void GetAllLog() 
        {
            view.LstLogPersonaJuridica = ObjLogPersonaJuridicaBL.GetAllByParameters(view.LogPersonaJuridica);
        }

        public void InsertLog() 
        {
            ObjLogPersonaJuridicaBL.Insert(view.LogPersonaJuridica);
        }

        
    }
}
