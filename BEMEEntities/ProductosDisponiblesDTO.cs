using System;
using System.Collections.Generic;

using System.Text;

namespace BEME.Entities
{
    public class ProductosDisponiblesDTO
    {
        private int idProductosDisponibles;
        private string descProductosDisponibles;
        private int idFamiliaProductos;

        

        public int IdProductosDisponibles
        {
            get { return idProductosDisponibles; }
            set { idProductosDisponibles = value; }
        }

        public string DescProductosDisponibles
        {
            get { return descProductosDisponibles; }
            set { descProductosDisponibles = value; }
        }

        public int IdFamiliaProductos
        {
            get { return idFamiliaProductos; }
            set { idFamiliaProductos = value; }
        }
    }
}
