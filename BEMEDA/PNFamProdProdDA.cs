using System;
using System.Collections.Generic;

using System.Text;
using BEME.Entities;
using System.Data.OleDb;

namespace BEME.DA
{
    public class PNFamProdProdDA:DataAccessBase
    {
        public void Insert(PNFamProdProdDTO objIn)
        {
            try
            {
                this.BEMEConnectionObj.Open();

                OleDbCommand cmd = this.BEMEConnectionObj.CreateCommand();

                cmd.CommandText =
                    "INSERT INTO PNFamProdProd ( " +
                    "RutPersonaNatural, " +
                    "IdFamiliaProductos, " +
                    "IdProductosDisponibles) " +
                    "VALUES ( " +
                    "@RutPersonaNatural, " +
                    "@IdFamiliaProductos, " +
                    "@IdProductosDisponibles) ";

                cmd.Parameters.AddRange(new OleDbParameter[]
            {
               new OleDbParameter("@RutPersonaNatural", objIn.RutPersonaNatural),
               new OleDbParameter("@IdFamiliaProductos", objIn.IdFamiliaProductos),
               new OleDbParameter("@IdProductosDisponibles", objIn.IdProductosDisponibles)
            });

                cmd.ExecuteNonQuery();
                this.BEMEConnectionObj.Close();
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
        }
    }
}
