using Project_1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1.Views
{
    public interface IProjectView
    {
        string id { get; set; }
        string nameProject { get; set; }
        string manager { get; set; }
        DateTime start { get; set; }
        DateTime end { get; set; }
        string percent { get; set; }    
        string status { get; set; }
        string description { get; set; }
        string SearchValue { get; set; }
        string StatusProject { get; set; } 
        string OwnerProject { get; set; }
        string Message { get; set; }
        bool Role { get; set; }
        bool IsEdit { get; set; }   
        bool IsSuccessful { get; set; }
        event EventHandler AddProject;
        event EventHandler UpdateProject;
        event EventHandler RemoveProject;
        event EventHandler SearchEvent;
        event EventHandler StatusEvent;
        event EventHandler OwnerEvent;
        event EventHandler SaveValue;
        event EventHandler ShowManagementTask;
        event EventHandler LoadProject;
        event EventHandler ShowTask;
        event EventHandler Cancel;
        event EventHandler LoadDataForChart;
        void SetDataForDataGridView(BindingSource ProjectList);
        void Show();
        void SetDataForChart(List<ChartRepository.RevenueByDate> grossRevenueList);
        void SetDateForProcessDeveloper(List<ChartRepository.RevenueByPercent> grossRevenueList);
    }
}
