using System;
using System.Collections.Generic;

using System.Text;
using BEME.Entities;
using BEME.Core;
using System.Data.OleDb;

namespace BEME.DA
{
    public class TipoFormalidadDA:DataAccessBase
    {
        public List<TipoFormalidadDTO> GetAll()
        {
            List<TipoFormalidadDTO> toReturn = new List<TipoFormalidadDTO>();
            TipoFormalidadDTO obj;

            try
            {
                this.BEMEConnectionObj.Open();

                OleDbCommand cmd = new OleDbCommand("SELECT IdFormalidad, DescTipoFormalidad FROM TipoFormalidad", this.BEMEConnectionObj);
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    obj = new TipoFormalidadDTO();
                    obj.IdFormalidad = Convert.ToInt32(reader["IdFormalidad"]);
                    obj.DescTipoFormalidad = Convert.ToString(reader["DescTipoFormalidad"]);
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
