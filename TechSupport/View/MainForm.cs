using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.View
{
    /// <summary>
    /// MainForm class used to display the username of the tech support application
    /// Author: Kim Weible
    /// Version: Spring 2022
    /// </summary>
    public partial class MainForm : Form
    {
        private LoginForm loginForm;
        private readonly IncidentAddController incidentController;

        /// <summary>
        /// constructor used to initialize the MainForm class
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            incidentController = new IncidentAddController();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = View.LoginForm.usernameEntry;
            RefreshIncidentDataGrid();
        }

        private void LogoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            loginForm = new LoginForm();
            loginForm.Closed += (s, args) => this.Close();
            loginForm.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void RefreshIncidentDataGrid()
        {
            incidentDataGridView.DataSource = null;
            incidentDataGridView.DataSource = this.incidentController.GetAllIncidents();
        }

        private void AddIncidentButton_Click(object sender, EventArgs e)
        {
            using (Form addIncidentDialog = new AddIncidentDialog())
            {
                DialogResult result = addIncidentDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    this.RefreshIncidentDataGrid();
                }
            }
        }

        private void SearchIncidentButton_Click(object sender, EventArgs e)
        {
            using (Form searchIncidentDialog = new SearchIncidentDialog())
            {
                DialogResult result = searchIncidentDialog.ShowDialog();
            }
        }
    }
}
