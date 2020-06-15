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
    public partial class Consulta : System.Web.UI.Page, IConsulta
    {
        private ConsultaPresenter presenter;
        private ConsultaPresenter Presenter
        {
            get
            {
                if (presenter == null)
                {
                    presenter = new ConsultaPresenter(this);
                }
                return presenter;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            SetEventToTextBoxes(Page.Controls);

            if (!IsPostBack) 
            {
                Presenter.GetAllTipoEmpresa();
            }
        }

        #region IConsulta Members

        TipoEmpresaDTO IConsulta.ObjTipooEmpresa
        {
            get 
            {
                TipoEmpresaDTO toReturn = new TipoEmpresaDTO();

                toReturn.IdTipoEmpresa = Convert.ToInt32(ddlTipoEmpresa.SelectedValue);
                toReturn.DescTipoEmpresa = ddlTipoEmpresa.SelectedItem.Text;

                return toReturn;
            }
        }

        List<TipoEmpresaDTO> IConsulta.LstTipoEmpresa
        {
            set 
            {
                ddlTipoEmpresa.DataSource = value;
                ddlTipoEmpresa.DataBind();
            }
        }

        string IConsulta.Rut
        {
            get 
            {
                return txtRut.Text;
            }
        }

        #endregion

        #region Events
        protected void ddlTipoEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(ddlTipoEmpresa.SelectedValue) == (int)Parameters.TipoEmpresa.PersonaNatural)
            {
                btnConsultar.PostBackUrl = Parameters.Paths.FrmPersonaNatural;
            }
            else if (Convert.ToInt32(ddlTipoEmpresa.SelectedValue) == (int)Parameters.TipoEmpresa.PersonaJuridica)
            {
                btnConsultar.PostBackUrl = Parameters.Paths.FrmPersonaJuridica;
            }
            else if (Convert.ToInt32(ddlTipoEmpresa.SelectedValue) == (int)Parameters.TipoEmpresa.ClienteAntiguo)
            {
                btnConsultar.PostBackUrl = Parameters.Paths.FrmConsultaClienteAntiguo;
            }
            else
            {
                btnConsultar.PostBackUrl = string.Empty;
            }
        } 
        #endregion

        #region Private Methods
        private void SetEventToTextBoxes(ControlCollection ctls)
        {
            foreach (Control c in ctls)
            {
                if (c is System.Web.UI.WebControls.TextBox)
                {
                    TextBox tb = c as TextBox;
                    tb.Attributes.Add(Parameters.Texts.OnKeyPress,
                        string.Format(Parameters.FormatStrings.OnKeyPressButtonClick,
                            btnConsultar.ClientID));

                }
                if (c.HasControls())
                {
                    SetEventToTextBoxes(c.Controls);

                }
            }
        } 
        #endregion
    }
}
