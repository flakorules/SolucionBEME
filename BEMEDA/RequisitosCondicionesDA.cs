using System;
using System.Collections.Generic;

using System.Text;


using BEME.Entities;
using System.Data.OleDb;

namespace BEME.DA
{
    public class RequisitosCondicionesDA : DataAccessBase
    {

        public RequisitosCondicionesDTO GetByParameters(ResulRequisitosCondicionesDTO objIn)
        {
            RequisitosCondicionesDTO toReturn;

            try
            {
                this.BEMEConnectionObj.Open();

                OleDbCommand cmd = this.BEMEConnectionObj.CreateCommand();

                cmd.CommandText =
                    "SELECT RequisitosCondiciones.IdRequisitosCondiciones, " +
                    "RequisitosCondiciones.DescRequisitosCondiciones, " +
                    "RequisitosCondiciones.RutaRequisitosCondiciones " +
                    "FROM RequisitosCondiciones " +
                    "INNER JOIN ResulRequisitosCondiciones " +
                    "ON RequisitosCondiciones.IdRequisitosCondiciones = ResulRequisitosCondiciones.IdRequisitosCondiciones " +
                    "WHERE (((ResulRequisitosCondiciones.IdBancaDerivacion)=@IdBancaDerivacion) " +
                    "AND ((ResulRequisitosCondiciones.IdTipoEmpresa)=@IdTipoEmpresa)) ";



                cmd.Parameters.AddRange(new OleDbParameter[]
            {
               new OleDbParameter("@IdBancaDerivacion", objIn.IdBancaDerivacion),
               new OleDbParameter("@IdBancaDerivacion", objIn.IdTipoEmpresa)
            });

                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    toReturn = new RequisitosCondicionesDTO();

                    toReturn.IdRequisitosCondiciones = Convert.ToInt32(reader["IdRequisitosCondiciones"]);
                    toReturn.DescRequisitosCondiciones = Convert.ToString(reader["DescRequisitosCondiciones"]);
                    toReturn.RutaRequisitosCondiciones = Convert.ToString(reader["RutaRequisitosCondiciones"]);
                }
                else
                {
                    toReturn = null;
                }
                reader.Close();
                this.BEMEConnectionObj.Close();
            }
            catch (OleDbException ex)
            {
                toReturn = null;
                throw ex;
            }

            return toReturn;
        }
    }
}
