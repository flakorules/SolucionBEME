using System;
using System.Collections.Generic;

using System.Text;

using BEME.Business;
using BEME.Entities;
using BEME.Interfaces;


namespace BEME.Presenters
{
    public class ConsultaPresenter : PresenterBase
    {
        private IConsulta view;
        

        public ConsultaPresenter(IConsulta view) 
        {
            this.view = view;
        }

        public void GetAllTipoEmpresa()
        {
            view.LstTipoEmpresa = ObjTipoEmpresaBL.GetAll();
        }
    }
}
