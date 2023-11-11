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
    public partial class StatisticalView : Form, IStatisticalView
    {
        public StatisticalView()
        {
            InitializeComponent();
            AssociateAndRaiseEvents();
        }

        private void AssociateAndRaiseEvents()
        {
            btnProject.Click += delegate
            {
                ShowStatisticalProject?.Invoke(this, EventArgs.Empty);
                if(!IsSuccessful)
                {
                    MessageBox.Show(Message,"Warning",MessageBoxButtons.OK);
                }
            };
            btnTask.Click += delegate
            {
                ShowStatisticalTask?.Invoke(this, EventArgs.Empty);
                if (!IsSuccessful)
                {
                    MessageBox.Show(Message, "Warning", MessageBoxButtons.OK);
                }
            };
        }
        private static StatisticalView instance;
        public static StatisticalView GetInstace(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new StatisticalView();
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
        public void SetDataForDataGridView(BindingSource source)
        {
            dgvStatistical.DataSource = source;
        }

        private string message;
        private bool isEdit;
        private bool isSuccessful;
        public string Message
        {
            get { return message; }
            set { message = value; }
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
        public DateTime start
        {
            get { return dtpStart.Value; }
            set { dtpStart.Value = value; }
        }
        public DateTime end
        {
            get { return dtpEnd.Value; }
            set
            {
                dtpEnd.Value = value;
            }
        }
        public string StatusDev 
        {
            get { return cboStatus.Text; }
            set { cboStatus.Text = value; }
        }

        public event EventHandler ShowStatisticalProject;
        public event EventHandler ShowStatisticalTask;
        public event EventHandler ShowStatisticalDeveloper;

        private void cboStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            ShowStatisticalDeveloper?.Invoke(this, EventArgs.Empty);
        }
    }
}
