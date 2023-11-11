using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_1.Models;
using Project_1.Views;
using Project_1.Repositories;

namespace Project_1.Presenters
{
    public class AddProjectPresenter
    {
        private IProjectView view;
        private IProjectRepository repository;
        private int idManager;
        public AddProjectPresenter(IProjectView view, IProjectRepository repository, int idManager)
        {
            this.view = view;
            this.repository = repository;
            this.idManager = idManager;
            this.view.SaveValue += SaveNewFields;
            this.view.Show();
        }


        private void SaveNewFields(object sender, EventArgs e)
        {
            var model = new ProjectModel();
            model.ID = Convert.ToInt32(view.id);
            model.Project = view.nameProject;
            model.Start = view.start;
            model.Complete =view.end;
            model.Status = view.status;
            model.Description = view.description;
            try
            {
                new Common.ModelDataValidation().Validate(model);
                repository.AddProject(model, idManager);
                view.IsSuccessful = true;
                view.Message = "Added project successfully!!!";
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }
    }
}
