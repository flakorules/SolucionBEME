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
    public partial class DatosPersonaNatural : System.Web.UI.Page, IDatosPersonaNatural
    {
        private DatosPersonaNaturalPresenter presenter;
        private DatosPersonaNaturalPresenter Presenter
        {
            get
            {
                if (presenter == null)
                {
                    presenter = new DatosPersonaNaturalPresenter(this);
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
                Presenter.GetAllPermanenciaRubro();
                SetDataFromPreviousPage();
                Presenter.GetAllLog();
            }
        }

        #region IDatosPersonaNatural Members

        List<UsuariosDTO> IDatosPersonaNatural.LstUsuarios
        {
            set 
            {
                ddlUsuarios.DataSource = value;
                ddlUsuarios.DataBind();
            }
        }

        PersonaNaturalDTO IDatosPersonaNatural.ObjPersonaNatural
        {
            get 
            {
                PersonaNaturalDTO toReturn = new PersonaNaturalDTO();

                toReturn.IdUsuario = Convert.ToInt32(ddlUsuarios.SelectedValue);
                toReturn.NombrePersonaNatural = txtNombreCliente.Text;
                toReturn.RutPersonaNatural = txtRutCliente.Text;

                toReturn.IdFormalidad = Convert.ToInt32(ddlTipoFormalidad.SelectedValue);
                toReturn.IdNivelVentas = Convert.ToInt32(ddlNivelVentas.SelectedValue);
                toReturn.IdTipoEmpresa = Convert.ToInt32(ddlTipoEmpresa.SelectedValue);
                toReturn.IdPermanenciaRubro = Convert.ToInt32(ddlPermanenciaRubro.SelectedValue);


                toReturn.TelefonoPersonaNatural = txtTelefonoCliente.Text;
                toReturn.CorreoPersonaNatural = txtCorreoCliente.Text;
                toReturn.NomEmpresaPersonaNatural = txtNombreEmpresaCliente.Text;
                toReturn.RutEmpresaPersonaNatural = txtRutEmpresaCliente.Text;
                toReturn.GiroComercialEmpresaPersonaNatural= txtGiroComercial.Text;
                toReturn.ObservacionesPersonaNatural= txtObservaciones.Text;

                toReturn.LstFamiliaProductos = this.GetAllSelectedFamilias();


                return toReturn;
            }
            set 
            {
                PersonaNaturalDTO toReturn = value;
                ddlUsuarios.SelectedValue = Convert.ToString(toReturn.IdUsuario);
                txtNombreCliente.Text = toReturn.NombrePersonaNatural;
                txtRutCliente.Text = toReturn.RutPersonaNatural;

                ddlTipoFormalidad.SelectedValue = Convert.ToString(toReturn.IdFormalidad);
                ddlNivelVentas.SelectedValue = Convert.ToString(toReturn.IdNivelVentas);
                ddlTipoEmpresa.SelectedValue = Convert.ToString(toReturn.IdTipoEmpresa);
                ddlPermanenciaRubro.SelectedValue = Convert.ToString(toReturn.IdPermanenciaRubro);
                
                txtTelefonoCliente.Text = toReturn.TelefonoPersonaNatural;
                txtCorreoCliente.Text = toReturn.CorreoPersonaNatural;
                txtNombreEmpresaCliente.Text = toReturn.NomEmpresaPersonaNatural;
                txtRutEmpresaCliente.Text = toReturn.RutEmpresaPersonaNatural;
                txtGiroComercial.Text = toReturn.GiroComercialEmpresaPersonaNatural;
                //txtObservaciones.Text = toReturn.ObservacionesPersonaNatural;

                repFamiliaProductos.DataSource = value.LstFamiliaProductos;
                repFamiliaProductos.DataBind();
            }
        }

        List<TipoFormalidadDTO> IDatosPersonaNatural.LstTipoFormalidad
        {
            set
            {
                ddlTipoFormalidad.DataSource = value;
                ddlTipoFormalidad.DataBind();
            }
        }

        List<NivelVentasDTO> IDatosPersonaNatural.LstNivelVentas
        {
            set
            {
                ddlNivelVentas.DataSource = value;
                ddlNivelVentas.DataBind();
            }
        }

        List<TipoEmpresaDTO> IDatosPersonaNatural.LstTipoEmpresa
        {
            set
            {
                ddlTipoEmpresa.DataSource = value;
                ddlTipoEmpresa.DataBind();
            }
        }

        List<PermanenciaRubroDTO> IDatosPersonaNatural.LstPermanenciaRubro
        {
            set
            {
                ddlPermanenciaRubro.DataSource = value;
                ddlPermanenciaRubro.DataBind();
            }
        }

        LogPersonaNaturalDTO IDatosPersonaNatural.LogPersonaNatural
        {
            get 
            {
                LogPersonaNaturalDTO toReturn = new LogPersonaNaturalDTO();

                toReturn.RutPersonaNatural = txtRutCliente.Text;
                toReturn.Fecha = DateTime.Now;
                toReturn.IdUsuario = Convert.ToInt32(ddlUsuarios.SelectedValue);
                toReturn.Texto = txtObservaciones.Text;


                return toReturn;
            }
        }


        List<LogPersonaNaturalDTO> IDatosPersonaNatural.LstLogPersonaNatural
        {
            set 
            {
                gvLog.DataSource = value;
                gvLog.DataBind();
            }
        }


        #endregion

        #region Events
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
                        Presenter.UpdateObservaciones();
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
                    
                    txtNombreCliente.ReadOnly = true;
                    txtRutCliente.ReadOnly = true;
                    txtTelefonoCliente.ReadOnly = true;
                    txtCorreoCliente.ReadOnly = true;
                    txtNombreEmpresaCliente.ReadOnly = true;
                    txtRutEmpresaCliente.ReadOnly = true;
                    txtGiroComercial.ReadOnly = true;

                }
                catch (NotFoundIdException ex)
                {
                    litMensaje.Text = ex.Message;
                    mpeMensaje.Show();
                }
            }
            else
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

                #region Permanencia en el Rubro
                PermanenciaRubroDTO objPermanenciaRubroDTO = pagPrevia.ObjPermanenciaRubroDTO;
                ddlPermanenciaRubro.SelectedValue = Convert.ToString(objPermanenciaRubroDTO.IdPermanenciaRubro);
                #endregion

                #region Familia de Productos - Productos Disponibles
                repFamiliaProductos.DataSource = (List<FamiliaProductosDTO>)(((IIngreso)PreviousPage).LstFamiliaProductos);
                repFamiliaProductos.DataBind();
                #endregion

                txtNombreCliente.ReadOnly = false;
                txtRutCliente.ReadOnly = false;
                txtTelefonoCliente.ReadOnly = false;
                txtCorreoCliente.ReadOnly = false;
                txtNombreEmpresaCliente.ReadOnly = false;
                txtRutEmpresaCliente.ReadOnly = false;
                txtGiroComercial.ReadOnly = false;
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
    }
}
