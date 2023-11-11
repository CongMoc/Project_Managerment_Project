using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_1.Models;
using Project_1.Views;
using Project_1.Repositories;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace Project_1.Presenters
{
    public class ManagementTaskPresenter
    {
        private ITaskView task;
        private ITaskRepository taskRepository;
        private BindingSource bindingSource;
        private IEnumerable<TaskModel> taskList;
        private ChartRepository chartRepository;
        private readonly string sqlConnectionString;
        private int idProject;
        public ManagementTaskPresenter(ITaskView task, ITaskRepository taskRepository,string sqlConnectionString,int idproject,string nameProject)
        {
            this.bindingSource = new BindingSource();
            this.task = task;
            this.chartRepository = new ChartRepository(sqlConnectionString);
            this.idProject = idproject;
            this.sqlConnectionString = sqlConnectionString;
            this.task.nameProject = nameProject;
            this.task.idProject = idproject.ToString();
            this.taskRepository = taskRepository;
            this.task.AddNewEvent += AddNewTask;
            this.task.EditEvent += LoadAllFieldsEvents;
            this.task.DeleteEvent += DeleteTask;
            this.task.SearchEvent += SearchTask;
            this.task.LoadForm += LoadAllFieldsForDataSource;
            this.task.SetdataSourceForComboBox(bindingSource);
            LoadAllFields();
            this.task.Show();
        }

        private void LoadAllFieldsForDataSource(object sender, EventArgs e)
        {
            LoadAllFields();
            var MTask = (TaskModel)bindingSource.Current;
            if (MTask != null)
            {
                var refreshData = chartRepository.LoadDataTask(MTask.Start, MTask.Complete, MTask.ID);
                if (refreshData)
                {
                    task.SetDataForChart(chartRepository.GrossRevenueList);
                }
            }
        }
        private void LoadAllFieldsEvents(object sender, EventArgs e)
        {
            var MTask = (TaskModel)bindingSource.Current;
            try
            {
                task.idTask = MTask.ID.ToString();
                task.nameTask = MTask.Task;
                task.nameProject = MTask.Project;
                task.nameDev = MTask.Developer;
                task.descriptionTask = MTask.Description;
                task.start = MTask.Start;
                task.end = MTask.Complete;
                task.percent = MTask.Percent.ToString();
                task.status = MTask.Status;
                task.role = MTask.Role;
                task.bestTool = MTask.BestTool;
                task.request = MTask.Request;
                new Common.ModelDataValidation().Validate(task);
                ITaskView addtask = AddTaskView.GetInstace();
                new AddTaskPresenter(addtask, taskRepository, sqlConnectionString, task.nameProject, idProject, Convert.ToInt32(task.idTask));
            }
            catch (Exception ex)
            {
                task.Message = ex.Message;
            }
        }

        private void LoadAllFields()
        {
            taskList = taskRepository.GetByProjectId(idProject);
            bindingSource.DataSource = taskList;
            taskRepository.UpdateStatusProject(idProject);
            taskRepository.UpdatePrecentProject(idProject);
            
        }

        private void SearchTask(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.task.SearchValue);
            if (emptyValue == false)
            {
                taskList = taskRepository.FindAll(idProject,this.task.SearchValue);
            }
            else
            {
                taskList = taskRepository.GetByProjectId(idProject);
            }
            bindingSource.DataSource = taskList;
        }

        private void DeleteTask(object sender, EventArgs e)
        {
            try
            {
                var projectList = (TaskModel)bindingSource.Current;
                if (projectList is null)
                {
                    task.IsSuccessful = false;
                    task.Message = "False!!!Please choose any task...";
                }
                else
                {
                    taskRepository.Remove(projectList.ID);
                    task.IsSuccessful = true;
                    task.Message = "Deleted successfully";
                    LoadAllFields();
                }
            }
            catch (Exception ex)
            {
                task.IsSuccessful = false;
                task.Message = ex.Message;
            }
        }

        private void AddNewTask(object sender, EventArgs e)
        {
            ITaskView addtask = AddTaskView.GetInstace();
            new AddTaskPresenter(addtask, taskRepository, sqlConnectionString,task.nameProject,idProject, 0);
        }
    }
}
