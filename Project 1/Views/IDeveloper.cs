using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.Views
{
    public interface IDeveloper
    {
        string Message { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string name { get; set; }
        string role { get; set; }
        string bestTool { get; set; }
        string gender { get; set; }
        string email { get; set; }
        string status { get; set; }
        string phone { get; set; }
        string address { get; set; }
        event EventHandler ChangePassword;
        event EventHandler EditEvent;
        event EventHandler SaveEvent;
        void Show();
    }
}
