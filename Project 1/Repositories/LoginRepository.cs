using Project_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Web.Security;

namespace Project_1.Repositories
{
    public class LoginRepository : BaseRepository, ILoginRepository
    {
        public LoginRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool CheckRole(string email)
        {
            bool check = false;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select dbo.CheckRole('" + email + "')";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        check = Convert.ToBoolean(reader[0]);
                    }
                }
            }
            return check;
        }

        public int OutputID(string email)
        {
            int id = 0;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select dbo.OutputIDUser('" + email + "')";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id = Convert.ToInt32(reader[0]);
                    }
                }
            }
            return id;
         }
         

        public int CheckEmail(string email)
        {
            int id = 0;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select dbo.CheckEmail('" + email + "')";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id = Convert.ToInt32(reader[0]);
                    }
                }
            }
            return id;
        }

        public void Register(LoginModel login, bool role)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec CreateLogin @name,@rl,@email,@pass,@role";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = login.Name;
                command.Parameters.Add("@rl", SqlDbType.NVarChar).Value = login.Role;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = login.Email;
                command.Parameters.Add("@pass", SqlDbType.Int).Value = login.Password;
                command.Parameters.Add("@role", SqlDbType.Bit).Value = role;
                command.ExecuteNonQuery();
            }
        }

        public int TestEmailAndPass(string email, string password)
        {
            int check = 0;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select dbo.TestEmailAndPass('" + email + "','" + password + "')";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        check = Convert.ToInt32(reader[0]);
                    }
                }
            }
            return check;
        }

        public void Update(string email, string pass,bool role)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec UpdateLogin @email,@pass,@role";
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
                command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = pass;
                command.Parameters.Add("@role", SqlDbType.Bit).Value = role;
                command.ExecuteNonQuery();
            }
        }

        public string NameDeveloper(string email)
        {
            string name = "";
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "exec NameDeveloper @email";
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        name = reader[0].ToString();
                    }
                }
            }
            return name;
        }
    }
}
