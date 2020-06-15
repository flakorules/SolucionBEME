using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using BEME.Interfaces;
using System.Collections.Generic;
using BEME.Entities;
using BEME.Presenters;
namespace BEME.Web
{
    public partial class ConsultaLog : System.Web.UI.Page, IConsultaLog
    {
        private ConsultaLogPresenter presenter;
        private ConsultaLogPresenter Presenter
        {
            get
            {
                if (presenter == null)
                {
                    presenter = new ConsultaLogPresenter(this);
                }
                return presenter;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Presenter.GetAllLog();
        }

        #region IConsultaLog Members

        List<LogPersonaNaturalDTO> IConsultaLog.LstLogPersonaNatural
        {
            set
            {
                gvLog.DataSource = value;
                gvLog.DataBind();
            }
        }

        #endregion
    }
}
