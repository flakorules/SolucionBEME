using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BEME.Entities
{
    public class LogClienteAntiguoDTO
    {
        private int idLogCA;
        private int idClienteAntiguo;
        private string nombreClienteAntiguo;
        private int idUsuario;
        private string nombreUsuario;
        private DateTime fechaLogCA;
        private DateTime? fecAtenClienteAntiguo;
        private string resFinClienteAntiguo;
        
        public int IdLogCA
        {
            get { return idLogCA; }
            set { idLogCA = value; }
        }

        public int IdClienteAntiguo
        {
            get { return idClienteAntiguo; }
            set { idClienteAntiguo = value; }
        }
        
        public string NombreClienteAntiguo
        {
            get { return nombreClienteAntiguo; }
            set { nombreClienteAntiguo = value; }
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
        
        public DateTime FechaLogCA
        {
            get { return fechaLogCA; }
            set { fechaLogCA = value; }
        }
        
        public DateTime? FecAtenClienteAntiguo
        {
            get { return fecAtenClienteAntiguo; }
            set { fecAtenClienteAntiguo = value; }
        }
        
        public string ResFinClienteAntiguo
        {
            get { return resFinClienteAntiguo; }
            set { resFinClienteAntiguo = value; }
        }

    }
}
