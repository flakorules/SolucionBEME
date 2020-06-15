using System;
using System.Collections;
using System.Configuration;
using System.Data;

using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;



using BEME.Entities;
using BEME.Interfaces;
using BEME.Presenters;
using BEME.Core;
using System.Collections.Generic;

namespace BEME.Web
{
    public partial class Download : System.Web.UI.Page, IDownload
    {
        private DownloadPresenter presenter;
        private DownloadPresenter Presenter
        {
            get
            {
                if (presenter == null)
                {
                    presenter = new DownloadPresenter(this);
                }
                return presenter;
            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            Presenter.GetResulRequisitosCondicionesDTO();
        }

        #region IDownload Members

        ResulRequisitosCondicionesDTO IDownload.ObjResulRequisitosCondiciones
        {
            get 
            {
                ResulRequisitosCondicionesDTO obj;

                obj = ((IIngreso)PreviousPage).ObjResulRequisitosCondiciones;

                return obj;
            }
        }

        RequisitosCondicionesDTO IDownload.ObjRequisitosCondiciones
        {
            set 
            {
                RequisitosCondicionesDTO obj = value;


                Response.Clear();
                Response.ContentType = "application/pdf";
                Response.AppendHeader("Content-Disposition", "attachment; filename=RequisitosCondiciones.pdf");
                Response.TransmitFile(Server.MapPath(obj.RutaRequisitosCondiciones));
                Response.End(); 

                
            }
        }

        #endregion
    }
}
