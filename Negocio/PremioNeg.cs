using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;
using AccesoDatos;

namespace Negocio
{
    public class PremioNeg
    {


        string Tabla = "Productos";
        public int idProductoElegido { get; set; }


        public Premio ListarPremio(int idPremio)
        {

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                Premio premioElegido = new Premio();

                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                String Query = String.Format("SELECT * FROM {0} where id ={1}", Tabla, idPremio);
                comando.CommandText = Query;
                comando.Connection = conexion;
                conexion.Open();

                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    if (idPremio == Convert.ToInt32(lector["Id"]))
                    {
                        idProductoElegido = premioElegido.ID;
                        premioElegido.ID = Convert.ToInt32(lector["Id"]);
                        premioElegido.Descripcion = Convert.ToString(lector["Descripcion"]);
                        premioElegido.Titulo = Convert.ToString(lector["Titulo"]);
                        premioElegido.URLImagen = Convert.ToString(lector["URLImagen"]);

                    }
                }


                return premioElegido;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }


    }

}
