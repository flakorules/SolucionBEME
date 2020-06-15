using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BEME.Business;
using BEME.Entities;
using BEME.Interfaces;

namespace BEME.Presenters
{
    public class InformesPresenter : PresenterBase
    {
        private IInformes view;

        public InformesPresenter(IInformes view) 
        {
            this.view = view;
        }

        public void GetAllPersonaNatural() 
        {
            view.LstPersonaNatural = ObjPersonaNaturalBL.GetAll();
        }

        public void GetAllPersonaJuridica()
        {
            view.LstPersonaJuridica = ObjPersonaJuridicaBL.GetAll();
        }

        public void GetAllClienteAntiguo() 
        {
            view.LstClienteAntiguo = ObjClienteAntiguoBL.GetAll();
        }
    }
}
