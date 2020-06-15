using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BEME.Business;
using BEME.Entities;
using BEME.Interfaces;

namespace BEME.Presenters
{
    public class DatosClienteAntiguoPresenter : PresenterBase
    {

        private IDatosClienteAntiguo view;


        public DatosClienteAntiguoPresenter(IDatosClienteAntiguo view) 
        {
            this.view = view;
        }

        public void Insert()
        {
            view.ObjClienteAntiguo = ObjClienteAntiguoBL.Insert(view.ObjClienteAntiguo);
        }

        public void Update()
        {
            ObjClienteAntiguoBL.Update(view.ObjClienteAntiguo);
        }

        public void GetById()
        {
            view.ObjClienteAntiguo = ObjClienteAntiguoBL.GetById(view.ObjClienteAntiguo);
        }

        public void GetAllUsuarios()
        {
            view.LstUsuarios = ObjUsuariosBL.GetAll();
        }

        public void InsertLog()
        {
            ObjLogClienteAntiguoBL.Insert(view.LogClienteAntiguo);
        }
    }
}
