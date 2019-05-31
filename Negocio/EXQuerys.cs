using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AccesoDatos;  

namespace Negocio
{
    public class EXQuerys
    {
        public SqlConnection SqlConnection { set; get; }
        public SqlCommand SqlCommand { set; get; }
        public SqlDataReader SqlDataReader { set; get; }

        public EXQuerys()
        {
            this.SqlConnection = new SqlConnection();
            this.SqlCommand = new SqlCommand();
        }

        private void PrepararConsulta(String Query)
        {
            this.SqlConnection.ConnectionString = AccesoDatosManager.cadenaConexion;
            this.SqlCommand.CommandType = System.Data.CommandType.Text;
            this.SqlCommand.CommandText = Query;
            this.SqlCommand.Connection = this.SqlConnection;
            this.SqlConnection.Open();
        }

        public void EjecutarSeleccion(String Query)
        {
            this.PrepararConsulta(Query);
            this.SqlDataReader = this.SqlCommand.ExecuteReader();
        }

        public int InsertarConsulta(String Query)
        {
            this.PrepararConsulta(Query);
            return this.GetOrElse(this.SqlCommand.ExecuteScalar(), 0);
        }

        public void EjecutarQuery(String Query)
        {
            this.PrepararConsulta(Query);
            this.SqlCommand.ExecuteNonQuery();
        }

        private int GetOrElse(object ToConvert, int Default)
        {
            try
            {
                return int.Parse(ToConvert.ToString());
            }
            catch (Exception)
            {
                return Default;
            }
        }

    }
}
