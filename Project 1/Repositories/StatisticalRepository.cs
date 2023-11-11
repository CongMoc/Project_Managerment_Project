using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Project_1.Models;
using System.Reflection;

namespace Project_1.Repositories
{
    public class StatisticalRepository : BaseRepository, IStatisticalRepository
    {
        public StatisticalRepository(string sqlConnectionString) 
        {
            this.connectionString = sqlConnectionString;
        }
        public IEnumerable<DeveloperModel> developerModels(string status)
        {
            var developerModels= new List<DeveloperModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec StatisticalDeveloper @status";
                command.Parameters.Add("@status", SqlDbType.NVarChar).Value = status;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var model = new DeveloperModel();
                        model.ID = Convert.ToInt32(reader[0]);
                        model.Name = reader[1].ToString();
                        model.Gender = reader[2].ToString();
                        model.Email = reader[3].ToString();
                        model.Role = reader[4].ToString();
                        model.BestTool = reader[5].ToString();
                        model.Status = reader[6].ToString();
                        model.Phone = reader[7].ToString();
                        model.Address = reader[8].ToString();
                        developerModels.Add(model);
                    }
                }
            }
            return developerModels;
        }

        public IEnumerable<ProjectModel> projectModels(DateTime start, DateTime end)
        {
            var List = new List<ProjectModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec StatisticalProject @start,@end";
                command.Parameters.Add("@start", SqlDbType.Date).Value = start;
                command.Parameters.Add("@end", SqlDbType.Date).Value = end;
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

        public IEnumerable<TaskModel> taskModels(DateTime start, DateTime end)
        {
            var list = new List<TaskModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec StatisticalTask @start,@end";
                command.Parameters.Add("@start", SqlDbType.Date).Value = start;
                command.Parameters.Add("@end", SqlDbType.Date).Value = end;
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
                        Model.Complete = DateTime.Parse(reader[7].ToString());
                        Model.Status = reader[8].ToString();
                        Model.Percent = float.Parse(reader[9].ToString());
                        Model.Description = reader[10].ToString();
                        list.Add(Model);
                    }
                }
            }
            return list;
        }
    }
}
