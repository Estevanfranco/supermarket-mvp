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
    internal class CategoriesRepository: BaseRepository, ICategoriRepository
    {

        public CategoriesRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(CategoriModel categoriModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Categories VALUES (@name, @description)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categoriModel.Name;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = categoriModel.Description;
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
                command.CommandText = "DELETE FROM Categories WHERE Categories_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(CategoriModel categoriModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Categories SET Categories_Name = @name,
                                        Categories_Description = @description
                                        WHERE Categories_Id = @Id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categoriModel.Name;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = categoriModel.Description;
                command.Parameters.Add("@id", SqlDbType.Int).Value = categoriModel.Id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<CategoriModel> GetAll()
        {
            var categoriesList = new List<CategoriModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Categories ORDER BY Categories_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categorieModel = new CategoriModel();
                        categorieModel.Id = (int)reader["Categories_Id"];
                        categorieModel.Name = reader["Categories_Name"].ToString();
                        categorieModel.Description = reader["Categories_Description"].ToString();
                        categoriesList.Add(categorieModel);
                    }
                }
            }
            return categoriesList;
        }

        public IEnumerable<CategoriModel> GetByValue(string value)
        {
            var categoriesList = new List<CategoriModel>();
            int categorieId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string categorieName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Categories WHERE Categories_Id=@id or Categories_Name LIKE @name+ '%'
                                      ORDER by Categories_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = categorieId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categorieName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categorieModel = new CategoriModel();
                        categorieModel.Id = (int)reader["Categories_Id"];
                        categorieModel.Name = reader["Categories_Name"].ToString();
                        categorieModel.Description = reader["Categories_Description"].ToString();
                        categoriesList.Add(categorieModel);
                    }
                }
            }

            return categoriesList;
        }

    }
}
