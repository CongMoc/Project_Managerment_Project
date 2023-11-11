using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1.Models
{
    public interface IDeveloperRepositoty
    {
        void ShowInformation(DeveloperModel model,int idDev);
        void Edit(DeveloperModel model, int idDev);
    }
}
