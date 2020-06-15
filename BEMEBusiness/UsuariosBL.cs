using System;
using System.Collections.Generic;

using System.Text;
using BEME.DA;
using BEME.Entities;

namespace BEME.Business
{
    public class UsuariosBL : BaseBL
    {
        
        public List<UsuariosDTO> GetAll() 
        {
            return ObjUsuariosDA.GetAll();
        }

        public UsuariosDTO GetById(UsuariosDTO objIn) 
        {
            return ObjUsuariosDA.GetById(objIn);
        }
    }
}
