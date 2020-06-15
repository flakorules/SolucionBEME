using System;
using System.Collections.Generic;

using System.Text;

namespace BEME.Entities
{
    public class FamiliaProductosDTO
    {
        private int idFamiliaProductos;
        private string descFamiliaProductos;
        private List<ProductosDisponiblesDTO> lstProductosDisponibles;

        public int IdFamiliaProductos
        {
            get { return idFamiliaProductos; }
            set { idFamiliaProductos = value; }
        }
        public string DescFamiliaProductos
        {
            get { return descFamiliaProductos; }
            set { descFamiliaProductos = value; }
        }
        public List<ProductosDisponiblesDTO> LstProductosDisponibles
        {
            get { return lstProductosDisponibles; }
            set { lstProductosDisponibles = value; }
        }
    }
}
