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
    public partial class MainView : Form,IMainView
    {
        private bool enerbal;

        public event EventHandler ShowProject;
        public event EventHandler ShowProfile;
        public event EventHandler ShowTask;
        public event EventHandler ShowExcel;
        public event EventHandler ShowLogin;

        public bool check
        { 
            get { return enerbal; }
            set { enerbal = value; }
        }
        private bool Role;
        public bool role
        {
            get { return Role; }
            set 
            { 
                Role = value;
                tsbbtnStatistical.Enabled = value;
            }
        }
        public string name 
        {
            get;set;
        }

        public MainView()
        {
            InitializeComponent();
            AssociateAndRaiseEvents();
        }

        private void AssociateAndRaiseEvents()
        {
            tsbbtnMain.Click += delegate
            {
                ShowProject?.Invoke(this, EventArgs.Empty);
            };
            tsbbtnProfile.Click += delegate
            {
                ShowProfile?.Invoke(this, EventArgs.Empty);
            };
            tsbbtnTask.Click += delegate
            {
                ShowTask?.Invoke(this, EventArgs.Empty);
            };
            tsbbtnProject.Click += delegate
            {
                ShowProject?.Invoke(this, EventArgs.Empty);
            };
            tsbbtnStatistical.Click += delegate
            {
                ShowExcel?.Invoke(this, EventArgs.Empty);
            };
            tsbbtnLogOut.Click += delegate
            {
                DialogResult result = MessageBox.Show("Do you want to log out Project management?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                    ShowLogin?.Invoke(this, EventArgs.Empty);
                }
            };
            tsbbtnMinimize.Click += delegate
            {
                if (this.WindowState == FormWindowState.Minimized)
                {
                    this.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    this.WindowState = FormWindowState.Minimized;
                }
            };
            tsbbtnMaximize.Click += delegate
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Normal;
                }
                else
                {
                    this.WindowState = FormWindowState.Maximized;
                }
            };
            tsbbtnExit.Click += delegate
            {
                DialogResult result = MessageBox.Show("Do you want to disable Project management?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            };
        }


        private void txtIDBook_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void MainView_Load(object sender, EventArgs e)
        {
            ShowProject?.Invoke(this, EventArgs.Empty);
            if(role)
            {
                tsblbRole.Text = "Manager";
            }
            else
            {
                tsblbRole.Text = "Developer";
            }
        }
    }
}
