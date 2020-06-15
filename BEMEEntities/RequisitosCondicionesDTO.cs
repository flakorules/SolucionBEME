using System;
using System.Collections.Generic;

using System.Text;

namespace BEME.Entities
{
    public class RequisitosCondicionesDTO
    {
        private int idRequisitosCondiciones;
        private string descRequisitosCondiciones;
        private string rutaRequisitosCondiciones;

        public int IdRequisitosCondiciones
        {
            get { return idRequisitosCondiciones; }
            set { idRequisitosCondiciones = value; }
        }
        

        public string DescRequisitosCondiciones
        {
            get { return descRequisitosCondiciones; }
            set { descRequisitosCondiciones = value; }
        }

        public string RutaRequisitosCondiciones
        {
            get { return rutaRequisitosCondiciones; }
            set { rutaRequisitosCondiciones = value; }
        }
    }
}
