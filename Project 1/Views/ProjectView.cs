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
    public partial class ProjectView : Form,IProjectView
    {
        public ProjectView()
        {
            InitializeComponent();
            EventsProject();
            tabControl1.TabPages.Remove(tabPageProjectDetail);
        }

        private void EventsProject()
        {
            btnAdd.Click += delegate
            {
                AddProject?.Invoke(this, EventArgs.Empty);
            };
            btnTask.Click += delegate
            {
                if (IsEdit)
                {
                    if (Role)
                    {
                        ShowManagementTask?.Invoke(this, EventArgs.Empty);
                    }
                    else
                    {
                        ShowTask?.Invoke(this, EventArgs.Empty);
                    }
                }
                else
                {
                    MessageBox.Show("False!!! Please choose some project...", "Warning", MessageBoxButtons.OK);
                }
            };
            btnDelete.Click += delegate
            {
                var result = MessageBox.Show("Are you sure want to remove this project?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    RemoveProject?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
            btnSaveProject.Click += delegate
            {
                if (dtpStart.Value < dtpComplete.Value)
                {
                    SaveValue?.Invoke(this, EventArgs.Empty);
                    if (IsSuccessful)
                    {
                        tabControl1.TabPages.Add(tabPageProject);
                        tabControl1.TabPages.Remove(tabPageProjectDetail);
                    }
                    MessageBox.Show(Message);
                }
                else
                {
                    MessageBox.Show("Date start must to less than date complete!!!");
                }
            };
            btnCancelProject.Click += delegate
            {
                Cancel?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Add(tabPageProject);
                tabControl1.TabPages.Remove(tabPageProjectDetail);
            };
            btnSearch.Click += delegate
            {
                SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyData == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
        }

        private static ProjectView instance;

        public event EventHandler AddProject;
        public event EventHandler UpdateProject;
        public event EventHandler RemoveProject;
        public event EventHandler SearchEvent;
        public event EventHandler SaveValue;
        public event EventHandler Cancel;
        public event EventHandler ShowManagementTask;
        public event EventHandler StatusEvent;
        public event EventHandler OwnerEvent;
        public event EventHandler LoadProject;
        public event EventHandler ShowTask;
        public event EventHandler LoadDataForChart;

        private string ID;
        public string id
        {
            get { return ID; }
            set { ID = value; } 
        }
        public string nameProject
        {
            get { return txtNameProject.Text; }
            set { txtNameProject.Text = value; }
        }
        private string Manager;
        public string manager
        {
            get { return Manager; }
            set { Manager = value; }
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
        public string percent
        {
            get { return lbPercent.Text; }
            set { lbPercent.Text = value; }
        }
        public string status 
        {
            get { return cboStatusP.Text; }
            set { cboStatusP.Text = value; }
        }
        public string description 
        { 
            get { return txtDescription.Text; }
            set 
            {
                txtDescription.Text = value;
            }
        }
        public string SearchValue
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
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
            get {return isSuccessful; }
            set { isSuccessful = value; }
        }
        private string message;
        public string Message
        {
            get { return message; }
            set { message = value;}
        }
        private bool role;
        public bool Role 
        {
            get { return role; }
            set
            {
                role = value;
                btnAdd.Enabled = value;
                btnTask.Enabled = value;
                btnDelete.Enabled = value; 
                txtDescription.Enabled = value;
                txtNameProject.Enabled = value;
                cboStatusP.Enabled = value;
            }
        }

        public string StatusProject
        {
            get { return cboStatus.Text; } 
            set { cboStatus.Text = value; }
        }
        public string OwnerProject
        {
            get { return cboOwner.Text; }
            set { cboOwner.Text = value; }
        }

        public static ProjectView GetInstace(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProjectView();
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

        public void SetDataForDataGridView(BindingSource ProjectList)
        {
            dgvProject.DataSource = ProjectList;
        }


        private void cboStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            StatusEvent?.Invoke(this, EventArgs.Empty);
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UpdateProject?.Invoke(this, EventArgs.Empty);
            if (IsEdit)
            {
                tabControl1.TabPages.Remove(tabPageProject);
                tabControl1.TabPages.Add(tabPageProjectDetail);
                LoadDataForChart?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show(Message, "Warning", MessageBoxButtons.OK);
            }
        }

        private void ProjectView_Load(object sender, EventArgs e)
        {
            UpdateProject?.Invoke(this, EventArgs.Empty);
        }

        private void cboOwner_SelectedValueChanged(object sender, EventArgs e)
        {
            OwnerEvent?.Invoke(this, EventArgs.Empty);
        }

        private void dgvProject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateProject?.Invoke(this, EventArgs.Empty);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoadProject?.Invoke(this, EventArgs.Empty);
            LoadDataForChart?.Invoke(this, EventArgs.Empty);
        }

        private void chartProject_Click(object sender, EventArgs e)
        {

        }

        public void SetDataForChart(List<ChartRepository.RevenueByDate> chartList)
        {
            chartProject.DataSource = chartList;
            chartProject.Series[0].XValueMember = "Date";
            chartProject.Series[0].YValueMembers = "Percent";
            chartProject.DataBind();
        }

        private void tabPageProjectDetail_Click(object sender, EventArgs e)
        {

        }

        public void SetDateForProcessDeveloper(List<ChartRepository.RevenueByPercent> grossRevenueList)
        {
            
        }
    }
}
