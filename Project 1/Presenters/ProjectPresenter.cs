using Project_1.Models;
using Project_1.Presenters.Common;
using Project_1.Repositories;
using Project_1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Project_1.Presenters
{
    public class ProjectPresenter
    {
        private IProjectView project;
        private IProjectRepository repository;
        private string sqlConnectionString;
        private BindingSource bindingSource;
        private IEnumerable<ProjectModel> projects;
        private IMainView main;
        private ChartRepository chartRepository;
        public int idUser;
        public ProjectPresenter(IProjectView project, int iduser, string sqlconnectionString,IMainView main,bool role)
        {
            this.project = project;
            this.idUser = iduser;
            this.main = main;
            this.project.Role = role;
            this.bindingSource = new BindingSource();
            this.chartRepository = new ChartRepository(sqlconnectionString);
            this.sqlConnectionString = sqlconnectionString;
            this.repository = new ProjectReponsitory(sqlConnectionString);
            this.project.AddProject += AddNewEvent;
            this.project.UpdateProject += LoadAllPorject;
            this.project.SearchEvent += SearchProject;
            this.project.RemoveProject += RemoveProjects;
            this.project.SaveValue += SaveProjects;
            this.project.Cancel += CancelProjects;
            this.project.StatusEvent += StatusSelectedValue;
            this.project.OwnerEvent += ManagerProject;
            this.project.ShowManagementTask += ShowManagementTaskView;
            this.project.LoadProject += LoadProjectAfterUpdate;
            this.project.ShowTask += ShowTaskForDeveloper;
            this.project.LoadDataForChart += ShowListItemForChart;
            this.project.SetDataForDataGridView(bindingSource);
            LoadAllListProject();
            ClearFieldsProject();
            this.project.Show();
        }

        private void ShowListItemForChart(object sender, EventArgs e)
        {
            var refreshData = chartRepository.LoadDataProject(project.start, project.end, Convert.ToInt32(project.id));
            if(refreshData)
            {
                project.SetDataForChart(chartRepository.GrossRevenueList);
            }
            var refreshDataDev = chartRepository.LoadDateTaskWithDev(project.start, project.end, Convert.ToInt32(project.id));
            if (refreshDataDev)
            {
                project.SetDateForProcessDeveloper(chartRepository.GrossRevenueDeveloperList);
            }
        }

        private void ShowTaskForDeveloper(object sender, EventArgs e)
        {
            ITaskView taskView = TaskView.GetInstace((Form)main);
            new TaskPresenter(taskView, sqlConnectionString, project.Role,Convert.ToInt32(project.id),idUser);
        }

        private void LoadProjectAfterUpdate(object sender, EventArgs e)
        {
            LoadAllListProject();
        }

        private void ClearFieldsProject()
        {
            project.nameProject = "";
            project.status = "";
            project.percent = "0";
            project.description = "";
        }

        private void CancelProjects(object sender, EventArgs e)
        {
            ClearFieldsProject();
        }

        private void SaveProjects(object sender, EventArgs e)
        {
            var Project = new ProjectModel();
            Project.ID = Convert.ToInt32(project.id);
            Project.Project = project.nameProject;
            Project.Start = project.start;
            Project.Complete = project.end;
            Project.Status = project.status;
            Project.Percent = float.Parse(project.percent);
            Project.Description = project.description;
            try
            {
                if (project.IsEdit)
                {
                    repository.UpdateProject(Project, idUser);
                    project.Message = "Updated project successfully!!!";
                    project.IsSuccessful = true;
                    LoadAllListProject();
                    ClearFieldsProject();
                }
            }
            catch(Exception ex)
            {
                project.Message = ex.Message; 
                project.IsSuccessful = false;
            }
        }

        private void LoadAllListProject()
        {
            projects = repository.GetAll(idUser);
            bindingSource.DataSource = projects;
        }

        private void ManagerProject(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.project.OwnerProject);
            if (emptyValue == false)
            {
                projects = repository.GetOwner(this.project.OwnerProject);
            }
            else
            {
                projects = repository.GetAll(idUser);
            }
            bindingSource.DataSource = projects;
        }

        private void StatusSelectedValue(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.project.StatusProject);
            if (emptyValue == false)
            {
                projects = repository.GetStatus(idUser,this.project.StatusProject);
            }
            else
            {
                projects = repository.GetAll(idUser);
            }
            bindingSource.DataSource = projects;
        }

        private void RemoveProjects(object sender, EventArgs e)
        {
            try
            {
                var projectList = (ProjectModel)bindingSource.Current;
                if (projectList != null)
                {
                    repository.Delete(projectList.ID);
                    project.IsSuccessful = true;
                    project.Message = "Project deleted successfully";
                    LoadAllListProject();
                }
                else
                {
                    project.IsSuccessful = false;
                    project.Message = "False!!!Please choose any project before delete";
                }
            }
            catch (Exception ex)
            {
                project.IsSuccessful = false;
                project.Message = ex.Message ;
            }
        }

        private void SearchProject(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.project.SearchValue);
            if (emptyValue == false)
            {
                projects = repository.SearchByValue(idUser,this.project.SearchValue);
            }
            else
            {
                projects = repository.GetAll(idUser);
            }
            bindingSource.DataSource = projects;
        }

        private void LoadAllPorject(object sender, EventArgs e)
        {
            var Project = (ProjectModel)bindingSource.Current;
            if (Project is null)
            {
                project.Message = "Please choose any project!!!";
            }
            else
            {
                project.id = Project.ID.ToString();
                project.nameProject = Project.Project.ToString();
                project.start = DateTime.Parse(Project.Start.ToString());
                project.end = DateTime.Parse(Project.Complete.ToString());
                project.status = Project.Status;
                project.percent = Project.Percent.ToString();
                project.description = Project.Description.ToString();
                project.IsEdit = true;
            }
        }

        private void AddNewEvent(object sender, EventArgs e)
        {
            project.IsEdit = false;
            IProjectView addProject = AddProjectView.GetInstace();
            IProjectRepository repository = new ProjectReponsitory(sqlConnectionString);
            new AddProjectPresenter(addProject, repository, idUser);
        }

        private void ShowManagementTaskView(object sender, EventArgs e)
        {
            ITaskView managertask = ManagementTask.GetInstace();
            ITaskRepository taskRepository = new TaskRepository(sqlConnectionString);
            new ManagementTaskPresenter(managertask, taskRepository, sqlConnectionString,Convert.ToInt32(project.id),project.nameProject);
        }
    }
}
