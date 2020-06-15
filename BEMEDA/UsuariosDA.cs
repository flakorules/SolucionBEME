using System;
using System.Collections.Generic;

using System.Text;

using BEME.Entities;
using BEME.Core;
using System.Data.OleDb;
namespace BEME.DA
{
    public class UsuariosDA : DataAccessBase
    {

        public List<UsuariosDTO> GetAll()
        {
            List<UsuariosDTO> toReturn = new List<UsuariosDTO>();
            UsuariosDTO obj;

            try
            {
                this.BEMEConnectionObj.Open();

                OleDbCommand cmd = new OleDbCommand("SELECT IdUsuario, NombreUsuario FROM Usuarios", this.BEMEConnectionObj);
                
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    obj = new UsuariosDTO();
                    obj.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);
                    obj.NombreUsuario = Convert.ToString(reader["NombreUsuario"]);
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

        public UsuariosDTO GetById(UsuariosDTO objIn)
        {
            UsuariosDTO toReturn;

            try
            {
                this.BEMEConnectionObj.Open();

                OleDbCommand cmd = this.BEMEConnectionObj.CreateCommand();

                cmd.CommandText =
                    "SELECT IdUsuario, " +
                    "NombreUsuario " +
                    "FROM Usuarios " +
                    "WHERE Usuarios.IdUsuario = @IdUsuario";


                cmd.Parameters.AddRange(new OleDbParameter[]
            {
               new OleDbParameter("@IdUsuario", objIn.IdUsuario)
            });

                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    toReturn = new UsuariosDTO();
                    toReturn.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);
                    toReturn.NombreUsuario = Convert.ToString(reader["NombreUsuario"]);
                    
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
