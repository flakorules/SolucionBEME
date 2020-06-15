using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BEME.Entities
{
    public class LogPersonaNaturalDTO
    {
        private int idLog;
        private string rutPersonaNatural;
        private string nombrePersonaNatural;
        private DateTime fecha;
        private int idUsuario;
        private string nombreUsuario;
        private string texto;

        public int IdLog
        {
            get { return idLog; }
            set { idLog = value; }
        }

        public string RutPersonaNatural
        {
            get { return rutPersonaNatural; }
            set { rutPersonaNatural = value; }
        }

        public string NombrePersonaNatural
        {
            get { return nombrePersonaNatural; }
            set { nombrePersonaNatural = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

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

        public string Texto
        {
            get { return texto; }
            set { texto = value; }
        }
    }
}
