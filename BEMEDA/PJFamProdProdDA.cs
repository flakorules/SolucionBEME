using System;
using System.Collections.Generic;

using System.Text;
using BEME.Entities;
using System.Data.OleDb;


namespace BEME.DA
{
    public class PJFamProdProdDA: DataAccessBase
    {

        public void Insert(PJFamProdProdDTO objIn)
        {

            try
            {
                this.BEMEConnectionObj.Open();

                OleDbCommand cmd = this.BEMEConnectionObj.CreateCommand();

                cmd.CommandText =
                    "INSERT INTO PJFamProdProd ( " +
                    "RutEmpresa, " +
                    "IdFamiliaProductos, " +
                    "IdProductosDisponibles) " +
                    "VALUES ( " +
                    "@RutEmpresa, " +
                    "@IdFamiliaProductos, " +
                    "@IdProductosDisponibles) ";

                cmd.Parameters.AddRange(new OleDbParameter[]
            {
               new OleDbParameter("@RutEmpresa", objIn.RutEmpresa),
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
