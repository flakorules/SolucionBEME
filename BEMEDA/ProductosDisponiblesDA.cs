using System;
using System.Collections.Generic;

using System.Text;

using BEME.Entities;
using BEME.Core;
using System.Data.OleDb;

namespace BEME.DA
{
    public class ProductosDisponiblesDA : DataAccessBase
    {
        public List<ProductosDisponiblesDTO> GetAll()
        {
            List<ProductosDisponiblesDTO> toReturn = new List<ProductosDisponiblesDTO>();
            ProductosDisponiblesDTO obj;

            try
            {
                this.BEMEConnectionObj.Open();

                OleDbCommand cmd = new OleDbCommand("SELECT IdProductosDisponibles, DescProductosDisponibles FROM ProductosDisponibles", this.BEMEConnectionObj);
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    obj = new ProductosDisponiblesDTO();
                    obj.IdProductosDisponibles = Convert.ToInt32(reader["IdProductosDisponibles"]);
                    obj.DescProductosDisponibles = Convert.ToString(reader["DescProductosDisponibles"]);
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

        public List<ProductosDisponiblesDTO> GetAllByParameters(ResultadoProductosDisponiblesDTO objIN)
        {
            List<ProductosDisponiblesDTO> toReturn = new List<ProductosDisponiblesDTO>();

            ProductosDisponiblesDTO obj;

            try
            {
                this.BEMEConnectionObj.Open();

                OleDbCommand cmd = this.BEMEConnectionObj.CreateCommand();

                cmd.CommandText =
    "SELECT ProductosDisponibles.IdProductosDisponibles, ProductosDisponibles.DescProductosDisponibles " +
    "FROM ProductosDisponibles INNER JOIN ResultadoProductosDisponibles " +
    "ON ProductosDisponibles.IdProductosDisponibles = ResultadoProductosDisponibles.IdProductosDisponibles " +
    "WHERE (((ResultadoProductosDisponibles.IdTipoEmpresa)=@IdTipoEmpresa) " +
    "AND ((ResultadoProductosDisponibles.IdTipoPersonaJuridica)=@IdTipoPersonaJuridica) " +
    "AND ((ResultadoProductosDisponibles.IdPermanenciaRubro)=@IdPermanenciaRubro) " +
    "AND ((ResultadoProductosDisponibles.IdFamiliaProductos)=@IdFamiliaProductos))";


                cmd.Parameters.AddRange(new OleDbParameter[]
            {
               new OleDbParameter("@IdTipoEmpresa", objIN.IdTipoEmpresa),
               new OleDbParameter("@IdTipoPersonaJuridica", objIN.IdTipoPersonaJuridica),
               new OleDbParameter("@IdPermanenciaRubro", objIN.IdPermanenciaRubro),
               new OleDbParameter("@IdFamiliaProductos", objIN.IdFamiliaProductos)
            });

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    obj = new ProductosDisponiblesDTO();
                    obj.IdProductosDisponibles = Convert.ToInt32(reader["IdProductosDisponibles"]);
                    obj.DescProductosDisponibles = Convert.ToString(reader["DescProductosDisponibles"]);
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

        public List<ProductosDisponiblesDTO> GetAllByParameters(PJFamProdProdDTO objIN)
        {
            List<ProductosDisponiblesDTO> toReturn = new List<ProductosDisponiblesDTO>();

            ProductosDisponiblesDTO obj;

            try
            {
                this.BEMEConnectionObj.Open();

                OleDbCommand cmd = this.BEMEConnectionObj.CreateCommand();

                cmd.CommandText =
                    "SELECT DISTINCT ProductosDisponibles.IdProductosDisponibles, " +
                    "ProductosDisponibles.DescProductosDisponibles " +
                    "FROM ProductosDisponibles " +
                    "INNER JOIN PJFamProdProd " +
                    "ON ProductosDisponibles.IdProductosDisponibles = PJFamProdProd.IdProductosDisponibles " +
                    "WHERE (((PJFamProdProd.RutEmpresa)=@RutEmpresa) " +
                    "AND ((PJFamProdProd.IdFamiliaProductos)=@IdFamiliaProductos))";


                cmd.Parameters.AddRange(new OleDbParameter[]
            {
               new OleDbParameter("@RutEmpresa", objIN.RutEmpresa),
               new OleDbParameter("@IdFamiliaProductos", objIN.IdFamiliaProductos)
            });

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    obj = new ProductosDisponiblesDTO();
                    obj.IdProductosDisponibles = Convert.ToInt32(reader["IdProductosDisponibles"]);
                    obj.DescProductosDisponibles = Convert.ToString(reader["DescProductosDisponibles"]);
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





        public List<ProductosDisponiblesDTO> GetAllByParameters(PNFamProdProdDTO objIN)
        {
            List<ProductosDisponiblesDTO> toReturn = new List<ProductosDisponiblesDTO>();

            ProductosDisponiblesDTO obj;

            try
            {
                this.BEMEConnectionObj.Open();

                OleDbCommand cmd = this.BEMEConnectionObj.CreateCommand();

                cmd.CommandText =
                    "SELECT ProductosDisponibles.IdProductosDisponibles, " +
                    "ProductosDisponibles.DescProductosDisponibles " +
                    "FROM ProductosDisponibles " +
                    "INNER JOIN PNFamProdProd " +
                    "ON ProductosDisponibles.IdProductosDisponibles = PNFamProdProd.IdProductosDisponibles " +
                    "WHERE (((PNFamProdProd.RutPersonaNatural)=@RutPersonaNatural) " +
                    "AND ((PNFamProdProd.IdFamiliaProductos)=@IdFamiliaProductos))";


                cmd.Parameters.AddRange(new OleDbParameter[]
                {
                    new OleDbParameter("@RutPersonaNatural", objIN.RutPersonaNatural),
                    new OleDbParameter("@IdFamiliaProductos", objIN.IdFamiliaProductos)
                });

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    obj = new ProductosDisponiblesDTO();
                    obj.IdProductosDisponibles = Convert.ToInt32(reader["IdProductosDisponibles"]);
                    obj.DescProductosDisponibles = Convert.ToString(reader["DescProductosDisponibles"]);
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
