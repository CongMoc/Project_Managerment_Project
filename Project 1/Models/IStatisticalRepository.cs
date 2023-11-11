using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.Models
{
    public interface IStatisticalRepository
    {
        IEnumerable<ProjectModel> projectModels(DateTime start,DateTime end);
        IEnumerable<TaskModel> taskModels(DateTime start,DateTime end);
        IEnumerable<DeveloperModel> developerModels(string status);
    }
}
