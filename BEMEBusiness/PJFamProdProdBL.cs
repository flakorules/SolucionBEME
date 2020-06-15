using System;
using System.Collections.Generic;

using System.Text;


using BEME.DA;
using BEME.Entities;

namespace BEME.Business
{
    public class PJFamProdProdBL : BaseBL
    {

        public void Insert(PJFamProdProdDTO objIn)
        {
            ObjPJFamProdProdDA.Insert(objIn);
        }

        //TODO: Agregar método de consulta

        public void Insert(PersonaJuridicaDTO objIn) 
        {
            PJFamProdProdDTO objPJFamProdProdDTO;

            foreach (FamiliaProductosDTO itemFam in objIn.LstFamiliaProductos) 
            {
                foreach (ProductosDisponiblesDTO itemProd in itemFam.LstProductosDisponibles) 
                {
                    objPJFamProdProdDTO = new PJFamProdProdDTO();
                    objPJFamProdProdDTO.RutEmpresa = objIn.RutEmpresa;
                    objPJFamProdProdDTO.IdFamiliaProductos = itemFam.IdFamiliaProductos;
                    objPJFamProdProdDTO.IdProductosDisponibles = itemProd.IdProductosDisponibles;
                    Insert(objPJFamProdProdDTO);
                }
            }
        }
    }
}
