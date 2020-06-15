using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BEME.Entities;
using System.Data.OleDb;

namespace BEME.DA
{
    public class LogPersonaNaturalDA : DataAccessBase
    {
        public void Insert(LogPersonaNaturalDTO objIn)
        {

            try
            {
                this.BEMEConnectionObj.Open();

                OleDbCommand cmd = this.BEMEConnectionObj.CreateCommand();

                cmd.CommandText =
                            "INSERT INTO LogPN( " +
                            "RutPersonaNatural, " +
                            "IdUsuario, " +
                            "FechaLogPN, " +
                            "TextoLogPN) " +
                            "VALUES( " +
                            "@RutPersonaNatural, " +
                            "@IdUsuario, " +
                            //"@FechaLogPN, " +
                            "Now(), " +
                            "@TextoLogPN)";



                cmd.Parameters.AddRange(new OleDbParameter[]
                {
                    new OleDbParameter("@RutPersonaNatural", objIn.RutPersonaNatural),  
                    new OleDbParameter("@IdUsuario", objIn.IdUsuario),
                    //new OleDbParameter("@FechaLogPN", objIn.Fecha),
                    new OleDbParameter("@TextoLogPN", objIn.Texto)
                });

                cmd.ExecuteNonQuery();


                this.BEMEConnectionObj.Close();
            }
            catch (OleDbException ex)
            {
                throw ex;
            }

        }

        public List<LogPersonaNaturalDTO> GetAllByParameters(LogPersonaNaturalDTO objIN)
        {
            List<LogPersonaNaturalDTO> toReturn = new List<LogPersonaNaturalDTO>();

            LogPersonaNaturalDTO obj;

            try
            {
                this.BEMEConnectionObj.Open();

                OleDbCommand cmd = this.BEMEConnectionObj.CreateCommand();

                cmd.CommandText =
                    "SELECT LogPN.IdLogPN, " +
                    "LogPN.RutPersonaNatural, " +
                    "PersonaNatural.NombrePersonaNatural, " +
                    "LogPN.IdUsuario, " +
                    "Usuarios.NombreUsuario, " +
                    "LogPN.FechaLogPN, " +
                    "LogPN.TextoLogPN " +
                    "FROM Usuarios " +
                    "INNER JOIN (PersonaNatural " +
                    "INNER JOIN LogPN " +
                    "ON PersonaNatural.RutPersonaNatural = LogPN.RutPersonaNatural) " +
                    "ON Usuarios.IdUsuario = LogPN.IdUsuario " +
                    "WHERE (((LogPN.RutPersonaNatural)=@RutPersonaNatural)) " +
                    "ORDER BY LogPN.FechaLogPN";

                cmd.Parameters.AddRange(new OleDbParameter[]
                {
                    new OleDbParameter("@RutPersonaNatural", objIN.RutPersonaNatural)
                });

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    obj = new LogPersonaNaturalDTO();

                    obj.IdLog = Convert.ToInt32(reader["IdLogPN"]);
                    obj.RutPersonaNatural = Convert.ToString(reader["RutPersonaNatural"]);
                    obj.NombrePersonaNatural = Convert.ToString(reader["NombrePersonaNatural"]);
                    obj.Fecha = Convert.ToDateTime(reader["FechaLogPN"]);
                    obj.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);
                    obj.NombreUsuario = Convert.ToString(reader["NombreUsuario"]);
                    obj.Texto = Convert.ToString(reader["TextoLogPN"]);

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
