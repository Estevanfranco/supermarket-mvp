using Supermarket_mvp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Supermarket_mvp._Repositories
{
    internal class CustomersRepository : BaseRepository, ICustomersRepository
    {

        public CustomersRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(CustomersModel customersModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Customers VALUES (@document, @firstName, @lastName, @address, @birthday, @phoneNumber, @email)";
                command.Parameters.Add("@document", SqlDbType.NVarChar).Value = customersModel.Document;
                command.Parameters.Add("@firstName", SqlDbType.NVarChar).Value = customersModel.FirstName;
                command.Parameters.Add("@lastName", SqlDbType.NVarChar).Value = customersModel.LastName;
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = customersModel.Address;
                command.Parameters.Add("@birthday", SqlDbType.NVarChar).Value = customersModel.Birthday;
                command.Parameters.Add("@phoneNumber", SqlDbType.NVarChar).Value = customersModel.PhoneNumber;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = customersModel.Email;

                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Customers WHERE Customers_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(CustomersModel customersModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Customers SET Customers_DocNum = @document,
                                        Customers_FirstName = @firstName,
                                        Customers_LastName = @lastName,
                                        Customers_Address = @address,
                                        CustomersBirthday = @birthday,
                                        CustomersPhoneNumber = @phoneNumber,
                                        CustomersEmail = @email
                                        WHERE Customers_Id = @Id";


                //
                command.Parameters.Add("@document", SqlDbType.NVarChar).Value = customersModel.Document;
                command.Parameters.Add("@firstName", SqlDbType.NVarChar).Value = customersModel.FirstName;
                command.Parameters.Add("@lastName", SqlDbType.NVarChar).Value = customersModel.LastName;
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = customersModel.Address;
                command.Parameters.Add("@birthday", SqlDbType.NVarChar).Value = customersModel.Birthday;
                command.Parameters.Add("@phoneNumber", SqlDbType.NVarChar).Value = customersModel.PhoneNumber;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = customersModel.Email;
                command.Parameters.Add("@id", SqlDbType.NVarChar).Value = customersModel.Id;
                command.ExecuteNonQuery();

            }
        }

        public IEnumerable<CustomersModel> GetAll()
        {
            var customersList = new List<CustomersModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Customers ORDER BY Customers_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customersModel = new CustomersModel();
                        customersModel.Id = (int)reader["Customers_Id"];
                        customersModel.Document = reader["Customers_DocNum"].ToString();
                        customersModel.FirstName = reader["Customers_FirstName"].ToString();
                        customersModel.LastName = reader["Customers_LastName"].ToString();
                        customersModel.Address = reader["Customers_Address"].ToString();
                        customersModel.Birthday = reader["CustomersBirthday"].ToString();
                        customersModel.PhoneNumber = reader["CustomersPhoneNumber"].ToString();
                        customersModel.Email = reader["CustomersEmail"].ToString();

                        customersList.Add(customersModel);
                    }
                }
            }
            return customersList;
        }






        public IEnumerable<CustomersModel> GetByValue(string value)
        {
            var customersList = new List<CustomersModel>();
            int customersId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string customersName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Customers WHERE Customers_Id=@id or Customers_DocNum LIKE @document+ '%'
                                      ORDER by Customers_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = customersId;
                command.Parameters.Add("@document", SqlDbType.NVarChar).Value = customersName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var custoemrsModel = new CustomersModel();
                        custoemrsModel.Id = (int)reader["Customers_Id"];
                        custoemrsModel.Document = reader["Customers_DocNum"].ToString();
                        custoemrsModel.FirstName = reader["Customers_FirstName"].ToString();
                        custoemrsModel.LastName = reader["Customers_LastName"].ToString();
                        custoemrsModel.Address = reader["Customers_Address"].ToString();
                        custoemrsModel.Birthday = reader["CustomersBirthday"].ToString();
                        custoemrsModel.PhoneNumber = reader["CustomersPhoneNumber"].ToString();
                        custoemrsModel.Email = reader["CustomersEmail"].ToString();

                        customersList.Add(custoemrsModel);
                    }
                }
            }

            return customersList;
        }


    }
}
