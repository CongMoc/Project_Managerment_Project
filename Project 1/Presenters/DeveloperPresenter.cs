using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_1.Models;
using Project_1.Repositories;
using Project_1.Views;

namespace Project_1.Presenters
{
    public class DeveloperPresenter
    {
        private IDeveloper developer;
        private IDeveloperRepositoty repositoty;
        private DeveloperModel model;
        private int idDev;
        private readonly string sqlconnectionString;
        private bool Role;
        public DeveloperPresenter(IDeveloper developer, IDeveloperRepositoty repositoty,string sqlConnectionString, int idDev,bool role)
        {
            this.model = new DeveloperModel();
            this.developer = developer;
            this.repositoty = repositoty;
            this.sqlconnectionString = sqlConnectionString;
            this.idDev = idDev;
            this.Role = role;
            this.developer.EditEvent += LoadFieldsInformationDev;
            this.developer.SaveEvent += SaveFieldsDev;
            this.developer.ChangePassword += ChangePasswordView;
            LoadAllInformationDev();
            this.developer.Show();
        }

        private void LoadAllInformationDev()
        {
            repositoty.ShowInformation(model, idDev);
            developer.name = model.Name;
            developer.phone = model.Phone;
            developer.email = model.Email;
            developer.address = model.Address;
            developer.gender = model.Gender;
            developer.status = model.Status;
            developer.role = model.Role;
            developer.bestTool = model.BestTool;
            new Common.ModelDataValidation().Validate(model);
        }

        private void ChangePasswordView(object sender, EventArgs e)
        {
            ILoginView change = ChangePassView.GetInstace();
            ILoginRepository repository = new LoginRepository(sqlconnectionString);
            new ChangerPassPresenter(change, repository, sqlconnectionString, developer.email, Role,false);
        }

        private void SaveFieldsDev(object sender, EventArgs e)
        {
            var modelDev = new DeveloperModel();
            modelDev.ID = idDev;
            modelDev.Name = developer.name;
            modelDev.Phone = developer.phone;
            modelDev.Gender = developer.gender;
            modelDev.Address = developer.address;
            modelDev.Role = developer.role; 
            modelDev.BestTool = developer.bestTool;
            modelDev.Status = developer.status;
            modelDev.Email = developer.email;
            if(developer.IsEdit)
            {
                try
                {
                    new Common.ModelDataValidation().Validate(modelDev);
                    repositoty.Edit(modelDev, idDev);
                    developer.IsSuccessful = true;
                    developer.Message = "Updated information successfully!!!";
                }
                catch(Exception ex)
                {
                    developer.Message = ex.Message;
                    developer.IsSuccessful = false;
                }
            }
        }

        private void LoadFieldsInformationDev(object sender, EventArgs e)
        {
            if (developer is null)
            {
                developer.IsEdit = false;
            }
            else
            {
                developer.IsEdit = true;
            }
        }
    }
}
