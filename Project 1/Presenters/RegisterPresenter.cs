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
    public class RegisterPresenter
    {
        private ILoginView Login;
        private ILoginRepository repository;
        private readonly string sqlConnectionString;

        public RegisterPresenter(ILoginView login, string sqlConnectionString)
        {
            this.Login = login;
            this.repository = new LoginRepository(sqlConnectionString);
            this.Login.Register += RegisterDEV;
            this.Login.ShowLoginView += ShowLoginViewCancel;
            this.Login.Show();
        }

        private void ShowLoginViewCancel(object sender, EventArgs e)
        {
            ILoginView loginView = new LoginView();
            ILoginRepository loginRepository = new LoginRepository(sqlConnectionString);
            new LoginPresenter(loginView, loginRepository, sqlConnectionString);
        }

        private void RegisterDEV(object sender, EventArgs e)
        {
            var register = new LoginModel();
            register.Name = Login.name;
            register.Password = Login.password;
            register.Email = Login.email;
            register.Role = Login.roletool;
            if(Login.roletool == "Project Manager")
            {
                Login.role = true;
            }
            else
            {
                Login.role = false;
            }
            try
            {
                new Common.ModelDataValidation().Validate(register);
                int checklogin = repository.TestEmailAndPass(Login.email, Login.password);
                if (checklogin == 4 || checklogin ==2)
                {
                    Login.IsSuccessful = true;
                    repository.Register(register, Login.role);
                    Login.Message = "Registed Successfully!!!";
                }
                else
                {
                    Login.IsSuccessful = false;
                    Login.Message = "Email is invalid!!!";
                }
            }
            catch (Exception ex)
            {
                Login.Message = ex.Message;
                Login.IsSuccessful = false;
            }
        }
    }
}
