using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Project_1.Models
{
    public class TaskModel
    {
        private int id;
        private string name;
        private string nameProject;
        private DateTime start;
        private DateTime end;
        private string developer;
        private string roleDev;
        private string bestTool;
        private string status;
        private string description;
        private float percent;
        private DateTime datework;
        private string request;
        //Properties
        [DisplayName("ID")]
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        [DisplayName("Task")]
        [Required(ErrorMessage = "Task is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Task must be between 2 and 50 characters")]
        public string Task
        {
            get { return name; }
            set { name = value; }
        }
        [DisplayName("Project")]
        [Required(ErrorMessage = "Project is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Project must be between 2 and 50 characters")]
        public string Project
        {
            get { return nameProject; }
            set { nameProject = value; }
        }
        [DisplayName("Developer")]
        [Required(ErrorMessage = "Developer is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Developer must be between 2 and 50 characters")]
        public string Developer
        {
            get { return developer; }
            set { developer = value; }
        }
        [DisplayName("Role Developer")]
        [Required(ErrorMessage = "Role is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Role must be between 2 and 50 characters")]
        public string Role
        {
            get { return roleDev; }
            set { roleDev = value; }
        }
        [DisplayName("BestTool")]
        [Required(ErrorMessage = "Best tool is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Best tool must be between 2 and 50 characters")]
        public string BestTool
        {
            get { return bestTool; }
            set { bestTool = value; }
        }
        [DisplayName("Start")]
        public DateTime Start
        {
            get { return start; }
            set { start = value; }
        }
        [DisplayName("Complete")]
        public DateTime Complete
        {
            get { return end; }
            set { end = value; }
        }
        [DisplayName("Date Working")]
        public DateTime DateWork
        {
            get { return datework; }
            set { datework = value; }
        }
        [DisplayName("Status")]
        [Required(ErrorMessage = "Status is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Status must be between 2 and 50 characters")]
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        [DisplayName("Description")]
        [Required(ErrorMessage = "Description is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Description must be between 2 and 50 characters")]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        [DisplayName("Percent")]
        [Required(ErrorMessage = "Percent is required")]
        public float Percent
        {
            get { return percent; }
            set { percent = value; }
        }
        [DisplayName("Request")]
        [Required(ErrorMessage = "Request is required")]
        [StringLength(500,MinimumLength = 0,ErrorMessage = "Request must be between 2 and 50 characters")]
        public string Request
        {
            get { return request; }
            set { request = value; }
        }
    }
}
