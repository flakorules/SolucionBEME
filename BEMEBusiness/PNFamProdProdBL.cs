using System;
using System.Collections.Generic;

using System.Text;
using BEME.DA;
using BEME.Entities;


namespace BEME.Business
{
    public class PNFamProdProdBL : BaseBL
    {        
        public void Insert(PNFamProdProdDTO objIn)
        {
            ObjPNFamProdProdDA.Insert(objIn);
        }

        public void Insert(PersonaNaturalDTO objIn)
        {
            PNFamProdProdDTO objPJFamProdProdDTO;

            foreach (FamiliaProductosDTO itemFam in objIn.LstFamiliaProductos)
            {
                foreach (ProductosDisponiblesDTO itemProd in itemFam.LstProductosDisponibles)
                {
                    objPJFamProdProdDTO = new PNFamProdProdDTO();
                    objPJFamProdProdDTO.RutPersonaNatural = objIn.RutPersonaNatural;
                    objPJFamProdProdDTO.IdFamiliaProductos = itemFam.IdFamiliaProductos;
                    objPJFamProdProdDTO.IdProductosDisponibles = itemProd.IdProductosDisponibles;
                    Insert(objPJFamProdProdDTO);
                }
            }
        }
    }
}
