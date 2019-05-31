using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ClienteNeg
    {
        string Tabla = "Clientes";
        EXQuerys EXQuerys = new EXQuerys();

        public Cliente GetCliente(int DNI)
        {
            try
            {
                String Query = String.Format("SELECT * FROM {0} WHERE DNI = {1}", Tabla, DNI);
                EXQuerys.EjecutarSeleccion(Query);
                EXQuerys.SqlDataReader.Read();

                return this.TraerDatos();
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }


        public Cliente AltaCliente(int DNI, String Name, String Lastname, String Email, String Address, String City, int PostalCode)
        {
            try
            {
                String Query = String.Format("INSERT INTO {0} (DNI, Nombre, Apellido, Email, Direccion, Ciudad, Codigo_Postal)" +
                                             "VALUES ({1}, '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')",
                                             Tabla,
                                             DNI,
                                             Name,
                                             Lastname,
                                             Email,
                                             Address,
                                             City,
                                             PostalCode);
                EXQuerys.InsertarConsulta(Query);
                EXQuerys.SqlConnection.Close();

                return this.GetCliente(DNI);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }






        private Cliente TraerDatos()
        {
            if (!EXQuerys.SqlDataReader.HasRows)
                return null;

            return new Cliente
            {
                ID = Convert.ToInt32(EXQuerys.SqlDataReader["Id"]),
                DNI = Convert.ToInt32(EXQuerys.SqlDataReader["DNI"]),
                Nombre = Convert.ToString(EXQuerys.SqlDataReader["Nombre"]),
                Apellido = Convert.ToString(EXQuerys.SqlDataReader["Apellido"]),
                email = Convert.ToString(EXQuerys.SqlDataReader["Email"]),
                Domicilio = Convert.ToString(EXQuerys.SqlDataReader["Direccion"]),
                Ciudad = Convert.ToString(EXQuerys.SqlDataReader["Ciudad"]),
                CP = Convert.ToInt32(EXQuerys.SqlDataReader["Codigo_Postal"])

            };
        }


    }
}
