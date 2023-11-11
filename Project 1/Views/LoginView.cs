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
    public partial class LoginView : Form,ILoginView
    {
        private bool issuccessful;
        private string message;
        private bool isedit;
        public LoginView()
        {
            InitializeComponent();
            Events();
        }

        private void Events()
        {
            //Login
            btnLogin.Click += delegate
            {
                Login?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    this.Hide();
                    ShowMainView?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
                else
                {
                    lbMessage.Text = Message;
                }
            };
            //Register
            lbRegister.Click += delegate
            {
                this.Hide();
                ShowRegisterView?.Invoke(this, EventArgs.Empty);
            };
            //Forgot Password
            lbForgotPass.Click += delegate
            {
                this.Hide();
                ShowPassWord?.Invoke(this, EventArgs.Empty);
            };
        }

        private bool Role;
        public string email 
        { 
            get { return txtEmail.Text; }
            set { txtEmail.Text = value; }
        }
        public string password 
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }
        public bool role
        {
            get { return Role; }
            set { Role = value; }
        }

        public bool IsEdit
        {
            get { return isedit; }
            set { isedit = value; }
        }
        public bool IsSuccessful 
        {
            get { return issuccessful; }
            set { issuccessful = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public string manager { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string roletool { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler Login;
        public event EventHandler ShowMainView;
        public event EventHandler Register;
        public event EventHandler ShowRegisterView;
        public event EventHandler ForgotPassword;
        public event EventHandler ShowPassWord;
        public event EventHandler UpdatePassword;
        public event EventHandler ShowUpdatePasswordView;
        public event EventHandler ShowLoginView;

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Do you want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
            lbMessage.Text = "";
        }
        static int count = 0;
        private void pictureBoxSeePass_Click(object sender, EventArgs e)
        {
            if(count == 0)
            {
                txtPassword.UseSystemPasswordChar = false;
                count++;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                count--;
            }
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtPassword.UseSystemPasswordChar = true;
        }
    }
}
