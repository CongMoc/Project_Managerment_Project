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
    public partial class Re_issuePassView : Form,ILoginView
    {
        public Re_issuePassView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnResetPass.Click += delegate
            {
                ForgotPassword?.Invoke(this, EventArgs.Empty);
                if (IsEdit)
                {
                    this.Close();
                    ShowUpdatePasswordView?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    lbMessage.Text = Message;
                }
            };
            lbLogin.Click += delegate
            {
                this.Close();
                ShowLoginView?.Invoke(this, EventArgs.Empty);
            };
        }

        public string email 
        {
            get
            {
                return txtEmail.Text;
            }
            set { txtEmail.Text = value; }
        }
        public string password { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        private bool isEdit;
        private bool isSuccessful;  
        public bool IsEdit 
        {
            get { return  isEdit; }
            set { isEdit  = value; }
        }
        public bool IsSuccessful
        { 
            get { return isSuccessful; }
            set { isSuccessful  = value; }
        }
        private string message;
        public string Message 
        {
            get { return  message; }
            set { message = value; }
        }
        private bool Role;
        public bool role 
        { 
            get { return  Role; }
            set { Role = value; }
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
    }
}
