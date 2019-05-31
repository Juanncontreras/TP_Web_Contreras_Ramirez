using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace DigitalVoucher
{
    public partial class Index : System.Web.UI.Page
    {

        VoucherNeg voucherNeg = new VoucherNeg();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btIngresarVoucher_Click(object sender, EventArgs e)
        {
            try
            {
                if (voucherNeg.ValidarVoucher(txbCodigoVoucher.Text) == true)
                {
                    Response.Redirect("~/SeleccionarPremios.aspx?parametro=" + txbCodigoVoucher.Text);

                }
                else
                    Response.Write("<script>window.alert('El voucher ingresado es erroneo o ya ha sido utilizado. Intente nuevamente');</script>");
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}