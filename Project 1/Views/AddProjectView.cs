using Project_1.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1.Views
{
    public partial class AddProjectView : Form,IProjectView
    {
        public AddProjectView()
        {
            InitializeComponent();
            AsscociateAndRaiseEvents();
        }

        private void AsscociateAndRaiseEvents()
        {
            tsbbtnExit.Click += delegate
            {
                this.Close();
            };
            btnSaveProject.Click += delegate
            {
                SaveValue?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    this.Close();
                }
                MessageBox.Show(Message, "Warning", MessageBoxButtons.OK);
            };
        }
        private static AddProjectView instance;
        public static AddProjectView GetInstace()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new AddProjectView();
                instance.Dock = DockStyle.Fill;
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

        private string ID;
        public string id 
        {
            get { return ID; }
            set { ID = value; }
        }
        public string nameProject
        {
            get { return txtNameProject.Text; }
            set { txtNameProject.Text =  value; }
        }
        public string manager
        {
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException();
        }
        public DateTime start 
        {
            get { return dtpStart.Value; }
            set { dtpStart.Value = value; }
        }
        public DateTime end
        {
            get { return dtpComplete.Value; } 
            set { dtpComplete.Value = value; }
        }
        private string Percent;
        public string percent
        {
            get { return Percent; }
            set { Percent = value; }
        }
        public string status 
        {
            get { return cboStatusP.Text; }
            set { cboStatusP.Text = value; }
        }
        public string description
        {
            get { return txtDescription.Text; }
            set { txtDescription.Text = value; }
        }
        public string SearchValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string StatusProject 
        {
            get { return cboStatusP.Text; }
            set { cboStatusP.Text = value; }
        }
        public string OwnerProject
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException();
        }
        private string message;
        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        private bool role;
        private bool isEdit;
        private bool isSuccessful;
        public bool Role
        {
            get { return role; }
            set { role = value; } 
        }
        public bool IsEdit 
        {
            get { return isEdit; }
            set { isEdit = value; } 
        }
        public bool IsSuccessful 
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }

        public event EventHandler AddProject;
        public event EventHandler UpdateProject;
        public event EventHandler RemoveProject;
        public event EventHandler SearchEvent;
        public event EventHandler StatusEvent;
        public event EventHandler OwnerEvent;
        public event EventHandler SaveValue;
        public event EventHandler ShowManagementTask;
        public event EventHandler LoadProject;
        public event EventHandler ShowTask;
        public event EventHandler Cancel;
        public event EventHandler LoadDataForChart;

        public void SetDataForChart(List<ChartRepository.RevenueByDate> grossRevenueList)
        {
            throw new NotImplementedException();
        }

        public void SetDataForDataGridView(BindingSource ProjectList)
        {
            throw new NotImplementedException();
        }

        public void SetDateForProcessDeveloper(List<ChartRepository.RevenueByPercent> grossRevenueList)
        {
            throw new NotImplementedException();
        }
    }
}
