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
    public partial class DatosClienteAntiguo : System.Web.UI.Page, IDatosClienteAntiguo
    {

        private DatosClienteAntiguoPresenter presenter;
        private DatosClienteAntiguoPresenter Presenter
        {
            get
            {
                if (presenter == null)
                {
                    presenter = new DatosClienteAntiguoPresenter(this);
                }
                return presenter;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            SetEventToTextBoxes(Page.Controls);
            if (!IsPostBack)
            {
                Presenter.GetAllUsuarios();

                SetDataFromPreviousPage();
            }
        }


        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
            Parameters.FormAction formAction = (Parameters.FormAction)Convert.ToInt32(HdnIdFormAction.Value);

            switch (formAction)
            {
                case Parameters.FormAction.Insert:
                    Presenter.Insert();
                    Presenter.InsertLog();
                    break;
                case Parameters.FormAction.Update:
                    Presenter.Update();
                    Presenter.InsertLog();
                    break;
                default:
                    break;
            }

            litMensaje.Text = string.Format("Se ha guardado correctamente el registro.<br/>Correlativo: {0}", txtIdClienteAntiguo.Text);
            mpeMensaje.Show();
            }
            catch (DuplicatedIdException ex)
            {
                litMensaje.Text = ex.Message;
                mpeMensaje.Show();
            }
            catch (Exception ex)
            {
                litMensaje.Text = ex.Message;
                mpeMensaje.Show();
            }
        }

        #region IDatosClienteAntiguo Members

        ClienteAntiguoDTO IDatosClienteAntiguo.ObjClienteAntiguo
        {
            get
            {
                ClienteAntiguoDTO obj = new ClienteAntiguoDTO();
                
                obj.IdClienteAntiguo = string.IsNullOrEmpty(txtIdClienteAntiguo.Text) ? 
                    (int?)null : Convert.ToInt32(txtIdClienteAntiguo.Text);
                
                obj.RutClienteAntiguo = txtRutCliente.Text;
                obj.IdUsuario = Convert.ToInt32(ddlUsuarios.SelectedValue);
                obj.FecPresClienteAntiguo = string.IsNullOrEmpty(txtFechaPresentacion.Text) ? (DateTime?)null :
                    DateTime.ParseExact(txtFechaPresentacion.Text, "dd-MM-yyyy", null);

                obj.NombreClienteAntiguo = txtNombreCliente.Text;
                obj.ReqClienteAntiguo = txtReqCliente.Text;
                obj.ResClienteAntiguo = txtResolucion.Text;

                return obj;
            }
            set
            {
                ClienteAntiguoDTO obj = value;

                txtIdClienteAntiguo.Text = obj.IdClienteAntiguo == null ? 
                    string.Empty : obj.IdClienteAntiguo.GetValueOrDefault().ToString(); 
                txtRutCliente.Text = obj.RutClienteAntiguo;
                txtFechaPresentacion.Text = obj.FecPresClienteAntiguo.GetValueOrDefault().ToString("dd-MM-yyyy");
                txtNombreCliente.Text = obj.NombreClienteAntiguo;
                txtReqCliente.Text = obj.ReqClienteAntiguo;
                txtResolucion.Text = obj.ResClienteAntiguo;

                gvLog.DataSource = obj.LstLogClienteAntiguo;
                gvLog.DataBind();
                
            }
        }


        LogClienteAntiguoDTO IDatosClienteAntiguo.LogClienteAntiguo
        {
            get
            {
                LogClienteAntiguoDTO toReturn = new LogClienteAntiguoDTO();


                Parameters.FormAction formAction = (Parameters.FormAction)Convert.ToInt32(HdnIdFormAction.Value);

                switch (formAction)
                {
                    case Parameters.FormAction.Insert:
                        toReturn.IdClienteAntiguo = Convert.ToInt32(txtIdClienteAntiguo.Text);
                        toReturn.IdUsuario = Convert.ToInt32(ddlUsuarios.SelectedValue);
                        toReturn.FechaLogCA = DateTime.Now;

                        toReturn.FecAtenClienteAntiguo = string.IsNullOrEmpty(txtFechaPresentacion.Text) ? (DateTime?)null :
                            DateTime.ParseExact(txtFechaPresentacion.Text, "dd-MM-yyyy", null);                       
    
                        toReturn.ResFinClienteAntiguo = txtReqCliente.Text;
                        break;
                    case Parameters.FormAction.Update:
                        toReturn.IdClienteAntiguo = Convert.ToInt32(txtIdClienteAntiguo.Text);
                        toReturn.IdUsuario = Convert.ToInt32(ddlUsuarios.SelectedValue);
                        toReturn.FechaLogCA = DateTime.Now;
                        toReturn.FecAtenClienteAntiguo = string.IsNullOrEmpty(txtFecAtencion.Text) ? (DateTime?)null :
                            DateTime.ParseExact(txtFecAtencion.Text, "dd-MM-yyyy", null);
                        toReturn.ResFinClienteAntiguo = txtResolucionFinal.Text;
                        break;
                    default:
                        break;
                }             
                return toReturn;
            }
        }


        List<UsuariosDTO> IDatosClienteAntiguo.LstUsuarios
        {
            set 
            {
                ddlUsuarios.DataSource = value;
                ddlUsuarios.DataBind();
            }
        }

        #endregion


        #region Private Methods

        private void SetDataFromPreviousPage()
        {
            if (PreviousPage is IConsulta)
            {
                HdnIdFormAction.Value = Convert.ToString((int)Parameters.FormAction.Update);
                try
                {
                    txtRutCliente.Text = ((IConsulta)PreviousPage).Rut;
                    Presenter.GetById();

                    trCorrelativo.Visible = true;
                    
                    litFechaPresentacion.Visible = false;
                    txtFechaPresentacion.Visible = false;
                    txtFechaPresentacion.ReadOnly = true;
                    ceFechaPresentacion.Enabled = false;
                    imbFechaPresentacion.Visible = false;
                    
                    txtNombreCliente.ReadOnly = true;
                    txtRutCliente.ReadOnly = true;
                    txtReqCliente.ReadOnly = true;
                    txtResolucion.ReadOnly = true;

                    ceFecAtencion.Enabled = true;
                    imbFecAtencion.Enabled = true;

                    txtResolucionFinal.ReadOnly = false;

                    trFecAtancion.Visible = true;
                    trResolucionFinal.Visible = true;

                    rfvFecAtencion.Enabled = true;
                    rfvResolucionFinal.Enabled = true;

                }
                catch (NotFoundIdException ex)
                {
                    litMensaje.Text = ex.Message;
                    mpeMensaje.Show();
                }

            }
            else if (PreviousPage is IConsultaClienteAntiguo) 
            {
                HdnIdFormAction.Value = Convert.ToString((int)Parameters.FormAction.Update);
                litTitulo.Text = "Consulta - Cliente Antiguo";
                txtIdClienteAntiguo.Text = ((IConsultaClienteAntiguo)PreviousPage).Id.ToString();
                
                Presenter.GetById();

                trCorrelativo.Visible = true;

                litFechaPresentacion.Visible = false;
                txtFechaPresentacion.Visible = false;

                txtFechaPresentacion.ReadOnly = true;
                ceFechaPresentacion.Enabled = false;
                imbFechaPresentacion.Visible = false;

                txtNombreCliente.ReadOnly = true;
                txtRutCliente.ReadOnly = true;
                txtReqCliente.ReadOnly = true;
                txtResolucion.ReadOnly = true;

                ceFecAtencion.Enabled = true;
                imbFecAtencion.Enabled = true;

                txtResolucionFinal.ReadOnly = false;

                trFecAtancion.Visible = true;
                trResolucionFinal.Visible = true;
                trGestiones.Visible = true;

                rfvFecAtencion.Enabled = true;
                rfvResolucionFinal.Enabled = true;

            }
            else 
            {
                HdnIdFormAction.Value = Convert.ToString((int)Parameters.FormAction.Insert);
                litTitulo.Text = "Cliente Antiguo";

                trCorrelativo.Visible = false;

                litFechaPresentacion.Visible = true;
                txtFechaPresentacion.Visible = true;
                txtFechaPresentacion.ReadOnly = false;
                ceFechaPresentacion.Enabled = true;
                imbFechaPresentacion.Visible = true;

                txtNombreCliente.ReadOnly = false ;
                txtRutCliente.ReadOnly = false;
                txtReqCliente.ReadOnly = false;
                txtResolucion.ReadOnly = false;

                ceFecAtencion.Enabled = true;
                imbFecAtencion.Enabled = true;

                txtResolucionFinal.ReadOnly = false;


                trFecAtancion.Visible = false;
                trResolucionFinal.Visible = false;
                trGestiones.Visible = false;

                rfvFecAtencion.Enabled = false;
                rfvResolucionFinal.Enabled = false;
            }
        }

        private void SetEventToTextBoxes(ControlCollection ctls)
        {
            foreach (Control c in ctls)
            {
                if (c is System.Web.UI.WebControls.TextBox)
                {
                    TextBox tb = c as TextBox;
                    tb.Attributes.Add(Parameters.Texts.OnKeyPress,
                        string.Format(Parameters.FormatStrings.OnKeyPressButtonClick,
                            btnGuardar.ClientID));

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
