using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using BEME.Entities;
using System.Data.OleDb;

namespace BEME.DA
{
    public class LogClienteAntiguoDA : DataAccessBase
    {


        public void Insert(LogClienteAntiguoDTO objIn)
        {

            try
            {
                this.BEMEConnectionObj.Open();

                OleDbCommand cmd = this.BEMEConnectionObj.CreateCommand();

                cmd.CommandText =
                    "INSERT INTO LogCA( " +
                    "IdClienteAntiguo, " +
                    "IdUsuario, " +
                    "FechaLogCA, " +
                    "FecAtenClienteAntiguo, " +
                    "ResFinClienteAntiguo) " +
                    "VALUES(@IdClienteAntiguo, " +
                    "@IdUsuario, " +
                    "Now(), " +
                    "@FecAtenClienteAntiguo, " +
                    "@ResFinClienteAntiguo)";



                cmd.Parameters.AddRange(new OleDbParameter[]
                {
                    new OleDbParameter("@IdClienteAntiguo", objIn.IdClienteAntiguo),  
                    new OleDbParameter("@IdUsuario", objIn.IdUsuario),
                    new OleDbParameter("@FecAtenClienteAntiguo", objIn.FecAtenClienteAntiguo),
                    new OleDbParameter("@ResFinClienteAntiguo", objIn.ResFinClienteAntiguo)
                });

                cmd.ExecuteNonQuery();


                this.BEMEConnectionObj.Close();
            }
            catch (OleDbException ex)
            {
                throw ex;
            }

        }

        public List<LogClienteAntiguoDTO> GetAllByParameters(LogClienteAntiguoDTO objIN)
        {
            List<LogClienteAntiguoDTO> toReturn = new List<LogClienteAntiguoDTO>();

            LogClienteAntiguoDTO obj;

            try
            {
                this.BEMEConnectionObj.Open();

                OleDbCommand cmd = this.BEMEConnectionObj.CreateCommand();

                cmd.CommandText =
                    "SELECT LogCA.IdLogCA, " +
                    "LogCA.IdClienteAntiguo, " +
                    "ClienteAntiguo.NombreClienteAntiguo, " +
                    "LogCA.IdUsuario, " +
                    "Usuarios.NombreUsuario, " +
                    "LogCA.FechaLogCA, " +
                    "LogCA.FecAtenClienteAntiguo, " +
                    "LogCA.ResFinClienteAntiguo " +
                    "FROM ClienteAntiguo " +
                    "INNER JOIN (Usuarios " +
                    "INNER JOIN LogCA " +
                    "ON Usuarios.IdUsuario = LogCA.IdUsuario) " +
                    "ON ClienteAntiguo.IdClienteAntiguo = LogCA.IdClienteAntiguo " +
                    "WHERE (((LogCA.IdClienteAntiguo)=@IdClienteAntiguo)) " +
                    "ORDER BY LogCA.FechaLogCA"; 

                cmd.Parameters.AddRange(new OleDbParameter[]
                {
                    new OleDbParameter("@IdClienteAntiguo", objIN.IdClienteAntiguo)
                });

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    obj = new LogClienteAntiguoDTO();

                    obj.IdLogCA = Convert.ToInt32(reader["IdLogCA"]);
                    obj.IdClienteAntiguo= Convert.ToInt32(reader["IdClienteAntiguo"]);
                    obj.NombreClienteAntiguo = Convert.ToString(reader["NombreClienteAntiguo"]);
                    obj.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);
                    obj.NombreUsuario = Convert.ToString(reader["NombreUsuario"]);
                    obj.FechaLogCA = Convert.ToDateTime(reader["FechaLogCA"]);
                    obj.FecAtenClienteAntiguo = Convert.ToDateTime(reader["FecAtenClienteAntiguo"]);
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

            return toReturn;
        }
    }
}
