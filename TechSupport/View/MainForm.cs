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
    /// MainForm class used to display the username of the tech support application
    /// Author: Kim Weible
    /// Version: Spring 2022
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// constructor used to initialize the MainForm class
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// method used to populate the username to MainForm on load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = View.LoginForm.usernameEntry;
        }

        /// <summary>
        /// method used to close the MainForm and open the LoginForm on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            View.LoginForm login = new LoginForm();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// method used to close the application if the x button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
