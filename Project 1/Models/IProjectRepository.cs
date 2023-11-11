using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1.Models
{
    public interface IProjectRepository
    {
        void AddProject(ProjectModel moidel,int id);
        void UpdateProject(ProjectModel project, int id);
        void Delete(int idProject);
        IEnumerable<ProjectModel> GetAll(int idManager);
        IEnumerable<ProjectModel> GetStatus(int id,string status);
        IEnumerable<ProjectModel> GetOwner(string NameManager);
        IEnumerable<ProjectModel> SearchByValue(int id,string value);

    }
}
