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
using BEME.Exceptions;

namespace BEME.Web
{
    public partial class DatosPersonaJuridica : System.Web.UI.Page, IDatosPersonaJuridica
    {

        private DatosPersonaJuridicaPresenter presenter;
        private DatosPersonaJuridicaPresenter Presenter
        {
            get
            {
                if (presenter == null)
                {
                    presenter = new DatosPersonaJuridicaPresenter(this);
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
                Presenter.GetAllTipoFormalidad();
                Presenter.GetAllNivelVentas();
                Presenter.GetAllTipoEmpresa();
                Presenter.GetAllTipoPersonaJuridica();
                Presenter.GetAllPermanenciaRubro();
                SetDataFromPreviousPage();
                Presenter.GetAllLog();
            }
        }

        #region IDatosPersonaJuridica Members

        List<UsuariosDTO> IDatosPersonaJuridica.LstUsuarios
        {
            set 
            {
                ddlUsuarios.DataSource = value;
                ddlUsuarios.DataBind();
            }
        }

        PersonaJuridicaDTO IDatosPersonaJuridica.ObjPersonaJuridica
        {
            get 
            {
                PersonaJuridicaDTO obj = new PersonaJuridicaDTO();

                obj.NombreEmpresa = txtNombreEmpresa.Text;
                obj.IdUsuario = Convert.ToInt32(ddlUsuarios.SelectedValue);
                obj.RutEmpresa= txtRutEmpresa.Text;
                obj.NombreRepresLegal = txtRepresLegal.Text;
                obj.RutRepresLegal = txtRutRepresLegal.Text;
                obj.GiroComercial = txtGiroComercial.Text;

                obj.IdFormalidad = Convert.ToInt32(ddlTipoFormalidad.SelectedValue);
                obj.IdNivelVentas = Convert.ToInt32(ddlNivelVentas.SelectedValue);
                obj.IdTipoEmpresa = Convert.ToInt32(ddlTipoEmpresa.SelectedValue);
                obj.IdTipoPersonaJuridica = Convert.ToInt32(ddlTipoPersonaJuridica.SelectedValue);
                obj.IdPermanenciaRubro = Convert.ToInt32(ddlPermanenciaRubro.SelectedValue);

                obj.Telefono = txtTelefono.Text;
                obj.Correo = txtCorreo.Text;
                obj.Observaciones = txtObservaciones.Text;
                obj.LstFamiliaProductos = this.GetAllSelectedFamilias();

                return obj;
            }
            set 
            {
                PersonaJuridicaDTO obj = value;

                ddlUsuarios.SelectedValue = Convert.ToString(obj.IdUsuario);
                txtNombreEmpresa.Text = obj.NombreEmpresa;
                txtRutEmpresa.Text = obj.RutEmpresa;
                txtRepresLegal.Text = obj.NombreRepresLegal;
                txtRutRepresLegal.Text = obj.RutRepresLegal;
                txtGiroComercial.Text = obj.GiroComercial;

                ddlTipoFormalidad.SelectedValue = Convert.ToString(obj.IdFormalidad);
                ddlNivelVentas.SelectedValue = Convert.ToString(obj.IdNivelVentas);
                ddlTipoEmpresa.SelectedValue = Convert.ToString(obj.IdTipoEmpresa);
                ddlTipoPersonaJuridica.SelectedValue = Convert.ToString(obj.IdTipoPersonaJuridica);
                ddlPermanenciaRubro.SelectedValue = Convert.ToString(obj.IdPermanenciaRubro);
                
                txtTelefono.Text = obj.Telefono;
                txtCorreo.Text = obj.Correo;
                //txtObservaciones.Text = obj.Observaciones;
                
                repFamiliaProductos.DataSource = value.LstFamiliaProductos;
                repFamiliaProductos.DataBind();
            }
        }

        List<TipoFormalidadDTO> IDatosPersonaJuridica.LstTipoFormalidad
        {
            set 
            {
                ddlTipoFormalidad.DataSource = value;
                ddlTipoFormalidad.DataBind();
            }
        }

        List<NivelVentasDTO> IDatosPersonaJuridica.LstNivelVentas
        {
            set 
            {
                ddlNivelVentas.DataSource = value;
                ddlNivelVentas.DataBind();
            }
        }

        List<TipoEmpresaDTO> IDatosPersonaJuridica.LstTipoEmpresa
        {
            set 
            {
                ddlTipoEmpresa.DataSource = value;
                ddlTipoEmpresa.DataBind();
            }
        }

        List<TipoPersonaJuridicaDTO> IDatosPersonaJuridica.LstTipoPersonaJuridica
        {
            set
            {
                ddlTipoPersonaJuridica.DataSource = value;
                ddlTipoPersonaJuridica.DataBind();
            }
        }
        
        List<PermanenciaRubroDTO> IDatosPersonaJuridica.LstPermanenciaRubro
        {
            set 
            {
                ddlPermanenciaRubro.DataSource = value;
                ddlPermanenciaRubro.DataBind();
            }
        }

        LogPersonaJuridicaDTO IDatosPersonaJuridica.LogPersonaJuridica
        {
            get 
            {
                LogPersonaJuridicaDTO toReturn = new LogPersonaJuridicaDTO();

                toReturn.IdUsuario = Convert.ToInt32(ddlUsuarios.SelectedValue);
                toReturn.RutEmpresa = txtRutEmpresa.Text;
                toReturn.Fecha = DateTime.Now;
                toReturn.Texto = txtObservaciones.Text;

                return toReturn;
            }
        }

        List<LogPersonaJuridicaDTO> IDatosPersonaJuridica.LstLogPersonaJuridica
        {
            set 
            {
                gvLog.DataSource = value;
                gvLog.DataBind();
            }
        }

        #endregion

        #region Private Methods
        private void SetDataFromPreviousPage()
        {
            if (PreviousPage is IIngreso)
            {
                HdnIdFormAction.Value = Convert.ToString((int)Parameters.FormAction.Insert);

                IIngreso pagPrevia = (IIngreso)PreviousPage;

                #region Nombre de Usuario
                UsuariosDTO objUsuariosDTO = pagPrevia.ObjUsuariosDTO;
                ddlUsuarios.SelectedValue = Convert.ToString(objUsuariosDTO.IdUsuario); 
                #endregion

                #region Formalidad
                TipoFormalidadDTO objTipoFormalidadDTO = pagPrevia.ObjTipoFormalidadDTO;
                ddlTipoFormalidad.SelectedValue = Convert.ToString(objTipoFormalidadDTO.IdFormalidad); 
                #endregion

                #region Nivel de Ventas
                NivelVentasDTO objNivelVentasDTO = pagPrevia.ObjNivelVentasDTO;
                ddlNivelVentas.SelectedValue = Convert.ToString(objNivelVentasDTO.IdNivelVentas);
                #endregion

                #region Tipo de Empresa
                TipoEmpresaDTO objTipoEmpresaDTO = pagPrevia.ObjTipoEmpresaDTO;
                ddlTipoEmpresa.SelectedValue = Convert.ToString(objTipoEmpresaDTO.IdTipoEmpresa);
                #endregion

                #region Tipo Persona Juridica
                TipoPersonaJuridicaDTO objTipoPersonaJuridica = pagPrevia.ObjTipoPersonaJuridica;
                ddlTipoPersonaJuridica.SelectedValue = Convert.ToString(objTipoPersonaJuridica.IdTipoPersonaJuridica); 
                #endregion

                #region Permanencia en el Rubro
                PermanenciaRubroDTO objPermanenciaRubroDTO = pagPrevia.ObjPermanenciaRubroDTO;
                ddlPermanenciaRubro.SelectedValue = Convert.ToString(objPermanenciaRubroDTO.IdPermanenciaRubro);
                #endregion

                #region Familia de Productos - Productos Disponibles
                repFamiliaProductos.DataSource = (List<FamiliaProductosDTO>)(((IIngreso)PreviousPage).LstFamiliaProductos);
                repFamiliaProductos.DataBind(); 
                #endregion

                txtNombreEmpresa.ReadOnly = false;
                txtRutEmpresa.ReadOnly = false;
                txtRepresLegal.ReadOnly = false;
                txtRutRepresLegal.ReadOnly = false;
                txtGiroComercial.ReadOnly = false;
                txtTelefono.ReadOnly = false;
                txtCorreo.ReadOnly = false;

            }
            else if (PreviousPage is IConsulta)
            {
                HdnIdFormAction.Value = Convert.ToString((int)Parameters.FormAction.Update);

                try
                {
                    txtRutEmpresa.Text = ((IConsulta)PreviousPage).Rut;
                    Presenter.GetById();

                    txtNombreEmpresa.ReadOnly = true;
                    txtRutEmpresa.ReadOnly = true;
                    txtRepresLegal.ReadOnly = true;
                    txtRutRepresLegal.ReadOnly = true;
                    txtGiroComercial.ReadOnly = true;
                    txtTelefono.ReadOnly = true;
                    txtCorreo.ReadOnly = true;


                }
                catch (NotFoundIdException ex)
                {
                    litMensaje.Text = ex.Message;
                    mpeMensaje.Show();
                }
            }
        }

        private List<FamiliaProductosDTO> GetAllSelectedFamilias()
        {
            List<FamiliaProductosDTO> toReturn = new List<FamiliaProductosDTO>();
            List<ProductosDisponiblesDTO> lstProductos;
            FamiliaProductosDTO objFamilia;
            ProductosDisponiblesDTO objPdcto;
            
            foreach (RepeaterItem item in repFamiliaProductos.Items)
            {

                objFamilia = new FamiliaProductosDTO();
                objFamilia.DescFamiliaProductos = ((Literal)item.FindControl("litDescFamiliaProductos")).Text;
                objFamilia.IdFamiliaProductos = Convert.ToInt32(((HiddenField)item.FindControl("hdnIdFamiliaProductos")).Value);

                lstProductos = new List<ProductosDisponiblesDTO>();

                Repeater repPdctos = (Repeater)item.FindControl("repProductosDisponibles");

                foreach (RepeaterItem itemPdcto in repPdctos.Items)
                {
                    objPdcto = new ProductosDisponiblesDTO();
                    objPdcto.IdProductosDisponibles = Convert.ToInt32(((HiddenField)itemPdcto.FindControl("hdnIdProductosDisponibles")).Value);
                    objPdcto.DescProductosDisponibles = ((Literal)itemPdcto.FindControl("litDescProductosDisponibles")).Text;
                    objPdcto.IdFamiliaProductos = Convert.ToInt32(((HiddenField)itemPdcto.FindControl("hdnIdFamiliaProductos")).Value);
                    lstProductos.Add(objPdcto);
                }

                objFamilia.LstProductosDisponibles = lstProductos;
                toReturn.Add(objFamilia);

                
            }
            return toReturn;
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

        #region Methods
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

                litMensaje.Text = "Se ha guardado correctamente el registro.";
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
        #endregion





       
    }
}
