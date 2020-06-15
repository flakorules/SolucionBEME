using System;
using System.Collections.Generic;

using System.Text;
using BEME.DA;
using BEME.Entities;


namespace BEME.Business
{
    public class ProductosDisponiblesBL : BaseBL
    {
        public List<ProductosDisponiblesDTO> GetAll()
        {
            return this.ObjProductosDisponiblesDA.GetAll();
        }

        public List<ProductosDisponiblesDTO> GetAllByParameters(ResultadoProductosDisponiblesDTO objIN)
        {
            return this.ObjProductosDisponiblesDA.GetAllByParameters(objIN);
        }

        public List<ProductosDisponiblesDTO> GetAllByParameters(PJFamProdProdDTO objIN) 
        {
            return this.ObjProductosDisponiblesDA.GetAllByParameters(objIN);
        }

        public List<ProductosDisponiblesDTO> GetAllByParameters(PNFamProdProdDTO objIN)
        {
            return this.ObjProductosDisponiblesDA.GetAllByParameters(objIN);
        }
    }
}
