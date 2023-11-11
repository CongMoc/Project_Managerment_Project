using Project_1.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1.Views
{
    public partial class AddTaskView : Form,ITaskView
    {
        private string IDTask;
        private string IDProject;
        public string idTask 
        { 
            get { return IDTask; }
            set { IDTask = value; }  
        }
        public string idProject
        {
            get { return IDProject; }
            set { IDProject = value; }
        }
        public string nameTask
        {
            get { return txtNameTask.Text; }
            set { txtNameTask.Text = value; }
        }
        public string nameProject
        {
            get { return txtNameProject.Text; }
            set { txtNameProject.Text = value; }
        }
        public string descriptionTask 
        {
            get { return txtDescription.Text; }
            set { txtDescription.Text = value; }
        }
        public DateTime start
        {
            get { return dtpStart.Value; }
            set {dtpStart.Value = value; }
        }
        public DateTime end 
        {
            get { return dtpEnd.Value; }
            set {dtpEnd.Value = value; }
        }
        public string status
        {
            get { return cboStatus.Text; }
            set { cboStatus.Text = value; }
        }
        private bool isEdit;
        private bool isSuccessful;
        public bool IsEdit
        {
            get { return isEdit; }
            set 
            {
                isEdit = value;
            }
        }
        public string request
        {
            get { return txtRequest.Text; }
            set { txtRequest.Text = value; }
        }
        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        private string IDDev;
        public string idDev
        {
            get { return IDDev; }
            set { IDDev= value; }
        }
        public string nameDev 
        {   
            get { return cboDeveloper.Text; }
            set { cboDeveloper.Text = value; }
        }

        public string SearchValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public string role
        {
            get { return cboRole.Text; }
            set { cboRole.Text = value; } 
        }
        public string bestTool 
        { 
            get { return cboBestTool.Text; }
            set { cboBestTool.Text = value; }
        }

        public DateTime datework
        {
            get;set;
        }
        private string Percent;
        public string percent
        {
            get { return Percent; }
            set { Percent = value; }
        }

        public AddTaskView()
        {
            LoadForm?.Invoke(this, EventArgs.Empty);
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }
        private static AddTaskView instance;
        public static AddTaskView GetInstace()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new AddTaskView();
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler EditEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler SearchEvent;
        public event EventHandler LoadForm;
        public event EventHandler ShowAddTask;

        private void AssociateAndRaiseViewEvents()
        {
            if(!IsEdit)
            {
                txtNameTask.Enabled = true;
                cboBestTool.Enabled = true;
                cboRole.Enabled = true;
                cboDeveloper.Enabled = true;
            }
            else
            {
                txtNameTask.Enabled = false;
                cboBestTool.Enabled = false;
                cboRole.Enabled = false;
                cboDeveloper.Enabled = false;
            }
            tsbbtnMinimize.Click += delegate
            {
                if(this.WindowState == FormWindowState.Normal)
                {
                    this.WindowState = FormWindowState.Minimized;
                }
            };
            tsbbtnExit.Click += delegate
            {
                this.Close();
            };
            btnCancel.Click += delegate
            {
                this.Close();
            };
            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    this.Close();
                }
                MessageBox.Show(Message, "Warning", MessageBoxButtons.OK);
            };
        }

        private void AddTaskView_Load(object sender, EventArgs e)
        {
            cboDeveloper.DisplayMember = "Developer";
            cboBestTool.DisplayMember = "BestTool";
            cboRole.DisplayMember = "Role";
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void SetdataSourceForComboBox(BindingSource source)
        {
            cboDeveloper.DataSource = source;
            cboBestTool.DataSource = source;
            cboRole.DataSource = source;
        }

        public void SetDataForChart(List<ChartRepository.RevenueByDate> grossRevenueList)
        {
            throw new NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
