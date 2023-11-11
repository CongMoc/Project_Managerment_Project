using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.Views
{
    public interface IMainView
    {
        //Properties
        bool check { get; set; }
        bool role { get; set; }
        string name { get; set; }
        //Events
        event EventHandler ShowProject;
        event EventHandler ShowProfile;
        event EventHandler ShowTask;
        event EventHandler ShowExcel;
        event EventHandler ShowLogin;
        void Show();
    }
}
