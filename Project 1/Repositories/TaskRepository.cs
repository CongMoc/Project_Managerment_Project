using Project_1.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Reflection;
using Project_1.Views;

namespace Project_1.Repositories
{
    public class TaskRepository : BaseRepository, ITaskRepository
    {
        public TaskRepository(string SqlconnectionString) 
        {
            this.connectionString = SqlconnectionString;
        }

        public void Add(TaskModel model, int idDeveloper, int idProject)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec AddTask @idproject,@iddev,@name,@description,@start,@end";
                command.Parameters.Add("@idproject", SqlDbType.Int).Value = idProject;
                command.Parameters.Add("@iddev", SqlDbType.Int).Value = idDeveloper;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = model.Task;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = model.Description;
                command.Parameters.Add("@start", SqlDbType.Date).Value = model.Start;
                command.Parameters.Add("@end", SqlDbType.Date).Value = model.Complete;
                command.ExecuteNonQuery();
            }
        }

        public void AddDetailTask(TaskModel model, int idProject, int idDeveloper,int idTask)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec AddDetailTask @idTask,@idProject,@IDDev,@status,@datework,@description";
                command.Parameters.Add("@idTask",SqlDbType.Int).Value = idTask;
                command.Parameters.Add("@idProject", SqlDbType.Int).Value = idProject;
                command.Parameters.Add("@IDDev", SqlDbType.Int).Value = idDeveloper;
                command.Parameters.Add("@status", SqlDbType.NVarChar).Value = model.Status;
                command.Parameters.Add("@datework",SqlDbType.Date).Value = model.DateWork;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = model.Description;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<TaskModel> FindAll(int idProject,string value)
        {
            var list = new List<TaskModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec FindAll @idProject, @value";
                command.Parameters.Add("@idProject", SqlDbType.Int).Value = idProject;
                command.Parameters.Add("@value", SqlDbType.NVarChar).Value = value;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var Model = new TaskModel();
                        Model.ID = Convert.ToInt32(reader[0]);
                        Model.Task = reader[1].ToString();
                        Model.Project = reader[2].ToString();
                        Model.Developer = reader[3].ToString();
                        Model.Role = reader[4].ToString();
                        Model.BestTool = reader[5].ToString();
                        Model.Start = DateTime.Parse(reader[6].ToString());
                        Model.Complete = (DateTime)reader[7];
                        Model.DateWork = (DateTime)reader[8];   
                        Model.Status = reader[9].ToString();
                        Model.Percent = (float)reader[10];
                        Model.Description = reader[11].ToString();
                        Model.Request = reader[12].ToString();
                        list.Add(Model);
                    }
                }
            }
            return list;
        }

        public IEnumerable<TaskModel> GetAll()
        {
            var list = new List<TaskModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec TaskViewAll";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var Model = new TaskModel();
                        Model.ID = Convert.ToInt32(reader[0]);
                        Model.Task = reader[1].ToString();
                        Model.Project = reader[2].ToString();
                        Model.Developer = reader[3].ToString();
                        Model.Role = reader[4].ToString();
                        Model.BestTool = reader[5].ToString();
                        Model.Start = DateTime.Parse(reader[6].ToString());
                        Model.Complete = (DateTime)reader[7];
                        Model.DateWork = (DateTime)reader[8];
                        Model.Status = reader[9].ToString();
                        Model.Percent = float.Parse(reader[10].ToString());
                        Model.Description = reader[11].ToString();
                        Model.Request = reader[12].ToString();
                        list.Add(Model);
                    }
                }
            }
            return list;
        }

        public IEnumerable<TaskModel> GetAllManagementTask(int idDeveloper)
        {
            var list = new List<TaskModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec TaskView @idDeveloper";
                command.Parameters.Add("@idDeveloper", SqlDbType.Int).Value = idDeveloper;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var Model = new TaskModel();
                        Model.ID = Convert.ToInt32(reader[0]);
                        Model.Task = reader[1].ToString();
                        Model.Project = reader[2].ToString();
                        Model.Developer = reader[3].ToString();
                        Model.Role = reader[4].ToString();
                        Model.BestTool = reader[5].ToString();
                        Model.Start = DateTime.Parse(reader[6].ToString());
                        Model.Complete = (DateTime)reader[7];
                        Model.DateWork = (DateTime)reader[8];
                        Model.Status = reader[9].ToString();
                        Model.Percent = float.Parse(reader[10].ToString());
                        Model.Description = reader[11].ToString();
                        Model.Request = reader[12].ToString();
                        list.Add(Model);
                    }
                }
            }
            return list;
        }

        public IEnumerable<TaskModel> GetByProjectId(int projectId)
        {
            var list = new List<TaskModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec ManagementTaskView @idProject";
                command.Parameters.Add("@idProject",SqlDbType.Int).Value = projectId;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var Model = new TaskModel();
                        Model.ID = Convert.ToInt32(reader[0]);
                        Model.Task = reader[1].ToString();
                        Model.Project = reader[2].ToString();
                        Model.Developer = reader[3].ToString();
                        Model.Role = reader[4].ToString();
                        Model.BestTool = reader[5].ToString();
                        Model.Start = DateTime.Parse(reader[6].ToString());
                        Model.Complete = (DateTime)reader[7];
                        Model.Status = reader[8].ToString();
                        Model.Percent = float.Parse(reader[9].ToString());
                        Model.Description = reader[10].ToString();
                        Model.Request = reader[11].ToString();
                        list.Add(Model);
                    }
                }
            }
            return list;
        }

        public TaskModel GetTask(int idTask,int idProject)
        {
            var Model = new TaskModel();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec TaskViewByID @idProject,@idTask";
                command.Parameters.Add("@idProject", SqlDbType.Int).Value = idProject;
                command.Parameters.Add("@idTask", SqlDbType.Int).Value = idTask;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Model.ID = Convert.ToInt32(reader[0]);
                        Model.Task = reader[1].ToString();
                        Model.Project = reader[2].ToString();
                        Model.Developer = reader[3].ToString();
                        Model.Role = reader[4].ToString();
                        Model.BestTool = reader[5].ToString();
                        Model.Start = DateTime.Parse(reader[6].ToString());
                        Model.Complete = (DateTime)reader[7];
                        Model.Status = reader[8].ToString();
                        Model.Description = reader[9].ToString();
                        Model.Request = reader[10].ToString();
                    }
                }
            }
            return Model;
        }

        public int IDDeveloper(int idTask)
        {
            int id = 0;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"select dbo.IDDeveloper('" +idTask+ "')";
                id = (int)command.ExecuteScalar();
            }
            return id;
        }

        public int IDDeveloperByName(string name)
        {
            int id = 0;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"select dbo.Developer('" + name + "')";
                id = (int)command.ExecuteScalar();
            }
            return id;
        }

        public int IDProjectByIDTask(int idTask)
        {
            int id = 0;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"select dbo.ReturnIDProject('" + idTask + "')";
                id = (int)command.ExecuteScalar();
            }
            return id;
        }

        public void Remove(int idTask)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec deleteTask @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = idTask;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<TaskModel> ShowDeveloperFree()
        {
            var list = new List<TaskModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"select Name,Role,BestTool from tbl_Developer where Status = 'Free' and Role != 'Project manager'";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var model = new TaskModel();
                        model.Developer = reader[0].ToString();
                        model.Role = reader[1].ToString();
                        model.BestTool = reader[2].ToString();
                        list.Add(model);
                    }
                }
                return list;
            }
        }

        public void Update(TaskModel model, int idDeveloper,int idProject)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec UpdateTask @id,@idProject,@idDeveloper,@name,@start,@end,@status,@description,@request";
                command.Parameters.Add("@id", SqlDbType.Int).Value = model.ID;
                command.Parameters.Add("@idProject", SqlDbType.Int).Value  = idProject;
                command.Parameters.Add("@idDeveloper", SqlDbType.Int).Value = idDeveloper;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = model.Task;
                command.Parameters.Add("@start", SqlDbType.Date).Value = model.Start;
                command.Parameters.Add("@end", SqlDbType.Date).Value = model.Complete;
                command.Parameters.Add("@status", SqlDbType.NVarChar).Value = model.Status;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = model.Description;
                command.Parameters.Add("@request", SqlDbType.NVarChar).Value = model.Request;
                command.ExecuteNonQuery();
            }
        }

        public void UpdateDetailTask(TaskModel model,int idTask)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec UpdateDetailTask @id,@idTask,@status,@description,@datework,@request";
                command.Parameters.Add("@id", SqlDbType.Int).Value = model.ID;
                command.Parameters.Add("@idTask", SqlDbType.Int).Value = idTask;
                command.Parameters.Add("@datework", SqlDbType.Date).Value = model.DateWork;
                command.Parameters.Add("@status", SqlDbType.NVarChar).Value = model.Status;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = model.Description;
                command.Parameters.Add("@request", SqlDbType.NVarChar).Value = model.Request;
                command.ExecuteNonQuery();
            }
        }

        public void UpdatePrecentProject(int idProject)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec PercentProject @idProject";
                command.Parameters.Add("idProject", SqlDbType.Int).Value = idProject;
                command.ExecuteNonQuery();
            }
        }

        public void UpdateStatusDeveloper(int idDev)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec UpdateStatusDeveloper @id";
                command.Parameters.Add("id", SqlDbType.Int).Value = idDev;
                command.ExecuteNonQuery();
            }
        }

        public void UpdateStatusProject(int idProject)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec UpdateStatusProject @idProject";
                command.Parameters.Add("idProject", SqlDbType.Int).Value = idProject;
                command.ExecuteNonQuery();
            }
        }
        public void UpdatePercentTask(int idTask)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec PercentTask @idTask";
                command.Parameters.Add("idTask", SqlDbType.Int).Value = idTask;
                command.ExecuteNonQuery();
            }
        }

        public int IDTaskByIDDetailTask(int idDetailTask)
        {
            int id = 0;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"select dbo.ReturnIDTask('" + idDetailTask + "')";
                id = (int)command.ExecuteScalar();
            }
            return id;
        }

        public int CheckAddOrUpdate(int idTask,int idDev)
        {
            int id = 0;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"select dbo.CheckAddOrUpdate(@idTask,@iddev)";
                command.Parameters.Add("@idTask", SqlDbType.Int).Value = idTask;
                command.Parameters.Add("@iddev", SqlDbType.Int).Value = idDev;
                id = (int)command.ExecuteScalar();
            }
            return id;
        }

        public void RemoveDetailTask(int idDetailTask)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec deleteDetailTask @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = idDetailTask;
                command.ExecuteNonQuery();
            }
        }
    }
}
