using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.Models
{
    public interface ITaskRepository
    {
        void Add(TaskModel model,int Developer,int idProject);
        void AddDetailTask(TaskModel model, int idProject,int idDeveloper,int idTask);
        void Update(TaskModel model, int idDeveloper,int idProject);
        void UpdateDetailTask(TaskModel model,int idTask);
        void Remove(int idTask);
        void RemoveDetailTask(int idDetailTask);
        int IDDeveloper(int idTask);
        void UpdateStatusProject(int idProject);
        void UpdatePrecentProject(int idProject);
        void UpdatePercentTask(int idTask);
        void UpdateStatusDeveloper(int idDev);
        int IDDeveloperByName(string name);
        int IDProjectByIDTask(int idTask);
        int IDTaskByIDDetailTask(int idDetailTask);
        int CheckAddOrUpdate(int idTask,int idDev);
        IEnumerable<TaskModel> ShowDeveloperFree();
        IEnumerable<TaskModel> GetAll();
        IEnumerable<TaskModel> GetByProjectId(int projectId);
        IEnumerable<TaskModel> GetAllManagementTask(int idDeveloper);
        TaskModel GetTask(int idTask,int idProject);
        IEnumerable<TaskModel> FindAll(int idProject,string value);
    }
}
