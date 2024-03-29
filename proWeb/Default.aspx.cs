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
        protected void comprobarCode(object sender, EventArgs e)
        {
            string code = txtCode.Text;
            if (code.Length < 1 || code.Length > 16)
            {
                // Si el código no cumple con los requisitos, muestra un mensaje de error
                lblMessage.Text = "El código debe tener entre 1 y 16 caracteres.";
                Console.WriteLine("Product operation has failed. Error: {0}", lblMessage.Text);
                return;
            }

            lblMessage.Text = "La operación fue exitosa.";
            // Aquí va el resto del código para procesar el formulario si la validación es exitosa
        }

        protected void comprobarName(object sender, EventArgs e)
        {
            string code = txtName.Text;
            if (code.Length > 32)
            {
                // Si el código no cumple con los requisitos, muestra un mensaje de error
                lblMessage.Text = "El nombre debe tener como máximo 32 caracteres.";
                Console.WriteLine("Product operation has failed. Error: {0}", lblMessage.Text);
                return;
            }

            lblMessage.Text = "La operación fue exitosa.";
            // Aquí va el resto del código para procesar el formulario si la validación es exitosa
        }

        protected void comprobarAmount(object sender, EventArgs e)
        {
            string code = txtAmount.Text;
            int numero = int.Parse(code);
            if (0 > numero || numero > 9999)
            {
                // Si el código no cumple con los requisitos, muestra un mensaje de error
                lblMessage.Text = "La unidad introducida no es correcta.";
                Console.WriteLine("Product operation has failed. Error: {0}", lblMessage.Text);
                return;
            }

            lblMessage.Text = "La operación fue exitosa.";
            // Aquí va el resto del código para procesar el formulario si la validación es exitosa
        }

        protected void comprobarPrice(object sender, EventArgs e)
        {
            string code = txtPrice.Text;
            float numero = int.Parse(code);
            if (0 > numero || numero > 9999.99)
            {
                // Si el código no cumple con los requisitos, muestra un mensaje de error
                lblMessage.Text = "El precio introducida no es correcta.";
                Console.WriteLine("Product operation has failed. Error: {0}", lblMessage.Text);
                return;
            }

            lblMessage.Text = "La operación fue exitosa.";
            // Aquí va el resto del código para procesar el formulario si la validación es exitosa
        }

        
    }
}