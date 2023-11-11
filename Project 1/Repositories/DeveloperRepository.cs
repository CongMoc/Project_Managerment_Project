using Project_1.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Project_1.Repositories
{
    public class DeveloperRepository : BaseRepository,IDeveloperRepositoty
    {
        public DeveloperRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Edit(DeveloperModel model, int idDev)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec UpdateInformationDev @id,@name,@gender,@email,@role,@besttool,@status,@phone,@address";
                command.Parameters.Add("@id", SqlDbType.Int).Value = idDev;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = model.Name;
                command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = model.Gender;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = model.Email;
                command.Parameters.Add("@role", SqlDbType.NVarChar).Value = model.Role;
                command.Parameters.Add("@besttool", SqlDbType.NVarChar).Value = model.BestTool;
                command.Parameters.Add("@status", SqlDbType.NVarChar).Value = model.Status;
                command.Parameters.Add("@phone",SqlDbType.NVarChar).Value = model.Phone;
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = model.Address;
                command.ExecuteNonQuery();
            }
        } 

        public void ShowInformation(DeveloperModel model, int idDev)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec InformationDev @id";
                command.Parameters.Add("id", SqlDbType.Int).Value = idDev;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        model.Name = reader[0].ToString();
                        model.Gender = reader[1].ToString();
                        model.Email = reader[2].ToString();
                        model.Role = reader[3].ToString();
                        model.BestTool = reader[4].ToString();
                        model.Status = reader[5].ToString();
                        model.Phone =reader[6].ToString();
                        model.Address = reader[7].ToString();
                    }
                }
            }
        }
    }
}
