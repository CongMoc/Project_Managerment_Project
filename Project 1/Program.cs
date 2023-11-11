using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_1.Views;
using Project_1.Models;
using Project_1.Presenters;
using Project_1.Repositories;
using System.Configuration;

namespace Project_1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            ILoginView view = new LoginView();
            ILoginRepository reponsitory = new LoginRepository(sqlConnectionString);
            new LoginPresenter(view, reponsitory, sqlConnectionString);
            Application.Run((Form)view);
        }
    }
}
