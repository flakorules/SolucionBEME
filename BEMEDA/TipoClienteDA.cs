using System;
using System.Collections.Generic;

using System.Text;
using System.Data.OleDb;
using BEME.Entities;
using BEME.Core;

namespace BEME.DA
{
    public class TipoClienteDA : DataAccessBase
    {
        public List<TipoClienteDTO> GetAll()
        {
            List<TipoClienteDTO> toReturn;
            TipoClienteDTO obj;

            try
            {
                this.BEMEConnectionObj.Open();

                OleDbCommand cmd = new OleDbCommand("SELECT IdTipoCliente, DescTipoCliente FROM TipoCliente", this.BEMEConnectionObj);
                OleDbDataReader reader = cmd.ExecuteReader();

                toReturn = new List<TipoClienteDTO>();

                while (reader.Read())
                {
                    obj = new TipoClienteDTO();
                    obj.IdTipoCliente = Convert.ToInt32(reader["IdTipoCliente"]);
                    obj.DescTipoCliente = Convert.ToString(reader["DescTipoCliente"]);
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
            finally 
            {
                
            }

            return toReturn;
        }
    }
}
