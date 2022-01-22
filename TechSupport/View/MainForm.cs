using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace TechSupport.View
{
    /// <summary>
    /// MainForm class used to display the username of the tech support application
    /// Author: Kim Weible
    /// Version: Spring 2022
    /// </summary>
    public partial class MainForm : Form
    {
        LoginForm loginForm;
        /// <summary>
        /// constructor used to initialize the MainForm class
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = View.LoginForm.usernameEntry;
        }

        private void LogoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (loginForm == null)
            {
                loginForm = new LoginForm();
                FormClosed += LoginForm_FormClosed;
            }
            loginForm.Show(this);  //Show Form assigning this form as the forms owner
            Hide();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginForm = null;  //If form is closed make sure reference is set to null
            Show();
        }
    }
}
