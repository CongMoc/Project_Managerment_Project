using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.Models
{
    public interface ILoginRepository
    {
        void Register(LoginModel login,bool role);
        void Update(string email, string pass,bool role);
        int OutputID(string email);
        int CheckEmail(string email);
        string NameDeveloper(string email);
        int TestEmailAndPass(string email,string password);
        bool CheckRole(string email);
    }
}
