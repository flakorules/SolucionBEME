using System;
using System.Collections.Generic;

using System.Text;
using BEME.Entities;
using System.Data.OleDb;

namespace BEME.DA
{
    public class PersonaNaturalDA : DataAccessBase
    {
        public void Insert(PersonaNaturalDTO objIn)
        {

            try
            {
                this.BEMEConnectionObj.Open();

                OleDbCommand cmd = this.BEMEConnectionObj.CreateCommand();

                cmd.CommandText =
                    "INSERT INTO PersonaNatural " +
                    "(RutPersonaNatural, " +
                    "IdUsuario, " +
                    "IdFormalidad, " +
                    "IdNivelVentas, " +
                    "IdTipoEmpresa, " +
                    "IdPermanenciaRubro, " +
                    "NombrePersonaNatural, " +
                    "TelefonoPersonaNatural, " +
                    "CorreoPersonaNatural, " +
                    "NomEmpresaPersonaNatural, " +
                    "RutEmpresaPersonaNatural, " +
                    "GiroComercialEmpresaPersonaNatural, " +
                    "ObservacionesPersonaNatural) " +
                    "VALUES " +
                    "(@RutPersonaNatural, " +
                    "@IdUsuario, " + 
                    "@IdFormalidad, " + 
                    "@IdNivelVentas, " +
                    "@IdTipoEmpresa, " +
                    "@IdPermanenciaRubro, " +
                    "@NombrePersonaNatural, " +
                    "@TelefonoPersonaNatural, " +
                    "@CorreoPersonaNatural, " +
                    "@NomEmpresaPersonaNatural, " +
                    "@RutEmpresaPersonaNatural, " +
                    "@GiroComercialEmpresaPersonaNatural, " +
                    "@ObservacionesPersonaNatural)";

                cmd.Parameters.AddRange(new OleDbParameter[]
                {
                       new OleDbParameter("@RutPersonaNatural", objIn.RutPersonaNatural),
                       new OleDbParameter("@IdUsuario", objIn.IdUsuario),
                       new OleDbParameter("@IdFormalidad", objIn.IdFormalidad),
                       new OleDbParameter("@IdNivelVentas", objIn.IdNivelVentas),
                       new OleDbParameter("@IdTipoEmpresa", objIn.IdTipoEmpresa),
                       new OleDbParameter("@IdPermanenciaRubro", objIn.IdPermanenciaRubro),
                       new OleDbParameter("@NombrePersonaNatural", objIn.NombrePersonaNatural),
                       new OleDbParameter("@TelefonoPersonaNatural", objIn.TelefonoPersonaNatural),
                       new OleDbParameter("@CorreoPersonaNatural", objIn.CorreoPersonaNatural),
                       new OleDbParameter("@NomEmpresaPersonaNatural", objIn.NomEmpresaPersonaNatural),
                       new OleDbParameter("@RutEmpresaPersonaNatural", objIn.RutEmpresaPersonaNatural),
                       new OleDbParameter("@GiroComercialEmpresaPersonaNatural", objIn.GiroComercialEmpresaPersonaNatural),
                       new OleDbParameter("@ObservacionesPersonaNatural", objIn.ObservacionesPersonaNatural)
                });
                cmd.ExecuteNonQuery();
                this.BEMEConnectionObj.Close();
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
        }

        public void Update(PersonaNaturalDTO objIn)
        {

            try
            {
                this.BEMEConnectionObj.Open();

                OleDbCommand cmd = this.BEMEConnectionObj.CreateCommand();

                cmd.CommandText = 
                    "UPDATE PersonaNatural " +
                    "SET IdUsuario = @IdUsuario, " +  
                    "IdFormalidad = @IdFormalidad, " +  
                    "IdNivelVentas = @IdNivelVentas, " +  
                    "IdTipoEmpresa = @IdTipoEmpresa, " +  
                    "IdPermanenciaRubro = @IdPermanenciaRubro, " +  
                    "NombrePersonaNatural = @NombrePersonaNatural, " +  
                    "TelefonoPersonaNatural = @TelefonoPersonaNatural, " +  
                    "CorreoPersonaNatural = @CorreoPersonaNatural, " +  
                    "NomEmpresaPersonaNatural = @NomEmpresaPersonaNatural, " +  
                    "RutEmpresaPersonaNatural = @RutEmpresaPersonaNatural, " +  
                    "GiroComercialEmpresaPersonaNatural = @GiroComercialEmpresaPersonaNatural, " +  
                    "ObservacionesPersonaNatural = @ObservacionesPersonaNatural " + 
                    "WHERE RutPersonaNatural = @RutPersonaNatural";


                cmd.Parameters.AddRange(new OleDbParameter[]
                {
                    new OleDbParameter("@IdUsuario", objIn.IdUsuario),
                    new OleDbParameter("@IdFormalidad", objIn.IdFormalidad),
                    new OleDbParameter("@IdNivelVentas", objIn.IdNivelVentas),
                    new OleDbParameter("@IdTipoEmpresa", objIn.IdTipoEmpresa),
                    new OleDbParameter("@IdPermanenciaRubro", objIn.IdPermanenciaRubro),
                    new OleDbParameter("@NombrePersonaNatural", objIn.NombrePersonaNatural),
                    new OleDbParameter("@TelefonoPersonaNatural", objIn.TelefonoPersonaNatural),
                    new OleDbParameter("@CorreoPersonaNatural", objIn.CorreoPersonaNatural),
                    new OleDbParameter("@NomEmpresaPersonaNatural", objIn.NomEmpresaPersonaNatural),
                    new OleDbParameter("@RutEmpresaPersonaNatural", objIn.RutEmpresaPersonaNatural),
                    new OleDbParameter("@GiroComercialEmpresaPersonaNatural", objIn.GiroComercialEmpresaPersonaNatural),
                    new OleDbParameter("@ObservacionesPersonaNatural", objIn.ObservacionesPersonaNatural),
                    new OleDbParameter("@RutPersonaNatural", objIn.RutPersonaNatural)
                });
                cmd.ExecuteNonQuery();
                this.BEMEConnectionObj.Close();
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
        }

        public PersonaNaturalDTO GetById(PersonaNaturalDTO objIn) 
        {
            PersonaNaturalDTO toReturn;

            try
            {
                this.BEMEConnectionObj.Open();

                OleDbCommand cmd = this.BEMEConnectionObj.CreateCommand();

                cmd.CommandText =
                    "SELECT RutPersonaNatural, " +
                    "IdUsuario, " +
                    "IdFormalidad, " +
                    "IdNivelVentas, " + 
                    "IdTipoEmpresa, " + 
                    "IdPermanenciaRubro, " + 
                    "NombrePersonaNatural, " + 
                    "TelefonoPersonaNatural, " + 
                    "CorreoPersonaNatural, " + 
                    "NomEmpresaPersonaNatural, " + 
                    "RutEmpresaPersonaNatural, " + 
                    "GiroComercialEmpresaPersonaNatural, " + 
                    "ObservacionesPersonaNatural " +
                    "FROM PersonaNatural " +
                    "WHERE RutPersonaNatural=@RutPersonaNatural";

                cmd.Parameters.AddRange(new OleDbParameter[]
            {
               new OleDbParameter("@RutPersonaNatural", objIn.RutPersonaNatural)
            });

                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    toReturn = new PersonaNaturalDTO();

                    toReturn.RutPersonaNatural = Convert.ToString(reader["RutPersonaNatural"]);
                    toReturn.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);
                    toReturn.IdFormalidad = Convert.ToInt32(reader["IdFormalidad"]);
                    toReturn.IdNivelVentas = Convert.ToInt32(reader["IdNivelVentas"]);
                    toReturn.IdTipoEmpresa = Convert.ToInt32(reader["IdTipoEmpresa"]);
                    toReturn.IdPermanenciaRubro = Convert.ToInt32(reader["IdPermanenciaRubro"]);
                    toReturn.NombrePersonaNatural = Convert.ToString(reader["NombrePersonaNatural"]);
                    toReturn.TelefonoPersonaNatural = Convert.ToString(reader["TelefonoPersonaNatural"]);
                    toReturn.CorreoPersonaNatural = Convert.ToString(reader["CorreoPersonaNatural"]);
                    toReturn.NomEmpresaPersonaNatural = Convert.ToString(reader["NomEmpresaPersonaNatural"]);
                    toReturn.RutEmpresaPersonaNatural = Convert.ToString(reader["RutEmpresaPersonaNatural"]);
                    toReturn.GiroComercialEmpresaPersonaNatural = Convert.ToString(reader["GiroComercialEmpresaPersonaNatural"]);
                    toReturn.ObservacionesPersonaNatural = Convert.ToString(reader["ObservacionesPersonaNatural"]);

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

        public List<InformePersonaNaturalDTO> GetAll() 
        {
            List<InformePersonaNaturalDTO> toReturn;
            InformePersonaNaturalDTO obj;

            try
            {
                this.BEMEConnectionObj.Open();

                //string query = "SELECT PersonaNatural.RutPersonaNatural, " +
                //                "PersonaNatural.IdUsuario, " +
                //                "Usuarios.NombreUsuario, " +
                //                "PersonaNatural.IdFormalidad, " +
                //                "TipoFormalidad.DescTipoFormalidad, " +
                //                "PersonaNatural.IdNivelVentas, " +
                //                "NivelVentas.DescNivelVentas, " +
                //                "PersonaNatural.IdTipoEmpresa, " +
                //                "TipoEmpresa.DescTipoEmpresa, " +
                //                "PersonaNatural.IdPermanenciaRubro, " +
                //                "PermanenciaRubro.DescPermanenciaRubro, " +
                //                "PersonaNatural.NombrePersonaNatural, " +
                //                "PersonaNatural.TelefonoPersonaNatural, " +
                //                "PersonaNatural.CorreoPersonaNatural, " +
                //                "PersonaNatural.NomEmpresaPersonaNatural, " +
                //                "PersonaNatural.RutEmpresaPersonaNatural, " +
                //                "PersonaNatural.GiroComercialEmpresaPersonaNatural, " +
                //                "PersonaNatural.ObservacionesPersonaNatural " +
                //                "FROM ((((Usuarios " +
                //                "INNER JOIN PersonaNatural " +
                //                "ON Usuarios.IdUsuario = PersonaNatural.IdUsuario) " +
                //                "INNER JOIN TipoFormalidad " +
                //                "ON PersonaNatural.IdFormalidad = TipoFormalidad.IdFormalidad) " +
                //                "INNER JOIN NivelVentas " +
                //                "ON PersonaNatural.IdNivelVentas = NivelVentas.IdNivelVentas) " +
                //                "INNER JOIN TipoEmpresa " +
                //                "ON PersonaNatural.IdTipoEmpresa = TipoEmpresa.IdTipoEmpresa) " +
                //                "INNER JOIN PermanenciaRubro " +
                //                "ON PersonaNatural.IdPermanenciaRubro = PermanenciaRubro.IdPermanenciaRubro";


                string query = "SELECT PersonaNatural.RutPersonaNatural, " +
                    "PersonaNatural.IdUsuario, " +
                    "Usuarios.NombreUsuario, " +
                    "PersonaNatural.IdFormalidad, " +
                    "TipoFormalidad.DescTipoFormalidad, " +
                    "PersonaNatural.IdNivelVentas, " +
                    "NivelVentas.DescNivelVentas, " +
                    "PersonaNatural.IdTipoEmpresa, " +
                    "TipoEmpresa.DescTipoEmpresa, " +
                    "PersonaNatural.IdPermanenciaRubro, " +
                    "PermanenciaRubro.DescPermanenciaRubro," +
                    "PersonaNatural.NombrePersonaNatural, " +
                    "PersonaNatural.TelefonoPersonaNatural, " +
                    "PersonaNatural.CorreoPersonaNatural, " +
                    "PersonaNatural.NomEmpresaPersonaNatural, " +
                    "PersonaNatural.RutEmpresaPersonaNatural, " +
                    "PersonaNatural.GiroComercialEmpresaPersonaNatural, " +
                    "PersonaNatural.ObservacionesPersonaNatural, " +
                    "UsrCnx.NombreUsuario AS NombreUsuarioCnx, " +
                    "LogPN.FechaLogPN, " +
                    "LogPN.TextoLogPN " +
                    "FROM Usuarios AS UsrCnx " +
                    "INNER JOIN ((Usuarios " +
                    "INNER JOIN ((((PersonaNatural " +
                    "INNER JOIN TipoFormalidad " +
                    "ON PersonaNatural.IdFormalidad = TipoFormalidad.IdFormalidad) " +
                    "INNER JOIN NivelVentas " +
                    "ON PersonaNatural.IdNivelVentas = NivelVentas.IdNivelVentas) " +
                    "INNER JOIN TipoEmpresa " +
                    "ON PersonaNatural.IdTipoEmpresa = TipoEmpresa.IdTipoEmpresa) " +
                    "INNER JOIN PermanenciaRubro " +
                    "ON PersonaNatural.IdPermanenciaRubro = PermanenciaRubro.IdPermanenciaRubro) " +
                    "ON Usuarios.IdUsuario = PersonaNatural.IdUsuario) " +
                    "INNER JOIN LogPN " +
                    "ON PersonaNatural.RutPersonaNatural = LogPN.RutPersonaNatural) " +
                    "ON UsrCnx.IdUsuario = LogPN.IdUsuario " +
                    "ORDER BY PersonaNatural.RutPersonaNatural, LogPN.FechaLogPN";

                OleDbCommand cmd = new OleDbCommand(query, this.BEMEConnectionObj);
                OleDbDataReader reader = cmd.ExecuteReader();

                toReturn = new List<InformePersonaNaturalDTO>();

                while (reader.Read())
                {
                    obj = new InformePersonaNaturalDTO();

                    
                    obj.RutPersonaNatural = Convert.ToString(reader["RutPersonaNatural"]);
                    obj.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);
                    obj.NombreUsuario = Convert.ToString(reader["NombreUsuario"]);
                    obj.IdFormalidad = Convert.ToInt32(reader["IdFormalidad"]);
                    obj.DescTipoFormalidad = Convert.ToString(reader["DescTipoFormalidad"]);
                    obj.IdNivelVentas = Convert.ToInt32(reader["IdNivelVentas"]);
                    obj.DescNivelVentas = Convert.ToString(reader["DescNivelVentas"]);
                    obj.IdTipoEmpresa = Convert.ToInt32(reader["IdTipoEmpresa"]);
                    obj.DescTipoEmpresa = Convert.ToString(reader["DescTipoEmpresa"]);
                    obj.IdPermanenciaRubro = Convert.ToInt32(reader["IdPermanenciaRubro"]);
                    obj.DescPermanenciaRubro = Convert.ToString(reader["DescPermanenciaRubro"]);
                    obj.NombrePersonaNatural = Convert.ToString(reader["NombrePersonaNatural"]);
                    obj.TelefonoPersonaNatural = Convert.ToString(reader["TelefonoPersonaNatural"]);
                    obj.CorreoPersonaNatural = Convert.ToString(reader["CorreoPersonaNatural"]);
                    obj.NomEmpresaPersonaNatural = Convert.ToString(reader["NomEmpresaPersonaNatural"]);
                    obj.RutEmpresaPersonaNatural = Convert.ToString(reader["RutEmpresaPersonaNatural"]);
                    obj.GiroComercialEmpresaPersonaNatural = Convert.ToString(reader["GiroComercialEmpresaPersonaNatural"]);
                    obj.ObservacionesPersonaNatural = Convert.ToString(reader["ObservacionesPersonaNatural"]);
                    obj.NombreUsuarioCnx = Convert.ToString(reader["NombreUsuarioCnx"]);
                    obj.FechaLogPN = Convert.ToDateTime(reader["FechaLogPN"]);
                    obj.TextoLogPN = Convert.ToString(reader["TextoLogPN"]);

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
