using Project_1.Models;
using Project_1.Repositories;
using Project_1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1.Presenters
{
    public class MainPresenter
    {
        private IMainView main;
        private readonly string sqlConnectionString;
        public int id;

        public MainPresenter(IMainView main, string sqlConnectionString,bool role, string name,int iduser)
        {
            this.main = main;
            this.sqlConnectionString = sqlConnectionString;
            this.main.name = name;
            this.main.role = role;
            this.id = iduser;
            this.main.ShowProject += ShowProjectView;
            this.main.ShowTask += ShowTasksView;
            this.main.ShowProfile += ShowProfileView;
            this.main.ShowLogin += ShowLoginView;
            this.main.ShowExcel += ShowStatisticalView;
            this.main.Show();
        }

        private void ShowLoginView(object sender, EventArgs e)
        {
            ILoginView view = new LoginView();
            ILoginRepository reponsitory = new LoginRepository(sqlConnectionString);
            new LoginPresenter(view, reponsitory, sqlConnectionString);
        }

        private void ShowStatisticalView(object sender, EventArgs e)
        {
            IStatisticalView statistical = StatisticalView.GetInstace((Form)main);
            new StatisticalPresenter(statistical, sqlConnectionString);
        }

        private void ShowProfileView(object sender, EventArgs e)
        {
            IDeveloper developer = ProfileView.GetInstace((Form)main);
            IDeveloperRepositoty developerRepositoty = new DeveloperRepository(sqlConnectionString);
            new DeveloperPresenter(developer, developerRepositoty, sqlConnectionString,id,main.role);
        }

        private void ShowTasksView(object sender, EventArgs e)
        {
            ITaskView view = TaskView.GetInstace((Form)main);
            new TaskPresenter(view,sqlConnectionString, main.role,0,id);
        }

        private void ShowProjectView(object sender, EventArgs e)
        {
            IProjectView view = ProjectView.GetInstace((Form)main); 
            new ProjectPresenter(view,id,sqlConnectionString,main,main.role);
        }
    }
}
