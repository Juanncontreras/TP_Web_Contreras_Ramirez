using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using AccesoDatos;
using Dominio;

namespace DigitalVoucher
{
    public partial class Registro : System.Web.UI.Page
    {
        public int IDPremioElegido;
        public string voucherActual;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["ParametroVoucher"] != null)
            {
                voucherActual = Request.Params["ParametroVoucher"];


            }
            if (Request.Params["ParametroIDProducto"] != null)
            {
                IDPremioElegido = Convert.ToInt32(Request.Params["ParametroIDProducto"]);
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ClienteNeg clienteNeg = new ClienteNeg();
            VoucherNeg voucherNeg = new VoucherNeg();

            //try
            //{
            //    cliente.Apellido = txtApellido.text();
            //    cliente.Nombre = txtNombre.text();
            //    cliente.Domicilio = txtDomicilio.text();
            //    cliente.DNI = Convert.ToInt32(txtDNI.text);
            //    cliente.Ciudad = txtCiudad.text();
            //    cliente.CP = Convert.ToInt32(txtCP.text());
            //    cliente.email = txtEmail.text();
            //    clienteNeg.AltaCliente(cliente.DNI, cliente.Nombre, cliente.Apellido, cliente.email, cliente.Domicilio, cliente.Ciudad, cliente.CP);
            //    cliente=clienteNeg.GetCliente(cliente.DNI);
            //    voucherNeg.VoucherXCliente(voucherActual, IDPremioElegido, cliente.ID);
            //}
            //catch (Exception)
            //{

            //    throw;
            //}


        }





    }
}