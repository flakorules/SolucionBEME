using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BEME.Business;

namespace BEME.Presenters
{
    public abstract class PresenterBase
    {
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
