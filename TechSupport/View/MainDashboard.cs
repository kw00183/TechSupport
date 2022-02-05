using System;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.View
{
    /// <summary>
    /// class for tabbed dashboard form
    /// Author: Kim Weible
    /// Version: Spring 2022
    /// </summary>
    public partial class MainDashboard : Form
    {
        #region Data members

        public string username;
        private readonly LoginForm loginForm;

        #endregion

        #region Constructors

        /// <summary>
        /// constructor used to initialize the MainDashboard class
        /// </summary>
        /// <param name="form">login form passed to main form</param>
        public MainDashboard(LoginForm form)
        {
            InitializeComponent();
            loginForm = form;
        }

        #endregion

        #region Methods

        /// <summary>
        /// method used to set the username to show on the form
        /// </summary>
        /// <param name="user">username of person logging in</param>
        public void SetUsername(string user)
        {
            username = user;
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = username;
        }

        private void LogoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginForm.LogOut();
            this.Hide();
        }

        private void MainDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        #endregion
    }
}
