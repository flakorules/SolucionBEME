using System;
using System.Collections.Generic;

using System.Text;
using BEME.Entities;
using BEME.Core;
using System.Data.OleDb;

namespace BEME.DA
{
    public class NivelVentasDA : DataAccessBase
    {
        public List<NivelVentasDTO> GetAll()
        {
            List<NivelVentasDTO> toReturn = new List<NivelVentasDTO>();
            NivelVentasDTO obj;

            try
            {
                this.BEMEConnectionObj.Open();

                OleDbCommand cmd = new OleDbCommand("SELECT IdNivelVentas, DescNivelVentas FROM NivelVentas", this.BEMEConnectionObj);
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    obj = new NivelVentasDTO();
                    obj.IdNivelVentas = Convert.ToInt32(reader["IdNivelVentas"]);
                    obj.DescNivelVentas = Convert.ToString(reader["DescNivelVentas"]);
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
