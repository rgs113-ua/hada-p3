using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENProduct
    {
        // Atributos de la clase para representar los datos de un producto
        private string code;
        private string name;
        private int amount;
        private float price;
        private int category;
        private DateTime creationDate;

        // Propiedades públicas para acceder y establecer los valores de los atributos
        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public int Amount { get => amount; set => amount = value; }
        public float Price { get => price; set => price = value; }
        public int Category { get => category; set => category = value; }
        public DateTime CreationDate { get => creationDate; set => creationDate = value; }

        // Constructores de la clase
        public ENProduct()
        {
            // Constructor sin parámetros
        }

        public ENProduct(string code, string name, int amount, float price, int category, DateTime creationDate)
        {
            // Constructor con parámetros para inicializar los atributos
            this.code = code;
            this.name = name;
            this.amount = amount;
            this.price = price;
            this.category = category;
            this.creationDate = creationDate;
        }

        // Métodos para interactuar con la base de datos a través del controlador CADProduct
        public bool Create()
        {
            try
            {
                CADProduct cadProduct = new CADProduct();
                return cadProduct.Create(this);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public bool Update()
        {
            try
            {
                CADProduct cadProduct = new CADProduct();
                return cadProduct.Update(this);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public bool Delete()
        {
            try
            {
                CADProduct cadProduct = new CADProduct();
                return cadProduct.Delete(this);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public bool Read()
        {
            try
            {
                CADProduct cadProduct = new CADProduct();
                return cadProduct.Read(this);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public bool ReadFirst()
        {
            try
            {
                CADProduct cadProduct = new CADProduct();
                return cadProduct.ReadFirst(this);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public bool ReadNext()
        {
            try
            {
                CADProduct cadProduct = new CADProduct();
                return cadProduct.ReadNext(this);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public bool ReadPrev()
        {
            try
            {
                CADProduct cadProduct = new CADProduct();
                return cadProduct.ReadPrev(this);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }
    }

}
