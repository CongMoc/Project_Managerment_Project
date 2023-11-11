using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.Views
{
    public interface ILoginView
    {
        //Properties
        string email { get; set; }
        string password { get; set; }
        string name { get; set; }
        string roletool { get; set; }   
        bool role { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }
        //Events
        event EventHandler Login;
        event EventHandler ShowLoginView;
        event EventHandler ShowMainView;
        event EventHandler Register;
        event EventHandler ShowRegisterView;
        event EventHandler ForgotPassword;
        event EventHandler ShowPassWord;
        event EventHandler UpdatePassword;
        event EventHandler ShowUpdatePasswordView;
        void Show();
    }
}
