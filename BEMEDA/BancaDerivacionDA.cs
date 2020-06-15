using System;
using System.Collections.Generic;

using System.Text;
using BEME.Entities;
using BEME.Core;
using System.Data.OleDb;

namespace BEME.DA
{
    public class BancaDerivacionDA : DataAccessBase
    {

        public List<BancaDerivacionDTO> GetAll()
        {
            List<BancaDerivacionDTO> toReturn = new List<BancaDerivacionDTO>();
            BancaDerivacionDTO obj;

            try
            {
                this.BEMEConnectionObj.Open();

                OleDbCommand cmd = new OleDbCommand("SELECT IdBancaDerivacion, DescBancaDerivacion FROM BancaDerivacion", this.BEMEConnectionObj);
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    obj = new BancaDerivacionDTO();
                    obj.IdBancaDerivacion = Convert.ToInt32(reader["IdBancaDerivacion"]);
                    obj.DescBancaDerivacion = Convert.ToString(reader["DescBancaDerivacion"]);
                    toReturn.Add(obj);
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
                
        public BancaDerivacionDTO GetAllByParameters(ResultadoDerivacionDTO obj) 
        {
            BancaDerivacionDTO toReturn;

            try
            {
                this.BEMEConnectionObj.Open();

                OleDbCommand cmd = this.BEMEConnectionObj.CreateCommand();

                cmd.CommandText = "SELECT BancaDerivacion.IdBancaDerivacion, BancaDerivacion.DescBancaDerivacion " +
    "FROM BancaDerivacion INNER JOIN (TipoFormalidad INNER JOIN (TipoCliente INNER JOIN (NivelVentas INNER JOIN ResultadoDerivacion ON NivelVentas.IdNivelVentas = ResultadoDerivacion.IdNivelVentas) ON TipoCliente.IdTipoCliente = ResultadoDerivacion.IdTipoCliente) ON TipoFormalidad.IdFormalidad = ResultadoDerivacion.IdFormalidad) ON BancaDerivacion.IdBancaDerivacion = ResultadoDerivacion.IdBancaDerivacion " +
    "WHERE (((ResultadoDerivacion.IdTipoCliente)=@IdTipoCliente) AND ((ResultadoDerivacion.IdFormalidad)=@IdFormalidad) AND ((ResultadoDerivacion.IdNivelVentas)=@IdNivelVentas))";
                cmd.Parameters.AddRange(new OleDbParameter[]
            {
               new OleDbParameter("@IdTipoCliente", obj.IdTipoCliente),
               new OleDbParameter("@IdFormalidad", obj.IdFormalidad),
               new OleDbParameter("@IdNivelVentas", obj.IdNivelVentas),
            });

                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    toReturn = new BancaDerivacionDTO();
                    toReturn.IdBancaDerivacion = Convert.ToInt32(reader["IdBancaDerivacion"]);
                    toReturn.DescBancaDerivacion = Convert.ToString(reader["DescBancaDerivacion"]);
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
