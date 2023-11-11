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
    public partial class ProfileView : Form,IDeveloper
    {
        public ProfileView()
        {
            InitializeComponent();
            AssociateAndRaiseEvents();
            tsbbtnSave.Enabled = false;
        }

        private void AssociateAndRaiseEvents()
        {
            tsbbtnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                if (IsEdit)
                {
                    txtAddress.Enabled = true;
                    txtName.Enabled = true;
                    cboGender.Enabled = true;
                    txtBestTool.Enabled = true;
                    txtPhone.Enabled = true;
                    cboStatus.Enabled = true;
                    tsbbtnSave.Enabled = true;
                }
            };
            tsbbtnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if(isSuccessful)
                {
                    txtAddress.Enabled = false;
                    txtName.Enabled =false;
                    cboGender.Enabled = false;
                    txtBestTool.Enabled = false;
                    txtPhone.Enabled = false;
                    cboStatus.Enabled = false;
                    tsbbtnSave.Enabled = false;
                }
                MessageBox.Show(Message, "Warning", MessageBoxButtons.OK);
            };
            tsbbtnChange.Click += delegate
            {
                ChangePassword?.Invoke(this, EventArgs.Empty);
            };
        }

        public string role
        {
            get { return txtRole.Text; }

            set
            {
                txtRole.Text = value;
                lbRole.Text = value;
            }
        }
        public string bestTool 
        {
            get { return txtBestTool.Text; }
            set { txtBestTool.Text = value; }
        }
        public string gender 
        {
           get { return cboGender.Text; }
            set
            {
                cboGender.Text = value;
            }
        }
        public string email
        {
            get { return txtEmail.Text; }
            set
            {
                txtEmail.Text = value;
            }
        }
        public string status 
        {
            get { return cboStatus.Text; }
            set
            {
                cboStatus.Text = value;
            }
        }
        public string phone 
        {
            get { return txtPhone.Text; }
            set
            {
                txtPhone.Text = value;
            }
        }
        public string address
        {
            get { return txtAddress.Text; }
            set { txtAddress.Text = value; }
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
            get {return isEdit;}
            set
            {
                isEdit = value;
            }
        }
        public bool IsSuccessful 
        {
            get { return isSuccessful; }
            set
            {
                isSuccessful = value;
            }
        }
        public string name
        {
            get { return txtName.Text; }
            set { txtName.Text = value;
                lbUserName.Text = value;
            }
        }

        public event EventHandler ChangePassword;
        public event EventHandler SaveEvent;
        public event EventHandler EditEvent;

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private static ProfileView instance;
        public static ProfileView GetInstace(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProfileView();
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
        private void tsbbtnBack_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
