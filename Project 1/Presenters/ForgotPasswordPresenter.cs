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
    public class ForgotPasswordPresenter
    {
        private ILoginView forgot;
        private ILoginRepository forgotRepository;
        private string sqlConnectionString;
        public ForgotPasswordPresenter(ILoginView forgot, ILoginRepository forgotRepository,string sqlconnectionString,bool Role)
        {
            this.forgot = forgot;
            this.forgot.role = Role;                 
            this.forgotRepository = forgotRepository;
            this.forgot.ForgotPassword += CheckEmailBeforeChangePass;
            this.forgot.ShowUpdatePasswordView += ShowChangePassView;
            this.forgot.ShowLoginView += Showlogin;
            this.sqlConnectionString = sqlconnectionString;
            this.forgot.Show();
        }

        private void Showlogin(object sender, EventArgs e)
        {
            ILoginView login = new LoginView();
            ILoginRepository loginRepository = new LoginRepository(sqlConnectionString);
            new LoginPresenter(login,loginRepository,sqlConnectionString);
        }

        private void ShowChangePassView(object sender, EventArgs e)
        {
            ILoginView login = new ChangePassView();
            new ChangerPassPresenter(login, forgotRepository, sqlConnectionString, forgot.email,forgot.role,true);
        }

        private void CheckEmailBeforeChangePass(object sender, EventArgs e)
        {
            int check = forgotRepository.CheckEmail(forgot.email);
            if(check == 0) 
            {
                forgot.IsEdit = true;
            }
            else if(check == 1)
            {
                forgot.IsEdit = false;
                forgot.Message = "Email is wrong!!!";
            }
            else
            {
                forgot.IsEdit = false;
                forgot.Message = "Email is invaid!!!";
            }
        }

    }
}
