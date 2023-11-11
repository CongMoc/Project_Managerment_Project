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
    public partial class TaskView : Form, ITaskView
    {
        public TaskView()
        {
            InitializeComponent();
            AssociateAndRaiseEvents();
            tabControl1.TabPages.Remove(tabPageTaskDetail);
            LoadForm?.Invoke(this,EventArgs.Empty);
            ShowAddTask?.Invoke(this, EventArgs.Empty);
        }

        private void AssociateAndRaiseEvents()
        {
            btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                if (IsEdit)
                {
                    tabControl1.TabPages.Add(tabPageTaskDetail);
                    tabControl1.TabPages.Remove(tabPageTask);
                }
            };
            btnDelete.Click += delegate
            {
                DeleteEvent?.Invoke(this, EventArgs.Empty);
                MessageBox.Show(Message, "Warning", MessageBoxButtons.OK);
            };
            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if(IsSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPageTaskDetail);
                    tabControl1.TabPages.Add(tabPageTask);
                }
                MessageBox.Show(Message, "Warning", MessageBoxButtons.OK);
                LoadForm?.Invoke(this, EventArgs.Empty);
                ShowAddTask?.Invoke(this, EventArgs.Empty);
            };
            txtKeyword.KeyDown += (s, e) =>
            {
                if (e.KeyData == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageTaskDetail);
                tabControl1.TabPages.Add(tabPageTask);
            };
        }

        private static TaskView instance;

        public event EventHandler AddNewEvent;
        public event EventHandler SearchEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler EditEvent;
        public event EventHandler LoadForm;
        public event EventHandler ShowAddTask;
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
        private DateTime Start = DateTime.Now;
        private DateTime Complete = DateTime.Now;
        public DateTime start 
        {
            get { return Start; }
            set { Start = value; }
        }
        public DateTime end
        {
            get { return Complete; }
            set { Complete = value; }
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
            set { isEdit = value; }
        }
        public bool IsSuccessful 
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        private string IDDev;
        public string SearchValue 
        {
            get { return txtKeyword.Text; }
            set { txtKeyword.Text = value; }
        }
        private string message;
        public string Message 
        {
            get { return message; }
            set { message= value; }
        }
        public string nameDev
        {
            get { return cboDeveloper.Text; }
            set { cboDeveloper.Text = value; }
        }
        public string idDev 
        {
            get { return IDDev; }
            set { IDDev= value; }
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
            get { return dtpDateWork.Value; }
            set { dtpDateWork.Value = value; }
        }
        public string percent
        {
            get { return lbPercent.Text; }
            set { lbPercent.Text = value; }
        }
        public string request
        {
            get { return txtRequest.Text; }
            set { txtRequest.Text= value; }
        }

        public static TaskView GetInstace(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new TaskView();
                instance.MdiParent = parentContainer;
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

        public void SetdataSourceForComboBox(BindingSource source)
        {
            dgvTaskList.DataSource = source;
        }

        private void tabPageTask_Click(object sender, EventArgs e)
        {

        }

        private void tabPageTaskDetail_Click(object sender, EventArgs e)
        {

        }

        private void pbReloadForm_Click(object sender, EventArgs e)
        {
            LoadForm?.Invoke(this, EventArgs.Empty);
            ShowAddTask?.Invoke(this, EventArgs.Empty);
        }

        public void SetDataForChart(List<ChartRepository.RevenueByDate> grossRevenueList)
        {
            chartPercentTask.DataSource = grossRevenueList;
            chartPercentTask.Series[0].XValueMember = "Date";
            chartPercentTask.Series[0].YValueMembers = "Percent";
            chartPercentTask.DataBind(); 
        }

        private void dgvTaskList_Click(object sender, EventArgs e)
        {
            ShowAddTask?.Invoke(this, EventArgs.Empty);
        }
    }
}
