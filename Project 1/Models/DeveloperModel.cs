using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.Models
{
    public class DeveloperModel
    {
        //Fields
        private int id;
        private string name;
        private string gender;
        private string email;
        private string role;
        private string bestTool;
        private string status;
        private string phone;
        private string address;
        //Properties
        [DisplayName("ID")]
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        [DisplayName("Name")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        [DisplayName("Gender")]
        [Required(ErrorMessage = "Gender is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Gender must be between 2 and 50 characters")]
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        [DisplayName("Email")]
        [Required(ErrorMessage = "Email is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Email must be between 2 and 50 characters")]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        [DisplayName("Role")]
        [Required(ErrorMessage = "Role is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Role must be between 2 and 50 characters")]
        public string Role
        {
            get { return role; }
            set { role= value; }
        }
        [DisplayName("Best Tool")]
        [Required(ErrorMessage = "Best tool is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Best tool must be between 2 and 50 characters")]
        public string BestTool
        {
            get { return bestTool; }
            set { bestTool = value; }
        }
        [DisplayName("Status")]
        [Required(ErrorMessage = "Status is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Status must be between 2 and 50 characters")]
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        [DisplayName("Phone")]
        [Required(ErrorMessage = "Phone is required")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Role must be between 2 and 50 characters")]
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        [DisplayName("Address")]
        [Required(ErrorMessage = "Address is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Address must be between 2 and 50 characters")]
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
    }
}
