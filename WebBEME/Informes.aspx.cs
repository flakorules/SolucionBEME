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

using BEME.Entities;
using BEME.Interfaces;
using BEME.Presenters;
using BEME.Core;
using System.Collections.Generic;
using BEME.Exceptions;
using System.IO;

namespace BEME.Web
{
    public partial class Informes : System.Web.UI.Page, IInformes
    {
        private InformesPresenter presenter;
        private InformesPresenter Presenter
        {
            get
            {
                if (presenter == null)
                {
                    presenter = new InformesPresenter(this);
                }
                return presenter;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                Presenter.GetAllPersonaNatural();
                Presenter.GetAllPersonaJuridica();
                Presenter.GetAllClienteAntiguo();
            }
        }

        #region IInformes Members

        List<InformePersonaNaturalDTO> IInformes.LstPersonaNatural
        {
            set 
            {
                gvPersonaNatural.DataSource = value;
                gvPersonaNatural.DataBind();
            }
        }

        List<InformePersonaJuridicaDTO> IInformes.LstPersonaJuridica
        {
            set 
            {
                gvPersonaJuridica.DataSource = value;
                gvPersonaJuridica.DataBind();
            }
        }

        List<InformeClienteAntiguoDTO> IInformes.LstClienteAntiguo
        {
            set 
            {
                gvClienteAntiguo.DataSource = value;
                gvClienteAntiguo.DataBind();
            }
        }

        #endregion

        public override void VerifyRenderingInServerForm(Control control)
        {
            /* Confirms that an HtmlForm control is rendered for the specified ASP.NET
               server control at run time. */
        }

        protected void btnExpPersNat_Click(object sender, EventArgs e)
        {
            Response.Clear();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment;filename=ListadoPersonaNatural.xls");
            Response.Charset = "";
            Response.ContentType = "application/vnd.ms-excel";
            using (StringWriter sw = new StringWriter())
            {
                HtmlTextWriter hw = new HtmlTextWriter(sw);   
                gvPersonaNatural.AllowPaging = false;
                Presenter.GetAllPersonaNatural();
                gvPersonaNatural.RenderControl(hw);
                Response.Output.Write(sw.ToString());
                Response.Flush();
                Response.End();
            }
        }

        protected void btnExpPersJur_Click(object sender, EventArgs e)
        {
            Response.Clear();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment;filename=ListadoPersonaJuridica.xls");
            Response.Charset = "";
            Response.ContentType = "application/vnd.ms-excel";
            using (StringWriter sw = new StringWriter())
            {
                HtmlTextWriter hw = new HtmlTextWriter(sw);
                gvPersonaJuridica.AllowPaging = false;
                Presenter.GetAllPersonaJuridica();
                gvPersonaJuridica.RenderControl(hw);
                Response.Output.Write(sw.ToString());
                Response.Flush();
                Response.End();
            }
        }

        protected void btnExpCliAnt_Click(object sender, EventArgs e)
        {
            Response.Clear();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment;filename=ListadoClienteAntiguo.xls");
            Response.Charset = "";
            Response.ContentType = "application/vnd.ms-excel";
            using (StringWriter sw = new StringWriter())
            {
                HtmlTextWriter hw = new HtmlTextWriter(sw);
                gvClienteAntiguo.AllowPaging = false;
                Presenter.GetAllClienteAntiguo();
                gvClienteAntiguo.RenderControl(hw);
                Response.Output.Write(sw.ToString());
                Response.Flush();
                Response.End();
            }
        }


        
    }
}
