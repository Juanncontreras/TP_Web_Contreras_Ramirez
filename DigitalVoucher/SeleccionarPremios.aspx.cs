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
    public partial class SeleccionarPremios : System.Web.UI.Page
    {
        PremioNeg premioNeg = new PremioNeg();
        Premio premioElegido = new Premio();

        public int IDPremioElegido;
        public string voucherActual;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["Parametro"] != null)
                voucherActual = Request.Params["Parametro"];


        }

        protected void ibMonitorMac_Click(object sender, ImageClickEventArgs e)
        {
            AccesoDatosManager acceso = new AccesoDatosManager();

            try
            {

                premioElegido = premioNeg.ListarPremio(1);
                IDPremioElegido = premioElegido.ID;
                Response.Redirect("~/Registro.aspx?ParametroVoucher=" + voucherActual + "&ParametroIDProducto=" + IDPremioElegido);
            }
            catch (Exception)
            {

                throw;
            }

        }

        protected void ibPS4_Click(object sender, ImageClickEventArgs e)
        {
            AccesoDatosManager acceso = new AccesoDatosManager();

            try
            {

                premioElegido = premioNeg.ListarPremio(2);
                IDPremioElegido = premioElegido.ID;
                Response.Redirect("~/Registro.aspx?ParametroVoucher=" + voucherActual + "&ParametroIDProducto=" + IDPremioElegido);
            }
            catch (Exception)
            {

                throw;
            }

        }

        protected void ibMiniComponente_Click(object sender, ImageClickEventArgs e)
        {
            AccesoDatosManager acceso = new AccesoDatosManager();

            try
            {

                premioElegido = premioNeg.ListarPremio(3);
                IDPremioElegido = premioElegido.ID;
                Response.Redirect("~/Registro.aspx?ParametroVoucher=" + voucherActual + "&ParametroIDProducto=" + IDPremioElegido);
            }
            catch (Exception)
            {

                throw;
            }

        }
        protected void ibLenovo_Click(object sender, ImageClickEventArgs e)
        {
            AccesoDatosManager acceso = new AccesoDatosManager();

            try
            {

                premioElegido = premioNeg.ListarPremio(4);
                IDPremioElegido = premioElegido.ID;
                Response.Redirect("~/Registro.aspx?ParametroVoucher=" + voucherActual + "&ParametroIDProducto=" + IDPremioElegido);
            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}