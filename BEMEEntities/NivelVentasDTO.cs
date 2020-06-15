using System;
using System.Collections.Generic;

using System.Text;

namespace BEME.Entities
{
    public class NivelVentasDTO
    {
        private int idNivelVentas;
        private string descNivelVentas;

        public int IdNivelVentas
        {
            get { return idNivelVentas; }
            set { idNivelVentas = value; }
        }

        public string DescNivelVentas
        {
            get { return descNivelVentas; }
            set { descNivelVentas = value; }
        }
    }
}
