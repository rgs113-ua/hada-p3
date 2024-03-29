using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proWeb
{
    public partial class Default : System.Web.UI.Page
    {
        // Método para realizar comprobaciones antes de realizar operaciones con productos
        protected void comprobaciones(object sender, EventArgs e)
        {
            // Obtener valores de los campos de texto
            string code = txtCode.Text;
            string name = txtName.Text;
            string amount = txtAmount.Text;
            int numeroAmount = int.Parse(amount);
            string price = txtPrice.Text;
            float numeroPrice = int.Parse(price);

            // Comprobaciones de validez de datos
            if (code.Length < 1 || code.Length > 16)
            {
                // Mensaje de error para código inválido
                lblMessage.Text = "El código debe tener entre 1 y 16 caracteres.";
                Console.WriteLine("Product operation has failed. Error: {0}", lblMessage.Text);
                return;
            }
            else if (name.Length > 32)
            {
                // Mensaje de error para nombre inválido
                lblMessage.Text = "El nombre debe tener como máximo 32 caracteres.";
                Console.WriteLine("Product operation has failed. Error: {0}", lblMessage.Text);
                return;
            }
            else if (0 > numeroAmount || numeroAmount > 9999)
            {
                // Mensaje de error para cantidad inválida
                lblMessage.Text = "La unidad introducida no es correcta.";
                Console.WriteLine("Product operation has failed. Error: {0}", lblMessage.Text);
                return;
            }
            else if (0 > numeroPrice || numeroPrice > 9999.99)
            {
                // Mensaje de error para precio inválido
                lblMessage.Text = "El precio introducido no es correcto.";
                Console.WriteLine("Product operation has failed. Error: {0}", lblMessage.Text);
                return;
            }

            // Mensaje de éxito si todas las comprobaciones son exitosas
            lblMessage.Text = "La operación fue exitosa.";
        }
    }
}
