using System;
using System.Collections.Generic;

using System.Text;

using BEME.Entities;
using BEME.Core;
using System.Data.OleDb;

namespace BEME.DA
{
    public class TipoEmpresaDA : DataAccessBase
    {
        public List<TipoEmpresaDTO> GetAll()
        {
            List<TipoEmpresaDTO> toReturn = new List<TipoEmpresaDTO>();
            TipoEmpresaDTO obj;

            try
            {
                this.BEMEConnectionObj.Open();

                OleDbCommand cmd = new OleDbCommand("SELECT IdTipoEmpresa,DescTipoEmpresa FROM TipoEmpresa", this.BEMEConnectionObj);
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    obj = new TipoEmpresaDTO();
                    obj.IdTipoEmpresa = Convert.ToInt32(reader["IdTipoEmpresa"]);
                    obj.DescTipoEmpresa = Convert.ToString(reader["DescTipoEmpresa"]);
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
