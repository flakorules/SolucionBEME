using System;
using System.Collections.Generic;

using System.Text;

namespace BEME.Exceptions
{
    public class NotFoundIdException : Exception
    {
        public NotFoundIdException()
        {
        }
        public NotFoundIdException(string Id)
            : base(string.Format("Id {0} no se encuentra en Base de Datos", Id))
        {
        }
    }
}
