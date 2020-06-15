using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BEME.Entities;
using System.Data.OleDb;

namespace BEME.DA
{
    public class LogPersonaJuridicaDA : DataAccessBase
    {
        public void Insert(LogPersonaJuridicaDTO objIn)
        {

            try
            {
                this.BEMEConnectionObj.Open();

                OleDbCommand cmd = this.BEMEConnectionObj.CreateCommand();

                cmd.CommandText =
                            "INSERT INTO LogPJ(RutEmpresa, " +
                            "IdUsuario, " +
                            "FechaLogPJ, " +
                            "TextoLogPJ) " +
                            "VALUES (@RutEmpresa, " +
                            "@IdUsuario, " +
                            //"@FechaLogPJ, " +
                            "Now(), " +
                            "@TextoLogPJ)";



                cmd.Parameters.AddRange(new OleDbParameter[]
                {
                    new OleDbParameter("@RutEmpresa", objIn.RutEmpresa),  
                    new OleDbParameter("@IdUsuario", objIn.IdUsuario),
                    //new OleDbParameter("@FechaLogPJ",OleDbType.datet, objIn.Fecha),
                    new OleDbParameter("@TextoLogPJ", objIn.Texto)
                });

                cmd.ExecuteNonQuery();


                this.BEMEConnectionObj.Close();
            }
            catch (OleDbException ex)
            {
                throw ex;
            }

        }

        public List<LogPersonaJuridicaDTO> GetAllByParameters(LogPersonaJuridicaDTO objIN)
        {
            List<LogPersonaJuridicaDTO> toReturn = new List<LogPersonaJuridicaDTO>();

            LogPersonaJuridicaDTO obj;

            try
            {
                this.BEMEConnectionObj.Open();

                OleDbCommand cmd = this.BEMEConnectionObj.CreateCommand();

                cmd.CommandText =
                        "SELECT LogPJ.IdLogPJ, " +
                        "LogPJ.RutEmpresa, " +
                        "PersonaJuridica.NombreEmpresa, " +
                        "LogPJ.IdUsuario, " +
                        "Usuarios.NombreUsuario, " +
                        "LogPJ.FechaLogPJ, " +
                        "LogPJ.TextoLogPJ " +
                        "FROM Usuarios " +
                        "INNER JOIN (PersonaJuridica " +
                        "INNER JOIN LogPJ " +
                        "ON PersonaJuridica.RutEmpresa = LogPJ.RutEmpresa) " +
                        "ON Usuarios.IdUsuario = LogPJ.IdUsuario " +
                        "WHERE (((LogPJ.RutEmpresa)=@RutEmpresa)) " +
                        "ORDER BY LogPJ.FechaLogPJ";


                cmd.Parameters.AddRange(new OleDbParameter[]
                {
                    new OleDbParameter("@RutEmpresa", objIN.RutEmpresa)
                });

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    obj = new LogPersonaJuridicaDTO();

                    obj.IdLog = Convert.ToInt32(reader["IdLogPJ"]);
                    obj.RutEmpresa = Convert.ToString(reader["RutEmpresa"]);
                    obj.NombreEmpresa = Convert.ToString(reader["NombreEmpresa"]);
                    obj.Fecha = Convert.ToDateTime(reader["FechaLogPJ"]);
                    obj.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);
                    obj.NombreUsuario = Convert.ToString(reader["NombreUsuario"]);
                    obj.Texto = Convert.ToString(reader["TextoLogPJ"]);
                    
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
