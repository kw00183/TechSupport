using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechSupport.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "Jane" && passwordTextBox.Text == "test1234")
            {
                errorMessageLabel.Text = "";
                View.MainForm main = new MainForm();
                main.Show();
                this.Close();
            }
            else
            {
                errorMessageLabel.Text = "invalid username/password";
                errorMessageLabel.ForeColor = Color.Red;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
