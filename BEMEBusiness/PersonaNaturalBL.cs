using System;
using System.Collections.Generic;

using System.Text;
using BEME.DA;
using BEME.Entities;
using BEME.Exceptions;

namespace BEME.Business
{
    public class PersonaNaturalBL : BaseBL
    {
        public void Insert(PersonaNaturalDTO objIn)
        {
            if (GetById(objIn.RutPersonaNatural) == null)
            {
                ObjPersonaNaturalDA.Insert(objIn);
                ObjPNFamProdProdBL.Insert(objIn);
            }
            else 
            {
                throw new DuplicatedIdException(objIn.RutEmpresaPersonaNatural);
            }
        }

        public void UpdateObservaciones(PersonaNaturalDTO objIn)
        {
            PersonaNaturalDTO objPN = GetById(objIn.RutPersonaNatural);
            objPN.ObservacionesPersonaNatural = objIn.ObservacionesPersonaNatural;
            Update(objPN);
        }

        public void Update(PersonaNaturalDTO objIn) 
        {
            ObjPersonaNaturalDA.Update(objIn);
        }

        public PersonaNaturalDTO GetById(PersonaNaturalDTO objIn)
        {
            PersonaNaturalDTO toReturn = ObjPersonaNaturalDA.GetById(objIn);

            if (toReturn == null)
            {
                throw new NotFoundIdException(objIn.RutPersonaNatural);
            }

            toReturn.LstFamiliaProductos = ObjFamiliaProductosBL.GetAllByParameters(
                new PNFamProdProdDTO
                {
                    RutPersonaNatural = objIn.RutPersonaNatural
                });

            return toReturn;

            return toReturn;
        }

        public PersonaNaturalDTO GetById(String rut)
        {
            PersonaNaturalDTO toReturn = new PersonaNaturalDTO();
            toReturn.RutPersonaNatural = rut;
            toReturn = ObjPersonaNaturalDA.GetById(toReturn);
            return toReturn;
        }

        public List<InformePersonaNaturalDTO> GetAll()
        {
            return ObjPersonaNaturalDA.GetAll();
        }
    }
}
