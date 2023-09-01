using IBroker.IBrokerService;
using IBroker.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IBroker
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent(); 
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
            IBrokerService.IBrokerServiceClient LoginClient = new IBrokerService.IBrokerServiceClient();
            LoginDetails login = new LoginDetails();
            login.UserName = txtUserName.Text;
            login.Password= txtPassword.Text;

            if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                label2.Text = "Please enter both username and password.";
              //  MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Here you can add your actual validation logic
            // For example, you can check if the username and password match a stored user in a database or a predefined set of credentials.

            else if (txtUserName.Text != "" && txtPassword.Text != "")
            {
              //  login.Status = "Activated";
               // login.Param = "Save";
                string Success = LoginClient.GetLogin(login);
                if (Success == "Activate User")
                {
                    DashBoard d1 = new DashBoard();
                    d1.Show();
                    //Login l1 = new Login();
                   // l1.Hide();
                }
                else
                {
                    label2.Text = "User Not Found...!!";
                }
                
            }
            else
            {
                label2.Text = "Invalid username or password.";
                //MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            try
            {
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            if (txtUserName.Text == "Enter User ID")
            {
                txtUserName.Text = "";
                txtUserName.ForeColor = Color.Black;
            }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void txtUserName_Leave(object sender, EventArgs e)
       {
            try
            {
            txtUserName.BorderStyle = BorderStyle.None;
            if (txtUserName.Text == "")
            {
                txtUserName.Text = "Enter User ID";
                txtUserName.ForeColor = Color.Silver;
            }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            try
            {
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            if (txtPassword.Text == "Enter Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            try
            {
            txtPassword.BorderStyle = BorderStyle.None;
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Enter Password";
                txtPassword.ForeColor = Color.Silver;
            }
            }
             catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                btnHidePass.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void btnHidePass_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btnShowPass.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
