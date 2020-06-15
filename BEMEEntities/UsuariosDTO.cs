using System;
using System.Collections.Generic;

using System.Text;

namespace BEME.Entities
{
    public class UsuariosDTO
    {
        private int idUsuario;
        private string nombreUsuario;

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }
        

        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }
    }
}
