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
    public partial class Ingreso : System.Web.UI.Page, IIngreso
    {
        private IngresoPresenter presenter;
        private IngresoPresenter Presenter
        {
            get
            {
                if (presenter == null)
                {
                    presenter = new IngresoPresenter(this);
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
                Presenter.GetAllTipoCliente();
                Presenter.GetAllTipoFormalidad();
                Presenter.GetAllNivelVentas();
                Presenter.GetAllBancaDerivacion();
                Presenter.GetAllTipoEmpresa();
                Presenter.GetAllPermanenciaRubro();
            }
        }

        #region IIngreso Members

        UsuariosDTO IIngreso.ObjUsuariosDTO
        {
            get 
            {
                UsuariosDTO obj = new UsuariosDTO();

                obj.IdUsuario = Convert.ToInt32(ddlUsuarios.SelectedValue);
                obj.NombreUsuario = ddlUsuarios.SelectedItem.Text;

                return obj;
            }
        }

        List<UsuariosDTO> IIngreso.LstUsuarios
        {
            set 
            {
                ddlUsuarios.DataSource = value;
                ddlUsuarios.DataBind();
            }
        }

        List<TipoClienteDTO> IIngreso.LstTipoCliente
        {
            set
            {
                ddlTipoCliente.DataSource = value;
                ddlTipoCliente.DataBind();
            }
        }

        TipoFormalidadDTO IIngreso.ObjTipoFormalidadDTO
        {
            get
            {
                TipoFormalidadDTO obj = new TipoFormalidadDTO();
                obj.IdFormalidad = Convert.ToInt32(ddlTipoFormalidad.SelectedValue);
                obj.DescTipoFormalidad = ddlTipoFormalidad.SelectedItem.Text;
                return obj;
            }
        }

        List<TipoFormalidadDTO> IIngreso.LstTipoFormalidad
        {
            set
            {
                ddlTipoFormalidad.DataSource = value;
                ddlTipoFormalidad.DataBind();
            }
        }

        NivelVentasDTO IIngreso.ObjNivelVentasDTO
        {
            get
            {
                NivelVentasDTO obj = new NivelVentasDTO();
                obj.IdNivelVentas = Convert.ToInt32(ddlNivelVentas.SelectedValue);
                obj.DescNivelVentas = ddlNivelVentas.SelectedItem.Text;
                return obj;
            }
        }

        List<NivelVentasDTO> IIngreso.LstNivelVentas
        {
            set
            {
                ddlNivelVentas.DataSource = value;
                ddlNivelVentas.DataBind();
            }
        }

        List<BancaDerivacionDTO> IIngreso.LstBancaDerivacion
        {
            set
            {
                ddlBancaDerivacion.DataSource = value;
                ddlBancaDerivacion.DataBind();
            }
        }

        ResultadoDerivacionDTO IIngreso.ObjResultadoDerivacion
        {
            get
            {
                ResultadoDerivacionDTO objResultadoDerivacion = new ResultadoDerivacionDTO();

                objResultadoDerivacion.IdTipoCliente = Convert.ToInt32(ddlTipoCliente.SelectedValue);
                objResultadoDerivacion.IdFormalidad = Convert.ToInt32(ddlTipoFormalidad.SelectedValue);
                objResultadoDerivacion.IdNivelVentas = Convert.ToInt32(ddlNivelVentas.SelectedValue);

                return objResultadoDerivacion;
            }
        }

        BancaDerivacionDTO IIngreso.ObjBancaDerivacion
        {
            set
            {
                BancaDerivacionDTO objBancaDerivacion = value;
                ddlBancaDerivacion.SelectedValue = value.IdBancaDerivacion.ToString();
            }
        }

        TipoEmpresaDTO IIngreso.ObjTipoEmpresaDTO
        {
            get
            {
                TipoEmpresaDTO obj = new TipoEmpresaDTO();
                obj.IdTipoEmpresa = Convert.ToInt32(ddlTipoEmpresa.SelectedValue);
                obj.DescTipoEmpresa = ddlTipoEmpresa.SelectedItem.Text;
                return obj;
            }
        }

        List<TipoEmpresaDTO> IIngreso.LstTipoEmpresa
        {
            set
            {
                ddlTipoEmpresa.DataSource = value.FindAll(o => o.IdTipoEmpresa != (int)Parameters.TipoEmpresa.ClienteAntiguo);
                ddlTipoEmpresa.DataBind();
            }
        }

        TipoPersonaJuridicaDTO IIngreso.ObjTipoPersonaJuridica
        {
            get
            {
                TipoPersonaJuridicaDTO obj = new TipoPersonaJuridicaDTO();
                obj.IdTipoPersonaJuridica = Convert.ToInt32(ddlTipoPersonaJuridica.SelectedValue);
                obj.DescTipoPersonaJuridica = ddlTipoPersonaJuridica.SelectedItem.Text;
                return obj;
            }
        }

        List<TipoPersonaJuridicaDTO> IIngreso.LstTipoPersonaJuridica
        {
            set
            {
                if (ddlTipoPersonaJuridica.Items.Count > Parameters.PositiveNumbers.ONE)
                {
                    for (int i = ddlTipoPersonaJuridica.Items.Count - Parameters.PositiveNumbers.ONE;
                        i > Parameters.PositiveNumbers.ZERO;
                        i--)
                    {
                        ddlTipoPersonaJuridica.Items.RemoveAt(i);
                    }
                }

                ddlTipoPersonaJuridica.DataSource = value;
                ddlTipoPersonaJuridica.DataBind();
            }
        }

        PermanenciaRubroDTO IIngreso.ObjPermanenciaRubroDTO
        {
            get
            {
                PermanenciaRubroDTO obj = new PermanenciaRubroDTO();
                obj.IdPermanenciaRubro = Convert.ToInt32(ddlPermanenciaRubro.SelectedValue);
                obj.DescPermanenciaRubro = ddlPermanenciaRubro.SelectedItem.Text;
                return obj;
            }
        }
                
        List<PermanenciaRubroDTO> IIngreso.LstPermanenciaRubro
        {
            set
            {
                ddlPermanenciaRubro.DataSource = value;
                ddlPermanenciaRubro.DataBind();
            }
        }

        List<FamiliaProductosDTO> IIngreso.LstFamiliaProductos
        {
            set
            {

                ClearFamiliaProductos();
                repFamiliaProductos.DataSource = value;
                repFamiliaProductos.DataBind();
            }
            get 
            {
                return GetAllSelectedFamilias();
            }
        }

        //TODO: Quizas haya que remover esta propiedad
        ResultadoProductosDisponiblesDTO IIngreso.ObjResultadoProductosDisponibles
        {
            get
            {
                ResultadoProductosDisponiblesDTO objResultadoProductosDisponibles = new ResultadoProductosDisponiblesDTO();

                objResultadoProductosDisponibles.IdTipoEmpresa = Convert.ToInt32(ddlTipoEmpresa.SelectedValue);
                objResultadoProductosDisponibles.IdTipoPersonaJuridica = Convert.ToInt32(ddlTipoPersonaJuridica.SelectedValue);
                objResultadoProductosDisponibles.IdPermanenciaRubro = Convert.ToInt32(ddlPermanenciaRubro.SelectedValue);
                

                return objResultadoProductosDisponibles;
            }
        }


        

        RequisitosCondicionesDTO IIngreso.ObjRequisitosCondiciones
        {
            set
            {
                lnbDownload.Visible = (value != null);
                trRequisitosCondiciones.Visible = (value != null);
            }
        }

        ResulRequisitosCondicionesDTO IIngreso.ObjResulRequisitosCondiciones
        {
            
            get 
            {
                ResulRequisitosCondicionesDTO obj = new ResulRequisitosCondicionesDTO();
                obj.IdBancaDerivacion = Convert.ToInt32(ddlBancaDerivacion.SelectedValue);
                obj.IdTipoEmpresa = Convert.ToInt32(ddlTipoEmpresa.SelectedValue);
                return obj;
            }
        }

        #endregion

        #region Events
        protected void btnLimpiar_Click(object sender, EventArgs e)
        {

            GetAllSelectedFamilias();

            ddlTipoCliente.SelectedValue = Convert.ToString(Parameters.NegativeNumbers.ONE);
            ddlTipoFormalidad.SelectedValue = Convert.ToString(Parameters.NegativeNumbers.ONE);
            ddlNivelVentas.SelectedValue = Convert.ToString(Parameters.NegativeNumbers.ONE);
            ddlBancaDerivacion.SelectedValue = Convert.ToString(Parameters.NegativeNumbers.ONE);


            ddlTipoEmpresa.SelectedValue = Convert.ToString(Parameters.NegativeNumbers.ONE);

            ddlTipoPersonaJuridica.SelectedValue = Convert.ToString(Parameters.NegativeNumbers.ONE);
            ClearTipoPersonaJuridica();
            ddlTipoPersonaJuridica.Enabled = false;

            ddlPermanenciaRubro.SelectedValue = Convert.ToString(Parameters.NegativeNumbers.ONE);

            ClearFamiliaProductos();

        }

        protected void ddlTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetAllDerivacionByParameters();
            Presenter.GetResulRequisitosCondicionesDTO();
        }

        protected void ddlTipoFormalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetAllDerivacionByParameters();
            Presenter.GetResulRequisitosCondicionesDTO();
        }

        protected void ddlNivelVentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetAllDerivacionByParameters();
            Presenter.GetResulRequisitosCondicionesDTO();
        }

        protected void ddlTipoEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(ddlTipoEmpresa.SelectedValue) == (int)Parameters.TipoEmpresa.PersonaNatural) 
            {
                btnContinuar.PostBackUrl = Parameters.Paths.FrmPersonaNatural;
            }
            else if (Convert.ToInt32(ddlTipoEmpresa.SelectedValue) == (int)Parameters.TipoEmpresa.PersonaJuridica)
            {
                btnContinuar.PostBackUrl = Parameters.Paths.FrmPersonaJuridica;
            }
            else 
            {
                btnContinuar.PostBackUrl = string.Empty;
            }

            Presenter.GetAllTipoPersonaJuridicaByParameters();

            if (Convert.ToInt32(ddlTipoEmpresa.SelectedValue) ==
                (int)Parameters.TipoEmpresa.PersonaNatural)
            {
                ddlTipoPersonaJuridica.SelectedValue = Convert.ToString((int)Parameters.TipoPersonaJuridica.NA);
                ddlTipoPersonaJuridica.Enabled = false;
            }
            else if (Convert.ToInt32(ddlTipoEmpresa.SelectedValue) ==
                (int)Parameters.TipoEmpresa.PersonaJuridica)
            {
                ddlTipoPersonaJuridica.SelectedValue = Convert.ToString(Parameters.NegativeNumbers.ONE);
                ddlTipoPersonaJuridica.Enabled = true;
            }
            else
            {

                if (ddlTipoPersonaJuridica.Items.Count > Parameters.PositiveNumbers.ONE)
                {
                    for (int i = ddlTipoPersonaJuridica.Items.Count - Parameters.PositiveNumbers.ONE;
                        i > Parameters.PositiveNumbers.ZERO;
                        i--)
                    {
                        ddlTipoPersonaJuridica.Items.RemoveAt(i);
                    }
                }

                ddlTipoPersonaJuridica.SelectedValue = Convert.ToString(Parameters.NegativeNumbers.ONE);
                ddlTipoPersonaJuridica.Enabled = false;
            }

            GetAllFamiliaProductosByParameters();
            

            Presenter.GetResulRequisitosCondicionesDTO();
        }

        protected void ddlTipoPersonaJuridica_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetAllFamiliaProductosByParameters();
        }

        protected void ddlPermanenciaRubro_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetAllFamiliaProductosByParameters();
        }

        #endregion

        #region Private Methods
        private void GetAllDerivacionByParameters()
        {
            if (Convert.ToInt32(ddlTipoCliente.SelectedValue) != Parameters.NegativeNumbers.ONE &&
                Convert.ToInt32(ddlTipoFormalidad.SelectedValue) != Parameters.NegativeNumbers.ONE &&
                Convert.ToInt32(ddlNivelVentas.SelectedValue) != Parameters.NegativeNumbers.ONE)
            {
                Presenter.GetAllDerivacionByParameters();
            }
            else
            {
                ddlBancaDerivacion.SelectedValue = Convert.ToString(Parameters.NegativeNumbers.ONE);
            }
        }


        private void GetAllFamiliaProductosByParameters()
        {
            if (Convert.ToInt32(ddlTipoEmpresa.SelectedValue) != Parameters.NegativeNumbers.ONE &&
                Convert.ToInt32(ddlTipoPersonaJuridica.SelectedValue) != Parameters.NegativeNumbers.ONE &&
                Convert.ToInt32(ddlPermanenciaRubro.SelectedValue) != Parameters.NegativeNumbers.ONE)
            {
                Presenter.GetAllFamiliaProductosByParameters();
            }
            else
            {
                ClearFamiliaProductos();
            }

        }

        private void ClearTipoPersonaJuridica() 
        {
            if (ddlTipoPersonaJuridica.Items.Count > Parameters.PositiveNumbers.ONE)
            {
                for (int i = ddlTipoPersonaJuridica.Items.Count - Parameters.PositiveNumbers.ONE;
                    i > Parameters.PositiveNumbers.ZERO;
                    i--)
                {
                    ddlTipoPersonaJuridica.Items.RemoveAt(i);
                }
            }
        }

        private void ClearFamiliaProductos()
        {
            repFamiliaProductos.DataSource = null;
            repFamiliaProductos.DataBind();
        }

        

        private List<FamiliaProductosDTO> GetAllSelectedFamilias()
        {
            List<FamiliaProductosDTO> toReturn = new List<FamiliaProductosDTO>();
            List<ProductosDisponiblesDTO> lstProductos;
            FamiliaProductosDTO objFamilia;
            ProductosDisponiblesDTO objPdcto;
            foreach (RepeaterItem item in repFamiliaProductos.Items)
            {

                CheckBoxList cblProductosDisponibles = (CheckBoxList)item.FindControl("cblProductosDisponibles");



                if (cblProductosDisponibles.SelectedIndex != Parameters.NegativeNumbers.ONE)
                {
                    objFamilia = new FamiliaProductosDTO();
                    objFamilia.DescFamiliaProductos = ((Literal)item.FindControl("litDescFamiliaProductos")).Text;
                    objFamilia.IdFamiliaProductos = Convert.ToInt32(((HiddenField)item.FindControl("hdnIdFamiliaProductos")).Value);

                    lstProductos = new List<ProductosDisponiblesDTO>();
                    foreach (ListItem itemCbl in cblProductosDisponibles.Items)
                    {
                        if (itemCbl.Selected)
                        {
                            objPdcto = new ProductosDisponiblesDTO();
                            objPdcto.IdProductosDisponibles = Convert.ToInt32(itemCbl.Value);
                            objPdcto.DescProductosDisponibles = itemCbl.Text;
                            objPdcto.IdFamiliaProductos = objFamilia.IdFamiliaProductos;
                            lstProductos.Add(objPdcto);

                        }
                    }

                    objFamilia.LstProductosDisponibles = lstProductos;
                    toReturn.Add(objFamilia);
                }
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
                            btnContinuar.ClientID));

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
