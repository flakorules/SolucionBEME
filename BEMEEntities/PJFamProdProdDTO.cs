using System;
using System.Collections.Generic;

using System.Text;

namespace BEME.Entities
{
    public class PJFamProdProdDTO
    {
        private string rutEmpresa;
        private int idFamiliaProductos;
        private int idProductosDisponibles;

        public string RutEmpresa
        {
            get { return rutEmpresa; }
            set { rutEmpresa = value; }
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
