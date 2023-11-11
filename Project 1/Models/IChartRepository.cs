using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.Models
{
    public interface IChartRepository
    {
        bool LoadDataProject(DateTime startDate,DateTime endDate,int idProject);
        bool LoadDataTask(DateTime startDate, DateTime endDate, int idTask);
        bool LoadDateTaskWithDev(DateTime startDate,DateTime endDate,int idTask);
    }
}
