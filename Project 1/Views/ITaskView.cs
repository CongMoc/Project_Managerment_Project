using Project_1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1.Views
{
    public interface ITaskView
    {
        //Properties
        string idTask { get; set; }
        string idProject { get; set; }
        string nameTask { get; set; }
        string nameProject { get; set; }
        string descriptionTask { get; set; }
        DateTime start { get; set; }
        DateTime end { get; set; }
        DateTime datework { get; set; }
        string percent { get; set; }
        string request { get; set; }
        string status { get; set; }
        string Message { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string nameDev { get; set; }
        string idDev { get; set; }
        string role { get; set; }
        string bestTool { get; set; }
        string SearchValue { get; set; }
        //Events
        event EventHandler LoadForm;
        event EventHandler ShowAddTask;
        event EventHandler AddNewEvent;
        event EventHandler SearchEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        event EventHandler DeleteEvent;
        event EventHandler EditEvent;
        void SetdataSourceForComboBox(BindingSource source);
        void SetDataForChart(List<ChartRepository.RevenueByDate> grossRevenueList);
        void Show();
    }
}
