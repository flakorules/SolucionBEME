using System;
using System.Collections.Generic;

using System.Text;
using BEME.DA;
using BEME.Entities;
using BEME.Exceptions;

namespace BEME.Business
{
    public class PersonaJuridicaBL : BaseBL
    {
        
        public void Insert(PersonaJuridicaDTO objIn)
        {
            if (GetById(objIn.RutEmpresa) == null)
            {
                ObjPersonaJuridicaDA.Insert(objIn);
                ObjPJFamProdProdBL.Insert(objIn);
            }
            else 
            {
                throw new DuplicatedIdException(objIn.RutEmpresa);
            }
        }

        public void Update(PersonaJuridicaDTO objIn) 
        {
            ObjPersonaJuridicaDA.Update(objIn);
        }

        public void UpdateObservaciones(PersonaJuridicaDTO objIn)
        {
            PersonaJuridicaDTO objPN = GetById(objIn.RutEmpresa);
            objPN.Observaciones = objIn.Observaciones;
            Update(objPN);
        }



        public PersonaJuridicaDTO GetById(PersonaJuridicaDTO objIn)
        {
            PersonaJuridicaDTO toReturn = ObjPersonaJuridicaDA.GetById(objIn);
            if (toReturn == null)
            {
                throw new NotFoundIdException(objIn.RutEmpresa);
            }

            toReturn.LstFamiliaProductos = ObjFamiliaProductosBL.GetAllByParameters(
                new PJFamProdProdDTO
                {
                    RutEmpresa = objIn.RutEmpresa
                });

            return toReturn;
        }

        public PersonaJuridicaDTO GetById(string rut)
        {
            PersonaJuridicaDTO toReturn = new PersonaJuridicaDTO();
            toReturn.RutEmpresa = rut;
            toReturn = ObjPersonaJuridicaDA.GetById(toReturn);
            return toReturn;
        }

        public List<InformePersonaJuridicaDTO> GetAll()
        {
            return ObjPersonaJuridicaDA.GetAll();
        }
    }
}
