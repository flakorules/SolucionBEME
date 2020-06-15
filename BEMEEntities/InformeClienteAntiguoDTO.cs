using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BEME.Entities
{
    public class InformeClienteAntiguoDTO
    {
        private int? idClienteAntiguo;
        private string rutClienteAntiguo;
        private int idUsuario;
        private string nombreUsuario;
        private DateTime? fecPresClienteAntiguo;
        private string nombreClienteAntiguo;
        private string reqClienteAntiguo;
        private string resClienteAntiguo;
        private string nombreUsuarioCnx;
        private DateTime fechaLogCA;
        private string resFinClienteAntiguo;

        

        
        

        
        public int? IdClienteAntiguo
        {
            get { return idClienteAntiguo; }
            set { idClienteAntiguo = value; }
        }

        public string RutClienteAntiguo
        {
            get { return rutClienteAntiguo; }
            set { rutClienteAntiguo = value; }
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

        public DateTime? FecPresClienteAntiguo
        {
            get { return fecPresClienteAntiguo; }
            set { fecPresClienteAntiguo = value; }
        }

        public string NombreClienteAntiguo
        {
            get { return nombreClienteAntiguo; }
            set { nombreClienteAntiguo = value; }
        }

        public string ReqClienteAntiguo
        {
            get { return reqClienteAntiguo; }
            set { reqClienteAntiguo = value; }
        }

        public string ResClienteAntiguo
        {
            get { return resClienteAntiguo; }
            set { resClienteAntiguo = value; }
        }

        public string NombreUsuarioCnx
        {
            get { return nombreUsuarioCnx; }
            set { nombreUsuarioCnx = value; }
        }

        public DateTime FechaLogCA
        {
            get { return fechaLogCA; }
            set { fechaLogCA = value; }
        }

        public string ResFinClienteAntiguo
        {
            get { return resFinClienteAntiguo; }
            set { resFinClienteAntiguo = value; }
        }

    }
}
