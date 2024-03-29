using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace library
{
    public class CADProduct
    {
        private string connectionString;

        public CADProduct()
        {
            // Constructor: inicializa la cadena de conexión de la BD
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True";
        }
        // Método para crear un nuevo producto en la base de datos
        public bool Create(ENProduct en)
        {
            try
            {
                // Abre una conexión a la base de datos y ejecuta una consulta SQL INSERT
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Products (name, code, amount, price, category, creationDate) VALUES (@name, @code, @amount, @price, @category, @creationDate)";
                    SqlCommand command = new SqlCommand(query, connection);
                    // Asigna valores a los parámetros de la consulta SQL
                    command.Parameters.AddWithValue("@name", en.Name);
                    command.Parameters.AddWithValue("@code", en.Code);
                    command.Parameters.AddWithValue("@amount", en.Amount);
                    command.Parameters.AddWithValue("@price", en.Price);
                    command.Parameters.AddWithValue("@category", en.Category);
                    command.Parameters.AddWithValue("@creationDate", en.CreationDate);
                    // Ejecuta la consulta y devuelve true si al menos una fila fue afectada
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            // Captura excepciones de SQL y muestra el mensaje de error
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        // Método para actualizar un producto existente en la base de datos
        public bool Update(ENProduct en)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Products SET name = @name, amount = @amount, price = @price, category = @category, creationDate = @creationDate WHERE code = @code";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", en.Name);
                    command.Parameters.AddWithValue("@amount", en.Amount);
                    command.Parameters.AddWithValue("@price", en.Price);
                    command.Parameters.AddWithValue("@category", en.Category);
                    command.Parameters.AddWithValue("@creationDate", en.CreationDate);
                    command.Parameters.AddWithValue("@code", en.Code);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        // Método para eliminar un producto de la base de datos
        public bool Delete(ENProduct en)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Products WHERE code = @code";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@code", en.Code);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        // Método para leer los detalles de un producto específico de la base de datos
        public bool Read(ENProduct en)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Products WHERE code = @code";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@code", en.Code);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        en.Name = reader["name"].ToString();
                        en.Amount = Convert.ToInt32(reader["amount"]);
                        en.Price = Convert.ToSingle(reader["price"]);
                        en.Category = Convert.ToInt32(reader["category"]);
                        en.CreationDate = Convert.ToDateTime(reader["creationDate"]);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        // Métodos adicionales para leer el primer producto, el siguiente y el anterior
        public bool ReadFirst(ENProduct en)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT TOP 1 * FROM Products ORDER BY id ASC";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        en.Code = reader["code"].ToString();
                        en.Name = reader["name"].ToString();
                        en.Amount = Convert.ToInt32(reader["amount"]);
                        en.Price = Convert.ToSingle(reader["price"]);
                        en.Category = Convert.ToInt32(reader["category"]);
                        en.CreationDate = Convert.ToDateTime(reader["creationDate"]);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public bool ReadNext(ENProduct en)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT TOP 1 * FROM Products WHERE id > (SELECT id FROM Products WHERE code = @code) ORDER BY id ASC";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@code", en.Code);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        en.Code = reader["code"].ToString();
                        en.Name = reader["name"].ToString();
                        en.Amount = Convert.ToInt32(reader["amount"]);
                        en.Price = Convert.ToSingle(reader["price"]);
                        en.Category = Convert.ToInt32(reader["category"]);
                        en.CreationDate = Convert.ToDateTime(reader["creationDate"]);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public bool ReadPrev(ENProduct en)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT TOP 1 * FROM Products WHERE id < (SELECT id FROM Products WHERE code = @code) ORDER BY id DESC";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@code", en.Code);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        en.Code = reader["code"].ToString();
                        en.Name = reader["name"].ToString();
                        en.Amount = Convert.ToInt32(reader["amount"]);
                        en.Price = Convert.ToSingle(reader["price"]);
                        en.Category = Convert.ToInt32(reader["category"]);
                        en.CreationDate = Convert.ToDateTime(reader["creationDate"]);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }
    }


}
