using System;
using System.Collections.Generic;

using System.Text;
using BEME.Business;
using BEME.Entities;
using BEME.Interfaces;
namespace BEME.Presenters
{
    public class DownloadPresenter : PresenterBase
    {
        IDownload view;

        //private RequisitosCondicionesBL objResulRequisitosCondicionesBO;

        //private RequisitosCondicionesBL ObjResulRequisitosCondicionesBO
        //{
        //    get
        //    {
        //        if (objResulRequisitosCondicionesBO == null)
        //        {
        //            objResulRequisitosCondicionesBO = new RequisitosCondicionesBL();
        //        }
        //        return objResulRequisitosCondicionesBO;
        //    }
        //}

        public DownloadPresenter(IDownload view) 
        {
            this.view = view;
        }


        public void GetResulRequisitosCondicionesDTO()
        {
            view.ObjRequisitosCondiciones = ObjRequisitosCondicionesBL.GetByParameters(view.ObjResulRequisitosCondiciones);
        }
    }
}
