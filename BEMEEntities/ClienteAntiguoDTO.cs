using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BEME.Entities
{
    public class ClienteAntiguoDTO
    {
        private int? idClienteAntiguo;
        private string rutClienteAntiguo;
        private int idUsuario;
        private string nombreUsuario;
        private DateTime? fecPresClienteAntiguo;
        private string nombreClienteAntiguo;
        private string reqClienteAntiguo;
        private string resClienteAntiguo;
        private List<LogClienteAntiguoDTO> lstLogClienteAntiguo;

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

        public List<LogClienteAntiguoDTO> LstLogClienteAntiguo
        {
            get { return lstLogClienteAntiguo; }
            set { lstLogClienteAntiguo = value; }
        }
        
    }
}
