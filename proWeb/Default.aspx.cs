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
        protected void comprobaciones(object sender, EventArgs e)
        {
            string code = txtCode.Text;
            string name = txtName.Text;
            string amount = txtAmount.Text;
            int numeroAmount = int.Parse(amount);
            string price = txtPrice.Text;
            float numeroPrice = int.Parse(price);
            if (code.Length < 1 || code.Length > 16)
            {
                
                lblMessage.Text = "El código debe tener entre 1 y 16 caracteres.";
                Console.WriteLine("Product operation has failed. Error: {0}", lblMessage.Text);
                return;
            }else if (name.Length > 32){
               
                lblMessage.Text = "El nombre debe tener como máximo 32 caracteres.";
                Console.WriteLine("Product operation has failed. Error: {0}", lblMessage.Text);
                return;
            }else if (0 > numeroAmount || numeroAmount > 9999){
                
                lblMessage.Text = "La unidad introducida no es correcta.";
                Console.WriteLine("Product operation has failed. Error: {0}", lblMessage.Text);
                return;
            }else if (0 > numeroPrice || numeroPrice > 9999.99){
                
                lblMessage.Text = "El precio introducida no es correcta.";
                Console.WriteLine("Product operation has failed. Error: {0}", lblMessage.Text);
                return;
            }

            lblMessage.Text = "La operación fue exitosa.";
            
        }

        

        
    }
}