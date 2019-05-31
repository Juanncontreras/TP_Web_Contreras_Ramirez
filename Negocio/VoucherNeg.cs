using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class VoucherNeg : EXQuerys
    {


        string Tabla = "Vouchers";
        public string voucherActual { get; set; }



        public bool ValidarVoucher(string voucher)
        {

            try
            {
                String Query = String.Format("SELECT COUNT(*) AS Count FROM {0} WHERE CodigoVoucher = '{1}' and Estado = 0 ", Tabla, voucher);
                this.EjecutarSeleccion(Query);
                this.SqlDataReader.Read();
                if (int.Parse(this.SqlDataReader["Count"].ToString()) == 1)
                {
                    voucherActual = voucher;
                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void VoucherXCliente(String voucher, int IDProducto, int IDUsuario)
        {
            try
            {
                String Query = String.Format("UPDATE {0} SET IdCliente = {1}, IdProducto = {2}, Estado = 0 WHERE CodigoVoucher = '{3}'",
                                             Tabla,
                                             IDUsuario,
                                             IDProducto,
                                             voucher);
                this.EjecutarQuery(Query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.SqlConnection.Close();
            }
        }
    }
}
