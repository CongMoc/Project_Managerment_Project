using Project_1.Models;
using Project_1.Repositories;
using Project_1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.Presenters
{
    public class ChangerPassPresenter
    {
        private ILoginView change;
        private ILoginRepository repository;
        private string sqlConnectionString;
        public ChangerPassPresenter(ILoginView change, ILoginRepository repository,string sqlconnectionString,string email,bool Role,bool Check)
        {
            this.change = change;
            this.repository = repository;
            this.change.email = email;
            this.change.IsEdit = Check;
            this.change.role = Role;
            this.sqlConnectionString = sqlconnectionString;
            this.change.UpdatePassword += ChangePassword;
            this.change.ShowLoginView += BackToLoginView;
            this.change.Show();
        }

        private void ChangePassword(object sender, EventArgs e)
        {
            try
            {
                repository.Update(change.email, change.password,change.role);
                change.Message = "Changed password successfully!!!";
                change.IsSuccessful = true;
            }
            catch(Exception ex)
            {
                change.Message = ex.Message;  
                change.IsSuccessful = false;
            }
        }

        private void BackToLoginView(object sender, EventArgs e)
        {
            ILoginView login = new LoginView();
            ILoginRepository loginRepository = new LoginRepository(sqlConnectionString);
            new LoginPresenter(login, loginRepository, sqlConnectionString);
        }
    }
}
