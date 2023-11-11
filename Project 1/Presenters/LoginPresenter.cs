using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using Project_1.Models;
using Project_1.Views;
using Project_1.Repositories;

namespace Project_1.Presenters
{
    public class LoginPresenter
    {
        private ILoginView login;
        private ILoginRepository repository;
        private string sqlConnectionString;
        public LoginPresenter(ILoginView login, ILoginRepository repository, string sqlConnectionString)
        {
            this.login = login;
            this.repository = repository;
            this.sqlConnectionString = sqlConnectionString;
            this.login.Login += LoginUser;
            this.login.ShowMainView += ShowMainView;
            this.login.ShowRegisterView += ShowRegisterView;
            this.login.ShowPassWord += ShowForgotView;
            this.login.Show();
        }

        private void ShowForgotView(object sender, EventArgs e)
        {
            ILoginView forgot = new Re_issuePassView();
            ILoginRepository forgotRepository = new LoginRepository(sqlConnectionString);
            new ForgotPasswordPresenter(forgot, forgotRepository,sqlConnectionString,login.role);
        }

        private void ShowRegisterView(object sender, EventArgs e)
        {
            ILoginView view = new RegisterView();
            new RegisterPresenter(view, sqlConnectionString);
        }

        private void ShowMainView(object sender, EventArgs e)
        {
            int id = repository.OutputID(login.email);
            IMainView view = new MainView();
            new MainPresenter(view, sqlConnectionString, login.role,repository.NameDeveloper(login.email), id);
        }

        private void LoginUser(object sender, EventArgs e)
        {
            new Common.ModelDataValidation().Validate(login);
            int checklogin = repository.TestEmailAndPass(login.email, login.password);
            try
            {
                if (checklogin == 0)
                {
                    login.IsSuccessful = true;
                    login.role = repository.CheckRole(login.email);
                    login.Message = "Logined Successfully!!!";
                }
                else
                {
                    login.IsSuccessful = false;
                    if (checklogin == 1)
                    {
                        login.Message = "Password is wrong!!!";
                    }
                    else if (checklogin == 2)
                    {
                        login.Message = "Email is wrong!!!";
                    }
                    else if (checklogin == 4)
                    {
                        login.Message = "Email and password is wrong!!!";
                    }
                    else
                    {
                        login.Message = "Email is invalid!!!";
                    }
                }
            }
            catch(Exception ex)
            {
                login.Message = ex.Message;
                login.IsSuccessful = false;
            }
        }
    }
}
