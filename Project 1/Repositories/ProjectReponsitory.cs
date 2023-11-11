using Project_1.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_1.Repositories
{
    public class ProjectReponsitory:BaseRepository,IProjectRepository
    {
        public ProjectReponsitory(string ConnectionString) 
        { 
            this.connectionString = ConnectionString;
        }

        public void AddProject(ProjectModel project,int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec AddProject @name,@idmanager,@start,@end,@status,@description";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = project.Project;
                command.Parameters.Add("@idmanager", SqlDbType.Int).Value = id;
                command.Parameters.Add("@start", SqlDbType.DateTime).Value = project.Start;
                command.Parameters.Add("@end", SqlDbType.DateTime).Value = project.Complete;
                command.Parameters.Add("@status", SqlDbType.NVarChar).Value = project.Status;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = project.Description;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int idProject)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec DeleteProject @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = idProject;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<ProjectModel> GetAll(int idManager)
        {
            var List = new List<ProjectModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec ProjectView @idmanager";
                command.Parameters.Add("@idmanager", SqlDbType.Int).Value = idManager;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var Model = new ProjectModel();
                        Model.ID = Convert.ToInt32(reader[0]);
                        Model.Project = reader[1].ToString();
                        Model.Manager = reader[2].ToString();
                        Model.Start = DateTime.Parse(reader[3].ToString());
                        Model.Complete = DateTime.Parse(reader[4].ToString());
                        Model.Status = reader[5].ToString();
                        Model.Percent = float.Parse(reader[6].ToString());
                        Model.Description = reader[7].ToString();
                        List.Add(Model);
                    }
                }
            }
            return List;
        }

        public IEnumerable<ProjectModel> GetOwner(string NameManager)
        {
            var List = new List<ProjectModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec ProjectViewByOwner @name";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = NameManager;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var Model = new ProjectModel();
                        Model.ID = Convert.ToInt32(reader[0]);
                        Model.Project = reader[1].ToString();
                        Model.Manager = reader[2].ToString();
                        Model.Start = DateTime.Parse(reader[3].ToString());
                        Model.Complete = DateTime.Parse(reader[4].ToString());
                        Model.Status = reader[5].ToString();
                        Model.Percent = float.Parse(reader[6].ToString());
                        Model.Description = reader[7].ToString();
                        List.Add(Model);
                    }
                }
            }
            return List;
        }


        public IEnumerable<ProjectModel> GetStatus(int id, string status)
        {
            var List = new List<ProjectModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec ProjectViewStatus @id,@status";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@status", SqlDbType.NVarChar).Value = status;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var Model = new ProjectModel();
                        Model.ID = Convert.ToInt32(reader[0]);
                        Model.Project = reader[1].ToString();
                        Model.Manager = reader[2].ToString();
                        Model.Start = DateTime.Parse(reader[3].ToString());
                        Model.Complete = DateTime.Parse(reader[4].ToString());
                        Model.Status = reader[5].ToString();
                        Model.Percent = float.Parse(reader[6].ToString());
                        Model.Description = reader[7].ToString();
                        List.Add(Model);
                    }
                }
            }
            return List;
        }

        public IEnumerable<ProjectModel> SearchByValue(int id,string value)
        {
            var List = new List<ProjectModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec FindProject @id,@value";
                command.Parameters.Add("@id", SqlDbType.Int).Value =id;
                command.Parameters.Add("@value", SqlDbType.NVarChar).Value = value;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var Model = new ProjectModel();
                        Model.ID = Convert.ToInt32(reader[0]);
                        Model.Project = reader[1].ToString();
                        Model.Manager = reader[2].ToString();
                        Model.Start = DateTime.Parse(reader[3].ToString());
                        Model.Complete = DateTime.Parse(reader[4].ToString());
                        Model.Status = reader[5].ToString();
                        Model.Percent = float.Parse(reader[6].ToString());
                        Model.Description = reader[7].ToString();
                        List.Add(Model);
                    }
                }
            }
            return List;
        }

        public void UpdateProject(ProjectModel project, int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec UpdateProject @id,@name,@idmanager,@start,@end,@status,@percent,@description";
                command.Parameters.Add("@id", SqlDbType.Int).Value = project.ID;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = project.Project;
                command.Parameters.Add("@idmanager", SqlDbType.Int).Value = id;
                command.Parameters.Add("@start", SqlDbType.Date).Value = project.Start;
                command.Parameters.Add("@end", SqlDbType.Date).Value = project.Complete;
                command.Parameters.Add("@status", SqlDbType.NVarChar).Value = project.Status;
                command.Parameters.Add("@percent", SqlDbType.Char).Value = project.Percent;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = project.Description;
                command.ExecuteNonQuery();
            }
        }
    }
}
