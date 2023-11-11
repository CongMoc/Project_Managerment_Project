using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_1.Models;
using Project_1.Views;
using Project_1.Repositories;
using System.Windows.Forms;

namespace Project_1.Presenters
{
    public class AddTaskPresenter
    {
        private ITaskView Addtask;
        private ITaskRepository taskRepository;
        private BindingSource bindingSource;
        private IEnumerable<TaskModel> developers;
        private int idDev;
        private int idProject;
        private readonly string sqlConnectionstring;
        private static int IDTask;
        public AddTaskPresenter(ITaskView addtask, ITaskRepository taskRepository,string sqlconnectionString,string nameProject,int idproject,int idTask)
        {
            this.bindingSource = new BindingSource();
            this.Addtask = addtask;
            this.Addtask.nameProject = nameProject;
            this.sqlConnectionstring = sqlconnectionString;
            this.taskRepository = taskRepository;
            this.Addtask.idTask = idTask.ToString();
            this.idProject = idproject;
            IDTask = idTask;
            this.Addtask.SaveEvent += SaveTaskForDEV;
            this.Addtask.ShowAddTask += ShowManagementTask;
            this.Addtask.SetdataSourceForComboBox(bindingSource);
            this.Addtask.LoadForm += LoadFromAgain;
            LoadAllFields();
            this.Addtask.Show();
        }

        private void ShowManagementTask(object sender, EventArgs e)
        {
            ITaskView manager = ManagementTask.GetInstace();
            new ManagementTaskPresenter(manager, taskRepository, sqlConnectionstring, idProject, Addtask.nameProject);
            taskRepository.UpdateStatusDeveloper(idDev);
        }

        private void LoadFromAgain(object sender, EventArgs e)
        {
            LoadAllFields();
        }

        private void ClearAllFields()
        {
            Addtask.nameTask = "";
            Addtask.descriptionTask = "";
            Addtask.start = DateTime.Now;
            Addtask.end = DateTime.Now;
            Addtask.request = "";
        }

        private void LoadAllFields()
        {
            if(IDTask == 0)
            {
                ClearAllFields();
                Addtask.IsEdit = false;
                developers = taskRepository.ShowDeveloperFree();
                bindingSource.DataSource = developers;
            }
            else
            {
                var list = taskRepository.GetTask(IDTask, idProject);
                new Common.ModelDataValidation().Validate(list);
                Addtask.nameTask = list.Task;
                Addtask.nameProject = list.Project;
                Addtask.nameDev = list.Developer;
                Addtask.role = list.Role;
                Addtask.descriptionTask = list.Description;
                Addtask.bestTool = list.BestTool;
                Addtask.status = list.Status;
                Addtask.start = list.Start;
                Addtask.end = list.Complete;
                Addtask.request = list.Request;
                Addtask.IsEdit = true;
            }
        }

        private void SaveTaskForDEV(object sender, EventArgs e)
        {
            var task = new TaskModel();
            task.ID = Convert.ToInt32(Addtask.idTask);
            task.Task = Addtask.nameTask;
            task.Developer = Addtask.nameDev;
            task.Role = Addtask.role;
            task.BestTool = Addtask.bestTool;
            task.Status = Addtask.status;
            task.Project = Addtask.nameProject;
            task.Start = Addtask.start;
            task.Status = Addtask.status;
            task.Complete  = Addtask.end;
            task.Description = Addtask.descriptionTask;
            task.Request = Addtask.request;
            idDev = taskRepository.IDDeveloperByName(Addtask.nameDev);
            Addtask.idDev = idDev.ToString();
            try
            {
                new Common.ModelDataValidation().Validate(task);
                if(Addtask.IsEdit)
                {
                    taskRepository.Update(task, idDev, idProject);
                    Addtask.Message = "Updated task successfully!!!";
                    Addtask.IsSuccessful = true;
                }
                else
                {
                    taskRepository.Add(task, idDev,idProject);
                    Addtask.Message = "Added task successfully!!!";
                    Addtask.IsSuccessful = true;
                }
            }
            catch (Exception ex) 
            {
                Addtask.IsSuccessful = false;
                Addtask.Message = ex.Message;
            }
        }
    }
}
