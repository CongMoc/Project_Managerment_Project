using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
namespace Project_1.Views
{
    public partial class RegisterView : Form,ILoginView
    {
        public RegisterView()
        {
            InitializeComponent();
            AssociateAndRaiseEvents();
        }
        
        private void AssociateAndRaiseEvents()
        {
            btnRegister.Click += delegate
            {
                if (txtPassword.Text == txtRetype.Text)
                {
                    Register?.Invoke(this, EventArgs.Empty);
                    if (IsSuccessful)
                    {
                        this.Close();
                        ShowLoginView?.Invoke(this, EventArgs.Empty);
                    }
                    MessageBox.Show(Message);
                }
                else
                {
                    MessageBox.Show("Retype pass and password is not same!!!", "Warning", MessageBoxButtons.OK);
                }
            };
            btnCancel.Click += delegate
            {
                this.Close();
                ShowLoginView?.Invoke(this, EventArgs.Empty);
            };
        }

        private bool issuccessful;
        private bool isedit;
        private string message;
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
        public bool RoleUser;
        public bool role
        {
            get { return RoleUser; }
            set { RoleUser = value; }
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

        public string name
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }
        public string roletool
        {
            get { return cboRole.Text; }
            set { cboRole.Text = value; }
        }

        public event EventHandler Login;
        public event EventHandler ShowLoginView;
        public event EventHandler ShowMainView;
        public event EventHandler Register;
        public event EventHandler ShowRegisterView;
        public event EventHandler ForgotPassword;
        public event EventHandler ShowPassWord;
        public event EventHandler UpdatePassword;
        public event EventHandler ShowUpdatePasswordView;

        private void RegisterView_Load(object sender, EventArgs e)
        {

        }

        private void txtName_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
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

        private void txtRetype_Click(object sender, EventArgs e)
        {
            txtRetype.Text = "";
            txtRetype.UseSystemPasswordChar = true;
        }
        static int countpass = 0;

        private void picSeePass_Click(object sender, EventArgs e)
        {
            if(countpass == 0 )
            {
                txtPassword.UseSystemPasswordChar = false;
                countpass++;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                countpass--;
            }
        }
        static int countretype= 0;
        private void picSeeRetype_Click(object sender, EventArgs e)
        {
            if (countretype == 0)
            {
                txtRetype.UseSystemPasswordChar = false;
                countretype++;
            }
            else
            {
                txtRetype.UseSystemPasswordChar = true;
                countretype--;
            }
        }
    }
}
