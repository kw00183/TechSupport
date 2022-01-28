using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private MainForm mainForm;

        /// <summary>
        /// constructor used to initialize the LoginForm class
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "Jane" && passwordTextBox.Text == "test1234")
            {
                usernameEntry = "Jane";
                HideErrorMessage();

                this.Hide();
                mainForm = new MainForm();
                mainForm.Closed += (s, args) => this.Close();
                mainForm.Show();
            }
            else
            {
                ShowInvalidErrorMessage();
            }
        }

        private void HideErrorMessage()
        {
            errorMessageLabel.Text = "";
        }

        private void ShowInvalidErrorMessage()
        {
            errorMessageLabel.Text = "invalid username/password";
            errorMessageLabel.ForeColor = Color.Red;
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            HideErrorMessage();
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            HideErrorMessage();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
