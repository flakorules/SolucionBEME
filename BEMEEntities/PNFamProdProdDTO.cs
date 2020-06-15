using System;
using System.Collections.Generic;

using System.Text;

namespace BEME.Entities
{
    public class PNFamProdProdDTO
    {
        private string rutPersonaNatural;
        private int idFamiliaProductos;
        private int idProductosDisponibles;

        public string RutPersonaNatural
        {
            get { return rutPersonaNatural; }
            set { rutPersonaNatural = value; }
        }

        public int IdFamiliaProductos
        {
            get { return idFamiliaProductos; }
            set { idFamiliaProductos = value; }
        }

        public int IdProductosDisponibles
        {
            get { return idProductosDisponibles; }
            set { idProductosDisponibles = value; }
        }
    }
}
