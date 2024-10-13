using Supermarket_mvp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp._Repositories
{
    internal class PayModeRepository : BaseRepository, IPayModeRepository
    {

        public PayModeRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(PayModeModel payModeModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open(); // Abre la conexión a la base de datos

                command.Connection = connection; // Asocia el comando a la conexión abierta
                command.CommandText = "INSERT INTO Paymode VALUES (@name, @observation)"; // Establece el comando SQL para insertar datos

                // Agrega parámetros al comando para prevenir inyecciones SQL y mejorar la legibilidad
                command.Parameters.AddWithValue("@name", payModeModel.Name);
                command.Parameters.AddWithValue("@observation", payModeModel.Observation);

                command.ExecuteNonQuery(); // Ejecuta el comando SQL, insertando los datos
            }
        }

        public void Delete(int id)
        {

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open(); // Abre la conexión a la base de datos

                command.Connection = connection; // Asocia el comando a la conexión abierta
                command.CommandText = "DELETE FROM PayMode WHERE Pay_Mode_Id = @id"; // Establece el comando SQL para eliminar datos

                command.Parameters.Add("@id", SqlDbType.Int).Value = id; // Agrega un parámetro para el ID

                command.ExecuteNonQuery(); // Ejecuta el comando SQL, eliminando el registro
            }

        }

        public void Edit(PayModeModel payModeModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open(); // Abre la conexión a la base de datos

                command.Connection = connection; // Asocia el comando a la conexión abierta
                command.CommandText = @"UPDATE Paymode
                       SET Pay_Mode_Name = @name,
                           Pay_Mode_Observation = @observation
                       WHERE Pay_Mode_Id = @id"; // Establece el comando SQL para actualizar datos

                // Agrega parámetros al comando para prevenir inyecciones SQL y mejorar la legibilidad
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = payModeModel.Name;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = payModeModel.Observation;
                command.Parameters.Add("@id", SqlDbType.Int).Value = payModeModel.Id;

                command.ExecuteNonQuery(); // Ejecuta el comando SQL, actualizando los datos
            }
        }

        public IEnumerable<PayModeModel> GetAll()
        {
            var payModeList = new List<PayModeModel>();
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM PayMode ORDER BY Pay_Mode_Id DESC";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var payModeModel = new PayModeModel();
                            payModeModel.Id = (int)reader["Pay_Mode_Id"];
                            payModeModel.Name = reader["Pay_Mode_Name"].ToString();
                            payModeModel.Observation = reader["Pay_Mode_Observation"].ToString();
                            payModeList.Add(payModeModel);
                        }
                    }
                }
            }
            return payModeList;
        }



        public IEnumerable<PayModeModel> GetByValue(string value)
        {
            var payModeList = new List<PayModeModel>();
            int payModeId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string payModeName = value;
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"SELECT * FROM PayMode 
                          WHERE Pay_Mode_Id=@id OR Pay_Mode_Name LIKE @name+'%'
                          ORDER BY Pay_Mode_Id DESC";
                    command.Parameters.Add("@id", SqlDbType.Int).Value = payModeId;
                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = payModeName;
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var payModeModel = new PayModeModel();
                            payModeModel.Id = (int)reader["Pay_Mode_Id"];
                            payModeModel.Name = reader["Pay_Mode_Name"].ToString();
                            payModeModel.Observation = reader["Pay Mode_Observation"].ToString();
                            payModeList.Add(payModeModel);
                        }
                    }
                }
            }
            return payModeList;
        }



    }
}
