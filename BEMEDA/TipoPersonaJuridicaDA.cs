using System;
using System.Collections.Generic;

using System.Text;
using BEME.Entities;
using BEME.Core;
using System.Data.OleDb;

namespace BEME.DA
{
    public class TipoPersonaJuridicaDA : DataAccessBase
    {
        public List<TipoPersonaJuridicaDTO> GetAll()
        {
            List<TipoPersonaJuridicaDTO> toReturn = new List<TipoPersonaJuridicaDTO>();
            TipoPersonaJuridicaDTO obj;

            try
            {
                this.BEMEConnectionObj.Open();

                OleDbCommand cmd = new OleDbCommand("SELECT IdTipoPersonaJuridica, DescTipoPersonaJuridica FROM TipoPersonaJuridica", this.BEMEConnectionObj);
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    obj = new TipoPersonaJuridicaDTO();
                    obj.IdTipoPersonaJuridica = Convert.ToInt32(reader["IdTipoPersonaJuridica"]);
                    obj.DescTipoPersonaJuridica = Convert.ToString(reader["DescTipoPersonaJuridica"]);
                    toReturn.Add(obj);
                }

                reader.Close();
                this.BEMEConnectionObj.Close();
            }
            catch (OleDbException ex)
            {
                toReturn = null;
                throw;
            }

            return toReturn;
        }

        public List<TipoPersonaJuridicaDTO> GetAllByParameters(ResultadoProductosDisponiblesDTO objIn)
        {
            List<TipoPersonaJuridicaDTO> toReturn = new List<TipoPersonaJuridicaDTO>();
            TipoPersonaJuridicaDTO obj;

            try
            {
                this.BEMEConnectionObj.Open();

                OleDbCommand cmd = this.BEMEConnectionObj.CreateCommand();

                cmd.CommandText =
    "SELECT DISTINCT TipoPersonaJuridica.IdTipoPersonaJuridica, " +
    "TipoPersonaJuridica.DescTipoPersonaJuridica " +
    "FROM TipoPersonaJuridica INNER JOIN ResultadoProductosDisponibles " +
    "ON TipoPersonaJuridica.IdTipoPersonaJuridica = ResultadoProductosDisponibles.IdTipoPersonaJuridica " +
    "WHERE (((ResultadoProductosDisponibles.IdTipoEmpresa)=@IdTipoEmpresa))";

                cmd.Parameters.AddRange(new OleDbParameter[]
            {
               new OleDbParameter("@IdTipoEmpresa", objIn.IdTipoEmpresa)
            });

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    obj = new TipoPersonaJuridicaDTO();
                    obj.IdTipoPersonaJuridica = Convert.ToInt32(reader["IdTipoPersonaJuridica"]);
                    obj.DescTipoPersonaJuridica = Convert.ToString(reader["DescTipoPersonaJuridica"]);
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
    }
}
