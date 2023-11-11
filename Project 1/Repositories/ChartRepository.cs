using Project_1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Project_1.Repositories
{
    public class ChartRepository: BaseRepository,IChartRepository
    {
        public ChartRepository(string sqlConnectionstring) 
        {
            this.connectionString = sqlConnectionstring;
        }
        public struct RevenueByDate
        {
            public string Date { get; set; }
            public float Percent { get; set; }
        }
        public struct RevenueByPercent
        {
            public string Name { get; set; }
            public float Percent { get; set; }
        }
        private int numberDays;
        private DateTime fromDate;
        private DateTime toDate;
        private int idProject;
        private int idTask;
        public List<RevenueByDate> GrossRevenueList { get; private set; }
        public List<RevenueByPercent> GrossRevenueDeveloperList { get; private set; }

        // Private Method 
        private void GetDataProject()
        {
            GrossRevenueList = new List<RevenueByDate>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"exec PercentProcessProject @idProject";
                    command.Parameters.Add("idProject", SqlDbType.Int).Value = idProject;
                    var reader = command.ExecuteReader();
                    var resultTable = new List<KeyValuePair<DateTime, float>>();
                    while(reader.Read())
                    {
                        resultTable.Add(new KeyValuePair<DateTime, float>((DateTime)reader[0], float.Parse(reader[1].ToString())));
                    }
                    reader.Close();

                    //Group by days
                    if(numberDays <= 30)
                    {
                        foreach (var item in resultTable)
                        {
                            GrossRevenueList.Add(new RevenueByDate()
                            {
                                Date = item.Key.ToString("dd MMM"),
                                Percent = item.Value
                            });
                        }
                    }

                    //Group by weeks
                    else if(numberDays <= 92)
                    {
                        GrossRevenueList = (from item in resultTable
                                            group item by CultureInfo.CurrentCulture.Calendar.
                                            GetWeekOfYear(item.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                            into order
                                            select new RevenueByDate
                                            {
                                                Date = "Week" + order.Key.ToString(),
                                                Percent = order.Sum(Percent => Percent.Value)
                                            }).ToList();
                    }

                    else if(numberDays <= (365*2))
                    {
                        bool isYear =numberDays <= 365 ?true : false;
                        GrossRevenueList = (from item in resultTable
                                            group item by item.Key.ToString("MMM yyy")
                                            into order
                                            select new RevenueByDate
                                            {
                                                Date = isYear?order.Key.Substring(0,order.Key.IndexOf(" ")):order.Key,
                                                Percent = order.Sum(Percent => Percent.Value)
                                            }).ToList();
                    }
                    else
                    {
                        GrossRevenueList = (from item in resultTable
                                            group item by item.Key.ToString("yyy")
                                            into order
                                            select new RevenueByDate
                                            {
                                                Date = order.Key,
                                                Percent = order.Sum(Percent => Percent.Value)
                                            }).ToList();
                    }
                }
            }
        }

        private void GetDataTask()
        {
            GrossRevenueList = new List<RevenueByDate>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"exec PercentProcessTask @idTask";
                    command.Parameters.Add("@idTask", SqlDbType.Int).Value = idTask;
                    var reader = command.ExecuteReader();
                    var resultTable = new List<KeyValuePair<DateTime, float>>();
                    while (reader.Read())
                    {
                        resultTable.Add(new KeyValuePair<DateTime, float>((DateTime)reader[0], float.Parse(reader[1].ToString())));
                    }
                    reader.Close();

                    //Group by days
                    if (numberDays <= 30)
                    {
                        foreach (var item in resultTable)
                        {
                            GrossRevenueList.Add(new RevenueByDate()
                            {
                                Date = item.Key.ToString("dd MMM"),
                                Percent = item.Value
                            });
                        }
                    }

                    //Group by weeks
                    else if (numberDays <= 92)
                    {
                        GrossRevenueList = (from item in resultTable
                                            group item by CultureInfo.CurrentCulture.Calendar.
                                            GetWeekOfYear(item.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                            into order
                                            select new RevenueByDate
                                            {
                                                Date = "Week" + order.Key.ToString(),
                                                Percent = order.Sum(Percent => Percent.Value)
                                            }).ToList();
                    }

                    else if (numberDays <= (365 * 2))
                    {
                        bool isYear = numberDays <= 365 ? true : false;
                        GrossRevenueList = (from item in resultTable
                                            group item by item.Key.ToString("MMM yyy")
                                            into order
                                            select new RevenueByDate
                                            {
                                                Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                                                Percent = order.Sum(Percent => Percent.Value)
                                            }).ToList();
                    }
                    else
                    {
                        GrossRevenueList = (from item in resultTable
                                            group item by item.Key.ToString("yyy")
                                            into order
                                            select new RevenueByDate
                                            {
                                                Date = order.Key,
                                                Percent = order.Sum(Percent => Percent.Value)
                                            }).ToList();
                    }
                }
            }
        }
        private void GetDateTaskByDeveloper()
        {
            GrossRevenueDeveloperList = new List<RevenueByPercent>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"exec PercentProcessTaskByDeveloper @idProject";
                    command.Parameters.Add("idProject", SqlDbType.Int).Value = idProject;
                    var reader = command.ExecuteReader();
                    var resultTable = new List<KeyValuePair<string, float>>();
                    while (reader.Read())
                    {
                        resultTable.Add(new KeyValuePair<string, float>(reader[0].ToString(), float.Parse(reader[1].ToString())));
                    }
                    reader.Close();
                    foreach (var item in resultTable)
                    {
                        GrossRevenueDeveloperList.Add(new RevenueByPercent()
                        {
                            Name = item.Key.ToString(),
                            Percent = item.Value
                        });
                    }
                }
            }
        }
        //Public Methods
        public bool LoadDataProject(DateTime startDate,DateTime endDate,int idProject)
        {
            endDate = new DateTime(endDate.Year,endDate.Month,endDate.Day,endDate.Hour,endDate.Minute,59);
            if (startDate != this.fromDate || endDate != this.toDate)
            {
                this.fromDate = startDate;
                this.toDate = endDate;
                this.numberDays = (endDate - startDate).Days;
                this.idProject = idProject;
                GetDataProject();
                Console.WriteLine("Refreshed data: {0} - {1}", startDate.ToString(), endDate.ToString());
                return true;
            }
            else
            {
                Console.WriteLine("Data not refreshed, same query: {0} - {1}",startDate.ToString(),endDate.ToString()); 
                return false;
            }
        }

        public bool LoadDataTask(DateTime startDate, DateTime endDate, int idTask)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, endDate.Hour, endDate.Minute, 59);
            if (startDate != this.fromDate || endDate != this.toDate)
            {
                this.fromDate = startDate;
                this.toDate = endDate;
                this.numberDays = (endDate - startDate).Days;
                this.idTask = idTask;
                GetDataTask();
                Console.WriteLine("Refreshed data: {0} - {1}", startDate.ToString(), endDate.ToString());
                return true;
            }
            else
            {
                Console.WriteLine("Data not refreshed, same query: {0} - {1}", startDate.ToString(), endDate.ToString());
                return false;
            }
        }

        public bool LoadDateTaskWithDev(DateTime startDate, DateTime endDate, int idProject)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, endDate.Hour, endDate.Minute, 59);
            if (startDate != this.fromDate || endDate != this.toDate)
            {
                this.fromDate = startDate;
                this.toDate = endDate;
                this.numberDays = (endDate - startDate).Days;
                this.idProject = idProject;
                GetDateTaskByDeveloper();
                Console.WriteLine("Refreshed data: {0} - {1}", startDate.ToString(), endDate.ToString());
                return true;
            }
            else
            {
                Console.WriteLine("Data not refreshed, same query: {0} - {1}", startDate.ToString(), endDate.ToString());
                return false;
            }
        }
    }
}
