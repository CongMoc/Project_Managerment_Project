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
    public partial class ManagementTask : Form,ITaskView
    {
        public ManagementTask()
        {
            InitializeComponent();
            AssociateAndRaiseEvents();
            LoadForm?.Invoke(this, EventArgs.Empty);
            tabControl1.TabPages.Remove(tp_ManagementTaskDetail);
        }
        private static ManagementTask instance;
        public static ManagementTask GetInstace()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ManagementTask();
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
        private void AssociateAndRaiseEvents()
        {
            btnAdd.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
            };
            btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                if (!IsEdit)
                {
                    MessageBox.Show(Message, "Warning", MessageBoxButtons.OK);
                }
            };
            btnDelete.Click += delegate
            {
                DialogResult result = MessageBox.Show("Are you sure to delete this task?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    if (IsSuccessful)
                    {
                        LoadForm?.Invoke(this, EventArgs.Empty);
                        MessageBox.Show(Message);
                    }
                }
            };
            txtKeyword.KeyDown += (s, e) =>
            {
                if (e.KeyData == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            btnSearchTask.Click += delegate
            {
                SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            tsbbtnExit.Click += delegate
            {
                LoadForm?.Invoke(this, EventArgs.Empty);
                this.Close();
            };
            tsbbtnMinimize.Click += delegate
            {
                this.WindowState = FormWindowState.Minimized;
            };
        }
        private string IDTask;
        private string IDProject;
        string IDDev { get; set; }
        public string idTask
        {
            get { return IDTask; }
            set { IDTask = value; }
        }
        public string idProject 
        {
            get { return  IDProject; }  
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
            set { dtpStart.Value = value; }
        }
        public DateTime end 
        {
            get { return dtpEnd.Value; }
            set { dtpEnd.Value = value; }
        }
        public string status
        {
            get { return cboStatus.Text; }
            set { cboStatus.Text = value; }
        }
        private bool idEdit;
        private bool isSuccessful;
        public bool IsEdit
        {
            get { return idEdit; }
            set { idEdit = value;}
        }
        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; } 
        }
        public string idDev
        {
            get { return IDDev; }
            set { idDev = value; }
        }
        public string nameDev
        {
            get { return cboDeveloper.Text; }
            set { cboDeveloper.Text = value; }
        }
        private string message;
        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        public string SearchValue
        {
            get { return txtKeyword.Text; }
            set { txtKeyword.Text = value; }
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
        private string Percent;
        public string percent
        {
            get { return Percent; }
            set { Percent = value; } 
        }

        public string request
        {
            get { return txtRequest.Text; }
            set { txtRequest.Text = value; }
        }

        public event EventHandler LoadForm;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler EditEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler SearchEvent;
        public event EventHandler ShowAddTask;

        public void SetdataSourceForComboBox(BindingSource source)
        {
            dgvManagementTask.DataSource = source;  
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ManagementTask_Load(object sender, EventArgs e)
        {
            LoadForm?.Invoke(this, EventArgs.Empty);
        }

        public void SetDataForChart(List<ChartRepository.RevenueByDate> grossRevenueList)
        {
            chartPercentTask.DataSource = grossRevenueList;
            chartPercentTask.Series[0].XValueMember = "Date";
            chartPercentTask.Series[0].YValueMembers = "Percent";
            chartPercentTask.DataBind();
        }

        private void dgvManagementTask_Click(object sender, EventArgs e)
        {
            LoadForm?.Invoke(this, EventArgs.Empty);
        }

        private void pbReloadForm_Click(object sender, EventArgs e)
        {
            LoadForm?.Invoke(this, EventArgs.Empty);
        }
    }
}
