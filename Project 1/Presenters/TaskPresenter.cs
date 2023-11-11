using Project_1.Models;
using Project_1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_1.Models;
using Project_1.Repositories;
using Project_1.Views;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Project_1.Presenters
{
    public class TaskPresenter
    {
        private ITaskView task;
        private ITaskRepository repository;
        private int idProject;
        private int idDev;
        private BindingSource bindingSource;
        private IEnumerable<TaskModel> taskModel;
        private ChartRepository chartRepository;
        private bool Role;
        private DateTime check;
        private int idtask;
        public TaskPresenter(ITaskView view, string sqlConnectionString,bool role,int idProject,int idDev)
        {
            this.bindingSource = new BindingSource();
            this.repository = new TaskRepository(sqlConnectionString);
            this.chartRepository = new ChartRepository(sqlConnectionString);
            this.task = view;
            this.task.idProject = idProject.ToString();
            this.Role = role;
            this.idDev = idDev;
            this.task.EditEvent += LoadFieldsForEvents;
            this.task.DeleteEvent += DeleteFields;
            this.task.SearchEvent += SearchFieldsInList;
            this.task.SaveEvent += SaveFieldsForTaskList;
            this.task.LoadForm += LoadFieldsAgain;
            this.task.ShowAddTask += LoadFieldsForChart;
            this.task.SetdataSourceForComboBox(bindingSource);
            LoadAllFields();
            this.task.Show();
        }

        private void LoadFieldsForChart(object sender, EventArgs e)
        {
            var taskList = (TaskModel)bindingSource.Current;
            task.percent = taskList.Percent.ToString();
            idtask = repository.IDTaskByIDDetailTask(taskList.ID);
            var refreshData = chartRepository.LoadDataTask(taskList.Start, taskList.Complete,idtask);
            if (refreshData)
            {
                task.SetDataForChart(chartRepository.GrossRevenueList);
            }
        }

        private void LoadFieldsAgain(object sender, EventArgs e)
        {
            LoadAllFields();
        }

        private void LoadAllFields()
        {
            if (!Role)
            {
                taskModel = repository.GetAllManagementTask(idDev);
            }
            else
            {
                taskModel = repository.GetAll();
            }
            bindingSource.DataSource = taskModel;   
        }

        private void SearchFieldsInList(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.task.SearchValue);
            if (emptyValue == false)
            {
                taskModel = repository.FindAll(idProject, this.task.SearchValue);
            }
            else
            {
                taskModel = repository.GetAll();
            }
            bindingSource.DataSource =taskModel;
        }

        private void SaveFieldsForTaskList(object sender, EventArgs e)
        {
            var model = new TaskModel();
            model.ID = Convert.ToInt32(task.idTask);
            model.Task = task.nameTask;
            model.Project = task.nameProject;
            model.Role = task.role;
            model.Start = task.start;
            model.Complete = task.end;
            model.Developer = task.nameDev;
            model.Percent = float.Parse(task.percent);
            model.DateWork = task.datework;
            model.Description = task.descriptionTask;
            model.Status = task.status;
            model.BestTool = task.bestTool;
            model.Request = task.request;
            task.idDev = idDev.ToString();
            try
            {
                new Common.ModelDataValidation().Validate(model);
                int edit = repository.CheckAddOrUpdate(idtask, idDev);
                if(task.IsEdit)
                {
                    if (check == model.DateWork && edit == 1)
                    {
                        repository.UpdateDetailTask(model,idtask);
                    }
                    else
                    {
                        repository.AddDetailTask(model, idProject, idDev,idtask);
                    }
                    task.IsSuccessful = true;
                    task.Message = "Updated task successfully!!!";
                    LoadAllFields();
                }
            }
            catch(Exception ex)
            {
                task.IsSuccessful = false;
                task.Message = ex.Message;
            }
        }

        private void DeleteFields(object sender, EventArgs e)
        {
            try
            {
                var taskList = (TaskModel)bindingSource.Current;
                if (taskList != null)
                {
                    repository.RemoveDetailTask(taskList.ID);
                    task.IsSuccessful = true;
                    task.Message = "Task deleted successfully";
                    LoadAllFields();
                }
                else
                {
                    task.IsSuccessful = false;
                    task.Message = "False!!!Please choose any task before delete";
                }
            }
            catch (Exception ex)
            {
                task.IsSuccessful = false;
                task.Message = ex.Message;
            }
        }

        private void LoadFieldsForEvents(object sender, EventArgs e)
        {
            var taskList = (TaskModel)bindingSource.Current;
            task.idTask = taskList.ID.ToString();
            idtask = repository.IDTaskByIDDetailTask(taskList.ID);
            task.idProject = repository.IDProjectByIDTask(idtask).ToString();
            idProject = repository.IDProjectByIDTask(idtask);
            task.nameTask = taskList.Task;
            task.nameProject = taskList.Project;
            task.descriptionTask = taskList.Description;
            task.nameDev = taskList.Developer;
            task.start = taskList.Start;
            task.end = taskList.Complete;
            task.datework = taskList.DateWork;
            task.percent = taskList.Percent.ToString();
            check = taskList.DateWork;
            task.status = taskList.Status;
            task.bestTool = taskList.BestTool;
            task.role = taskList.Role;
            task.request = taskList.Request; 
            task.IsEdit = true;
        }
    }
}
