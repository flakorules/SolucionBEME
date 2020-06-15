using System;
using System.Collections.Generic;

using System.Text;

using BEME.Entities;
using BEME.Core;
using System.Data.OleDb;


namespace BEME.DA
{
    public class FamiliaProductosDA : DataAccessBase
    {
        public List<FamiliaProductosDTO> GetAll()
        {
            List<FamiliaProductosDTO> toReturn = new List<FamiliaProductosDTO>();
            FamiliaProductosDTO obj;

            try
            {
                this.BEMEConnectionObj.Open();

                OleDbCommand cmd = new OleDbCommand("SELECT IdFamiliaProductos, DescFamiliaProductos FROM FamiliaProductos", this.BEMEConnectionObj);
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    obj = new FamiliaProductosDTO();
                    obj.IdFamiliaProductos = Convert.ToInt32(reader["IdFamiliaProductos"]);
                    obj.DescFamiliaProductos = Convert.ToString(reader["DescFamiliaProductos"]);
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

        public List<FamiliaProductosDTO> GetAllByParameters(ResultadoProductosDisponiblesDTO objIn)
        {
            List<FamiliaProductosDTO> toReturn = new List<FamiliaProductosDTO>();
            FamiliaProductosDTO obj;

            try
            {
                this.BEMEConnectionObj.Open();

                OleDbCommand cmd = this.BEMEConnectionObj.CreateCommand();

                cmd.CommandText =
                    "SELECT DISTINCT FamiliaProductos.IdFamiliaProductos, " +
                    "FamiliaProductos.DescFamiliaProductos " +
                    "FROM FamiliaProductos INNER JOIN ResultadoProductosDisponibles " +
                    "ON FamiliaProductos.IdFamiliaProductos = ResultadoProductosDisponibles.IdFamiliaProductos " +
                    "WHERE (((ResultadoProductosDisponibles.IdTipoEmpresa)= @IdTipoEmpresa) AND " +
                    "((ResultadoProductosDisponibles.IdTipoPersonaJuridica)= @IdTipoPersonaJuridica) AND " +
                    "((ResultadoProductosDisponibles.IdPermanenciaRubro)= @IdPermanenciaRubro)) ";


                cmd.Parameters.AddRange(new OleDbParameter[]
            {
               new OleDbParameter("@IdTipoEmpresa", objIn.IdTipoEmpresa),
               new OleDbParameter("@IdTipoPersonaJuridica", objIn.IdTipoPersonaJuridica),
               new OleDbParameter("@IdPermanenciaRubro", objIn.IdPermanenciaRubro)
            });

                OleDbDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    obj = new FamiliaProductosDTO();
                    obj.IdFamiliaProductos = Convert.ToInt32(reader["IdFamiliaProductos"]);
                    obj.DescFamiliaProductos = Convert.ToString(reader["DescFamiliaProductos"]);
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

        public List<FamiliaProductosDTO> GetAllByParameters(PJFamProdProdDTO objIn)
        {
            List<FamiliaProductosDTO> toReturn = new List<FamiliaProductosDTO>();
            FamiliaProductosDTO obj;

            try
            {
                this.BEMEConnectionObj.Open();

                OleDbCommand cmd = this.BEMEConnectionObj.CreateCommand();

                cmd.CommandText =
                    "SELECT DISTINCT FamiliaProductos.IdFamiliaProductos, " +
                    "FamiliaProductos.DescFamiliaProductos " +
                    "FROM FamiliaProductos " +
                    "INNER JOIN PJFamProdProd " +
                    "ON FamiliaProductos.IdFamiliaProductos = PJFamProdProd.IdFamiliaProductos " +
                    "WHERE (((PJFamProdProd.RutEmpresa)=@RutEmpresa))";


                cmd.Parameters.AddRange(new OleDbParameter[]
            {
               new OleDbParameter("@RutEmpresa", objIn.RutEmpresa)
            });

                OleDbDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    obj = new FamiliaProductosDTO();
                    obj.IdFamiliaProductos = Convert.ToInt32(reader["IdFamiliaProductos"]);
                    obj.DescFamiliaProductos = Convert.ToString(reader["DescFamiliaProductos"]);
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

        public List<FamiliaProductosDTO> GetAllByParameters(PNFamProdProdDTO objIn)
        {
            List<FamiliaProductosDTO> toReturn = new List<FamiliaProductosDTO>();
            FamiliaProductosDTO obj;

            try
            {
                this.BEMEConnectionObj.Open();

                OleDbCommand cmd = this.BEMEConnectionObj.CreateCommand();

                cmd.CommandText =
                    "SELECT FamiliaProductos.IdFamiliaProductos, " +
                    "FamiliaProductos.DescFamiliaProductos " +
                    "FROM FamiliaProductos " +
                    "INNER JOIN PNFamProdProd " +
                    "ON FamiliaProductos.IdFamiliaProductos = PNFamProdProd.IdFamiliaProductos " +
                    "WHERE (((PNFamProdProd.RutPersonaNatural)=@RutPersonaNatural))";


                cmd.Parameters.AddRange(new OleDbParameter[]
            {
               new OleDbParameter("@RutPersonaNatural", objIn.RutPersonaNatural)
            });

                OleDbDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    obj = new FamiliaProductosDTO();
                    obj.IdFamiliaProductos = Convert.ToInt32(reader["IdFamiliaProductos"]);
                    obj.DescFamiliaProductos = Convert.ToString(reader["DescFamiliaProductos"]);
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
