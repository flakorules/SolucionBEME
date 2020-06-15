using System;
using System.Collections.Generic;

using System.Text;

using BEME.Entities;
using System.Data.OleDb;

namespace BEME.DA
{
    public class PersonaJuridicaDA : DataAccessBase
    {
        public void Insert(PersonaJuridicaDTO objIn)
        {

            try
            {
                this.BEMEConnectionObj.Open();

                OleDbCommand cmd = this.BEMEConnectionObj.CreateCommand();

                cmd.CommandText =
                    "INSERT INTO " +
                    "PersonaJuridica " +
                    "(RutEmpresa, " +
                    "IdUsuario, " +
                    "IdTipoPersonaJuridica, " +
                    "IdFormalidad, " +
                    "IdNivelVentas, " +
                    "IdTipoEmpresa, " +
                    "IdPermanenciaRubro, " +
                    "NombreEmpresa, " +
                    "NombreRepresLegal, " +
                    "RutRepresLegal, " +
                    "GiroComercial, " +
                    "Telefono, " +
                    "Correo, " +
                    "Observaciones) " +
                    "VALUES " +
                    "(@RutEmpresa, " +
                    "@IdUsuario, " +
                    "@IdTipoPersonaJuridica, " +
                    "@IdFormalidad, " +
                    "@IdNivelVentas, " +
                    "@IdTipoEmpresa, " +
                    "@IdPermanenciaRubro, " +
                    "@NombreEmpresa, " +
                    "@NombreRepresLegal, " +
                    "@RutRepresLegal, " +
                    "@GiroComercial, " +
                    "@Telefono, " +
                    "@Correo, " +
                    "@Observaciones) ";



                cmd.Parameters.AddRange(new OleDbParameter[]
                {
                    new OleDbParameter("@RutEmpresa", objIn.RutEmpresa),  
                    new OleDbParameter("@IdUsuario", objIn.IdUsuario),  
                    new OleDbParameter("@IdTipoPersonaJuridica", objIn.IdTipoPersonaJuridica),
                    new OleDbParameter("@IdFormalidad", objIn.IdFormalidad),
                    new OleDbParameter("@IdNivelVentas", objIn.IdNivelVentas),
                    new OleDbParameter("@IdTipoEmpresa", objIn.IdTipoEmpresa),
                    new OleDbParameter("@IdPermanenciaRubro", objIn.IdPermanenciaRubro),
                    new OleDbParameter("@NombreEmpresa", objIn.NombreEmpresa),
                    new OleDbParameter("@NombreRepresLegal", objIn.NombreRepresLegal),
                    new OleDbParameter("@RutRepresLegal", objIn.RutRepresLegal),
                    new OleDbParameter("@GiroComercial", objIn.GiroComercial),
                    new OleDbParameter("@Telefono", objIn.Telefono),
                    new OleDbParameter("@Correo", objIn.Correo),
                    new OleDbParameter("@Observaciones", objIn.Observaciones)
                });

                cmd.ExecuteNonQuery();


                this.BEMEConnectionObj.Close();
            }
            catch (OleDbException ex)
            {
                throw ex;
            }

        }

        public void Update(PersonaJuridicaDTO objIn)
        {

            try
            {
                this.BEMEConnectionObj.Open();

                OleDbCommand cmd = this.BEMEConnectionObj.CreateCommand();

                cmd.CommandText =
                    "UPDATE PersonaJuridica " +
                    "SET IdUsuario = @IdUsuario, " +
                    "IdTipoPersonaJuridica = @IdTipoPersonaJuridica, " +
                    "IdFormalidad = @IdFormalidad, " +
                    "IdNivelVentas = @IdNivelVentas, " +
                    "IdTipoEmpresa = @IdTipoEmpresa, " +
                    "IdPermanenciaRubro = @IdPermanenciaRubro, " +
                    "NombreEmpresa = @NombreEmpresa, " +
                    "NombreRepresLegal = @NombreRepresLegal, " +
                    "RutRepresLegal = @RutRepresLegal, " +
                    "GiroComercial = @GiroComercial, " +
                    "Telefono = @Telefono, " +
                    "Correo = @Correo, " +
                    "Observaciones = @Observaciones " +
                    "WHERE RutEmpresa = @RutEmpresa;";


                cmd.Parameters.AddRange(new OleDbParameter[]
                {
                    new OleDbParameter("@IdUsuario", objIn.IdUsuario),
                    new OleDbParameter("@IdTipoPersonaJuridica", objIn.IdTipoPersonaJuridica),
                    new OleDbParameter("@IdFormalidad", objIn.IdFormalidad),
                    new OleDbParameter("@IdNivelVentas", objIn.IdNivelVentas),
                    new OleDbParameter("@IdTipoEmpresa", objIn.IdTipoEmpresa),
                    new OleDbParameter("@IdPermanenciaRubro", objIn.IdPermanenciaRubro),
                    new OleDbParameter("@NombreEmpresa", objIn.NombreEmpresa),
                    new OleDbParameter("@NombreRepresLegal", objIn.NombreRepresLegal),
                    new OleDbParameter("@RutRepresLegal", objIn.RutRepresLegal),
                    new OleDbParameter("@GiroComercial", objIn.GiroComercial),
                    new OleDbParameter("@Telefono", objIn.Telefono),
                    new OleDbParameter("@Correo", objIn.Correo),
                    new OleDbParameter("@Observaciones", objIn.Observaciones),
                    new OleDbParameter("@RutEmpresa", objIn.RutEmpresa)
                });

                int cont = cmd.ExecuteNonQuery();


                this.BEMEConnectionObj.Close();
            }
            catch (OleDbException ex)
            {
                throw ex;
            }

        }

        public PersonaJuridicaDTO GetById(PersonaJuridicaDTO objIn)
        {
            PersonaJuridicaDTO toReturn;

            try
            {
                this.BEMEConnectionObj.Open();

                OleDbCommand cmd = this.BEMEConnectionObj.CreateCommand();

                cmd.CommandText =
                    "SELECT RutEmpresa, " +
                    "IdUsuario, " +
                    "IdFormalidad, " +
                    "IdNivelVentas, " +
                    "IdTipoEmpresa, " +
                    "IdTipoPersonaJuridica, " +
                    "IdPermanenciaRubro, " +
                    "NombreEmpresa, " +
                    "NombreRepresLegal, " +
                    "RutRepresLegal, " +
                    "GiroComercial, " +
                    "Telefono, " +
                    "Correo, " +
                    "Observaciones " +
                    "FROM PersonaJuridica " + 
                    "WHERE (((PersonaJuridica.RutEmpresa)=@RutEmpresa)) ";

                

                cmd.Parameters.AddRange(new OleDbParameter[]
                {
                    new OleDbParameter("@RutEmpresa", objIn.RutEmpresa)
                });

                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    toReturn = new PersonaJuridicaDTO();
                    toReturn.RutEmpresa = Convert.ToString(reader["RutEmpresa"]);
                    toReturn.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);
                    toReturn.IdFormalidad = Convert.ToInt32(reader["IdFormalidad"]);
                    toReturn.IdNivelVentas = Convert.ToInt32(reader["IdNivelVentas"]);
                    toReturn.IdTipoEmpresa = Convert.ToInt32(reader["IdTipoEmpresa"]);
                    toReturn.IdTipoPersonaJuridica = Convert.ToInt32(reader["IdTipoPersonaJuridica"]);
                    toReturn.IdPermanenciaRubro = Convert.ToInt32(reader["IdPermanenciaRubro"]);
                    toReturn.NombreEmpresa = Convert.ToString(reader["NombreEmpresa"]);
                    toReturn.NombreRepresLegal = Convert.ToString(reader["NombreRepresLegal"]);
                    toReturn.RutRepresLegal = Convert.ToString(reader["RutRepresLegal"]);
                    toReturn.GiroComercial = Convert.ToString(reader["GiroComercial"]);                    
                    toReturn.Telefono = Convert.ToString(reader["Telefono"]);
                    toReturn.Correo = Convert.ToString(reader["Correo"]);
                    toReturn.Observaciones = Convert.ToString(reader["Observaciones"]);
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

        public List<InformePersonaJuridicaDTO> GetAll()
        {
            List<InformePersonaJuridicaDTO> toReturn;
            InformePersonaJuridicaDTO obj;

            try
            {
                this.BEMEConnectionObj.Open();

                //string query = "SELECT PersonaJuridica.RutEmpresa, " +
                //                "PersonaJuridica.IdUsuario, " +
                //                "Usuarios.NombreUsuario, " +
                //                "PersonaJuridica.IdTipoPersonaJuridica, " +
                //                "TipoPersonaJuridica.DescTipoPersonaJuridica, " +
                //                "PersonaJuridica.IdFormalidad, " +
                //                "TipoFormalidad.DescTipoFormalidad, " +
                //                "PersonaJuridica.IdNivelVentas, " +
                //                "NivelVentas.DescNivelVentas, " +
                //                "PersonaJuridica.IdTipoEmpresa, " +
                //                "TipoEmpresa.DescTipoEmpresa, " +
                //                "PersonaJuridica.IdPermanenciaRubro, " +
                //                "PermanenciaRubro.DescPermanenciaRubro, " +
                //                "PersonaJuridica.NombreEmpresa, " +
                //                "PersonaJuridica.NombreRepresLegal, " +
                //                "PersonaJuridica.RutRepresLegal, " +
                //                "PersonaJuridica.GiroComercial, " +
                //                "PersonaJuridica.Telefono, " +
                //                "PersonaJuridica.Correo, " +
                //                "PersonaJuridica.Observaciones " +
                //                "FROM Usuarios " +
                //                "INNER JOIN (TipoPersonaJuridica " +
                //                "INNER JOIN (TipoFormalidad " +
                //                "INNER JOIN (TipoEmpresa " +
                //                "INNER JOIN (PermanenciaRubro " +
                //                "INNER JOIN (NivelVentas " +
                //                "INNER JOIN PersonaJuridica " +
                //                "ON NivelVentas.IdNivelVentas = PersonaJuridica.IdNivelVentas) " +
                //                "ON PermanenciaRubro.IdPermanenciaRubro = PersonaJuridica.IdPermanenciaRubro) " +
                //                "ON TipoEmpresa.IdTipoEmpresa = PersonaJuridica.IdTipoEmpresa) " +
                //                "ON TipoFormalidad.IdFormalidad = PersonaJuridica.IdFormalidad) " +
                //                "ON TipoPersonaJuridica.IdTipoPersonaJuridica = PersonaJuridica.IdTipoPersonaJuridica) " +
                //                "ON Usuarios.IdUsuario = PersonaJuridica.IdUsuario ";


                string query = "SELECT PersonaJuridica.RutEmpresa, " +
                                "PersonaJuridica.IdUsuario, " +
                                "Usuarios.NombreUsuario, " +
                                "PersonaJuridica.IdTipoPersonaJuridica, " +
                                "TipoPersonaJuridica.DescTipoPersonaJuridica, " +
                                "PersonaJuridica.IdFormalidad, " +
                                "TipoFormalidad.DescTipoFormalidad, " +
                                "PersonaJuridica.IdNivelVentas, " +
                                "NivelVentas.DescNivelVentas, " +
                                "PersonaJuridica.IdTipoEmpresa, " +
                                "TipoEmpresa.DescTipoEmpresa, " +
                                "PersonaJuridica.IdPermanenciaRubro, " +
                                "PermanenciaRubro.DescPermanenciaRubro, " +
                                "PersonaJuridica.NombreEmpresa, " +
                                "PersonaJuridica.NombreRepresLegal," +
                                "PersonaJuridica.RutRepresLegal, " +
                                "PersonaJuridica.GiroComercial, " +
                                "PersonaJuridica.Telefono, " +
                                "PersonaJuridica.Correo, " +
                                "PersonaJuridica.Observaciones, " +
                                "UsrCnx.NombreUsuario AS NombreUsuarioCnx, " +
                                "LogPJ.FechaLogPJ, " +
                                "LogPJ.TextoLogPJ " +
                                "FROM Usuarios AS UsrCnx " +
                                "INNER JOIN ((Usuarios " +
                                "INNER JOIN (TipoPersonaJuridica " +
                                "INNER JOIN (TipoFormalidad " +
                                "INNER JOIN (TipoEmpresa " +
                                "INNER JOIN (PermanenciaRubro " +
                                "INNER JOIN (NivelVentas " +
                                "INNER JOIN PersonaJuridica " +
                                "ON NivelVentas.IdNivelVentas = PersonaJuridica.IdNivelVentas) " +
                                "ON PermanenciaRubro.IdPermanenciaRubro = PersonaJuridica.IdPermanenciaRubro) " +
                                "ON TipoEmpresa.IdTipoEmpresa = PersonaJuridica.IdTipoEmpresa) " +
                                "ON TipoFormalidad.IdFormalidad = PersonaJuridica.IdFormalidad) " +
                                "ON TipoPersonaJuridica.IdTipoPersonaJuridica = PersonaJuridica.IdTipoPersonaJuridica) " +
                                "ON Usuarios.IdUsuario = PersonaJuridica.IdUsuario) " +
                                "INNER JOIN LogPJ ON PersonaJuridica.RutEmpresa = LogPJ.RutEmpresa) " +
                                "ON UsrCnx.IdUsuario = LogPJ.IdUsuario " +
                                "ORDER BY PersonaJuridica.RutEmpresa, LogPJ.FechaLogPJ";

                OleDbCommand cmd = new OleDbCommand(query, this.BEMEConnectionObj);
                OleDbDataReader reader = cmd.ExecuteReader();

                toReturn = new List<InformePersonaJuridicaDTO>();

                while (reader.Read())
                {
                    obj = new InformePersonaJuridicaDTO();

                    obj.RutEmpresa = Convert.ToString(reader["RutEmpresa"]);
                    obj.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);
                    obj.NombreUsuario = Convert.ToString(reader["NombreUsuario"]);
                    obj.IdTipoPersonaJuridica = Convert.ToInt32(reader["IdTipoPersonaJuridica"]);
                    obj.DescTipoPersonaJuridica = Convert.ToString(reader["DescTipoPersonaJuridica"]);
                    obj.IdFormalidad = Convert.ToInt32(reader["IdFormalidad"]);
                    obj.DescTipoFormalidad = Convert.ToString(reader["DescTipoFormalidad"]);
                    obj.IdNivelVentas = Convert.ToInt32(reader["IdNivelVentas"]);
                    obj.DescNivelVentas = Convert.ToString(reader["DescNivelVentas"]);
                    obj.IdTipoEmpresa = Convert.ToInt32(reader["IdTipoEmpresa"]);
                    obj.DescTipoEmpresa = Convert.ToString(reader["DescTipoEmpresa"]);
                    obj.IdPermanenciaRubro = Convert.ToInt32(reader["IdPermanenciaRubro"]);
                    obj.DescPermanenciaRubro = Convert.ToString(reader["DescPermanenciaRubro"]);
                    obj.NombreEmpresa = Convert.ToString(reader["NombreEmpresa"]);
                    obj.NombreRepresLegal = Convert.ToString(reader["NombreRepresLegal"]);
                    obj.RutRepresLegal = Convert.ToString(reader["RutRepresLegal"]);
                    obj.GiroComercial = Convert.ToString(reader["GiroComercial"]);
                    obj.Telefono = Convert.ToString(reader["Telefono"]);
                    obj.Correo = Convert.ToString(reader["Correo"]);
                    obj.Observaciones = Convert.ToString(reader["Observaciones"]);
                    obj.NombreUsuarioCnx = Convert.ToString(reader["NombreUsuarioCnx"]);
                    obj.FechaLogPJ = Convert.ToDateTime(reader["FechaLogPJ"]);
                    obj.TextoLogPJ = Convert.ToString(reader["TextoLogPJ"]);
                    
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
