using System;
using System.Collections.Generic;

using System.Text;
using BEME.Entities;
using BEME.Core;
using System.Data.OleDb;

namespace BEME.DA
{
    public class PermanenciaRubroDA : DataAccessBase
    {
        public List<PermanenciaRubroDTO> GetAll()
        {
            List<PermanenciaRubroDTO> toReturn = new List<PermanenciaRubroDTO>();
            PermanenciaRubroDTO obj;

            try
            {
                this.BEMEConnectionObj.Open();

                OleDbCommand cmd = new OleDbCommand("SELECT IdPermanenciaRubro,DescPermanenciaRubro FROM PermanenciaRubro", this.BEMEConnectionObj);
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    obj = new PermanenciaRubroDTO();
                    obj.IdPermanenciaRubro = Convert.ToInt32(reader["IdPermanenciaRubro"]);
                    obj.DescPermanenciaRubro = Convert.ToString(reader["DescPermanenciaRubro"]);
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
