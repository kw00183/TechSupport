﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.View
{
    public partial class MainDashboard : Form
    {
        private readonly IncidentController incidentController;
        public string username;
        private readonly LoginForm loginForm;

        /// <summary>
        /// constructor used to initialize the MainDashboard class
        /// </summary>
        /// <param name="form">login form passed to main form</param>
        public MainDashboard(LoginForm form)
        {
            InitializeComponent();
            incidentController = new IncidentController();
            loginForm = form;
        }

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
        //    RefreshIncidentDataGrid();
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

        //private void RefreshIncidentDataGrid()
        //{
        //    incidentDataGridView.DataSource = null;
        //    incidentDataGridView.DataSource = this.incidentController.GetAllIncidents();
        //}

        private void AddIncidentButton_Click(object sender, EventArgs e)
        {
            using (Form addIncidentDialog = new AddIncidentDialog())
            {
                DialogResult result = addIncidentDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                //    this.RefreshIncidentDataGrid();
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
