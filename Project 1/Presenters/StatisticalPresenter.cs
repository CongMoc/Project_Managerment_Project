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
    public class StatisticalPresenter
    {
        private IStatisticalView view;
        private IEnumerable<TaskModel> taskModel;
        private IEnumerable<ProjectModel> projectModel;
        private IEnumerable<DeveloperModel> developerModel;
        private IStatisticalRepository repository;
        private BindingSource bindingSource;

        public StatisticalPresenter(IStatisticalView view, string sqlConnectionString)
        {
            this.view = view;
            this.bindingSource = new BindingSource();
            this.repository = new StatisticalRepository(sqlConnectionString);
            this.view.ShowStatisticalProject += StatisticalProject;
            this.view.ShowStatisticalDeveloper += StatisticalDeveloper;
            this.view.ShowStatisticalTask += StatisticalTask;
            this.view.SetDataForDataGridView(bindingSource);
            this.view.Show();
        }

        private void StatisticalTask(object sender, EventArgs e)
        {
            try
            {
                if (view.start < view.end)
                {
                    taskModel = repository.taskModels(view.start, view.end);
                    bindingSource.DataSource = taskModel;
                    view.IsSuccessful = true;
                }
                else
                {
                    view.IsSuccessful = false;
                    view.Message = "Start date must to more than end date!!!";
                }
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void StatisticalDeveloper(object sender, EventArgs e)
        {
            try
            {
                developerModel = repository.developerModels(view.StatusDev);
                bindingSource.DataSource = developerModel;
                view.IsSuccessful = true;
            }
            catch(Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void StatisticalProject(object sender, EventArgs e)
        {
            try
            {
                if (view.start < view.end)
                {
                    projectModel = repository.projectModels(view.start, view.end);
                    bindingSource.DataSource = projectModel;
                    view.IsSuccessful = true;
                }
                else
                {
                    view.IsSuccessful = false;
                    view.Message = "Start date must to more than end date!!!";
                }
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }
    }
}
