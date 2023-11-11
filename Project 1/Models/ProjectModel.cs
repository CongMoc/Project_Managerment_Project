using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;

namespace Project_1.Models
{
    public class ProjectModel
    {
        //Fields
        private int id;
        private string name;
        private DateTime start;
        private DateTime complete;
        private string manager;
        private float percent;
        private string status;
        private string description;
        //Properties
        [DisplayName("ID")]
        public int ID
        {
            get{ return id; }
            set { id = value;}
        }
        [DisplayName("Project")]
        [Required(ErrorMessage = "Project's Name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Project's Name must be between 2 and 50 characters")]
        public string Project
        {
            get { return name; }
            set { name = value; }
        }
        [DisplayName("Start Date")]
        public DateTime Start
        {
            get { return start; }
            set { start = value; }
        }
        [DisplayName("Complete Date")]
        public DateTime Complete
        {
            get { return complete; }
            set { complete = value; }
        }
        [DisplayName("Manager's Name")]
        public string Manager
        {
            get { return manager; }
            set { manager = value; }
        }
        [DisplayName("Percent %")]
        [Required(ErrorMessage = "Percent is required")]
        public float Percent
        {
            get { return percent; }
            set { percent = value; }
        }
        [DisplayName("Status")]
        [Required(ErrorMessage = "Status is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Satus must be between 2 and 50 characters")]
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
    }
}
