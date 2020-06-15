using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using BEME.DA;

namespace BEME.Business
{
    public abstract class BaseBL
    {
        private BancaDerivacionDA objBancaDerivacionDA;
        private ClienteAntiguoDA objClienteAntiguoDA;
        private FamiliaProductosDA objFamiliaProductosDA;
        private LogClienteAntiguoDA objLogClienteAntiguoDA;
        private LogPersonaJuridicaDA objLogPersonaJuridicaDA;
        private LogPersonaNaturalDA objLogPersonaNaturalDA;
        private NivelVentasDA objNivelVentasDA;
        private PermanenciaRubroDA objPermanenciaRubroDA;
        private PersonaJuridicaDA objPersonaJuridicaDA;
        private PersonaNaturalDA objPersonaNaturalDA;
        private PJFamProdProdDA objPJFamProdProdDA;
        private PNFamProdProdDA objPNFamProdProdDA;
        private ProductosDisponiblesDA objProductosDisponiblesDA;
        private RequisitosCondicionesDA objRequisitosCondicionesDA;
        private TipoClienteDA objTipoClienteDA;
        private TipoEmpresaDA objTipoEmpresaDA;
        private TipoFormalidadDA objTipoFormalidadDA;
        private TipoPersonaJuridicaDA objTipoPersonaJuridicaDA;
        private UsuariosDA objUsuariosDA;

        private BancaDerivacionBL objBancaDerivacionBL;
        private ClienteAntiguoBL objClienteAntiguoBL;
        private FamiliaProductosBL objFamiliaProductosBL;
        private LogClienteAntiguoBL objLogClienteAntiguoBL;
        private LogPersonaJuridicaBL objLogPersonaJuridicaBL;
        private LogPersonaNaturalBL objLogPersonaNaturalBL;
        private NivelVentasBL objNivelVentasBL;
        private PermanenciaRubroBL objPermanenciaRubroBL;
        private PersonaJuridicaBL objPersonaJuridicaBL;
        private PersonaNaturalBL objPersonaNaturalBL;
        private PJFamProdProdBL objPJFamProdProdBL;
        private PNFamProdProdBL objPNFamProdProdBL;
        private ProductosDisponiblesBL objProductosDisponiblesBL;
        private RequisitosCondicionesBL objRequisitosCondicionesBL;
        private TipoClienteBL objTipoClienteBL;
        private TipoEmpresaBL objTipoEmpresaBL;
        private TipoFormalidadBL objTipoFormalidadBL;
        private TipoPersonaJuridicaBL objTipoPersonaJuridicaBL;
        private UsuariosBL objUsuariosBL;

        protected BancaDerivacionDA ObjBancaDerivacionDA
        {
            get
            {
                if (objBancaDerivacionDA == null)
                {
                    objBancaDerivacionDA = new BancaDerivacionDA();
                }
                return objBancaDerivacionDA;
            }
        }
        protected ClienteAntiguoDA ObjClienteAntiguoDA
        {
            get
            {
                if (objClienteAntiguoDA == null)
                {
                    objClienteAntiguoDA = new ClienteAntiguoDA();
                }
                return objClienteAntiguoDA;
            }
        }
        protected FamiliaProductosDA ObjFamiliaProductosDA
        {
            get
            {
                if (objFamiliaProductosDA == null)
                {
                    objFamiliaProductosDA = new FamiliaProductosDA();
                }
                return objFamiliaProductosDA;
            }
        }
        protected LogClienteAntiguoDA ObjLogClienteAntiguoDA
        {
            get
            {
                if (objLogClienteAntiguoDA == null)
                {
                    objLogClienteAntiguoDA = new LogClienteAntiguoDA();
                }
                return objLogClienteAntiguoDA;
            }
        }
        protected LogPersonaJuridicaDA ObjLogPersonaJuridicaDA
        {
            get
            {
                if (objLogPersonaJuridicaDA == null)
                {
                    objLogPersonaJuridicaDA = new LogPersonaJuridicaDA();
                }
                return objLogPersonaJuridicaDA;
            }
        }
        protected LogPersonaNaturalDA ObjLogPersonaNaturalDA
        {
            get
            {
                if (objLogPersonaNaturalDA == null)
                {
                    objLogPersonaNaturalDA = new LogPersonaNaturalDA();
                }
                return objLogPersonaNaturalDA;
            }
        }
        protected NivelVentasDA ObjNivelVentasDA
        {
            get
            {
                if (objNivelVentasDA == null)
                {
                    objNivelVentasDA = new NivelVentasDA();
                }
                return objNivelVentasDA;
            }
        }
        protected PermanenciaRubroDA ObjPermanenciaRubroDA
        {
            get
            {
                if (objPermanenciaRubroDA == null)
                {
                    objPermanenciaRubroDA = new PermanenciaRubroDA();
                }
                return objPermanenciaRubroDA;
            }
        }
        protected PersonaJuridicaDA ObjPersonaJuridicaDA
        {
            get
            {
                if (objPersonaJuridicaDA == null)
                {
                    objPersonaJuridicaDA = new PersonaJuridicaDA();
                }
                return objPersonaJuridicaDA;
            }
        }
        protected PersonaNaturalDA ObjPersonaNaturalDA
        {
            get
            {
                if (objPersonaNaturalDA == null)
                {
                    objPersonaNaturalDA = new PersonaNaturalDA();
                }
                return objPersonaNaturalDA;
            }
        }
        protected PJFamProdProdDA ObjPJFamProdProdDA
        {
            get
            {
                if (objPJFamProdProdDA == null)
                {
                    objPJFamProdProdDA = new PJFamProdProdDA();
                }
                return objPJFamProdProdDA;
            }
        }
        protected PNFamProdProdDA ObjPNFamProdProdDA
        {
            get
            {
                if (objPNFamProdProdDA == null)
                {
                    objPNFamProdProdDA = new PNFamProdProdDA();
                }
                return objPNFamProdProdDA;
            }
        }
        protected ProductosDisponiblesDA ObjProductosDisponiblesDA
        {
            get
            {
                if (objProductosDisponiblesDA == null)
                {
                    objProductosDisponiblesDA = new ProductosDisponiblesDA();
                }
                return objProductosDisponiblesDA;
            }
        }
        protected RequisitosCondicionesDA ObjRequisitosCondicionesDA
        {
            get
            {
                if (objRequisitosCondicionesDA == null)
                {
                    objRequisitosCondicionesDA = new RequisitosCondicionesDA();
                }
                return objRequisitosCondicionesDA;
            }
        }
        protected TipoClienteDA ObjTipoClienteDA
        {
            get
            {
                if (objTipoClienteDA == null)
                {
                    objTipoClienteDA = new TipoClienteDA();
                }
                return objTipoClienteDA;
            }
        }
        protected TipoEmpresaDA ObjTipoEmpresaDA
        {
            get
            {
                if (objTipoEmpresaDA == null)
                {
                    objTipoEmpresaDA = new TipoEmpresaDA();
                }
                return objTipoEmpresaDA;
            }
        }
        protected TipoFormalidadDA ObjTipoFormalidadDA
        {
            get
            {
                if (objTipoFormalidadDA == null)
                {
                    objTipoFormalidadDA = new TipoFormalidadDA();
                }
                return objTipoFormalidadDA;
            }
        }
        protected TipoPersonaJuridicaDA ObjTipoPersonaJuridicaDA
        {
            get
            {
                if (objTipoPersonaJuridicaDA == null)
                {
                    objTipoPersonaJuridicaDA = new TipoPersonaJuridicaDA();
                }
                return objTipoPersonaJuridicaDA;
            }
        }
        protected UsuariosDA ObjUsuariosDA
        {
            get
            {
                if (objUsuariosDA == null)
                {
                    objUsuariosDA = new UsuariosDA();
                }
                return objUsuariosDA;
            }
        }

        protected BancaDerivacionBL ObjBancaDerivacionBL
        {
            get
            {
                if (objBancaDerivacionBL == null)
                {
                    objBancaDerivacionBL = new BancaDerivacionBL();
                }
                return objBancaDerivacionBL;
            }
        }
        protected ClienteAntiguoBL ObjClienteAntiguoBL
        {
            get
            {
                if (objClienteAntiguoBL == null)
                {
                    objClienteAntiguoBL = new ClienteAntiguoBL();
                }
                return objClienteAntiguoBL;
            }
        }
        protected FamiliaProductosBL ObjFamiliaProductosBL
        {
            get
            {
                if (objFamiliaProductosBL == null)
                {
                    objFamiliaProductosBL = new FamiliaProductosBL();
                }
                return objFamiliaProductosBL;
            }
        }
        protected LogClienteAntiguoBL ObjLogClienteAntiguoBL
        {
            get
            {
                if (objLogClienteAntiguoBL == null)
                {
                    objLogClienteAntiguoBL = new LogClienteAntiguoBL();
                }
                return objLogClienteAntiguoBL;
            }
        }
        protected LogPersonaJuridicaBL ObjLogPersonaJuridicaBL
        {
            get
            {
                if (objLogPersonaJuridicaBL == null)
                {
                    objLogPersonaJuridicaBL = new LogPersonaJuridicaBL();
                }
                return objLogPersonaJuridicaBL;
            }
        }
        protected LogPersonaNaturalBL ObjLogPersonaNaturalBL
        {
            get
            {
                if (objLogPersonaNaturalBL == null)
                {
                    objLogPersonaNaturalBL = new LogPersonaNaturalBL();
                }
                return objLogPersonaNaturalBL;
            }
        }
        protected NivelVentasBL ObjNivelVentasBL
        {
            get
            {
                if (objNivelVentasBL == null)
                {
                    objNivelVentasBL = new NivelVentasBL();
                }
                return objNivelVentasBL;
            }
        }
        protected PermanenciaRubroBL ObjPermanenciaRubroBL
        {
            get
            {
                if (objPermanenciaRubroBL == null)
                {
                    objPermanenciaRubroBL = new PermanenciaRubroBL();
                }
                return objPermanenciaRubroBL;
            }
        }
        protected PersonaJuridicaBL ObjPersonaJuridicaBL
        {
            get
            {
                if (objPersonaJuridicaBL == null)
                {
                    objPersonaJuridicaBL = new PersonaJuridicaBL();
                }
                return objPersonaJuridicaBL;
            }
        }
        protected PersonaNaturalBL ObjPersonaNaturalBL
        {
            get
            {
                if (objPersonaNaturalBL == null)
                {
                    objPersonaNaturalBL = new PersonaNaturalBL();
                }
                return objPersonaNaturalBL;
            }
        }
        protected PJFamProdProdBL ObjPJFamProdProdBL
        {
            get
            {
                if (objPJFamProdProdBL == null)
                {
                    objPJFamProdProdBL = new PJFamProdProdBL();
                }
                return objPJFamProdProdBL;
            }
        }
        protected PNFamProdProdBL ObjPNFamProdProdBL
        {
            get
            {
                if (objPNFamProdProdBL == null)
                {
                    objPNFamProdProdBL = new PNFamProdProdBL();
                }
                return objPNFamProdProdBL;
            }
        }
        protected ProductosDisponiblesBL ObjProductosDisponiblesBL
        {
            get
            {
                if (objProductosDisponiblesBL == null)
                {
                    objProductosDisponiblesBL = new ProductosDisponiblesBL();
                }
                return objProductosDisponiblesBL;
            }
        }
        protected RequisitosCondicionesBL ObjRequisitosCondicionesBL
        {
            get
            {
                if (objRequisitosCondicionesBL == null)
                {
                    objRequisitosCondicionesBL = new RequisitosCondicionesBL();
                }
                return objRequisitosCondicionesBL;
            }
        }
        protected TipoClienteBL ObjTipoClienteBL
        {
            get
            {
                if (objTipoClienteBL == null)
                {
                    objTipoClienteBL = new TipoClienteBL();
                }
                return objTipoClienteBL;
            }
        }
        protected TipoEmpresaBL ObjTipoEmpresaBL
        {
            get
            {
                if (objTipoEmpresaBL == null)
                {
                    objTipoEmpresaBL = new TipoEmpresaBL();
                }
                return objTipoEmpresaBL;
            }
        }
        protected TipoFormalidadBL ObjTipoFormalidadBL
        {
            get
            {
                if (objTipoFormalidadBL == null)
                {
                    objTipoFormalidadBL = new TipoFormalidadBL();
                }
                return objTipoFormalidadBL;
            }
        }
        protected TipoPersonaJuridicaBL ObjTipoPersonaJuridicaBL
        {
            get
            {
                if (objTipoPersonaJuridicaBL == null)
                {
                    objTipoPersonaJuridicaBL = new TipoPersonaJuridicaBL();
                }
                return objTipoPersonaJuridicaBL;
            }
        }
        protected UsuariosBL ObjUsuariosBL
        {
            get
            {
                if (objUsuariosBL == null)
                {
                    objUsuariosBL = new UsuariosBL();
                }
                return objUsuariosBL;
            }
        }
    }
}
