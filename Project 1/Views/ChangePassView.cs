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
    public partial class ChangePassView : Form,ILoginView
    {
        public ChangePassView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnChange.Click += delegate
            {
                if (txtNewPass.Text != "" && txtRetype.Text != "")
                {
                    if (txtNewPass.Text == txtRetype.Text)
                    {
                        UpdatePassword?.Invoke(this, EventArgs.Empty);
                        if (IsSuccessful)
                        {
                            this.Close();
                            if (IsEdit)
                            {
                                ShowLoginView?.Invoke(this, EventArgs.Empty);
                            }
                        }
                        MessageBox.Show(Message);
                    }
                    else
                    {
                        lbMessage.Text = "New Pass is not same Retype Pass";
                    }
                }
                else
                {
                    lbMessage.Text = "New Pass and Retype Pass never null!!!";
                }
            };
        }

        private string Email;
        public string email
        { 
            get { return Email; }
            set { Email = value; }
        }
        public string password 
        { 
            get
            {
                return txtNewPass.Text;
            }
            set { txtNewPass.Text = value; }
        }
        private bool Role;
        public bool role
        {
            get { return Role; }
            set { Role = value; }
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
        private string message;
        public string Message
        { 
            get { return message; }
            set { message = value; }
        }

        public string manager { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string roletool { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler Login;
        public event EventHandler ShowLoginView;
        public event EventHandler ShowMainView;
        public event EventHandler Register;
        public event EventHandler ShowRegisterView;
        public event EventHandler ForgotPassword;
        public event EventHandler ShowPassWord;
        public event EventHandler UpdatePassword;
        public event EventHandler ShowUpdatePasswordView;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtNewPass_Click(object sender, EventArgs e)
        {
            txtNewPass.Text = "";
            txtNewPass.UseSystemPasswordChar = true;
        }

        private void txtRetype_Click(object sender, EventArgs e)
        {
            txtRetype.Text = "";
            txtRetype.UseSystemPasswordChar = true;
        }
        static int count=0;
        private void pictureBoxSeePass_Click(object sender, EventArgs e)
        {
            if(count == 0)
            {
                txtNewPass.UseSystemPasswordChar = false;
                count ++;
            }
            else
            {
                txtNewPass.UseSystemPasswordChar = true;
                count--;
            }
        }
        static int Count = 0;
        private void pictureBoxSeeRetype_Click(object sender, EventArgs e)
        {
            if(Count == 0)
            {
                txtRetype.UseSystemPasswordChar = false;
                Count++;
            }
            else
            {
                txtRetype.UseSystemPasswordChar = true;
                Count--;
            }
        }
        private static ChangePassView instance;
        public static ChangePassView GetInstace()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ChangePassView();
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

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            
        }
    }
}
