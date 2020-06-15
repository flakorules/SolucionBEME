using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BEME.Business;
using BEME.Entities;
using BEME.Interfaces;

namespace BEME.Presenters
{
    public class ConsultaClienteAntiguoPresenter : PresenterBase
    {
        private IConsultaClienteAntiguo view;

        public ConsultaClienteAntiguoPresenter(IConsultaClienteAntiguo view)
        {
            this.view = view;
        }

        public void GetByRut()
        {
            view.LstClienteAntiguo = ObjClienteAntiguoBL.GetByRut(view.ObjClienteAntiguo);
        }
    }
}
