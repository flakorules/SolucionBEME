using System;
using System.Collections.Generic;

using System.Text;
using BEME.DA;
using BEME.Entities;
namespace BEME.Business
{
    public class FamiliaProductosBL : BaseBL
    {
        
        public List<FamiliaProductosDTO> GetAll()
        {
            return this.ObjFamiliaProductosDA.GetAll();
        }

        public List<FamiliaProductosDTO> GetAllByParameters(ResultadoProductosDisponiblesDTO objIn) 
        {
            List<FamiliaProductosDTO> toReturn = this.ObjFamiliaProductosDA.GetAllByParameters(objIn);
            
            foreach (var obj in toReturn) 
            {
                objIn.IdFamiliaProductos = obj.IdFamiliaProductos;
                obj.LstProductosDisponibles = ObjProductosDisponiblesBL.GetAllByParameters(objIn);
            }

            return toReturn;
        }

        public List<FamiliaProductosDTO> GetAllByParameters(PJFamProdProdDTO objIn) 
        {
            List<FamiliaProductosDTO> toReturn = this.ObjFamiliaProductosDA.GetAllByParameters(objIn);
            
            foreach (FamiliaProductosDTO objFamilia in toReturn) 
            { 
                objIn.IdFamiliaProductos = objFamilia.IdFamiliaProductos;
                objFamilia.LstProductosDisponibles = ObjProductosDisponiblesBL.GetAllByParameters(objIn);
            }

            return toReturn;
        }

        public List<FamiliaProductosDTO> GetAllByParameters(PNFamProdProdDTO objIn)
        {
            List<FamiliaProductosDTO> toReturn = this.ObjFamiliaProductosDA.GetAllByParameters(objIn);

            foreach (FamiliaProductosDTO objFamilia in toReturn)
            {
                objIn.IdFamiliaProductos = objFamilia.IdFamiliaProductos;
                objFamilia.LstProductosDisponibles = ObjProductosDisponiblesBL.GetAllByParameters(objIn);
            }

            return toReturn;
        }
    }
}
