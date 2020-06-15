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

namespace BEME.Web
{
    public partial class ConsultaClienteAntiguo : System.Web.UI.Page, IConsultaClienteAntiguo
    {
        private ConsultaClienteAntiguoPresenter presenter;
        private ConsultaClienteAntiguoPresenter Presenter
        {
            get
            {
                if (presenter == null)
                {
                    presenter = new ConsultaClienteAntiguoPresenter(this);
                }
                return presenter;
            }
        }

        private int id;


        #region Events
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SetDataFromPreviousPage();
            }
        }

        protected void gvClientes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex = Convert.ToInt32(e.CommandArgument);
            int id = Convert.ToInt32(gvClientes.DataKeys[rowIndex].Values["IdClienteAntiguo"]);
            this.id = id;
            Server.Transfer(Parameters.Paths.FrmClienteAntiguo);
            //Response.Redirect(Parameters.Paths.FrmClienteAntiguo);
        } 
        #endregion

        #region IConsultaClienteAntiguo Members

        int IConsultaClienteAntiguo.Id
        {
            get 
            {
                return id;
            }
        }

        ClienteAntiguoDTO IConsultaClienteAntiguo.ObjClienteAntiguo
        {
            get 
            {
                ClienteAntiguoDTO toReturn = new ClienteAntiguoDTO();

                toReturn.RutClienteAntiguo = txtRut.Text;

                return toReturn;
            }
        }

        List<ClienteAntiguoDTO> IConsultaClienteAntiguo.LstClienteAntiguo
        {
            set 
            {
                gvClientes.DataSource = value;
                gvClientes.DataBind();
            }
        }

        #endregion

        #region Private Methods
        private void SetDataFromPreviousPage()
        {
            if (PreviousPage is IConsulta)
            {

                try
                {

                    txtRut.Text = ((IConsulta)PreviousPage).Rut;
                    Presenter.GetByRut();
                }
                catch (NotFoundIdException ex)
                {
                    litMensaje.Text = ex.Message;
                    mpeMensaje.Show();
                }
            }
        } 
        #endregion

        

        
    }
}
