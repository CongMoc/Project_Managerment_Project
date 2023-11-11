using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1.Views
{
    public interface IStatisticalView
    {
        string Message { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        DateTime start { get; set; }
        DateTime end { get; set; }
        string StatusDev { get; set; }
        event EventHandler ShowStatisticalProject;
        event EventHandler ShowStatisticalTask;
        event EventHandler ShowStatisticalDeveloper;
        void SetDataForDataGridView(BindingSource source);
        void Show();
    }
}
