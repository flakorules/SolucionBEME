using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BEME.DA;
using BEME.Entities;
using BEME.Exceptions;
using BEME.Core;

namespace BEME.Business
{
    public class ClienteAntiguoBL : BaseBL
    {
        public ClienteAntiguoDTO Insert(ClienteAntiguoDTO objIn)
        {
            ObjClienteAntiguoDA.Insert(objIn);
            objIn.IdClienteAntiguo = GetMaxId();
            return objIn;
        }

        public void Update(ClienteAntiguoDTO objIn)
        {
            ObjClienteAntiguoDA.Update(objIn);
        }

        public ClienteAntiguoDTO GetById(ClienteAntiguoDTO objIn)
        {

            //return ObjClienteAntiguoDA.GetById(objIn);
            ClienteAntiguoDTO toReturn = ObjClienteAntiguoDA.GetById(objIn);

            if (toReturn == null)
            {
                throw new NotFoundIdException(objIn.RutClienteAntiguo);
            }

            toReturn.LstLogClienteAntiguo = ObjLogClienteAntiguoBL.GetAllByParameters(
                    new LogClienteAntiguoDTO
                    {
                        IdClienteAntiguo = objIn.IdClienteAntiguo.GetValueOrDefault()
                    }
                );

            return toReturn;
        }

        public ClienteAntiguoDTO GetById(string rut)
        {
            ClienteAntiguoDTO toReturn = new ClienteAntiguoDTO();
            toReturn.RutClienteAntiguo = rut;
            toReturn = ObjClienteAntiguoDA.GetById(toReturn);
            return toReturn;
        }

        public List<InformeClienteAntiguoDTO> GetAll()
        {
            return ObjClienteAntiguoDA.GetAll();
        }

        public int? GetMaxId()
        {
            return ObjClienteAntiguoDA.GetMaxId();
        }

        public List<ClienteAntiguoDTO> GetByRut(ClienteAntiguoDTO objIn)
        {
            List<ClienteAntiguoDTO> toReturn = ObjClienteAntiguoDA.GetByRut(objIn);

            if (toReturn.Count == Parameters.PositiveNumbers.ZERO)
            {
                throw new NotFoundIdException(objIn.RutClienteAntiguo);
            }

            return ObjClienteAntiguoDA.GetByRut(objIn);
        }
    }
}
