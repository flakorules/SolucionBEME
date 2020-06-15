using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BEME.DA;
using BEME.Entities;

namespace BEME.Business
{
    public class LogPersonaNaturalBL : BaseBL
    {
        public List<LogPersonaNaturalDTO> GetAll() 
        {
            List<LogPersonaNaturalDTO> toReturn=new List<LogPersonaNaturalDTO>();

            LogPersonaNaturalDTO obj;

            for (int i = 0; i < 5; i++) 
            {
                obj = new LogPersonaNaturalDTO();

                obj.IdLog = i;
                obj.Fecha = DateTime.Now;
                obj.IdUsuario = i;

                obj.NombreUsuario = string.Format("usr{0}", i);
                obj.Texto = string.Format("Texto {0}", i);

                toReturn.Add(obj);
            }

            return toReturn;
        }

        public void Insert(LogPersonaNaturalDTO objIn) 
        {
            ObjLogPersonaNaturalDA.Insert(objIn);
        }


        public List<LogPersonaNaturalDTO> GetAllByParameters(LogPersonaNaturalDTO objIN) 
        {
            return ObjLogPersonaNaturalDA.GetAllByParameters(objIN);
        }
    }
}
