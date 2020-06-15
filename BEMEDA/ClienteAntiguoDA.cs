using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BEME.Entities;
using System.Data.OleDb;

namespace BEME.DA
{
    public class ClienteAntiguoDA : DataAccessBase
    {

        public void Insert(ClienteAntiguoDTO objIn)
        {

            try
            {
                this.BEMEConnectionObj.Open();

                OleDbCommand cmd = this.BEMEConnectionObj.CreateCommand();

                cmd.CommandText =
                    "INSERT INTO ClienteAntiguo " +
                    "(RutClienteAntiguo, " +
                    "IdUsuario, " +
                    "FecPresClienteAntiguo, " +
                    "NombreClienteAntiguo, " +
                    "ReqClienteAntiguo, " +
                    "ResClienteAntiguo)" +
                    "VALUES (@RutClienteAntiguo, " +
                    "@IdUsuario, " +
                    "@FecPresClienteAntiguo, " +
                    "@NombreClienteAntiguo, " +
                    "@ReqClienteAntiguo, " +
                    "@ResClienteAntiguo)";
                    



                cmd.Parameters.AddRange(new OleDbParameter[]
                {
                    new OleDbParameter("@RutClienteAntiguo", objIn.RutClienteAntiguo),  
                    new OleDbParameter("@IdUsuario", objIn.IdUsuario),  
                    new OleDbParameter("@FecPresClienteAntiguo", objIn.FecPresClienteAntiguo),
                    new OleDbParameter("@NombreClienteAntiguo", objIn.NombreClienteAntiguo),
                    new OleDbParameter("@ReqClienteAntiguo", objIn.ReqClienteAntiguo),
                    new OleDbParameter("@ResClienteAntiguo", objIn.ResClienteAntiguo),
                });

                cmd.ExecuteNonQuery();


                this.BEMEConnectionObj.Close();
            }
            catch (OleDbException ex)
            {
                throw ex;
            }

        }

        public void Update(ClienteAntiguoDTO objIn)
        {

            try
            {
                this.BEMEConnectionObj.Open();

                OleDbCommand cmd = this.BEMEConnectionObj.CreateCommand();

                cmd.CommandText =
                    "UPDATE ClienteAntiguo " +
                    "SET IdUsuario = @IdUsuario, " +
                    "FecPresClienteAntiguo = @FecPresClienteAntiguo, " +
                    "NombreClienteAntiguo = @NombreClienteAntiguo, " +
                    "ReqClienteAntiguo = @ReqClienteAntiguo, " +
                    "ResClienteAntiguo = @ResClienteAntiguo " +
                    "WHERE RutClienteAntiguo = @RutClienteAntiguo";

                cmd.Parameters.AddRange(new OleDbParameter[]
                {
                    new OleDbParameter("@IdUsuario", objIn.IdUsuario),  
                    new OleDbParameter("@FecPresClienteAntiguo", objIn.FecPresClienteAntiguo),
                    new OleDbParameter("@NombreClienteAntiguo", objIn.NombreClienteAntiguo),
                    new OleDbParameter("@ReqClienteAntiguo", objIn.ReqClienteAntiguo),
                    new OleDbParameter("@ResClienteAntiguo", objIn.ResClienteAntiguo),
                    new OleDbParameter("@RutClienteAntiguo", objIn.RutClienteAntiguo)
                });

                int cont = cmd.ExecuteNonQuery();


                this.BEMEConnectionObj.Close();
            }
            catch (OleDbException ex)
            {
                throw ex;
            }

        }

        public ClienteAntiguoDTO GetById(ClienteAntiguoDTO objIn)
        {
            ClienteAntiguoDTO toReturn;

            try
            {
                this.BEMEConnectionObj.Open();

                OleDbCommand cmd = this.BEMEConnectionObj.CreateCommand();

                cmd.CommandText =
                    "SELECT ClienteAntiguo.IdClienteAntiguo, " +
                    "ClienteAntiguo.RutClienteAntiguo, " +
                    "ClienteAntiguo.IdUsuario, " +
                    "Usuarios.NombreUsuario, " +
                    "ClienteAntiguo.FecPresClienteAntiguo, " +
                    "ClienteAntiguo.NombreClienteAntiguo, " +
                    "ClienteAntiguo.ReqClienteAntiguo, " +
                    "ClienteAntiguo.ResClienteAntiguo " +
                    "FROM Usuarios " +
                    "INNER JOIN ClienteAntiguo " +
                    "ON Usuarios.IdUsuario = ClienteAntiguo.IdUsuario " +
                    "WHERE (((ClienteAntiguo.IdClienteAntiguo) = @IdClienteAntiguo))";



                cmd.Parameters.AddRange(new OleDbParameter[]
                {
                    new OleDbParameter("@IdClienteAntiguo", objIn.IdClienteAntiguo)
                });

                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    toReturn = new ClienteAntiguoDTO();
                    toReturn.IdClienteAntiguo = Convert.ToInt32(reader["IdClienteAntiguo"]);
                    toReturn.RutClienteAntiguo = Convert.ToString(reader["RutClienteAntiguo"]);
                    toReturn.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);
                    toReturn.NombreUsuario = Convert.ToString(reader["NombreUsuario"]);
                    toReturn.FecPresClienteAntiguo = Convert.ToDateTime(reader["FecPresClienteAntiguo"]);
                    toReturn.NombreClienteAntiguo = Convert.ToString(reader["NombreClienteAntiguo"]);
                    toReturn.ReqClienteAntiguo = Convert.ToString(reader["ReqClienteAntiguo"]);
                    toReturn.ResClienteAntiguo = Convert.ToString(reader["ResClienteAntiguo"]);
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

        public int? GetMaxId()
        {
            int? toReturn;

            try
            {
                this.BEMEConnectionObj.Open();

                OleDbCommand cmd = this.BEMEConnectionObj.CreateCommand();

                cmd.CommandText =
                    "SELECT Max(ClienteAntiguo.IdClienteAntiguo) AS IdClienteAntiguo " +
                    "FROM ClienteAntiguo";


                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    toReturn = Convert.ToInt32(reader["IdClienteAntiguo"]);
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

        public List<ClienteAntiguoDTO> GetByRut(ClienteAntiguoDTO objIn)
        {
            List<ClienteAntiguoDTO> toReturn;
            ClienteAntiguoDTO obj;

            try
            {
                this.BEMEConnectionObj.Open();

                string query =
                    "SELECT ClienteAntiguo.IdClienteAntiguo, " +
                    "ClienteAntiguo.IdUsuario, " +
                    "ClienteAntiguo.RutClienteAntiguo, " +
                    "Usuarios.NombreUsuario, " +
                    "ClienteAntiguo.FecPresClienteAntiguo, " +
                    "ClienteAntiguo.NombreClienteAntiguo, " +
                    "ClienteAntiguo.ReqClienteAntiguo, " +
                    "ClienteAntiguo.ResClienteAntiguo " +
                    "FROM Usuarios " +
                    "INNER JOIN ClienteAntiguo " +
                    "ON Usuarios.IdUsuario = ClienteAntiguo.IdUsuario " +
                    "WHERE (((ClienteAntiguo.RutClienteAntiguo) = @RutClienteAntiguo))";



                OleDbCommand cmd = new OleDbCommand(query, this.BEMEConnectionObj);


                cmd.Parameters.AddRange(new OleDbParameter[]
                {
                    new OleDbParameter("@RutClienteAntiguo", objIn.RutClienteAntiguo)
                });
                
                OleDbDataReader reader = cmd.ExecuteReader();

                toReturn = new List<ClienteAntiguoDTO>();

                while (reader.Read())
                {
                    obj = new ClienteAntiguoDTO();

                    obj.IdClienteAntiguo = Convert.ToInt32(reader["IdClienteAntiguo"]);
                    obj.RutClienteAntiguo = Convert.ToString(reader["RutClienteAntiguo"]);
                    obj.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);
                    obj.NombreUsuario = Convert.ToString(reader["NombreUsuario"]);
                    obj.FecPresClienteAntiguo = Convert.ToDateTime(reader["FecPresClienteAntiguo"]);
                    obj.NombreClienteAntiguo = Convert.ToString(reader["NombreClienteAntiguo"]);
                    obj.ReqClienteAntiguo = Convert.ToString(reader["ReqClienteAntiguo"]);
                    obj.ResClienteAntiguo = Convert.ToString(reader["ResClienteAntiguo"]);

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

        public List<InformeClienteAntiguoDTO> GetAll()
        {
            List<InformeClienteAntiguoDTO> toReturn;
            InformeClienteAntiguoDTO obj;

            try
            {
                this.BEMEConnectionObj.Open();

                string query =
                    "SELECT ClienteAntiguo.IdClienteAntiguo, " +
                    "ClienteAntiguo.RutClienteAntiguo, " +
                    "ClienteAntiguo.IdUsuario, " +
                    "Usuarios.NombreUsuario, " +
                    "ClienteAntiguo.FecPresClienteAntiguo, " +
                    "ClienteAntiguo.NombreClienteAntiguo, " +
                    "ClienteAntiguo.ReqClienteAntiguo, " +
                    "ClienteAntiguo.ResClienteAntiguo, " +
                    "UsrCnx.NombreUsuario AS NombreUsuarioCnx, " +
                    "LogCA.FechaLogCA, " +
                    "LogCA.ResFinClienteAntiguo " +
                    "FROM Usuarios AS UsrCnx " +
                    "INNER JOIN ((Usuarios " +
                    "INNER JOIN ClienteAntiguo " +
                    "ON Usuarios.IdUsuario = ClienteAntiguo.IdUsuario) " +
                    "INNER JOIN LogCA " +
                    "ON ClienteAntiguo.IdClienteAntiguo = LogCA.IdClienteAntiguo) " +
                    "ON UsrCnx.IdUsuario = LogCA.IdUsuario " +
                    "ORDER BY ClienteAntiguo.IdClienteAntiguo, LogCA.FechaLogCA";


                


                OleDbCommand cmd = new OleDbCommand(query, this.BEMEConnectionObj);
                OleDbDataReader reader = cmd.ExecuteReader();

                toReturn = new List<InformeClienteAntiguoDTO>();

                while (reader.Read())
                {
                    obj = new InformeClienteAntiguoDTO();
                    obj.IdClienteAntiguo = Convert.ToInt32(reader["IdClienteAntiguo"]);
                    obj.RutClienteAntiguo = Convert.ToString(reader["RutClienteAntiguo"]);
                    obj.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);
                    obj.NombreUsuario = Convert.ToString(reader["NombreUsuario"]);
                    obj.FecPresClienteAntiguo = Convert.ToDateTime(reader["FecPresClienteAntiguo"]);
                    obj.NombreClienteAntiguo = Convert.ToString(reader["NombreClienteAntiguo"]);
                    obj.ReqClienteAntiguo = Convert.ToString(reader["ReqClienteAntiguo"]);
                    obj.ResClienteAntiguo = Convert.ToString(reader["ResClienteAntiguo"]);
                    obj.NombreUsuarioCnx = Convert.ToString(reader["NombreUsuarioCnx"]);
                    obj.FechaLogCA = Convert.ToDateTime(reader["FechaLogCA"]);
                    obj.ResFinClienteAntiguo = Convert.ToString(reader["ResFinClienteAntiguo"]);

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
