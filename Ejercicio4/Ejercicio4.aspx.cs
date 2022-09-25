using System;

namespace Ejercicio4
{
    public partial class Ejercicio4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                double monto = double.Parse(TxtMonto.Text);
                double porcentaje = 0;
                if (monto >= 3000.01)
                    porcentaje = .30;
                else if (monto >= 1000.01)
                    porcentaje = .20;
                else if (monto >= 0.01)
                    porcentaje = .10;

                double descuento = monto * porcentaje;
                double totalPagar = monto - descuento;

                LimpiarTextBox();
                this.TxtDescuento.Text = descuento.ToString();
                this.TxtTotalPagar.Text = totalPagar.ToString();

            }
            catch (Exception)
            {
                LimpiarTextBox();
                this.LblError.Text = "Monto ingresado no es válido.";
            }
        }
        private void LimpiarTextBox()
        {
            this.LblError.Text = "";
            this.TxtDescuento.Text = "";
            this.TxtTotalPagar.Text = "";                        
        }
    }
}
