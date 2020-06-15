using System;
using System.Collections.Generic;

using System.Text;

namespace BEME.Exceptions
{
    public class DuplicatedIdException: Exception
    {
        public DuplicatedIdException() 
        { 
        }
        public DuplicatedIdException(string Id)
            : base(string.Format("Id {0} ya existe en Base de Datos", Id))
        {
        }
    }
}
