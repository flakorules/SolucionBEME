using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BEME.Interfaces;
using BEME.Business;

namespace BEME.Presenters
{
    public class ConsultaLogPresenter : PresenterBase
    {
        private IConsultaLog view;
        
        public ConsultaLogPresenter(IConsultaLog view) 
        {
            this.view = view;
        }

        public void GetAllLog()
        {
            view.LstLogPersonaNatural = ObjLogPersonaNaturalBL.GetAll();
        }
    }
}
