using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.Models
{
    public class LoginModel
    {
        private string email;
        private string password;
        private string role;
        private string name;
        //Properties - Validations  
        [Required(ErrorMessage = "Email is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Email must be between 2 and 50 characters and have '@gmail.com'")]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        [Required(ErrorMessage = "Password is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Password must be between 3 and 50 characters")]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        [Required(ErrorMessage = "Role is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Role must be between 3 and 50 characters")]
        public string Role
        {
            get { return role; }
            set { role = value; }
        }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
