using System;
using System.Collections.Generic;

using System.Text;

using BEME.Business;
using BEME.Entities;
using BEME.Interfaces;

namespace BEME.Presenters
{
    public class DatosPersonaNaturalPresenter : PresenterBase
    {
        private IDatosPersonaNatural view;

        public DatosPersonaNaturalPresenter(IDatosPersonaNatural view) 
        {
            this.view = view;
        }

        public void Insert() 
        {
            ObjPersonaNaturalBL.Insert(view.ObjPersonaNatural);
        }

        public void UpdateObservaciones()
        {
            ObjPersonaNaturalBL.UpdateObservaciones(view.ObjPersonaNatural);
        }

        public void GetById() 
        {
            view.ObjPersonaNatural = ObjPersonaNaturalBL.GetById(view.ObjPersonaNatural);
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
            view.LstLogPersonaNatural = ObjLogPersonaNaturalBL.GetAllByParameters(view.LogPersonaNatural);
        }

        public void InsertLog()
        {
            ObjLogPersonaNaturalBL.Insert(view.LogPersonaNatural);
        }


    }
}
