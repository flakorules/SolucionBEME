using System;
using System.Collections.Generic;

using System.Text;

namespace BEME.Entities
{
    public class PermanenciaRubroDTO
    {
        private int idPermanenciaRubro;
        private string descPermanenciaRubro;

        public int IdPermanenciaRubro
        {
            get { return idPermanenciaRubro; }
            set { idPermanenciaRubro = value; }
        }

        public string DescPermanenciaRubro
        {
            get { return descPermanenciaRubro; }
            set { descPermanenciaRubro = value; }
        }
    }
}
