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
    /// <summary>
    /// LoginForm class used to check the username and password to access the tech support application
    /// Author: Kim Weible
    /// Version: Spring 2022
    /// </summary>
    public partial class LoginForm : Form
    {
        public static string usernameEntry = "";

        /// <summary>
        /// constructor used to initialize the LoginForm class
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// method used to handle the Login button event logic to check the username and password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "Jane" && passwordTextBox.Text == "test1234")
            {
                usernameEntry = "Jane";
                HideErrorMessage();
                View.MainForm main = new MainForm();
                this.Hide();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                ShowInvalidErrorMessage();
            }
        }

        /// <summary>
        /// method used to clear the error message text from the errorMessageLabel object
        /// </summary>
        private void HideErrorMessage()
        {
            errorMessageLabel.Text = "";
        }

        /// <summary>
        /// method used to control the message and color of text for the errorMessageLabel object
        /// </summary>
        private void ShowInvalidErrorMessage()
        {
            errorMessageLabel.Text = "invalid username/password";
            errorMessageLabel.ForeColor = Color.Red;
        }

        /// <summary>
        /// method used to handle text change event to the usernameTextBox object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            HideErrorMessage();
        }

        /// <summary>
        /// method used to handle text change event to the passwordTextBox object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            HideErrorMessage();
        }

        /// <summary>
        /// method used to close the application if the x button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
